<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisteredUsers.aspx.cs" Inherits="UI.Admin.RegisteredUsers" %>

<%@ Register Src="~/Admin/User Control File/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Admin/User Control File/SideNavigation.ascx" TagPrefix="uc1" TagName="SideNavigation" %>
<%@ Register Src="~/Admin/User Control File/TopNavigation.ascx" TagPrefix="uc1" TagName="TopNavigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>All Users - Dashboard</title>
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
						
						<!-- Breadcrumb -->
						<h2 class="heading">Registered Users</h2>
						<ol class="breadcrumb">
						  	<li><a href="Dashboard.aspx">Home</a></li>
						  	<li><a href="RegisteredUsers.aspx">Registered Users</a></li>
						  	<li class="active">Data</li>
						</ol>
						<!-- Breadcrumb -->

						<div class="registered-users">
							<div class="bg">
                                <div class="col-xs-12 col-sm-12 col-md-6 col-lg-6 column1">
								</div>
                                <div class="col-xs-12 col-sm-12 col-md-6 col-lg-6 column3 search text-right" style="padding: 0">
                                    <input type="text" runat="server" id="ReportSearch" placeholder="Search by Name" />
                                    <asp:Button ID="Search" runat="server" CssClass="btn btn-primary" Text="GO" OnClick="Search_Click" />
                                </div>
								<div class="clearfix"></div>
								<div class="table-responsive" runat="server" id="table">
									<table class="table table-responsive table-bordered table-hover ">
										<tr>
											<th>Regestration ID</th>
											<th>Full Name</th>
											<th>Nick Name</th>
											<th>Username</th>
											<th>Email</th>
											<th>Password</th>
											<th>Contact</th>
											<th>Age</th>
											<th>Join Date</th>
											<th>About</th>
											<th>Gander</th>
											<th>Image</th>
										</tr>
                                        <% if(DisplayRegistrationData.Count > 0)
                                           { 
                                               foreach(var data in DisplayRegistrationData)
                                               {%>
										<tr>
											<td><%= data.RegistrationID%></td>
											<td><%= data.FullName%></td>
											<td><%= data.Nickname%></td>
											<td><%= data.Username%></td>
											<td><%= data.Email%></td>
											<td><%= data.Password%></td>
											<td><%= data.ContactNumber%></td>
											<td><%= data.Age%>21</td>
											<td><%= data.JoinDate%></td>
											<td><%= data.About%></td>
											<td><%= data.Gander%></td>
											<td><img src="../<%= data.Image%>" width="35" height="35" style="object-fit: cover"></td>
										</tr>
                                        <%}}else
                                           Response.Write("<h5 class='text-center' style='font-weight:bold;margin-top:20px;margin-bottom:10px;letter-spacing: 1px;font-size:16px;'>Sorry, Missing People Reports are not Available at the Moment.</h5>");%>
									</table>
									<!-- Table -->
								</div>
								<!-- Table Responsive -->
                                
                                <% if (DisplayDataOnSearch != null)
                                         { %>
                                <div class="table-responsive">
									<table class="table table-responsive table-bordered table-hover ">
										<tr>
											<th>Regestration ID</th>
											<th>Full Name</th>
											<th>Nick Name</th>
											<th>Username</th>
											<th>Email</th>
											<th>Password</th>
											<th>Contact</th>
											<th>Age</th>
											<th>Join Date</th>
											<th>About</th>
											<th>Gander</th>
											<th>Image</th>
										</tr>
                                        <% if (DisplayDataOnSearch.Count > 0)
                                         {
                                             foreach (var data in DisplayDataOnSearch)
                                             {%>
										<tr>
											<td><%= data.RegistrationID%></td>
											<td><%= data.FullName%></td>
											<td><%= data.Nickname%></td>
											<td><%= data.Username%></td>
											<td><%= data.Email%></td>
											<td><%= data.Password%></td>
											<td><%= data.ContactNumber%></td>
											<td><%= data.Age%>21</td>
											<td><%= data.JoinDate%></td>
											<td><%= data.About%></td>
											<td><%= data.Gander%></td>
											<td><img src="../<%= data.Image%>" width="35" height="35" style="object-fit: cover"></td>
										</tr>
                                        <%}
                                         };%>
									</table>
									<!-- Table -->
								</div>
								<!-- Table Responsive -->
                                <%} %>
							</div>
							<!-- BG -->
						</div>
						<!-- Registetred User -->
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
