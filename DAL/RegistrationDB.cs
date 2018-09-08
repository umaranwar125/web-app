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
    public class RegistrationDB
    {
        string strCon;
        SqlConnection con;
        
        // Connection to Database.
        public void connection()
        {
            strCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            con = new SqlConnection(strCon);
            con.Open();
        }

        // Insert Registration Data.
        public bool InsertRegisterationData(string FullName, string Username, string Email, string Password, string Contact, string Age, string Gander, string Image)
        {
            connection();
            SqlCommand InsertCMD = new SqlCommand("InsertDataForRegistration", con);
            InsertCMD.CommandType = CommandType.StoredProcedure;
            InsertCMD.Parameters.AddWithValue("@Name", FullName);
            InsertCMD.Parameters.AddWithValue("@username", Username);
            InsertCMD.Parameters.AddWithValue("@Email", Email);
            InsertCMD.Parameters.AddWithValue("@Password", Password);
            InsertCMD.Parameters.AddWithValue("@Contact", Contact);
            InsertCMD.Parameters.AddWithValue("@Age", Age);
            InsertCMD.Parameters.AddWithValue("@joindate", DateTime.Today.ToString("dd MMM yyyy"));
            InsertCMD.Parameters.AddWithValue("@Gander", Gander);
            InsertCMD.Parameters.AddWithValue("@Image", Image);
            InsertCMD.ExecuteNonQuery();
            con.Close();
            return true;
        }

        // Checking UserName And Email Existance in Registration.
        public bool CheckingUserNameDuringRegistration(string Username, string Email)
        {
            connection();
            SqlCommand CheckingUsername = new SqlCommand("CheckingUsernameAndEmailExistance", con);
            CheckingUsername.CommandType = CommandType.StoredProcedure;
            CheckingUsername.Parameters.AddWithValue("@User", Username);
            CheckingUsername.Parameters.AddWithValue("@Email", Email);
            SqlDataReader reader = CheckingUsername.ExecuteReader();
            if (reader.Read())
            {
                con.Close();
                reader.Close();
                return true;
            }
            else 
            {
                con.Close();
                reader.Close();
                return false;
            }
        }

        // Select Registration Data From Databse.
        public List<RegistrationObjects> SelectRegistrationData(string username)
        {
            List<RegistrationObjects> ls = new List<RegistrationObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectRegistrationData", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = SelectData.ExecuteReader();
            if(reader.Read())
            {
                RegistrationObjects ob = new RegistrationObjects();
                ob.RegistrationID = Convert.ToInt16(reader["RegistrationID"]);
                ob.FullName = reader["FullName"].ToString();
                ob.Nickname = reader["Nickname"].ToString();
                ob.Username = reader["Username"].ToString();
                ob.Email = reader["Email"].ToString();
                ob.Password = reader["Password"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.Age = reader["Age"].ToString();
                ob.About = reader["About"].ToString();
                ob.JoinDate = Convert.ToDateTime(reader["JoinDate"]).ToString();
                ob.Gander = reader["Gander"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }

        // Select Registration Data From Databse For Admin Panel.
        public List<RegistrationObjects> SelectRegistrationDataForAdminPanel()
        {
            List<RegistrationObjects> ls = new List<RegistrationObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectAllDataOfRegistration", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            while (reader.Read())
            {
                RegistrationObjects ob = new RegistrationObjects();
                ob.RegistrationID = Convert.ToInt16(reader["RegistrationID"]);
                ob.FullName = reader["FullName"].ToString();
                ob.Nickname = reader["Nickname"].ToString();
                ob.Username = reader["Username"].ToString();
                ob.Email = reader["Email"].ToString();
                ob.Password = reader["Password"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.Age = reader["Age"].ToString();
                ob.About = reader["About"].ToString();
                ob.JoinDate = Convert.ToDateTime(reader["JoinDate"]).ToString();
                ob.Gander = reader["Gander"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }

        // Checking Email Existance for User Prfile.
        public bool CheckingEmail(string username, string Email)
        {
            connection();
            SqlCommand CheckData = new SqlCommand("SelectEmailForUserProfile", con);
            CheckData.CommandType = CommandType.StoredProcedure;
            CheckData.Parameters.AddWithValue("@Email", Email);
            CheckData.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = CheckData.ExecuteReader();
            if (reader.Read())
            {
                con.Close();
                reader.Close();
                return true;
            }
            else
            {
                con.Close();
                reader.Close();
                return false;
            }
        }

        // Checking Old password Existance for User Prfile.
        public bool CheckingPassword(string username, string password)
        {
            connection();
            SqlCommand CheckData = new SqlCommand("SelectOldPasswordForUserProfile", con);
            CheckData.CommandType = CommandType.StoredProcedure;
            CheckData.Parameters.AddWithValue("@username", username);
            CheckData.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = CheckData.ExecuteReader();
            if (reader.Read())
            {
                con.Close();
                reader.Close();
                return false;
            }
            else
            {
                con.Close();
                reader.Close();
                return true;
            }
        }

        // Update User Profile.
        public bool UpdateUserProfile(string username, string name, string about, string email_addr, string contact_num, string pass, string img)
        {
            connection();
            SqlCommand UpdateData = new SqlCommand("UpdateUserProfile", con);
            UpdateData.CommandType = CommandType.StoredProcedure;
            UpdateData.Parameters.AddWithValue("@username", username);
            UpdateData.Parameters.AddWithValue("@Full_Name", name);
            UpdateData.Parameters.AddWithValue("@About", about);
            UpdateData.Parameters.AddWithValue("@Email_addr", email_addr);
            UpdateData.Parameters.AddWithValue("@Contact_num", contact_num);
            UpdateData.Parameters.AddWithValue("@password", pass);
            UpdateData.Parameters.AddWithValue("@Image", img);
            UpdateData.ExecuteNonQuery();
            con.Close();
            return true;
        }

        // Select Total Number of Posts From Missing People For Admin Panel.
        public List<RegistrationObjects> TotalRegisterationPosts()
        {
            List<RegistrationObjects> ls = new List<RegistrationObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectRegisteredCountPosts", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            if (reader.Read())
            {
                RegistrationObjects ob = new RegistrationObjects();
                ob.RegistrationID = Convert.ToInt32(reader["RegistrationID"]);
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }

        // Search Registeration Data.
        public List<RegistrationObjects> SearchRegisterationData(string Name)
        {
            List<RegistrationObjects> ls = new List<RegistrationObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectRegisterationDataForAdminPanelSearch", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@Name", Name);
            SqlDataReader reader = SelectData.ExecuteReader();
            while (reader.Read())
            {
                RegistrationObjects ob = new RegistrationObjects();
                ob.RegistrationID = Convert.ToInt16(reader["RegistrationID"]);
                ob.FullName = reader["FullName"].ToString();
                ob.Nickname = reader["Nickname"].ToString();
                ob.Username = reader["Username"].ToString();
                ob.Email = reader["Email"].ToString();
                ob.Password = reader["Password"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.Age = reader["Age"].ToString();
                ob.About = reader["About"].ToString();
                ob.JoinDate = Convert.ToDateTime(reader["JoinDate"]).ToString();
                ob.Gander = reader["Gander"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }
    }
}
