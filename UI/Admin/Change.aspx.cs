using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;
using System.Configuration;
using BOL;
using BLL;

namespace UI.Admin
{
    public partial class ChangeUsername : System.Web.UI.Page
    {
        int AdminID;
        public List<AdminProfilePageObjects> DisplayProfileData;
        AdminProfileBussiness ob1 = new AdminProfileBussiness();
        AdminLoginBussiness ob = new AdminLoginBussiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminUsername"] == null)
                Response.Redirect("Login.aspx");
            ob1.GetAdminID(Session["AdminUsername"].ToString());
            DisplayProfileData = ob1.SelectAdminProfileData(AdminID);
            GetActiveAdminID(Session["AdminUsername"].ToString());
            if (AdminID != 2)
            {
                AddAdminUser.Attributes["class"] = "disabled";
                DeleteAdminUser.Attributes["class"] = "disabled";
            }
        }

        protected void AdminLoginUpdate_Click(object sender, EventArgs e)
        {
            string Oldpwd1 = FormsAuthentication.HashPasswordForStoringInConfigFile(OldPasswordOne.Value.ToString(), "MD5");
            string Oldpwd2 = FormsAuthentication.HashPasswordForStoringInConfigFile(OldPasswordTwo.Value.ToString(), "MD5");
            string Newpwd1 = FormsAuthentication.HashPasswordForStoringInConfigFile(NewPasswordOne.Value.ToString(), "MD5");
            string Newpwd2 = FormsAuthentication.HashPasswordForStoringInConfigFile(NewPasswordTwo.Value.ToString(), "MD5");
            ob.GetAdminID(Session["AdminUsername"].ToString());
            if (ob.AdminLoginMethodWithAdminID(AdminID, OldUsername.Value.ToString(), Oldpwd1, Oldpwd2))
            {
                if (ob.UpdateAdminLoginMethod(AdminID, NewUsername.Value.ToString(), Newpwd1, Newpwd2))
                {
                    Session["AdminUsername"] = NewUsername.Value;
                    Match.Visible = true;
                    NotMatch.Visible = false;
                }
            }
            else
                NotMatch.Visible = true;
        }
        // Getting Active Admin ID.
        public void GetActiveAdminID(string Username)
        {
            string constr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand GetID = new SqlCommand("SelectAdminIDAndUsername", con);
            GetID.CommandType = System.Data.CommandType.StoredProcedure;
            GetID.Parameters.AddWithValue("@Username", Username);
            SqlDataReader reader = GetID.ExecuteReader();
            if (reader.Read())
            {
                AdminID = Convert.ToInt16(reader["AdminID"]);
                Session["AdminID"] = AdminID;
                con.Close();
                reader.Close();
            }
        }
    }
}