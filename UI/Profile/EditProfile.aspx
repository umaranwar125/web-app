<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="UI.Profile.EditProfile" %>

<%@ Register Src="~/User Control Files/Header.ascx" TagPrefix="uc1" TagName="Header" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <uc1:Header runat="server" ID="Header" />
    <link rel="stylesheet" type="text/css" href="Style/ProfileStyle.css"/>
    <script src="Script/File.js"></script>
</head>
<body style="background: #eef3f6">
    
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
                    <a class="navbar-brand animated  bounceInLeft" href="/Default.aspx"><span><b><u>M</u></b>issing</span> <b>P</b>eople<br>
                        <b>A</b>nd <b>T</b>hings</a>
                </div>

                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                    <ul class="nav navbar-nav navbar-right animated  bounceInRight">
                        <li id="DefaultActive" runat="server"><a href="/Default.aspx">Home</a></li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Post a Report<span class="caret"></span></a>
                            <ul class="dropdown-menu">
                                <li><a href="/MissingPeopleReport.aspx">Missing People</a></li>
                                <li><a href="/MissingThingReport.aspx">Missing Things</a></li>
                                <li><a href="/UnidentifiedPeople.aspx">Unidentified Peolpe</a></li>
                            </ul>
                        </li>
                        <li id="SeekingInformationActive" runat="server"><a href="/SeekingInformation.aspx">Seeking Information</a></li>
                        <li id="ReportSightingActive" runat="server" style="margin-right: 5px;"><a href="/ReportAsighting.aspx">Report a Sighting</a></li>
                        <% if (Session["username"] == null)
                           {%>
                        <li id="LoginActive" runat="server" style="margin-right: 10px;"><a href="Login.aspx">Login</a></li>
                        <li id="CreateAccountActive" runat="server" class="create-button"><a href="CreateAccount.aspx">Create Account</a></li>
                        <% }
                           else
                           {%>
                        <% foreach (var data in DisplayUserProfile)
                           { %>
                        <li class="dropdown profile">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">
                                <img src="/<%= data.Image %>" class="img img-circle" width="40" height="40" /><span><%= data.FullName %></span>
                            </a>
                            <ul class="dropdown-menu">
                                <li><a href="MyProfile.aspx">MyProfile</a></li>
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

    <form id="form1" runat="server">
        <div class="container">
			<div class="profile">
				<!-- navbar -->
				<nav class="navbar navbar-default">
                    <!-- Brand and toggle get grouped for better mobile display -->
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <% foreach(var data in DisplayUserProfile)
                           { %>
                        <a class="navbar-brand" href="MyProfile.aspx"><b><%= data.FullName %></b>'s Profile</a>
                    <%} %>
                    </div>
                    <!-- Collect the nav links, forms, and other content for toggling -->
                    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                        <ul class="nav navbar-nav navbar-right">
                            <li class="active"><a href="EditProfile.html"><i class="fa fa-key" aria-hidden="true"></i>&nbsp;Edit Profile</a></li>
                            <li><a href="FavouritePost.html"><i class="fa fa-heart-o" aria-hidden="true"></i>&nbsp;Favourite Posts</a></li>
                            <li><a href="Logout.aspx"><i class="fa fa-power-off" aria-hidden="true"></i>&nbsp;Logout</a></li>
                        </ul>
                    </div>
                    <!-- /.navbar-collapse -->
                </nav>
			
                <!-- profile -->
                <div class="col-xs-12 col-sm-4 col-md-4 col-lg-4">
                	<div class="Profile-bg">
                        <% foreach(var data in DisplayUserProfile)
                           { %>
	                	<img src="/<%= data.Image %>" alt="">
	                	<h3><%= data.FullName %></h3>
	                	<h5><%= data.About %></h5>
                        <h6>Join Date: <%= data.JoinDate %></h6>
	                    <%} %>
                    </div>
                </div>
                <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8">
	                <div class="Profie-info-bg">
	                	<label for="">Full Name</label>
	                	<input type="text" placeholder="Enter your Name" id="FullName" runat="server" />
	                	<label for="" class="margin">Title</label>
	                	<input type="text" placeholder="Say something in 3-4 words." id="Title" runat="server" />
	                	<label for="" class="margin">Email Address</label>
                        <%--<input type="text" placeholder="Enter Email Address" id="Email" runat="server" />--%>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
	                	<label for="" class="margin">Contact Number</label>
	                	<input type="text" placeholder="Enter Contact Number" id="Contact" runat="server" />
	                	<label for="" class="margin">New Password</label>
	                	<input type="text" placeholder="Enter New Password" id="New_Pwd" runat="server" />
	                	<label for="" class="margin">Confirm Password</label>
	                	<input type="text" placeholder="Enter Confirm Password" id="Con_Pwd" runat="server" />
	                	<label for="" class="margin">Change Image</label>
	                	<input type="file">
                        <h5 class="text-right" style="color: red; display:none" id="error"></h5>
                		<input type="button" class="btn btn-warning center-block" id="Update-profile" value="Update Profile">
                		<div style="display: none;" id="show">
                			<label for="" class="text-center" style="text-transform: uppercase;margin-top: 10px; letter-spacing: 1px">For Varification Purpose</label>
	                		<label for="" class="margin">Old Password</label>
	                		<input type="text" placeholder="Enter Old Password" id="Old_Pwd" />
                            <h5 class="text-right" style="color: red; display:none" id="error-pwd"></h5>
		            		<input type="button" class="btn btn-warning center-block" value="Update Now" id="Update-Now" />
	                	</div>
	                	<div class="clearfix"></div>
	            	</div>
	            	<br><br><br>
                </div>
			</div>
		</div>
    </form>
</body>
</html>
