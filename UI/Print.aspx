<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Print.aspx.cs" Inherits="UI.Print" %>

<%@ Register Src="~/User Control Files/Header.ascx" TagPrefix="uc1" TagName="Header" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <uc1:Header runat="server" ID="Header" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="col-xs-12 col-sm-12 col-md-2 col-lg-2"></div>
            <div class="col-xs-12 col-sm-12 col-md-8 col-lg-8">
                <asp:Button ID="PrintBtn" runat="server" Text="Download Now" CssClass="btn btn-default print-btn" OnClick="PrintBtn_Click" />
                <div class="print">
                    <asp:Panel ID="Panel1" runat="server">
                        <%foreach (var data in displayMissingPeopleData)
                            { %>
                                                    <img src="../<%= data.Image %>" runat="server" id="myImg" class="img-responsive img-circle center-block" />
                    <%} %>
                    </asp:Panel>
                </div>
            </div>
            <div class="col-xs-12 col-sm-12 col-md-2 col-lg-2"></div>
        </div>
    </form>
</body>
</html>
