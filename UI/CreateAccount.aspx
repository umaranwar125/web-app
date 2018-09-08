<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="UI.CreateAccount" %>

<%@ Register Src="~/User Control Files/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/User Control Files/Navigation.ascx" TagPrefix="uc1" TagName="Navigation" %>
<%@ Register Src="~/User Control Files/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registeration - Missing People and Things</title>
    <meta name="keywords" content="missing people, missing thing, unidentified people, registeration, missing people in pakistan"/>
    <meta name="author" content="Umar Anwar" />
    <uc1:Header runat="server" ID="Header" />
</head>
<body style="background: url('Image/black.jpg'); background-repeat: no-repeat; background-size: cover; background-position: center;">
    <form id="form1" runat="server">
        <section id="Login-header">
            <!-- Starting of Header Area -->
            <uc1:Navigation runat="server" ID="Navigation" />
        </section>

        <div class="container">
            <div class="col-xs-0 col-sm-3 col-md-3 col-lg-4"></div>
            <div class="col-xs-12 col-sm-6 col-md-6 col-lg-4">
                <div class="Registration">
                    <div class="bg">
                        <img src="Image/user.png" width="100" height="100">
                        <h4 class="text-center register">Registration</h4>
                        <hr>
                        <div class="inputs">
                            <h5 class="fs-subtitle" runat="server" id="EmailFailure" visible="false" style="color: red; font-size: 12px; font-weight: bold">Email is not in correct format. Please try again!</h5>
                            <h5 class="fs-subtitle" runat="server" id="ExistingMsg" visible="false" style="color: red; font-size: 12px; font-weight: bold">Sorry! Email or Username is already exist. Please try with new one!</h5>
                            <input type="text" placeholder="Full Name (*)" runat="server" id="RegisterName" />
                            <input type="text" placeholder="Username (*)" id="RegisterUsername" runat="server" />
                            <input type="text" placeholder="Email Address (*)" id="RegisterEmail" runat="server" required="" />
                            <input type="password" placeholder="Password (*)" id="RegisterPassword" runat="server" />
                            <input type="password" placeholder="Re-enter Password (*)" id="RegisterConfirm" runat="server" />
                            <input type="text" placeholder="Mobile Number (*)" id="RegisterContact" runat="server" />
                            <input type="text" placeholder="Age (*)" id="RegisterAge" runat="server" />
                            <div class="gander">
                                <label for="" style="margin-right: 50px;">Gander (*)</label>
                                <input type="radio" name="gender" id="RegisterMale" value="Male" runat="server" checked="" />&nbsp;Male&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							    <input type="radio" name="gender" id="RegisterFemale" value="Female" runat="server" />&nbsp;Female	
                            </div>
                            <label for="" runat="server" class="image">Image <span>(Optional)</span></label>
                            <asp:FileUpload ID="RegisterImage" runat="server"></asp:FileUpload>
                            <br />
                            <h5 class="fs-subtitle ErrorMsg"></h5>
                            <h5 class="fs-subtitle ErrorAge"></h5>
                            <h5 class="fs-subtitle" id="ErrorUserName" runat="server"></h5>
                            <h5 class="fs-subtitle ErrorNumber"></h5>
                            <h5 class="fs-subtitle ErrorMatching"></h5>
                            <asp:Button ID="RegsiterClickButton" runat="server" Text="Create Account" CssClass="btn center-block login-btn btnRegister" OnClick="RegsiterClickButton_Click"></asp:Button>
                            <h6 class="text-center singup">Already have an account? <a href="login">Log in</a></h6>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-xs-0 col-sm-3 col-md-3 col-lg-4"></div>
        </div>

        <div id="Testimonial">
            <div class="footer">
                <uc1:Footer runat="server" ID="Footer" />
            </div>
            <!-- End of Footer-->
        </div>
    </form>
</body>
</html>
