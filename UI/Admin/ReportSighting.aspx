<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportSighting.aspx.cs" Inherits="UI.Admin.ReportSighting" %>

<%@ Register Src="~/Admin/User Control File/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Admin/User Control File/SideNavigation.ascx" TagPrefix="uc1" TagName="SideNavigation" %>
<%@ Register Src="~/Admin/User Control File/TopNavigation.ascx" TagPrefix="uc1" TagName="TopNavigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sighting Reports - Dashboard</title>
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
						<h2 class="heading">Report Sighting</h2>
						<ol class="breadcrumb">
						  	<li><a href="Dashboard.aspx">Home</a></li>
						  	<li><a href="ReportSighting.aspx">Report Sighting</a></li>
						  	<li class="active">Data</li>
						</ol>
						<!-- Breadcrumb -->

						<div class="all-reports">
							<div class="bg">
								<div class="col-xs-12 col-sm-7 col-md-6 col-lg-6 column1" style="padding: 0;" runat="server" id="Combo">
									<label>Select Category</label>
									<select class="category" runat="server" id="SelectTable">
										<option value="All Reports" selected="">All Reports</option>
										<option value="Missing People Sighting">Missing People Sighting</option>
										<option value="Missing Auto Mobile Sighting">Missing Auto Mobile Sighting</option>
										<option value="Missing Mobile Sighting">Missing Mobile Sighting</option>
										<option value="Missing CNIC Sighting">Missing CNIC Sighting</option>
									</select>
                                    <asp:Button ID="SelectThing" runat="server" CssClass="btn btn-primary" Text="Go" OnClick="SelectThing_Click" />
								</div>
                                <div class="col-xs-12 col-sm-12 col-md-2 col-lg-2 column2 text-center"></div>
                                <div class="col-xs-12 col-sm-5 col-md-4 col-lg-4 column3 text-right" style="padding: 0">
                                    <input type="text" runat="server" id="ReportSearch" placeholder="Search by Missing Object" />
                                    <asp:Button ID="Search" runat="server" CssClass="btn btn-primary" Text="GO" OnClick="Search_Click" />
                                </div>
								<div class="clearfix"></div>
                                    <div class="alert alert-success" runat="server" id="alert_delete" role="alert" style="display: none; margin-top: 10px;"><span class="glyphicon glyphicon-thumbs-up" aria-hidden="true"></span>&nbsp;Report has been deleted successfully.</div>
								<div class="table-responsive">
                                    <%if(DisplayReportSightingData.Count > 0)
                                      { %>
                                    <!-- All Reports -->
                                    <div runat="server" id="AllReports">
									<table class="table table-responsive table-bordered table-hover">
										<tr>
											<th>Delete</th>
											<th>Sighting ID</th>
											<th>Registration ID</th>
                                            <th>Reference Number</th>
                                            <th>Missing Object</th>
											<th>Missing Person Name</th>
											<th>Clothes</th>
											<th>Company Name</th>
											<th>Brand Name</th>
											<th>Color</th>
											<th>CNIC Number</th>
											<th>CNIC Family NUmber</th>
											<th>Found Place</th>
											<th>Found Date</th>
											<th>Was there CCTV Camera?</th>
											<th>What publicity did you see?</th>
											<th>Image</th>
											<th>Gander</th>
											<th>Your Name</th>
											<th>Your Email Address</th>
											<th>Contact Number</th>
											<th>Current Address</th>
											<th>May we contact you?</th>
										</tr>
                                        <%foreach(var Data in DisplayReportSightingData)
                                           { %>
										<tr>
                                            <td><a href="ReportSighting.aspx?Report_Sighting_Delete_Id=<%= Data.SightingID %>" class="btn btn-danger">Delete</a></td>
											<td><%= Data.SightingID%></td>
											<td><%= Data.RegistrationID%></td>
											<td><%= Data.ReferenceNumber%></td>
                                            <td><%= Data.MissingThingName%></td>
											<td><%= Data.MissingPersonName%></td>
											<td><%= Data.Clothes%></td>
											<td><%= Data.CompanyName%></td>
											<td><%= Data.BrandName%></td>
											<td><%= Data.Color%></td>
											<td><%= Data.CNICNumber%></td>
											<td><%= Data.CNICFamilyNumber%></td>
											<td><%= Data.FoundPlace%></td>
											<td><%= Data.FoundDate%></td>
											<td><%= Data.CCTVCamera%></td>
											<td><%= Data.Advertisement%></td>
											<td><img src="../<%= Data.Image%>" width="35" height="35" style="object-fit: cover"></td>
											<td><%= Data.Gander%></td>
											<td><%= Data.YourName%></td>
											<td><%= Data.EmailAddress%></td>
											<td><%= Data.ContactNumber%></td>
											<td><%= Data.CurrentAddress%></td>
											<td><%= Data.AskQuestion%></td>
										</tr>
                                        <%}%>
									</table>
									<!-- Table -->
                                    </div>

                                    <!-- Missing People Sighting Reports -->
                                    <div runat="server" id="MissingPeople" visible="false">
									<table class="table table-responsive table-bordered table-hover">
										<tr>
											<th>Delete</th>
											<th>ID</th>
											<th>Registration ID</th>
                                            <th>Reference Number</th>
											<th>Missing Object</th>
											<th>Missing Person Name</th>
											<th>Clothes</th>
                                            <th>Image</th>
											<th>Gander</th>
											<th>Found Place</th>
											<th>Found Date</th>
											<th>Was there CCTV Camera?</th>
											<th>What publicity did you see?</th>
											<th>Your Name</th>
											<th>Your Email Address</th>
											<th>Contact Number</th>
											<th>Current Address</th>
											<th>May we contact you?</th>
										</tr>
                                          <%  foreach(var Data in DisplayReportSightingData)
                                              {
                                                  if (Data.MissingThingName == "Person")
                                                  {
                                                      %>
										<tr>
                                            <td><a href="ReportSighting.aspx?Report_Sighting_Delete_Id=<%= Data.SightingID %>" class="btn btn-danger">Delete</a></td>
											<td><%= Data.SightingID%></td>
											<td><%= Data.RegistrationID%></td>
											<td><%= Data.ReferenceNumber%></td>
                                            <td><%= Data.MissingThingName%></td>
                                            <td><%= Data.MissingPersonName%></td>
											<td><%= Data.Clothes%></td>
                                            <td><img src="../<%= Data.Image%>" width="35" height="35"></td>
											<td><%= Data.Gander%></td>
                                            <td><%= Data.FoundPlace%></td>
											<td><%= Data.FoundDate%></td>
											<td><%= Data.CCTVCamera%></td>
											<td><%= Data.Advertisement%></td>
											<td><%= Data.YourName%></td>
											<td><%= Data.EmailAddress%></td>
											<td><%= Data.ContactNumber%></td>
											<td><%= Data.CurrentAddress%></td>
											<td><%= Data.AskQuestion%></td>
										</tr>
                                        <%}
                                           }%>
									</table>
									<!-- Table -->
                                    </div>

                                    <!-- Missing Auto Mobile Reports -->
                                    <div runat="server" id="MissingAuto" visible="false">
									<table class="table table-responsive table-bordered table-hover">
										<tr>
											<th>Delete</th>
											<th>Sighting ID</th>
											<th>Registration ID</th>
											<th>Reference Number</th>
											<th>Missing Object</th>
                                            <th>Company Name</th>
                                            <th>Brand Name</th>
                                            <th>Color</th>
											<th>Image</th>
											<th>Found Place</th>
											<th>Found Date</th>
											<th>Was there CCTV Camera?</th>
											<th>What publicity did you see?</th>
											<th>Your Name</th>
											<th>Your Email Address</th>
											<th>Contact Number</th>
											<th>Current Address</th>
											<th>May we contact you?</th>
										</tr>
                                        <% foreach(var Data in DisplayReportSightingData)
                                           {
                                               if(Data.MissingThingName == "Auto Mobile")
                                               { %>
										<tr>
                                            <td><a href="ReportSighting.aspx?Report_Sighting_Delete_Id=<%= Data.SightingID %>" class="btn btn-danger">Delete</a></td>
											<td><%= Data.SightingID%></td>
											<td><%= Data.RegistrationID%></td>
											<td><%= Data.ReferenceNumber%></td>
											<td><%= Data.MissingThingName%></td>
                                            <td><%= Data.CompanyName%></td>
											<td><%= Data.BrandName%></td>
											<td><%= Data.Color%></td>
                                            <td><img src="../<%= Data.Image%>" width="35" height="35"></td>
                                            <td><%= Data.FoundPlace%></td>
											<td><%= Data.FoundDate%></td>
											<td><%= Data.CCTVCamera%></td>
											<td><%= Data.Advertisement%></td>
											<td><%= Data.YourName%></td>
											<td><%= Data.EmailAddress%></td>
											<td><%= Data.ContactNumber%></td>
											<td><%= Data.CurrentAddress%></td>
											<td><%= Data.AskQuestion%></td>
										</tr>
                                        <%}}%>
									</table>
									<!-- Table -->
                                    </div>

                                    <!-- Missing Mobile Reports -->
                                    <div runat="server" id="MissingMobile" visible="false">
									<table class="table table-responsive table-bordered table-hover">
										<tr>
											<th>Delete</th>
											<th>Sighting ID</th>
											<th>Registration ID</th>
											<th>Reference Number</th>
											<th>Missing Object</th>
                                            <th>Brand Name</th>
                                            <th>Color</th>
                                            <th>Image</th>
											<th>Found Place</th>
											<th>Found Date</th>
											<th>Was there CCTV Camera?</th>
											<th>What publicity did you see?</th>
											<th>Your Name</th>
											<th>Your Email Address</th>
											<th>Contact Number</th>
											<th>Current Address</th>
											<th>May we contact you?</th>
										</tr>
                                       
                                       <%    foreach(var Data in DisplayReportSightingData)
                                             { 
                                                 if(Data.MissingThingName == "Mobile")
                                                 {%>
										<tr>
                                            <td><a href="ReportSighting.aspx?Report_Sighting_Delete_Id=<%= Data.SightingID %>" class="btn btn-danger">Delete</a></td>
											<td><%= Data.SightingID%></td>
											<td><%= Data.RegistrationID%></td>
											<td><%= Data.ReferenceNumber%></td>
											<td><%= Data.MissingThingName%></td>
											<td><%= Data.BrandName%></td>
											<td><%= Data.Color%></td>
                                            <td><img src="../<%= Data.Image%>" width="35" height="35"></td>
                                            <td><%= Data.FoundPlace%></td>
											<td><%= Data.FoundDate%></td>
											<td><%= Data.CCTVCamera%></td>
											<td><%= Data.Advertisement%></td>
											<td><%= Data.YourName%></td>
											<td><%= Data.EmailAddress%></td>
											<td><%= Data.ContactNumber%></td>
											<td><%= Data.CurrentAddress%></td>
											<td><%= Data.AskQuestion%></td>
										</tr>
                                        <%}}
                                          %>
									</table>
									<!-- Table -->
                                    </div>

                                    <!-- Missing CNIC Reports -->
                                    <div runat="server" id="MissingCNIC" visible="false">
									<table class="table table-responsive table-bordered table-hover">
										<tr>
											<th>Delete</th>
											<th>Sighting ID</th>
											<th>Registration ID</th>
											<th>Reference Number</th>
											<th>Missing Object</th>
                                            <th>CNIC Number</th>
                                            <th>CNIC Family Number</th>
                                            <th>Image</th>
											<th>Found Place</th>
											<th>Found Date</th>
											<th>Was there CCTV Camera?</th>
											<th>What publicity did you see?</th>
											<th>Your Name</th>
											<th>Your Email Address</th>
											<th>Contact Number</th>
											<th>Current Address</th>
											<th>May we contact you?</th>
										</tr>
                                        <%foreach(var Data in DisplayReportSightingData)
                                          { 
                                              if(Data.MissingThingName == "CNIC")
                                              {%>
										<tr>
                                            <td><a href="ReportSighting.aspx?Report_Sighting_Delete_Id=<%= Data.SightingID %>" class="btn btn-danger">Delete</a></td>
											<td><%= Data.SightingID%></td>
											<td><%= Data.RegistrationID%></td>
											<td><%= Data.ReferenceNumber%></td>
											<td><%= Data.MissingThingName%></td>
                                            <td><%= Data.CNICNumber%></td>
											<td><%= Data.CNICFamilyNumber%></td>
                                            <td><img src="../<%= Data.Image%>" width="35" height="35"></td>
                                            <td><%= Data.FoundPlace%></td>
											<td><%= Data.FoundDate%></td>
											<td><%= Data.CCTVCamera%></td>
											<td><%= Data.Advertisement%></td>
											<td><%= Data.YourName%></td>
											<td><%= Data.EmailAddress%></td>
											<td><%= Data.ContactNumber%></td>
											<td><%= Data.CurrentAddress%></td>
											<td><%= Data.AskQuestion%></td>
										</tr>
                                        <%}}%>
									</table>
									<!-- Table -->
                                    </div>
								    <%}else
                                       Response.Write("<h5 class='text-center' style='font-weight:bold;margin-top:20px;margin-bottom:10px;letter-spacing: 1px;font-size:16px;'>Sorry, No Reports are Available at the Moment.</h5>");  %>
                                
                                    <% if(DisplayDataOnSearch != null)
                                        {
                                            %>
                                    
                                    <table class="table table-responsive table-bordered table-hover">
										<tr>
											<th>Delete</th>
											<th>Sighting ID</th>
											<th>Registration ID</th>
                                            <th>Reference Number</th>
                                            <th>Missing Object</th>
											<th>Missing Person Name</th>
											<th>Clothes</th>
											<th>Company Name</th>
											<th>Brand Name</th>
											<th>Color</th>
											<th>CNIC Number</th>
											<th>CNIC Family NUmber</th>
											<th>Found Place</th>
											<th>Found Date</th>
											<th>Was there CCTV Camera?</th>
											<th>What publicity did you see?</th>
											<th>Image</th>
											<th>Gander</th>
											<th>Your Name</th>
											<th>Your Email Address</th>
											<th>Contact Number</th>
											<th>Current Address</th>
											<th>May we contact you?</th>
										</tr>
                                        <%if (DisplayDataOnSearch.Count > 0)
                                            { %>
                                        <%foreach (var Data in DisplayDataOnSearch)
                                            { %>
										<tr>
                                            <td><a href="ReportSighting.aspx?Report_Sighting_Delete_Id=<%= Data.SightingID %>" class="btn btn-danger">Delete</a></td>
											<td><%= Data.SightingID%></td>
											<td><%= Data.RegistrationID%></td>
											<td><%= Data.ReferenceNumber%></td>
                                            <td><%= Data.MissingThingName%></td>
											<td><%= Data.MissingPersonName%></td>
											<td><%= Data.Clothes%></td>
											<td><%= Data.CompanyName%></td>
											<td><%= Data.BrandName%></td>
											<td><%= Data.Color%></td>
											<td><%= Data.CNICNumber%></td>
											<td><%= Data.CNICFamilyNumber%></td>
											<td><%= Data.FoundPlace%></td>
											<td><%= Data.FoundDate%></td>
											<td><%= Data.CCTVCamera%></td>
											<td><%= Data.Advertisement%></td>
											<td><img src="../<%= Data.Image%>" width="35" height="35" style="object-fit: cover"></td>
											<td><%= Data.Gander%></td>
											<td><%= Data.YourName%></td>
											<td><%= Data.EmailAddress%></td>
											<td><%= Data.ContactNumber%></td>
											<td><%= Data.CurrentAddress%></td>
											<td><%= Data.AskQuestion%></td>
										</tr>
                                        <%}}
                                            }%>
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
