using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOL;
using BLL;

namespace UI.Admin
{
    public partial class Feedback : System.Web.UI.Page
    {
        public List<FeedbackPageObjects> DisplayFeedbackData;
        FeedbackBussiness ob = new FeedbackBussiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminUsername"] == null)
                Response.Redirect("Login.aspx");
            DisplayFeedbackData = ob.SelectFeedbackDataForAdminPanel();
        }
    }
}