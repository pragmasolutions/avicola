var reportesVentasPorCierre = function () {
    var $formRefreshReport = $("#ReportContainer"),
    _lastData,
    init = function () {
        $('#StandardId').attr('disabled', 'disabled');

        $('#BatchStatus').change(getBatches);
        $('#BatchId').change(getBatchStandards);
        avicolaSpinner.stopSpin();
        controls.parse('form');
        
        $('.panel-body').on('submit', 'form', submit);
    },
    getBatches = function() {
        var id = $('#BatchStatus').val();
        $.getJSON('/Report/GetBatches/' + id, function(batches) {
            var $batch = $('#BatchId');
            $batch.html('<option value="">Seleccione Lote</option>');
            for (var i = 0; i < batches.length; i++) {
                $batch.append('<option value="' + batches[i].Id + '">' + batches[i].Name + '</option>');
            }
            $('#StandardId').val('').attr('disabled', 'disabled');
        });
    },
    getBatchStandards = function () {
        var $batch = $('#BatchId');
        var batchId = $batch.val();

        if (batchId != '') {
            $.getJSON('/Report/GetStandards/' + batchId, function (standards) {
                var $standard = $('#StandardId');
                $standard.removeAttr('disabled');
                
                $standard.html('<option value="">Seleccione Estándar</option>');
                for (var i = 0; i < standards.length; i++) {
                    $standard.append('<option value="' + standards[i].Id + '">' + standards[i].Name + '</option>');
                }
                
            });
        } else {
            $('#StandardId').attr('disabled', 'disabled');
        }
        
    },
    submit = function () {
        if ($('#StandardId').val() == '') {
            alert('Por favor complete todos los filtros');
            return false;
        }
        var data = $(this).serialize();
        var url = '/Report/GenerateBatchStandardFollowUp?' + data;

        $.getJSON(url, function (data) {
            _lastData = mergeFatalitiesAndDiscarded(data);
            convertFatalitiesToPercentage();
            generateChart(data);
        });
        return false;
    },
    getDifferences = function (batchName, standardName, week, value) {
        var result = '<br/><br/>';
        var batch = _lastData;
        var standard = $.grep(batch.GeneticLine.Standards, function (x) { return x.Name == standardName })[0];
        var standardItem = $.grep(standard.StandardItems, function (x) { return x.Sequence == week })[0];

        if (standard.ShowSecondValue) {
            if (value >= standardItem.Value1 && value <= standardItem.Value2) {
                result += '<span><b style="color: green;">Dentro del rango óptimo</b></span>';
            } else if (value > standardItem.Value2) {
                result += '<span><b style="color: red;">' + (value - standardItem.Value2) + ' ' + standard.MeasureUnity + '</b> por encima del máximo óptimo</span>';
            } else {
                result += '<span><b style="color: red;">' + (standardItem.Value1 - value) + ' ' + standard.MeasureUnity + '</b> por debajo del mínimo óptimo</span>';
            }
        } else {
            if (value == standardItem.Value1) {
                result += '<span><b style="color: green;">Valor óptimo</b></span>';
            } else if (value > standardItem.Value1) {
                result += '<span><b style="color: red;">' + Highcharts.numberFormat((value - standardItem.Value1), 2) + ' ' + standard.MeasureUnity + '</b> por encima del valor óptimo</span>';
            } else {
                result += '<span><b style="color: red;">' + Highcharts.numberFormat((standardItem.Value1 - value), 2) + ' ' + standard.MeasureUnity + '</b> por debajo del valor óptimo</span>';
            }
        }
        return result;
    },
    generateChart = function (batch) {
        var categories = [],
            series = [],
            colors = [],
            availableColors = [
                '#2f7ed8', '#0d233a', '#8bbc21', '#910000', '#1aadce',
                '#492970', '#f28f43', '#77a1e5', '#c42525', '#a6c96a'
            ];

        for (var j = 0; j < batch.GeneticLine.Standards.length; j++) {
            var color = availableColors.pop();
            var standard = batch.GeneticLine.Standards[j];

            var name = standard.Name + ' (' + standard.MeasureUnity + ')';
            var firstSerie = {
                name: standard.ShowSecondValue ? '[<] ' + name : name,
                data: [],
                dashStyle: 'shortdot',
                lineWidth: 1.5,
                showInLegend: false
            }

            var measureSerie = {
                name: '[*] ' + name,
                data: [],
                lineWidth: 3
            }

            for (var i = 0; i < standard.StandardItems.length; i++) {
                var item = standard.StandardItems[i];

                categories.push(i + 1);
                firstSerie.data.push(item.Value1);

                if (item.Measures.length > 0) {
                    var sum = 0;
                    for (var k = 0; k < item.Measures.length; k++) {
                        sum += item.Measures[k].Value;
                    }
                    if (standard.AggregateOperation == 'AVG') {
                        measureSerie.data.push(sum / item.Measures.length);
                    } else {
                        measureSerie.data.push(sum);
                    }
                } else {
                    measureSerie.data.push(null);
                }
            }
            series.push(firstSerie);
            colors.push(color);

            if ($.grep(measureSerie.data, function (x) { return x != null }).length > 0) {
                series.push(measureSerie);
                colors.push(color);
            }

            if (standard.ShowSecondValue) {

                var secondSerie = {
                    name: '[>] ' + name,
                    data: [],
                    dashStyle: 'shortdot',
                    lineWidth: 1.5,
                    showInLegend: false
                }
                for (i = 0; i < standard.StandardItems.length; i++) {
                    item = standard.StandardItems[i];

                    secondSerie.data.push(item.Value2);
                }
                series.push(secondSerie);
                colors.push(color);
            }
        }


        $('#ReportContainer').highcharts({
            colors: colors,
            title: {
                text: batch.GeneticLine.Standards[0].Name.toUpperCase(),
                x: -20 //center
            },
            subtitle: {
                text: batch.Name,
                x: -20
            },
            xAxis: {
                categories: categories
            },
            yAxis: {
                title: {
                    text: 'Valor'
                },
                plotLines: [
                    {
                        value: 0,
                        width: 1,
                        color: '#808080'
                    }
                ]
            },
            tooltip: {
                formatter: function () {
                    var standard = this.series.name.split('(')[0].trim();
                    var measure = this.series.name.split('(')[1].split(')')[0];

                    var firstPart = 'Semana <b>' + this.x + '</b><br/>' + standard + ': <b>' + Highcharts.numberFormat(this.y, 2) + '</b> ' + measure;

                    if (this.series.name.indexOf('[*]') == -1) {
                        return firstPart;
                    }
                    var batchName = this.series.chart.title.textStr;
                    var standardName = standard.replace('[*] ', '');
                    var secondPart = getDifferences(batchName, standardName, this.x, this.y);
                    return firstPart + secondPart;
                }
            },
            legend: {
                enabled: false
            },
            series: series
        });
    },
    mergeFatalitiesAndDiscarded = function (batch) {
        
        var fatalities = $.grep(batch.GeneticLine.Standards, function (x) { return x.Name == 'Mortandad' })[0];
        var discarded = $.grep(batch.GeneticLine.Standards, function (x) { return x.Name == 'Descarte' })[0];

        if (fatalities && discarded) {
            for (var j = 0; j < discarded.StandardItems.length; j++) {
                var discardedItem = discarded.StandardItems[j];
                var fatalityItem = fatalities.StandardItems[j];

                for (var k = 0; k < discardedItem.Measures.length; k++) {
                    var measure = discardedItem.Measures[k];
                    fatalityItem.Measures.push({ Value: measure.Value });
                }
            }

            batch.GeneticLine.Standards = $.grep(batch.GeneticLine.Standards, function (x) { return x.Name != 'Descarte' });
        }
       
        return batch;
    },
    convertFatalitiesToPercentage = function () {
        var standard = _lastData.GeneticLine.Standards[0];
        if (standard.Name == 'Mortandad') {
            standard.MeasureUnity = '% aves';
            var remainingBirds = _lastData.InitialBirds;
            var acum = 0;
            for (var i = 0; i < standard.StandardItems.length; i++) {
                var item = standard.StandardItems[i];

                var count = 0;
                for (var j = 0; j < item.Measures.length; j++) {
                    var measure = item.Measures[j];
                    count += measure.Value;
                }

                acum += (count * 100) / remainingBirds;

                item.Measures = [
                    {
                        Value: acum
                    }
                ];
                remainingBirds -= count;
            }
        }

    }

    init();
}();