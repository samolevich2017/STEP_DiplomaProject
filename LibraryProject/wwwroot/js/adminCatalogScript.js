document.addEventListener("DOMContentLoaded", function () {

    if (window.sessionStorage.getItem("sortTable") != null) {
        $("#sortTable").val(window.sessionStorage.getItem("sortTable"));
    }

});

$(document).ready(function () {
    $("#sortTable").on("change", function () {
        window.sessionStorage.setItem("sortTable", this.value.toString());
    });

    
});