﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="UI.Admin.Profile" %>

<%@ Register Src="~/Admin/User Control File/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Admin/User Control File/TopNavigation.ascx" TagPrefix="uc1" TagName="TopNavigation" %>
<%@ Register Src="~/Admin/User Control File/SideNavigation.ascx" TagPrefix="uc1" TagName="SideNavigation" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profile - Dashboard</title>
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
                                    <%foreach(var data in DisplayAdminProfile)
                                      { %>
                                    <a class="navbar-brand" href="Profile.aspx"><span><%= data.FullName %></span>'s Profile</a>
                                    <%} %>
                                </div>
                                <!-- Collect the nav links, forms, and other content for toggling -->
                                <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                                    <ul class="nav navbar-nav navbar-right">
                                        <li><a href="Change.aspx"><i class="fa fa-key" aria-hidden="true"></i>&nbsp;Change Admin Username and Password</a></li>
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
                                    <%foreach(var data in DisplayAdminProfile)
                                      { %>
									<img src="<%= data.Image%>" class="img img-responsive img-rounded center-block" width="490" height="490" />
									<h3><%= data.FullName%></h3>
									<h5><%= data.Title%></h5>
                                    <%} %>
								</div>
							</div>
							<div class="col-xs-12 col-sm-12 col-md-8 col-lg-8">
								<div class="information-bg">
                                    <h5 class="text-center" runat="server" visible="false" id="EmailFailure" style="margin-top:-10px;margin-bottom:15px;color: red;font-size:16px;font-weight:bold"><span style="font-size:19px;font-weight:bold;">*</span> Email is not in correct format</h5>
                                    <h5 class="text-center" runat="server" visible="false" id="Error" style="margin-top:-10px;margin-bottom:15px;color: red;font-size:16px;font-weight:bold"><span style="font-size:19px;font-weight:bold;">*</span> Image is Required</h5>
									<label>Full Name</label><input type="text" placeholder="Ex: Umar Anwar" runat="server" id="FullName" />
									<label>Title</label><input type="text" placeholder="Max 30 Cahracters" runat="server" id="Title" />
									<label>Email</label><input type="text" placeholder="abc@xyz.com" runat="server" id="Email" />
									<label>Qualification</label>
									<select class="qualification" runat="server" id="Qualification">
										<option value="Qualification" class="selected" selected="" disabled="">Select your Qualification</option>
										<option value="FA/Fsc">FA/Fsc</option>
										<option value="BA/Bsc">BA/Bsc</option>
										<option value="MA/Msc">MA/Msc</option>
										<option value="BS">BS</option>
										<option value="MS">MS</option>
										<option value="PHd">PHd</option>
										<option value="Other">Other</option>
									</select>
									<label>Mobile No</label><input type="text" placeholder="Ex: 03159382193" runat="server" id="Contact">
									<textarea placeholder="Bio-Description" runat="server" id="Description"></textarea>
									<label class="image">Update Image</label><asp:FileUpload ID="Image" runat="server" CssClass="file" />
                                    <h5 class="pull-right ErrorMsg"></h5>
                                    <div class="clearfix"></div>
                                    <asp:Button ID="AdminProfileUpdate" runat="server" Text="Update Profile" CssClass="btn center-block" OnClick="AdminProfileUpdate_Click"/>
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
