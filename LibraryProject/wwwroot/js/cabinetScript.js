// меню с пунктами
let tabs = document.getElementById('tabs');

// кнопка для октрытия меню с пунктами профиля
let btnTabs = document.getElementById('btnOpenTabs');

// флаг для определения открыто ли меню, или закрыто
// по умолчанию - закрыто
let flagOpen = false;

// вешаем обработчик события клика на кнопку открытия пунктов меню профиля
$(btnTabs).on("click", function (event) {
    // если меню закрыто, то анимация появления
    // иначе анимауия скрытия
    if (flagOpen === false) {
        $(tabs).removeClass('closeTabsBlock').addClass('openTabsBlock');
        flagOpen = true;
        $(btnTabs).removeClass('btnOpenTabs').addClass('btnCloseTabs');
    } else {
        $(tabs).removeClass("openTabsBlock").addClass('closeTabsBlock');
        flagOpen = false;
        $(btnTabs).removeClass('btnCloseTabs').addClass('btnOpenTabs');
    } // if/else
});

// решение бага
// при скрытии меню табов в мобильной версии, не появлялось меню при больших размерах экрана
window.addEventListener('resize', function (event) {
    if (window.innerWidth > 600) {
        $(tabs).removeClass('closeTabsBlock');
    };
});