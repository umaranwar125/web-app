using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace UI
{
    public partial class Feedback : System.Web.UI.Page
    {
        int RegistrationID;
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionsRemove();
        }

        // Feedback Button Click.
        protected void FeedbackSubmit_Click(object sender, EventArgs e)
        {
            FeedbackBussiness ob = new FeedbackBussiness();
            if (Session["username"] == null)
            {
                Session["Feedback"] = "Feedback";
                Response.Redirect("login");
            }
            else
            {
                ob.GetUserID(Session["username"].ToString());
                if (AllOfIt.Checked)
                {
                    if (VisitYes.Checked)
                    {
                        if (ob.InsertFeedbackData(RegistrationID, VisitYes.Value, AllOfIt.Value, FindInformation.Value, Opinion.Value, Likelihood.Value, Suggestion.Value))
                            Msg.Visible = true;
                    }
                    else if (VisitNo.Checked)
                    {
                        if (ob.InsertFeedbackData(RegistrationID, VisitNo.Value, AllOfIt.Value, FindInformation.Value, Opinion.Value, Likelihood.Value, Suggestion.Value))
                            Msg.Visible = true;
                    }
                }
                else if (SomeOfIt.Checked)
                {
                    if (VisitYes.Checked)
                    {
                        if (ob.InsertFeedbackData(RegistrationID, VisitYes.Value, SomeOfIt.Value, FindInformation.Value, Opinion.Value, Likelihood.Value, Suggestion.Value))
                            Msg.Visible = true;
                    }
                    else if (VisitNo.Checked)
                    {
                        if (ob.InsertFeedbackData(RegistrationID, VisitNo.Value, SomeOfIt.Value, FindInformation.Value, Opinion.Value, Likelihood.Value, Suggestion.Value))
                            Msg.Visible = true;
                    }
                }
                else if (NoneOfIt.Checked)
                {
                    if (VisitYes.Checked)
                    {
                        if (ob.InsertFeedbackData(RegistrationID, VisitYes.Value, NoneOfIt.Value, FindInformation.Value, Opinion.Value, Likelihood.Value, Suggestion.Value))
                            Msg.Visible = true;
                    }
                    else if (VisitNo.Checked)
                    {
                        if (ob.InsertFeedbackData(RegistrationID, VisitNo.Value, NoneOfIt.Value, FindInformation.Value, Opinion.Value, Likelihood.Value, Suggestion.Value))
                            Msg.Visible = true;
                    }
                }
            }
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