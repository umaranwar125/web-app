<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="UI.Admin.Dashboard" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<%@ Register Src="~/Admin/User Control File/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Admin/User Control File/SideNavigation.ascx" TagPrefix="uc1" TagName="SideNavigation" %>
<%@ Register Src="~/Admin/User Control File/TopNavigation.ascx" TagPrefix="uc1" TagName="TopNavigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dashboard</title>
    <uc1:Header runat="server" ID="Header" />
</head>
<body>
    <form id="form1" runat="server">
        <!-- Contaier-Fluid -->
        <div class="container-fluid">
            <div class="row">
                <!-- First Column -->
                <div class="col-md-2 col-lg-2 side-bar">
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
                        <h2 class="heading">Dashboard</h2>
                        <ol class="breadcrumb">
                            <li><a href="Dashboard.aspx">Home</a></li>
                            <li><a href="Dashboard.aspx">Dashboard</a></li>
                            <li class="active">Data</li>
                        </ol>
                        <!-- Breadcrumb -->

                        <!-- Statistic Reports -->
                        <div class="row">
                            <div class="statistic-report">
                                <!-- Column 1 -->
                                <div class="col-sm-12 col-sm-6 col-md-3 col-lg-3">
                                    <div class="panel panel-danger">
                                        <div class="panel-heading" style="background: white;">
                                            <div class="row">
                                                <div class="col-xs-3">
                                                    <i class="fa fa-pencil-square-o fa-4x border" aria-hidden="true"></i>
                                                </div>
                                                <div class="col-xs-9">
                                                    <%foreach (var data in DisplayTotalMissingPeople)
                                                        { %>
                                                    <div class="text-right huge"><%= data.PeopleID %></div>
                                                    <%} %>
                                                    <div class="text-right text">Missing People Reports</div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <!-- Column 2 -->
                                <div class="col-sm-12 col-sm-6 col-md-3 col-lg-3">
                                    <div class="panel panel-success">
                                        <div class="panel-heading" style="background: white;">
                                            <div class="row">
                                                <div class="col-xs-3">
                                                    <i class="fa fa-check-square-o fa-4x border" aria-hidden="true"></i>
                                                </div>
                                                <div class="col-xs-9">
                                                    <% foreach (var data in DisplayTotalMissingThing)
                                                        { %>
                                                    <div class="text-right huge"><%= data.ThingID %></div>
                                                    <%} %>
                                                    <div class="text-right text">Missing Thing Reports</div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <!-- Column 3 -->
                                <div class="col-sm-12 col-sm-6 col-md-3 col-lg-3">
                                    <div class="panel panel-info">
                                        <div class="panel-heading" style="background: white;">
                                            <div class="row">
                                                <div class="col-xs-3">
                                                    <i class="fa fa-pencil fa-4x border" aria-hidden="true"></i>
                                                </div>
                                                <div class="col-xs-9">
                                                    <% foreach (var data in DisplayTotalUnidentifiedPeople)
                                                        { %>
                                                    <div class="text-right huge"><%= data.UnindentifiedID %></div>
                                                    <%} %>
                                                    <div class="text-right text">Unidentified People Reports</div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <!-- Column 4 -->
                                <div class="col-sm-12 col-sm-6 col-md-3 col-lg-3">
                                    <div class="panel panel-warning">
                                        <div class="panel-heading" style="background: white;">
                                            <div class="row">
                                                <div class="col-xs-3">
                                                    <i class="fa fa-thumbs-up fa-4x border" aria-hidden="true"></i>
                                                </div>
                                                <div class="col-xs-9">
                                                    <% foreach (var data in DisplayTotalComments)
                                                        { %>
                                                    <div class="text-right huge"><%= data.CommentID %></div>
                                                    <%} %>
                                                    <div class="text-right text">Total Comments</div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- Statistic Reports -->
                        </div>
                        <!-- Row -->

                        <!-- Statistic Reports -->
                        <div class="row">
                            <div class="statistic-report">
                                <!-- Column 1 -->
                                <div class="col-sm-12 col-sm-6 col-md-3 col-lg-3">
                                    <div class="panel panel-danger panel1">
                                        <div class="panel-heading" style="background: white;">
                                            <div class="row">
                                                <div class="col-xs-3">
                                                    <i class="fa fa-user-circle fa-4x border" aria-hidden="true"></i>
                                                </div>
                                                <div class="col-xs-9">
                                                    <%foreach (var data in DisplayTotalRegisteration)
                                                        { %>
                                                    <div class="text-right huge"><%= data.RegistrationID %></div>
                                                    <%} %>
                                                    <div class="text-right text">Registered Users</div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <!-- Column 2 -->
                                <div class="col-sm-12 col-sm-6 col-md-3 col-lg-3">
                                    <div class="panel panel-success panel2">
                                        <div class="panel-heading" style="background: white;">
                                            <div class="row">
                                                <div class="col-xs-3">
                                                    <i class="fa fa-wpforms fa-4x border" aria-hidden="true"></i>
                                                </div>
                                                <div class="col-xs-9">
                                                    <%foreach (var data in DisplayTotalFeedbacks)
                                                        { %>
                                                    <div class="text-right huge"><%= data.FeedbackID %></div>
                                                    <%} %>
                                                    <div class="text-right text">Total Feedbacks</div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <!-- Column 3 -->
                                <div class="col-sm-12 col-sm-6 col-md-3 col-lg-3">
                                    <div class="panel panel-info panel3">
                                        <div class="panel-heading" style="background: white;">
                                            <div class="row">
                                                <div class="col-xs-3">
                                                    <i class="fa fa-phone-square fa-4x border" aria-hidden="true"></i>
                                                </div>
                                                <div class="col-xs-9">
                                                    <% foreach (var data in DisplayTotalContacts)
                                                        { %>
                                                    <div class="text-right huge"><%= data.ContactID %></div>
                                                    <%} %>
                                                    <div class="text-right text">Total Contacts</div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <!-- Column 4 -->
                                <div class="col-sm-12 col-sm-6 col-md-3 col-lg-3">
                                    <div class="panel panel-warning panel4">
                                        <div class="panel-heading" style="background: white;">
                                            <div class="row">
                                                <div class="col-xs-3">
                                                    <i class="fa fa-pencil-square fa-4x border" aria-hidden="true"></i>
                                                </div>
                                                <div class="col-xs-9">
                                                    <% foreach (var data in DisplayTotalReportSighting)
                                                        { %>
                                                    <div class="text-right huge"><%= data.SightingID %></div>
                                                    <%} %>
                                                    <div class="text-right text">Total Sighting Reports</div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- Statistic Reports -->
                        </div>
                        <!-- Row -->
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
