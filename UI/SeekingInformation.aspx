<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeekingInformation.aspx.cs" Inherits="UI.SeekingInformation" %>

<%@ Register Src="~/User Control Files/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/User Control Files/Navigation.ascx" TagPrefix="uc1" TagName="Navigation" %>
<%@ Register Src="~/User Control Files/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Seeking Information - Missing People and Things</title>
    <meta name="description"  content="In this form people can search out for those people they are looking for either by simple search or filter."/>
    <meta name="keywords" content="missing people, missing thing, unidentified people, seeking information, search, missing people in pakistan"/>
    <meta name="author" content="Umar Anwar" />
    <uc1:Header runat="server" ID="Header1" />
</head>
<body>
    <form id="form1" runat="server">
        <section id="header">
            <!-- Starting of Header Area -->
            <uc1:Navigation runat="server" ID="Navigation" />
            <div class="container top">
                <h1 class="text-center information"><b>S</b>eeking <b>I</b>nformatin</h1>
                <hr>
                <div class="col-xs-12 col-sm-3 col-md-3 col-lg-3"></div>
                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                    <center>
					<div class="form-group">
						<div class="form-inline">
							<input type="text" class="form-control" runat="server" id="top_search" placeholder="Search by Name"/>
							<asp:Button ID="RegularSearch" runat="server" Text="Search" OnClick="RegularSearch_Click"></asp:Button>
						</div>
					</div>
				</center>
                </div>
                <div class="col-xs-12 col-sm-3 col-md-3 col-lg-3"></div>
            </div>
        </section>
        <!-- End of Header Area Section-->


        <section id="form-submit">
            <!-- Start of Form Submit Section -->
            <div class="container">
                <!-- Start of Section Container -->
                <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8">
                    <!-- Start of 1st Column-->
                    <div class="search-bg">
                        <h4 class="text-center">Filter for Searching</h4>
                        <div class="form-group">
                            <div class="form-inline">
                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                    <input type="text" class="form-control" runat="server" id="Name" placeholder="Full Name" />
                                    <input type="text" class="form-control" runat="server" id="GuardianName" placeholder="Father/Guardian Name" />
                                </div>
                                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                                    <input type="text" class="form-control" runat="server" id="Contact" placeholder="Contact Number" />
                                    <asp:DropDownList ID="CategoryName" runat="server" CssClass="form-control">
                                        <asp:ListItem disabled="true" Selected="True">Select Category</asp:ListItem>
                                        <asp:ListItem>Missing Person</asp:ListItem>
                                        <asp:ListItem>Missing Thing</asp:ListItem>
                                        <asp:ListItem>Unidentified Person</asp:ListItem>
                                    </asp:DropDownList>

                                </div>
                                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12 error">
                                    <h5 runat="server" id="ErrorEmpty"></h5>
                                    <h5 runat="server" id="ErrorCategory" visible="false" style="color: red; margin-top: 0px; margin-bottom: 0px">*Please Select Category.</h5>
                                </div>
                            </div>
                        </div>
                        <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                            <asp:Button ID="SearchButton" runat="server" Text="Search" CssClass="btn btn-default center-block" OnClick="SearchButton_Click" TabIndex="4" />
                        </div>
                    </div>

                    <!-- Search Results -->
                    <div class="SearchResult">
                        <div class="row">

                            <% if (SearchDataForMissingPeople != null)
                                {
                                    if (SearchDataForMissingPeople.Count > 0)
                                    {%>
                            <h3 class="info">Search Result Found:</h3>
                            <% foreach (var data in SearchDataForMissingPeople)
                                { %>
                            <div class="col-xs-8 col-sm-6 col-md-4 col-lg-4">
                                <div class="thumbnail imageBox">
                                    <a href="missing-post?Missing_People_Id=<%=data.PeopleID%>">
                                        <img src="<%= data.Image%>" alt="..."/>
                                        <h5 class="name">Gander: <%= data.Gander%></h5>
                                        <h5 class="reference">Reference# <%= data.ReferenceNumber%></h5>
                                        <h5 class="contact">Contact# <%= data.ContactNumber%></h5>
                                        <div class="caption">
                                            <h4 class="text-center"><%= data.FullName.ToUpper() %></h4>
                                            <hr style="margin-top: 0px; width: 30%" />
                                            <h6>Category: Missing People</h6>
                                            <h6>Missing Place: <%=  data.MissingPlace%></h6>
                                            <h6>Missing Date: <%= data.MissingDate %></h6>
                                            <h6>Religion: <%= data.Religion%></h6>
                                            <h6>Age: <%= data.Age %></h6>
                                        </div>
                                    </a>
                                </div>
                            </div>
                            <%}
                                    }
                                    else
                                    { Response.Write("<h3 class='text-center' style='margin-top: 0px;'>Your search did not match any post.</h3>"); }
                                }
                                else { }
                                if (SearchDataForMissingThing != null)
                                {
                                    if (SearchDataForMissingThing.Count > 0)
                                    {%>
                            <h3 style="margin-left: 15px; margin-top: 0px; margin-bottom: 20px;">Search Result Found:</h3>
                            <% foreach (var data in SearchDataForMissingThing)
                                { %>
                            <div class="col-xs-8 col-sm-6 col-md-4 col-lg-4">
                                <div class="thumbnail imageBox">
                                    <a href="missing-post?Missing_Thing_Id=<%= data.ThingID%>">
                                        <img src="<%= data.Image%>" alt="..." />
                                        <h5 class="name">Missing Thing: <%= data.ThingName%></h5>
                                        <h5 class="reference">Reference# <%= data.ReferenceNumber%></h5>
                                        <h5 class="contact">Contact# <%= data.ContactNumber%></h5>
                                        <div class="caption">
                                            <h4 class="text-center"><%= data.OwnerName.ToUpper() %></h4>
                                            <hr style="margin-top: 0px; width: 30%" />
                                            <h6>Category: Missing Thing</h6>
                                            <h6>Missing Place: <%=  data.MissingPlace%></h6>
                                            <h6>Missing Date: <%= data.MissingDate %></h6>
                                            <h6>Address: <%= data.CurrentAddress%></h6>
                                        </div>
                                    </a>
                                </div>
                            </div>
                            <%}
                                    }
                                    else
                                    { Response.Write("<h3 class='text-center' style='margin-top: 0px;'>Your search did not match any post.</h3>"); }
                                }
                                else { }
                                if (SearchDataForUnidentifiedPeople != null)
                                {
                                    if (SearchDataForUnidentifiedPeople.Count > 0)
                                    {%>
                            <h3 style="margin-left: 15px; margin-top: 0px; margin-bottom: 20px;">Search Result Found:</h3>
                            <% foreach (var data in SearchDataForUnidentifiedPeople)
                                { %>
                            <div class="col-xs-8 col-sm-6 col-md-4 col-lg-4">
                                <div class="thumbnail imageBox">
                                    <a href="missing-post?Unidentified_People_Id=<%= data.UnindentifiedID%>">
                                        <img src="<%= data.Image%>" alt="..." />
                                        <h5 class="name">Gander: <%= data.Gander%></h5>
                                        <h5 class="reference">Reference# <%= data.ReferenceNumber%></h5>
                                        <h5 class="contact">Contact# <%= data.ContactNumber%></h5>
                                        <div class="caption">
                                            <h4 class="text-center"><%= data.FullName.ToUpper() %></h4>
                                            <hr style="margin-top: 0px; width: 30%" />
                                            <h6>Category: Unidentified People</h6>
                                            <h6>Found Place: <%=  data.FoundPlace%></h6>
                                            <h6>Language: <%= data.Language %></h6>
                                            <h6>Cloth Color: <%= data.ClothColor%></h6>
                                            <h6>Age: <%= data.Age %></h6>
                                        </div>
                                    </a>
                                </div>
                            </div>
                            <%}
                                    }
                                    else
                                    { Response.Write("<h3 class='text-center errorSearch' style='margin-top: 0px;'>Your search did not match any post.</h3>"); }
                                }
                                else { }%>



                            <% if (SearchPeopleDataInRegularSearchBar != null)
                                {
                                    if (SearchPeopleDataInRegularSearchBar.Count > 0)
                                    {%>
                            <% foreach (var data in SearchPeopleDataInRegularSearchBar)
                                { %>
                            <div class="col-xs-8 col-sm-6 col-md-4 col-lg-4">
                                <div class="thumbnail imageBox">
                                    <a href="missing-post?Missing_People_Id=<%=data.PeopleID%>">
                                        <img src="<%= data.Image%>" alt="..."/>
                                        <h5 class="name">Gander: <%= data.Gander%></h5>
                                        <h5 class="reference">Reference# <%= data.ReferenceNumber%></h5>
                                        <h5 class="contact">Contact# <%= data.ContactNumber%></h5>
                                        <div class="caption">
                                            <h4 class="text-center"><%= data.FullName.ToUpper() %></h4>
                                            <hr style="margin-top: 0px; width: 30%" />
                                            <h6>Category: Missing People</h6>
                                            <h6>Missing Place: <%=  data.MissingPlace%></h6>
                                            <h6>Missing Date: <%= data.MissingDate %></h6>
                                            <h6>Religion: <%= data.Religion%></h6>
                                            <h6>Age: <%= data.Age %></h6>
                                        </div>
                                    </a>
                                </div>
                            </div>
                            <%}
                                    }
                                 }
                                else { }
                                if (SearchThingDataInRegularSearchBar != null)
                                {
                                    if (SearchThingDataInRegularSearchBar.Count > 0)
                                    {%>
                            <% foreach (var data in SearchThingDataInRegularSearchBar)
                                { %>
                            <div class="col-xs-8 col-sm-6 col-md-4 col-lg-4">
                                <div class="thumbnail imageBox">
                                    <a href="missing-post?Missing_Thing_Id=<%= data.ThingID%>">
                                        <img src="<%= data.Image%>" alt="..." />
                                        <h5 class="name">Missing Thing: <%= data.ThingName%></h5>
                                        <h5 class="reference">Reference# <%= data.ReferenceNumber%></h5>
                                        <h5 class="contact">Contact# <%= data.ContactNumber%></h5>
                                        <div class="caption">
                                            <h4 class="text-center"><%= data.OwnerName.ToUpper() %></h4>
                                            <hr style="margin-top: 0px; width: 30%" />
                                            <h6>Category: Missing Thing</h6>
                                            <h6>Missing Place: <%=  data.MissingPlace%></h6>
                                            <h6>Missing Date: <%= data.MissingDate %></h6>
                                            <h6>Address: <%= data.CurrentAddress%></h6>
                                        </div>
                                    </a>
                                </div>
                            </div>
                            <%}
                                    }
                                }
                                else { }
                                if (SearchUnidentifiedDataInRegularSearchBar != null)
                                {
                                    if (SearchUnidentifiedDataInRegularSearchBar.Count > 0)
                                    {%>
                            <% foreach (var data in SearchUnidentifiedDataInRegularSearchBar)
                                { %>
                            <div class="col-xs-8 col-sm-6 col-md-4 col-lg-4">
                                <div class="thumbnail imageBox">
                                    <a href="missing-post?Unidentified_People_Id=<%= data.UnindentifiedID%>">
                                        <img src="<%= data.Image%>" alt="..." />
                                        <h5 class="name">Gander: <%= data.Gander%></h5>
                                        <h5 class="reference">Reference# <%= data.ReferenceNumber%></h5>
                                        <h5 class="contact">Contact# <%= data.ContactNumber%></h5>
                                        <div class="caption">
                                            <h4 class="text-center"><%= data.FullName.ToUpper() %></h4>
                                            <hr style="margin-top: 0px; width: 30%" />
                                            <h6>Category: Unidentified People</h6>
                                            <h6>Found Place: <%=  data.FoundPlace%></h6>
                                            <h6>Language: <%= data.Language %></h6>
                                            <h6>Cloth Color: <%= data.ClothColor%></h6>
                                            <h6>Age: <%= data.Age %></h6>
                                        </div>
                                    </a>
                                </div>
                            </div>
                            <%}
                                    }
                                 }
                                else { }%>
                        </div>
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                    </div>
                </div>
                <!-- End of 1st Column Class-->


                <div class="col-xs-12 col-sm-4 col-md-4 col-lg-4 seek" id="discussion-forum">
                    <!-- Start of 2nd Coloumn -->
                    <div class="column2 report">
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
            </div>
            <!-- End of Section Container-->
        </section>
        <!-- End of Section -->

        <div id="Testimonial">
            <div class="footer">
                <div class="text-center">
                    <a href="#header">
                        <img src="Image/Hero-Area-Up-Icon.png" alt="" width="55"></a>
                </div>
                <uc1:Footer runat="server" ID="Footer" />
            </div>
        </div>
        <!-- End of Footer-->
    </form>
</body>
</html>
