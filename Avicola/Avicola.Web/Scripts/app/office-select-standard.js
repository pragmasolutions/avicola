var officeAjax = function () {
    var $modal = $("#AddStandardModal"),
        $modalContent = $("#AddStandardModal .modal-content"),
        init = function () {
            $('#btn-add-standard').click(add);
            //$modal.on('submit', 'form', submit);
        },
        add = function () {
            var url = $(this).attr('href');
            loadView(url);
            return false;
        },
        //submit = function () {
        //    var $form = $(this);
        //    var url = $form.attr('action');
        //    var data = $form.serialize();
        //    //Post
        //    $.ajax({
        //        type: "POST",
        //        url: url,
        //        data: data
        //    }).done(submitSuccess);
            
        //    return false;
        //},
        //submitSuccess = function (result) {
        //    if (result.exito) {
        //        $modal.modal('hide').on('hidden.bs.modal', function () {
        //            //Refresh the list.
        //            refreshList();
        //        });
        //    } else {
        //        $modalContent.html(result);
        //        validacion.parse('#MarcasModal');
        //        controles.parse('#MarcasModal');
        //    }
        //},
        //refreshList = function () {
        //    var url = '/Marcas';
        //    maxikioscoSpinner.startSpin();
        //    $("#AdminContainer").load(url, function () {
        //        maxikioscoSpinner.stopSpin();
        //    });
        //},
        //editar = function () {
        //    var url = $(this).attr('href');
        //    cargarVista(url);
        //    return false;
        //},
        //detalle = function () {
        //    var url = $(this).attr('href');
        //    cargarVista(url);
        //    return false;
        //},
        //eliminar = function () {
        //    var url = $(this).attr('href');
        //    cargarVista(url);
        //    return false;
        //},
        loadView = function (url) {
            //maxikioscoSpinner.startSpin();
            $modalContent.load(url, function () {
                //maxikioscoSpinner.stopSpin();
                validation.parse('#AddStandardModal');
                controls.parse('#AddStandardModal');
                $modal.modal();
                //util.focusPrimerElemento($modalContent);
                return false;
            });
        };
    init();
}();