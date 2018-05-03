var panels = $(".panel-body");
var currentPanelSelected = $(".panel-selected");

panels.on("click", function (e) {
	currentPanelSelected.removeClass("panel-selected");
	$(this).addClass("panel-selected");
	currentPanelSelected = $(this);
});