
if ($(window).width() > 992) {
    $('.side-bar').show();
}
function Open() {
    if ($(window).width() < 992) {
        $('.side-bar').hide();
    }
}

function openNav() {
    $('.side-bar').fadeIn(0);
}

// Ajax Call for Username Forgot Page.
function UsernameAjaxMethod() {
    var user = $("#usernameCheck").val();
    $.ajax({
        type: "POST",
        url: "Login.aspx/UsernameForgotPageMethod",
        data: "{Forgotuser: '" + user + "'}",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            $('.UsernameCheck').fadeOut(function () {
                $('.ContactCheck').fadeIn(700);
            });
        },
        error: function () {
            if (user == "") {
                $('#ErrorUser').text("Username is Empty");
                $('#ErrorUser').css({ 'color': 'red', 'font-weight': 'bold', 'margin-top': '-15px', 'margin-bottom': '20px', 'font-size': '15px' });
                $('#ErrorUser').addClass('animated shake');
                return false;
            }
            else {
                $('#ErrorUser').text("Username is incorrect, if you have forgot your username, you are not able to go forward, you can contact from the Website Owner (+923159382193) regarding you account's unlock.");
                $('#ErrorUser').css({ 'color': 'red', 'font-weight': 'bold', 'margin-top': '-15px', 'margin-bottom': '2', 'font-size': '15px' });
                $('#ErrorUser').addClass('animated shake');
            }
        }
    });
}

// Ajax Call for Username PasswordOne Forgot Page.
function UsernamePasswordCheckAjaxMethod() {
    var user = $("#usernameCheck").val();
    var pwd1 = $('#PasswordOneCheck').val();
    $.ajax({
        type: "POST",
        url: "Login.aspx/UsernameAndPasswordOneCheckForgotPageMethod",
        data: "{userCheck:'" + user + "', pwdCheck:'" + pwd1 + "'}",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function () {
            $('.ContactCheck').fadeOut(function () {
                $('.AllisGood').fadeIn(700);
            });
        },
        error: function () {
            if(pwd1 == "")
            {
                $('#ErrorPwd1').text("Password is Empty");
                $('#ErrorPwd1').css({ 'color': 'red', 'font-weight': 'bold', 'margin-top': '-15px', 'margin-bottom': '20px', 'font-size': '15px' });
                $('#ErrorPwd1').addClass('animated shake');
                return false;
            }
            else
                $('#ErrorPwd1').text("Password is Incorrect");
        }
    });
}

// Ajax Call for username and PasswordTwo Forgot page.
function UsernamePasswordTwoCheckAjaxMethod() {
    var user = $("#usernameCheck").val();
    var pwdTwo = $("#PasswordTwoCheck").val();
    $.ajax({
        type: "POST",
        url: "Login.aspx/UsernameAndPasswordTwoCheckForgotPageMethodAjax",
        data: "{userCheck:'" + user + "', pwdCheck:'" + pwdTwo + "'}",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function () {
            $('.PasswordCheck').fadeOut(function () {
                $('.AllisGood').fadeIn(700);
            });
        },
        error: function () {
            if (pwdTwo == "") {
                $('#ErrorPwd2').text("Password is Empty");
                $('#ErrorPwd2').css({ 'color': 'red', 'font-weight': 'bold', 'margin-top': '-15px', 'margin-bottom': '20px', 'font-size': '15px' });
                $('#ErrorPwd2').addClass('animated shake');
                return false;
            }
            else
                $('#ErrorPwd2').text("Password is Incorrect");
        }
    });
}

// Ajax Call for Username and Security Question Answer Forgot Page.
function UsernameSecurityCheckAjaxMethod() {
    var user = $("#usernameCheck").val();
    var security = $('#Securty').val();
    var answer = $('#AnswerCheck').val();
    $.ajax({
        type: "POST",
        url: "Login.aspx/UsernameAndPasswordTwoCheckForgotPageMethod",
        data: "{userCheck: '" + user + "', security: '" + security + "', answer: '" + answer + "'}",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function () {
            $('.SecurityCheck').fadeOut(function () {
                $('.AllisGood').fadeIn(700);
            });
        },
        error: function () {
            if (security == "Choose Security Question") {
                $('#SecurityError').text("Please select Security Question.");
                $('#SecurityError').css({ 'color': 'red', 'font-weight': 'bold', 'margin-top': '-15px', 'margin-bottom': '20px', 'font-size': '15px' });
                $('#SecurityError').addClass('animated shake');
                return false;
            }
            else if (answer == "") {
                $('#SecurityError').text("Please give Answer.");
                $('#SecurityError').css({ 'color': 'red', 'font-weight': 'bold', 'margin-top': '-15px', 'margin-bottom': '20px', 'font-size': '15px' });
                $('#SecurityError').addClass('animated shake');
                return false;
            }
            else
                $('#SecurityError').text("It is not Correct.");
        }
    });
}

// Ajax Call for Admin Login.
function LoginAjaxMethod() {
    var Myuser = $("#UsernameLogin").val();
    var Mypwd1 = $("#PasswornOneLogin").val();
    var Mypwd2 = $("#PasswordTwoLogin").val();
    $.ajax({
        type: "POST",
        url: "Login.aspx/LoginMethod",
        data: "{user: '"+ Myuser +"', pwd1: '"+Mypwd1+"', pwd2: '"+Mypwd2+"'}",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            window.location = "Dashboard.aspx";
        },
        error: function () {
            if (Myuser == "") {
                $('.ShowMsg').text("Username is Empty");
                $('.ShowMsg').css({ 'color': 'red', 'font-weight': 'bold', 'margin-top': '-15px', 'margin-bottom': '20px', 'font-size': '15px' });
                $('.ShowMsg').addClass('animated shake');
                return false;
            }
            else if (Mypwd1 == "") {
                $('.ShowMsg').text("Password 1 is Empty");
                $('.ShowMsg').css({ 'color': 'red', 'font-weight': 'bold', 'margin-top': '-15px', 'margin-bottom': '20px', 'font-size': '15px' });
                $('.ShowMsg').addClass('animated shake');
                return false;
            }
            else if (Mypwd2 == "") {
                $('.ShowMsg').text("Password 2 is Empty");
                $('.ShowMsg').css({ 'color': 'red', 'font-weight': 'bold', 'margin-top': '-15px', 'margin-bottom': '20px', 'font-size': '15px' });
                $('.ShowMsg').addClass('animated shake');
                return false;
            }
            else
            {
                $('.ShowMsg').hide();
                $('#ErrorMsg').text("Username or Password is incorrect");
            }
        }
    });
}


function displayApproveMessage() {
    $(document).ready(function () {
        $('#alert_approve').show(function () {
            $('#alert_approve').delay(4000).fadeOut(1000);
        });
    });
}


function displayDeleteMessage() {
    $(document).ready(function () {
        $('#alert_delete').show(function () {
            $('#alert_delete').delay(4000).fadeOut(1000);
        });
    });
}

function displayDeleteSuccessMessage() {
    $(document).ready(function () {
        $('#alert_delete').show(function () {
            $('#alert_delete').delay(4000).fadeOut(1000);
        });
    });
}


// Forgot Password Page Hide and Show.
$(document).ready(function () {
    $('.ForgotPassword').click(function () {
        $('.MainPage').fadeOut(function(){
            $('.UsernameCheck').fadeIn(700);
        });
    });

    $('.DontRemember2').click(function () {
        $('.ContactCheck').fadeOut(function () {
            $('.PasswordCheck').fadeIn(700);
        });
    });

    $('.DontRemember3').click(function () {
        $('.PasswordCheck').fadeOut(function () {
            $('.SecurityCheck').fadeIn(700);
        });
    });

    $('.Next').click(function () {
        $('.SecurityCheck').fadeOut(function () {
            $('.Sorry').fadeIn(700);
        });
    });
});


// Account varified in Forgot Page Validation
$(document).ready(function () {
    $('#ForgotPasswordSucceeded').click(function(){
        var pwd1 = $('#NewsPassword1').val();
        var pwd2 = $('#NewsPassword2').val();
        if(pwd1 == "")
        {
            $('#UpdateError').text("Password 1 is Empty");
            $('#UpdateError').css({ 'color': 'red', 'font-weight': 'bold', 'margin-top': '-15px', 'margin-bottom': '20px', 'font-size': '15px' });
            $('#UpdateError').addClass('animated shake');
            return false;
        }
        if (pwd2 == "") {
            $('#UpdateError').text("Password 2 is Empty");
            $('#UpdateError').css({ 'color': 'red', 'font-weight': 'bold', 'margin-top': '-15px', 'margin-bottom': '20px', 'font-size': '15px' });
            $('#UpdateError').addClass('animated shake');
            return false;
        }
        else
            $('#UpdateError').hide();

    });
});

// Admin Profile Page Validation.
$(document).ready(function () {
    $('#AdminProfileUpdate').click(function () {
        var FullName = $('#FullName').val();
        var Title = $('#Title').val();
        var Contact = $('#Contact').val();
        if(FullName == "")
        {
            $('.ErrorMsg').text("*Full Name Field is Required.");
            $('.ErrorMsg').css({'color': 'red', 'font-weight':'bold','margin-bottom':'-5px'});
            return false;
        }
        else if (Title == "") {
            $('.ErrorMsg').text("*Title Field is Required.");
            $('.ErrorMsg').css({'color': 'red', 'font-weight': 'bold', 'margin-bottom': '-5px'});
            return false;
        }
        if (Contact >= 0 || Contact <= 9)
        {}
        else
        {
            $('.ErrorMsg').text("*Contact Number is not in Correct Format.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'margin-bottom': '-5px' });
            return false;
        }
    });
});

// Admin Login Data Change Validation.
$(document).ready(function () {
    $('#AdminLoginUpdate').click(function () {
        var OldUsername= $('#OldUsername').val();
        var OldPasswordOne= $('#OldPasswordOne').val();
        var OldPasswordTwo= $('#OldPasswordTwo').val();
        var NewUsername= $('#NewUsername').val();
        var NewPasswordOne= $('#NewPasswordOne').val();
        var NewPasswordTwo = $('#NewPasswordTwo').val();
        if(OldUsername == "")
        {
            $('.ErrorMsg').text("*Username is Required");
            $('.ErrorMsg').css({ 'color': 'red', 'font-size':'16px', 'font-weight':'bold', 'margin-top':'-10px' });
            return false;
        }
        else if (OldPasswordOne == "") {
            $('.ErrorMsg').text("*Password1 is Required");
            $('.ErrorMsg').css({ 'color': 'red', 'font-size': '16px', 'font-weight': 'bold', 'margin-top': '-10px' });
            return false;
        }
        else if (OldPasswordTwo == "") {
            $('.ErrorMsg').text("*Password2 is Required");
            $('.ErrorMsg').css({ 'color': 'red', 'font-size': '16px', 'font-weight': 'bold', 'margin-top': '-10px' });
            return false;
        }
        else
            $('.ErrorMsg').hide();
        if (NewUsername == "") {
            $('.ErrorMsg1').text("*Username is Required");
            $('.ErrorMsg1').css({ 'color': 'red', 'font-size': '16px', 'font-weight': 'bold', 'margin-top': '-10px' });
            return false;
        }
        else if (NewPasswordOne == "") {
            $('.ErrorMsg1').text("*Password1 is Required");
            $('.ErrorMsg1').css({ 'color': 'red', 'font-size': '16px', 'font-weight': 'bold', 'margin-top': '-10px' });
            return false;
        }
        else if (NewPasswordTwo == "") {
            $('.ErrorMsg1').text("*Password2 is Required");
            $('.ErrorMsg1').css({ 'color': 'red', 'font-size': '16px', 'font-weight': 'bold', 'margin-top': '-10px' });
            return false;
        }
        else
            $('.ErrorMsg1').hide();
    });
});

// Add Another Admin Validation.
$(document).ready(function () {
    $('#InsertAdmin').click(function () {
        var Username = $('#Username').val();
        var PasswordOne = $('#PasswordOne').val();
        var PasswordTwo = $('#PasswordTwo').val();
        var SecurityAnswer = $('#SecurityAnswer').val();
        if(Username == "")
        {
            $('.ErrorMsg').text("*Username is Required.");
            $('.ErrorMsg').css({'color': 'red', 'margin-bottom':'-5px'});
            return false;
        }
        else if (PasswordOne == "") {
            $('.ErrorMsg').text("*Password One is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'margin-bottom': '-5px' });
            return false;
        }
        else if (PasswordTwo == "") {
            $('.ErrorMsg').text("*Password Two is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'margin-bottom': '-5px' });
            return false;
        }
        else if (SecurityAnswer == "") {
            $('.ErrorMsg').text("*Security Answer is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'margin-bottom': '-5px' });
            return false;
        }
        else
            $('.ErrorMsg').hide();
    });
});


