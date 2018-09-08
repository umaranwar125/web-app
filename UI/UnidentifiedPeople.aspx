<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnidentifiedPeople.aspx.cs" Inherits="UI.UnidentifiedPeople" %>

<%@ Register Src="~/User Control Files/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/User Control Files/Navigation.ascx" TagPrefix="uc1" TagName="Navigation" %>
<%@ Register Src="~/User Control Files/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Unidentified People Report - Missing People and Things</title>
    <meta name="description"  content="In this form people can submit a report for those people who do know him/her home address, or by mistake they are missed from their homes, or he/she is mentally disturb, and want to go home."/>
    <meta name="keywords" content="missing people, missing thing, unidentified people, submit form, missing people in pakistan"/>
    <meta name="author" content="Umar Anwar" />
    <uc1:Header runat="server" ID="Header1" />
</head>
<body>
    <form id="form1" runat="server">
        <section id="header">
            <!-- Starting of Header Area -->
            <uc1:Navigation runat="server" ID="Navigation" />
            <div class="container top">
                <h1 class="text-center"><b>U</b>nidentified <b>P</b>eople</h1>
                <hr>
                <p>If you are worried about finding your loved ones and your stolen objects, don't go anywhere we are here to help you. We are with you in your sorrow. Just add a post and keep visiting our website so that you can find your missing relatives or objects quickly.</p>
            </div>
        </section>
        <!-- End of Header Area Section-->


        <section>
            <!-- Start of Form Submit Section -->
            <div class="container">
                <!-- Start of Section Container -->
                <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8">
                    <!-- Start of 1st Column-->
                    <div class="translator text-right">
                        <div id="google_translate_element"></div>
                        <script type="text/javascript">
                            function googleTranslateElementInit() {
                                new google.translate.TranslateElement({ pageLanguage: 'en', includedLanguages: 'en,hi,pa,ps,ur,zh-CN', layout: google.translate.TranslateElement.InlineLayout.SIMPLE }, 'google_translate_element');
                            }
                        </script>
                        <script type="text/javascript" src="//translate.google.com/translate_a/element.js?cb=googleTranslateElementInit"></script>
                    </div>
                    <div class="Missing">
                        <div class="bg">
                            <h2 class="fs-title">Unidentified Person Information</h2>
                            <div class="alert alert-warning" runat="server" id="Note"><strong>Note:</strong> Make sure you have created your account, if not then please <a href="register">click here</a> to make your account.</div>
                            <div class="alert alert-danger" runat="server" id="ErrorImage" visible="false"><strong><span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>&nbsp;</strong> Image is required.</div>
                            <div class="alert alert-success" runat="server" id="ReportSuccessfull" visible="false"><strong><span class="glyphicon glyphicon-thumbs-up"></span>&nbsp;</strong> Your report is successfully submit, You will get inform soon once your submitted report is approved by the admin. </div>
                            <label for="" class="first">Full Name*</label>
                            <input type="text" runat="server" title="Provide full name of that unknown person" placeholder="Enter full name" id="UnidentifiedName" />
                            <label for="">Father/Guardian Name (Optional)</label>
                            <input type="text" runat="server" title="Provide Father or Guardian name of that unknown person (if he/she knows)" placeholder="Enter father/guardian name" id="UnidentifiedGuardianName" />
                            <label for="">Mobile Number*</label>
                            <input type="text" runat="server" title="Provide Mobile Number of yourself so people can contact with you." placeholder="Enter mobile number" id="UnidentifiedContact" />
                            <label for="">Religion*</label>
                            <input type="text" runat="server" title="Provide Religion of that unknown person." placeholder="Enter religion" id="UnidentifiedReligion" />
                            <label for="">Age (Optional)</label>
                            <input type="text" runat="server" title="Provide Age of that unknown person." placeholder="Enter age" id="UnidentifiedAge" />
                            <label for="">Unique Identification (Optional)</label>
                            <input type="text" runat="server" title="Provide Unique identification of that unknown person (if available)" placeholder="Enter unique identification" id="UnidentifiedUnique" />
                            <label for="">Found Place*</label>
                            <input type="text" runat="server" title="From which place you have found that unknown person?" placeholder="Enter found place" id="UnidentifiedFound" />
                            <label for="">Language*</label>
                            <input type="text" runat="server" title="Provide Language of that unknown person." placeholder="Enter language" id="UnidentifiedLanguage" />
                            <label for="">Cloth*</label>
                            <input type="text" runat="server" title="Which color and which type of cloth is wear by that unknown person." placeholder="Enter cloth colour" id="UnidentifiedCloth" />
                            <label for="">Eyes (Optional)</label>
                            <input type="text" runat="server" title="Provide Eye color of that unknown person." placeholder="Enter eyes colour" id="UnidentifiedEyes" />
                            <label for="">Description*</label>
                            <textarea rows="20" runat="server" title="Provide Each and Every information about that unknown person." placeholder="Minimun 60 characters are required." id="UnidentifiedDescription"></textarea>
                            <div class="text-left gender">
                                <label for="">Gender*</label>
                                <input type="radio" name="gender" id="UnidetifiedMale" runat="server" value="Male" checked="" />Male&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
								<input type="radio" name="gender" id="UnidetifiedFemale" runat="server" value="Female" />Female
                            </div>
                            <div class="text-left image">
                                <label for="" class="Image">Image*</label><asp:FileUpload ID="UnidentifiedImage" runat="server" />
                            </div>
                            <h5 class="fs-subtitle ErrorMsg"></h5>
                            <h5 class="fs-subtitle ErrorCNIC"></h5>
                            <asp:Button ID="UnidentidiedButton" runat="server" CssClass="btn submit center-block" Text="Submit" OnClick="UnidentidiedButton_Click" />
                            <br />
                        </div>
                    </div>
                </div>
                <!-- End of 1st Column Class-->


                <div class="col-xs-12 col-sm-4 col-md-4 col-lg-4" id="discussion-forum">
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
            <!-- End of Footer-->
        </div>
    </form>
</body>
</html>
