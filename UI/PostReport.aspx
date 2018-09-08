<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostReport.aspx.cs" Inherits="UI.PostReport" %>

<%@ Register Src="~/User Control Files/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/User Control Files/Navigation.ascx" TagPrefix="uc1" TagName="Navigation" %>
<%@ Register Src="~/User Control Files/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Post a Report - Missing People and Things</title>
    <meta name="description"  content="Choose box and submit a report."/>
    <meta name="keywords" content="missing people, missing thing, unidentified people, post, report, missing people in pakistan"/>
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

        <section id="post-report">
            <div class="container">
                <center>
					<div class="col-xs-12 col-sm-6 col-md-6 col-lg-6 box">
						<h3 class="text-center">Missing People</h3>
						<p>If you are worried about finding your loved ones and your stolen objects, don't go anywhere we are here to help you. We are with you in your sorrow. Just add a post and keep visiting our website so that you can find your missing relatives or objects quickly.</p>
						<a href="missing-people-report" class="btn center-block">Post Now</a>
					</div>
					<div class="col-xs-12 col-sm-6 col-md-6 col-lg-6 box">
						<h3 class="text-center">Missing Things</h3>
						<p>If you are worried about finding your loved ones and your stolen objects, don't go anywhere we are here to help you. We are with you in your sorrow. Just add a post and keep visiting our website so that you can find your missing relatives or objects quickly.</p>
						<a href="missing-thing-report" class="btn center-block">Post Now</a>
					</div>
					<div class="col-xs-12 col-sm-6 col-md-6 col-lg-6 box">
						<h3 class="text-center">Unidentified People</h3>
						<p>If you are worried about finding your loved ones and your stolen objects, don't go anywhere we are here to help you. We are with you in your sorrow. Just add a post and keep visiting our website so that you can find your missing relatives or objects quickly.</p>
						<a href="unidentified-people-report" class="btn center-block">Post Now</a>
					</div>
					<div class="col-xs-12 col-sm-6 col-md-6 col-lg-6 box">
						<h3 class="text-center">Report Sighting</h3>
						<p>If you are worried about finding your loved ones and your stolen objects, don't go anywhere we are here to help you. We are with you in your sorrow. Just add a post and keep visiting our website so that you can find your missing relatives or objects quickly.</p>
						<a href="report-sighting" class="btn center-block">Post Now</a>
					</div>
				</center>
            </div>
        </section>

        <div id="Testimonial">
            <div class="footer">
                <uc1:Footer runat="server" ID="Footer" />
            </div>
            <!-- End of Footer-->
        </div>
    </form>
</body>
</html>
