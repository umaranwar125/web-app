<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MissingPeopleReport.aspx.cs" Inherits="UI.MissingPeopleReport" %>

<%@ Register Src="~/User Control Files/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/User Control Files/Navigation.ascx" TagPrefix="uc1" TagName="Navigation" %>
<%@ Register Src="~/User Control Files/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Missing People Report - Missing People and Things</title>
    <meta name="description"  content="In this form people can submit a report for those people who are missing from them."/>
    <meta name="keywords" content="missing people, missing thing, unidentified people, missing people report, submit form, missing people in pakistan"/>
    <meta name="author" content="Umar Anwar" />
    <uc1:Header runat="server" ID="Header1" />
</head>
<body>

    <form id="form1" runat="server">
        <section id="header">
            <!-- Starting of Header Area -->
            <uc1:Navigation runat="server" ID="Navigation" />


            <div class="container top">
                <h1 class="text-center"><b>M</b>issing <b>P</b>eople</h1>
                <hr>
                <p>If you are worried about finding your loved ones and your stolen objects, don't go anywhere we are here to help you. We are with you in your sorrow. Just add a post and keep visiting our website so that you can find your missing relatives or objects quickly.</p>
            </div>
        </section>
        <!-- End of Header Area Section-->

        <section>
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
                            <h2 class="fs-title">Missing Person Information</h2>
                            <div class="alert alert-warning" runat="server" id="Note"><strong>Note:</strong> Make sure you have created your account, if not then please <a href="register">click here</a> to make your account.</div>
                            <div class="alert alert-danger" runat="server" id="Error_Image" visible="false"><strong><span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>&nbsp;</strong> Image is required.</div>
                            <div class="alert alert-danger" runat="server" id="ErrorSelect" visible="false"><strong><span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>&nbsp;</strong> Please Select Missing Date. </div>
                            <div class="alert alert-success" runat="server" id="ReportSuccessfull" visible="false"><strong><span class="glyphicon glyphicon-thumbs-up"></span>&nbsp;</strong> Your report is successfully submit, You will get inform soon once your submitted report is approved by the admin. </div>

                            <label class="first">Full Name (*)</label>
                            <input type="text" placeholder="Enter Full Name" title="Provide missing person Name" id="MissingPeopleName" runat="server" />
                            <label>NickName (Optional)</label>
                            <input type="text" placeholder="Enter NickName" title="Provide missing person Nickname (if available)" id="MissingPeopleNickName" runat="server" />
                            <label>CNIC (Optional)</label>
                            <input type="text" placeholder="Enter CNIC" id="MissingPeopleCNIC" title="Provide missing person CNIC (if available)" runat="server" />
                            <label>Father/Guardian Name (*)</label>
                            <input type="text" placeholder="Enter Father/Guardian Name" title="Provide Father or Guardian Name of missing person" id="MissingPeopleGuardianName" runat="server" />
                            <label>Father/Guardian CNIC (*)</label>
                            <input type="text" placeholder="Enter Father/Guardian CNIC" title="Provide Father or Guardian CNIC of missing person " id="MissingPeopleGuardianCNIC" runat="server" />
                            <label>Mobile Number (*)</label>
                            <input type="text" placeholder="Enter Mobile Number" title="Provide Mobile number so people can contact you" id="MissingPeopleNameContact" runat="server" />
                            <div class="text-right">
                                <a class="add-contact">Add Another Number</a>
                            </div>
                            <div style="display: none" class="contact-hide">
                                <label>Another Mobile Number (Optional)</label>
                                <input type="text" placeholder="Enter Another Mobile Number" id="MissingPeopleAnotherContact" runat="server" />
                            </div>
                            <label>Permanent Address (*)</label>
                            <input type="text" placeholder="Enter Permanent Address" title="Provide Permanent address of missing person " id="MissingPeoplePermanent" runat="server" />
                            <label>Current Address (*)</label>
                            <input type="text" placeholder="Enter Current Address" title="Provide Current address of missing person" id="MissingPeopleCurrent" runat="server" />
                            <label>Religion (Optional)</label>
                            <input type="text" placeholder="Enter Religion" title="Provide Religion of missing person " id="MissingPeopleReligion" runat="server" />
                            <label>Age (*)</label>
                            <input type="text" placeholder="Enter Age" title="Provide Age of missing person." id="MissingPeopleAge" runat="server" />
                            <input type="button" class="btn more-info pull-right" runat="server" value="Add More Information" />
                            <div class="hide-input">
                                <label>Missing Place (*)</label>
                                <input type="text" placeholder="Enter Missing Place" title="From which place missing person disappear?" id="MissingPeoplePlace" runat="server" />
                            </div>
                            <div class="form-group hide-input">
                                <div class="form-inline">
                                    <label for="" class="MissingDate" runat="server">Missing Date (*)</label>
                                    <select class="form-control calender" title="At which date missing person disappear?" runat="server" id="Date">
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
                                    <select class="form-control calender" title="At which date missing person disappear?" id="MissingPeopleMonth" runat="server">
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
                                    <select class="form-control calender" title="At which date missing person disappear?" id="MissingPeopleYear" runat="server">
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
                            <div class="hide-input">
                                <label>Tribe (Optional)</label>
                                <input type="text" placeholder="Enter Tribe" title="Provide Tribe of missing person" id="MissingPeopleTribe" runat="server" />
                            </div>
                            <div class="hide-input">
                                <label>Language (*)</label>
                                <input type="text" placeholder="Enter Language" title="Provide Language of missing person" id="MissingPeopleLanguage" runat="server" />
                            </div>
                            <div class="hide-input">
                                <label>Cloth(Optional)</label>
                                <input type="text" placeholder="Enter Cloth (Optional)" title="Which cloth and color missing person wore last time?" id="MissingPeopleClothes" runat="server" />
                            </div>
                            <div class="hide-input">
                                <label>Height (Optional)</label>
                                <input type="text" placeholder="Enter Height" title="Provide Height of missing person (if available)" id="MissingPeopleHeight" runat="server" />
                            </div>
                            <div class="hide-input">
                                <label>Weight (Optional)</label>
                                <input type="text" placeholder="Enter Weight (Optional)" title="Provide Weight of missing person (if available)" id="MissingPeopleWeight" runat="server" />
                            </div>
                            <div class="hide-input">
                                <label>Eyes Color (Optional)</label>
                                <input type="text" placeholder="Enter Eyes Color (Optional)" title="Provide Eyes color of Missing Person" id="MissingPeopleEyes" runat="server" />
                            </div>
                            <div class="hide-input">
                                <label>Hair Color (Optional)</label>
                                <input type="text" placeholder="Enter Hair Color (Optional)" title="Provide Hair color of Missing Person" id="MissingPeopleHair" runat="server" />
                            </div>
                            <div class="hide-input">
                                <label>Description</label>
                                <textarea id="MissingPeopleDescription" title="Provide each and every imformation about that missing person." placeholder="Minimum 70 Characters are Required." runat="server" rows="20"></textarea>
                            </div>
                            <div class="gender hide-input">
                                <label for="" runat="server">Gender (*)</label>
                                <input type="radio" name="gender" id="MissingPeopleMale" value="Male" runat="server" checked="" />Male&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					    <input type="radio" name="gender" id="MissingPeopleFemale" value="Female" runat="server" />Female
                            </div>
                            <div class="hide-input image">
                                <label for="" class="Image" runat="server">Image (Optional)</label><asp:FileUpload ID="MissingPeopleImage" runat="server" />
                            </div>
                            <h6 class="fs-subtitle ErrorMsg"></h6>
                            <h6 class="fs-subtitle ErrorCNIC"></h6>
                            <h6 class="fs-subtitle ErrorLength"></h6>
                            <asp:Button ID="FormSubmit" runat="server" CssClass="btn submit hide-input center-block" OnClick="FormSubmit_Click" Text="Submit" />
                            <br />
                        </div>
                    </div>
                </div>


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
                        <img src="Image/Hero-Area-Up-Icon.png" alt="" width="55" /></a>
                </div>
                <uc1:Footer runat="server" ID="Footer" />
            </div>
            <!-- End of Footer-->
        </div>
    </form>
</body>
</html>
