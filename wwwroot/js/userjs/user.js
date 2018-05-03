var panels = $(".panel-body");
var userInformation = $(".user-information-box");
var currentPanelSelected = $(".panel-selected");
var currentInformation = $("#user-profile");

panels.on("click", function () {
	currentPanelSelected.removeClass("panel-selected");
	$(this).addClass("panel-selected");
	currentPanelSelected = $(this);
});

$("#panel-profile").on("click", function(){
	currentInformation.toggleClass("is-hidden");
	$("#user-profile").toggleClass("is-hidden");
	currentInformation = $("#user-profile");
});

$("#panel-orders").on("click", function(){
	currentInformation.toggleClass("is-hidden");
	$("#user-orders").toggleClass("is-hidden");
	currentInformation = $("#user-orders");
});

$("#panel-wish-list").on("click", function(){
	currentInformation.toggleClass("is-hidden");
	$("#user-wish-list").toggleClass("is-hidden");
	currentInformation = $("#user-wish-list");
});

$("#panel-bookshelf").on("click", function(){
	currentInformation.toggleClass("is-hidden");
	$("#user-bookshelf").toggleClass("is-hidden");
	currentInformation = $("#user-bookshelf");
});

$("#panel-settings").on("click", function(){
	currentInformation.toggleClass("is-hidden");
	$("#user-settings").toggleClass("is-hidden");
	currentInformation = $("#user-settings");
});

$("#panel-payment-shipping").on("click", function(){
	currentInformation.toggleClass("is-hidden");
	$("#user-payment-shipping").toggleClass("is-hidden");
	currentInformation = $("#user-payment-shipping");
});