using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOL;
using BLL;

namespace UI.User_Control_Files
{
    public partial class Navigation : System.Web.UI.UserControl
    {
        public List<RegistrationObjects> DisplayUserData;
        RegistrationBussiness ob = new RegistrationBussiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Url.AbsolutePath.EndsWith("index"))
            {
                DefaultActive.Attributes["class"] = "active";               
            }
            if (Request.Url.AbsolutePath.EndsWith("Default.aspx"))
            {
                DefaultActive.Attributes["class"] = "active";
            }
            if (Request.Url.AbsolutePath.EndsWith("login"))
            {
                LoginActive.Attributes["class"] = "active";
            }
            if (Request.Url.AbsolutePath.EndsWith("register"))
            {
                CreateAccountActive.Attributes["class"] = "active";
            }
            if (Request.Url.AbsolutePath.EndsWith("seeking-information"))
            {
                SeekingInformationActive.Attributes["class"] = "active";
            }
            if (Request.Url.AbsolutePath.EndsWith("report-sighting"))
            {
                ReportSightingActive.Attributes["class"] = "active";
            }
            if(Session["username"] != null)
            {
                DisplayUser();
            }
        }

        // Display User Method.
        private void DisplayUser()
        {
            DisplayUserData = ob.SelectRegistrationData(Session["username"].ToString());
        }
    }
}