$("#login").click(function() {
    $("#loginPopup").addClass("ShowOrHidePopup");
});

$("#loginBtn-Popup").click(function() {
    var email = $("#Email-Popup").val();
    var password = $("#Password-Popup").val();
    var rememberMe = $("#RememberMe-Popup").prop('checked');
    var login = { Email: email, Password: password, RememberMe: rememberMe}

    $.ajax({
        type: 'POST',
        url: 'Account/LogIn',
        data: JSON.stringify(login),
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        success: function (resp) {
            console.log(resp);
        },
        error: function (err) {
            console.log(err);
        }
    });
});

$("#reset-password-link").click(function() {
    $("#popup-form-container").empty();;
    $("#popup-form-title").text("Reset password");
    $("#popup-form-container").append(
        '<div class="form-group">' +
            '<label for="reset-password-email"></label>' +
            '<input type="email" id="reset-email" class="form-control" placeholder="Enter email..">' +
        '</div>' +
        '<div class="form-group">' +
            '<button class="btn btn-primary" id="reset-password-btn" onClick="ResetPassword()">Submit</button>' +
        '</div>' 
    );
});

function ResetPassword() {
    var email = $("#reset-email").val();
    var user = { Email: email };

    $.ajax({
        type: 'POST',
        utl: 'Account/ResetPassword',
        data: JSON.stringify(user),
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        success: function (resp) {
            console.log(resp);
        },
        error: function (err) {
            console.log(err);
        }
    })
};