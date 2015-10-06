var standardForm = function () {
    var _showSecondValue,
        _standardName,
        _geneticLineName,
        _measureUnity,
        _allowDecimal,

    generateChart = function() {
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
                firstSerie.data.push(parseFloat($(item).val()));
            });
            var secondSerie = {
                name: 'Máximo',
                data: []
            }
            $('.item-value.second-value .standard-item-value').each(function (i, item) {
                secondSerie.data.push(parseFloat($(item).val()));
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
                firstSerie.data.push(parseFloat($(item).val()));
            });
            series = [firstSerie];
        }

        $('#chart-container').highcharts({
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
    initialize = function (options) {
        _showSecondValue = options.showSecondValue;
        _standardName = options.standardName;
        _geneticLineName = options.geneticLineName;
        _measureUnity = options.measureUnity;
        _allowDecimal = options.allowDecimal;

        $('.standard-item-value').change(function () {
            if (!$(this).val()) {
                $(this).val(_allowDecimal ? '0,00' : '0');
            }
            generateChart();
        });

        generateChart();
    }

    return {
        initialize: initialize
    };
}();