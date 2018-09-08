<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="UI.Admin.Feedback" %>

<%@ Register Src="~/Admin/User Control File/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Admin/User Control File/SideNavigation.ascx" TagPrefix="uc1" TagName="SideNavigation" %>
<%@ Register Src="~/Admin/User Control File/TopNavigation.ascx" TagPrefix="uc1" TagName="TopNavigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>All Feedbacks - Dashboard</title>
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
						<h2 class="heading">Feedback</h2>
						<ol class="breadcrumb">
						  	<li><a href="Dashboard.aspx">Home</a></li>
						  	<li><a href="Feedback.aspx">Feedback</a></li>
						  	<li class="active">Data</li>
						</ol>
						<!-- Breadcrumb -->

						<div class="registered-users">
							<div class="bg">
								<div class="clearfix"></div>
								<div class="table-responsive">
									<table class="table table-responsive table-bordered table-hover ">
										<tr>
											<th>Delete</th>
											<th>Feedback ID</th>
											<th>Registration ID</th>
											<th>First time you have visisted Website?</th>
											<th>Did you find what you needed?</th>
											<th>Is Information easy to find?</th>
											<th>Opinion on Website</th>
											<th>Will you visit the website again?</th>
											<th>Suggestion</th>
										</tr>
                                        <%if (DisplayFeedbackData.Count > 0)
                                          {
                                              foreach (var data in DisplayFeedbackData)
                                              { %>
										<tr>
                                            <td><a href="Feedback.aspx?Feedback_Delete_Id=<%= data.FeedbackID %>" class="btn btn-danger">Delete</a></td>
											<td><%= data.FeedbackID %></td>
											<td><%= data.RegistrationID%></td>
											<td><%= data.VisitWebsite%></td>
											<td><%= data.FindYourNeed%></td>
											<td><%= data.EasyToFind%></td>
											<td><%= data.YourOpinion%></td>
											<td><%= data.Likelihood%></td>
											<td><%= data.Suggestions%></td>
										</tr>
                                        <%}
                                          }else
                                       Response.Write("<h5 class='text-center' style='font-weight:bold;margin-top:20px;margin-bottom:10px;letter-spacing: 1px;font-size:16px;'>Sorry, No Feedbacks are available.</h5>");  %>
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
