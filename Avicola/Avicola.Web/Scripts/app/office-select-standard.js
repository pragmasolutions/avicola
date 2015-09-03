var officeAjax = function () {
    var $modal = $("#AddStandardModal"),
        $modalContent = $("#AddStandardModal .modal-content"),
        init = function () {
            $('#btn-add-standard').click(add);
        },
        add = function () {
            var url = $(this).attr('href');
            loadView(url);
            return false;
        },
        loadView = function (url) {
            $modalContent.load(url, function () {
                validation.parse('#AddStandardModal');
                controls.parse('#AddStandardModal');
                $modal.modal();
                return false;
            });
        };
    init();
}();