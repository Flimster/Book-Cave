var panels = $(".panel-body");
var userInformation = $(".user-information-box");
var currentPanelSelected = $(".panel-selected");
var currentInformation = $("#profile");

panels.on("click", function () {
	currentPanelSelected.removeClass("panel-selected");
	$(this).addClass("panel-selected");
	currentPanelSelected = $(this);
});

$("#panel-profile").on("click", function(){
	currentInformation.addClass("is-hidden");
	currentInformation = $("#profile");
	currentInformation.removeClass("is-hidden");
});

$("#panel-orders").on("click", function(){
	console.log("Went here");
	currentInformation.addClass("is-hidden");
	currentInformation = $("#orders");
	currentInformation.removeClass("is-hidden");
});

$("#panel-wish-list").on("click", function(){
	currentInformation.addClass("is-hidden");
	currentInformation = $("#wishlist");
	currentInformation.removeClass("is-hidden");
});


$("#panel-bookshelf").on("click", function(){
	currentInformation.addClass("is-hidden");
	currentInformation = $("#bookshelf");
	currentInformation.removeClass("is-hidden");
});

$("#panel-settings").on("click", function(){
	currentInformation.addClass("is-hidden");
	currentInformation = $("#settings");
	currentInformation.removeClass("is-hidden");
});

$("#panel-payment-shipping").on("click", function(){
	currentInformation.addClass("is-hidden");
	currentInformation = $("#payment-shipping");
	currentInformation.removeClass("is-hidden");
});

$("#edit-profile").on("click", function(){

});