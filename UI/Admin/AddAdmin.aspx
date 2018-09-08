<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddAdmin.aspx.cs" Inherits="UI.Admin.AddAdmin" %>

<%@ Register Src="~/Admin/User Control File/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Admin/User Control File/SideNavigation.ascx" TagPrefix="uc1" TagName="SideNavigation" %>
<%@ Register Src="~/Admin/User Control File/TopNavigation.ascx" TagPrefix="uc1" TagName="TopNavigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Admin - Dashboard</title>
    <uc1:Header runat="server" ID="Header" />
</head>
<body>
    <form id="form1" runat="server">
        <!-- Contaier-Fluid -->
		<div class="container-fluid">
			<div class="row">
				<!-- First Column -->
				<div class="col-md-2 col-lg-2 side-bar" id="side-bar">
					<uc1:SideNavigation runat="server" ID="SideNavigation" />
				</div>

				<!-- Second Column -->
				<div class="col-xs-12 col-sm-12 col-md-10 col-lg-10 right-bg">

					<!-- Top COntent -->
					<div class="top-content">
                        <uc1:TopNavigation runat="server" ID="TopNavigation" />
					</div>
					<!-- Top Content  -->

					<!--  Main COntent -->
                    <div class="main-content" onclick="Open();">

                        <nav class="navbar navbar-default">
                                <!-- Brand and toggle get grouped for better mobile display -->
                                <div class="navbar-header">
                                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                                        <span class="sr-only">Toggle navigation</span>
                                        <span class="icon-bar"></span>
                                        <span class="icon-bar"></span>
                                        <span class="icon-bar"></span>
                                    </button>
                                    <%foreach(var data in DisplayProfileData)
                                      { %>
                                    <a class="navbar-brand" href="Profile.aspx"><span><%= data.FullName %></span>'s Profile</a>
                                    <%} %>
                                </div>

                                <!-- Collect the nav links, forms, and other content for toggling -->
                                <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                                    <ul class="nav navbar-nav navbar-right">
                                        <li><a href="Change.aspx"><i class="fa fa-key" aria-hidden="true"></i>&nbsp;Change Admin Username and Password</a></li>
                                        <li runat="server" id="AddAdminUser" class="active"><a href="AddAdmin.aspx"><i class="fa fa-user-plus" aria-hidden="true"></i>&nbsp;&nbsp;Add Another Admin</a></li>
                                        <li runat="server" id="DeleteAdminUser"><a href="DeleteAdmin.aspx"><i class="fa fa-times" aria-hidden="true"></i>&nbsp;&nbsp;Delete Admin</a></li>
                                        <li><a href="Logout.aspx"><i class="fa fa-power-off" aria-hidden="true"></i>&nbsp;Logout</a></li>
                                    </ul>
                                </div>
                                <!-- /.navbar-collapse -->
                        </nav>

						<div class="profile">
							<div class="col-xs-12 col-sm-12 col-md-4 col-lg-4">
								<div class="profile-bg text-center">
                                    <%foreach(var data in DisplayProfileData)
                                      { %>
									<img src="<%= data.Image %>" class="img img-responsive img-rounded center-block" width="490" height="490" />
									<h3><%= data.FullName %></h3>
									<h5><%= data.Title %></h5>
                                    <%} %>
								</div>
							</div>
							<div class="col-xs-12 col-sm-12 col-md-8 col-lg-8">
								<div class="information-bg" style="height: 700px">
                                    <h5 runat="server" id="Successfull" class="text-center" visible="false" style="color:green;font-size: 16px; margin-bottom: 20px;">Another Admin has been succesfully Created.</h5>
                                    <h5 class="text-center" runat="server" visible="false" id="Error" style="margin-top:-10px;margin-bottom:15px;color: red;font-size:16px;font-weight:bold"><span style="font-size:19px;font-weight:bold;">*</span> Please Select Security Question.</h5>
                                    <label>Username</label><input type="text" placeholder="Enter Unique Username" runat="server" id="Username" />
									<label>Password 1</label><input type="text" placeholder="Enter Password 1" runat="server" id="PasswordOne" />
									<label>Password 2</label><input type="text" placeholder="Enter Password 2" runat="server" id="PasswordTwo" />  
                                    <select class="qualification" runat="server" id="Qualification">
										<option value="Qualification" class="selected" selected="" disabled=""> Choose Security Question</option>
										<option value="What's the Nickname of your best Friend?"> What's the Nickname of your best Friend?</option>
										<option value="Who was your childhood hero?"> Who was your childhood hero?</option>
										<option value="In what year was your father born?"> In what year was your father born?</option>
										<option value="What is your favorite Song?"> What is your favorite Song?</option>
										<option value="Who was your childhood hero?"> Who was your childhood hero?</option>
										<option value="What was the last name of your favourite teacher?"> What was the last name of your favourite teacher?</option>
									</select>
									<label>Answer</label><input type="text" placeholder="Enter Security Question Answer" runat="server" id="SecurityAnswer" />  
                                    <h5 class="pull-right ErrorMsg"></h5>   
                                    <div class="clearfix"></div>
                                    <asp:Button ID="InsertAdmin" runat="server" Text="Add Admin" CssClass="btn center-block" OnClick="InsertAdmin_Click"/>
								</div>
							</div>
						</div>
					</div>
					<!-- Main Content -->
				</div>
				<!-- Second Column -->
			</div>
			<!-- Row  -->
		</div>
		<!-- Container-Fluid -->
    </form>
</body>
</html>
