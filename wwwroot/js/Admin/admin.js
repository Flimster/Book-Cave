getBookManager();

$("#admin-manage-books").on("click", function () {
	getBookManager();
});

$("#admin-users").on("click", function () {
	getUserManager();
});

function getBookManager() {
	$.get("Admin/GetManageBooks", function (data, status) {
		var bookHTML = createBookManagerHTML(data);
		$("#admin-main-box").html(bookHTML);
		bindDeleteButton(data);
	}).fail(function () {
		alert("Something went wrong");
	});
}

function getUserManager() {
	$.get("Admin/GetUsers", function (data, status) {
		var userHTML = createUserManagerHTML(data);
		$("#admin-main-box").html(userHTML);
	}).fail(function () {
		alert("Something went wrong");
	});
}

var idTitlePair;

var array = [];

function createBookManagerHTML(books) {
	var bookManagerHTML =
		"<div class='col-lg-12'>" +
		"<div class='col-lg-6'>" +
		"<button class='btn btn-primary'>Add book</button>" +
		"</div>" +
		"<div class='col-lg-6'>" +
		"<input type='text' name='search' id='search'>" +
		"</div>" +
		"</div><br>" +
		"<hr class='seperator'>";
	for (var i = 0; i < books.length; i++) {
		bookManagerHTML +=
			"<div class='col-lg-12 space'>" +
			"<div class='col-lg-3'>" +
			"<img src=" + books[i].image + " alt='no image found' class='image-size'>" +
			"</div>" +
			"<div class='col-lg-6'>" +
			books[i].title + "<br>" +
			books[i].author + "<br>" +
			books[i].genre + "<br>" +
			"</div>" +
			"<div class='col-lg-3'>" +
			"<button class='btn btn-success space'>Edit</button><br>" +
			"<button id='delete-" + i + "' class='btn btn-danger book-delete'>Delete</button>" +
			"</div>" +
			"</div>";
			idTitlePair = {i: books[i].title};
			array.push(idTitlePair);
	}
	return bookManagerHTML;
}

function createUserManagerHTML(activeUsers) {
	var activeUsersHTML =
		"<div class='col-lg-12'>" +
		"<div class='col-lg-6'>" +
		"<button class='btn btn-primary'>Add book</button>" +
		"</div>" +
		"<div class='col-lg-6'>" +
		"<input type='text' name='search' id='search'>" +
		"</div>" +
		"</div><br>" +
		"<hr class='seperator'>";
	for (var i = 0; i < activeUsers.length; i++) {
		activeUsersHTML +=
			"<div class='col-lg-12 space'>" +
			"<div class='col-lg-3'>" +
			"<img src=" + activeUsers[i].image + " alt='no image found' class='image-size'>" +
			"</div>" +
			"<div class='col-lg-6'>" +
			activeUsers[i].name + "<br>" +
			activeUsers[i].email + "<br>" +
			"</div>" +
			"<div class='col-lg-3'>" +
			"<button class='btn btn-success space'>Edit</button><br>" +
			"<button id='user-disable' class='btn btn-danger'>Disable</button>" +
			"</div>" +
			"</div>";
	}
	return activeUsersHTML;
}

function bindDeleteButton(data) {;
	for (var i = 0; i < data.length; i++){
		console.log(array[i]);
		console.log(idTitlePair.i);
		$("#delete-" + i).on("click", function(){
			alert("Are you sure you want to delete the book " + idTitlePair.i);
		});
	}
}

function deleteBook(title) {
	alert("Are you sure you want to delete the book " + title);
}

function disableUser(user) {
	alert("Are you sure you want to disable this user");
}