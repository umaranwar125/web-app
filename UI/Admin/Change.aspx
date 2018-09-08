<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Change.aspx.cs" Inherits="UI.Admin.ChangeUsername" %>

<%@ Register Src="~/Admin/User Control File/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Admin/User Control File/SideNavigation.ascx" TagPrefix="uc1" TagName="SideNavigation" %>
<%@ Register Src="~/Admin/User Control File/TopNavigation.ascx" TagPrefix="uc1" TagName="TopNavigation" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Change Admin Settings - Dashboard</title>
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
                                        <li class="active"><a href="Change.aspx"><i class="fa fa-key" aria-hidden="true"></i>&nbsp;Change Admin Username and Password</a></li>
                                        <li runat="server" id="AddAdminUser"><a href="AddAdmin.aspx"><i class="fa fa-user-plus" aria-hidden="true"></i>&nbsp;&nbsp;Add Another Admin</a></li>
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
									<img src="<%= data.Image%>" class="img img-responsive img-rounded center-block" width="490" height="490" />
									<h3><%= data.FullName%></h3>
									<h5><%= data.Title%></h5>
                                    <%} %>
								</div>
							</div>
							<div class="col-xs-12 col-sm-12 col-md-8 col-lg-8">
								<div class="information-bg" style="height: 950px">
                                    <h5 runat="server" id="Match" visible="false" style="color:green;font-size: 16px; margin-bottom: 20px;">Admin and Password has been successfully updated.</h5>
                                    <h5 runat="server" id="NotMatch" visible="false" style="color:red;font-size: 16px; margin-bottom: 20px;">Sorry, Your provided old Username or Password is not matched.</h5>
                                    <h4 class="text-center" style="color:#777777; letter-spacing: 1px; font-weight:bold;text-transform:uppercase;">Old Information</h4>
                                    <hr style="margin-top: 0px; margin-bottom: 30px;width: 20%;border: .5px solid #777777;" class="center-block" />
                                    <label>Admin Username</label><input type="text" placeholder="Enter Old Username" runat="server" id="OldUsername" />
									<label>Password 1</label><input type="text" placeholder="Enter Old Password 1" runat="server" id="OldPasswordOne" />
									<label>Password 2</label><input type="text" placeholder="Enter Old Password 2" runat="server" id="OldPasswordTwo" />  
                                    <h5 class="pull-right ErrorMsg"></h5>   
                                    <div class="clearfix"></div>

                                    <h4 class="text-center" style="color: #777777; letter-spacing: 1px;margin-top:0px; font-weight:bold;text-transform:uppercase;">New Information</h4>
                                    <hr style="margin-top: 0px; margin-bottom: 20px;width: 20%;border: .7px solid #777777;" class="center-block" />
                                    <label>Admin Username</label><input type="text" placeholder="Enter New Username" runat="server" id="NewUsername" />
                                    <label>Password 1</label><input type="text" placeholder="Enter New Password 1" runat="server" id="NewPasswordOne" />
									<label>Password 2</label><input type="text" placeholder="Enter New Password 2" runat="server" id="NewPasswordTwo" />
                                    <h5 class="pull-right ErrorMsg1"></h5>
                                    <div class="clearfix"></div>
                                    <div style="margin-bottom:-20px;"></div>
                                    <asp:Button ID="AdminLoginUpdate" runat="server" Text="Update" CssClass="btn center-block" OnClick="AdminLoginUpdate_Click"/>
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
