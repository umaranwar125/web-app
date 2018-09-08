using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using BLL;

namespace UI
{
    public partial class ContactUs : System.Web.UI.Page
    {
        // Main Form Load.
        protected void Page_Load(object sender, EventArgs e)
        {
            // To Remove a session for Successfull Registration.
            SessionsRemove();
            
            // To make Error Msg false when page loads.
            if (Request.Url.AbsolutePath.EndsWith("ContactUs.aspx"))
                ErrorInternet.Visible = false;
        }

        // Contact us Button Click Event.
        protected void ContactSubmitButton_Click(object sender, EventArgs e)
        {
            ContactBussiness ob = new ContactBussiness();
            if (Session["username"] == null)
            {
                Session["contact"] = "Question";
                Response.Redirect("login");
            }
            else
            {
                // Get user ID Method Calling.
                ob.GetUserID(Session["username"].ToString());
                try
                {
                    string body = "\n\nFrom:    " + ContactEmailAddress.Text + "\n\n";
                    body += "Subject:   " + ContactSubject.Text + "\n\n";
                    body += "Mobile:    " + ContactMobile.Text + "\n\n";
                    body += "Message:   " + ContactMessage.Value + "\n\n";
                    var smtp = new System.Net.Mail.SmtpClient();
                    {
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential("umaranwar616@gmail.com", "PARADISEISAGOODPLACE");
                        smtp.Timeout = 20000;
                    }
                    ServicePointManager.DefaultConnectionLimit = 200;
                    try
                    {
                        smtp.Send(ContactEmailAddress.Text, "umaranwar616@gmail.com", ContactSubject.Text, body);
                    }
                    catch (SmtpException ex)
                    {
                        visibility(true, false, false);
                    }
                    if(ErrorInternet.Visible == false)
                    {
                        ob.InsertContactDataToDatabase(ContactSubject.Text, ContactEmailAddress.Text, Convert.ToInt64(ContactMobile.Text), ContactMessage.Value, DateTime.Now.ToShortDateString().ToString(), DateTime.Now.ToShortTimeString().ToString());
                        visibility(false, false, true);
                    }
                }
                catch (FormatException ex)
                {
                    visibility(false, true, false);
                }
            }
            ContactEmailAddress.Text = "";
            ContactMobile.Text = "";
            ContactSubject.Text = "";
        }

        // Messages Visibility Method.
        private void visibility(bool Internet, bool Email, bool Successfull)
        {
            ErrorInternet.Visible = Internet;
            ErrorEmail.Visible = Email;
            SubmitSuccessfull.Visible = Successfull;
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