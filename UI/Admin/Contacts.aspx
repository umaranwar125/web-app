<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contacts.aspx.cs" Inherits="UI.Admin.Contacts" %>

<%@ Register Src="~/Admin/User Control File/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Admin/User Control File/SideNavigation.ascx" TagPrefix="uc1" TagName="SideNavigation" %>
<%@ Register Src="~/Admin/User Control File/TopNavigation.ascx" TagPrefix="uc1" TagName="TopNavigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>All Contacts - Dashboard</title>
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
						<h2 class="heading">Contacts</h2>
						<ol class="breadcrumb">
						  	<li><a href="Dashboard.aspx">Home</a></li>
						  	<li><a href="Contacts.aspx">Contacts</a></li>
						  	<li class="active">Data</li>
						</ol>
						<!-- Breadcrumb -->

						<div class="registered-users">
							<div class="bg">
								<div class="clearfix"></div>
								<div class="table-responsive">
                                    <div class="alert alert-success" runat="server" id="alert_delete" role="alert" style="display: none; margin-top: 10px;"><span class="glyphicon glyphicon-thumbs-up" aria-hidden="true"></span>&nbsp;Report has been deleted successfully.</div>
									<table class="table table-responsive table-bordered table-hover ">
										<tr>
											<th>Delete</th>
											<th>Contact ID</th>
											<th>Registration ID</th>
											<th>Email</th>
											<th>Contact Number</th>
											<th>Subject</th>
											<th>Message</th>
										</tr>
                                        <%if (DisplayContactData.Count > 0)
                                          {
                                              foreach (var data in DisplayContactData)
                                              { %>
										<tr>
											<td><a href="Contacts.aspx?Contacts_Id=<%= data.ContactID %>" class="btn btn-danger">Delete</a></td>  
											<td><%= data.ContactID%></td>
											<td><%= data.RegistrationID%></td>
											<td><%= data.Email%></td>
											<td><%= data.ContactNumber%></td>
											<td><%= data.Subject%></td>
											<td><%= data.Message%></td>
										</tr>
                                        <%}
                                          }else
                                       Response.Write("<h5 class='text-center' style='font-weight:bold;margin-top:20px;margin-bottom:10px;letter-spacing: 1px;font-size:16px;'>Sorry, No Contacts is submitted by the user yet.</h5>");  %>
									</table>
									<!-- Table -->
								</div>
								<!-- Table Responsive -->
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
