using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.Security;
using System.Web.Script.Services;
using BLL;

namespace UI.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UpdatedSuccessfully"] != null)
                Updated.Visible = true;
            else if(Session["UpdatedSuccessfully"] == null)
                Updated.Visible = false;
        }

        // Admin Login.
        [WebMethod]
        public static void LoginMethod(string user, string pwd1, string pwd2)
        {
            AdminLoginBussiness ob = new AdminLoginBussiness();
            string Password1 = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd1, "MD5");
            string Password2 = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd2, "MD5");
            if (ob.AdminLoginMethod(user, Password1, Password2))
            {
                HttpContext.Current.Session["AdminUsername"] = user;
                HttpContext.Current.Session.Remove("UpdatedSuccessfully");
            }
            else
            {
                HttpContext.Current.Session.Remove("UpdatedSuccessfully");
                HttpContext.Current.Response.Redirect("Login.aspx");
            }
        }

        // Username Check.
        [WebMethod]
        public static void UsernameForgotPageMethod(string Forgotuser)
        {
            AdminLoginBussiness ob = new AdminLoginBussiness();
            if (ob.SelectAdminUsernameForForgot(Forgotuser))
            {
                // Do Something.
            }
            else
                HttpContext.Current.Response.Write("a");
        }

        // Username And Password One Check.
        [WebMethod]
        public static void UsernameAndPasswordOneCheckForgotPageMethod(string userCheck, string pwdCheck)
        {
            AdminLoginBussiness ob = new AdminLoginBussiness();
            string Password1 = FormsAuthentication.HashPasswordForStoringInConfigFile(pwdCheck, "MD5");
            if(ob.SelectAdminUsernamePasswordOneForForgot(userCheck, Password1))
            {
                //DO something
            }
            else
                HttpContext.Current.Response.Write("a"); 
        }

        // Username And Password Two Check.
        [WebMethod]
        public static void UsernameAndPasswordTwoCheckForgotPageMethodAjax(string userCheck, string pwdCheck)
        {
            AdminLoginBussiness ob = new AdminLoginBussiness();
            string Password2 = FormsAuthentication.HashPasswordForStoringInConfigFile(pwdCheck, "MD5");
            if (ob.SelectAdminUsernamePasswordOneForForgot(userCheck, Password2))
            {
                //DO something
            }
            else
                HttpContext.Current.Response.Write("a");
        }

        // Username And Security Question and Answer Check.
        [WebMethod]
        public static void UsernameAndPasswordTwoCheckForgotPageMethod(string userCheck, string security, string answer)
        {
            AdminLoginBussiness ob = new AdminLoginBussiness();
            if (ob.SelectAdminUsernameSecurityQuestionForForgot(userCheck, security, answer))
            {
                //DO something
            }
            else
                HttpContext.Current.Response.Write("a");
        }

        // Update Password fter got success from Forgot Password.
        protected void ForgotPasswordSucceeded_Click(object sender, EventArgs e)
        {
            AdminLoginBussiness ob = new AdminLoginBussiness();
            string Password1 = FormsAuthentication.HashPasswordForStoringInConfigFile(NewsPassword1.Value.ToString(), "MD5");
            string Password2 = FormsAuthentication.HashPasswordForStoringInConfigFile(NewsPassword2.Value.ToString(), "MD5");
            if(ob.UpdatePasswordFromForgotPassword(usernameCheck.Value.ToString(), Password1, Password2))
            {
                Session["UpdatedSuccessfully"] = "Congratz";
                Response.Redirect("Login.aspx");
            }
        }

    }
}