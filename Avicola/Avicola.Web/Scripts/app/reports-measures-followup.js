var reportesVentasPorCierre = function () {
    var $formRefreshReport = $("#FrmRefreshReport"),
    init = function () {
        $('#StageId').attr('disabled', 'disabled');

        $('#BatchStatus').change(getBatches);
        $('#BatchId').change(getBatchStages);
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
            $('#StageId').val('').attr('disabled', 'disabled');
        });
    },
    getBatchStages = function () {
        var $batch = $('#BatchId');
        var batchId = $batch.val();

        if (batchId != '') {
            $.getJSON('/Report/GetStages/' + batchId, function (stages) {
                var $stage = $('#StageId');
                $stage.removeAttr('disabled');
                
                $stage.html('<option value="">Seleccione Etapa</option>');
                for (var i = 0; i < stages.length; i++) {
                    $stage.append('<option value="' + stages[i].Id + '">' + stages[i].Name + '</option>');
                }
                
            });
        } else {
            $('#StageId').attr('disabled', 'disabled');
        }
        
    },
    submit = function () {

        if (!$formRefreshReport.valid()) {
            return false;
        }

        $('.validation-summary-errors').remove();

        var url = '/Report/GenerateMeasuresFollowUp';
        var data = $formRefreshReport.serialize();
        url += '?' + data;
        $(this).attr('href', url);

        $('#ReporteIframe').attr('src', url);
        return false;
    };

    init();
}();