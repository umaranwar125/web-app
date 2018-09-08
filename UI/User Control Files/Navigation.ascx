<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Navigation.ascx.cs" Inherits="UI.User_Control_Files.Navigation" %>
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
            <a class="navbar-brand animated  bounceInLeft" href="index"><span><b><u>M</u></b>issing</span> <b>P</b>eople<br>
                <b>A</b>nd <b>T</b>hings</a>
        </div>

        <!-- Collect the nav links, forms, and other content for toggling -->
        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
            <ul class="nav navbar-nav navbar-right animated  bounceInRight">
                <li id="DefaultActive" runat="server"><a href="index">Home</a></li>
                <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Post a Report<span class="caret"></span></a>
                    <ul class="dropdown-menu">
                        <li><a href="missing-people-report">Missing People</a></li>
                        <li><a href="missing-thing-report">Missing Things</a></li>
                        <li><a href="unidentified-people-report">Unidentified Peolpe</a></li>
                    </ul>
                </li>
                <li id="SeekingInformationActive" runat="server"><a href="seeking-information">Seeking Information</a></li>
                <li id="ReportSightingActive" runat="server" style="margin-right:5px;"><a href="report-sighting">Report a Sighting</a></li>
                <% if (Session["username"] == null)
                   {%>
                <li id="LoginActive" runat="server" style="margin-right:10px;"><a href="login">Login</a></li>
                <li id="CreateAccountActive" runat="server" class="create-button"><a href="register">Create Account</a></li>
                <% }
                   else
                   {%>
                <% foreach(var data in DisplayUserData)
                   { %>
                <li class="dropdown profile">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">
                        <img src="/<%= data.Image %>" class="img img-circle" style="border-radius: 2px;" /><span><%= data.FullName %></span>
                    </a>
                    <ul class="dropdown-menu">
                        <li><a href="Profile/user-profile">MyProfile</a></li>
                        <li><a href="Logout.aspx">Logout</a></li>
                    </ul>
                </li>
                
                <% }} %>
            </ul>
        </div>
        <!-- /.navbar-collapse -->
    </div>
    <!-- /.container -->
</nav>
<!-- End of Nav-->
