<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrystalReports.aspx.cs" Inherits="UI.Admin.CrystalReports" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<%@ Register Src="~/Admin/User Control File/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Admin/User Control File/SideNavigation.ascx" TagPrefix="uc1" TagName="SideNavigation" %>
<%@ Register Src="~/Admin/User Control File/TopNavigation.ascx" TagPrefix="uc1" TagName="TopNavigation" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<uc1:Header runat="server" ID="Header" />	
    <title>Crystal Reports | Admin Panel</title>
    <script src="../crystalreportviewers13/js/crviewer/crv.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Contaier-Fluid -->
		<div class="container-fluid">
			<div class="row">
				<!-- First Column -->
				<div class="col-md-2 col-lg-2 side-bar" id="side-bar">
					<uc1:SideNavigation runat="server" ID="SideNavigation" />
				</div>

				<!-- Second Column -->
				<div class="col-xs-12 col-sm-12 col-md-10 col-lg-10 right-bg">

					<!-- Top COntent -->
					<div class="top-content">
                        <uc1:TopNavigation runat="server" ID="TopNavigation" />
					</div>
					<!-- Top Content  -->

					<!--  Main COntent -->
					<div class="main-content" onclick="Open();">
						
						<!-- Breadcrumb -->
						<h2 class="heading">Comments</h2>
						<ol class="breadcrumb">
						  	<li><a href="Dashboard.aspx">Home</a></li>
						  	<li><a href="Comments.aspx">Comments</a></li>
						  	<li class="active">Data</li>
						</ol>
						<!-- Breadcrumb -->

						<div class="registered-users">
							<div class="bg">
								<div class="clearfix"></div>
                                <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" ReportSourceID="CrystalReportSource1" DisplayToolbar="False" ToolPanelView="None" />
                                <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
                                    <Report FileName="Report1.rpt">
                                    </Report>
                                </CR:CrystalReportSource>
							</div>
							<!-- BG -->
						</div>
						<!-- Registetred User -->
					</div>
					<!-- Main Content -->
				</div>
				<!-- Second Column -->
			</div>
			<!-- Row  -->
		</div>
		<!-- Container-Fluid -->
    </form>
</body>
</html>
