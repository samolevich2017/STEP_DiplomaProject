document.addEventListener("DOMContentLoaded", function () {

    // устанавливаем значения из сессии
    for (let i = 0; i < window.sessionStorage.length; i++) {
        if (window.sessionStorage.key(i) == 'selectYearRange') {
            $(`#${window.sessionStorage.key(i)}`).prop('value', window.sessionStorage.getItem(window.sessionStorage.key(i)));
            $('#loYear').text(window.sessionStorage.getItem(window.sessionStorage.key(i)));
        }

        $(`#${window.sessionStorage.key(i)}`).prop('checked', window.sessionStorage.getItem(window.sessionStorage.key(i)));
    } // for

    if (window.sessionStorage.getItem("sortType") != null) {
        $("#sortType").val(window.sessionStorage.getItem("sortType"));
    }
        
    
});

let slider = document.getElementById("selectYearRange");
let output = document.getElementById("loYear");
let emd = document.getElementById("dotted");
output.innerText = slider.value;

slider.oninput = function () {
    if (this.value === this.max) {
        output.style.display = 'none';
        emd.style.display = 'none';
    } else if (this.value < this.max) {
        output.style.display = 'initial';
        emd.style.display = 'initial';
    }
    output.innerHTML = this.value;
};

// ------------------------------------------- Скрипт отображения фильтра в моб. версиях -------------------------
let filter = document.getElementById("filterBlock"); // сам блок с фильтром

let mobFilterBtn = document.getElementById("mobileFilterBtn");

mobFilterBtn.addEventListener("click", function () {
    $(filter).toggleClass("mobVersFilter");
    filter.animate([{ opacity: "0" }, { opacity: "1" }], { duration: 1200, easing: 'ease-in-out' });
    filter.animate([{ height: "0px" }, { height: "auto" }], { duration: 900, easing: 'ease' });
});

// ------------------------------------------- Скрипт сохранения состояния фильтра в сессии --------------------
$(document).ready(function () {

    $('input[type="checkbox"]').on("change click", function () {
        if ($(this).prop('checked')) {
            window.sessionStorage.setItem(this.id, "true");
        } else {
            window.sessionStorage.removeItem(this.id);
        }
    });

    $('input[type="range"]').on("change click", function () {
        window.sessionStorage.setItem(this.id, this.value);
        
    });

    $("#availStatus").on("change click", function () {
        if ($(this).prop("checked") == false) {
            $(this).val("false");
        }
    });


    // сброс фильтра
    $("#filterResetBtn").on("click", function () {
        
        $("#filterBooks").trigger("reset");
        
        window.sessionStorage.clear();
        window.sessionStorage.setItem("resetFilter", "true");

        $("#filterBooks").submit();

    });
});

// -------------------------------------- Скрипт для сортировки --------------------------------
$(document).ready(function () {
    $("#sortType").on("change", function () {
        window.sessionStorage.setItem("sortType", this.value.toString());
    });
});