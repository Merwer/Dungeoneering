$(".toggle-icon-eye").on("click", function () {
    $(this).children("span").toggleClass("fa-eye fa-eye-slash");
    $(this).closest("tr").toggleClass("info");
});