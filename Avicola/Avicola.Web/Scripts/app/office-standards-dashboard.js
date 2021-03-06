﻿var controlPanel = function () {
    var _lastData,

        refresh = function () {
            $.getJSON("/ControlPanel/GetAllActive?random=" + Math.random(), function(data) {
                _lastData = mergeFatalitiesAndDiscarded(data);
                convertFatalitiesToPercentage();
                var height = $(window).height();

                $container = $('.main-container').empty().height(height - 60);

                buildLayout(data.length);

                $container.find('.chart-block').each(function(i, block) {
                    generateChart(data[i], block);
                });

                setTimeout(refresh, 6000 * 4);
            });
        },
        convertFatalitiesToPercentage = function () {
            for (var k = 0; k < _lastData.length; k++) {
                var batch = _lastData[k];

                var standard = $.grep(batch.GeneticLine.Standards, function (x) { return x.Name == 'Mortandad' })[0];
                if (standard) {
                    standard.MeasureUnity = '% aves';
                    var remainingBirds = batch.InitialBirds;
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
            

        }
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
                    $container.append(getContainer(50, 50))
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
                    result += '<span><b style="color: red;">' + Highcharts.numberFormat((value - standardItem.Value2), 2) + ' ' + standard.MeasureUnity + '</b> por encima del máximo óptimo</span>';
                } else {
                    result += '<span><b style="color: red;">' + Highcharts.numberFormat((standardItem.Value1 - value), 2) + ' ' + standard.MeasureUnity + '</b> por debajo del mínimo óptimo</span>';
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
        generateChart = function (batch, container) {
            var weeks = [],
                series = [],
                colors = [],
                availableColors = [
                    '#2f7ed8', '#0d233a', '#8bbc21', '#910000', '#1aadce',
                    '#492970', '#f28f43', '#77a1e5', '#c42525', '#a6c96a'
                ];

            var maxSequence = batch.FirstHalf ? 17 : 120;
            var batchSequence = 0;
            for (var l = 0; l < batch.GeneticLine.Standards.length; l++) {
                var s = batch.GeneticLine.Standards[l];
                for (var m = 0; m < s.StandardItems.length; m++) {
                    var x = s.StandardItems[m];
                    if (x.Sequence > batchSequence) {
                        batchSequence = x.Sequence;
                    }
                }
            }

            if (batchSequence < maxSequence) {
                maxSequence = batchSequence;
            }

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
                    lineWidth: 1,
                    yAxis: standard.YAxis,
                    showInLegend: true
                }

                var items = batch.FirstHalf
                    ? $.grep(standard.StandardItems, function(x) { return x.Sequence < 18; })
                    : $.grep(standard.StandardItems, function(x) { return x.Sequence >= 16; });
                for (var i = 0; i < items.length; i++) {
                    var item = items[i];

                    firstSerie.data.push(item.Value1);

                    var lastNotNullMeasure;
                    if (item.Measures.length > 0) {
                        var sum = 0;
                        for (var k = 0; k < item.Measures.length; k++) {
                            sum += item.Measures[k].Value;
                        }

                        var weekValue = null;
                        if (standard.AggregateOperation == 'AVG') {
                            weekValue = sum / item.Measures.length;
                        } else {
                            weekValue = sum;
                        }
                        lastNotNullMeasure = {
                            x: i,
                            y: weekValue
                        }
                        measureSerie.data.push(lastNotNullMeasure);

                        var maxSequenceTemp = item.Sequence;
                        
                        if (maxSequenceTemp > maxSequence) {
                            maxSequence = maxSequenceTemp;
                        }
                        
                    } else {
                        measureSerie.data.push({
                            x: item.Sequence - 1,
                            y: null
                        });
                    }
                }
                
                if (lastNotNullMeasure != null) {
                    lastNotNullMeasure.dataLabels = {
                        enabled: true,
                        format: standard.Name
                    };
                    lastNotNullMeasure = null;
                }

                series.push(firstSerie);
                colors.push('black');
                
                if ($.grep(measureSerie.data, function (x) { return x.y != null }).length > 0) {
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
                    for (i = 0; i < items.length; i++) {
                        item = items[i];

                        secondSerie.data.push(item.Value2);
                    }
                    series.push(secondSerie);
                    colors.push('black');
                }
            }

            var minSequence = batch.FirstHalf ? 0 : 15;
            for (i = minSequence; i < maxSequence; i++) {
                weeks.push(i + 1);
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
                chart: {
                    type: 'spline'
                },
                colors: colors,
                title: {
                    text: batch.Name,
                    x: -20 //center
                },
                plotOptions: {
                    series: {
                        connectNulls: true,
                        dataLabels : {
                            allowOverlap : true
                        }
                    },
                    marker: {
                        enabled: true
                    },
                    spline: {
                        marker: {
                            enabled: true
                        }
                    }
                },
                subtitle: {
                    text: 'Línea genética: ' + batch.GeneticLine.Name,
                    x: -20
                },
                xAxis: {
                    categories: weeks,
                    //max: maxSequence
                },
                yAxis: yAxis,
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
                    layout: 'vertical',
                    align: 'right',
                    verticalAlign: 'top',
                    y: 25,
                    x: -75,
                    borderWidth: 1,
                    floating: true,
                    backgroundColor: 'gainsboro'
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