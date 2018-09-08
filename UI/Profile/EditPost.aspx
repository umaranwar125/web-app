<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditPost.aspx.cs" Inherits="UI.Profile.EditPost" %>

<%@ Register Src="~/User Control Files/Header.ascx" TagPrefix="uc1" TagName="Header" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Post - Missing People And Things</title>
    <meta name="robots" content="noindex, nofollow" />


    <!-- Icon -->
    <link rel="icon" type="image/png" href="/Image/title.png" />
    <uc1:Header runat="server" ID="Header" />
    <script src="Script/File.js"></script>
    <link href="Style/ProfileStyle.css" rel="stylesheet" />
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

    <form id="form1" runat="server">
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
                        <% foreach (var data in DisplayUserData)
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
                        <%} %>
                    </div>
                </div>
                <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8">
                    <div class="Profie-info-bg">
                        <%if (Request.QueryString["Missing-People-Edit-Post-ID"] != null)
                            { %>
                        <h5 style="display: none;" class="alert alert-danger" id="alert_Image"><strong>Please!</strong> choose image for post.</h5>
                        <h5 style="display: none;" class="alert alert-success" id="alert_success">Post has been successfully updated.</h5>
                        <label for="">Full Name (*)</label>
                        <input type="text" placeholder="Enter your Name" runat="server" id="M_P_Full_Name">
                        <label for="" class="margin">NickName (Optional)</label>
                        <input type="text" placeholder="Enter Nickname" runat="server" id="M_P_Nickname">
                        <label for="" class="margin">CNIC (Optional)</label>
                        <input type="text" placeholder="Enter CNIC" runat="server" id="M_P_CNIC">
                        <label for="" class="margin">Father/Guardian Name (*)</label>
                        <input type="text" placeholder="Enter Father Name" runat="server" id="M_P_Father_name">
                        <label for="" class="margin">Father/Guardian CNIC (*)</label>
                        <input type="text" placeholder="Enter CNIC" runat="server" id="M_P_Father_CNIC">
                        <label for="" class="margin">Mobile Number (*)</label>
                        <input type="text" placeholder="Enter Mobile Number" runat="server" id="M_P_Mobile">
                        <label for="" class="margin">Another Mobile Number (Optional)</label>
                        <input type="text" placeholder="Enter Mobile Number" runat="server" id="M_P_Mobile2">
                        <label for="" class="margin">Permanent Address (*)</label>
                        <input type="text" placeholder="Enter Permanent Address" runat="server" id="M_P_Permanent">
                        <label for="" class="margin">Current Address (*)</label>
                        <input type="text" placeholder="Enter Current Address" runat="server" id="M_P_Current">
                        <label for="" class="margin">Age (*)</label>
                        <input type="text" placeholder="Enter Age" runat="server" id="M_P_Age">
                        <label for="" class="margin">Missing Place (*)</label>
                        <input type="text" placeholder="Enter Missing Place" runat="server" id="M_P_Place">
                        <label for="" class="margin">Clothes Colour</label>
                        <input type="text" placeholder="Enter Colth Colour" runat="server" id="M_P_Cloth">
                        <label for="" class="margin">Description (*)</label>
                        <textarea placeholder="Enter detail in at least 60 characters." runat="server" id="M_P_Description"></textarea>
                        <label for="" class="margin">Choose Image (*)</label>
                        <asp:FileUpload ID="Image" runat="server" />
                        <h5 class="text-right ErrorMsg" style="color: red;"></h5>
                        <asp:Button ID="Update_Missing_People" runat="server" CssClass="btn btn-warning center-block" Text="Update Post" OnClick="Update_Missing_People_Click" />
                        <%}
                            else if (Request.QueryString["Missing-Thing-Edit-Post-ID"] != null)
                            {
                                List<BOL.MissingThingPageObject> lst = new List<BOL.MissingThingPageObject>();
                                lst = new BLL.UserProfileBussiness().SelectThingNameForEditPost(Convert.ToInt32(Request.QueryString["Missing-Thing-Edit-Post-ID"]));
                                foreach (var data in lst)
                                {
                                    if (data.ThingName == "Auto Mobile")
                                    {
                        %>
                        <h5 style="display: none;" class="alert alert-success" id="alert_success_Auto"><strong>Congratz!</strong> Post has been successfully updated.</h5>
                        <label for="">Owner Name (*)</label>
                        <input type="text" placeholder="Enter your Name" runat="server" id="Auto_Owner_name">
                        <label for="" class="margin">Owner CNIC (*)</label>
                        <input type="text" placeholder="Enter CNIC" runat="server" id="Auto_Owner_CNIC">
                        <label for="" class="margin">Mobile Number (*)</label>
                        <input type="text" placeholder="Enter Mobile Number" runat="server" id="Auto_Mobile_No">
                        <label for="" class="margin">Another Mobile Number (Optional)</label>
                        <input type="text" placeholder="Enter Mobile Number" runat="server" id="Auto_Mobile_No2">
                        <label for="" class="margin">Father/Guardian Name (*)</label>
                        <input type="text" placeholder="Enter Name" runat="server" id="Auto_Father_Name">
                        <label for="" class="margin">Father/Guardian CNIC (*)</label>
                        <input type="text" placeholder="Enter CNIC" runat="server" id="Auto_Father_CNIC">
                        <label for="" class="margin">Permanent Address (Optional)</label>
                        <input type="text" placeholder="Enter Permanent Address" runat="server" id="Auto_Permanent">
                        <label for="" class="margin">Current Address (Optional)</label>
                        <input type="text" placeholder="Enter Current Address" runat="server" id="Auto_Current">
                        <label for="" class="margin">Missing Place (*)</label>
                        <input type="text" placeholder="Enter Missing Place" runat="server" id="Auto_Place">
                        <label for="" class="margin">Company Name (*)</label>
                        <input type="text" placeholder="Enter Company Name" runat="server" id="Auto_company">
                        <label for="" class="margin">Brand Name (*)</label>
                        <input type="text" placeholder="Enter Brand Name" runat="server" id="Auto_Brand">
                        <label for="" class="margin">Engine Number (*)</label>
                        <input type="text" placeholder="Enter Engine Number" runat="server" id="Auto_Engine">
                        <label for="" class="margin">Chasses Number (*)</label>
                        <input type="text" placeholder="Enter Chasses Number" runat="server" id="Auto_chasses">
                        <label for="" class="margin">Color (*)</label>
                        <input type="text" placeholder="Enter Color Name" runat="server" id="Auto_Color">
                        <label for="" class="margin">Model Number (*)</label>
                        <input type="text" placeholder="Enter Model Number" runat="server" id="Auto_Model">
                        <label for="" class="margin">Description (*)</label>
                        <textarea placeholder="Enter detail in at least 60 characters." runat="server" id="Auto_description"></textarea>
                        <label for="" class="margin">Choose Image (*)</label>
                        <asp:FileUpload ID="Auto_img" runat="server" />
                        <h5 class="text-right ErrorAuto" style="color: red;"></h5>
                        <asp:Button ID="Update_Auto_Mobile_post" runat="server" CssClass="btn btn-warning center-block" Text="Update Post" OnClick="Update_Auto_Mobile_post_Click" />
                        <%}
                            if (data.ThingName == "CNIC")
                            {%>
                        <h5 style="display: none;" class="alert alert-success" id="alert_success_CNIC"><strong>Congratz!</strong> Post has been successfully updated.</h5>
                        <label for="">Owner Name (*)</label>
                        <input type="text" placeholder="Enter your Name" runat="server" id="CNIC_Owner_name">
                        <label for="" class="margin">Owner CNIC (*)</label>
                        <input type="text" placeholder="Enter CNIC" runat="server" id="CNIC_Owner_CNIC">
                        <label for="" class="margin">Mobile Number (*)</label>
                        <input type="text" placeholder="Enter Mobile Number" runat="server" id="CNIC_Mobile_no">
                        <label for="" class="margin">Another Mobile Number (Optional)</label>
                        <input type="text" placeholder="Enter Mobile Number" runat="server" id="CNIC_Mobile_no2">
                        <label for="" class="margin">Father/Guardian Name (*)</label>
                        <input type="text" placeholder="Enter Name" runat="server" id="CNIC_Father_name">
                        <label for="" class="margin">Father/Guardian CNIC (*)</label>
                        <input type="text" placeholder="Enter CNIC" runat="server" id="CNIC_Father_CNIC">
                        <label for="" class="margin">Permanent Address (Optional)</label>
                        <input type="text" placeholder="Enter Permanent Address" runat="server" id="CNIC_Permanent">
                        <label for="" class="margin">Current Address (Optional)</label>
                        <input type="text" placeholder="Enter Current Address" runat="server" id="CNIC_Current">
                        <label for="" class="margin">Missing Place (*)</label>
                        <input type="text" placeholder="Enter Missing Place" runat="server" id="CNIC_Place">
                        <label for="" class="margin">Your Missed CNIC Number(*)</label>
                        <input type="text" placeholder="Enter CNIC Number" runat="server" id="CNIC_Number">
                        <label for="" class="margin">Family Number (*)</label>
                        <input type="text" placeholder="Enter Family Number" runat="server" id="CNIC_Family">
                        <label for="" class="margin">Description (*)</label>
                        <textarea placeholder="Enter detail in at least 60 characters." runat="server" id="CNIC_Description"></textarea>
                        <label for="" class="margin">Choose Image (*)</label>
                        <asp:FileUpload ID="CNIC_img" runat="server" />
                        <h5 class="text-right ErrorCNIC" style="color: red;"></h5>
                        <asp:Button ID="Update_CNIC_Post" runat="server" CssClass="btn btn-warning center-block" Text="Update Post" OnClick="Update_CNIC_Post_Click" />
                        <%}
                            if (data.ThingName == "Mobile")
                            {
                        %>
                        <h5 style="display: none;" class="alert alert-success" id="alert_success_Mobile"><strong>Congratz!</strong> Post has been successfully updated.</h5>
                        <label for="">Owner Name (*)</label>
                        <input type="text" placeholder="Enter your Name" runat="server" id="Mobile_Owner_Name">
                        <label for="" class="margin">Owner CNIC (*)</label>
                        <input type="text" placeholder="Enter CNIC" runat="server" id="Mobile_Owner_CNIC">
                        <label for="" class="margin">Mobile Number (*)</label>
                        <input type="text" placeholder="Enter Mobile Number" runat="server" id="Mobile_Mobile_NO">
                        <label for="" class="margin">Another Mobile Number (Optional)</label>
                        <input type="text" placeholder="Enter Mobile Number" runat="server" id="Mobile_Mobile_NO2">
                        <label for="" class="margin">Father/Guardian Name (*)</label>
                        <input type="text" placeholder="Enter Name" runat="server" id="Mobile_Father_Name">
                        <label for="" class="margin">Father/Guardian CNIC (*)</label>
                        <input type="text" placeholder="Enter CNIC" runat="server" id="Mobile_Father_CNIC">
                        <label for="" class="margin">Permanent Address (Optional)</label>
                        <input type="text" placeholder="Enter Permanent Address" runat="server" id="Mobile_Permanent">
                        <label for="" class="margin">Current Address (Optional)</label>
                        <input type="text" placeholder="Enter Current Address" runat="server" id="Mobile_Current">
                        <label for="" class="margin">Missing Place (*)</label>
                        <input type="text" placeholder="Enter Missing Place" runat="server" id="Mobile_Place">
                        <label for="" class="margin">Brand Name (*)</label>
                        <input type="text" placeholder="Enter Brand Name" runat="server" id="Mobile_Brand">
                        <label for="" class="margin">Color (*)</label>
                        <input type="text" placeholder="Enter Color" runat="server" id="Mobile_Color">
                        <label for="" class="margin">Model (*)</label>
                        <input type="text" placeholder="Enter Model" runat="server" id="Mobile_Model">
                        <label for="" class="margin">IMEI (Optional)</label>
                        <input type="text" placeholder="Enter IMEI" runat="server" id="Mobile_IMEI">
                        <label for="" class="margin">Description (*)</label>
                        <textarea placeholder="Enter detail in at least 60 characters." runat="server" id="Mobile_Description"></textarea>
                        <label for="" class="margin">Choose Image (*)</label>
                        <asp:FileUpload ID="Mobile_img" runat="server" />
                        <h5 class="text-right ErrorMobile" style="color: red;"></h5>
                        <asp:Button ID="Update_Mobile_post" runat="server" CssClass="btn btn-warning center-block" Text="Update Post" OnClick="Update_Mobile_post_Click" />
                        <%}
                                }
                            }
                            else if (Request.QueryString["Unidentified-People-Edit-Post-ID"] != null)
                            {%>
                        <h5 style="display: none;" class="alert alert-danger" id="alert_Imag_Undentifiede"><strong>Please!</strong> choose image for post.</h5>
                        <h5 style="display: none;" class="alert alert-success" id="alert_success_Unidentified"><strong>Congratz!</strong> Post has been successfully updated.</h5>
                        <label for="">Full Name (*)</label>
                        <input type="text" placeholder="Enter your Name" runat="server" id="Uni_Name">
                        <label for="" class="margin">Father/Guardian Name (Optional)</label>
                        <input type="text" placeholder="Enter Father/Guardian Name" runat="server" id="Uni_Father_Name">
                        <label for="" class="margin">Mobile Number (*)</label>
                        <input type="text" placeholder="Enter Mobile Number" runat="server" id="Uni_Mobile">
                        <label for="" class="margin">Age (Optional)</label>
                        <input type="text" placeholder="Enter Age" runat="server" id="Uni_Age">
                        <label for="" class="margin">Unique Identification (Optional)</label>
                        <input type="text" placeholder="Enter Unique Identification" runat="server" id="Uni_Unique">
                        <label for="" class="margin">Found Place (*)</label>
                        <input type="text" placeholder="Enter Place" runat="server" id="Uni_found">
                        <label for="" class="margin">Language (*)</label>
                        <input type="text" placeholder="Enter Language" runat="server" id="Uni_language">
                        <label for="" class="margin">Description (*)</label>
                        <textarea placeholder="Enter detail in at least 60 characters." runat="server" id="Uni_description"></textarea>
                        <label for="" class="margin">Choose Image (*)</label>
                        <asp:FileUpload ID="Uni_Image" runat="server" />
                        <h5 class="text-right ErrorUnidentified" style="color: red;"></h5>
                        <asp:Button ID="Update_Unidentified_Post" runat="server" CssClass="btn btn-warning center-block" Text="Update Post" OnClick="Update_Unidentified_Post_Click" />
                        <%} %>
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
