var controlPanel = function () {
    var _lastData,

        refresh = function () {
            $.getJSON("/ControlPanel/GetAllActive", function (data) {
                _lastData = mergeFatalitiesAndDiscarded(data);

                var height = $(window).height();
                $container = $('.main-container').empty().height(height - 60);

                buildLayout(data.length);

                $container.find('.chart-block').each(function (i, block) {
                    generateChart(data[i], block);
                });


            });
        },
        getContainer = function (width, height) {
            var widthCol = 0;
            switch (width) {
                case 100:
                    widthCol = 12;
                    break;
                case 50:
                    widthCol = 6;
                    break;
                case 33:
                    widthCol = 4;
                    break;
                case 25:
                    widthCol = 3;
                    break;
            }
            var classes = 'col-lg-' + widthCol + ' ' + 'height' + height;
            var $container = $('<div class="chart-block ' + classes + '">');

            var $content = $('<div class="content">');
            $container.append($content);

            return $container;
        },
        buildLayout = function (batchCount) {
            switch (batchCount) {
                case 1:
                    $container.append(getContainer(100, 100));
                    break;
                case 2:
                    $container.append(getContainer(50, 100))
                        .append(getContainer(50, 100));
                    break;
                case 3:
                    $container.append(getContainer(50, 50))
                        .append(getContainer(50, 50))
                        .append(getContainer(100, 50));
                    break;
                case 4:
                    $container.append()
                        .append(getContainer(50, 50))
                        .append(getContainer(50, 50))
                        .append(getContainer(50, 50));
                    break;
                case 5:
                    $container.append(getContainer(33, 50))
                        .append(getContainer(33, 50))
                        .append(getContainer(33, 50))
                        .append(getContainer(50, 50))
                        .append(getContainer(50, 50));
                    break;
                case 6:
                    $container.append(getContainer(33, 50))
                        .append(getContainer(33, 50))
                        .append(getContainer(33, 50))
                        .append(getContainer(33, 50))
                        .append(getContainer(33, 50))
                        .append(getContainer(33, 50));
                    break;
                case 7:
                    $container.append(getContainer(25, 50))
                        .append(getContainer(25, 50))
                        .append(getContainer(25, 50))
                        .append(getContainer(25, 50))
                        .append(getContainer(25, 50))
                        .append(getContainer(25, 50))
                        .append(getContainer(25, 50));
                    break;
                case 8:
                    $container.append(getContainer(25, 50))
                        .append(getContainer(25, 50))
                        .append(getContainer(25, 50))
                        .append(getContainer(25, 50))
                        .append(getContainer(25, 50))
                        .append(getContainer(25, 50))
                        .append(getContainer(25, 50))
                        .append(getContainer(25, 50));
                    break;
                case 9:
                    $container.append(getContainer(33, 33))
                        .append(getContainer(33, 33))
                        .append(getContainer(33, 33))
                        .append(getContainer(33, 33))
                        .append(getContainer(33, 33))
                        .append(getContainer(33, 33))
                        .append(getContainer(33, 33))
                        .append(getContainer(33, 33))
                        .append(getContainer(33, 33));
                    break;
                case 10:
                    $container.append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(50, 33))
                        .append(getContainer(50, 33));
                    break;
                case 11:
                    $container.append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(50, 33));
                    break;
                case 12:
                    $container.append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33))
                        .append(getContainer(25, 33));
                    break;
            }
        },
        
        getDifferences = function (batchName, standardName, week, value) {
            var result = '<br/><br/>';
            var batch = $.grep(_lastData, function (x) { return x.Name == batchName })[0];
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
                    result += '<span><b style="color: red;">' + (value - standardItem.Value1) + ' ' + standard.MeasureUnity + '</b> por encima del valor óptimo</span>';
                } else {
                    result += '<span><b style="color: red;">' + (standardItem.Value1 - value) + ' ' + standard.MeasureUnity + '</b> por debajo del valor óptimo</span>';
                }
            }
            return result;
        },
        generateChart = function (batch, container) {
            var weeks = [],
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
                    showInLegend: false,
                    yAxis: standard.YAxis
                }
                
                var measureSerie = {
                    name: '[*] ' + name,
                    data: [],
                    lineWidth: 3,
                    yAxis: standard.YAxis
                }

                for (var i = 0; i < standard.StandardItems.length; i++) {
                    var item = standard.StandardItems[i];

                    weeks.push(i + 1);
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

                var lastMeasureValue = measureSerie.data[measureSerie.data.length - 1];

                var referenceData = {
                    y: lastMeasureValue,
                    dataLabels: {
                        enabled: true,
                        format: standard.Name
                    }
                }

                measureSerie.data.push(referenceData);

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
                        showInLegend: false,
                        yAxis: standard.YAxis
                    }
                    for (i = 0; i < standard.StandardItems.length; i++) {
                        item = standard.StandardItems[i];

                        secondSerie.data.push(item.Value2);
                    }
                    series.push(secondSerie);
                    colors.push(color);
                }
            }

            var yAxis = [
                {
                    title: {
                        text: 'Valor',
                        style: {
                            color: Highcharts.getOptions().colors[0]
                        }
                    }
                },
                {
                    title: {
                        text: 'Valor 2',
                        style: {
                            color: Highcharts.getOptions().colors[2]
                        }
                    },
                    opposite: true
                }
            ];

            $(container).find('.content').highcharts({
                colors: colors,
                title: {
                    text: batch.Name,
                    x: -20 //center
                },
                subtitle: {
                    text: 'Línea genética: ' + batch.GeneticLine.Name,
                    x: -20
                },
                xAxis: {
                    categories: weeks
                },
                yAxis: yAxis,
                tooltip: {
                    formatter: function () {
                        var standard = this.series.name.split('(')[0].trim();
                        var measure = this.series.name.split('(')[1].split(')')[0];

                        var firstPart = 'Semana <b>' + this.x + '</b><br/>' + standard + ': <b>' + this.y + '</b> ' + measure;

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
                    layout: 'vertical',
                    align: 'right',
                    verticalAlign: 'middle',
                    borderWidth: 0,
                    
                },
                series: series
            });
        },
        mergeFatalitiesAndDiscarded = function(data) {
            for (var i = 0; i < data.length; i++) {
                var batch = data[i];
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

                    batch.GeneticLine.Standards = $.grep(batch.GeneticLine.Standards, function(x) { return x.Name != 'Descarte' });
                }
            }
            return data;
        };

    return {
        refresh: refresh
    }
}();