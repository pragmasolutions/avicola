var standardForm = function () {
    var _showSecondValue,
        _standardName,
        _geneticLineName,
        _measureUnity,
        _allowDecimal,
        _divideWeek,
        _startingWeek,

    buildChart = function (selector, categories, series) {
        $(selector).show();
        $(selector).highcharts({
            title: {
                text: _geneticLineName,
                x: -20 //center
            },
            subtitle: {
                text: 'Standard: ' + _standardName,
                x: -20
            },
            xAxis: {
                categories: categories
            },
            yAxis: {
                title: {
                    text: _standardName + ' (' + _measureUnity + ')'
                },
                plotLines: [{
                    value: 0,
                    width: 1,
                    color: '#808080'
                }]
            },
            tooltip: {
                valueSuffix: ' ' + _measureUnity
            },
            legend: {
                layout: 'vertical',
                align: 'right',
                verticalAlign: 'middle',
                borderWidth: 0
            },
            series: series
        });
    },
    generateCharts = function() {
        var categories = [];
        var series;

        if (_showSecondValue) {
            var firstSerie = {
                name: 'Mínimo',
                data: []
            }
            $('.item-value.first-value .standard-item-value').each(function (i, item) {
                var sequence = parseFloat($(item).closest('tr').find('.item-sequence').html());
                categories.push(sequence);
                firstSerie.data.push(parseFloat($(item).val().replace(',', '.')));
            });
            var secondSerie = {
                name: 'Máximo',
                data: []
            }
            $('.item-value.second-value .standard-item-value').each(function (i, item) {
                secondSerie.data.push(parseFloat($(item).val().replace(',', '.')));
            });
            series = [firstSerie, secondSerie];
        } else {
            firstSerie = {
                name: _standardName,
                data: []
            }
            $('.item-value.first-value .standard-item-value').each(function (i, item) {
                var sequence = parseFloat($(item).closest('tr').find('.item-sequence').html());
                categories.push(sequence);
                firstSerie.data.push(parseFloat($(item).val().replace(',', '.')));
            });
            series = [firstSerie];
        }

        
        if (_startingWeek) {
            categories = $.grep(categories, function (x, i) { return i >= _startingWeek - 1 });
            for (var j = 0; j < series.length; j++) {
                var serie = series[j];
                serie.data = $.grep(serie.data, function (x, i) { return i >= _startingWeek - 1 });
            }
            buildChart('#chart-container', categories, series);
        } else if (_divideWeek) {
            var categories1 = $.grep(categories, function (x, i) { return i < _divideWeek - 1 });
            var categories2 = $.grep(categories, function (x, i) { return i >= _divideWeek - 1 });

            //clono el array
            var series2 = JSON.parse(JSON.stringify(series));

            for (j = 0; j < series.length; j++) {
                serie = series[j];
                serie.data = $.grep(serie.data, function (x, i) { return i < _divideWeek - 1 });
            }

            for (j = 0; j < series2.length; j++) {
                serie = series2[j];
                serie.data = $.grep(serie.data, function (x, i) { return i >= _divideWeek - 1 });
            }

            buildChart('#chart-container', categories1, series);
            buildChart('#second-chart-container', categories2, series2);

        } else {
            buildChart('#chart-container', categories, series);
        }
    },
    
    initialize = function (options) {
        _showSecondValue = options.showSecondValue;
        _standardName = options.standardName;
        _geneticLineName = options.geneticLineName;
        _measureUnity = options.measureUnity;
        _allowDecimal = options.allowDecimal;
        _divideWeek = options.divideWeek;
        _startingWeek = options.startingWeek;

        if (_startingWeek) {
            $.each($('.st-item'), function(i, item) {
                var sequence = $(item).data().sequence;
                if (sequence < _startingWeek) {
                    $(item).hide();
                }
            });
        }

        $('.standard-item-container').show();
        $('.standard-item-value').change(function () {
            if (!$(this).val()) {
                $(this).val(_allowDecimal ? '0,00' : '0');
            }
            generateCharts();
        });

        generateCharts();
    }

    return {
        initialize: initialize
    };
}();