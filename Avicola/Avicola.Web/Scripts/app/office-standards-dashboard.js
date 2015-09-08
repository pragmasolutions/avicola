var controlPanel = function () {
    var _lastData,

        refresh = function () {
            $.getJSON("/ControlPanel/GetAllActive", function (data) {
                _lastData = data;

                var height = $(window).height();
                $container = $('.main-container').empty().height(height - 60);

                buildLayout(data.length);

                $container.find('.chart-block').each(function (i, block) {
                    generateChart(data[i], block);
                });


            });
        },
        buildLayout = function (batchCount) {
            switch (batchCount) {
                case 1:
                    $container.append('<div class="chart-block col-lg-12 height100"><div class="content"></div></div>');
                    break;
                case 2:
                    $container.append('<div class="chart-block col-lg-6 height100"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-6 height100"><div class="content"></div></div>');
                    break;
                case 3:
                    $container.append('<div class="chart-block col-lg-6 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-6 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-12 height50"><div class="content"></div></div>');
                    break;
                case 4:
                    $container.append('<div class="chart-block col-lg-6 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-6 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-6 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-6 height50"><div class="content"></div></div>');
                    break;
                case 5:
                    $container.append('<div class="chart-block col-lg-4 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-4 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-4 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-6 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-6 height50"><div class="content"></div></div>');
                    break;
                case 6:
                    $container.append('<div class="chart-block col-lg-4 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-4 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-4 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-4 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-4 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-4 height50"><div class="content"></div></div>');
                    break;
                case 7:
                    $container.append('<div class="chart-block col-lg-3 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height50"><div class="content"></div></div>');
                    break;
                case 8:
                    $container.append('<div class="chart-block col-lg-3 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height50"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height50"><div class="content"></div></div>');
                    break;
                case 9:
                    $container.append('<div class="chart-block col-lg-4 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-4 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-4 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-4 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-4 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-4 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-4 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-4 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-4 height33"><div class="content"></div></div>');
                    break;
                case 10:
                    $container.append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-6 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-6 height33"><div class="content"></div></div>');
                    break;
                case 11:
                    $container.append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-6 height33"><div class="content"></div></div>');
                    break;
                case 12:
                    $container.append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>')
                        .append('<div class="chart-block col-lg-3 height33"><div class="content"></div></div>');
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
                    borderWidth: 0
                },
                series: series
            });
        };

    return {
        refresh: refresh
    }
}();