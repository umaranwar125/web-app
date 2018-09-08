using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;
using System.Configuration;
using BLL;
using BOL;

namespace UI.Admin
{
    public partial class AddAdmin : System.Web.UI.Page
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
            if (Convert.ToInt16(Session["AdminID"]) != 2)
            {
                Response.Redirect("Profile.aspx");
            }
        }


        protected void InsertAdmin_Click(object sender, EventArgs e)
        {
            string pwd1 = FormsAuthentication.HashPasswordForStoringInConfigFile(PasswordOne.Value.ToString(), "MD5");
            string pwd2 = FormsAuthentication.HashPasswordForStoringInConfigFile(PasswordTwo.Value.ToString(), "MD5"); 
            if(Qualification.SelectedIndex != 0)
            {
                if(ob.InsertAnotherAdmin(Username.Value.ToString(), pwd1, pwd2, Qualification.Value.ToString(), SecurityAnswer.Value.ToString()))
                {
                    ob.GetAdminID(Username.Value.ToString());
                    ob.InsertAnotherAdminProfile(AdminID);
                    Successfull.Visible = true;
                    Error.Visible = false;
                }
            }
            else
            {
                Error.Visible = true;
            }
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