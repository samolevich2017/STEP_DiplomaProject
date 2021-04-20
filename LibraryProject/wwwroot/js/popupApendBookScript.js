$(document).ready(function () {

    let popupApend = document.getElementById("popup_apendBook");

    
    
    setTimeout(() => { $(".block_btnApendFile").removeClass("hover"); $(".btnEditGenres").css("display", "block");}, 300)
    
    

    // событие клика для кнопки *Отмена*
    $(".btnApendCancel").on("click", function (e) {
        $(".btnEditGenres").css("display", "none");
        popupClose(popupApend);
    });

    // событие наведения курсора мыши на элемент для загрузки файла
    $(".inputApendFile").on("mouseover mouseout", function () {
        $(".block_btnApendFile").toggleClass('hover');
    });
    

    // событие клика по кнопке редактирования жанров (откроет попап с жанрами)
    $(".btnEditGenres").on("click", function () {
        $(".block_genresEdit").addClass("isVisible");
        $(".block_genresEdit_Content").addClass("openListGenres");
    });

    // событие клика по кнопке отмены редактирования жанров
    $(".btnCancelEditGenres").on("click", function (e) {
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
