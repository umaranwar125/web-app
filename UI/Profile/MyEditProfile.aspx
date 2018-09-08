<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyEditProfile.aspx.cs" Inherits="UI.Profile.MyEditProfile" %>

<%@ Register Src="~/User Control Files/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/User Control Files/Navigation.ascx" TagPrefix="uc1" TagName="Navigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Profile - Missing People And Things</title>
    <meta name="robots" content="noindex, nofollow" />

    <!-- Icon -->
    <link rel="icon" type="image/png" href="/Image/title.png" />

    <uc1:Header runat="server" ID="Header" />
    <link href="Style/ProfileStyle.css" rel="stylesheet" />
    <script src="Script/File.js"></script>
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
                        <% foreach (var data in DisplayUserData)
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
                        <%foreach (var data in DisplayUserData)
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
                        <% foreach (var data in DisplayUserData)
                            { %>
                        <img src="/<%= data.Image %>" alt="">
                        <h3><%= data.FullName %></h3>
                        <h5><%= data.About %></h5>
                        <% } %>
                    </div>
                </div>
                <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8">
                    <div class="Profie-info-bg">
                        <h5 style="display: none; color: red" id="alert_password">Sorry! Your old password is not correct.</h5>
                        <h5 style="display: none; color: red" id="alert_email">Sorry! Email is already exist.</h5>
                        <h5 style="display: none; color: green" id="alert_Congratz">Profile has been successfully updated.</h5>
                        <label for="">Full Name</label>
                        <input type="text" placeholder="Enter your Name" id="Full_N" runat="server">
                        <label for="" class="margin">Title</label>
                        <input type="text" placeholder="Say something in 3-4 words." id="Titl" runat="server">
                        <label for="" class="margin">Email Address</label>
                        <input type="text" placeholder="Enter Email Address" id="email_a" runat="server">
                        <label for="" class="margin">Contact Number</label>
                        <input type="text" placeholder="Enter Contact Number" id="contact_n" runat="server">
                        <label for="" class="margin">New Password</label>
                        <input type="password" placeholder="Enter New Password" id="new_p" runat="server">
                        <label for="" class="margin">Confirm Password</label>
                        <input type="password" placeholder="Enter Confirm Password" id="con_p" runat="server">
                        <label for="" class="margin">Change Image</label>
                        <asp:FileUpload ID="img" runat="server" />
                        <h5 id="error" class="text-right" style="color: red; display: none"></h5>
                        <h5 id="error-pwd" class="text-right" style="color: red; display: none"></h5>
                        <input type="button" class="btn btn-warning center-block" runat="server" id="Updateprofile" value="Update Profile">
                        <div style="display: none" id="show">
                            <label for="" class="text-center" style="text-transform: uppercase; margin-top: 10px;">For confirmation Purpose</label>
                            <label for="" class="margin">Old Password</label>
                            <input type="password" placeholder="Enter Old Password" id="old_p" runat="server">
                            <asp:Button ID="UpdateNow" runat="server" Text="Update Now" CssClass="btn btn-warning center-block" OnClick="UpdateNow_Click" />
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <br>
                    <br>
                    <br>
                </div>
            </div>
        </div>
        <div id="Testimonial">
            <div class="footer navbar-fixed-bottom">
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
