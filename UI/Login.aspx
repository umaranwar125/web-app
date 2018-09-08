<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Login" %>

<%@ Register Src="~/User Control Files/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/User Control Files/Navigation.ascx" TagPrefix="uc1" TagName="Navigation" %>
<%@ Register Src="~/User Control Files/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login - Missing People and Things</title>
    <meta name="keywords" content="missing people, missing thing, unidentified people, Login in, Signin, search, missing people in pakistan"/>
    <meta name="author" content="Umar Anwar" />
    <uc1:Header runat="server" ID="Header" />
</head>
<body style="background: url('Image/black.jpg'); background-repeat: no-repeat; background-size: cover; background-position: center;">
    <form id="form1" runat="server">
        <!-- Start of Header Area Section -->
        <section id="Login-header">
            <uc1:Navigation runat="server" ID="Navigation" />
        </section>
        <!-- End of Header Area Section-->

        <div class="container MainPage">
            <div class="col-xs-0 col-sm-3 col-md-3 col-lg-4"></div>
            <div class="col-xs-12 col-sm-6 col-md-6 col-lg-4">
                <div class="Login">
                    <div class="bg">
                        <img src="Image/user.png" width="100" height="100">
                        <h4 class="text-center LoginText">Login</h4>
                        <hr />
                        <div class="inputs">
                            <center>
                                <h5 class="fs-subtitle text-center SessionMsg" runat="server" id="FavouritePost" visible="false">Please login first to save a post.</h5>
                                <h5 class="fs-subtitle text-center SessionMsg" runat="server" id="SessionFeedback" visible="false">Please login first to submit a feedback.</h5>
                                <h5 class="fs-subtitle text-center SessionMsg" runat="server" id="SessionMissingPeople" visible="false">Please login first to submit a report.</h5>
                                <h5 class="fs-subtitle text-center SessionMsg" runat="server" id="SessionPost" visible="false">Please login first to see a post.</h5>
                                <h5 class="fs-subtitle text-center SessionMsg" runat="server" id="SessionC" visible="false">Please login first to submit a question.</h5>
                                <h5 class="fs-subtitle text-center SessionMsg" runat="server" id="PwdReset" style="color: darkseagreen" visible="false">Your password is successfully updated.</h5>
                                <h5 class="fs-subtitle text-left SessionMsg" runat="server" id="SessionMsg" style="color: darkseagreen" visible="false">You're registered successfully, Please login!</h5>
					        </center>
                            <h5 class="fs-subtitle animated shake" runat="server" id="ValidationMsg"></h5>
                            <h5 class="fs-subtitle animated shake" runat="server" id="ErrorMsg" visible="false">Username or password is incorrect.</h5>
                            <input type="text" placeholder="Username" runat="server" id="usernameTextbox" />
                            <input type="password" placeholder="Password" runat="server" id="passwordTextbox" />
                            <asp:Button ID="LoginClick" runat="server" Text="Login" CssClass="btn center-block login-btn" OnClick="LoginClick_Click"></asp:Button>
                            <h5 class="text-right ForgotPassword"><a href="#Forgot-Password">Forgot Password?</a></h5>
                            <h6 class="text-center signup">Don't have an account? <a href="register">Sign Up</a></h6>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-xs-0 col-sm-3 col-md-3 col-lg-4"></div>
        </div>

        <div class="container UsernameCheck" style="display: none">
            <div class="col-xs-2 col-sm-3 col-md-4 col-md-4"></div>
            <div class="col-xs-8 col-sm-6 col-md-4 col-md-4">
                <div class="Login">
                    <div class="bg">
                        <img src="Image/user.png" width="100" height="100">

                        <div class="inputs">
                            <h2 class="text-center help">Account Help</h2>
                            <input type="text" placeholder="Enter Username" runat="server" id="UsernameValue" />
                            <h3 class="fs-subtitle animated shake" runat="server" id="UsernameValidation"></h3>
                            <input type="button" class="btn center-block login-btn" runat="server" id="UsernameClick" value="Submit" onclick="UsernameExistance()" />
                            <h5 class="text-right DontRemember"><a href="#Dont-Remember">Don't Remember?</a></h5>
                            <h6 class="text-center">Don't have an account? <a href="register">Sign Up</a></h6>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-xs-2 col-sm-3 col-md-4 col-md-4"></div>
        </div>


        <div class="container EmailCheck" style="display: none">
            <div class="col-xs-2 col-sm-3 col-md-4 col-md-4"></div>
            <div class="col-xs-8 col-sm-6 col-md-4 col-md-4">
                <div class="Login">
                    <div class="bg">
                        <img src="Image/user.png" width="100" height="100">

                        <div class="inputs">
                            <h2 class="text-center help">Account Help</h2>
                            <input type="text" placeholder="Enter Email" runat="server" id="EmailValue" />
                            <h3 class="fs-subtitle animated shake" runat="server" id="EmailValidation"></h3>
                            <input type="button" class="btn center-block login-btn" runat="server" id="EmailClick" value="Submit" onclick="EmailExistance()" />
                            <h5 class="text-right GoBack"><a href="#Go-Back">Go Back</a></h5>
                            <h6 class="text-center">Don't have an account? <a href="register">Sign Up</a></h6>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-xs-2 col-sm-3 col-md-4 col-md-4"></div>
        </div>


        <div class="container NumberCheck" style="display: none">
            <div class="col-xs-2 col-sm-3 col-md-4 col-md-4"></div>
            <div class="col-xs-8 col-sm-6 col-md-4 col-md-4">
                <div class="Login">
                    <div class="bg">
                        <img src="Image/user.png" width="100" height="100">

                        <div class="inputs">
                            <h2 class="text-center help">Account Help</h2>
                            <h3 class="fs-subtitle text-left SessionMsg" id="H1" style="color: #bdc3c7; margin-top: 40px">For Confirmation Purpose!</h3>
                            <input type="text" placeholder="Your Registered Number" runat="server" id="NumberValue" />
                            <h3 class="fs-subtitle animated shake" runat="server" id="NumberValidation"></h3>
                            <input type="button" class="btn center-block login-btn" runat="server" id="NumberClick" value="Submit" onclick="NumberExistance()" />
                            <h6 class="text-center">Don't have an account? <a href="register">Sign Up</a></h6>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-xs-2 col-sm-3 col-md-4 col-md-4"></div>
        </div>

        <div class="container AdminContact" style="display: none">
            <div class="col-xs-2 col-sm-3 col-md-4 col-md-4"></div>
            <div class="col-xs-8 col-sm-6 col-md-4 col-md-4">
                <div class="Login">
                    <div class="bg">
                        <img src="Image/user.png" width="100" height="100">

                        <div class="inputs">
                            <h2 class="text-center help">Account Help</h2>
                            <h5 class="text-center" style="color: #bdc3c7; margin-top: 40px; line-height: 20px; margin-bottom: 30px; font-family: 'EB Garamond', serif; letter-spacing: 1px;">Sorry! Number is not correct, you can contact from the Website Admin for recovering your Password. <a href="ContactUs.aspx" style="color: #bdc3c7">Click Here</a></h5>
                            <h5 class="text-right TryAgain"><a href="#Try-Again">Try Again</a></h5>
                            <h6 class="text-center">Don't have an account? <a href="register">Sign Up</a></h6>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-xs-2 col-sm-3 col-md-4 col-md-4"></div>
        </div>

        <div class="container NewPasswordCheck" style="display: none">
            <div class="col-xs-2 col-sm-3 col-md-4 col-md-4"></div>
            <div class="col-xs-8 col-sm-6 col-md-4 col-md-4">
                <div class="Login">
                    <div class="bg">
                        <img src="Image/user.png" width="100" height="100">

                        <div class="inputs">
                            <h2 class="text-center help">Account <span style="color: green; font-weight: bold">Verified</span></h2>
                            <input type="password" placeholder="Password" runat="server" id="Password1Value" />
                            <input type="password" placeholder="Re-enter Password" runat="server" id="Password2Value" />
                            <h3 class="fs-subtitle animated shake" runat="server" id="PasswordValidation"></h3>
                            <asp:Button ID="PasswordClick" runat="server" CssClass="btn center-block login-btn" Text="Reset Password" OnClick="PasswordClick_Click" />
                            <h5 class="text-right LoginForm"><a href="#Login-Form">Go to Login Form</a></h5>
                            <h6 class="text-center">Don't have an account? <a href="register">Sign Up</a></h6>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-xs-2 col-sm-3 col-md-4 col-md-4"></div>
        </div>

        <div id="Testimonial">
            <div class="footer">
                <uc1:Footer runat="server" ID="Footer" />
            </div>
        </div>
        <!-- End of Footer-->
    </form>
</body>
</html>
