<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FullPost.aspx.cs" Inherits="UI.FullPost" %>

<%@ Register Src="~/User Control Files/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/User Control Files/Navigation.ascx" TagPrefix="uc1" TagName="Navigation" %>
<%@ Register Src="~/User Control Files/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Full Post - Missing People and Things</title>
    <meta name="author" content="Umar Anwar" />
    <uc1:Header runat="server" ID="Header" />
</head>
<body>

    <form id="form1" runat="server">
        <section id="top-nav">
            <uc1:Navigation runat="server" ID="Navigation" />
        </section>

        <section id="discussion-forum">
            <!-- Start of Content2 Section -->
            <div class="container">
                <!-- Start of Content2 Container-->
                <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8" style="margin-bottom: 80px;">
                    <!-- Start of 1st Coloumn -->
                    <% if (Request.QueryString["Missing_People_Id"] != null)
                        {%>
                    <div class="post" style="margin-top: 2px;">
                        <!-- Post 2 -->
                        <div class="media">
                            <!-- Start of Media -->

                            <%   foreach (var data in MissingPeopleObject)
                                { %>
                            <div class="form-group">
                                <div class="form-inline NameAndImage pull-left">
                                    <% foreach (var userData in UserImageAndName)
                                        {%>
                                    <a href="Profile/user-profile">
                                        <img src="<%= userData.Image %>" alt="" width="40" height="40" class="img  img-circle">
                                        <label for="" style="cursor: pointer; text-decoration: none"><%= userData.FullName %></label>
                                    </a>
                                    <%} %>
                                </div>
                                <div class="pull-right total-views">
                                    <label class="views">Total Views : </label>
                                    &nbsp;<label class="total"><%= data.Count %></label>
                                </div>
                            </div>
                            <img src="<%= data.Image %>" alt="" width="100%" height="400px" class="img img-thumbnail">
                            <h4 class="information text-center">IMPORTANT INFORMATION</h4>
                            <hr class="information-bottom">
                            <div class="panel panel-default">
                                <!-- Default panel contents -->
                                <div class="panel-heading">Missing People Information</div>
                                <div class="panel-body">
                                    <p><%= data.Description %></p>
                                </div>
                                <!-- Table -->
                                <div class="table table-responsive">
                                    <table class="table table-responsive table-condensed table-bordered table-striped ">
                                        <tr class="heading">
                                            <th>Full Name</th>
                                            <th>Reference Number</th>
                                            <th>Status</th>
                                            <th>Father/Guardian Name</th>
                                            <th>Contact # 1</th>
                                            <th>Contact # 2</th>
                                            <th>Religion</th>
                                            <th>Permanent Address</th>
                                            <th>Current Address</th>
                                            <th>Missing Place</th>
                                            <th>Missing Date</th>
                                            <th>Tribe</th>
                                            <th>Age</th>
                                            <th>Language</th>
                                            <th>Cloth Color</th>
                                            <th>Hair Color</th>
                                            <th>Height</th>
                                            <th>Eyes Color</th>
                                            <th>Gander</th>
                                        </tr>
                                        <tr>
                                            <td><%= data.FullName %></td>
                                            <td><%= data.ReferenceNumber %></td>
                                            <td style="color: green; font-weight: bold"><%= data.Status%></td>
                                            <td><%= data.FatherGuardianName %></td>
                                            <td><%= data.ContactNumber %></td>
                                            <td><%= data.AnotherContactNumber %></td>
                                            <td><%= data.Religion %></td>
                                            <td><%= data.PermanentAddress %></td>
                                            <td><%= data.CurrentAddress %></td>
                                            <td><%= data.MissingPlace %></td>
                                            <td><%= data.MissingDate %></td>
                                            <td><%= data.Tribe %></td>
                                            <td><%= data.Age %></td>
                                            <td><%= data.LAnguage %></td>
                                            <td><%= data.ClothesColor %></td>
                                            <td><%= data.HairColor %></td>
                                            <td><%= data.Height %></td>
                                            <td><%= data.EyeColor %></td>
                                            <td><%= data.Gander%></td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                            <!-- End of Panel -->

                            <div class="col-lg-12 all-comments">
                                <!-- All Comments -->
                                <div class="comment-bottom">
                                    <a href="index?Favourite_Missing_People_ID=<%= data.PeopleID %>"><i class="fa fa-heart-o" aria-hidden="true"></i>&nbsp;&nbsp;Favourite</a>
                                    <a href="report-sighting"><i class="fa fa-pencil" aria-hidden="true"></i>&nbsp;&nbsp;Report a Sighting</a>
                                    <a href="https://plus.google.com/share?url=myownblog125.blogspot.com" onclick="javascript:window.open(this.href,'', 'menubar=no,toolbar=no,resizable=yes,scrollbars=yes,height=600,width=600');return false;"><i class="fa fa-google-plus"></i>&nbsp;&nbsp;Share on Google</a>
                                    <a class="twitter-share-button" href="https://twitter.com/intent/tweet?text=myownblog125.blogspot.com"><i class="fa fa-twitter" aria-hidden="true"></i>&nbsp;&nbsp;Share on Twitter</a>
                                </div>
                                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12 comment" style="margin-bottom: 5px;">
                                    <div class="col-xs-2 col-sm-2 col-md-1 col-lg-1">
                                        <%foreach (var dat in UserImageAndName)
                                            { %>
                                        <a href="">
                                            <img src="<%= dat.Image %>" alt="" class="img-circle"/></a>
                                        <%} %>
                                    </div>
                                    <div class="col-xs-10 col-sm-10 col-md-11 col-lg-11">
                                        <div class="form-inline">
                                            <input type="text" class="form-control" runat="server" id="PeopleComment" placeholder="Add a Comment" />
                                            <asp:Button ID="Button1" runat="server" CssClass="btn btn-default" Text="Submit" OnClick="Button1_Click" />
                                        </div>
                                    </div>
                                    <br>
                                    <!-- End of Form-Group-->
                                </div>
                                <!-- End of Comment -->


                                <% if (DisplayAllComments.Count > 0)
                                    {
                                        foreach (var mydata in DisplayAllComments)
                                        {%>
                                <div class="comments">
                                    <div class="col-xs-2 col-sm-2 col-md-1 col-lg-1">
                                        <!-- Comment1 -->
                                        <img src="<%= mydata.Image %>" class="img img-rounded" alt="" />
                                    </div>
                                    <div class="col-xs-10 col-sm-10 col-md-11 col-lg-11">
                                        <div class="dropdown pull-right">
                                            <!-- DropDwn-->
                                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-option-horizontal"></span></a>
                                            <ul class="dropdown-menu">
                                                <li><a href="missing-post?Missing_People_Id=<%= data.PeopleID %>&Missing_People_Delete_ID=<%= mydata.CommentID %>"><i class="fa fa-times" aria-hidden="true"></i>&nbsp;&nbsp;Delete</a></li>
                                            </ul>
                                        </div>
                                        <h5><%= mydata.FullName %></h5>
                                        <p><%= mydata.Message %></p>
                                    </div>
                                    <!-- End of DropDwn-->
                                </div>
                                <!-- End of Comments -->
                                <%}
                                    } %>
                            </div>
                            <!-- End of Media -->
                            <% }
                            %>
                        </div>
                        <!-- End of Post -->
                        <div class="alert alert-danger" runat="server" id="alert_danger" role="alert" style="display: none;"><span class="glyphicon glyphicon-thumbs-down" aria-hidden="true"></span>&nbsp; Please write something.</div>
                        <div class="alert alert-success" runat="server" id="alert_sucess" role="alert" style="display: none;"><span class="glyphicon glyphicon-thumbs-up" aria-hidden="true"></span>&nbsp; Comment has been Added.</div>
                    </div>
                    <% }
                        else if (Request.QueryString["Missing_Thing_Id"] != null)
                        {%>
                    <div class="post" style="margin-top: 2px;">
                        <!-- Post 2 -->
                        <div class="media">
                            <!-- Start of Media -->
                            <%
                                foreach (var data in MissingThingObject)
                                {
                                    if (data.ThingName == "CNIC")
                                    {%>
                            <div class="form-group">
                                <div class="form-inline NameAndImage pull-left">
                                    <% foreach (var userData in UserImageAndName)
                                        {%>
                                    <a href="Profile/user-profile">
                                        <img src="<%= userData.Image %>" alt="" width="40" height="40" class="img  img-circle">
                                        <label for=""><%= userData.FullName %></label>
                                    </a>
                                    <%} %>
                                </div>

                                <div class="pull-right total-views">
                                    <label class="views">Total Views : </label>
                                    &nbsp;<label class="total"><%= data.Count %></label>
                                </div>
                            </div>
                            <img src="<%= data.Image%>" alt="" width="100%" height="400px" class="img img-thumbnail">
                            <h4 class="information text-center">IMPORTANT INFORMATION</h4>
                            <hr class="information-bottom">
                            <div class="panel panel-default">
                                <!-- Default panel contents -->
                                <div class="panel-heading">Missing Thing Information</div>
                                <div class="panel-body">
                                    <p><%= data.Description%></p>
                                </div>
                                <!-- Table -->
                                <div class="table table-responsive">
                                    <table class="table table-responsive table-condensed table-bordered table-striped ">
                                        <tr class="heading">
                                            <th>Full Name</th>
                                            <th>Reference Number</th>
                                            <th>Status</th>
                                            <th>Father/Guardian Name</th>
                                            <th>Contact # 1</th>
                                            <th>Contact # 2</th>
                                            <th>Permanent Address</th>
                                            <th>Current Address</th>
                                            <th>Missing Place</th>
                                            <th>Missing Date</th>
                                            <th>Missing Thing Name</th>
                                            <th>CNIC Number</th>
                                            <th>Unique Identification</th>
                                            <th>Date of Birth</th>
                                            <th>Family Number</th>
                                            <th>Gander</th>
                                        </tr>
                                        <tr>
                                            <td><%= data.OwnerName%></td>
                                            <td><%= data.ReferenceNumber%></td>
                                            <td style="color: green; font-weight: bold"><%= data.Status%></td>
                                            <td><%= data.FatherGuardianName%></td>
                                            <td><%= data.ContactNumber%></td>
                                            <td><%= data.AnotherContactNumber%></td>
                                            <td><%= data.PermanentAddress%></td>
                                            <td><%= data.CurrentAddress%></td>
                                            <td><%= data.MissingPlace%></td>
                                            <td><%= data.MissingDate%></td>
                                            <td><%= data.ThingName%></td>
                                            <td><%= data.CNICNumber%></td>
                                            <td><%= data.UniqueIdentification%></td>
                                            <td><%= data.DateOfBirth%></td>
                                            <td><%= data.FamilyNumber%></td>
                                            <td><%= data.Gander%></td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                            <!-- End of Panel -->

                            <div class="col-lg-12 all-comments">
                                <!-- All Comments -->
                                <div class="comment-bottom">
                                    <a href="index?Favourite_Missing_Thing_ID=<%= data.ThingID %>"><i class="fa fa-heart-o" aria-hidden="true"></i>&nbsp;&nbsp;Favourite</a>
                                    <a href="report-sighting"><i class="fa fa-pencil" aria-hidden="true"></i>&nbsp;&nbsp;Report a Sighting</a>
                                    <a href="https://plus.google.com/share?url=myownblog125.blogspot.com" onclick="javascript:window.open(this.href,'', 'menubar=no,toolbar=no,resizable=yes,scrollbars=yes,height=600,width=600');return false;"><i class="fa fa-google-plus"></i>&nbsp;&nbsp;Share on Google</a>
                                    <a class="twitter-share-button" href="https://twitter.com/intent/tweet?text=myownblog125.blogspot.com"><i class="fa fa-twitter" aria-hidden="true"></i>&nbsp;&nbsp;Share on Twitter</a>
                                </div>
                                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12 comment" style="margin-bottom: 5px;">
                                    <div class="col-xs-2 col-sm-2 col-md-1 col-lg-1">
                                        <%foreach (var dat in UserImageAndName)
                                            { %>
                                        <a href="">
                                            <img src="<%= dat.Image %>" alt="" class="img-circle"  /></a>
                                        <%} %>
                                    </div>
                                    <div class="col-xs-10 col-sm-10 col-md-11 col-lg-11" >
                                        <div class=" form-inline">
                                            <input type="text" id="CnicComment" runat="server" class="form-control" placeholder="Add a Comment" />
                                            <asp:Button ID="Button2" runat="server" CssClass="btn btn-default" Text="Submit" OnClick="Button2_Click" />
                                        </div>
                                    </div>
                                    <br>
                                    <!-- End of Form-Group-->
                                </div>
                                <!-- End of Comment -->

                                <%if (DisplayCNICComments.Count > 0)
                                    {
                                        foreach (var mydata in DisplayCNICComments)
                                        { %>
                                <div class="comments">
                                    <div class="col-xs-2 col-sm-2 col-md-1 col-lg-1">
                                        <!-- Comment1 -->
                                        <img src="<%= mydata.Image %>" class="img img-circle" alt="" />
                                    </div>
                                    <div class="col-xs-10 col-sm-10 col-md-11 col-lg-11">
                                        <div class="dropdown pull-right">
                                            <!-- DropDwn-->
                                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-option-horizontal"></span></a>
                                            <ul class="dropdown-menu">
                                                <li><a href="missing-post?Missing_Thing_Id=<%= data.ThingID%>&CNIC_Delete_ID=<%= mydata.CommentID %>"><i class="fa fa-times" aria-hidden="true"></i>&nbsp;&nbsp;Delete</a></li>
                                            </ul>
                                        </div>
                                        <h5><%= mydata.FullName %></h5>
                                        <p><%= mydata.Message %></p>
                                    </div>
                                    <!-- End of DropDwn-->
                                </div>
                                <!-- End of Comments -->
                                <%}
                                    } %>
                            </div>
                            <!-- End of Media -->
                            <%}
                                else if (data.ThingName == "Auto Mobile")
                                {%>
                            <div class="form-group">
                                <div class="form-inline NameAndImage pull-left">
                                    <% foreach (var userData in UserImageAndName)
                                        {%>
                                    <a href="Profile/user-profile">
                                        <img src="<%= userData.Image%>" alt="" width="40" height="40" class="img  img-circle">
                                        <label for=""><%= userData.FullName%></label>
                                    </a>
                                    <%} %>
                                </div>

                                <div class="pull-right total-views">
                                    <label class="views">Total Views : </label>
                                    &nbsp;<label class="total"><%= data.Count%></label>
                                </div>
                            </div>
                            <img src="<%= data.Image%>" alt="" width="100%" height="400px" class="img img-thumbnail">
                            <h4 class="information text-center">IMPORTANT INFORMATION</h4>
                            <hr class="information-bottom">
                            <div class="panel panel-default">
                                <!-- Default panel contents -->
                                <div class="panel-heading">Missing Thing Information</div>
                                <div class="panel-body">
                                    <p><%= data.Description%></p>
                                </div>
                                <!-- Table -->
                                <div class="table table-responsive">
                                    <table class="table table-responsive table-condensed table-bordered table-striped ">
                                        <tr class="heading">
                                            <th>Full Name</th>
                                            <th>Reference Number</th>
                                            <th>Status</th>
                                            <th>Father/Guardian Name</th>
                                            <th>Contact # 1</th>
                                            <th>Contact # 2</th>
                                            <th>Permanent Address</th>
                                            <th>Current Address</th>
                                            <th>Missing Place</th>
                                            <th>Missing Date</th>
                                            <th>Missing Thing Name</th>
                                            <th>Company Name</th>
                                            <th>Brand Name</th>
                                            <th>Engine Number</th>
                                            <th>Chasses Number</th>
                                            <th>Color</th>
                                            <th>Model</th>
                                        </tr>
                                        <tr>
                                            <td><%= data.OwnerName%></td>
                                            <td><%= data.ReferenceNumber%></td>
                                            <td style="color: green; font-weight: bold"><%= data.Status%></td>
                                            <td><%= data.FatherGuardianName%></td>
                                            <td><%= data.ContactNumber%></td>
                                            <td><%= data.AnotherContactNumber%></td>
                                            <td><%= data.PermanentAddress%></td>
                                            <td><%= data.CurrentAddress%></td>
                                            <td><%= data.MissingPlace%></td>
                                            <td><%= data.MissingDate%></td>
                                            <td><%= data.ThingName%></td>
                                            <td><%= data.CompanyName%></td>
                                            <td><%= data.BrandName%></td>
                                            <td><%= data.EngineNumber%></td>
                                            <td><%= data.FamilyNumber%></td>
                                            <td><%= data.Color%></td>
                                            <td><%= data.Model%></td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                            <!-- End of Panel -->
                            <div class="comment-bottom">
                                <a href="index?Favourite_Missing_Thing_ID=<%= data.ThingID %>"><i class="fa fa-heart-o" aria-hidden="true"></i>&nbsp;&nbsp;Favourite</a>
                                <a href="report-sighting"><i class="fa fa-pencil" aria-hidden="true"></i>&nbsp;&nbsp;Report a Sighting</a>
                                <a href="https://plus.google.com/share?url=myownblog125.blogspot.com" onclick="javascript:window.open(this.href,'', 'menubar=no,toolbar=no,resizable=yes,scrollbars=yes,height=600,width=600');return false;"><i class="fa fa-google-plus"></i>&nbsp;&nbsp;Share on Google</a>
                                <a class="twitter-share-button" href="https://twitter.com/intent/tweet?text=myownblog125.blogspot.com"><i class="fa fa-twitter" aria-hidden="true"></i>&nbsp;&nbsp;Share on Twitter</a>
                            </div>
                            <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12 comment" style="margin-bottom: 5px;">

                                <div class="col-xs-2 col-sm-2 col-md-1 col-lg-1">
                                    <%foreach (var dat in UserImageAndName)
                                        { %>
                                    <a href="">
                                        <img src="<%= dat.Image %>" alt="" class="img-circle"  /></a>
                                    <%} %>
                                </div>
                                <div class="col-xs-10 col-sm-10 col-md-11 col-lg-11" >
                                    <div class=" form-inline">
                                        <input type="text" id="AutoMobileComment" runat="server" class="form-control" placeholder="Add a Comment" />
                                        <asp:Button ID="Button3" runat="server" CssClass="btn btn-default" Text="Submit" OnClick="Button3_Click" />
                                    </div>
                                </div>
                                <br>
                                <!-- End of Form-Group-->
                            </div>
                            <!-- End of Comment -->

                            <div class="col-lg-12 all-comments">
                                <!-- All Comments -->
                                <%if (DisplayAutoMobileComments.Count > 0)
                                    {
                                        foreach (var mydata in DisplayAutoMobileComments)
                                        { %>
                                <div class="comments">
                                    <div class="col-xs-2 col-sm-2 col-md-1 col-lg-1">
                                        <!-- Comment1 -->
                                        <img src="<%= mydata.Image %>" class="img img-circle" alt=""/>
                                    </div>
                                    <div class="col-xs-10 col-sm-10 col-md-11 col-lg-11">
                                        <div class="dropdown pull-right">
                                            <!-- DropDwn-->
                                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-option-horizontal"></span></a>
                                            <ul class="dropdown-menu">
                                                <li><a href="missing-post?Missing_Thing_Id=<%= data.ThingID%>&AutoMobile_Delete_ID=<%= mydata.CommentID %>"><i class="fa fa-times" aria-hidden="true"></i>&nbsp;&nbsp;Delete</a></li>
                                            </ul>
                                        </div>
                                        <h5><%= mydata.FullName %></h5>
                                        <p><%= mydata.Message %></p>
                                    </div>
                                    <!-- End of DropDwn-->
                                </div>
                                <!-- End of Comments -->
                                <% }
                                    }%>
                            </div>
                            <!-- End of Media -->

                            <% 
                                }
                                else if (data.ThingName == "Mobile")
                                {%>
                            <div class="form-group">
                                <div class="form-inline NameAndImage pull-left">
                                    <% foreach (var userData in UserImageAndName)
                                        {%>
                                    <a href="Profile/user-profile">
                                        <img src="<%= userData.Image%>" alt="" width="40" height="40" class="img  img-circle">
                                        <label for=""><%= userData.FullName%></label>
                                    </a>
                                    <%} %>
                                </div>

                                <div class="pull-right total-views">
                                    <label class="views">Total Views : </label>
                                    &nbsp;<label class="total"><%= data.Count%></label>
                                </div>
                            </div>
                            <img src="<%= data.Image%>" alt="" width="100%" height="400px" class="img img-thumbnail">
                            <h4 class="information text-center">IMPORTANT INFORMATION</h4>
                            <hr class="information-bottom">
                            <div class="panel panel-default">
                                <!-- Default panel contents -->
                                <div class="panel-heading">Missing Thing Information</div>
                                <div class="panel-body">
                                    <p><%= data.Description%></p>
                                </div>
                                <!-- Table -->
                                <div class="table table-responsive">
                                    <table class="table table-responsive table-condensed table-bordered table-striped ">
                                        <tr class="heading">
                                            <th>Full Name</th>
                                            <th>Reference Number</th>
                                            <th>Status</th>
                                            <th>Father/Guardian Name</th>
                                            <th>Contact # 1</th>
                                            <th>Contact # 2</th>
                                            <th>Permanent Address</th>
                                            <th>Current Address</th>
                                            <th>Missing Place</th>
                                            <th>Missing Date</th>
                                            <th>Missing Thing Name</th>
                                            <th>Color</th>
                                            <th>Brand Name</th>
                                            <th>Model</th>
                                            <th>IMEI</th>
                                        </tr>
                                        <tr>
                                            <td><%= data.OwnerName%></td>
                                            <td><%= data.ReferenceNumber%></td>
                                            <td style="color: green; font-weightbold"><%= data.Status%></td>
                                            <td><%= data.FatherGuardianName%></td>
                                            <td><%= data.ContactNumber%></td>
                                            <td><%= data.AnotherContactNumber%></td>
                                            <td><%= data.PermanentAddress%></td>
                                            <td><%= data.CurrentAddress%></td>
                                            <td><%= data.MissingPlace%></td>
                                            <td><%= data.MissingDate%></td>
                                            <td><%= data.ThingName%></td>
                                            <td><%= data.Color%></td>
                                            <td><%= data.BrandName%></td>
                                            <td><%= data.Model%></td>
                                            <td><%= data.IMEI%></td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                            <!-- End of Panel -->

                            <div class="col-lg-12 all-comments">
                                <!-- All Comments -->
                                <div class="comment-bottom">
                                    <a href="index?Favourite_Missing_Thing_ID=<%= data.ThingID %>"><i class="fa fa-heart-o" aria-hidden="true"></i>&nbsp;&nbsp;Favourite</a>
                                    <a href="report-sighting"><i class="fa fa-pencil" aria-hidden="true"></i>&nbsp;&nbsp;Report a Sighting</a>
                                    <a href="https://plus.google.com/share?url=myownblog125.blogspot.com" onclick="javascript:window.open(this.href,'', 'menubar=no,toolbar=no,resizable=yes,scrollbars=yes,height=600,width=600');return false;"><i class="fa fa-google-plus"></i>&nbsp;&nbsp;Share on Google</a>
                                    <a class="twitter-share-button" href="https://twitter.com/intent/tweet?text=myownblog125.blogspot.com"><i class="fa fa-twitter" aria-hidden="true"></i>&nbsp;&nbsp;Share on Twitter</a>
                                </div>
                                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12 comment" style="margin-bottom: 5px;">
                                    <div class="col-xs-2 col-sm-2 col-md-1 col-lg-1">
                                        <%foreach (var dat in UserImageAndName)
                                            { %>
                                        <a href="">
                                            <img src="<%= dat.Image %>" alt="" class="img-circle" /></a>
                                        <%} %>
                                    </div>
                                    <div class="col-xs-10 col-sm-10 col-md-11 col-lg-11">
                                        <div class=" form-inline">
                                            <input type="text" id="MobileComment" runat="server" class="form-control" placeholder="Add a Comment" />
                                            <asp:Button ID="Button4" runat="server" CssClass="btn btn-default" Text="Submit" OnClick="Button4_Click" />
                                        </div>
                                    </div>
                                    <br>
                                    <!-- End of Form-Group-->
                                </div>
                                <!-- End of Comment -->

                                <% if (DisplayMobileComments.Count > 0)
                                    {
                                        foreach (var mydata in DisplayMobileComments)
                                        { %>
                                <div class="comments">
                                    <div class="col-xs-2 col-sm-2 col-md-1 col-lg-1">
                                        <!-- Comment1 -->
                                        <img src="<%= mydata.Image %>" class="img img-circle" alt="" />
                                    </div>
                                    <div class="col-xs-10 col-sm-10 col-md-11 col-lg-11">
                                        <div class="dropdown pull-right">
                                            <!-- DropDwn-->
                                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-option-horizontal"></span></a>
                                            <ul class="dropdown-menu">
                                                <li><a href="missing-post?Missing_Thing_Id=<%= data.ThingID%>&Mobile_Delete_ID=<%= mydata.CommentID %>"><i class="fa fa-times" aria-hidden="true"></i>&nbsp;&nbsp;Delete</a></li>
                                            </ul>
                                        </div>
                                        <h5><%= mydata.FullName %></h5>
                                        <p><%= mydata.Message %></p>
                                    </div>
                                    <!-- End of DropDwn-->
                                </div>
                                <!-- End of Comments -->
                                <%}
                                    } %>
                            </div>
                            <!-- End of Media -->
                            <%}
                                else
                                    Response.Write("Sorry Some problem Occur, try Later."); %>
                            <% }%>
                        </div>
                        <!-- End of Post -->
                            <div class="alert alert-danger" runat="server" id="Div1" role="alert" style="display: none;"><span class="glyphicon glyphicon-thumbs-down" aria-hidden="true"></span>&nbsp; Please write something.</div>
                        <div class="alert alert-success" runat="server" id="Div2" role="alert" style="display: none;"><span class="glyphicon glyphicon-thumbs-up" aria-hidden="true"></span>&nbsp; Comment has been Added.</div>
                    
                    </div>
                    <%}
                        else if (Request.QueryString["Unidentified_People_Id"] != null)
                        {%>
                    <div class="post" style="margin-top: 2px;">
                        <!-- Post 2 -->
                        <div class="media">
                            <!-- Start of Media -->

                            <%   foreach (var data in UnidentifiedPeopleObject)
                                { %>
                            <div class="form-group">
                                <div class="form-inline NameAndImage pull-left">
                                    <% foreach (var userData in UserImageAndName)
                                        {%>
                                    <a href="Profile/user-profile">
                                        <img src="<%= userData.Image %>" alt="" width="40" height="40" class="img  img-circle">
                                        <label for=""><%= userData.FullName %></label>
                                    </a>
                                    <%} %>
                                </div>

                                <div class="pull-right total-views">
                                    <label class="views">Total Views : </label>
                                    &nbsp;<label class="total"><%= data.Count %></label>
                                </div>
                            </div>
                            <img src="<%= data.Image %>" alt="" width="100%" height="400px" class="img" style="border-radius: 4px">
                            <h4 class="information text-center">IMPORTANT INFORMATION</h4>
                            <hr class="information-bottom">
                            <div class="panel panel-default">
                                <!-- Default panel contents -->
                                <div class="panel-heading">Unidentified People Information</div>
                                <div class="panel-body">
                                    <p><%= data.Description %></p>
                                </div>
                                <!-- Table -->
                                <div class="table table-responsive">
                                    <table class="table table-responsive table-condensed table-bordered table-striped ">
                                        <tr class="heading">
                                            <th>Full Name</th>
                                            <th>Reference Number</th>
                                            <th>Status</th>
                                            <th>Father/Guardian Name</th>
                                            <th>Contact # 1</th>
                                            <th>Religion</th>
                                            <th>Age</th>
                                            <th>Unique Identification</th>
                                            <th>Found Place</th>
                                            <th>Language</th>
                                            <th>Cloth Color</th>
                                            <th>Eyes Color</th>
                                            <th>Gander</th>
                                        </tr>
                                        <tr>
                                            <td><%= data.FullName %></td>
                                            <td><%= data.ReferenceNumber %></td>
                                            <td style="color: green; font-weight: bold;"><%= data.Status %></td>
                                            <td><%= data.FatherGuardianName %></td>
                                            <td><%= data.ContactNumber %></td>
                                            <td><%= data.Religion %></td>
                                            <td><%= data.Age %></td>
                                            <td><%= data.UniqueIdentification %></td>
                                            <td><%= data.FoundPlace %></td>
                                            <td><%= data.Language %></td>
                                            <td><%= data.ClothColor %></td>
                                            <td><%= data.EyesColor %></td>
                                            <td><%= data.Gander %></td>
                                    </table>
                                </div>
                            </div>
                            <!-- End of Panel -->


                            <div class="col-lg-12 all-comments">
                                <!-- All Comments -->
                                <div class="comment-bottom">
                                    <a href="index?Favourite_Unidentified_People_ID=<%= data.UnindentifiedID %>"><i class="fa fa-heart-o" aria-hidden="true"></i>&nbsp;&nbsp;Favourite</a>
                                    <a href="report-sighting"><i class="fa fa-pencil" aria-hidden="true"></i>&nbsp;&nbsp;Report a Sighting</a>
                                    <a href="https://plus.google.com/share?url=myownblog125.blogspot.com" onclick="javascript:window.open(this.href,'', 'menubar=no,toolbar=no,resizable=yes,scrollbars=yes,height=600,width=600');return false;"><i class="fa fa-google-plus"></i>&nbsp;&nbsp;Share on Google</a>
                                    <a class="twitter-share-button" href="https://twitter.com/intent/tweet?text=myownblog125.blogspot.com"><i class="fa fa-twitter" aria-hidden="true"></i>&nbsp;&nbsp;Share on Twitter</a>
                                </div>
                                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12 comment" style="margin-bottom: 5px;">
                                    <div class="col-xs-2 col-sm-2 col-md-1 col-lg-1">
                                        <%foreach (var dat in UserImageAndName)
                                            { %>
                                        <a href="">
                                            <img src="<%= dat.Image %>" alt="" class="img-circle" /></a>
                                        <%} %>
                                    </div>
                                    <div class="col-xs-10 col-sm-10 col-md-11 col-lg-11" >
                                        <div class=" form-inline">
                                            <input type="text" id="UnidentifiedPeopleComments" runat="server" class="form-control" placeholder="Add a Comment" />
                                            <asp:Button ID="Button5" runat="server" CssClass="btn btn-default" Text="Submit" OnClick="Button5_Click" />
                                        </div>
                                    </div>
                                    <br>
                                    <!-- End of Form-Group-->
                                </div>
                                <!-- End of Comment -->

                                <% if (DisplayUnidentifiedPeopleComments.Count > 0)
                                    {
                                        foreach (var mydata in DisplayUnidentifiedPeopleComments)
                                        { %>
                                <div class="comments">
                                    <div class="col-xs-2 col-sm-2 col-md-1 col-lg-1">
                                        <!-- Comment1 -->
                                        <img src="<%= mydata.Image %>" class="img img-circle" alt="">
                                    </div>
                                    <div class="col-xs-10 col-sm-10 col-md-11 col-lg-11">
                                        <div class="dropdown pull-right">
                                            <!-- DropDwn-->
                                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-option-horizontal"></span></a>
                                            <ul class="dropdown-menu">
                                                <li><a href="missing-post?Unidentified_People_Id=<%= data.UnindentifiedID%>&UnidentifiedPeople_Delete_ID=<%= mydata.CommentID %>"><i class="fa fa-times" aria-hidden="true"></i>&nbsp;&nbsp;Delete</a></li>
                                            </ul>
                                        </div>
                                        <h5><%= mydata.FullName %></h5>
                                        <p><%= mydata.Message %></p>
                                    </div>
                                    <!-- End of DropDwn-->
                                </div>
                                <!-- End of Comments -->
                                <%}
                                    } %>
                            </div>
                            <!-- End of Media -->
                            <% }
                            %>
                        </div>
                        <!-- End of Post -->
                            <div class="alert alert-danger" runat="server" id="Div3" role="alert" style="display: none;"><span class="glyphicon glyphicon-thumbs-down" aria-hidden="true"></span>&nbsp; Please write something.</div>
                        <div class="alert alert-success" runat="server" id="Div4" role="alert" style="display: none;"><span class="glyphicon glyphicon-thumbs-up" aria-hidden="true"></span>&nbsp; Comment has been Added.</div>
                    
                    </div>
                    <% }
                        else
                        {
                            Response.Redirect("Default.aspx");
                        } %>
                </div>

                <div class="col-xs-12 col-sm-4 col-md-4 col-lg-4 column2 Popular-column">
                    <!-- Start of 2nd Coloumn -->
                    <div class="panel panel-default">
                        <!-- Start of Panel for Recent Post -->
                        <div class="panel-heading">
                            <!-- Start of Panel-Heading -->
                            Popular Post
                        </div>
                        <!-- End of Panel-Heading -->
                        <div class="panel-body">
                            <% if (DisplayPopularPostOfMissingPeople.Count >= 1 || DisplayPopularPostOfMissingThing.Count >= 1 || DisplayPopularPostOfUnidentifiedPeople.Count >= 1)
                                {
                                    if (DisplayPopularPostOfMissingPeople.Count > 0)
                                    {
                                        foreach (var data in DisplayPopularPostOfMissingPeople)
                                        {%>
                            <!-- Popular Posts -->
                            <a href="missing-post?Missing_People_Id=<%=data.PeopleID%>">
                                <div class="col-xs-3 col-sm-12 col-md-4 col-lg-3">
                                    <img src="<%= data.Image%>" alt="" width="60" />
                                </div>
                                <div class="col-xs-9 col-sm-12 col-md-8 col-lg-9">
                                    <h4><%= data.FullName%></h4>
                                    <h5>Contact# <%= data.ContactNumber%></h5>
                                    <p>Hide From <%= data.MissingPlace%></p>
                                </div>
                                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                                    <p class="text"><%= data.Description.Substring(0, 50)%></p>
                                    <hr />
                                </div>
                                <!-- End of Post 1-->
                            </a>
                            <%}
                                }
                                if (DisplayPopularPostOfMissingThing.Count > 0)
                                {
                                    foreach (var data in DisplayPopularPostOfMissingThing)
                                    {%>
                            <a href="missing-post?Missing_Thing_Id=<%= data.ThingID %>">
                                <div class="col-xs-3 col-sm-12 col-md-4 col-lg-3">
                                    <img src="<%= data.Image%>" alt="" width="60" />
                                </div>
                                <div class="col-xs-9 col-sm-12 col-md-8 col-lg-9">
                                    <h4><%= data.OwnerName%></h4>
                                    <h5>Contact# <%= data.ContactNumber%></h5>
                                    <p>Hide From <%= data.MissingPlace%></p>
                                </div>
                                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                                    <p class="text"><%= data.Description.Substring(0, 50)%></p>
                                    <hr />
                                </div>
                                <!-- End of Post 1-->
                            </a>
                            <%}
                                }
                                if (DisplayPopularPostOfUnidentifiedPeople.Count > 0)
                                {
                                    foreach (var data in DisplayPopularPostOfUnidentifiedPeople)
                                    {%>
                            <a href="missing-post?Unidentified_People_Id=<%= data.UnindentifiedID%>">
                                <div class="col-xs-3 col-sm-12 col-md-4 col-lg-3">
                                    <img src="<%= data.Image%>" alt="" width="60" />
                                </div>
                                <div class="col-xs-9 col-sm-12 col-md-8 col-lg-9">
                                    <h4><%= data.FullName%></h4>
                                    <h5>Contact# <%= data.ContactNumber%></h5>
                                    <p>Hide From <%= data.FoundPlace%></p>
                                </div>
                                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                                    <p class="text"><%= data.Description.Substring(0, 50)%></p>
                                    <hr />
                                </div>
                                <!-- End of Post 1-->
                            </a>
                            <%}
                                    }
                                }
                                else
                                    Response.Write("<h5 class='text-center' visible='false'>Sorry No Post is Available.</h5>"); %>
                        </div>
                        <!-- End of Panel Body -->
                    </div>
                    <!-- End of Panel -->
                </div>
                <!-- End of 2nd Coloumn -->
            </div>
            <!-- End of Content2 Container -->
        </section>
        <!-- End of Content2 Section -->

        <div id="Testimonial">
            <div class="footer">
                <div class="text-center">
                    <a href="#top-nav">
                        <img src="Image/Hero-Area-Up-Icon.png" alt="" width="55"></a>
                </div>
                <uc1:Footer runat="server" ID="Footer" />
            </div>
        </div>
        <!-- End of Footer-->
    </form>
</body>
</html>
