using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BOL;
using BLL;

namespace UI.Admin
{
    public partial class DeleteAdmin : System.Web.UI.Page
    {
        int AdminID;
        public List<AdminProfilePageObjects> DisplayAdminProfile;
        public List<AdminLoginPageObjects> DisplayAdminLoginData;
        AdminProfileBussiness ob = new AdminProfileBussiness();
        AdminLoginBussiness ob1 = new AdminLoginBussiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminUsername"] == null)
                Response.Redirect("Login.aspx");
            ob.GetAdminID(Session["AdminUsername"].ToString());
            DisplayAdminProfile = ob.SelectAdminProfileData(AdminID);
            DisplayAdminLoginData = ob1.SelectAllDataOfAdminLoginForDisplay();
            GetActiveAdminID(Session["AdminUsername"].ToString());
            if (AdminID != 2)
            {
                AddAdminUser.Attributes["class"] = "disabled";
                DeleteAdminUser.Attributes["class"] = "disabled";
            }
            if (Convert.ToInt16(Session["AdminID"]) != 2)
                Response.Redirect("Profile.aspx");
            DeleteADmin();
        }

        // Delete ADmin user and Profile.
        public void DeleteADmin()
        {
            if (Request.QueryString["AdminID"] != null)
            {
                if (ob1.DeleteAdminUserProfile(Convert.ToInt32(Request.QueryString["AdminID"])))
                {
                    ob1.DeleteAdminUser(Convert.ToInt32(Request.QueryString["AdminID"]));
                    Response.Redirect("DeleteAdmin.aspx");
                }
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