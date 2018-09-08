<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyProfile.aspx.cs" Inherits="UI.Profile.MyProfile" %>

<%@ Register Src="~/User Control Files/Header.ascx" TagPrefix="uc1" TagName="Header" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profile - Missing People And Things</title>
    <meta name="robots" content="noindex, nofollow" />
    <uc1:Header runat="server" ID="Header" />
    
    <!-- Icon -->
    <link rel="icon" type="image/png" href="/Image/title.png" />

    <link rel="stylesheet" type="text/css" href="Style/ProfileStyle.css" />
</head>
<body style="background: #eef3f6">

    <form id="form1" runat="server">

        <section id="Profie-Header">
                 <nav class="navbar navbar-inverse navbar-fixed-top">
            <!-- Navigation Header -->
            <div class="container">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand animated  bounceInLeft" href="/index"><span><b><u>M</u></b>issing</span> <b>P</b>eople<br>
                        <b>A</b>nd <b>T</b>hings</a>
                </div>

                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                    <ul class="nav navbar-nav navbar-right animated  bounceInRight">
                        <li id="DefaultActive" runat="server"><a href="/index">Home</a></li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Post a Report<span class="caret"></span></a>
                            <ul class="dropdown-menu">
                                <li><a href="/missing-people-report">Missing People</a></li>
                                <li><a href="/missing-thing-report">Missing Things</a></li>
                                <li><a href="/unidentified-people-report">Unidentified Peolpe</a></li>
                            </ul>
                        </li>
                        <li id="SeekingInformationActive" runat="server"><a href="/seeking-information">Seeking Information</a></li>
                        <li id="ReportSightingActive" runat="server" style="margin-right: 5px;"><a href="/report-sighting">Report a Sighting</a></li>
                        <% if (Session["username"] == null)
                            {%>
                        <li id="LoginActive" runat="server" style="margin-right: 10px;"><a href="login">Login</a></li>
                        <li id="CreateAccountActive" runat="server" class="create-button"><a href="register">Create Account</a></li>
                        <% }
                            else
                            {%>
                        <% foreach (var data in DisplayUserProfile)
                            { %>
                        <li class="dropdown profile">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">
                                <img src="/<%= data.Image %>" class="img img-circle" width="40" height="40" style="border-radius: 2px;" /><span><%= data.FullName %></span>
                            </a>
                            <ul class="dropdown-menu">
                                <li><a href="user-profile">MyProfile</a></li>
                                <li><a href="/Logout.aspx">Logout</a></li>
                            </ul>
                        </li>

                        <% }
                            } %>
                    </ul>
                </div>
                <!-- /.navbar-collapse -->
            </div>
            <!-- /.container -->
        </nav>
            <!-- End of Nav-->

        </section>

        <div class="container">
            <div class="profile">
                <!-- navbar -->
                <nav class="navbar navbar-default">
                    <!-- Brand and toggle get grouped for better mobile display -->
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-2" aria-expanded="false">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <% foreach (var data in DisplayUserProfile)
                            { %>
                        <a class="navbar-brand" href="user-profile"><b><%= data.FullName %></b>'s Profile</a>
                        <%} %>
                    </div>
                    <!-- Collect the nav links, forms, and other content for toggling -->
                    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-2">
                        <ul class="nav navbar-nav navbar-right">
                            <li><a href="edit-profile"><i class="fa fa-key" aria-hidden="true"></i>&nbsp;Edit Profile</a></li>
                            <li><a href="favourite-post"><i class="fa fa-heart-o" aria-hidden="true"></i>&nbsp;Favourite Posts</a></li>
                            <li><a href="/Logout.aspx"><i class="fa fa-power-off" aria-hidden="true"></i>&nbsp;Logout</a></li>
                        </ul>
                    </div>
                    <!-- /.navbar-collapse -->
                </nav>

                <!-- profile -->
                <div class="col-xs-12 col-sm-4 col-md-4 col-lg-4">
                    <div class="Profile-bg">
                        <% foreach (var data in DisplayUserProfile)
                            { %>
                        <img src="/<%= data.Image %>" alt="">
                        <h3><%= data.FullName %></h3>
                        <h5><%= data.About %></h5>
                        <%} %>
                    </div>
                </div>
                <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8">
                    <div class="Profie-info-bg">
                        <h6 class="Submit-reposrts">Your Submitted Reports</h6>
                        <hr class="bottom">
                        <% if (DisplayMissingPeopleData.Count >= 1 || DisplayMissingThingData.Count >= 1 || DisplayUnidentifiedPeopleData.Count >= 1)
                            {
                                if (DisplayMissingPeopleData.Count > 0)
                                {
                                    foreach (var Mydata in DisplayMissingPeopleData)
                                    {%>
                        <div class="media">
                            <!-- Start of Media -->
                            <div class="media-left">
                                <!-- tart of Media-left -->
                                <a href="">
                                    <a href="/FullPost.aspx?Missing_People_Id=<%=Mydata.PeopleID%>">
                                        <img class="media-object img-thumbnail" src="/<%= Mydata.Image %>" alt="..." width="180"></a>
                                </a>
                            </div>
                            <div class="media-body">
                                <!-- tart of Media-body -->
                                <div class="dropdown pull-right">
                                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-option-horizontal"></span></a>
                                    <ul class="dropdown-menu">
                                        <li><a href="=<%= Mydata.PeopleID %>"><i class="fa fa-heart-o" aria-hidden="true"></i>&nbsp;&nbsp;Print</a></li>
                                        <li><a href="edit-post?Missing-People-Edit-Post-ID=<%= Mydata.PeopleID %>"><i class="fa fa-pencil" aria-hidden="true"></i>&nbsp;&nbsp;Edit</a></li>
                                        <li><a href="user-profile?Missing-People-Delete-ID=<%= Mydata.PeopleID %>"><i class="fa fa-remove" aria-hidden="true"></i>&nbsp;&nbsp;Delete</a></li>
                                    </ul>
                                </div>
                                <h4 class="media-heading"><%= Mydata.FullName %></h4>
                                <% if (Mydata.Status == "Pending")
                                    { %>
                                <h6>Status: <span style="color: red"><%= Mydata.Status %></span></h6>
                                <%}
                                    else if (Mydata.Status == "Approved")
                                    { %>
                                <h6>Status: <span style="color: green"><%= Mydata.Status %></span></h6>
                                <% }%>
                                <h6>Contact# <%= Mydata.ContactNumber %></h6>
                                <h6>CNIC# <%= Mydata.CNIC %></h6>
                                <h6>Reference# <%= Mydata.ReferenceNumber %></h6>
                                <h6>Total Views: <%= Mydata.Count %></h6>

                            </div>
                        </div>
                        <hr>
                        <%}
                            }
                            if (DisplayMissingThingData.Count > 0)
                            {
                                foreach (var mydata in DisplayMissingThingData)
                                {%>
                        <div class="media">
                            <!-- Start of Media -->
                            <div class="media-left">
                                <!-- tart of Media-left -->
                                <a href="">
                                    <a href="/FullPost.aspx?Missing_Thing_Id=<%= mydata.ThingID%>">
                                        <img class="media-object img-thumbnail" src="/<%= mydata.Image %>" alt="..." width="180" /></a>
                                </a>
                            </div>
                            <div class="media-body">
                                <!-- tart of Media-body -->
                                <div class="dropdown pull-right">
                                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-option-horizontal"></span></a>
                                    <ul class="dropdown-menu">
                                        <li><a href="=<%= mydata.ThingID %>"><i class="fa fa-heart-o" aria-hidden="true"></i>&nbsp;&nbsp;Print</a></li>
                                        <li><a href="edit-post?Missing-Thing-Edit-Post-ID=<%= mydata.ThingID %>"><i class="fa fa-pencil" aria-hidden="true"></i>&nbsp;&nbsp;Edit</a></li>
                                        <li><a href="user-profile?Missing-Thing-Delete-ID=<%= mydata.ThingID %>"><i class="fa fa-remove" aria-hidden="true"></i>&nbsp;&nbsp;Delete</a></li>
                                    </ul>
                                </div>
                                <h4 class="media-heading"><%= mydata.OwnerName%></h4>
                                <% if (mydata.Status == "Pending")
                                    { %>
                                <h6>Status: <span style="color: red"><%= mydata.Status %></span></h6>
                                <%}
                                    else if (mydata.Status == "Approved")
                                    { %>
                                <h6>Status: <span style="color: green"><%= mydata.Status %></span></h6>
                                <% }%>
                                <h6>Contact# <%= mydata.ContactNumber %></h6>
                                <h6>CNIC# <%= mydata.OwnerCNIC %></h6>
                                <h6>Reference# <%= mydata.ReferenceNumber %></h6>
                                <h6>Total Views: <%= mydata.Count %></h6>

                            </div>
                        </div>
                        <hr />
                        <%   }
                            }
                            if (DisplayUnidentifiedPeopleData.Count > 0)
                            {
                                foreach (var mydata in DisplayUnidentifiedPeopleData)
                                {%>
                        <div class="media">
                            <!-- Start of Media -->
                            <div class="media-left">
                                <!-- tart of Media-left -->
                                <a href="">
                                    <a href="/FullPost.aspx?Unidentified_People_Id=<%= mydata.UnindentifiedID%>">
                                        <img class="media-object img-thumbnail" src="/<%= mydata.Image %>" alt="..." width="180" /></a>
                                </a>
                            </div>
                            <div class="media-body">
                                <!-- tart of Media-body -->
                                <div class="dropdown pull-right">
                                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-option-horizontal"></span></a>
                                    <ul class="dropdown-menu">
                                        <li><a href="=<%= mydata.UnindentifiedID %>"><i class="fa fa-heart-o" aria-hidden="true"></i>&nbsp;&nbsp;Print</a></li>
                                        <li><a href="edit-post?Unidentified-People-Edit-Post-ID=<%= mydata.UnindentifiedID %>"><i class="fa fa-pencil" aria-hidden="true"></i>&nbsp;&nbsp;Edit</a></li>
                                        <li><a href="user-profile?Unidentified-People-Delete-ID=<%= mydata.UnindentifiedID %>"><i class="fa fa-remove" aria-hidden="true"></i>&nbsp;&nbsp;Delete</a></li>
                                    </ul>
                                </div>
                                <h4 class="media-heading"><%= mydata.FullName %></h4>
                                <% if (mydata.Status == "Pending")
                                    { %>
                                <h6>Status: <span style="color: red"><%= mydata.Status %></span></h6>
                                <%}
                                    else if (mydata.Status == "Approved")
                                    { %>
                                <h6>Status: <span style="color: green"><%= mydata.Status %></span></h6>
                                <% }%>
                                <h6>Contact# <%= mydata.ContactNumber %></h6>
                                <h6>Reference# <%= mydata.ReferenceNumber %></h6>
                                <h6>Found Place <%= mydata.FoundPlace%></h6>
                                <h6>Religion: <%= mydata.Religion %></h6>
                                <h6>Total Views: <%= mydata.Count %></h6>
                            </div>
                        </div>
                        <hr />
                        <%}
                                }
                            }
                            else
                                Response.Write("<h4 class='text-center' style='margin-bottom: 20px;color: gray'>Your submitted reports will show here.</h4>"); %>
                    </div>
                    <br>
                    <br>
                    <br>
                </div>
            </div>
        </div>

        <div id="Testimonial">
            <div class="footer">
                <!--Footer -->
                <div class="container wow bounceInDown" data-wow-duration="2s" data-wow-delay=".2s">
                    <!-- Start of Bottom  Container -->
                    <div class="col-xs-12 col-sm-12 col-md-3 col-lg-3">
                        <h5>&copy;2017-<%= DateTime.Today.Year %> All Rights Reserved.</h5>
                    </div>
                    <div class="col-xs-12 col-sm-12 col-md-9 col-lg-9 text-right">
                        <a href="/Default.aspx">Home</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
					<a href="/MissingPeopleReport.aspx">Missing People</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
					<a href="/MissingThingReport.aspx">Missing Things</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
					<a href="/UnidentifiedPeople.aspx">Unidentified People</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
					<a href="FAQs.aspx">FAQs</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
					<a href="#">Privacy Policy</a>&nbsp;&nbsp;&nbsp;
                    </div>
                </div>
                <!-- End of Container-->
            </div>
        </div>
        <!--Footer -->
    </form>
</body>
</html>
