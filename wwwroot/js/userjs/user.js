var panels = $(".panel-body");
var userInformation = $(".user-information-box");
var currentPanelSelected = $(".panel-selected");
var currentInformation = $("#user-profile");

panels.on("click", function () {
	currentPanelSelected.removeClass("panel-selected");
	$(this).addClass("panel-selected");
	currentPanelSelected = $(this);
});


// When the user goes to his account this loads his image
// name, email, favouritebook and favourite author
$.get("User/GetProfile", function (data, status) {
	var userProfileHTML =
		"<div class=col-lg-12>" +
		"<div class=col-lg-2>" +
		"<img src=" + data.image + " alt='no image found' width=150px height=200px>" +
		"</div>" +
		"<div class='col-lg-10 profile-info'>" +
		data.name + "<br>" +
		data.email + "<br>" +
		data.favouriteBook + "<br>" +
		data.favouriteAuthor + "<br>" +
		"</div>" +
		"</div>";
	$("#user-box").html(userProfileHTML);
}).fail(function (errorObject) {
	alert("Something went wrong");
});


$("#panel-profile").on("click", function () {
	$.get("User/GetProfile", function (data, status) {
		var userProfileHTML =
			"<div class=col-lg-12>" +
			"<div class=col-lg-2>" +
			"<img src=" + data.image + " alt='no image found' width=150px height=200px>" +
			"</div>" +
			"<div class='col-lg-10 profile-info'>" +
			data.name + "<br>" +
			data.email + "<br>" +
			data.favouriteBook + "<br>" +
			data.favouriteAuthor + "<br>" +
			"</div>" +
			"</div>";
		$("#user-box").html(userProfileHTML);
	}).fail(function (errorObject) {
		alert("Something went wrong");
	});
});

$("#panel-orders").on("click", function () {
	$.get("User/GetOrders", function (data, status) {
		var allOrdersHTML = "";
		var orderInformationHTML = "";
		var orderBookListHTML = "";
		var orderStatus;
		for (var orderNumber = 0; orderNumber < data.length; orderNumber++) {

			if (data[orderNumber].orderStatus === false) {
				orderStatus = "Is shipping";
			} else {
				orderStatus = "Shipped";
			}

			orderInformationHTML +=
				"<div class='col-lg-12 order-information' style=color:grey;>" +
				"<div class='col-lg-12 order-seperator-top'>" +
				"<div class=col-lg-3><strong>Order Placed</strong></div>" +
				"<div class=col-lg-3><strong>Order Id</strong></div>" +
				"<div class=col-lg-3><strong>Order Status</strong></div>" +
				"<div class=col-lg-3><strong>Price</strong></div>" +
				"</div>" +
				"<div class='col-lg-12 order-seperator-bottom'>" +
				"<div class=col-lg-3>" + data[orderNumber].orderPlaced + "</div>" +
				"<div class=col-lg-3>" + data[orderNumber].id + "</div>" +
				"<div class=col-lg-3>" + orderStatus + "</div>" +
				"<div class=col-lg-3>$ " + data[orderNumber].totalPrice + "</div>" +
				"</div>" +
				"</div>";

			for (var bookNumber = 0; bookNumber < data[orderNumber].bookList.length; bookNumber++) {
				orderBookListHTML =
					"<div class='col-lg-12 order-book'>" +
					"<div class=col-lg-3> " +
					"<img src=" + data[orderNumber].bookList[bookNumber].image + " alt=no-image class='order-image'>" +
					"</div>" +
					"<div class=col-lg-6 style=font-size:24px;>" +
					data[orderNumber].bookList[bookNumber].title + "<br><br>" +
					data[orderNumber].bookList[bookNumber].author + "<br><br>" +
					"$ " + data[orderNumber].bookList[bookNumber].price + "<br><br>" +
					"</div>" +
					"<div class=col-lg-3>" +
					"<button class='btn btn-primary'>Track</button><br><br>" +
					"<button class='btn btn-success'>Feedback</button>" +
					"</div>" +
					"</div><hr class='line'>";
				orderInformationHTML += orderBookListHTML;
			}
		}
		$("#user-box").html(orderInformationHTML);
	}).fail(function (errorObject) {
		alert("Something went wrong");
	});
});


$("#panel-wish-list").on("click", function () {
	$.get("User/GetWishList", function (data, status) {
		var wishListHTML = "";
		for (var i = 0; i < data.length; i++) {
			wishListHTML +=
				"<div class=col-lg-12>" +
				"<div class=col-lg-2>" +
				"<img src=" + data[i].image + " alt=no-image-found width=100px height=150px style=margin:5px 0px 5px 0px;>" +
				"</div>" +
				"<div class=col-lg-8>" +
				data[i].title + "<br>" + data[i].author + "<br>" + data[i].genre + "<br>" +
				"</div>" +
				"<div class=col-lg-2> $" +
				data[i].price +
				"</div>" +
				"</div><hr class='line'>";
		}
		$("#user-box").html(wishListHTML);
	}).fail(function (errorObject) {
		alert("Something went wrong");
	});
});

$("#panel-bookshelf").on("click", function () {
	$.get("User/GetBookShelf", function (data, status) {
		var bookshelfHTML = "";
		for (var i = 0; i < data.length; i++) {
			bookshelfHTML +=
				"<div class='col-lg-12'>" +
				"<div class=col-lg-2>" +
				"<img src=" + data[i].image + " alt=no-image-found width=100px height=150px style=margin:5px 0px 5px 0px;>" +
				"</div>" +
				"<div class=col-lg-8>" +
				data[i].title + "<br>" + data[i].author + "<br>" + data[i].genre + "<br>" +
				"</div>" +
				"<div class=col-lg-2> <button class='btn btn-primary' style=margin-top:2px;>Mark as read</button>" +
				"</div>" +
				"</div><hr class='line'>";
		}
		$("#user-box").html(bookshelfHTML);
	}).fail(function (errorObject) {
		alert("Something went wrong");
	});
});

$("#panel-settings").on("click", function () {
	$.get("User/GetSettings", function (data, status) {
		var settingsHTML = 
		"<div class=col-lg-12>" + 
			"<h2> Settings </h2>" +
			"<form method='post'>" +
				"<h3> Notifications </h3>" + 
				"<label for='stuff'>Send emails stuff</label> " +
				"<input type='checkbox' name='stuff' value='stuff'>" +
				"<label for='stuff2'>Send emails about some other stuff</label> " +
				"<input type='checkbox' name='stuff2' value='stuff2'>" +
			"</form>" +
				"<h3> Password </h3>" + 
				"<button type='button' class='btn btn-primary'>Change Password</button>" +
				"<h3> Delete Account </h3>" +
				"<button type='button' class='btn btn-danger'>Delete</button>" +
			"</div>";
		$("#user-box").html(settingsHTML);
	}).fail(function (errorObject) {
		alert("Something went wrong");
	});
});


$("#panel-payment-shipping").on("click", function () {
	$.get("User/GetPaymentAndShipping", function (data, status) {
		paymentAndShippingHTML = 
		"<h2> Payment methods </h2>" +
		"<div class='col-lg-12'>" +
			"<div class='col-lg-2'>Hello world</div>" +
			"<div class='col-lg-2'>Hello world num 2</div>" +
		"</div>" + 
		"<h2> Billing address </h2>" + 
		"<div class='col-lg-12'>" +
			"<div class='col-lg-2'>Hello world</div>" +
			"<div class='col-lg-2'>Hello world num 2</div>" +
		"</div>" + 
		"<h2> Shipping Address </h2>" +
		"<div class='col-lg-12'>" +
			"<div class='col-lg-2'>Hello world</div>" +
			"<div class='col-lg-2'>Hello world num 2</div>" +
		"</div>";
		$("#user-box").html(paymentAndShippingHTML);
	}).fail(function (errorObject) {
		alert("Something went wrong");
	});
});