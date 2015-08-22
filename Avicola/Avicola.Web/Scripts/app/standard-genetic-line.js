var app = app || {};
app.standards = function() {
    var _geneticLineId;

    return {
        initialize : function(geneticLineId) {
            _geneticLineId = geneticLineId;

            $('#btn-agregar-estandar').click(function () {
                $.getJSON();
            });
        }
    }
}();

