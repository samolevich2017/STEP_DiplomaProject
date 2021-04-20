const body = document.querySelector('body');
const lockPadding = document.querySelectorAll('.lock-padding');

let unlock = true;

const  timeout = 800;

let popupEdit = document.getElementById("popup_book");

const popupCloseIcon = document.querySelectorAll('.close-popup');
if(popupCloseIcon.length > 0){
    for(let i = 0; i < popupCloseIcon.length; i++){
       const el = popupCloseIcon[i];
       el.addEventListener('click', function (e) {
           popupClose(el.closest('.popup'));
           e.preventDefault();
       });
    } // for
} // if

function popupOpen(currentPopup) {
    if(currentPopup && unlock){
        const popupActive = document.querySelector('.popup.open');
        if (popupActive){
            popupClose(popupActive, false);
        } else{
           bodyLock();
        }
        currentPopup.classList.add('open');
        currentPopup.addEventListener("click", function (e) {
            if (!e.target.closest('.popup_content')) {
                // проверка, открыт ли внутренний попап для редактирования жанров
                if ($(".block_genresEdit").hasClass("isVisible")) {
                    closeGenreEditPopup(e);
                }
                popupClose(e.target.closest('.popup'));
            } // if
        }); // addEventListener
    }// if
} // popupOpen

function popupClose(popupActive, doUnlock = true) {
    if(unlock){
        popupActive.classList.remove("open");
        if(doUnlock){
            bodyUnlock();
        } // if
    } // if
} // popupClose

function bodyLock() {
    const lockPaddingValue = window.innerWidth - document.querySelector('.content').offsetWidth + 'px';

    if(lockPadding.length > 0){
        for (let i = 0; i < lockPadding.length; i++){
            const el = lockPadding[i];
            el.style.paddingRight = lockPaddingValue;
        } // for
    } // if

    body.style.paddingRight = lockPaddingValue;
    body.classList.add("lock");

    unlock = false;
    setTimeout(function () {
        unlock = true;
    }, timeout);
} // bodyLock

function bodyUnlock(){
    setTimeout(function () {
        if(lockPadding.length > 0){
            for (let i = 0; i < lockPadding.length; i++){
                const el = lockPadding[i];
                el.style.paddingRight = '0px';
            } // for
        } // if
        body.style.paddingRight = '0px';
        body.classList.remove('lock');
    }, timeout);

    unlock = false;
    setTimeout(function () {
       unlock = true;
    }, timeout);
} // bodyUnlock

// функция для закрытия попапа с жанрами
function closeGenreEditPopup(e) {
    if (!e.target.closest(".block_genresEdit_Content")) {
        $(".block_genresEdit").removeClass("isVisible");
        $(".block_genresEdit_Content").removeClass("openListGenres");
    } // if
} // closeGenreEditPopup

document.addEventListener('keydown', function (e) {
    if(e.which === 27){
        const popupActive = document.querySelector('.popup.open');
        popupClose(popupActive);
    } // if
});

$("")
