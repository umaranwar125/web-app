// For Input Field Animation
$(function($){
	$('.field-input').focus(function(){
		$(this).parent().addClass('is-focused has-label');
	});


	$('.field-input').blur(function(){
		
		if($(this).val() == '')
		{
			$(this).parent().removeClass('has-label');
		}
		$(this).parent().removeClass('is-focused');
	});
})


// For Scrolling Animation
$(function(){
	$('a[href*="#"]')
  // Remove links that don't actually link to anything
  .not('[href="#"]')
  .not('[href="#0"]')
  .click(function(event) {
    // On-page links
    if (
      location.pathname.replace(/^\//, '') == this.pathname.replace(/^\//, '') 
      && 
      location.hostname == this.hostname
    ) {
      // Figure out element to scroll to
      var target = $(this.hash);
      target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
      // Does a scroll target exist?
      if (target.length) {
        // Only prevent default if animation is actually gonna happen
        event.preventDefault();
        $('html, body').animate({
          scrollTop: target.offset().top
        }, 1500, function() {
          // Callback after animation
          // Must change focus!
          var $target = $(target);
          $target.focus();
          if ($target.is(":focus")) { // Checking if the target was focused
            return false;
          } else {
            $target.attr('tabindex','-1'); // Adding tabindex for elements not focusable
            $target.focus(); // Set focus again
          };
        });
      }
    }
  });
})

// Wow Animation
$(function(){
  new WOW().init();
})

function displayErrorMessage() {
    $(document).ready(function () {
        $('.alert-danger').show(function () {
            $('.alert-danger').delay(10000).fadeOut(1000);
        });
    });
}

//To Hide and Show Input Fields for Missing People Form.
$(document).ready(function(){
	$('.hide-input').hide();
	$('.contact-hide').hide();
	$('.add-contact').click(function(){
		$('.contact-hide').show(1000);
		$('.add-contact').hide();
	});
	$('.more-info').click(function(){
		$('.hide-input').show(1000);
		$('.more-info').hide();
		$('#form-submit').css({'margin-bottom':'1660px'});
	});
  $('.more-info-about-people').click(function(){
    $('#form-submit').css({'margin-bottom':'1200px'});
  });
});


// Register Page Validation.
$(document).ready(function(){
    $('.btnRegister').click(function () {
        var name = $('#RegisterName').val();
        var username = $('#RegisterUsername').val();
        var email = $('#RegisterEmail').val();
        var password = $('#RegisterPassword').val();
        var confirm = $('#RegisterConfirm').val();
        var contact = $('#RegisterContact').val();
        var age = $('#RegisterAge').val();
        if(name == "")
        {
            $('.ErrorMsg').text("*Name field is required.");
            $('.ErrorMsg').css({'color':'red','letter-spacing':'1px'});
            return false;
        }
        else if (username == "") {
            $('.ErrorMsg').text("*Username field is required.");
            $('.ErrorMsg').css({ 'color': 'red', 'letter-spacing': '1px' });
            return false;
        }
        else if (email == "") {
            $('.ErrorMsg').text("*Email field is required.");
            $('.ErrorMsg').css({ 'color': 'red', 'letter-spacing': '1px' });
            return false;
        }
        else if (password == "") {
            $('.ErrorMsg').text("*Password field is required.");
            $('.ErrorMsg').css({ 'color': 'red', 'letter-spacing': '1px' });
            return false;
        }
        else if (confirm == "") {
            $('.ErrorMsg').text("*Re-enter password field is required.");
            $('.ErrorMsg').css({ 'color': 'red', 'letter-spacing': '1px' });
            return false;
        }
        else if (contact == "") {
            $('.ErrorMsg').text("*Mobile field is required.");
            $('.ErrorMsg').css({ 'color': 'red', 'letter-spacing': '1px' });
            return false;
        }
        else if (age == "") {
            $('.ErrorMsg').text("*Age field is required.");
            $('.ErrorMsg').css({ 'color': 'red', 'letter-spacing': '1px' });
            return false;
        }
        else
            $('.ErrorMsg').hide();
        if(password != confirm)
        {
            $('.ErrorMatching').text("*Password is not match.");
            $('.ErrorMatching').css({ 'color': 'red','margin-top':'8px','letter-spacing':'1px'});
            return false;
        }
        else
            $('.ErrorMatching').hide();
        if (contact >= 0 || contact <= 9) {
        }
        else {
            $('.ErrorNumber').text("*Mobile number is not in correct format.");
            $('.ErrorNumber').css({ 'color': 'red', 'margin-top': '8px', 'letter-spacing': '1px' });
            return false;
        }
        if (age >= 0 || age <= 9) {
        }
        else {
            $('.ErrorNumber').text("*Age is not in correct format.");
            $('.ErrorNumber').css({ 'color': 'red', 'margin-top': '8px', 'letter-spacing': '1px' });
            return false;
        }
    });
});


// Login Page Validation.

$(document).ready(function () {
    $('#LoginClick').click(function () {
        var username = $('#usernameTextbox').val();
        var password = $('#passwordTextbox').val();
        if (username == "") {
            $('#ValidationMsg').show();
            $('#ValidationMsg').text("*Username field is required.");
            return false;
        }
        else if (password == "") {
            $('#ValidationMsg').show();
            $('#ValidationMsg').text("*Password field is required.");
            return false;
        }
        else
            $('#ValidationMsg').hide();
    });
    $('.ForgotPassword').click(function () {
        $('.MainPage').fadeOut(function () {
            $('.UsernameCheck').fadeIn(700);
        });
    });
    $('.DontRemember').click(function () {
        $('.UsernameCheck').fadeOut(function () {
            $('.EmailCheck').fadeIn(700);
        });
    });
    $('.GoBack').click(function () {
        $('.EmailCheck').fadeOut(function () {
            $('.UsernameCheck').fadeIn(700);
        });
    });
    $('.TryAgain').click(function () {
        $('.AdminContact').fadeOut(function () {
            $('.NumberCheck').fadeIn(700);
        });
    });
    $('.LoginForm').click(function () {
        $('.NewPasswordCheck').fadeOut(function () {
            $('.MainPage').fadeIn(700);
        });
    });
    $("#PasswordClick").click(function () {
        var pwd1 = $('#Password1Value').val();
        var pwd2 = $('#Password2Value').val();
        if(pwd1 == "")
        {
            $('#PasswordValidation').text("*New password is required.");
            return false;
        }
        if (pwd2 == "") {
            $('#PasswordValidation').text("*Re-enter password is required.");
            return false;
        }
        if (pwd1 != pwd2) {
            $('#PasswordValidation').text("*Password is not match.");
            return false;
        }
    });

});


function UsernameExistance() {
    $("#UsernameClick").click(function () {
        var Username = $('#UsernameValue').val();
        $.ajax({
            type: "POST",
            url: "Login.aspx/CheckUsernameExistance",
            data: "{username: '" + Username + "'}",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function () {
                $('.UsernameCheck').fadeOut(function () {
                    $('.NumberCheck').fadeIn(700);
                });
            },
            error: function () {
                if (Username == "")
                    $('#UsernameValidation').text("*Username is Required");
                else
                    $('#UsernameValidation').text("Sorry! Username is not exist.");
            }
        })
    });
}

function EmailExistance() {
    $('#EmailClick').click(function () {
        var email = $('#EmailValue').val();
        $.ajax({
            type: "POST",
            url: "Login.aspx/CheckingEmailExistance",
            data: "{email: '" + email + "'}",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function () {
                $('.EmailCheck').fadeOut(function () {
                    $('.NumberCheck').fadeIn(700);
                });
            },
            error: function () {
                if (email == "") {
                    $('#EmailValidation').text("Email is Required.");
                }
                else {
                    $('#EmailValidation').text("Sorry! Email is not Exist.");
                }
            }
        })
    });
}

function NumberExistance() {
    $('#NumberClick').click(function () {
        var email = $('#EmailValue').val();
        var Username = $('#UsernameValue').val();
        var number = $('#NumberValue').val();
        $.ajax({
            type: "POST",
            url: "Login.aspx/CheckingNumberExistance",
            data: "{email: '" + email + "', username: '" + Username + "', number: '" + number + "'}",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function () {
                $('.NumberCheck').fadeOut(function () {
                    $('.NewPasswordCheck').fadeIn(700);
                });
            },
            error: function () {
                if(number == "")
                {
                    $('#NumberValidation').text("Your Registered Number is Required.");
                }
                else
                {
                    $('.NumberCheck').fadeOut(function () {
                        $('.AdminContact').fadeIn(700);
                    });
                }
            }
        })
    });
}

// Missing People Page Validation.
$(document).ready(function () {
    $('#FormSubmit').click(function () {
        var MissingPeopleName = $('#MissingPeopleName').val();
        var MissingPeopleCNIC = $('#MissingPeopleCNIC').val();
        var MissingPeopleGuardianName = $('#MissingPeopleGuardianName').val();
        var MissingPeopleGuardianCNIC = $('#MissingPeopleGuardianCNIC').val();
        var MissingPeopleContactNumber = $('#MissingPeopleNameContact').val();
        var MissingPeopleAnotherContact = $('#MissingPeopleAnotherContact').val();
        var MissingPeoplePermanent = $('#MissingPeoplePermanent').val();
        var MissingPeopleCurrent = $('#MissingPeopleCurrent').val();
        var MissingPeopleLanguage = $('#MissingPeopleLanguage').val();
        var MissingPeopleAge = $('#MissingPeopleAge').val();
        var MissingPeoplePlace = $('#MissingPeoplePlace').val();
        var MissingPeopleDescription = $('#MissingPeopleDescription').val();
        if(MissingPeopleName == "" )
        {
            $('.ErrorMsg').text("*Full Name Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        else if (MissingPeopleGuardianName == "") {
            $('.ErrorMsg').text("*Father/Guardian Name Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        else if (MissingPeopleGuardianCNIC == "") {
            $('.ErrorMsg').text("*Father/Guardian CNIC Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        else if (MissingPeopleContactNumber == "") {
            $('.ErrorMsg').text("*Mobile Number Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        else if (MissingPeoplePermanent == "") {
            $('.ErrorMsg').text("*Permanent Address Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        else if (MissingPeopleCurrent == "") {
            $('.ErrorMsg').text("*Current Address Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        else if (MissingPeopleAge == "") {
            $('.ErrorMsg').text("*Age Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        else if (MissingPeoplePlace == "") {
            $('.ErrorMsg').text("*Missing Place Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        else if (MissingPeopleAge == "") {
            $('.ErrorMsg').text("*Age Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        else if (MissingPeopleDescription == "") {
            $('.ErrorMsg').text("*Description Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        else if (MissingPeopleDescription.length <= 60)
        {
            $('.ErrorLength').text("*Description length must be at least 60 Characters.");
            $('.ErrorLength').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            $('.ErrorMsg').hide();
            return false;
        }
        else
        {
            $('.ErrorMsg').hide();
            $('.ErrorLength').hide();
        }
        if (MissingPeopleCNIC >= 0 || MissingPeopleCNIC <= 9) {
        }
        else {
            $('.ErrorCNIC').text("*CNIC is not in Correct Format.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        if (MissingPeopleGuardianCNIC >= 0 || MissingPeopleGuardianCNIC <= 9) {
        }
        else {
            $('.ErrorCNIC').text("*Father/Guardian CNIC is not in Correct Format.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        if (MissingPeopleContactNumber >= 0 || MissingPeopleContactNumber <= 9) {
        }
        else {
            $('.ErrorCNIC').text("*Mobile Number is not in Correct Format.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        if (MissingPeopleAnotherContact >= 0 || MissingPeopleAnotherContact <= 9) {
        }
        else {
            $('.ErrorCNIC').text("*Mobile Number is not in Correct Format.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        if (MissingPeopleAge >= 0 || MissingPeopleAge <= 9) {
        }
        else {
            $('.ErrorCNIC').text("*Age is not in Correct Format.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
    });
});

// Validation for Contact US PAge.
$(document).ready(function () {
    $('#ContactSubmitButton').click(function () {
        var ContactEmail = $('#ContactEmailAddress').val();
        var COntactMobile = $('#ContactMobile').val();
        var ContactSubject = $('#ContactSubject').val();
        var ContactMessage = $('#ContactMessage').val();
        if (ContactEmail == "") {
            $('.ErrorMsg').text("*Email Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family':'EB Garamond, serif' });
            return false;
        }
        else if (COntactMobile == "") {
            $('.ErrorMsg').text("*Mobile Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (ContactSubject == "") {
            $('.ErrorMsg').text("*Subject Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (ContactMessage == "") {
            $('.ErrorMsg').text("*Message Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else
            $('.ErrorMsg').hide();
        if (COntactMobile >= 0 || COntactMobile <= 9) {
            $('.ErrorMsg').hide();
            return true;
        }
        else {
            $('.ErrorMobile').text("*Mobile Number is not in Correct Format.");
            $('.ErrorMobile').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
    });
});

// Validation for Missing Thing PAge.
$(document).ready(function () {
    $('#MissingThingButton').click(function () {
        var OwnerName = $('#ThingOwnerName').val();
        var OwnerCnic = $('#ThingOwnerCNIC').val();
        var ContactNumber = $('#ThingContact').val();
        var GuardianName = $('#ThingGuardianName').val();
        var GuardianCNIC = $('#ThingGuardianCNIC').val();
        var MissingPlace = $('#ThingMissingPlace').val();
        var Description = $('#ThingDescription').val();
        var CompanyName = $('#AutoCompany').val();
        var BrandName = $('#BrandName').val();
        var EngineNumber = $('#AutoEngine').val();
        var ChassesNumber = $('#AutoChasses').val();
        var Color = $('#Color').val();
        var Model = $('#Model').val();
        var CNICNumber = $('#CNICNumber').val();
        var Familynumber = $('#CNICFamily').val();
        if (OwnerName == "") {
            $('.ErrorMsg').text("*Owner Name is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (OwnerCnic == "") {
            $('.ErrorMsg').text("*Owner CNIC is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (ContactNumber == "") {
            $('.ErrorMsg').text("*Mobile Number is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (GuardianName == "") {
            $('.ErrorMsg').text("*Father/Guardian Name is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (GuardianCNIC == "") {
            $('.ErrorMsg').text("*Father/Guardian CNIC is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (MissingPlace == "") {
            $('.ErrorMsg').text("*Missing Place is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (Description == "") {
            $('.ErrorMsg').text("*Description is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (CompanyName == "") {
            $('.ErrorMsg').text("*Company Name is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (BrandName == "") {
            $('.ErrorMsg').text("*Brand Name is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (EngineNumber == "") {
            $('.ErrorMsg').text("*Engine Number is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (ChassesNumber == "") {
            $('.ErrorMsg').text("*Chasses Number is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (Color == "") {
            $('.ErrorMsg').text("*Color Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (Model == "") {
            $('.ErrorMsg').text("*Model Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (CNICNumber == "") {
            $('.ErrorMsg').text("*CNIC Number is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (Familynumber == "") {
            $('.ErrorMsg').text("*CNIC Family Number is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (Description.length <= 60) {
            $('.ErrorMsg').text("*Description length must be at least 60 Characters.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        else
            $('.ErrorMsg').hide();
        if (ContactNumber >= 0 || ContactNumber <= 9) {
        }
        else {
            $('.ErrorCNIC').text("*Mobile Number is not in Correct Format.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        if (OwnerCnic >= 0 || OwnerCnic <= 9) {
        }
        else {
            $('.ErrorCNIC').text("*Owner CNIC is not in Correct Format.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        if (GuardianCNIC >= 0 || GuardianCNIC <= 9) {
        }
        else {
            $('.ErrorCNIC').text("*Father/Guardian CNIC is not in Correct Format.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
    });
});

// Validation for Unidetified Person Page.
$(document).ready(function () {
    $('#UnidentidiedButton').click(function() {
        var UnidentidiedName = $('#UnidentifiedName').val();
        var UnidentidiedContact = $('#UnidentifiedContact').val();
        var UnidentidiedReligion = $('#UnidentifiedReligion').val();
        var UnidentidiedAge = $('#UnidentifiedAge').val();
        var UnidentidiedFound = $('#UnidentifiedFound').val();
        var UnidentidiedLanguage = $('#UnidentifiedLanguage').val();
        var UnidentidiedCloth = $('#UnidentifiedCloth').val();
        var UnidentidiedDescription = $('#UnidentifiedDescription').val();
        if (UnidentidiedName == "") {
            $('.ErrorMsg').text("*Name is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (UnidentidiedContact == "") {
            $('.ErrorMsg').text("*Mobile Number is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (UnidentidiedReligion == "") {
            $('.ErrorMsg').text("*Religion is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (UnidentidiedFound == "") {
            $('.ErrorMsg').text("*Found Place is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (UnidentidiedLanguage == "") {
            $('.ErrorMsg').text("*Language is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (UnidentidiedCloth == "") {
            $('.ErrorMsg').text("*Cloth Color is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (UnidentidiedDescription == "") {
            $('.ErrorMsg').text("*Description is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (UnidentidiedDescription.length <= 60) {
            $('.ErrorMsg').text("*Description length must be at least 60 Characters.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else
            $('.ErrorMsg').hide();
        if (UnidentidiedContact >= 0 || UnidentidiedContact <= 9) {
        }
        else {
            $('.ErrorCNIC').text("*Mobile Number is not in Correct Format.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        if (UnidentidiedAge >= 0 || UnidentidiedAge <= 9) {
        }
        else {
            $('.ErrorCNIC').text("*Age is not in Correct Format.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
    });
});

// Validation for report A Sighting Page.
$(document).ready(function () {
    $('#ReportSightingButton').click(function () {
        var ReportMissingName = $('#ReportMissingName').val();
        var ReportColor = $('#ReportColor').val();
        var ReportFound = $('#ReportFound').val();
        var ReportCloth = $('#ReportCloth').val();
        var ReportReferenceNumber = $('#ReportReferenceNumber').val();
        var ReportYourName = $('#ReportYourName').val();
        var ReportYourEmail = $('#ReportYourEmail').val();
        var ReportYourMobile = $('#ReportYourMobile').val();
        if (ReportColor == "") {
            $('.ErrorMsg').text("*What was the Color?");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (ReportFound == "") {
            $('.ErrorMsg').text("*Where did you see that?");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (ReportCloth == "") {
            $('.ErrorMsg').text("*What were they Wearing?");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (ReportReferenceNumber == "") {
            $('.ErrorMsg').text("*Please give a Reference Number of that Missing Post.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (ReportYourName == "") {
            $('.ErrorMsg').text("*Your Name is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (ReportYourEmail == "") {
            $('.ErrorMsg').text("*Your Email Address is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (ReportYourMobile == "") {
            $('.ErrorMsg').text("*Your Mobile Number is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else
            $('.ErrorMsg').hide();
        if (ReportYourMobile >= 0 || ReportYourMobile <= 9) {
        }
        else {
            $('.ErrorCNIC').text("*Mobile is not in Correct Format.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
    });
});

// Validation for report A Sighting Page.
$(document).ready(function () {
    $('#SearchButton').click(function () {
        var Name = $('#Name').val();
        var GuardianName = $('#GuardianName').val();
        var Contact = $('#Contact').val();
        if (Name == "") {
            $('#ErrorEmpty').text("*Full Name is Required.");
            $('#ErrorEmpty').css({ 'color': 'red', 'margin-top':'0px', 'margin-bottom':'0px'});
            return false;
        }
        else if (Contact == "") {
            $('#ErrorEmpty').text("*Mobile Number is Required.");
            $('#ErrorEmpty').css({ 'color': 'red', 'margin-top': '0px', 'margin-bottom': '0px' });
            return false;
        }
        else if (GuardianName == "") {
            $('#ErrorEmpty').text("*Father/Guardian Name is Required.");
            $('#ErrorEmpty').css({ 'color': 'red', 'margin-top': '0px', 'margin-bottom': '0px' });
            return false;
        }
        if (Contact >= 0 || Contact <= 9) {
        }
        else
        {
            $('#ErrorEmpty').text("*Mobile Number is not in Correct Format.");
            $('#ErrorEmpty').css({ 'color': 'red', 'margin-top': '0px', 'margin-bottom': '0px' });
            return false;
        }
    });
});

// Comment on People posts Ajax.
function AjaxPostComment() {
    var value = $("#Comment").val();
    $.ajax({
        type: "POST",
        url: "FullPost.aspx/CommentOnPosts",
        data: "{Comment:'" + value + "'}",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function () {
            $.ajax({
                type: "POST",
                url: "FullPost.aspx/DisplayComments",
                data: "",
                dataType: "json",
                contentType: "application/json, charset=utf-8",
                success: function () {
                    $('#alert_sucess').show(function () {
                        $(this).delay(3000).fadeOut(1000);
                    });
                    $('#alert_sucess').css({'text-align':'center'});
                },
                error: function () {
                    alert("Sorry");
                }
            });
        },
        error: function () {
            $('#alert_danger').show(function () {
                $(this).delay(3000).fadeOut(1000);
            });
            $('#alert_danger').css({'text-align': 'center' });
            return false;
        }
    });
}

// Favourite Post Success
function FavouritePost() {
    $('#FavouriteSuccess').slideDown(1000, function () {
        $(this).delay(5000).slideUp(1000);
    });
}

// Favourite Post Failure
function FavouritePostFailure() {
    $('#FavouriteFailure').slideDown(1000, function () {
        $(this).delay(5000).slideUp(1000);
    });
}
