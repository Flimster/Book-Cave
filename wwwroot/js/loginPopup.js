$("#login").click(function() {
    $("#loginPopup").addClass("ShowOrHidePopup");
});

$("#loginBtn-Popup").click(function() {
    var email = $("#Email-Popup").val();
    var password = $("#Password-Popup").val();
    var rememberMe = $("#RememberMe-Popup").prop('checked');
    var login = { Email: email, Password: password, RememberMe: rememberMe}
    console.log(login);
    
    //$.post("Account/LogIn", login);
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

/*
$.ajax({
    type: "POST",
    url: "Account/Login",
    data: '{"login"}',
    contentType: "application/json; charset=utf-8", // this
    dataType: "json", // and this
    success: function (msg) {
       //do something
    },
    error: function (errormessage) {
        //do something else
    }
});
*/    
    
});