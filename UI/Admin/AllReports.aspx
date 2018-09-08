<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllReports.aspx.cs" Inherits="UI.Admin.AllReports" %>

<%@ Register Src="~/Admin/User Control File/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Admin/User Control File/SideNavigation.ascx" TagPrefix="uc1" TagName="SideNavigation" %>
<%@ Register Src="~/Admin/User Control File/TopNavigation.ascx" TagPrefix="uc1" TagName="TopNavigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>All Reports - Dashboard</title>
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
                        <h2 class="heading">All Reports</h2>
                        <ol class="breadcrumb">
                            <li><a href="Dashboard.aspx">Home</a></li>
                            <li><a href="AllReports.aspx">All Reports</a></li>
                            <li class="active">Data</li>
                        </ol>
                        <!-- Breadcrumb -->

                        <div class="all-reports">
                            <div class="bg">
                                <div class="col-xs-12 col-sm-7 col-md-6 col-lg-6 column1" style="padding: 0;">
                                    <label>Select Category</label>
                                    <select class="category" runat="server" id="SelectTable">
                                        <option value="Missing People" selected="">Missing People</option>
                                        <option value="Missing Thing">Missing Thing</option>
                                        <option value="Unidentified People">Unidentified People</option>
                                    </select>
                                    <asp:Button ID="TableSelectButton" CssClass="btn btn-primary" runat="server" Text="GO" OnClick="TableSelectButton_Click" />
                                </div>
                                <div class="col-xs-12 col-sm-12 col-md-2 col-lg-2 column2 text-center"></div>
                                <div class="col-xs-12 col-sm-5 col-md-4 col-lg-4 column3 text-right" style="padding: 0">
                                    <input type="text" id="SearchReport" runat="server" placeholder="Search by Name" />
                                    <asp:Button ID="Search" runat="server" CssClass="btn btn-primary" Text="GO" OnClick="Search_Click" />
                                </div>
                                <div class="clearfix"></div>
                                <div class="table-responsive">
                                    <div class="alert alert-success" runat="server" id="alert_delete" role="alert" style="display: none; margin-top: 10px;"><span class="glyphicon glyphicon-thumbs-up" aria-hidden="true"></span>&nbsp;Report has been deleted successfully.</div>
                                    <div class="alert alert-success" runat="server" id="alert_approve" role="alert" style="display: none; margin-top: 10px;"><span class="glyphicon glyphicon-thumbs-up" aria-hidden="true"></span>&nbsp;Report has been approved successfully.</div>
                                    <!-- Missin People -->
                                    <div id="MissingPeoples" runat="server">
                                        <table class="table table-responsive table-bordered table-hover" style="margin-bottom: 30px;">
                                            <tr>
                                                <th>Approve</th>
                                                <th>Delete</th>
                                                <th>ID</th>
                                                <th>Registration ID</th>
                                                <th>Status</th>
                                                <th>Reference Number</th>
                                                <th>Full Name</th>
                                                <th>Nick Name</th>
                                                <th>CNIC</th>
                                                <th>Father/Guardian Name</th>
                                                <th>Father/Guardian CNIC</th>
                                                <th>Contact #1</th>
                                                <th>Contact #2</th>
                                                <th>Permanent Address</th>
                                                <th>Current Address</th>
                                                <th>Religion</th>
                                                <th>Age</th>
                                                <th>Missing Place</th>
                                                <th>Missing Date</th>
                                                <th>Tribe</th>
                                                <th>Language</th>
                                                <th>Cloth Color</th>
                                                <th>Height</th>
                                                <th>Weight</th>
                                                <th>Eyes Color</th>
                                                <th>Hair Color</th>
                                                <th>Description</th>
                                                <th>Gender</th>
                                                <th>Image</th>
                                                <th>Views</th>
                                            </tr>
                                            <%
                                                if (DisplayMissingPeopleDatainTable.Count > 0)
                                                {
                                                    foreach (var myData in DisplayMissingPeopleDatainTable)
                                                    { %>
                                            <tr>
                                                <td><a href="AllReports.aspx?Missing_People_Id=<%= myData.PeopleID %>" class="btn btn-success">Approve</a></td>
                                                <td><a href="AllReports.aspx?Missing_People_Delete_Id=<%= myData.PeopleID %>" class="btn btn-danger">Delete</a></td>
                                                <td><%= myData.PeopleID %></td>
                                                <td><%= myData.RegistrationID %></td>
                                                <% if (myData.Status == "Pending")
                                                { %>
                                                <td style="color: red; font-weight: bold;"><%= myData.Status %></td>
                                                <%}
                                                    else if (myData.Status == "Approved")
                                                    { %>
                                                <td style="color: green; font-weight: bold;"><%= myData.Status %></td>
                                                <%} %>
                                                <td><%= myData.ReferenceNumber %></td>
                                                <td><%= myData.FullName %></td>
                                                <td><%= myData.NickName %></td>
                                                <td><%= myData.CNIC%></td>
                                                <td><%= myData.FatherGuardianName%></td>
                                                <td><%= myData.FatherGuardianCNIC%></td>
                                                <td><%= myData.ContactNumber%></td>
                                                <td><%= myData.AnotherContactNumber%></td>
                                                <td><%= myData.PermanentAddress%></td>
                                                <td><%= myData.CurrentAddress%></td>
                                                <td><%= myData.Religion%></td>
                                                <td><%= myData.Age%></td>
                                                <td><%= myData.MissingPlace%></td>
                                                <td><%= myData.MissingDate%></td>
                                                <td><%= myData.Tribe%></td>
                                                <td><%= myData.LAnguage%></td>
                                                <td><%= myData.ClothesColor%></td>
                                                <td><%= myData.Height%></td>
                                                <td><%= myData.Weight%></td>
                                                <td><%= myData.EyeColor%></td>
                                                <td><%= myData.HairColor%></td>
                                                <td><%= myData.Description%></td>
                                                <td><%= myData.Gander%></td>
                                                <td>
                                                    <img src="../<%= myData.Image%>" width="35" height="35" style="object-fit: cover"></td>
                                                <td><%= myData.Count%></td>
                                            </tr>
                                            <%}
                                                }
                                                else
                                                    Response.Write("<h5 class='text-center'>Sorry, No Reports are available at the moment.</h5>");
                                            %>
                                        </table>
                                        <!-- Table -->
                                    </div>

                                    <!-- Missing Thing -->
                                    <div runat="server" id="MissingThings" visible="false">
                                        <table class="table table-responsive table-bordered table-hover">
                                            <tr>
                                                <th>Approve</th>
                                                <th>Delete</th>
                                                <th>ID</th>
                                                <th>Registration ID</th>
                                                <th>Status</th>
                                                <th>Reference Number</th>
                                                <th>Owner Name</th>
                                                <th>Owner CNIC</th>
                                                <th>Father Guardian Name</th>
                                                <th>Father Guardian CNIC</th>
                                                <th>Contact #1</th>
                                                <th>Contact #2</th>
                                                <th>Thing Name</th>
                                                <th>Company Name</th>
                                                <th>Brand Name</th>
                                                <th>Engine Number</th>
                                                <th>Chasses Number</th>
                                                <th>Color</th>
                                                <th>Model</th>
                                                <th>IMEI</th>
                                                <th>Missing Place</th>
                                                <th>Missing Date</th>
                                                <th>Description</th>
                                                <th>CNIC Number </th>
                                                <th>Unique Identification</th>
                                                <th>Date of Birth</th>
                                                <th>Family Number</th>
                                                <th>Permanent Address</th>
                                                <th>Current Address</th>
                                                <th>Gander</th>
                                                <th>Image</th>
                                                <th>Views</th>
                                            </tr>
                                            <% if (DisplayMissingThingDatainTable.Count > 0)
                                                {
                                                    foreach (var myData in DisplayMissingThingDatainTable)
                                                    { %>
                                            <tr>
                                                <td><a href="AllReports.aspx?Missing_Thing_Id=<%= myData.ThingID %>" class="btn btn-success">Approve</a></td>
                                                <td><a href="AllReports.aspx?Missing_Thing_Delete_Id=<%= myData.ThingID%>" class="btn btn-danger">Delete</a></td>
                                                <td><%= myData.ThingID%></td>
                                                <td><%= myData.RegistrationID%></td>
                                                <%if (myData.Status == "Pending")
                                                { %>
                                                <td style="color: red; font-weight: bold"><%= myData.Status%></td>
                                                <%}
                                                    else if (myData.Status == "Approved")
                                                    { %>
                                                <td style="color: green; font-weight: bold"><%= myData.Status%></td>
                                                <%} %>
                                                <td><%= myData.ReferenceNumber%></td>
                                                <td><%= myData.OwnerName%></td>
                                                <td><%= myData.OwnerCNIC%></td>
                                                <td><%= myData.FatherGuardianName%></td>
                                                <td><%= myData.FatherGuardianCNIC%></td>
                                                <td><%= myData.ContactNumber%></td>
                                                <td><%= myData.AnotherContactNumber%></td>
                                                <td style="font-weight: bold"><%= myData.ThingName%></td>
                                                <td><%= myData.CompanyName%></td>
                                                <td>Q Mobile</td>
                                                <td><%= myData.EngineNumber%></td>
                                                <td><%= myData.ChassesNumber%></td>
                                                <td>black</td>
                                                <td>Qi6</td>
                                                <td><%= myData.IMEI%></td>
                                                <td><%= myData.MissingPlace%></td>
                                                <td><%= myData.MissingDate%></td>
                                                <td><%= myData.Description%></td>
                                                <td><%= myData.CNICNumber%></td>
                                                <td><%= myData.UniqueIdentification%></td>
                                                <td><%= myData.DateOfBirth%></td>
                                                <td><%= myData.FamilyNumber%></td>
                                                <td><%= myData.PermanentAddress%></td>
                                                <td><%= myData.CurrentAddress%></td>
                                                <td><%= myData.Gander%></td>
                                                <td>
                                                    <img src="../<%= myData.Image%>" width="35" height="35" style="object-fit: cover" /></td>
                                                <td><%= myData.Count%></td>
                                            </tr>
                                            <%}
                                                }
                                                else
                                                    Response.Write("<h5 class='text-center'>Sorry, No Reports are available at the moment.</h5>");
                                            %>
                                        </table>
                                        <!-- Table -->
                                    </div>

                                    <!-- Unidentified People -->
                                    <div runat="server" visible="false" id="UnidentifiedPeoples">
                                        <table class="table table-responsive table-bordered table-hover">
                                            <tr>
                                                <th>Approve</th>
                                                <th>Delete</th>
                                                <th>ID</th>
                                                <th>Registration ID</th>
                                                <th>Status</th>
                                                <th>Reference Number</th>
                                                <th>Full Name</th>
                                                <th>Father Guardian Name</th>
                                                <th>Contact Number</th>
                                                <th>Religion</th>
                                                <th>Age</th>
                                                <th>Unique Identification</th>
                                                <th>Found Place</th>
                                                <th>Language</th>
                                                <th>Cloth Color</th>
                                                <th>Eye Color</th>
                                                <th>Description</th>
                                                <th>Gander</th>
                                                <th>Image</th>
                                                <th>Views</th>
                                            </tr>
                                            <% if (DisplayUnidentifiedPeopleDatainTable.Count > 0)
                                                {
                                                    foreach (var myData in DisplayUnidentifiedPeopleDatainTable)
                                                    { %>
                                            <tr>
                                                <td><a href="AllReports.aspx?Unidentified_People_Id=<%= myData.UnindentifiedID %>" class="btn btn-success">Approve</a></td>
                                                <td><a href="AllReports.aspx?Unidentified_People_Delete_Id=<%= myData.UnindentifiedID%>" class="btn btn-danger">Delete</a></td>
                                                <td><%= myData.UnindentifiedID%></td>
                                                <td><%= myData.RegistrationID%></td>
                                                <%if (myData.Status == "Pending")
                                                    { %>
                                                <td style="color: red; font-weight: bold"><%= myData.Status%></td>
                                                <%}
                                                    else if (myData.Status == "Approved")
                                                    { %>
                                                <td style="color: green; font-weight: bold"><%= myData.Status%></td>
                                                <%} %>
                                                <td><%= myData.ReferenceNumber%></td>
                                                <td><%= myData.FullName%></td>
                                                <td><%= myData.FatherGuardianName%></td>
                                                <td><%= myData.ContactNumber%></td>
                                                <td><%= myData.Religion%></td>
                                                <td><%= myData.Age%></td>
                                                <td><%= myData.UniqueIdentification%></td>
                                                <td><%= myData.FoundPlace%></td>
                                                <td><%= myData.Language%></td>
                                                <td><%= myData.ClothColor%></td>
                                                <td><%= myData.EyesColor%></td>
                                                <td><%= myData.Description%></td>
                                                <td><%= myData.Gander%></td>
                                                <td>
                                                    <img src="../<%= myData.Image%>" width="35" height="35" style="object-fit: cover"></td>
                                                <td><%= myData.Count%></td>
                                            </tr>
                                            <%}
                                                }
                                                else
                                                    Response.Write("<h5 class='text-center'>Sorry, No Reports are available at the moment.</h5>"); %>
                                        </table>
                                        <!-- Table -->
                                    </div>
                                    </div>
                                <!-- Table Responsive -->
                                    <%-- Searching System  --%>

                                    <div class="table-responsive">
                                    <% if (SearchPeopleDataInRegularSearchBar != null)
                                             { %>
                                        <br />
                                        <h3>Missing People Record</h3>
                                    <table class="table table-responsive table-bordered table-hover" style="margin-bottom: 30px;">
                                            <tr>
                                                <th>Approve</th>
                                                <th>Delete</th>
                                                <th>ID</th>
                                                <th>Registration ID</th>
                                                <th>Status</th>
                                                <th>Reference Number</th>
                                                <th>Full Name</th>
                                                <th>Nick Name</th>
                                                <th>CNIC</th>
                                                <th>Father/Guardian Name</th>
                                                <th>Father/Guardian CNIC</th>
                                                <th>Contact #1</th>
                                                <th>Contact #2</th>
                                                <th>Permanent Address</th>
                                                <th>Current Address</th>
                                                <th>Religion</th>
                                                <th>Age</th>
                                                <th>Missing Place</th>
                                                <th>Missing Date</th>
                                                <th>Tribe</th>
                                                <th>Language</th>
                                                <th>Cloth Color</th>
                                                <th>Height</th>
                                                <th>Weight</th>
                                                <th>Eyes Color</th>
                                                <th>Hair Color</th>
                                                <th>Description</th>
                                                <th>Gender</th>
                                                <th>Image</th>
                                                <th>Views</th>
                                            </tr>
                                            <%
                                             if (SearchPeopleDataInRegularSearchBar.Count > 0)
                                             {
                                                 foreach (var myData in SearchPeopleDataInRegularSearchBar)
                                                 { %>
                                            <tr>
                                                <td><a href="AllReports.aspx?Missing_People_Id=<%= myData.PeopleID %>" class="btn btn-success">Approve</a></td>
                                                <td><a href="AllReports.aspx?Missing_People_Delete_Id=<%= myData.PeopleID %>" class="btn btn-danger">Delete</a></td>
                                                <td><%= myData.PeopleID %></td>
                                                <td><%= myData.RegistrationID %></td>
                                                <% if (myData.Status == "Pending")
                                             { %>
                                                <td style="color: red; font-weight: bold;"><%= myData.Status %></td>
                                                <%}
                                             else if (myData.Status == "Approved")
                                             { %>
                                                <td style="color: green; font-weight: bold;"><%= myData.Status %></td>
                                                <%} %>
                                                <td><%= myData.ReferenceNumber %></td>
                                                <td><%= myData.FullName %></td>
                                                <td><%= myData.NickName %></td>
                                                <td><%= myData.CNIC%></td>
                                                <td><%= myData.FatherGuardianName%></td>
                                                <td><%= myData.FatherGuardianCNIC%></td>
                                                <td><%= myData.ContactNumber%></td>
                                                <td><%= myData.AnotherContactNumber%></td>
                                                <td><%= myData.PermanentAddress%></td>
                                                <td><%= myData.CurrentAddress%></td>
                                                <td><%= myData.Religion%></td>
                                                <td><%= myData.Age%></td>
                                                <td><%= myData.MissingPlace%></td>
                                                <td><%= myData.MissingDate%></td>
                                                <td><%= myData.Tribe%></td>
                                                <td><%= myData.LAnguage%></td>
                                                <td><%= myData.ClothesColor%></td>
                                                <td><%= myData.Height%></td>
                                                <td><%= myData.Weight%></td>
                                                <td><%= myData.EyeColor%></td>
                                                <td><%= myData.HairColor%></td>
                                                <td><%= myData.Description%></td>
                                                <td><%= myData.Gander%></td>
                                                <td>
                                                    <img src="../<%= myData.Image%>" width="35" height="35" style="object-fit: cover"></td>
                                                <td><%= myData.Count%></td>
                                            </tr>
                                            <%}
                                             }
                                            %>
                                        </table>
                                    <%} %>
                                        <!-- Table -->
                                        </div>

                                    <div class="table-responsive">
                                    <% if (SearchThingDataInRegularSearchBar != null)
                                             { %>
                                        <br />
                                        <h3>Missing Things Record</h3>
                                    <table class="table table-responsive table-bordered table-hover">
                                            <tr>
                                                <th>Approve</th>
                                                <th>Delete</th>
                                                <th>ID</th>
                                                <th>Registration ID</th>
                                                <th>Status</th>
                                                <th>Reference Number</th>
                                                <th>Owner Name</th>
                                                <th>Owner CNIC</th>
                                                <th>Father Guardian Name</th>
                                                <th>Father Guardian CNIC</th>
                                                <th>Contact #1</th>
                                                <th>Contact #2</th>
                                                <th>Thing Name</th>
                                                <th>Company Name</th>
                                                <th>Brand Name</th>
                                                <th>Engine Number</th>
                                                <th>Chasses Number</th>
                                                <th>Color</th>
                                                <th>Model</th>
                                                <th>IMEI</th>
                                                <th>Missing Place</th>
                                                <th>Missing Date</th>
                                                <th>Description</th>
                                                <th>CNIC Number </th>
                                                <th>Unique Identification</th>
                                                <th>Date of Birth</th>
                                                <th>Family Number</th>
                                                <th>Permanent Address</th>
                                                <th>Current Address</th>
                                                <th>Gander</th>
                                                <th>Image</th>
                                                <th>Views</th>
                                            </tr>
                                            <% if (SearchThingDataInRegularSearchBar.Count > 0)
                                             {
                                                 foreach (var myData in SearchThingDataInRegularSearchBar)
                                                 { %>
                                            <tr>
                                                <td><a href="AllReports.aspx?Missing_Thing_Id=<%= myData.ThingID %>" class="btn btn-success">Approve</a></td>
                                                <td><a href="AllReports.aspx?Missing_Thing_Delete_Id=<%= myData.ThingID%>" class="btn btn-danger">Delete</a></td>
                                                <td><%= myData.ThingID%></td>
                                                <td><%= myData.RegistrationID%></td>
                                                <%if (myData.Status == "Pending")
                                             { %>
                                                <td style="color: red; font-weight: bold"><%= myData.Status%></td>
                                                <%}
                                             else if (myData.Status == "Approved")
                                             { %>
                                                <td style="color: green; font-weight: bold"><%= myData.Status%></td>
                                                <%} %>
                                                <td><%= myData.ReferenceNumber%></td>
                                                <td><%= myData.OwnerName%></td>
                                                <td><%= myData.OwnerCNIC%></td>
                                                <td><%= myData.FatherGuardianName%></td>
                                                <td><%= myData.FatherGuardianCNIC%></td>
                                                <td><%= myData.ContactNumber%></td>
                                                <td><%= myData.AnotherContactNumber%></td>
                                                <td style="font-weight: bold"><%= myData.ThingName%></td>
                                                <td><%= myData.CompanyName%></td>
                                                <td>Q Mobile</td>
                                                <td><%= myData.EngineNumber%></td>
                                                <td><%= myData.ChassesNumber%></td>
                                                <td>black</td>
                                                <td>Qi6</td>
                                                <td><%= myData.IMEI%></td>
                                                <td><%= myData.MissingPlace%></td>
                                                <td><%= myData.MissingDate%></td>
                                                <td><%= myData.Description%></td>
                                                <td><%= myData.CNICNumber%></td>
                                                <td><%= myData.UniqueIdentification%></td>
                                                <td><%= myData.DateOfBirth%></td>
                                                <td><%= myData.FamilyNumber%></td>
                                                <td><%= myData.PermanentAddress%></td>
                                                <td><%= myData.CurrentAddress%></td>
                                                <td><%= myData.Gander%></td>
                                                <td>
                                                    <img src="../<%= myData.Image%>" width="35" height="35" style="object-fit: cover" /></td>
                                                <td><%= myData.Count%></td>
                                            </tr>
                                            <%}
                                                 }
                                             %>
                                        </table>
                                    <%} %>
                                        <!-- Table -->
                                        </div>

                                    <div class="table-responsive">
                                    <% if (SearchUnidentifiedDataInRegularSearchBar != null)
                                             { %>
                                        <br />
                                        <h3>Unidentified People Record</h3>
                                    <table class="table table-responsive table-bordered table-hover">
                                            <tr>
                                                <th>Approve</th>
                                                <th>Delete</th>
                                                <th>ID</th>
                                                <th>Registration ID</th>
                                                <th>Status</th>
                                                <th>Reference Number</th>
                                                <th>Full Name</th>
                                                <th>Father Guardian Name</th>
                                                <th>Contact Number</th>
                                                <th>Religion</th>
                                                <th>Age</th>
                                                <th>Unique Identification</th>
                                                <th>Found Place</th>
                                                <th>Language</th>
                                                <th>Cloth Color</th>
                                                <th>Eye Color</th>
                                                <th>Description</th>
                                                <th>Gander</th>
                                                <th>Image</th>
                                                <th>Views</th>
                                            </tr>
                                            <% if (SearchUnidentifiedDataInRegularSearchBar.Count > 0)
                                             {
                                                 foreach (var myData in SearchUnidentifiedDataInRegularSearchBar)
                                                 { %>
                                            <tr>
                                                <td><a href="AllReports.aspx?Unidentified_People_Id=<%= myData.UnindentifiedID %>" class="btn btn-success">Approve</a></td>
                                                <td><a href="AllReports.aspx?Unidentified_People_Delete_Id=<%= myData.UnindentifiedID%>" class="btn btn-danger">Delete</a></td>
                                                <td><%= myData.UnindentifiedID%></td>
                                                <td><%= myData.RegistrationID%></td>
                                                <%if (myData.Status == "Pending")
                                             { %>
                                                <td style="color: red; font-weight: bold"><%= myData.Status%></td>
                                                <%}
                                             else if (myData.Status == "Approved")
                                             { %>
                                                <td style="color: green; font-weight: bold"><%= myData.Status%></td>
                                                <%} %>
                                                <td><%= myData.ReferenceNumber%></td>
                                                <td><%= myData.FullName%></td>
                                                <td><%= myData.FatherGuardianName%></td>
                                                <td><%= myData.ContactNumber%></td>
                                                <td><%= myData.Religion%></td>
                                                <td><%= myData.Age%></td>
                                                <td><%= myData.UniqueIdentification%></td>
                                                <td><%= myData.FoundPlace%></td>
                                                <td><%= myData.Language%></td>
                                                <td><%= myData.ClothColor%></td>
                                                <td><%= myData.EyesColor%></td>
                                                <td><%= myData.Description%></td>
                                                <td><%= myData.Gander%></td>
                                                <td>
                                                    <img src="../<%= myData.Image%>" width="35" height="35" style="object-fit: cover"></td>
                                                <td><%= myData.Count%></td>
                                            </tr>
                                            <%}
                                                 }
                                             } %>
                                        </table>
                                        <!-- Table -->
                                    <%-- } --%>
                                        </div>
                                
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
