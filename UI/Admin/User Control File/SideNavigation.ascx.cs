using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Admin.User_Control_File
{
    public partial class SideNavigation : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Url.AbsolutePath.EndsWith("Dashboard.aspx"))
            {
                DashboardActive.Attributes["class"] = "active";
            }
            if(Request.Url.AbsolutePath.EndsWith("AllReports.aspx"))
            {
                AllReportsActive.Attributes["class"] = "active";
            }
            if (Request.Url.AbsolutePath.EndsWith("ReportSighting.aspx"))
            {
                SightingActive.Attributes["class"] = "active";
            }
            if (Request.Url.AbsolutePath.EndsWith("RegisteredUsers.aspx"))
            {
                UsersActive.Attributes["class"] = "active";
            }
            if (Request.Url.AbsolutePath.EndsWith("Feedback.aspx"))
            {
                FeedbackActive.Attributes["class"] = "active";
            }
            if (Request.Url.AbsolutePath.EndsWith("Contacts.aspx"))
            {
                ContactActive.Attributes["class"] = "active";
            }
            if (Request.Url.AbsolutePath.EndsWith("Comments.aspx"))
            {
                CommentsActive.Attributes["class"] = "active";
            }
        }
    }
}