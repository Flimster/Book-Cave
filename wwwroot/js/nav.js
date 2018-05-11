$(document).on('click', '.mega-dropdown', function(e) {
    e.stopPropagation();
})

$("#shop-by-replacement").click(function() {
    $("#mega-dropdown-menu").toggleClass("show-or-hide");
    $("#shop-by-replacement").toggleClass("lower-nav-active");
    $("#mega-menu-arrow").toggleClass("glyphicon-chevron-down");
    $("#mega-menu-arrow").toggleClass("glyphicon-chevron-up");
})
