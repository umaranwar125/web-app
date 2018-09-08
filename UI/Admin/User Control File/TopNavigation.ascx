<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TopNavigation.ascx.cs" Inherits="UI.Admin.User_Control_File.TopNavigation" %>

<div class="pull-left">
    <a href="javascript:void(0)" onclick="openNav();"><i class="fa fa-bars" aria-hidden="true"></i></a>
    <span class="glyphicon glyphicon-search"></span>&nbsp;<input type="text" placeholder="Search">
    <input type="submit" class="btn btn-primary" value="Go">
</div>

<!-- Notification -->
<div class="pull-right">
    <li class="dropdown notification">
        <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><i class="fa fa-bell-o" aria-hidden="true"></i><span class="digit"><%= SelectIDFromPeople.Count + SelectIDFromThing.Count + SelectIDFromUnidentified.Count + SelectIDFromSighting.Count %></span></a>
        <ul class="dropdown-menu">
            <h4 class="text-center">Notifications</h4>
            <hr class="bottom">

            <!-- Content 1 -->

            <% foreach (var data in SelectIDFromSighting)
            {
                SelectRegisteredData = SelectRegisterationData(data.RegistrationID);
                    foreach (var Mydata in SelectRegisteredData)
                    {
             %>
            <div class="content">
                <div class="col-xs-3 col-sm-3 col-md-3 col-lg-3">
                    <img src="../<%= Mydata.Image %>" width="50" height="50">
                </div>
                <div class="col-xs-9 col-sm-9 col-md-9 col-lg-9">
                    <p><span><%= Mydata.FullName %></span> submitted a<span> Sighting </span>Report</p>
                </div>
                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                    <hr style="border: 1px solid #d6dde5; margin-left: -15px; margin-right: -15px">
                </div>
            </div>
            <%}} %>

            <% foreach (var data in SelectIDFromPeople)
            {
                SelectRegisteredData = SelectRegisterationData(data.RegistrationID);
                    foreach (var Mydata in SelectRegisteredData)
                    {
             %>
            <div class="content">
                <div class="col-xs-3 col-sm-3 col-md-3 col-lg-3">
                    <img src="../<%= Mydata.Image %>" width="50" height="50">
                </div>
                <div class="col-xs-9 col-sm-9 col-md-9 col-lg-9">
                    <p><span><%= Mydata.FullName %></span> posted a <span>Missing People </span>Report</p>
                </div>
                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                    <hr style="border: 1px solid #d6dde5; margin-left: -15px; margin-right: -15px">
                </div>
            </div>
            <%}} %>

            <% foreach (var data in SelectIDFromThing)
            {
                SelectRegisteredData = SelectRegisterationData(data.RegistrationID);
                    foreach (var Mydata in SelectRegisteredData)
                    {
             %>
            <div class="content">
                <div class="col-xs-3 col-sm-3 col-md-3 col-lg-3">
                    <img src="../<%= Mydata.Image %>" width="50" height="50">
                </div>
                <div class="col-xs-9 col-sm-9 col-md-9 col-lg-9">
                    <p><span><%= Mydata.FullName %></span> posted a <span>Missing Thing </span>Report</p>
                </div>
                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                    <hr style="border: 1px solid #d6dde5; margin-left: -15px; margin-right: -15px">
                </div>
            </div>
            <%}} %>

            <% foreach (var data in SelectIDFromUnidentified)
            {
                SelectRegisteredData = SelectRegisterationData(data.RegistrationID);
                    foreach (var Mydata in SelectRegisteredData)
                    {
             %>
            <div class="content">
                <div class="col-xs-3 col-sm-3 col-md-3 col-lg-3">
                    <img src="../<%= Mydata.Image %>" width="50" height="50">
                </div>
                <div class="col-xs-9 col-sm-9 col-md-9 col-lg-9">
                    <p><span><%= Mydata.FullName %></span> posted an <span>Unidentified People </span>Report</p>
                </div>
                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                    <hr style="border: 1px solid #d6dde5; margin-left: -15px; margin-right: -15px">
                </div>
            </div>
            <%}} %>
        </ul>
    </li>

    <!-- Message -->
    <li class="dropdown message">
        <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><i class="fa fa-envelope-o" aria-hidden="true"></i><span class="digit"><%= DisplayContactsInMessages.Count %></span></a>
        <ul class="dropdown-menu">
            <h4 class="text-center">Messages</h4>
            <hr class="bottom">

            <!-- Content 1 -->
            <%foreach(var data in DisplayContactsInMessages)
              { %>
            <div class="content">
                <div class="pull-left">
                    <h5><%= data.ContactNumber %></h5>
                </div>
                <div class="pull-right">
                    <h5><%= data.Date %></h5>
                </div>
                <div class="clearfix"></div>
                <h5 class="text-center" style="margin-top: -5px;"><%= data.Time %></h5>
                <div>
                    <h6><%= data.Message %></h6>
                </div>
                <hr style="border: 1px solid #d6dde5; margin-top: 0px; margin-bottom: 20px;">
            </div>
            <%} %>
        </ul>
    </li>

    <!-- Profile -->
    <li class="dropdown profile">
        <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">
            <%foreach(var data in DisplayAdminProfile){ %>
            <img src="<%= data.Image %>">&nbsp;&nbsp;
			<h5><%= data.FullName %></h5>
            <%} %>
            &nbsp;<span class="caret"></span></a>
        <ul class="dropdown-menu">
            <li><a href="Profile.aspx"><i class="fa fa-user-o" aria-hidden="true"></i>&nbsp;&nbsp;&nbsp;Profile</a></li>
            <li><a href="Logout.aspx"><i class="fa fa-power-off" aria-hidden="true"></i>&nbsp;&nbsp;&nbsp;Logout</a></li>
        </ul>
    </li>
</div>
