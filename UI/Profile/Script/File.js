// Edit Profile Validation
$(document).ready(function () {
    $('#Updateprofile').click(function () {
        var name = $('#Full_N').val();
        var titile = $('#Titl').val();
        var contact = $('#email_a').val();
        var email = $('#contact_n').val();
        var new_pwd = $('#new_p').val();
        var con_pwd = $('#con_p').val();

        if (name == "") {
            $('#error').show();
            $('#error').text("* Please enter your Name.");
            return false;
        }
        else if (titile == "") {
            $('#error').show();
            $('#error').text("* Please enter Title.");
            return false;
        }
        else if (email == "") {
            $('#error').show();
            $('#error').text("* Please enter your Email Address.");
            return false;
        }
        else if (contact == "") {
            $('#error').show();
            $('#error').text("* Please enter your Mobile Number.");
            return false;
        }
        else if (new_pwd == "") {
            $('#error').show();
            $('#error').text("* Please Enter Password1.");
            return false;
        }
        else if (con_pwd == "") {
            $('#error').show();
            $('#error').text("* Please Enter Password2.");
            return false;
        }
        else if (new_pwd != con_pwd) {
            $('#error').show();
            $('#error').text("* Password is not match.");
            return false;
        }
        else {
            $('#error').hide();
            $(this).fadeOut(1000, function () {
                $('#show').fadeIn(1000);
            });
        }
    });

    $('#UpdateNow').click(function () {
        var old_pwd = $('#old_p').val();
        if(old_pwd == "")
        {
            $('#error-pwd').show();
            $('#error-pwd').text("* Please enter Old Password.");
            return false;
        }
        else
            $('#error-pwd').hide();
    });
});

function displayCongratsMessage() {
    $(document).ready(function () {
        $('#alert_Congratz').show(function () {
            $('#alert_Congratz').delay(4000).fadeOut(1000);
        });
    });
}

function displayEmailMessage() {
    $(document).ready(function () {
        $('#alert_email').show(function () {
            $('#alert_email').delay(4000).fadeOut(1000);
        });
    });
}

function displayPasswordMessage() {
    $(document).ready(function () {
        $('#alert_password').show(function () {
            $('#alert_password').delay(4000).fadeOut(1000);
        });
    });
}

function displayCongratsFavouritePostMessage() {
    $(document).ready(function () {
        $('#alert_Favourite_Delete').show(function () {
            $('#alert_password').delay(4000).fadeOut(1000);
        });
    });
}

// Edit Post Validation.
$(document).ready(function () {
    $('#Update_Missing_People').click(function () {
        var MissingPeopleName = $('#M_P_Full_Name').val();
        var MissingPeopleCNIC = $('#M_P_CNIC').val();
        var MissingPeopleGuardianName = $('#M_P_Father_name').val();
        var MissingPeopleGuardianCNIC = $('#M_P_Father_CNIC').val();
        var MissingPeopleContactNumber = $('#M_P_Mobile').val();
        var MissingPeopleAnotherContact = $('#M_P_Mobile2').val();
        var MissingPeoplePermanent = $('#M_P_Permanent').val();
        var MissingPeopleCurrent = $('#M_P_Current').val();
        var MissingPeopleAge = $('#M_P_Age').val();
        var MissingPeoplePlace = $('#M_P_Place').val();
        var MissingPeopleDescription = $('#M_P_Description').val();
        if (MissingPeopleName == "") {
            $('.ErrorMsg').text("*Full Name Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold'});
            return false;
        }
        else if (MissingPeopleGuardianName == "") {
            $('.ErrorMsg').text("*Father/Guardian Name Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold'});
            return false;
        }
        else if (MissingPeopleGuardianCNIC == "") {
            $('.ErrorMsg').text("*Father/Guardian CNIC Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold'});
            return false;
        }
        else if (MissingPeopleContactNumber == "") {
            $('.ErrorMsg').text("*Contact Number Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold'});
            return false;
        }
        else if (MissingPeoplePermanent == "") {
            $('.ErrorMsg').text("*Permanent Address Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold'});
            return false;
        }
        else if (MissingPeopleCurrent == "") {
            $('.ErrorMsg').text("*Current Address Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold'});
            return false;
        }
        else if (MissingPeopleAge == "") {
            $('.ErrorMsg').text("*Age Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold'});
            return false;
        }
        else if (MissingPeoplePlace == "") {
            $('.ErrorMsg').text("*Missing Place Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold'});
            return false;
        }
        else if (MissingPeopleDescription == "") {
            $('.ErrorMsg').text("*Description Field is Required.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold'});
            return false;
        }
        else if (MissingPeopleDescription.length <= 60) {
            $('.ErrorMsg').text("*Description length must be at least 60 Characters.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold' });
            return false;
        }

        if (MissingPeopleCNIC >= 0 || MissingPeopleCNIC <= 9) {
        }
        else {
            $('.ErrorMsg').text("*CNIC is not in Correct Format.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold' });
            return false;
        }
        if (MissingPeopleGuardianCNIC >= 0 || MissingPeopleGuardianCNIC <= 9) {
        }
        else {
            $('.ErrorMsg').text("*Father/Guardian CNIC is not in Correct Format.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold' });
            return false;
        }
        if (MissingPeopleContactNumber >= 0 || MissingPeopleContactNumber <= 9) {
        }
        else {
            $('.ErrorMsg').text("*Contact Number is not in Correct Format.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold' });
            return false;
        }
        if (MissingPeopleAnotherContact >= 0 || MissingPeopleAnotherContact <= 9) {
        }
        else {
            $('.ErrorMsg').text("*Contact Number is not in Correct Format.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold' });
            return false;
        }
        if (MissingPeopleAge >= 0 || MissingPeopleAge <= 9) {
        }
        else {
            $('.ErrorMsg').text("*Age is not in Correct Format.");
            $('.ErrorMsg').css({ 'color': 'red', 'font-weight': 'bold' });
            return false;
        }
    });
});

function displayErrorImageEditPeoplePost() {
    $(document).ready(function () {
        $('#alert_Image').show(function () {
            $('#alert_Image').delay(4000).fadeOut(1000);
        });
    });
}

function displaySuccessMsgForEditPeoplePost() {
    $(document).ready(function () {
        $('#alert_success').show(function () {
            $('#alert_success').delay(4000).fadeOut(1000);
        });
    });
}

// Validation for Auto Mobile Post
$(document).ready(function () {
    $('#Update_Auto_Mobile_post').click(function () {
        var OwnerName = $('#Auto_Owner_name').val();
        var OwnerCnic = $('#Auto_Owner_CNIC').val();
        var ContactNumber = $('#Auto_Mobile_No').val();
        var ContactNumber2 = $('#Auto_Mobile_No2').val();
        var GuardianName = $('#Auto_Father_Name').val();
        var GuardianCNIC = $('#Auto_Father_CNIC').val();
        var MissingPlace = $('#Auto_Place').val();
        var Description = $('#Auto_description').val();
        var CompanyName = $('#Auto_company').val();
        var BrandName = $('#Auto_Brand').val();
        var EngineNumber = $('#Auto_Engine').val();
        var ChassesNumber = $('#Auto_chasses').val();
        var Color = $('#Auto_Color').val();
        var Model = $('#Auto_Model').val();
        if (OwnerName == "") {
            $('.ErrorAuto').text("*Owner Name is Required.");
            $('.ErrorAuto').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (OwnerCnic == "") {
            $('.ErrorAuto').text("*Owner CNIC is Required.");
            $('.ErrorAuto').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (ContactNumber == "") {
            $('.ErrorAuto').text("*Contact Number is Required.");
            $('.ErrorAuto').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (GuardianName == "") {
            $('.ErrorAuto').text("*Father/Guardian Name is Required.");
            $('.ErrorAuto').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (GuardianCNIC == "") {
            $('.ErrorAuto').text("*Father/Guardian CNIC is Required.");
            $('.ErrorAuto').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (MissingPlace == "") {
            $('.ErrorAuto').text("*Missing Place is Required.");
            $('.ErrorAuto').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (CompanyName == "") {
            $('.ErrorAuto').text("*Company Name is Required.");
            $('.ErrorAuto').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (BrandName == "") {
            $('.ErrorAuto').text("*Brand Name is Required.");
            $('.ErrorAuto').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (EngineNumber == "") {
            $('.ErrorAuto').text("*Engine Number is Required.");
            $('.ErrorAuto').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (ChassesNumber == "") {
            $('.ErrorAuto').text("*Chasses Number is Required.");
            $('.ErrorAuto').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (Color == "") {
            $('.ErrorAuto').text("*Color Field is Required.");
            $('.ErrorAuto').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (Model == "") {
            $('.ErrorAuto').text("*Model Field is Required.");
            $('.ErrorAuto').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (Description == "") {
            $('.ErrorAuto').text("*Description is Required.");
            $('.ErrorAuto').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (Description.length <= 60) {
            $('.ErrorAuto').text("*Description length must be at least 60 Characters.");
            $('.ErrorAuto').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        if (ContactNumber >= 0 || ContactNumber <= 9) {
        }
        else {
            $('.ErrorAuto').text("*Contact Number is not in Correct Format.");
            $('.ErrorAuto').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        if (ContactNumber2 >= 0 || ContactNumber2 <= 9) {
        }
        else {
            $('.ErrorAuto').text("*Contact Number is not in Correct Format.");
            $('.ErrorAuto').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        if (OwnerCnic >= 0 || OwnerCnic <= 9) {
        }
        else {
            $('.ErrorAuto').text("*Owner CNIC is not in Correct Format.");
            $('.ErrorAuto').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        if (GuardianCNIC >= 0 || GuardianCNIC <= 9) {
        }
        else {
            $('.ErrorAuto').text("*Father/Guardian CNIC is not in Correct Format.");
            $('.ErrorAuto').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
    });
});

// Validation for CNIC Post
$(document).ready(function () {
    $('#Update_CNIC_Post').click(function () {
        var OwnerName = $('#CNIC_Owner_name').val();
        var OwnerCnic = $('#CNIC_Owner_CNIC').val();
        var ContactNumber = $('#CNIC_Mobile_no').val();
        var ContactNumber2 = $('#CNIC_Mobile_no2').val();
        var GuardianName = $('#CNIC_Father_name').val();
        var GuardianCNIC = $('#CNIC_Father_CNIC').val();
        var MissingPlace = $('#CNIC_Place').val();
        var Description = $('#CNIC_Description').val();
        var CNICNumber = $('#CNIC_Number').val();
        var Familynumber = $('#CNIC_Family').val();
        if (OwnerName == "") {
            $('.ErrorCNIC').text("*Owner Name is Required.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (OwnerCnic == "") {
            $('.ErrorCNIC').text("*Owner CNIC is Required.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (ContactNumber == "") {
            $('.ErrorCNIC').text("*Contact Number is Required.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (GuardianName == "") {
            $('.ErrorCNIC').text("*Father/Guardian Name is Required.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (GuardianCNIC == "") {
            $('.ErrorCNIC').text("*Father/Guardian CNIC is Required.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (MissingPlace == "") {
            $('.ErrorCNIC').text("*Missing Place is Required.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (CNICNumber == "") {
            $('.ErrorCNIC').text("*CNIC Number is Required.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (Familynumber == "") {
            $('.ErrorCNIC').text("*CNIC Family Number is Required.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (Description == "") {
            $('.ErrorCNIC').text("*Description is Required.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (Description.length <= 60) {
            $('.ErrorCNIC').text("*Description length must be at least 60 Characters.");
            $('.ErrorCNIC').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        if (ContactNumber >= 0 || ContactNumber <= 9) {
        }
        else {
            $('.ErrorCNIC').text("*Contact Number is not in Correct Format.");
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
        if (ContactNumber2 >= 0 || ContactNumber2 <= 9) {
        }
        else {
            $('.ErrorCNIC').text("*Contact Number is not in Correct Format.");
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

// Validation for Mobile Post
$(document).ready(function () {
    $('#Update_Mobile_post').click(function () {
        var OwnerName = $('#Mobile_Owner_Name').val();
        var OwnerCnic = $('#Mobile_Owner_CNIC').val();
        var ContactNumber = $('#Mobile_Mobile_NO').val();
        var ContactNumber2 = $('#Mobile_Mobile_NO2').val();
        var GuardianName = $('#Mobile_Father_Name').val();
        var GuardianCNIC = $('#Mobile_Father_CNIC').val();
        var MissingPlace = $('#Mobile_Place').val();
        var Description = $('#Mobile_Description').val();
        var BrandName = $('#Mobile_Brand').val();
        var Color = $('#Mobile_Color').val();
        var Model = $('#Mobile_Model').val();
        if (OwnerName == "") {
            $('.ErrorMobile').text("*Owner Name is Required.");
            $('.ErrorMobile').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (OwnerCnic == "") {
            $('.ErrorMobile').text("*Owner CNIC is Required.");
            $('.ErrorMobile').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (ContactNumber == "") {
            $('.ErrorMobile').text("*Contact Number is Required.");
            $('.ErrorMobile').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (GuardianName == "") {
            $('.ErrorMobile').text("*Father/Guardian Name is Required.");
            $('.ErrorMobile').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (GuardianCNIC == "") {
            $('.ErrorMobile').text("*Father/Guardian CNIC is Required.");
            $('.ErrorMobile').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (MissingPlace == "") {
            $('.ErrorMobile').text("*Missing Place is Required.");
            $('.ErrorMobile').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (BrandName == "") {
            $('.ErrorMobile').text("*Brand Name is Required.");
            $('.ErrorMobile').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (Color == "") {
            $('.ErrorMobile').text("*Color Field is Required.");
            $('.ErrorMobile').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (Model == "") {
            $('.ErrorMobile').text("*Model Field is Required.");
            $('.ErrorMobile').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (Description == "") {
            $('.ErrorMobile').text("*Description is Required.");
            $('.ErrorMobile').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (Description.length <= 60) {
            $('.ErrorMobile').text("*Description length must be at least 60 Characters.");
            $('.ErrorMobile').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        if (ContactNumber >= 0 || ContactNumber <= 9) {
        }
        else {
            $('.ErrorMobile').text("*Contact Number is not in Correct Format.");
            $('.ErrorMobile').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        if (ContactNumber2 >= 0 || ContactNumber2 <= 9) {
        }
        else {
            $('.ErrorMobile').text("*Contact Number is not in Correct Format.");
            $('.ErrorMobile').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        if (OwnerCnic >= 0 || OwnerCnic <= 9) {
        }
        else {
            $('.ErrorMobile').text("*Owner CNIC is not in Correct Format.");
            $('.ErrorMobile').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        if (GuardianCNIC >= 0 || GuardianCNIC <= 9) {
        }
        else {
            $('.ErrorMobile').text("*Father/Guardian CNIC is not in Correct Format.");
            $('.ErrorMobile').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
    });
});

function displayAutoSuccessMsgForEditThingPost() {
    $(document).ready(function () {
        $('#alert_success_Auto').show(function () {
            $('#alert_success_Auto').delay(4000).fadeOut(1000);
        });
    });
}

function displayCNICSuccessMsgForEditThingPost() {
    $(document).ready(function () {
        $('#alert_success_CNIC').show(function () {
            $('#alert_success_CNIC').delay(4000).fadeOut(1000);
        });
    });
}

function displayMobileSuccessMsgForEditThingPost() {
    $(document).ready(function () {
        $('#alert_success_Mobile').show(function () {
            $('#alert_success_Mobile').delay(4000).fadeOut(1000);
        });
    });
}

// Validation for Unidetified Person Page.
$(document).ready(function () {
    $('#Update_Unidentified_Post').click(function () {
        var UnidentidiedName = $('#Uni_Name').val();
        var UnidentidiedContact = $('#Uni_Mobile').val();
        var UnidentidiedAge = $('#Uni_Age').val();
        var UnidentidiedFound = $('#Uni_found').val();
        var UnidentidiedLanguage = $('#Uni_language').val();
        var UnidentidiedDescription = $('#Uni_description').val();
        if (UnidentidiedName == "") {
            $('.ErrorUnidentified').text("*Name is Required.");
            $('.ErrorUnidentified').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (UnidentidiedContact == "") {
            $('.ErrorUnidentified').text("*Contact Number is Required.");
            $('.ErrorUnidentified').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (UnidentidiedFound == "") {
            $('.ErrorUnidentified').text("*Found Place is Required.");
            $('.ErrorUnidentified').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (UnidentidiedLanguage == "") {
            $('.ErrorUnidentified').text("*Language is Required.");
            $('.ErrorUnidentified').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (UnidentidiedDescription == "") {
            $('.ErrorUnidentified').text("*Description is Required.");
            $('.ErrorUnidentified').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        else if (UnidentidiedDescription.length <= 60) {
            $('.ErrorUnidentified').text("*Description length must be at least 60 Characters.");
            $('.ErrorUnidentified').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px', 'font-family': 'EB Garamond, serif' });
            return false;
        }
        if (UnidentidiedContact >= 0 || UnidentidiedContact <= 9) {
        }
        else {
            $('.ErrorUnidentified').text("*Contact Number is not in Correct Format.");
            $('.ErrorUnidentified').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
        if (UnidentidiedAge >= 0 || UnidentidiedAge <= 9) {
        }
        else {
            $('.ErrorUnidentified').text("*Age is not in Correct Format.");
            $('.ErrorUnidentified').css({ 'color': 'red', 'font-weight': 'bold', 'letter-spacing': '1px' });
            return false;
        }
    });
});

function displayUnidentifiedErrorImageForEditThingPost() {
    $(document).ready(function () {
        $('#alert_Imag_Undentifiede').show(function () {
            $('#alert_Imag_Undentifiede').delay(4000).fadeOut(1000);
        });
    });
}

function displayUnidentifiedSuccessMsgForEditThingPost() {
    $(document).ready(function () {
        $('#alert_success_Unidentified').show(function () {
            $('#alert_success_Unidentified').delay(4000).fadeOut(1000);
        });
    });
}