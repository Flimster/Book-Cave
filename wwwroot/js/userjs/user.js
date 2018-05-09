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
	currentInformation.removeClass("is-hidden");
	currentInformation = $("#profile");
	currentInformation.addClass("is-hidden");
});

$("#panel-orders").on("click", function(){
	currentInformation.removeClass("is-hidden");
	currentInformation = $("#orders");
	currentInformation.addClass("is-hidden");
});

$("#panel-wishlist").on("click", function(){
	currentInformation.removeClass("is-hidden");
	currentInformation = $("#wishlist");
	currentInformation.addClass("is-hidden");
});


$("#panel-bookshelf").on("click", function(){
	currentInformation.removeClass("is-hidden");
	currentInformation = $("#bookshelf");
	currentInformation.addClass("is-hidden");
});


function changePanelView(idOfBox){
	idOfBox.addClass("is-hidden");
	currentInformation = idOfBox;
	idOfBox.removeClass("is-hidden");
}



// $.get("User/GetProfile", function (data, status) {
// 	var userProfileHTML = createProfileHTML(data);
// 	$("#user-box").html(userProfileHTML);
// }).fail(function (errorObject) {
// 	console.log(errorObject);
// });


// $("#panel-profile").on("click", function () {
// 	$.get("User/GetProfile", function (data, status) {
// 		var userProfileHTML = createProfileHTML(data);
// 		$("#user-box").html(userProfileHTML);
// 	}).fail(function (errorObject) {
// 		console.log(errorObject);
// 	});
// });

// $("#panel-orders").on("click", function () {
// 	$.get("User/GetOrders", function (data, status) {
// 		var allOrdersHTML = "";
// 		var orderInformationHTML = "";
// 		var orderStatus;
// 		for (var orderNumber = 0; orderNumber < data.length; orderNumber++) {

// 			if (data[orderNumber].orderStatus === false) {
// 				orderStatus = "Is shipping";
// 			} else {
// 				orderStatus = "Shipped";
// 			}
// 			orderInformationHTML += createOrderInformation(data[orderNumber], orderStatus);
// 			orderInformationHTML += createBookHMTL(data[orderNumber].bookList);
// 		}
// 		$("#user-box").html(orderInformationHTML);
// 	}).fail(function () {
// 	});
// });


// $("#panel-wish-list").on("click", function () {
// 	$.get("User/GetWishList", function (data, status) {
// 		var wishListHTML = createWishListHTML(data);
// 		$("#user-box").html(wishListHTML);
// 	}).fail(function () {
// 	});
// });

// $("#panel-bookshelf").on("click", function () {
// 	$.get("User/GetBookShelf", function (data, status) {
// 		var bookshelfHTML = createBookshelfHTML(data);
// 		$("#user-box").html(bookshelfHTML);
// 	}).fail(function () {

// 	});
// });

// $("#panel-settings").on("click", function () {
// 	$.get("User/GetSettings", function (data, status) {
// 		var settingsHTML =
// 			"<div class=col-lg-12>" +
// 			"<h2> Settings </h2>" +
// 			"<form method='post'>" +
// 			"<h3> Notifications </h3>" +
// 			"<div><label for='stuff'>Send emails stuff</label> " +
// 			"<input type='checkbox' name='stuff' value='stuff'></div>" +
// 			"<div><label for='stuff2'>Send emails about some other stuff</label> " +
// 			"<input type='checkbox' name='stuff2' value='stuff2'></div>" +
// 			"</form>" +
// 			"<h3> Password </h3>" +
// 			"<button type='button' class='btn btn-primary'>Change Password</button>" +
// 			"<h3> Delete Account </h3>" +
// 			"<button type='button' class='btn btn-danger'>Delete</button>" +
// 			"</div>";
// 		$("#user-box").html(settingsHTML);
// 	}).fail(function (errorObject) {
// 		console.log(errorObject);

// 	});
// });


// $("#panel-payment-shipping").on("click", function () {
// 	$.get("User/GetPaymentAndShipping", function (data, status) {
// 		// const bingodingo = 'HELLO!';
// 		// `<h2>${bingodingo}

// 		// </h2>`
// 		paymentAndShippingHTML =
// 			"<h2> Payment methods </h2>" +
// 			"<div class='col-lg-12'>" +
// 			"<div class='col-lg-2'>Hello world</div>" +
// 			"<div class='col-lg-2'>Hello world num 2</div>" +
// 			"</div>" +
// 			"<h2> Billing address </h2>" +
// 			"<div class='col-lg-12'>" +
// 			"<div class='col-lg-2'>Hello world</div>" +
// 			"<div class='col-lg-2'>Hello world num 2</div>" +
// 			"</div>" +
// 			"<h2> Shipping Address </h2>" +
// 			"<div class='col-lg-12'>" +
// 			"<div class='col-lg-2'>Hello world</div>" +
// 			"<div class='col-lg-2'>Hello world num 2</div>" +
// 			"</div>";
// 		$("#user-box").html(paymentAndShippingHTML);
// 	}).fail(function (errorObject) {
// 		console.log(errorObject);
// 	});
// });