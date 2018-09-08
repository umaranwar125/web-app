<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAllPosts.aspx.cs" Inherits="UI.ViewAllPosts" %>

<%@ Register Src="~/User Control Files/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/User Control Files/Navigation.ascx" TagPrefix="uc1" TagName="Navigation" %>
<%@ Register Src="~/User Control Files/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>All Posts - Missing People and Things</title>
    <meta name="keywords" content="missing people, missing thing, unidentified people, all posts, missing people in pakistan"/>
    <meta name="author" content="Umar Anwar" />
    <uc1:Header runat="server" ID="Header" />
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
        <section id="top-nav">
            <uc1:Navigation runat="server" ID="Navigation" />
        </section>

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
                                        <li><a href="index?Print=<%= data.PeopleID %>"><i class="fa fa-print"></i>&nbsp;&nbsp;Print</a></li>
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
                                <p id="description"><%= data.Description.Substring(0, 60)%> &nbsp;<a href="missing-post?Missing_People_Id=<%=data.PeopleID%>">See More...</a></p>
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
                            <!-- End of Bosy -->
                            <div class="col-lg-12 all-comments">
                                <!-- All Comments -->
                                <div class="pull-right">
                                    <a href="missing-post?Missing_Thing_Id=<%= data.ThingID %>" class="view-all">Add Comment</a>
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
                                <a href="FullPost.aspx?Unidentified_People_Id=<%= data.UnindentifiedID%>">
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
                            <!-- End of Bosy -->
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
                                    <p class="text"><%= data.Description.Substring(0,60) + "..."  %></p>
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
