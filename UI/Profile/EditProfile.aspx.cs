using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BOL;
using BLL;

namespace UI.Profile
{
    public partial class EditProfile : System.Web.UI.Page
    {
        string Full_name;
        string email;
        string contact;
        string about;
        string image;
        public List<RegistrationObjects> DisplayUserProfile;
        UserProfileBussiness ProfileOB = new UserProfileBussiness();
        RegistrationBussiness ob = new RegistrationBussiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            DisplayUser();
            SelectRegistrationData(Session["username"].ToString());
        }

        // Display User Method.
        private void DisplayUser()
        {
            DisplayUserProfile = ob.SelectRegistrationData(Session["username"].ToString());
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
                Full_name = reader["FullName"].ToString();
                email = reader["Email"].ToString();
                contact = reader["ContactNumber"].ToString();
                about = reader["About"].ToString();
                image = reader["Image"].ToString();
            }
            
            con.Close();
        }
    }
}