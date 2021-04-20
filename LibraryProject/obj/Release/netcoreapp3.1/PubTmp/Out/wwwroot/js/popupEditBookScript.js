$(document).ready(function () {

    const startFileUrl = $(".block_coverImg>img").attr("src");

    // событие клика для кнопки *Изменить*
    $(".btnEdit").on("click", function () {
        $("input[type='text'], #selectBookYear, textarea").attr("disabled", false);
        $(".tooltip_AboutFile").addClass("tooltip_aboutFileVisible");
        $("input[type='file']").attr("disabled", false);
        $(".btnSaveChanges").attr("disabled", false);
        $("#btnEditGenres").show();
    });

    // событие клика для кнопки *Отмена*
    $(".btnCancel").on("click", function (e) {
        $(".block_coverImg>img").attr("src", startFileUrl);
        $("input[type='text'], #selectBookYear, textarea").attr("disabled", true);
        $(".tooltip_AboutFile").removeClass("tooltip_aboutFileVisible");
        $("input[type='file']").attr("disabled", true);
        $(".btnSaveChanges").attr("disabled", true);
        $("#btnEditGenres").hide();
    });

    // событие наведения курсора мыши на элемент для загрузки файла
    $(".inputFile").on("mouseover mouseout", function () {
        if ($(".tooltip_AboutFile").hasClass("tooltip_aboutFileVisible")) {
            $(".block_btnFile").toggleClass('hover');
            
        }
    });

    // событие клика по кнопке редактирования жанров (откроет попап с жанрами)
    $(".btnEditGenres").on("click", function () {
        $(".block_genresEdit").addClass("isVisible");
        $(".block_genresEdit_Content").addClass("openListGenres");
    });

    // событие клика по кнопке отмены редактирования жанров
    $(".btnCancelEditGenres").on("click", function (e) {
        $(".block_coverImg>img").attr("src", startFileUrl);
        $(".block_genresEdit").removeClass("isVisible");
        $(".block_genresEdit_Content").removeClass("openListGenres");
    });

    // событие клика по черной области (закроет попап с жанрами)
    $(".block_genresEdit").on("click", function (e) {
        closeGenreEditPopup(e);
    });

    // функция для закрытия попапа с жанрами
    function closeGenreEditPopup(e) {
        if (!e.target.closest(".block_genresEdit_Content")) {
            $(".block_genresEdit").removeClass("isVisible");
            $(".block_genresEdit_Content").removeClass("openListGenres");
        } // if
    } // closeGenreEditPopup

});
