// function createProfileHTML(data) {
// 	var profileHTML =
// 		"<div id='image-container' class='col-lg-12'>" +
// 		"<img id='profile-image' src=" + data.image + " alt='no image found'>" +
// 		"</div>" +
// 		"<div class='col-lg-12 profile-info'>" +
// 		"<div class='col-lg-4'>" +
// 		data.name +
// 		"</div>" +
// 		"<div class='col-lg-4'></div>" +
// 		"<div class='col-lg-4'>" +
// 		data.email +
// 		"</div>" +
// 		"</div>" +
// 		"<div class='col-lg-12 profile-info'>" +
// 		"<div class='col-lg-4'>" +
// 		data.favouriteBook +
// 		"</div>" +
// 		"<div class='col-lg-4'></div>" +		
// 		"<div class='col-lg-4'>" +
// 		data.favouriteAuthor +
// 		"</div>" +
// 		"</div>";
// 	return profileHTML;
// }

function createOrderInformation(data, orderStatus) {
	orderInformation =
		"<div class='col-lg-12 order-information' style=color:grey;>" +
		"<div class='col-lg-12 order-seperator-top'>" +
		"<div class=col-lg-3><strong>Order Placed</strong></div>" +
		"<div class=col-lg-3><strong>Order Id</strong></div>" +
		"<div class=col-lg-3><strong>Order Status</strong></div>" +
		"<div class=col-lg-3><strong>Price</strong></div>" +
		"</div>" +
		"<div class='col-lg-12 order-seperator-bottom'>" +
		"<div class=col-lg-3>" + data.date + "</div>" +
		"<div class=col-lg-3>" + data.id + "</div>" +
		"<div class=col-lg-3>" + orderStatus + "</div>" +
		"<div class=col-lg-3>$ " + data.price + "</div>" +
		"</div>" +
		"</div>";
	return orderInformation;
}

function createBookHMTL(data) {
	var orderBookListHTML = "";
	var authors;
	for (var bookNumber = 0; bookNumber < data.length; bookNumber++) {
		authors = getAuthorsList(data[bookNumber].authors);
		orderBookListHTML +=
			"<div class='col-lg-12 order-book'>" +
			"<div class=col-lg-3> " +
			"<img src=" + data[bookNumber].image + " alt=no-image class='order-image'>" +
			"</div>" +
			"<div class=col-lg-6 style=font-size:24px;>" +
			data[bookNumber].title + "<br><br>" +
			authors + "<br><br>" +
			"$ " + data[bookNumber].price + "<br><br>" +
			"</div>" +
			"<div class=col-lg-3>" +
			"<button class='btn btn-primary'>Track</button><br><br>" +
			"<button class='btn btn-success'>Feedback</button>" +
			"</div>" +
			"</div><hr class='line'>";
	}
	return orderBookListHTML;
}


function createWishListHTML(data) {
	var wishListHTML = "";
	var authors;
	var genres;
	for (var i = 0; i < data.length; i++) {
		authors = getAuthorsList(data[i].authors);
		genres = getGenresList(data[i].genre);
		wishListHTML +=
			"<div class=col-lg-12>" +
			"<div class=col-lg-2>" +
			"<img src=" + data[i].image + " alt=no-image-found width=100px height=150px style=margin:5px 0px 5px 0px;>" +
			"</div>" +
			"<div class=col-lg-8>" +
			data[i].title + "<br>" +
			authors + "<br>" +
			genres + "<br>" +
			"</div>" +
			"<div class=col-lg-2> $" +
			data[i].price +
			"</div>" +
			"</div><hr class='line'>";
	}
	return wishListHTML;
}

function createBookshelfHTML(data) {
	var bookshelfHTML = "";
	var authors;
	var genres;
	for (var i = 0; i < data.length; i++) {
		authors = getAuthorsList(data[i].authors);
		genres = getGenresList(data[i].genre);
		bookshelfHTML +=
			"<div class='col-lg-12'>" +
			"<div class=col-lg-2>" +
			"<img src=" + data[i].image + " alt=no-image-found width=100px height=150px style=margin:5px 0px 5px 0px;>" +
			"</div>" +
			"<div class=col-lg-8>" +
			data[i].title + "<br>" + authors + "<br>" + genres + "<br>" +
			"</div>" +
			"<div class=col-lg-2> <button class='btn btn-primary' style=margin-top:2px;>Mark as read</button>" +
			"</div>" +
			"</div><hr class='line'>";
	}
	return bookshelfHTML;
}

function getAuthorsList(authorList) {
	var authors = "";
	for (var i = 0; i < authorList.length; i++){
		authors += authorList[i].name + " "; 
	}
	return authors;
}

function getGenresList(genreList) {
	var genres = "";
	for (var i = 0; i < genreList.length; i++){
		genres += genreList[i].name + " "; 
	}
	return genres;
}