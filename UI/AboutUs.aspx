<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="UI.AboutUs" %>

<%@ Register Src="~/User Control Files/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/User Control Files/Navigation.ascx" TagPrefix="uc1" TagName="Navigation" %>
<%@ Register Src="~/User Control Files/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>About Us - Missing People and Things</title>
    <meta name="description"  content="We are the people who are working from every day to night to meet you from your missing relatives and things."/>
    <meta name="keywords" content="missing people, missing thing, unidentified people, about us, missing people in pakistan"/>
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

        <section id="about-us">
            <div class="container">
                <h1 class="text-center"><b>A</b>bout <b>U</b>s</h1>
                <p>If you are worried about finding your loved ones and your stolen objects, don't go anywhere we are here to help you. We are with you in your sorrow. Just add a post and keep visiting our website so that you can find your missing relatives or objects quickly. If you are worried about finding your loved ones and your stolen objects, don't go anywhere we are here to help you. We are with you in your sorrow. Just add a post and keep visiting our website so that you can find your missing relatives or objects quickly. Just add a post and keep visiting our website so that you can find your missing relatives or objects quickly. If you are worried about finding your loved ones and your stolen objects, don't go anywhere we are here to help you. We are with you in your sorrow. Just add a post and keep visiting our website so that you can find your missing relatives or objects quickly.</p>
                <h1 class="text-center"><b>O</b>ur <b>M</b>ission</h1>
                <p>If you are worried about finding your loved ones and your stolen objects, don't go anywhere we are here to help you. We are with you in your sorrow. Just add a post and keep visiting our website so that you can find your missing relatives or objects quickly. </p>
                <h1 class="text-center"><b>O</b>ur <b>V</b>ission</h1>
                <p>If you are worried about finding your loved ones and your stolen objects, don't go anywhere we are here to help you. We are with you in your sorrow. Just add a post and keep visiting our website so that you can find your missing relatives or objects quickly. </p>
            </div>
        </section>


        <!-- Start of Footer-->
        <div id="Testimonial">
            <div class="footer">
                <uc1:Footer runat="server" ID="Footer" />
            </div>
        </div>
        <!-- End of Footer-->
    </form>
</body>
</html>
