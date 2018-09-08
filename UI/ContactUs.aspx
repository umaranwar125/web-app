<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="UI.ContactUs" %>

<%@ Register Src="~/User Control Files/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/User Control Files/Navigation.ascx" TagPrefix="uc1" TagName="Navigation" %>
<%@ Register Src="~/User Control Files/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact Us - Missing People and Things</title>
    <meta name="description"  content="If you have any query related to our website you can caontact with our team."/>
    <meta name="keywords" content="missing people, missing thing, unidentified people, contact us, missing people in pakistan"/>
    <meta name="author" content="Umar Anwar" />
    <uc1:Header runat="server" ID="Header" />
</head>
<body>
    <form id="form1" runat="server">
        <section id="contact-header">
            <!-- Starting of Header Area -->
            <uc1:Navigation runat="server" ID="Navigation" />
            <div class="container top">
                <h1 class="text-center"><b>C</b>ontact <b>U</b>s</h1>
                <hr />
                <p>If you are worried about finding your loved ones and your stolen objects, don't go anywhere we are here to help you. We are with you in your sorrow. Just add a post and keep visiting our website so that you can find your missing relatives or objects quickly.</p>
            </div>
        </section>
        <!-- End of Header Area Section-->


        <section id="contact-form">
            <div class="container">
                <!-- Start of Section Container -->
                <center>
                    <h4 runat="server" id="ErrorInternet" visible="false">Sorry message is not send, some problem occur.</h4>
                    <h4 runat="server" id="SubmitSuccessfull" visible="false" style="color:green; margin-top:-20px;">Congrats! Message is successfully sent.</h4>
					<h4 id="ErrorEmail" runat="server" visible="false">Email is not in Correct Format.</h4>
                    <h4>What Do You Want To Say?</h4><br>
					<div class="form-group" id="myForm">
						<div class="form-inline">
								
								<i class="fa fa-envelope fa-2x" aria-hidden="true"></i>
								<%--<input type="text" class="form-control" runat="server" id="ContactEmailAddress" placeholder="Email Address" aria-describedby="basic-addon1" />--%>
                                <asp:TextBox id="ContactEmailAddress" CssClass="form-control" placeholder="Email Address (*)" aria-describedby="basic-addon1" runat="server"></asp:TextBox>
								
                                <i class="fa fa-phone fa-2x" aria-hidden="true"></i>
								<%--<input type="text" class="form-control" runat="server" id="ContactMobile" placeholder="Mobile No" aria-describedby="basic-addon1" />--%>
						        <asp:TextBox ID="ContactMobile" CssClass="form-control" placeholder="Mobile No (*)" aria-describedby="basic-addon1" runat="server"></asp:TextBox>    

                                <i class="fa fa-pencil fa-2x" aria-hidden="true"></i>
								<%--<input type="text" class="form-control" runat="server" id="ContactSubject" placeholder="Subject" aria-describedby="basic-addon1"/>--%>
                                <asp:TextBox runat="server" id="ContactSubject" CssClass="form-control" placeholder="Subject (*)" aria-describedby="basic-addon1"></asp:TextBox>
                                 
                        &nbsp;</div>
							<textarea name="" id="ContactMessage" cols="30" rows="6" runat="server" placeholder="Your Message (*)" class="form-control" aria-describedby="basic-addon1" style="overflow: hidden"></textarea>
                            <h5 class="ErrorMsg text-right"></h5>
                            <h5 class="ErrorMobile text-right"></h5>    
                            <asp:Button ID="ContactSubmitButton" CssClass="btn pull-right" runat="server" Text="Submit" OnClick="ContactSubmitButton_Click"></asp:Button>

					</div>
				</center>
            </div>
            <!-- End of Container -->
            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d26459.325865981926!2d71.99277292249305!3d34.00753815953874!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x38ded252117f0d67%3A0x416b6f690ea12711!2sNowshera+Cantonment%2C+Nowshera%2C+Pakistan!5e0!3m2!1sen!2s!4v1509875353165" width="100%" height="400" frameborder="" style="border-radius: 2px; margin-bottom: 80px;" allowfullscreen></iframe>
        </section>


        <div id="Testimonial">
            <div class="footer">
                <div class="text-center">
                    <a href="#contact-header">
                        <img src="Image/Hero-Area-Up-Icon.png" alt="" width="55"></a>
                </div>
                <uc1:Footer runat="server" ID="Footer" />
            </div>

        </div>
        <!-- End of Footer-->
    </form>
</body>
</html>
