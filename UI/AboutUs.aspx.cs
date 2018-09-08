using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class AboutUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionsRemove();
        }

        // Sessions Remove Method.
        private void SessionsRemove()
        {
            Session.Remove("RegisteredSuccessfully");
            Session.Remove("contact");
            Session.Remove("MissingPeople");
            Session.Remove("MissingThing");
            Session.Remove("UnidentifiedPeople");
            Session.Remove("ReportSighting");
            Session.Remove("FullPost");
            Session.Remove("ResetPassword");
            Session.Remove("Feedback");
            Session.Remove("Favourite");
        }
    }
}