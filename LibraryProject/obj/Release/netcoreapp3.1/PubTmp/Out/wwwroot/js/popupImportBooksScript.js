$(document).ready(function () {
    $("#inputImportFile").on("change", function (e) {

        let popupImport = document.getElementById("popup_importBook");

        // проверка типа загружаемого файла
        var filesExt = ['json']; // массив расширений
        var parts = $(this).val().split('.');
        if (!(filesExt.join().search(parts[parts.length - 1]) !== -1)) {
            alert('Ошибка! Данный тип файлов не поддерживается!');
            return;
        }
        var file = $("#inputImportFile").prop("files")[0];
        let formData = new FormData();
        formData.append("fileImport", file);
        formData.append("statusImportCode", 1);

        if (confirm("Внимание! После нажатия 'Ок', импорт нельзя будет отменить! Если Вы не уверены, нажмите 'Отмена'.")) {
            $.ajax({
                url: "/Admin/AdminImportBooks",
                dataType: 'script',
                cache: false,
                contentType: false,
                processData: false,
                data: formData,
                type: 'post'
            });

            popupClose(popup_importBooks);

            window.location.reload();

            Toast.add({
                text: 'Импорт прошел успешно!',
                color: '#28a745',
                autohide: true,
                delay: 5000
            });

        } else {
            popupClose(popup_importBooks);
            Toast.add({
                text: 'Импорт был отменен!',
                color: '#FF40405',
                autohide: true,
                delay: 5000
            });
        }
        
    });
});