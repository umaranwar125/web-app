<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Admin.Login" %>

<%@ Register Src="~/Admin/User Control File/Header.ascx" TagPrefix="uc1" TagName="Header" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login - Dashboard</title>
	<uc1:Header runat="server" ID="Header" />
</head>
<body id="login">
    <form id="form1" runat="server">
        <section>
            <!-- Main Login Form -->
			<div class="container MainPage">
				<div class="col-sm-1 col-md-1 col-lg-2"></div>
				<div class="col-xs-12 col-sm-10 col-md-10 col-lg-8">
					<div class="my-form">
						<div class="form-content">
							<h2 class="text-center">Login</h2>
							<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.</p>
							<p>when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.</p>
						</div>
						<div class="login-form">
							<img src="../Image/Untitled-2.gif" class="center-block" width="100" height="100" />
							<div class="inputs">
                                <h5 class="text-center animated shake" id="ErrorMsg" visible="false" style="color: red;font-weight: bold;font-family: 'Quicksand', sans-serif;margin-top: -15px; margin-bottom: 20px;font-size: 15px;"></h5>
                                <h5 class="text-center ShowMsg" style="font-family: 'Quicksand', sans-serif;"></h5>
                                <h5 class="text-center" runat="server" visible="false" id="Updated" style="font-family: 'Quicksand', sans-serif;color: green">Password Updated Successfully.</h5>
                                <label>Username</label><input type="text" runat="server" id="UsernameLogin" placeholder="Enter Username" />
								<label>Password 1</label><input type="password" runat="server" id="PasswornOneLogin"  placeholder="Enter First Password" />
								<label>Password 2</label><input type="password" runat="server" id="PasswordTwoLogin" placeholder="Enter Second Password" />
                                <input type="button" class="btn" id="LoginButton" value="Login" runat="server" onclick="LoginAjaxMethod()"/>
								<a href="#Forgot-Password" class="pull-left ForgotPassword">Forgot Password</a>
								<a href="../Default.aspx" class="pull-right page">Go to Main Page</a>
							</div>
						</div>
					</div>
				</div>
				<div class="col-sm-1 col-md-1 col-lg-2"></div>
			</div>


            <!-- Forgot Username Page -->
            <div class="container UsernameCheck" style="display: none">
				<div class="col-sm-1 col-md-1 col-lg-2"></div>
				<div class="col-xs-12 col-sm-10 col-md-10 col-lg-8">
					<div class="my-form">
						<div class="form-content">
							<h2 class="text-center">Login</h2>
							<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.</p>
							<p>when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.</p>
						</div>
						<div class="login-form">
							<img src="../Image/Untitled-2.gif" class="center-block" width="100" height="100" />
                            <h2 class="text-center help">Account Help</h2>
							<div class="inputs" style="margin-top: 70px;">
                                <h5 class="text-center animated shake" id="ErrorUser" visible="false"></h5>
                                <label>Username</label><input type="text" runat="server" id="usernameCheck" placeholder="Enter Username" />
                                <input type="button" value="Submit" class="btn" id="UsernameCheckButton" runat="server" onclick="UsernameAjaxMethod()" />
								<a href="../Default.aspx" class="pull-right page">Go to Main Page</a>
							</div>
						</div>
					</div>
				</div>
				<div class="col-sm-1 col-md-1 col-lg-2"></div>
			</div>

            <!-- Forgot Password1 Page -->
            <div class="container ContactCheck" style="display: none">
				<div class="col-sm-1 col-md-1 col-lg-2"></div>
				<div class="col-xs-12 col-sm-10 col-md-10 col-lg-8">
					<div class="my-form">
						<div class="form-content">
							<h2 class="text-center">Login</h2>
							<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.</p>
							<p>when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.</p>
						</div>
						<div class="login-form">
							<img src="../Image/Untitled-2.gif" class="center-block" width="100" height="100" />
							<h2 class="text-center help">Account Help</h2>
                            <div class="inputs" style="margin-top: 70px;">
                                <h5 class="text-center animated shake" id="ErrorPwd1" visible="false" style="color: red;font-weight: bold;font-family: 'Quicksand', sans-serif;margin-top: -15px; margin-bottom: 20px;font-size: 15px;"></h5>
                                <label>Password 1</label><input type="text" runat="server" id="PasswordOneCheck" placeholder="Enter Password" />
                                <input type="button" id="PasswordOneCheckButton" class="btn" value="Submit" onclick="UsernamePasswordCheckAjaxMethod()" />
								<a href="#Password1" class="pull-left DontRemember2">Try another way</a>
								<a href="../Default.aspx" class="pull-right page">Go to Main Page</a>
							</div>
						</div>
					</div>
				</div>
				<div class="col-sm-1 col-md-1 col-lg-2"></div>
			</div>

            <!-- Occur When Everyting is Correct. -->
            <div class="container AllisGood" style="display: none">
				<div class="col-sm-1 col-md-1 col-lg-2"></div>
				<div class="col-xs-12 col-sm-10 col-md-10 col-lg-8">
					<div class="my-form">
						<div class="form-content">
							<h2 class="text-center">Login</h2>
							<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.</p>
							<p>when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.</p>
						</div>
						<div class="login-form">
							<img src="../Image/Untitled-2.gif" class="center-block" width="100" height="100" />
							<h2 class="text-center help">Account <span style="color: green; font-weight: bold">Verified</span></h2>
                            <div class="inputs" style="margin-top: 70px;">
                                <h5 class="text-center animated shake" id="UpdateError" visible="false" style="color: red;font-weight: bold;font-family: 'Quicksand', sans-serif;margin-top: -15px; margin-bottom: 20px;font-size: 15px;"></h5>
                                <label>Password 1</label><input type="text" runat="server" id="NewsPassword1" placeholder="Enter New Password 1" />
                                <label>Password 2</label><input type="text" runat="server" id="NewsPassword2" placeholder="Enter New Password 2" />
                                <asp:Button ID="ForgotPasswordSucceeded" CssClass="btn" runat="server" Text="Update" OnClick="ForgotPasswordSucceeded_Click" />
								<a href="../Default.aspx" class="pull-right page">Go to Main Page</a>
							</div>
						</div>
					</div>
				</div>
				<div class="col-sm-1 col-md-1 col-lg-2"></div>
			</div>

            <!-- Forgot Password Two Page -->
            <div class="container PasswordCheck" style="display: none">
				<div class="col-sm-1 col-md-1 col-lg-2"></div>
				<div class="col-xs-12 col-sm-10 col-md-10 col-lg-8">
					<div class="my-form">
						<div class="form-content">
							<h2 class="text-center">Login</h2>
							<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.</p>
							<p>when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.</p>
						</div>
						<div class="login-form">
							<img src="../Image/Untitled-2.gif" class="center-block" width="100" height="100" />
							<h2 class="text-center help">Account Help</h2>
                            <div class="inputs" style="margin-top: 70px;">
                                <h5 class="text-center animated shake" id="ErrorPwd2" visible="false" style="color: red;font-weight: bold;font-family: 'Quicksand', sans-serif;margin-top: -15px; margin-bottom: 20px;font-size: 15px;"></h5>
                                <label>Password 2</label><input type="text" runat="server" id="PasswordTwoCheck" placeholder="Enter Password" />
                                <input type="button" id="PasswordTwoCheckButton" class="btn" value="Submit" onclick="UsernamePasswordTwoCheckAjaxMethod()" />
								<a href="#Password2" class="pull-left DontRemember3">Try another way</a>
								<a href="../Default.aspx" class="pull-right page">Go to Main Page</a>
							</div>
						</div>
					</div>
				</div>
				<div class="col-sm-1 col-md-1 col-lg-2"></div>
			</div>

            <!-- Forgot Security Page -->
            <div class="container SecurityCheck" style="display:none">
				<div class="col-sm-1 col-md-1 col-lg-2"></div>
				<div class="col-xs-12 col-sm-10 col-md-10 col-lg-8">
					<div class="my-form">
						<div class="form-content">
							<h2 class="text-center">Login</h2>
							<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.</p>
							<p>when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.</p>
						</div>
						<div class="login-form">
							<img src="../Image/Untitled-2.gif" class="center-block" width="100" height="100" />
							<h2 class="text-center help">Account Help</h2>
                            <div class="inputs" style="margin-top: 70px;">
                                <h5 class="text-center animated shake" id="SecurityError" visible="false" style="color: red;font-weight: bold;font-family: 'Quicksand', sans-serif;margin-top: -15px; margin-bottom: 20px;font-size: 15px;"></h5>
                                <label>Security Question</label>
                                <select runat="server" id="Securty">
										<option value="Choose Security Question" class="selected" selected="" disabled=""> Choose Security Question</option>
										<option value="What's the Nickname of your best Friend?"> What's the Nickname of your best Friend?</option>
										<option value="Who was your childhood hero?"> Who was your childhood hero?</option>
										<option value="In what year was your father born?"> In what year was your father born?</option>
										<option value="What is your favorite Song?"> What is your favorite Song?</option>
										<option value="Who was your childhood hero?"> Who was your childhood hero?</option>
										<option value="What was the last name of your favourite teacher?"> What was the last name of your favourite teacher?</option>
									</select>
                                <label>Enter Answer</label><input type="text" runat="server" id="AnswerCheck" placeholder="Answer" />
                                <input type="button" id="SecurityCheckButton" class="btn" value="Submit" onclick="UsernameSecurityCheckAjaxMethod()" />
                                <a href="#Security-Question" class="pull-left Next">Try another way</a>
								<a href="../Default.aspx" class="pull-right page">Go to Main Page</a>
							</div>
						</div>
					</div>
				</div>
				<div class="col-sm-1 col-md-1 col-lg-2"></div>
			</div>

            <!-- End of Forgot Page -->
            <div class="container Sorry" style="display: none">
				<div class="col-sm-1 col-md-1 col-lg-2"></div>
				<div class="col-xs-12 col-sm-10 col-md-10 col-lg-8">
					<div class="my-form">
						<div class="form-content">
							<h2 class="text-center">Login</h2>
							<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.</p>
							<p>when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.</p>
						</div>
						<div class="login-form">
							<img src="../Image/Untitled-2.gif" class="center-block" width="100" height="100" />
							<h2 class="text-center help">No account found</h2> 
                            <div class="inputs" style="margin-top: 70px;">
                                <h5 class="End">We couldn't verify this account belongs to you. Please refer to this Website Owner for unlocking your account.<br />
                                    Contact Number of Website Owner is 03159382193.</h5>
								<a href="Login.aspx" class="pull-left">Try again</a>
                                <a href="../Default.aspx" class="pull-right page">Go to Main Page</a>
                            </div>
                        </div>
					</div>
				</div>
				<div class="col-sm-1 col-md-1 col-lg-2"></div>
			</div>
		</section>
    </form>
</body>
</html>
