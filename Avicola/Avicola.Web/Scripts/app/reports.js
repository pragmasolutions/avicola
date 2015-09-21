var reportes = function () {
    var $formRefreshReport = $("#FrmRefreshReport"),
        init = function () {

            $("#ButtonsPanel").on('click', 'a.download-report', download);
            
            //Reparse form validation.
            controls.parse('#AdminContainer');
        },
        download = function () {
            //Descargar el reporte con los filtros espedicados
            
            var url = $(this).attr('href');
            var data = $formRefreshReport.serialize();
            url += '&' + data;
            $(this).attr('href', url);
        };

    init();
}();