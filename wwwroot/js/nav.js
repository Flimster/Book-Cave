$(document).on('click', '.mega-dropdown', function(e) {
    e.stopPropagation();
})

$("#mega-menu-arrow").click(function() {
    $("#mega-menu-arrow span").toggleClass("glyphicon-chevron-down");
    $("#mega-menu-arrow span").toggleClass("glyphicon-chevron-up");
});
