<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SideNavigation.ascx.cs" Inherits="UI.Admin.User_Control_File.SideNavigation" %>

<nav>
    <h3><a href="Dashboard.aspx"><b>A</b>dmin <b>Panel</b></a></h3>
    <hr class="bottom" />
    <ul>
        <a href="Dashboard.aspx">
            <li runat="server" id="DashboardActive"><i class="fa fa-tachometer" aria-hidden="true"></i>&nbsp;&nbsp;Dashboard</li>
        </a>
        <a href="Profile.aspx">
            <li runat="server" id="Li1"><i class="fa fa-user fa-5x border" aria-hidden="true"></i>&nbsp;&nbsp;My Profile</li>
        </a>
        <a href="AllReports.aspx">
            <li runat="server" id="AllReportsActive"><i class="fa fa-check-square-o fa-5x border" aria-hidden="true"></i>&nbsp;&nbsp;All Reports</li>
        </a>
        <a href="ReportSighting.aspx">
            <li runat="server" id="SightingActive"><i class="fa fa-eye fa-5x border" aria-hidden="true"></i>&nbsp;&nbsp;Report Sighting</li>
        </a>
        <a href="RegisteredUsers.aspx">
            <li runat="server" id="UsersActive"><i class="fa fa-user-circle fa-5x border" aria-hidden="true"></i>&nbsp;&nbsp;Registered Users</li>
        </a>
        <a href="Feedback.aspx">
            <li runat="server" id="FeedbackActive"><i class="fa fa-star-half-o fa-5x border" aria-hidden="true"></i>&nbsp;&nbsp;Feedback</li>
        </a>
        <a href="Contacts.aspx">
            <li runat="server" id="ContactActive"><i class="fa fa-phone fa-5x border" aria-hidden="true"></i>&nbsp;&nbsp;Contacts</li>
        </a>
        <a href="Comments.aspx">
            <li runat="server" id="CommentsActive"><i class="fa fa-comments-o fa-5x border" aria-hidden="true"></i>&nbsp;&nbsp;Comments</li>
        </a>
        <a href="CrystalReports.aspx">
            <li runat="server" id="Li2"><i class="fa fa-pencil"></i>&nbsp;&nbsp;Crystal Reports</li>
        </a>
    </ul>
</nav>
