using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BOL;
using BLL;

namespace UI.Profile
{
    public partial class MyEditProfile : System.Web.UI.Page
    {
        string full_name;
        string email_address;
        string contact_number;
        string about_you;
        public List<RegistrationObjects> DisplayUserData;
        UserProfileBussiness obj = new UserProfileBussiness();
        RegistrationBussiness ob = new RegistrationBussiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
                Response.Redirect("/Login.aspx");
            DisplayUser();
            Sessions();
            SelectRegistrationData(Session["username"].ToString());
            if(!IsPostBack)
            {
                Session.Remove("CongratzSession");
                Session.Remove("EmailSession");
                Session.Remove("PasswordSession");
            }
        }

        // Sessions.
        private void Sessions()
        {
            if (Session["CongratzSession"] != null)
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>displayCongratsMessage();</script>");
            if (Session["EmailSession"] != null)
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>displayEmailMessage();</script>");
            if (Session["PasswordSession"] != null)
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>displayPasswordMessage();</script>");
        }

        // Update Profile.
        protected void UpdateNow_Click(object sender, EventArgs e)
        {
            string new_pas = FormsAuthentication.HashPasswordForStoringInConfigFile(new_p.Value.ToString(), "MD5");
            string con_pas = FormsAuthentication.HashPasswordForStoringInConfigFile(con_p.Value.ToString(), "MD5");
            string old_pas = FormsAuthentication.HashPasswordForStoringInConfigFile(old_p.Value.ToString(), "MD5");

            if(ob.CheckingEmail(Session["username"].ToString(), email_a.Value.ToString()))
            {
                Session["EmailSession"] = "EmailSession";
                Response.Redirect("MyEditProfile.aspx");
            }
            else
            {
                if (ob.CheckingPassword(Session["username"].ToString(), old_pas))
                {
                    Session["PasswordSession"] = "PasswordSession";
                    Response.Redirect("MyEditProfile.aspx");
                }
                else 
                {
                    if (img.HasFile)
                    {
                        string path = img.FileName.ToString();
                        img.PostedFile.SaveAs(Server.MapPath("~") + "//Image//" + path);
                        string str = "Image/" + path.ToString();
                        if (ob.UpdateUserProfile(Session["username"].ToString(), Full_N.Value.ToString(), Titl.Value.ToString(), email_a.Value.ToString(), contact_n.Value.ToString(), con_pas, str))
                        {
                            Session["CongratzSession"] = "CongratzSession";
                            Response.Redirect("MyEditProfile.aspx");
                        }
                    }
                    else if (!img.HasFile)
                    {
                        if (ob.UpdateUserProfile(Session["username"].ToString(), Full_N.Value.ToString(), Titl.Value.ToString(), email_a.Value.ToString(), contact_n.Value.ToString(), con_pas, "Image/facebook-avatar.jpg"))
                        {
                            Session["CongratzSession"] = "CongratzSession";
                            Response.Redirect("MyEditProfile.aspx");
                        }
                    }
                }
            }
        }

        // Display User Method.
        private void DisplayUser()
        {
            DisplayUserData = ob.SelectRegistrationData(Session["username"].ToString());
        }

        // Select Registration Data From Databse.
        public void SelectRegistrationData(string username)
        {
            string strCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            SqlCommand SelectData = new SqlCommand("SelectRegistrationData", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = SelectData.ExecuteReader();
            if (reader.Read())
            {
                full_name = reader["FullName"].ToString();
                email_address = reader["Email"].ToString();
                contact_number = reader["ContactNumber"].ToString();
                about_you = reader["About"].ToString();
            }
            Full_N.Attributes.Add("placeholder", full_name);
            email_a.Attributes.Add("placeholder", email_address);
            contact_n.Attributes.Add("placeholder", contact_number);
            Titl.Attributes.Add("placeholder", about_you);
            con.Close();
        }
    }
}