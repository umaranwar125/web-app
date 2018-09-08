<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UI.Default" %>

<%@ Register Src="~/User Control Files/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/User Control Files/Navigation.ascx" TagPrefix="uc1" TagName="Navigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <uc1:Header runat="server" ID="Header1" />
    <title>Home - Missing People and Things</title>
    <meta name="keywords" content="missing people, missing things, auto mobile, mobile, cnic, unidentified people, pakistan website, missing people in pakistan"/>
    <meta name="description" content="This website is all about those people whose relatives and things like Auto mobile, Mobiles, and CNIC are missed and want to find them." />
    <meta name="author" content="Umar Anwar" />
</head>
<body>

    <div id="fb-root"></div>
    <script>(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) return;
    js = d.createElement(s); js.id = id;
    js.src = 'https://connect.facebook.net/en_US/sdk.js#xfbml=1&version=v2.12';
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));</script>

    <form id="form1" runat="server">
        <!-- Favourite Post Success -->
        <div class="top-favourite" runat="server" id="FavouriteSuccess" style="display: none">
            <p>Post has been added successfully to your profile.</p>
        </div>

        <div class="top-favourite" runat="server" id="FavouriteFailure" style="display: none">
            <p>Post is already available in your profile.</p>
        </div>

        <!-- Starting of Header Area -->
        <section id="Header">
            <uc1:Navigation runat="server" ID="Navigation" />
            <!-- Hero Content Area -->
            <div class="container">
                <!-- Start of Hero Area Container -->
                <div class="col-xs-12 col-sm-8 col-md-6 col-lg-6 hero-content">
                    <h1><b>W</b>e <b>A</b>re <b>Y</b>our <b>L</b>ast <b>H</b>ope<span>.</span></h1>
                    <p>If you are worried about finding your loved ones and your stolen objects, don't go anywhere we are here to help you. We are with you in your sorrow. Just add a post and keep visiting our website so that you can find your missing relatives or objects quickly. If you are worried about finding your loved ones and your stolen objects, don't go anywhere we are here to help you. We are with you in your sorrow. Just add a post and keep visiting our website so that you can find your missing relatives or objects quickly. Just add a post and keep visiting our website so that you can find your missing relatives or objects quickly.</p>
                    <br />
                    <center>
						<a href="post-report" class="post-button">Post a Report</a>
						<a href="about" class="about-button">About Us</a>
						<a href="report-sighting" class="report-button">Report a Sighting</a>
					</center>
                </div>
                <div class="col-xs-12 col-sm-8 col-md-6 col-lg-6"></div>
            </div>
            <!-- End of Hero Area Container-->
            <div class="text-center">
                <a href="#discussion-forum">
                    <img src="Image/Hero-Area-Down-Icon.png" alt="" width="55"></a>
            </div>
        </section>
        <!-- End of Header Section -->


        <section id="content1">
            <!-- Start of Content1 Section -->
            <div class="container">
                <!-- Start of Content1 Container -->
                <div class="col-xs-6 col-sm-6 col-md-3 col-lg-3">
                    <!-- Post1 -->
                    <div class="container-fluid post1">
                        <h2 class="text-center"><b>C</b>ontact <b>U</b>s</h2>
                        <hr>
                        <p>If you are worried about finding your loved ones and your stolen objects, don't go anywhere we are here to help you.</p>
                        <center>
							<a href="contact">Contact Us</a>
						</center>
                        <br />
                    </div>
                </div>
                <div class="col-xs-6 col-sm-6 col-md-3 col-lg-3">
                    <!-- Post2 -->
                    <div class="container-fluid post2">
                        <h2 class="text-center"><b>A</b>ll <b>P</b>osts</h2>
                        <hr>
                        <p>If you are worried about finding your loved ones and your stolen objects, don't go anywhere we are here to help you.</p>
                        <center>
							<a href="all-posts">All Posts</a>
						</center>
                        <br />
                    </div>
                </div>
                <div class="col-xs-6 col-sm-6 col-md-3 col-lg-3">
                    <!-- Post3 -->
                    <div class="container-fluid post3">
                        <h2 class="text-center"><b>G</b>et <b>C</b>onnected</h2>
                        <hr>
                        <p>If you are worried about finding your loved ones and your stolen objects, don't go anywhere we are here to help you.</p>
                        <center>
							<a href="register">Create Account</a>
						</center>
                        <br />
                    </div>
                </div>
                <div class="col-xs-6 col-sm-6 col-md-3 col-lg-3">
                    <!-- Post3 -->
                    <div class="container-fluid post4">
                        <h2 class="text-center"><b>F</b>ound <b>S</b>omeone</h2>
                        <hr>
                        <p>If you are worried about finding your loved ones and your stolen objects, don't go anywhere we are here to help you.</p>
                        <center>
							<a href="report-sighting">Report It</a>
						</center>
                        <br />
                    </div>
                </div>
            </div>
            <!-- End of Content1 Container Section -->
        </section>
        <!-- End of Content1 Section -->



        <section id="discussion-forum">
            <!-- Start of Content2 Section -->
            <div class="container">
                <!-- Start of Content2 Container-->
                <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8">
                    <!-- Start of 1st Coloumn -->
                    <h2 class="heading"><b>M</b>issing <b>P</b>osts</h2>
                    <% if (DisplayRecentPostOfMissingPeople.Count >= 1 || DisplayRecentPostOfMissingThing.Count >= 1 || DisplayRecentPostOfUnidentifiedPeople.Count >= 1)
                        { %>
                    <%if (Post_display.Count > 0)
                        {
                            foreach (var data in Post_display)
                            {%>
                    <div class="post">
                        <!-- Post 1 -->
                        <div class="media">
                            <!-- Start of Media -->
                            <div class="media-left">
                                <!-- tart of Media-left -->
                                <a href="missing-post?Missing_People_Id=<%=data.PeopleID%>">
                                    <img class="media-object img-thumbnail" id="image" src="<%= data.Image%>" alt="Image" height="200" width="150" />
                                </a>
                            </div>
                            <div class="media-body">
                                <!-- tart of Media-body -->
                                <div class="dropdown pull-right">
                                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-option-horizontal"></span></a>
                                    <ul class="dropdown-menu">
                                        <li><a href="report-sighting"><i class="fa fa-pencil" aria-hidden="true"></i>&nbsp;&nbsp;Report a Sighting</a></li>
                                        <li><a href="missing-post?Missing_People_Id=<%=data.PeopleID%>"><i class="fa fa-eye" aria-hidden="true"></i>&nbsp;&nbsp;See Full Post</a></li>
                                        <li><a href="index?Favourite_Missing_People_ID=<%= data.PeopleID %>"><i class="fa fa-heart-o" aria-hidden="true"></i>&nbsp;&nbsp;Favourite</a></li>
                                        <li><a href="print-form?Print-Missing-People-ID=<%= data.PeopleID %>"><i class="fa fa-print"></i>&nbsp;&nbsp;Print</a></li>
                                        <li class="divider"></li>
                                        <div class="text-center">
                                        <li class="center-block"><div class="fb-share-button" data-href="https://www.missingpeopleandthings.com" data-layout="button" data-size="small" data-mobile-iframe="true"><a target="_blank" href="https://www.facebook.com/sharer/sharer.php?u=<%= data.PeopleID %>" class="fb-xfbml-parse-ignore">Share</a></div></li>
                                        </div>
                                        <li><a href="https://plus.google.com/share?url=myownblog125.blogspot.com" onclick="javascript:window.open(this.href,'', 'menubar=no,toolbar=no,resizable=yes,scrollbars=yes,height=600,width=600');return false;"><i class="fa fa-google-plus"></i>&nbsp;Share on Google</a></li>
                                        <li><a class="twitter-share-button" href="https://twitter.com/intent/tweet?text=myownblog125.blogspot.com"><i class="fa fa-twitter" aria-hidden="true"></i>&nbsp;&nbsp;Share on Twitter</a></li>
                                    </ul>
                                </div>
                                <h4 class="media-heading" id="Name"><%=data.FullName%></h4>
                                <h6 id="contact">Contact# <%= data.ContactNumber%> </h6>
                                <h6>Reference# <%= data.ReferenceNumber%></h6>
                                <h6>Category: Missing People</h6>
                                <h6 id="date">Missing Date: <%= data.MissingDate%></h6>
                                <p id="description"><%= data.Description.Substring(0, 50)%> &nbsp;<a href="missing-post?Missing_People_Id=<%=data.PeopleID%>">See More...</a></p>
                            </div>
                            <!-- End of Body -->
                            <div class="col-lg-12 all-comments">
                                <!-- All Comments -->
                                <div class="pull-right">
                                    <a href="missing-post?Missing_People_Id=<%=data.PeopleID%>" class="view-all">Add Comment</a>
                                </div>
                            </div>
                            <!-- End of All Comments -->
                        </div>
                        <!-- End of Media -->
                    </div>
                    <!-- End of Post -->
                    <%    } %>

                    <% }
                        if (Things_Post_display.Count > 0)
                        {
                            foreach (var data in Things_Post_display)
                            { %>
                    <div class="post">
                        <!-- Post 2 -->
                        <div class="media">
                            <!-- Start of Media -->
                            <div class="media-left">
                                <!-- tart of Media-left -->
                                <a href="missing-post?Missing_Thing_Id=<%= data.ThingID%>">
                                    <img class="media-object img-thumbnail" src="<%= data.Image%>" alt="..." width="150">
                                </a>
                            </div>
                            <div class="media-body">
                                <!-- tart of Media-body -->
                                <div class="dropdown pull-right">
                                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-option-horizontal"></span></a>
                                    <ul class="dropdown-menu">
                                        <li><a href="report-sighting"><i class="fa fa-pencil" aria-hidden="true"></i>&nbsp;&nbsp;Report a Sighting</a></li>
                                        <li><a href="missing-post?Missing_Thing_Id=<%= data.ThingID%>"><i class="fa fa-eye" aria-hidden="true"></i>&nbsp;&nbsp;See Full Post</a></li>
                                        <li><a href="index?Favourite_Missing_Thing_ID=<%= data.ThingID %>"><i class="fa fa-heart-o" aria-hidden="true"></i>&nbsp;&nbsp;Favourite</a></li>
                                        <li><a href="index?Print=<%= data.ThingID %>"><i class="fa fa-print"></i>&nbsp;&nbsp;Print</a></li>
                                        <li class="divider"></li>
                                        <div class="text-center">
                                        <li class="center-block"><div class="fb-share-button" data-href="https://www.missingpeopleandthings.com" data-layout="button" data-size="small" data-mobile-iframe="true"><a target="_blank" href="https://www.facebook.com/sharer/sharer.php?u=<%= data.ThingID %>" class="fb-xfbml-parse-ignore">Share</a></div></li>
                                        </div>
                                        <li><a href="https://plus.google.com/share?url=myownblog125.blogspot.com" onclick="javascript:window.open(this.href,'', 'menubar=no,toolbar=no,resizable=yes,scrollbars=yes,height=600,width=600');return false;"><i class="fa fa-google-plus"></i>&nbsp;Share on Google</a></li>
                                        <li><a class="twitter-share-button" href="https://twitter.com/intent/tweet?text=myownblog125.blogspot.com"><i class="fa fa-twitter" aria-hidden="true"></i>&nbsp;&nbsp;Share on Twitter</a></li>
                                    </ul>
                                </div>
                                <h4 class="media-heading"><%= data.OwnerName%></h4>
                                <h6>Contact# <%= data.ContactNumber%></h6>
                                <h6>Reference# <%= data.ReferenceNumber%></h6>
                                <h6>Category: Missing Thing</h6>
                                <h6>Missing Date: <%= data.MissingDate%></h6>
                                <p><%= data.Description.Substring(0, 50)%> &nbsp;<a href="missing-post?Missing_Thing_Id=<%= data.ThingID%>">See More...</a></p>
                            </div>
                            <div class="col-lg-12 all-comments">
                                <!-- All Comments -->
                                <div class="pull-right">
                                    <a href="missing-post?Missing_Thing_Id=<%= data.ThingID%>" class="view-all">Add Comment</a>
                                </div>
                            </div>
                            <!-- End of All Comments -->
                        </div>
                        <!-- End of Media -->
                    </div>
                    <!-- End of Post -->
                    <% } %>

                    <%}
                        if (Unidentified_Post_display.Count > 0)
                        {
                            foreach (var data in Unidentified_Post_display)
                            { %>
                    <div class="post">
                        <!-- Post 3 -->
                        <div class="media">
                            <!-- Start of Media -->
                            <div class="media-left">
                                <!-- tart of Media-left -->
                                <a href="missing-post?Unidentified_People_Id=<%= data.UnindentifiedID%>">
                                    <img class="media-object img-thumbnail" src="<%= data.Image%>" alt="..." width="150">
                                </a>
                            </div>
                            <div class="media-body">
                                <!-- tart of Media-body -->
                                <div class="dropdown pull-right">
                                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-option-horizontal"></span></a>
                                    <ul class="dropdown-menu">
                                        <li><a href="report-sighting"><i class="fa fa-pencil" aria-hidden="true"></i>&nbsp;&nbsp;Report a Sighting</a></li>
                                        <li><a href="missing-post?Unidentified_People_Id=<%= data.UnindentifiedID%>"><i class="fa fa-eye" aria-hidden="true"></i>&nbsp;&nbsp;See Full Post</a></li>
                                        <li><a href="index?Favourite_Unidentified_People_ID=<%= data.UnindentifiedID %>"><i class="fa fa-heart-o" aria-hidden="true"></i>&nbsp;&nbsp;Favourite</a></li>
                                        <li><a href="index?Print=<%= data.UnindentifiedID %>"><i class="fa fa-print"></i>&nbsp;&nbsp;Print</a></li>
                                        <li class="divider"></li>
                                        <div class="text-center">
                                        <li class="center-block"><div class="fb-share-button" data-href="https://www.missingpeopleandthings.com" data-layout="button" data-size="small" data-mobile-iframe="true"><a target="_blank" href="https://www.facebook.com/sharer/sharer.php?u=<%= data.UnindentifiedID %>" class="fb-xfbml-parse-ignore">Share</a></div></li>
                                        </div>
                                        <li><a href="https://plus.google.com/share?url=myownblog125.blogspot.com" onclick="javascript:window.open(this.href,'', 'menubar=no,toolbar=no,resizable=yes,scrollbars=yes,height=600,width=600');return false;"><i class="fa fa-google-plus"></i>&nbsp;Share on Google</a></li>
                                        <li><a class="twitter-share-button" href="https://twitter.com/intent/tweet?text=myownblog125.blogspot.com"><i class="fa fa-twitter" aria-hidden="true"></i>&nbsp;&nbsp;Share on Twitter</a></li>
                                    </ul>
                                </div>
                                <h4 class="media-heading"><%= data.FullName%></h4>
                                <h6>Contact# <%= data.ContactNumber%></h6>
                                <h6>Reference# <%= data.ReferenceNumber%></h6>
                                <h6>Category: Unidntified People</h6>
                                <h6>Found Place: <%= data.FoundPlace%></h6>
                                <p><%= data.Description.Substring(0, 50)%> &nbsp;<a href="missing-post?Unidentified_People_Id=<%= data.UnindentifiedID%>">See More...</a></p>
                            </div>
                            <div class="col-lg-12 all-comments">
                                <!-- All Comments -->
                                <div class="pull-right">
                                    <a href="missing-post?Unidentified_People_Id=<%= data.UnindentifiedID%>" class="view-all">Add Comment</a>
                                </div>
                            </div>
                            <!-- End of All Comments -->
                        </div>
                        <!-- End of Media -->
                    </div>
                    <!-- End of Post -->
                    <% } %>
                    <% }
                        }
                        else
                            Response.Write("<h3 class='text-center' visible='false'>Sorry No Post is Available.</h3>");%>
                    <br />
                    <br />
                    <center>
                        <% if (Post_display.Count == 4 && Things_Post_display.Count == 3 && Unidentified_Post_display.Count == 3)
                            {%>			
						<a href="all-posts">View All Post</a>
					    <% }%>
                    </center>
                </div>
                <!-- End of 1st Coloumn -->


                <div class="col-xs-12 col-sm-4 col-md-4 col-lg-4 column2">
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


                    <div class="panel panel-default">
                        <!-- Start of Panel for Recent Post -->
                        <div class="panel-heading">
                            <!-- Start of Panel-Heading -->
                            Recent Post
                        </div>
                        <!-- End of Panel-Heading -->
                        <div class="panel-body">
                            <% if (DisplayRecentPostOfMissingPeople.Count >= 1 || DisplayRecentPostOfMissingThing.Count >= 1 || DisplayRecentPostOfUnidentifiedPeople.Count >= 1)
                                { %>
                            <% if (DisplayRecentPostOfMissingPeople.Count > 0)
                                {
                                    foreach (var data in DisplayRecentPostOfMissingPeople)
                                    {%>
                            <!-- Recents Posts  -->
                            <a href="missing-post?Missing_People_Id=<%=data.PeopleID%>">
                                <div class="col-xs-3 col-sm-12 col-md-4 col-lg-3">
                                    <img src="<%= data.Image %>" alt="" width="60" />
                                </div>
                                <div class="col-xs-9 col-sm-12 col-md-8 col-lg-9">
                                    <h4><%= data.FullName %></h4>
                                    <h5>Contact# <%= data.ContactNumber %></h5>
                                    <p>Hide From <%= data.MissingPlace %>.</p>
                                </div>
                                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                                    <p class="text"><%= data.Description.Substring(0,50) + "..."  %></p>
                                    <hr />
                                </div>
                                <!-- End of Post 1-->
                            </a>
                            <%  }
                                }
                                if (DisplayRecentPostOfMissingThing.Count > 0)
                                {%>


                            <%foreach (var data in DisplayRecentPostOfMissingThing)
                                {%>
                            <a href="missing-post?Missing_Thing_Id=<%= data.ThingID %>">
                                <div class="col-xs-3 col-sm-12 col-md-4 col-lg-3">
                                    <img src="<%= data.Image %>" alt="" width="60" />
                                </div>
                                <div class="col-xs-9 col-sm-12 col-md-8 col-lg-9">
                                    <h4><%= data.OwnerName %></h4>
                                    <h5>Contact# <%= data.ContactNumber %></h5>
                                    <p>Hide From <%= data.MissingPlace %>.</p>
                                </div>
                                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                                    <p class="text"><%= data.Description.Substring(0,50) %></p>
                                    <hr />
                                </div>
                                <!-- End of Post 1-->
                            </a>
                            <% }
                                }
                                if (DisplayRecentPostOfUnidentifiedPeople.Count > 0)
                                { %>


                            <% foreach (var data in DisplayRecentPostOfUnidentifiedPeople)
                                {%>
                            <a href="missing-post?Unidentified_People_Id=<%= data.UnindentifiedID%>">
                                <div class="col-xs-3 col-sm-12 col-md-4 col-lg-3">
                                    <img src="<%= data.Image %>" alt="" width="60" />
                                </div>
                                <div class="col-xs-9 col-sm-12 col-md-8 col-lg-9">
                                    <h4><%= data.FullName %></h4>
                                    <h5>Contact# <%= data.ContactNumber %></h5>
                                    <p>Found From <%= data.FoundPlace %>.</p>
                                </div>
                                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                                    <p class="text"><%= data.Description.Substring(0,50)  %></p>
                                    <hr />
                                </div>
                                <!-- End of Post 1-->
                            </a>
                            <%}
                                } %>

                            <% }
                                else
                                    Response.Write("<h5 class='text-center' visible='false'>Sorry No Post is Available.</h5>");
                            %>
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


        <section id="Testimonial">
            <!-- Start of Footer Setion -->
            <div class="text-center">
                <a href="#Header">
                    <img src="Image/Hero-Area-Up-Icon.png" alt="" width="55" /></a>
            </div>
            <div class="container">
                <!--satrt of Footer Container -->
                <center class="wow bounceInDown" data-wow-duration="2s" data-wow-delay=".1s">
					<a href="#"><i class="fa fa-facebook" aria-hidden="true"></i></a>
					<a href="#"><i class="fa fa-instagram" aria-hidden="true"></i></a>
					<a href="#"><i class="fa fa-twitter" aria-hidden="true"></i></a>
					<a href="#"><i class="fa fa-envelope" aria-hidden="true"></i></a>
					<a href="#"><i class="fa fa-phone" aria-hidden="true"></i></a>
					<hr/>
				</center>

                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6 column-1">
                    <!-- Start of 1st Coloumn -->
                    <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6 text-left wow bounceInRight" data-wow-duration="2s" data-wow-delay="1s">
                        <h4><b class="color">O</b>ther <b>L</b>inks</h4>
                        <a href="about">&nbsp;&nbsp;&nbsp;&nbsp; > Who we are ?</a><br />
                        <a href="feedback">&nbsp;&nbsp;&nbsp;&nbsp; > Feedback</a><br />
                        <a href="frequently-asked-questions">&nbsp;&nbsp;&nbsp;&nbsp; > FAQs</a>
                    </div>
                    <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6 wow bounceInRight" data-wow-duration="2s" data-wow-delay="1.3s">
                        <h4 class="mission"><b class="color">O</b>ur <b>M</b>ission</h4>
                        <p><span>L</span>orem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum is simply dummy text of the printing and typesetting industry.</p>
                    </div>
                </div>
                <!--End of 1t Coloumn -->

                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6 wow bounceInRight" data-wow-duration="2s" data-wow-delay="1.6s">
                    <!--Satrt of 2nd Coloumn-->
                    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d26459.325865981926!2d71.99277292249305!3d34.00753815953874!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x38ded252117f0d67%3A0x416b6f690ea12711!2sNowshera+Cantonment%2C+Nowshera%2C+Pakistan!5e0!3m2!1sen!2s!4v1509875353165" width="100%" height="300" frameborder="" style="border-radius: 2px; margin-bottom: 30px;" allowfullscreen></iframe>
                </div>

                <hr>
                <!-- End of 2nd Coloumn -->
            </div>
            <!--end of Footer Container -->

            <div class="footer">
                <div class="container wow bounceInDown" data-wow-duration="2s" data-wow-delay="1.6s">
                    <!-- Start of Bottom  Container -->
                    <div class="col-xs-12 col-sm-12 col-md-2 col-lg-4">
                        <h5>&copy;2017-<%= DateTime.Today.Year %> All Rights Reserved.</h5>
                    </div>
                    <div class="col-xs-12 col-sm-12 col-md-10 col-lg-8 text-right">
                        <a href="index">Home</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
						<a href="missing-people-report">Missing People</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
						<a href="missing-thing-report">Missing Things</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
						<a href="unidentified-people-report">Unidentified People</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
						<a href="feedback">Feedback</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
						<a href="frequently-asked-questions">FAQs</a>&nbsp;&nbsp;&nbsp;
                    </div>
                </div>
                <!-- End of Container-->
            </div>
            <!-- End of Footer-->
        </section>
        <!-- End of Section -->
    </form>
    <!--Start of Tawk.to Script-->
    <script type="text/javascript">
        var Tawk_API = Tawk_API || {}, Tawk_LoadStart = new Date();
        (function () {
            var s1 = document.createElement("script"), s0 = document.getElementsByTagName("script")[0];
            s1.async = true;
            s1.src = 'https://embed.tawk.to/5b6fe9bbf31d0f771d83b5fa/default';
            s1.charset = 'UTF-8';
            s1.setAttribute('crossorigin', '*');
            s0.parentNode.insertBefore(s1, s0);
        })();
    </script>
    <!--End of Tawk.to Script-->
</body>
</html>
