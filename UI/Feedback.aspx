<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="UI.Feedback" %>

<%@ Register Src="~/User Control Files/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/User Control Files/Navigation.ascx" TagPrefix="uc1" TagName="Navigation" %>
<%@ Register Src="~/User Control Files/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Feedback - Missing People and Things</title>
    <meta name="description"  content="If we are doing something wrong or we should add something new in website, you can do feedback."/>
    <meta name="keywords" content="missing people, missing thing, unidentified people, feedback, response, missing people in pakistan"/>
    <meta name="author" content="Umar Anwar" />
    <uc1:Header runat="server" ID="Header" />
</head>
<body>
    <form id="form1" runat="server">
        <section id="Login-header">
            <!-- Starting of Header Area -->
            <uc1:Navigation runat="server" ID="Navigation" />
        </section>
        <!-- End of Header Area Section-->
        <section id="feedback">
            <div class="container">
                <div class="col-xs-0 col-sm-0 col-md-3 col-lg-3"></div>
                <div class="col-xs-12 col-sm-12 col-md-6 col-lg-6">
                    <h5 runat="server" id="Msg" visible="false" class="text-center" style="color: green;">Thank you for the feedback, this feedback is very mean for us.</h5>
                    <div class="bg">
                        <h3 class="text-center">Give us your feedback</h3>
                        <hr>
                        <div class="visit">
                            <h5>Is this the first time you have visited the webite?</h5>
                            <input type="radio" name="visit" value="Yes" id="VisitYes" runat="server" />
                            &nbsp;&nbsp;&nbsp;Yes
                            <br />
                            <input type="radio" name="visit" value="No" id="VisitNo" runat="server" />
                            &nbsp;&nbsp;&nbsp;No
                            <br />
                        </div>
                        <label for=""></label>
                        <div class="find">
                            <h5>Did you find what you needed?</h5>
                            <input type="radio" name="find" value="All of it" runat="server" id="AllOfIt" />
                            &nbsp;&nbsp;&nbsp;Yes, all of it
                            <br />
                            <input type="radio" name="find" value="Some of it" runat="server" id="SomeOfIt" />
                            &nbsp;&nbsp;&nbsp;Yes, some of it
                            <br />
                            <input type="radio" name="find" value="None of it" runat="server" id="NoneOfIt" />
                            &nbsp;&nbsp;&nbsp;No, none of it
                            <br />
                        </div>
                        <label for=""></label>
                        <div class="easy">
                            <h5>Please tell us how easy it is to find information on the site.</h5>
                            <select name="" id="FindInformation" runat="server">
                                <option value="Please Select" disabled="" selected="">Please Select</option>
                                <option value="Very Easy">Very Easy</option>
                                <option value="Easy">Easy</option>
                                <option value="Average">Average</option>
                                <option value="Difficult">Difficult</option>
                                <option value="Very Difficult">Very Difficult</option>
                            </select>
                        </div>
                        <label for=""></label>
                        <div class="Impression">
                            <h5>What is your opinion of this page?</h5>
                            <select name="" id="Opinion" runat="server">
                                <option value="Please Select" disabled="" selected="">Please Select</option>
                                <option value="Too Good">Too Good</option>
                                <option value="Good">Good</option>
                                <option value="Excellent">Excellent</option>
                                <option value="Bad">Bad</option>
                                <option value="Too Bad">Too Bad</option>
                            </select>
                        </div>
                        <label for=""></label>
                        <div class="likelihood">
                            <h5>What is the likelihood that you will visit the website again?</h5>
                            <select name="" id="Likelihood" runat="server">
                                <option value="Please Select" disabled="" selected="">Please Select</option>
                                <option value="Extremely Likely">Extremely Likely</option>
                                <option value="Very Likely">Very Likely</option>
                                <option value="Moderately Likely">Moderately Likely</option>
                                <option value="Slightly Likely">Slightly Likely</option>
                                <option value="Not at all Likely">Not at all Likely</option>
                            </select>
                        </div>
                        <label for=""></label>
                        <div class="comment">
                            <h5>Would you like to add any suggestion?</h5>
                            <textarea name="" cols="30" rows="3" runat="server" id="Suggestion"></textarea>
                        </div>
                        <div class="text-right">
                            <asp:Button ID="FeedbackSubmit" runat="server" Text="Submit" CssClass="btn btn-feedback" OnClick="FeedbackSubmit_Click" />
                        </div>
                    </div>
                </div>
                <div class="col-xs-0 col-sm-0 col-md-3 col-lg-3"></div>
            </div>
        </section>

        <div id="Testimonial">
            <div class="footer">
                <uc1:Footer runat="server" ID="Footer" />
            </div>
        </div>
    </form>
</body>
</html>
