using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BOL;

namespace DAL
{
    public class AdminProfileDB
    {
        string conStr;
        SqlConnection con;
        int AdminId;

        // Connection to Databse.
        private void connection()
        {
            conStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            con = new SqlConnection(conStr);
            con.Open();
        }

        // Get Admin Login ID.
        public void GetAdminID(string Username)
        {
            connection();
            SqlCommand GetAdminID = new SqlCommand("SelectAdminIDAndUsername", con);
            GetAdminID.CommandType = CommandType.StoredProcedure;
            GetAdminID.Parameters.AddWithValue("@Username", Username);
            SqlDataReader reader = GetAdminID.ExecuteReader();
            if(reader.Read())
            {
                AdminId = Convert.ToInt32(reader["AdminID"]);
                con.Close();
                reader.Close();
            }
        }

        // Update Admin Profile.
        public bool UpdateAdminProfile(int ID, string FullName, string Title, string Email, string Qualification, string ContactNumber, string BioDescription, string Image)
        {
            connection();
            SqlCommand UpdateData = new SqlCommand("UpdateAdminProfile", con);
            UpdateData.CommandType = CommandType.StoredProcedure;
            UpdateData.Parameters.AddWithValue("@AdminID", AdminId);
            UpdateData.Parameters.AddWithValue("@FullName", FullName);
            UpdateData.Parameters.AddWithValue("@Title", Title);
            UpdateData.Parameters.AddWithValue("@Email", Email);
            UpdateData.Parameters.AddWithValue("@Qualification", Qualification);
            UpdateData.Parameters.AddWithValue("@ContactNumber", ContactNumber);
            UpdateData.Parameters.AddWithValue("@BioDescription", BioDescription);
            UpdateData.Parameters.AddWithValue("@Image", Image);
            UpdateData.ExecuteNonQuery();
            return true;
        }
    
        // Select Admin Profile Page Data.
        public List<AdminProfilePageObjects> SelectAdminProfileData(int ID)
        {
            List<AdminProfilePageObjects> ls = new List<AdminProfilePageObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectALLDataOfAdminProfile", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@AdminID", AdminId);
            SqlDataReader reader = SelectData.ExecuteReader();
            if(reader.Read())
            {
                AdminProfilePageObjects ob = new AdminProfilePageObjects();
                ob.AdminID = Convert.ToInt32(reader["AdminID"]);
                ob.FullName = reader["FullName"].ToString();
                ob.Title = reader["Title"].ToString();
                ob.Email = reader["Email"].ToString();
                ob.Qualification = reader["Qualification"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.BioDescription = reader["BioDescription"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }
    }
}
