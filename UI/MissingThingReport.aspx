<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MissingThingReport.aspx.cs" Inherits="UI.MissingThingReport" %>

<%@ Register Src="~/User Control Files/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/User Control Files/Navigation.ascx" TagPrefix="uc1" TagName="Navigation" %>
<%@ Register Src="~/User Control Files/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Missing Things Report - Missing People and Things</title>
    <meta name="description"  content="In this form people can submit a report for different things like auto mobile, mobile, cnic."/>
    <meta name="keywords" content="missing people, missing thing, unidentified people, missing thing report, submit form, auto mobile, mobile, cnic, missing people in pakistan"/>
    <meta name="author" content="Umar Anwar" />
    <uc1:Header runat="server" ID="Header1" />
</head>
<body style="background: #f7f7f7">
    <form id="form1" runat="server">
        <section id="header">
            <!-- Starting of Header Area -->
            <uc1:Navigation runat="server" ID="Navigation" />
            <div class="container top">
                <h1 class="text-center"><b>M</b>issing <b>T</b>hings</h1>
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
                            <h2 class="fs-title">Missing Thing Information</h2>
                            <div class="alert alert-danger" runat="server" id="ErrorDate" visible="false"><span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>&nbsp; Please Select Missing Date.</div>
                            <div class="alert alert-danger" runat="server" id="ErrorSelect" visible="false"><span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>&nbsp; Please select Thing that is missed from you.</div>
                            <div class="alert alert-success" runat="server" id="ReportSuccessfull" visible="false"><strong><span class="glyphicon glyphicon-thumbs-up"></span>&nbsp;</strong> Your report is successfully submit, You will get inform soon once your submitted report is approved by the admin. </div>
                            <div class="alert alert-warning" runat="server" id="Note"><strong>Note:</strong> Make sure you have created your account, if not then please <a href="register">click here</a> to make your account.</div>

                            <label for="" class="first">Owner Name*</label>
                            <input type="text" runat="server" title="Provide Full Name of missing thing's owner" id="ThingOwnerName" placeholder="Enter owner name" />
                            <label for="">Owner CNIC*</label>
                            <input type="text" runat="server" title="Provide CNIC of missing thing's owner" id="ThingOwnerCNIC" placeholder="Enter owner CNIC" />
                            <label for="">Mobile Number*</label>
                            <input type="text" id="ThingContact" title="Provide Mobile Number of missing thing's owner" runat="server" placeholder="Enter mobile number" />
                            <div class="text-right">
                                <a class="add-contact">Add Another</a>
                            </div>
                            <div class="field text-left is-focused contact-hide">
                                <label for="">Another Mobile Number (Optional)</label>
                                <input type="text" id="ThingAnotherContact" runat="server" placeholder="Enter another mobile number" />
                            </div>
                            <label for="">Father/Guardian Name*</label>
                            <input type="text" id="ThingGuardianName" title="Provide Father or Guardian Name of missing thing's owner" runat="server" placeholder="Enter father/guardian name" />
                            <label for="">Father/Guardian CNIC*</label>
                            <input type="text" id="ThingGuardianCNIC" title="Provide Father or Guardian Name of missing thing's owner" runat="server" placeholder="Enter father/guardian CNIC" />
                            <label for="">Permanent Address (Optional)</label>
                            <input type="text" id="ThingPermanentAddress" title="Provide Permanent address of missing thing's owner" runat="server" placeholder="Enter permanent address" />
                            <label for="">Current Address (Optional)</label>
                            <input type="text" id="ThingCurrentAddress" title="Provide Current address of missing thing's owner" runat="server" placeholder="Enter current address" />
                            <label for="">Missing Place*</label>
                            <input type="text" id="ThingMissingPlace" title="From which place you have lost your thing?" runat="server" placeholder="Enter missing place" />
                            <div class="form-group text-left">
                                <div class="form-inline">
                                    <label for="" class="MissingDate" runat="server">Missing Date*</label>
                                    <asp:DropDownList ID="Date" title="At which date you have lost your thing?" CssClass="form-control calender" runat="server">
                                        <asp:ListItem disabled="true" Selected="True">Date</asp:ListItem>
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                                        <asp:ListItem>6</asp:ListItem>
                                        <asp:ListItem>7</asp:ListItem>
                                        <asp:ListItem>8</asp:ListItem>
                                        <asp:ListItem>9</asp:ListItem>
                                        <asp:ListItem>10</asp:ListItem>
                                        <asp:ListItem>11</asp:ListItem>
                                        <asp:ListItem>12</asp:ListItem>
                                        <asp:ListItem>13</asp:ListItem>
                                        <asp:ListItem>14</asp:ListItem>
                                        <asp:ListItem>15</asp:ListItem>
                                        <asp:ListItem>16</asp:ListItem>
                                        <asp:ListItem>17</asp:ListItem>
                                        <asp:ListItem>18</asp:ListItem>
                                        <asp:ListItem>19</asp:ListItem>
                                        <asp:ListItem>20</asp:ListItem>
                                        <asp:ListItem>21</asp:ListItem>
                                        <asp:ListItem>22</asp:ListItem>
                                        <asp:ListItem>23</asp:ListItem>
                                        <asp:ListItem>24</asp:ListItem>
                                        <asp:ListItem>25</asp:ListItem>
                                        <asp:ListItem>26</asp:ListItem>
                                        <asp:ListItem>27</asp:ListItem>
                                        <asp:ListItem>28</asp:ListItem>
                                        <asp:ListItem>29</asp:ListItem>
                                        <asp:ListItem>30</asp:ListItem>
                                        <asp:ListItem>31</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:DropDownList ID="Month" title="At which date you have lost your thing?" CssClass="form-control calender" runat="server">
                                        <asp:ListItem Selected="True" disabled="true" Value="Month">Month</asp:ListItem>
                                        <asp:ListItem Value="Jan">January</asp:ListItem>
                                        <asp:ListItem Value="Feb">February</asp:ListItem>
                                        <asp:ListItem>March</asp:ListItem>
                                        <asp:ListItem>April</asp:ListItem>
                                        <asp:ListItem>May</asp:ListItem>
                                        <asp:ListItem Value="Jun">June</asp:ListItem>
                                        <asp:ListItem>July</asp:ListItem>
                                        <asp:ListItem Value="Aug">August</asp:ListItem>
                                        <asp:ListItem Value="Sep">September</asp:ListItem>
                                        <asp:ListItem Value="Oct">Octuber</asp:ListItem>
                                        <asp:ListItem Value="Nov">Novermber</asp:ListItem>
                                        <asp:ListItem Value="Dec">December</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:DropDownList ID="Year" title="At which date you have lost your thing?" CssClass="form-control calender" runat="server">
                                        <asp:ListItem Selected="True" disabled="true">Year</asp:ListItem>
                                        <asp:ListItem>2000</asp:ListItem>
                                        <asp:ListItem>2001</asp:ListItem>
                                        <asp:ListItem>2002</asp:ListItem>
                                        <asp:ListItem>2003</asp:ListItem>
                                        <asp:ListItem>2004</asp:ListItem>
                                        <asp:ListItem>2005</asp:ListItem>
                                        <asp:ListItem>2006</asp:ListItem>
                                        <asp:ListItem>2007</asp:ListItem>
                                        <asp:ListItem>2008</asp:ListItem>
                                        <asp:ListItem>2009</asp:ListItem>
                                        <asp:ListItem>2010</asp:ListItem>
                                        <asp:ListItem>2011</asp:ListItem>
                                        <asp:ListItem>2012</asp:ListItem>
                                        <asp:ListItem>2013</asp:ListItem>
                                        <asp:ListItem>2014</asp:ListItem>
                                        <asp:ListItem>2015</asp:ListItem>
                                        <asp:ListItem>2016</asp:ListItem>
                                        <asp:ListItem>2017</asp:ListItem>
                                        <asp:ListItem>2018</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <label for="">Description*</label>
                            <input type="text" id="ThingDescription" title="Provide Each and Every information about your thing." runat="server" placeholder="Minimum 70 characters are Required." />
                            <div class="text-left form-group">
                                <div class="form-inline">
                                    <label for="" class="MissingDate">Select Thing*</label>
                                    <asp:DropDownList ID="ThingSelect" CssClass="form-control calender" runat="server" AutoPostBack="true">
                                        <asp:ListItem disabled="true" Selected="True">Select Missing Things</asp:ListItem>
                                        <asp:ListItem>Auto Mobile</asp:ListItem>
                                        <asp:ListItem>Mobile</asp:ListItem>
                                        <asp:ListItem>CNIC</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div runat="server" visible="false" id="AutoCompanyHide">
                                <label for="">Company Name*</label>
                                <input type="text" id="AutoCompany" title="Provide Company name of missing thing" runat="server" placeholder="Enter company name" />
                            </div>
                            <div runat="server" visible="false" id="BrandHide">
                                <label for="">Brand Name*</label>
                                <input type="text" id="BrandName" title="Provide Brand name of missing thing" runat="server" placeholder="Enter brand name" />
                            </div>
                            <div runat="server" visible="false" id="AutoEngineHide">
                                <label for="">Engine Number*</label>
                                <input type="text" id="AutoEngine" title="Provide Engine number of your Auto mobile" runat="server" placeholder="Enter engine number" />
                            </div>
                            <div runat="server" visible="false" id="AutoChassesHide">
                                <label for="">Chasses Number*</label>
                                <input type="text" id="AutoChasses" title="Provide Chasses number of your Auto Mobile" runat="server" placeholder="Enter chasses number" />
                            </div>
                            <div runat="server" visible="false" id="ColorHide">
                                <label for="">Color*</label>
                                <input type="text" id="Color" title="Provide Color name of missing thing" runat="server" placeholder="Enter color name" />
                            </div>
                            <div runat="server" visible="false" id="ModelHide">
                                <label for="">Model*</label>
                                <input type="text" id="Model" title="Provide Model of your of missing thing" runat="server" placeholder="Enter model number" />
                            </div>
                            <div runat="server" visible="false" id="MobileIMEIHide">
                                <label for="">IMEI (Optional)</label>
                                <input type="text" id="MobileIMEI" title="Provide IMEI number of your Mobile" runat="server" placeholder="Enter IMEI number" />
                            </div>
                            <div runat="server" visible="false" id="CnicNumberHide">
                                <label for="">CNIC Number*</label>
                                <input type="text" id="CNICNumber" title="Provide Number of your CNIC" runat="server" placeholder="Enter CNIC number" />
                            </div>
                            <div runat="server" visible="false" id="CNICUniqueHide">
                                <label for="">Unique Identification (Optional)</label>
                                <input type="text" id="CNICUnique" title="Provide your Unique Identification" runat="server" placeholder="Enter unique identification" />
                            </div>
                            <div runat="server" visible="false" id="CNICFamilyHide">
                                <label for="">Family Number*</label>
                                <input type="text" id="CNICFamily" title="Provide Family Number of your CNIC" runat="server" placeholder="Enter family number" />
                            </div>
                            <div class="form-group" runat="server" visible="false" id="CNICDateHide">
                                <div class="form-inline">
                                    <label for="" class="MissingDate" runat="server">Date of Birth*</label>
                                    <select class="form-control calender" title="Provide your Date Of Birth of CNIC" runat="server" id="CNICDate">
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
                                    <select class="form-control calender" title="Provide your Date Of Birth of CNIC" id="CNICMonth" runat="server">
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
                                    <select class="form-control calender" title="Provide your Date Of Birth of CNIC" id="CNICYear" runat="server">
                                        <option value="year" selected="" disabled="">Year</option>
                                        <option value="1940">1940</option>
                                        <option value="1941">1941</option>
                                        <option value="1942">1942</option>
                                        <option value="1943">1943</option>
                                        <option value="1944">1944</option>
                                        <option value="1945">1945</option>
                                        <option value="1946">1946</option>
                                        <option value="1947">1947</option>
                                        <option value="1948">1948</option>
                                        <option value="1949">1949</option>
                                        <option value="1950">1950</option>
                                        <option value="1951">1951</option>
                                        <option value="1952">1952</option>
                                        <option value="1953">1963</option>
                                        <option value="1954">1954</option>
                                        <option value="1955">1955</option>
                                        <option value="1956">1956</option>
                                        <option value="1957">1957</option>
                                        <option value="1958">1958</option>
                                        <option value="1959">1959</option>
                                        <option value="1960">1960</option>
                                        <option value="1961">1961</option>
                                        <option value="1962">1962</option>
                                        <option value="1963">1963</option>
                                        <option value="1964">1964</option>
                                        <option value="1965">1965</option>
                                        <option value="1966">1966</option>
                                        <option value="1967">1967</option>
                                        <option value="1968">1968</option>
                                        <option value="1969">1969</option>
                                        <option value="1970">1970</option>
                                        <option value="1971">1971</option>
                                        <option value="1972">1972</option>
                                        <option value="1973">1973</option>
                                        <option value="1974">1974</option>
                                        <option value="1975">1975</option>
                                        <option value="1976">1976</option>
                                        <option value="1977">1977</option>
                                        <option value="1978">1978</option>
                                        <option value="1979">1979</option>
                                        <option value="1980">1980</option>
                                        <option value="1981">1981</option>
                                        <option value="1982">1982</option>
                                        <option value="1983">1983</option>
                                        <option value="1984">1984</option>
                                        <option value="1985">1985</option>
                                        <option value="1986">1986</option>
                                        <option value="1987">1987</option>
                                        <option value="1988">1988</option>
                                        <option value="1989">1989</option>
                                        <option value="1990">1990</option>
                                        <option value="1991">1991</option>
                                        <option value="1992">1992</option>
                                        <option value="1993">1993</option>
                                        <option value="1994">1994</option>
                                        <option value="1995">1995</option>
                                        <option value="1996">1996</option>
                                        <option value="1997">1997</option>
                                        <option value="1998">1998</option>
                                        <option value="1999">1999</option>
                                        <option value="2000">2000</option>
                                        <option value="2001">2001</option>
                                        <option value="2002">2002</option>
                                        <option value="2003">2003</option>
                                        <option value="2004">2004</option>
                                        <option value="2005">2005</option>
                                        <option value="2006">2006</option>
                                        <option value="2007">2007</option>
                                        <option value="2008">2008</option>
                                        <option value="2009">2009</option>
                                        <option value="2010">2010</option>
                                        <option value="2011">2011</option>
                                        <option value="2012">2012</option>
                                        <option value="2013">2013</option>
                                        <option value="2014">2014</option>
                                        <option value="2015">2015</option>
                                        <option value="2016">2016</option>
                                        <option value="2017">2017</option>
                                        <option value="2018">2018</option>
                                    </select>
                                </div>
                            </div>
                            <div class="gender" runat="server" visible="false" id="CNICGanderHide">
                                <label for="" runat="server">Gander*</label>
                                <input type="radio" name="gender" id="CNICMale" value="Male" runat="server" checked="" />Male&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
								<input type="radio" name="gender" id="CNICFemale" value="Female" runat="server" />Female
                            </div>
                            <div class="text-left" runat="server" visible="false" id="ImageHide">
                                <label for="" class="Image">Image(Optional)</label><asp:FileUpload ID="Image" runat="server" />
                            </div>
                            <h5 class="fs-subtitle ErrorMsg"></h5>
                            <h5 class="fs-subtitle ErrorCNIC"></h5>
                            <asp:Button ID="MissingThingButton" runat="server" CssClass="btn submit center-block" Text="Submit" OnClick="MissingThingButton_Click" />
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
