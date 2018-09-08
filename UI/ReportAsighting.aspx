<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportAsighting.aspx.cs" Inherits="UI.ReportAsighting" %>

<%@ Register Src="~/User Control Files/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/User Control Files/Navigation.ascx" TagPrefix="uc1" TagName="Navigation" %>
<%@ Register Src="~/User Control Files/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Report a Sighting - Missing People and Things</title>
    <meta name="description"  content="In this web page you can submit a report if you have seen that person either on website before or in real life, you can inform website owner by submitting a report."/>
    <meta name="keywords" content="missing people, missing thing, unidentified people, report sighting, missing people in pakistan"/>
    <meta name="author" content="Umar Anwar" />
    <uc1:Header runat="server" ID="Header1" />
</head>
<body>
    <form id="form1" runat="server">
        <section id="header">
            <!-- Starting of Header Area -->
            <uc1:Navigation runat="server" ID="Navigation" />
            <div class="container top">
                <h1 class="text-center"><b>R</b>eport <b>S</b>ighting</h1>
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

                            <h2 class="fs-title">Report Sighting Information</h2>
                            <div class="alert alert-warning" runat="server" id="Note" visible="true"><strong>Note:</strong> Make sure you have created your account, if not then please <a href="CreateAccount.aspx">click here</a> to make your account.</div>
                            <div class="alert alert-danger" runat="server" id="ErrorCCTV" visible="false"><strong><span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>&nbsp;</strong> Is there any CCTV at the location?</div>
                            <div class="alert alert-danger" runat="server" id="ErrorPublicity" visible="false"><strong><span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>&nbsp;</strong> What Publicity did you see?</div>
                            <div class="alert alert-danger" runat="server" id="ErrorReference" visible="false"><strong><span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>&nbsp;</strong> Reference Number is not correct.</div>
                            <div class="alert alert-danger" runat="server" id="ErrorDate" visible="false"><strong><span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>&nbsp;</strong> What date did you see the missing person?</div>
                            <div class="alert alert-success" runat="server" id="ReportSuccessfull" visible="false"><strong><span class="glyphicon glyphicon-thumbs-up"></span>&nbsp;</strong> Your Sighting report is successfully submit. We really appreciate your love, support and cooperation with other people. </div>
                            <h4 style="margin-bottom: -10px; font-weight: bold; color: #fa5c65; margin-top: 30px;" class="text-center">About Missing Object</h4>
                            <hr style="border: 0.5px solid #fa5c65; width: 100px; margin-bottom: 25px;">


                            <div class="text-left">
                                <div class="form-group">
                                    <div class="form-inline">
                                        <label for="" class="MissingDate">What you have Found? (*)</label>
                                        <asp:DropDownList ID="ReportFoundThing" title="For which object you are going to report?" runat="server" CssClass="form-control calender" AutoPostBack="True">
                                            <asp:ListItem disabled="true" Selected="True">Please Select</asp:ListItem>
                                            <asp:ListItem>Person</asp:ListItem>
                                            <asp:ListItem>Auto Mobile</asp:ListItem>
                                            <asp:ListItem>Mobile</asp:ListItem>
                                            <asp:ListItem>CNIC</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div runat="server" visible="false" id="ReportMissingPersonHide">
                                <label for="" style="margin-top: 20px;">Missing Person Name (Optional)</label>
                                <input type="text" runat="server" title="Provide Name of Missing person that you have found." placeholder="Enter Name" id="ReportMissingPerson" />
                            </div>
                            <div runat="server" visible="false" id="ReportCompanyNameHide" style="margin-top: 30px;">
                                <label for="">What was the Compnay Name of that Auto? (Optional)</label>
                                <input type="text" runat="server" title="Provide a Compay Name of Auto Mobile that you have found." placeholder="Enter Company Name" id="ReportCompanyName" />
                            </div>
                            <div runat="server" visible="false" id="ReportBrandNameHide" style="margin-top: 30px;">
                                <label for="">What was the Brand Name? (Optional)</label>
                                <input type="text" runat="server" title="Provide Brand Name of Auto Mobile that you have found." placeholder="Enter Brand Name" id="ReportBrandName" />
                            </div>
                            <div runat="server" visible="false" id="ReportColorHide" style="margin-top: 30px;">
                                <label for="">What was the Color? (*)</label>
                                <input type="text" runat="server" title="Provide Color Name of Auto Mobile that you have found." placeholder="Enter Colour Name" id="ReportColor" />
                            </div>
                            <div runat="server" visible="false" id="ReportCNICNumberHide" style="margin-top: 30px;">
                                <label for="">What was the CNIC Number? (Optional)</label>
                                <input type="text" runat="server" title="Provide CNIC Number that you have found." placeholder="Enter CNIC Number" id="ReportCNICNumber" />
                            </div>
                            <div runat="server" visible="false" id="ReportCNICFamilyHide" style="margin-top: 30px;">
                                <label for="">What was the CNIC Family Number? (Optional)</label>
                                <input type="text" runat="server" title="Provide CNIC Family number that you have found." placeholder="Enter Family Number" id="ReportCNICFamily" />
                            </div>
                            <div class="text-left">
                                <label for="" class="MissingDate" runat="server" style="margin-bottom: -25px;">What date did you see that? (*)</label><br /><br />
                                <div class="form-group seen">
                                    <div class="form-inline">
                                        <select class="form-control calender" title="what date did you see that object?" runat="server" id="ReportDate">
                                            <option value="date" selected="" disabled="">Date</option>
                                            <option value="1">1</option>
                                            <option value="2">2</option>
                                            <option value="3">3</option>
                                            <option value="4">4</option>
                                            <option value="5">5</option>
                                            <option value="6">6</option>
                                            <option value="7">7</option>
                                            <option value="8">8</option>
                                            <option value="9">9</option>
                                            <option value="10">10</option>
                                            <option value="11">11</option>
                                            <option value="12">12</option>
                                            <option value="13">13</option>
                                            <option value="14">14</option>
                                            <option value="15">15</option>
                                            <option value="16">16</option>
                                            <option value="17">17</option>
                                            <option value="18">18</option>
                                            <option value="19">19</option>
                                            <option value="20">20</option>
                                            <option value="21">21</option>
                                            <option value="22">22</option>
                                            <option value="23">23</option>
                                            <option value="24">24</option>
                                            <option value="25">25</option>
                                            <option value="26">26</option>
                                            <option value="27">27</option>
                                            <option value="28">28</option>
                                            <option value="29">29</option>
                                            <option value="30">30</option>
                                            <option value="31">31</option>
                                        </select>
                                        <select class="form-control calender" id="ReportMonth" runat="server">
                                            <option value="month" selected="" disabled="">Month</option>
                                            <option value="Jan">January</option>
                                            <option value="Feb">February</option>
                                            <option value="March">March</option>
                                            <option value="April">April</option>
                                            <option value="May">May</option>
                                            <option value="June">June</option>
                                            <option value="July">July</option>
                                            <option value="August">August</option>
                                            <option value="Sep">September</option>
                                            <option value="Oct">Octuber</option>
                                            <option value="Nov">November</option>
                                            <option value="Dec">December</option>
                                        </select>
                                        <select class="form-control calender" id="ReportYear" runat="server">
                                            <option value="year" selected="" disabled="">Year</option>
                                            <option value="2017">2010</option>
                                            <option value="2017">2011</option>
                                            <option value="2017">2012</option>
                                            <option value="2017">2013</option>
                                            <option value="2017">2014</option>
                                            <option value="2017">2015</option>
                                            <option value="2017">2016</option>
                                            <option value="2017">2017</option>
                                            <option value="2018">2018</option>
                                        </select>
                                    </div>
                                </div>
                            </div>
                            <label for="" style="margin-top: 40px;">Where did you see that? (*)</label>
                            <input type="text" runat="server" title="At which place you have seen that object?" placeholder="Enter Place Name" id="ReportFound" />
                            <div class="text-left">
                                <div class="form-group">
                                    <div class="form-inline">
                                        <label for="" class="MissingDate">Is there any CCTV at the location? (*)</label>
                                        <select class="form-control calender" id="ReportCCTV" runat="server">
                                            <option value="Select" selected="" disabled="">Please Select</option>
                                            <option value="Yes">Yes</option>
                                            <option value="No">No</option>
                                            <option value="Don't Know">Don't Know</option>
                                        </select>
                                    </div>
                                </div>
                            </div>
                            <div runat="server" visible="false" id="ReportClothHide">
                                <label for="" style="margin-top: 30px;">What were they Wearing? (*)</label>
                                <input type="text" runat="server" placeholder="Enter Cloth Name" id="ReportCloth" />
                            </div>
                            <div class="text-left" style="margin-top: 30px;">
                                <div class="form-group">
                                    <div class="form-inline">
                                        <label for="" class="MissingDate">What Publicity did you see? (*)</label>
                                        <asp:DropDownList ID="ReportPublicity" runat="server" CssClass="form-control calender" AutoPostBack="True">
                                            <asp:ListItem disabled="true" Selected="True">Please Select</asp:ListItem>
                                            <asp:ListItem>Newspaper</asp:ListItem>
                                            <asp:ListItem>TV</asp:ListItem>
                                            <asp:ListItem>Wall</asp:ListItem>
                                            <asp:ListItem>Website</asp:ListItem>
                                            <asp:ListItem>Other</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div runat="server" visible="false" id="ReportReferenceHide">
                                <label for="">Enter Reference Number (*)</label>
                                <input type="text" runat="server" title="Provide a Reference Number (Avaiable on that Post)" placeholder="Enter Reference Number" id="ReportReferenceNumber" />
                            </div>
                            <div class="text-left gender" runat="server" visible="false" id="ReportGanderHide" style="margin-top: 20px; margin-bottom: -10px;">
                                <label for="">Gender of Missing Person (*)</label>
                                <input type="radio" name="gender" runat="server" id="ReportMale" value="Male">Male&nbsp;&nbsp;
								<input type="radio" name="gender" runat="server" id="ReportFemale" value="Female">Female
                            </div>
                            <div class="text-left image" style="margin-top: 30px;">
                                <label for="" class="Image">Image (Optional)</label><asp:FileUpload ID="ReportImage" runat="server" />
                            </div>
                            <h4 style="margin-bottom: -10px; font-weight: bold; color: #fa5c65; margin-top: 30px;" class="text-center">About You</h4>
                            <hr style="border: 0.5px solid #fa5c65; width: 50px; margin-bottom: 20px;">
                            <label for="">Your Name (*)</label>
                            <input type="text" runat="server" title="Provide Your Full Name" placeholder="Enter Name" id="ReportYourName" />
                            <label for="">Your Email Address (*)</label>
                            <input type="text" runat="server" title="Provide Your Email address" placeholder="Enter Email Address" id="ReportYourEmail" />
                            <label for="">Mobile Number (*)</label>
                            <input type="text" runat="server" title="Provide Your Mobile Number" placeholder="Enter Mobile Number" id="ReportYourMobile" />
                            <label for="">Your Current Address (Optional)</label>
                            <input type="text" runat="server" title="Provide Your Current Address" placeholder="Enter Current Address" id="ReportYourAddress" />
                            <div class="text-left">
                                <input type="checkbox" name="name" value="Yes" runat="server" id="ReportYes" style="cursor: pointer" /><label for="" class="MissingDate YesLabel" style="margin-top: 10px;">&nbsp;May we contact you to ask such questions?</label>
                            </div>
                            <h5 class="fs-subtitle ErrorMsg"></h5>
                            <h5 class="fs-subtitle ErrorCNIC"></h5>
                            <asp:Button ID="ReportSightingButton" runat="server" CssClass="btn submit center-block" Text="Submit" OnClick="ReportSightingButton_Click" />
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
