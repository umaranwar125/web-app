using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using BLL;
using System.Web.Security;

namespace UI
{
    public partial class Login : System.Web.UI.Page
    {
        LoginBussiness ob = new LoginBussiness();
        // Page Load Event.
        protected void Page_Load(object sender, EventArgs e)
        {
            Sessions();
            SessionMessagesShow();
            if (Session["ResetPassword"] != null)
                PwdReset.Visible = true;
        }

        // Login Button Click Event.
        protected void LoginClick_Click(object sender, EventArgs e)
        {
            string PasswordDecrypted = FormsAuthentication.HashPasswordForStoringInConfigFile(passwordTextbox.Value.ToString(), "MD5");
            if (ob.LoginMethod(usernameTextbox.Value.ToString(), PasswordDecrypted))
            {
                Session["username"] = usernameTextbox.Value.ToString();
                Session.Remove("ResetPassword");
                SessionRedirect();
            }
            else
            {
                Session.Remove("ResetPassword");
                Visibility();
            }
        }

        // Checking Username.
        [WebMethod]
        public static void CheckUsernameExistance(string username)
        {
            LoginBussiness ob = new LoginBussiness();
            if (ob.CheckUsername(username))
            {
                // DO Something.
            }
            else
            {
                HttpContext.Current.Response.Write("a");
            }
        }

        // Checking Email.
        [WebMethod]
        public static void CheckingEmailExistance(string email)
        {
            LoginBussiness ob = new LoginBussiness();
            if (ob.CheckEmail(email))
            {
                // Do Something
            }
            else
            {
                HttpContext.Current.Response.Write("a");
            }
        }

        // Checking Number.
        [WebMethod]
        public static void CheckingNumberExistance(string number, string username, string email)
        {
            LoginBussiness ob = new LoginBussiness();
            if (ob.CheckNumber(number, username, email))
            {
                // Do something.
            }
            else
            {
                HttpContext.Current.Response.Write("a");
            }
        }

        // Change Password.
        protected void PasswordClick_Click(object sender, EventArgs e)
        {
            string pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(Password2Value.Value.ToString(), "MD5");
            LoginBussiness ob = new LoginBussiness();
            if (ob.UpdatePassword(NumberValue.Value.ToString(), UsernameValue.Value.ToString(), EmailValue.Value.ToString(), pwd))
            {
                Session["ResetPassword"] = "Password Reset";
                Response.Redirect("login");
            }
        }

        // Redirect page when session is not null.
        private void SessionRedirect()
        {
            if (Session["contact"] != null)
                Response.Redirect("contact");
            else if (Session["MissingPeople"] != null)
                Response.Redirect("missing-people-report");
            else if (Session["MissingThing"] != null)
                Response.Redirect("missing-thing-report");
            else if (Session["UnidentifiedPeople"] != null)
                Response.Redirect("unidentified-people-report");
            else if(Session["ReportSighting"] != null)
                Response.Redirect("report-sighting");
            else if (Session["Feedback"] != null)
                Response.Redirect("feedback");
            else
                Response.Redirect("index");
        }

        // Sessions for Page Load Event.
        private void Sessions()
        {
            if (Session["RegisteredSuccessfully"] != null)
                SessionMsg.Visible = true;
            if (Request.Url.AbsolutePath.EndsWith("Login.aspx"))
                Session.Remove("RegisteredSuccessfully");
        }

        // Messages Visibility
        private void Visibility()
        {
            ErrorMsg.Visible = true;
            SessionMsg.Visible = false;
            SessionC.Visible = false;
            SessionMissingPeople.Visible = false;
            SessionPost.Visible = false;
            SessionFeedback.Visible = false;
            FavouritePost.Visible = false;
        }

        // Session for Contact Us page.
        private void SessionMessagesShow()
        {
            if(Session["contact"] != null)
                SessionC.Visible = true;
            if (Session["MissingPeople"] != null)
                SessionMissingPeople.Visible = true;
            if (Session["MissingThing"] != null)
                SessionMissingPeople.Visible = true;
            if(Session["UnidentifiedPeople"] != null)
                SessionMissingPeople.Visible = true;
            if(Session["ReportSighting"] != null)
                SessionMissingPeople.Visible = true;
            if (Session["FullPost"] != null)
                SessionPost.Visible = true;
            if (Session["Feedback"] != null)
                SessionFeedback.Visible = true;
            if (Session["Favourite"] != null )
                FavouritePost.Visible = true;
        }
    }
}