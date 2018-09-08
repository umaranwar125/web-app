using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class Logout : System.Web.UI.Page
    {
        // Page Load Event.
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionsRemove();
            Response.Redirect("Default.aspx");
        }

        // Sessions Remove Method.
        private void SessionsRemove()
        {
            Session.Remove("RegisteredSuccessfully");
            Session.Remove("contact");
            Session.Remove("username");
            Session.Remove("MissingPeople");
            Session.Remove("MissingThing");
            Session.Remove("UnidentifiedPeople");
            Session.Remove("ReportSighting");
            Session.Remove("FullPost");
            Session.Remove("ResetPassword");
            Session.Remove("Feedback");
        }
    }
}