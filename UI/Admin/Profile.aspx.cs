using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel.DataAnnotations;
using BLL;
using BOL;

namespace UI.Admin
{
    public partial class Profile : System.Web.UI.Page
    {
        int AdminID;
        public List<AdminProfilePageObjects> DisplayAdminProfile;
        AdminProfileBussiness ob = new AdminProfileBussiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminUsername"] == null)
                Response.Redirect("Login.aspx");
            ob.GetAdminID(Session["AdminUsername"].ToString());
            DisplayAdminProfile = ob.SelectAdminProfileData(AdminID);
            GetActiveAdminID(Session["AdminUsername"].ToString());
            if(AdminID != 2)
            {
                AddAdminUser.Attributes["class"] = "disabled";
                DeleteAdminUser.Attributes["class"] = "disabled";
            }
        }
        
        // Email Validation.
        private bool isValid(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }

        protected void AdminProfileUpdate_Click(object sender, EventArgs e)
        {
            if (isValid(Email.Value.ToString()))
            {
                if (Image.HasFile)
                {
                    string path = Image.FileName.ToString();
                    Image.PostedFile.SaveAs(Server.MapPath(".") + "//Image//" + path);
                    string str = "Image/" + path.ToString();
                    if (ob.UpdateAdminProfile(AdminID, FullName.Value.ToString(), Title.Value.ToString(), Email.Value.ToString(), Qualification.Value.ToString(), Contact.Value.ToString(), Description.Value.ToString(), str))
                    {
                        Response.Redirect("Profile.aspx");
                    }
                }
                else if (!Image.HasFile)
                {
                    Error.Visible = true;
                    EmailFailure.Visible = false;
                }
            }
            else
                EmailFailure.Visible = true;
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
            if(reader.Read())
            {
                AdminID = Convert.ToInt16(reader["AdminID"]);
                Session["AdminID"] = AdminID;
                con.Close();
                reader.Close();
            }
        }
    }
}