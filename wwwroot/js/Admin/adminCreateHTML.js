var deleteButtons = [];
var editButtons = [];
var disableButtons = [];

function createBookManagerHTML(books) {
	// Start by emptying the arrays
	deleteButtons = [];
	editButtons = [];

	var linkToCreateBook = createLinkToCreateBookView();

	$("#button").html(linkToCreateBook);
	var bookManagerHTML = "";
	// A list of authors and genres the book contains
	var authors;
	var genres;
	// Objects that are used with the AJAX in admin.js
	var editPair;
	var deletePair;

	for (var i = 0; i < books.length; i++) {
		authors = "";
		genres = "";
		for (var j = 0; j < books[i].authors.length; j++) {
			authors += books[i].authors[j].name + " ";
		}
		for (j = 0; j < books[i].genre.length; j++) {
			genres += books[i].genre[j].name + " ";
		}

		bookManagerHTML +=
			"<div class='col-lg-12 space'>" +
			"<div class='col-lg-3'>" +
			"<img src=" + books[i].image + " alt='no image found' class='image-size'>" +
			"</div>" +
			"<div class='col-lg-6'>" +
			books[i].title + "<br>" +
			authors + "<br>" +
			genres + "<br>" +
			"</div>" +
			"<div class='col-lg-3'>" +
			"<button id='edit" + i + "' class='btn btn-success space'>Edit</button><br>" +
			"<button id='delete" + i + "' class='btn btn-danger book-delete'>Delete</button>" +
			"</div>" +
			"</div>";

		editPair = {
			buttonName: "#edit" + i,
			title: books[i].title,
			id: books[i].id
		};

		deletePair = {
			buttonName: "#delete" + i,
			title: books[i].title,
			id: books[i].id
		};

		editButtons.push(editPair);
		deleteButtons.push(deletePair);
	}
	return bookManagerHTML;
}

function createUserManagerHTML(activeUsers) {
	editButtons = [];
	disableButtons = [];

	var editObject;
	var disableObject;

	var linkToCreateUser = createLinkToCreateUserView();

	$("#button").html(linkToCreateUser);
	var activeUsersHTML = " ";
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
		editObject = {
			buttonName: "#edit" + i,
			name: activeUsers[i].name,
			id: activeUsers[i].id
		};

		disableObject = {
			buttonName: "#disable" + i,
			name: activeUsers[i].name,
			id: activeUsers[i].id
		};
		editButtons.push(editObject);
		disableButtons.push(disableObject);
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