var deleteButtons = [];
var editButtons = [];
var disableButtons = [];

// TESting

getBookManager();

$("#admin-manage-books").on("click", function () {
	getBookManager();
});

$("#admin-users").on("click", function () {
	getUserManager();
});

$("#admin-reports").on("click", function () {
	getReports();
});

function getBookManager() {
	$.get("Admin/GetManageBooks", function (data, status) {
		var bookHTML = createBookManagerHTML(data);
		$("#information").html(bookHTML);
		bindAllBookButtons(deleteButtons, data, bindDeleteToButton);
		bindAllBookButtons(editButtons, data, bindEditToButton);
	}).fail(function (errorObject) {
		console.log(errorObject);
	});
}

function getUserManager() {
	$.get("Admin/GetUsers", function (data, status) {
		var userHTML = createUserManagerHTML(data);
		$("#information").html(userHTML);
		bindAllUserButtons(editButtons, data, bindEditToButton);
		bindAllUserButtons(disableButtons, data, bindDisableToButton);
	}).fail(function (errorObject) {
		console.log(errorObject);
	});
}

function getReports() {
	$.get("Admin/GetReports", function (data, status) {
		var reportHTML = createReportsHTML(data);
		$("#information").html(reportHTML);
	}).fail(function (errorObject) {
		console.log(errorObject);
	});
}

function createBookManagerHTML(books) {
	deleteButtons = [];
	editButtons = [];
	var linkToCreateBook = createLinkToCreateBookView();
	$("#button").html(linkToCreateBook);
	var bookManagerHTML = "";
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
			"<button id='edit" + i + "' class='btn btn-success space'>Edit</button><br>" +
			"<button id='delete" + i + "' class='btn btn-danger book-delete'>Delete</button>" +
			"</div>" +
			"</div>";
		deleteButtons.push("#delete" + i);
		editButtons.push("#edit" + i);
	}
	return bookManagerHTML;
}

function createUserManagerHTML(activeUsers) {
	editButtons = [];
	disableButtons = [];
	var linkToCreateUser = createLinkToCreateUserView();
	$("#button").html(linkToCreateUser);
	var activeUsersHTML = "<a asp-controller='Home' asp-action='Index'>Hello </a>";
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
			"<button id='edit" + i + "' class='btn btn-success space'>Edit</button><br>" +
			"<button id='disable" + i + "' class='btn btn-danger'>Disable</button>" +
			"</div>" +
			"</div>";
		editButtons.push("#edit" + i);
		disableButtons.push("#disable" + i);
	}
	return activeUsersHTML;
}

function createReportsHTML(reports) {
	var linkToCreateUser = createLinkToCreateUserView();
	$("#button").html(linkToCreateUser);
	var reportHTML = "";
	for (var i = 0; i < reports.length; i++) {
		reportHTML +=
			"<div class='col-lg-12 space'>" +
			"<div class='col-lg-3'>" +
			"<img src=" + reports[i].image + " alt='no image found' class='image-size'>" +
			"</div>" +
			"<div class='col-lg-6'>" +
			reports[i].name + "<br>" +
			reports[i].email + "<br>" +
			reports[i].userGroup + "<br>" +
			reports[i].registrationDate + "<br>" +
			reports[i].lastLoggedInDate + "<br>" +
			"</div>" +
			"<div class='col-lg-3'>" +
			"<button class='btn btn-primary space'>View Report</button><br>" +
			"<h4>(Total reports: " + reports[i].totalReports + ")</h4>" +
			"</div>" +
			"</div>";
	}
	return reportHTML;
}

function createLinkToCreateBookView() {
	var link =
		"<a href='Admin/CreateBook'>" +
		"<button id='add' name='add' class='btn btn-primary'>Add book</button>" +
		"</a>";
	return link;
}

function createLinkToCreateUserView() {
	var link =
		"<a href='Admin/CreateUser'>" +
		"<button id='add' name='add' class='btn btn-primary'>Add user</button>" +
		"</a>";
	return link;
}

function bindAllBookButtons(buttonArray, data, bindFunction) {
	for (var i = 0; i < data.length; i++) {
		bindFunction(buttonArray[i], data[i].title);
	}
}

function bindAllUserButtons(buttonArray, data, bindFunction) {
	for (var i = 0; i < data.length; i++) {
		bindFunction(buttonArray[i], data[i].name);
	}
}

function bindDeleteToButton(button, name) {
	$(button).on("click", function () {
		if (confirm("Are you sure you want to delete the book " + name)) {

		}
	});
}

function bindEditToButton(button, name) {
	$(button).on("click", function () {
		if (confirm("Are you sure you want to edit " + name)) {

		}
	});
}

function bindDisableToButton(button, name) {
	$(button).on("click", function () {
		if (confirm("Are you sure you want to disable the user " + name)) {

		}
	});
}