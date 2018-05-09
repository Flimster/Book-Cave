var skipNumOfBooks = 0;

getBookManager(skipNumOfBooks);

$("#admin-manage-books").on("click", function () {
	skipNumOfBooks = 0;
	getBookManager(skipNumOfBooks);
});

$("#admin-users").on("click", function () {
	getUserManager();
});

$("#admin-reports").on("click", function () {
	getReports();
});

$("#prev").on("click", function () {
	if (skipNumOfBooks !== 0) {
		skipNumOfBooks -= 5;
	}
	getBookManager(skipNumOfBooks);
});

$("#next").on("click", function () {
	skipNumOfBooks += 5;
	getBookManager(skipNumOfBooks);
});

function getBookManager(number) {
	$.get("Admin/GetManageBooks", {skip: number},  function (data, status) {
		var bookHTML = createBookManagerHTML(data);
		$("#information").html(bookHTML);
		bindAllBookButtons(editButtons, data, editBook);
		bindAllBookButtons(deleteButtons, data, deleteBook);
	}).fail(function (errorObject) {
		console.log(errorObject);
	});
}

function getUserManager() {
	$.get("Admin/GetUsers", function (data, status) {
		var userHTML = createUserManagerHTML(data);
		$("#information").html(userHTML);
		bindAllUserButtons(editButtons, data, editUser);
		bindAllUserButtons(disableButtons, data, disableUser);
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

function bindAllBookButtons(buttonArray, data, bindFunction) {
	for (var i = 0; i < data.length; i++) {
		bindFunction(buttonArray[i]);
	}
}

function bindAllUserButtons(buttonArray, data, bindFunction) {
	for (var i = 0; i < data.length; i++) {
		bindFunction(buttonArray[i], data[i].name);
	}
}

function deleteBook(button) {
	$(button.buttonName).on("click", function () {
		if (confirm("Are you sure you want to delete the book " + button.title)) {
			$.post("Admin/DeleteBook", button, function () {
				console.log("Could delete book");
			}).fail(function () {
				console.log("Could not delete book");
			});
		}
	});
}

function editBook(button) {
	$(button.buttonName).on("click", function () {
		if (confirm("Are you sure you want to edit " + button.title)) {
			$.post("Admin/EditBook", button, function () {
				console.log("Could edit user");
			}).fail(function () {
				console.log("Could not edit user");
			});
		}
	});
}

function editUser(button) {
	$(button.buttonName).on("click", function () {
		if (confirm("Are you sure you want to edit " + button.name)) {
			$.post("Admin/EditUser", button, function () {
				console.log("Could edit user");
			}).fail(function () {
				console.log("Could not edit user");
			});
		}
	});
}

function disableUser(button) {
	$(button.buttonName).on("click", function () {
		if (confirm("Are you sure you want to disable the user " + button.name)) {
			$.post("Admin/DisableUser", button, function () {
				console.log("Could disable user");
			}).fail(function () {
				console.log("Could not disable user");
			});
		}
	});
}