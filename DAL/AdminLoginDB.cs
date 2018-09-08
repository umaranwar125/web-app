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
    public class AdminLoginDB
    {
        string conStr;
        SqlConnection con;
        int AdminID;

        // Connection to Databse;
        public void connection()
        {
            conStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            con = new SqlConnection(conStr);
            con.Open();
        }

        //Get Looged in Admin ID.
        public void GetAdminID(string Username)
        {
            connection();
            SqlCommand GetAdminID = new SqlCommand("SelectAdminIDAndUsername", con);
            GetAdminID.CommandType = CommandType.StoredProcedure;
            GetAdminID.Parameters.AddWithValue("@Username", Username);
            SqlDataReader reader = GetAdminID.ExecuteReader();
            if (reader.Read())
            {
                AdminID = Convert.ToInt32(reader["AdminID"]);
                con.Close();
                reader.Close();
            }
        }

        // Admin Login Method.
        public bool AdminLoginMethod(string username, string passwordOne, string passwordTwo)
        {
            connection();
            SqlCommand SelectData = new SqlCommand("SelectDataForAdminLogin", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@Username", username);
            SelectData.Parameters.AddWithValue("@PasswordOne", passwordOne);
            SelectData.Parameters.AddWithValue("@PasswordTwo", passwordTwo);
            SqlDataReader reader = SelectData.ExecuteReader();
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

        // Admin Login Method Along with Admin ID.
        public bool AdminLoginMethodWithAdminID(int ID, string username, string passwordOne, string passwordTwo)
        {
            connection();
            SqlCommand SelectData = new SqlCommand("SelectAllDataOfAdminLogin", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@AdminID", AdminID);
            SelectData.Parameters.AddWithValue("@Username", username);
            SelectData.Parameters.AddWithValue("@PasswordOne", passwordOne);
            SelectData.Parameters.AddWithValue("@PasswordTwo", passwordTwo);
            SqlDataReader reader = SelectData.ExecuteReader();
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

        // Update Admin Login Method.
        public bool UpdateAdminLoginMethod(int ID, string username, string passwordOne, string passwordTwo)
        {
            connection();
            SqlCommand UpdataData = new SqlCommand("UpdateAdminLogin", con);
            UpdataData.CommandType = CommandType.StoredProcedure;
            UpdataData.Parameters.AddWithValue("@AdminID", AdminID);
            UpdataData.Parameters.AddWithValue("@Username", username);
            UpdataData.Parameters.AddWithValue("@PasswordOne", passwordOne);
            UpdataData.Parameters.AddWithValue("@PasswordTwo", passwordTwo);
            UpdataData.ExecuteNonQuery();
            return true;
        }

        // Insert Another Admin.
        public bool InsertAnotherAdmin(string Username, string PasswordOne, string PasswordTwo, string Security, string Answer)
        {
            connection();
            SqlCommand InsertData = new SqlCommand("InsertAnotherAdmin", con);
            InsertData.CommandType = CommandType.StoredProcedure;
            InsertData.Parameters.AddWithValue("@Username", Username);
            InsertData.Parameters.AddWithValue("@PasswordOne", PasswordOne);
            InsertData.Parameters.AddWithValue("@PasswordTwo", PasswordTwo);
            InsertData.Parameters.AddWithValue("@Security", Security);
            InsertData.Parameters.AddWithValue("@Answer", Answer);
            InsertData.ExecuteNonQuery();
            return true;
        }

        // Insert Another Admin Profile.
        public bool InsertAnotherAdminProfile(int ID)
        {
            connection();
            SqlCommand InsertData = new SqlCommand("InsertAdminProfileData", con);
            InsertData.CommandType = CommandType.StoredProcedure;
            InsertData.Parameters.AddWithValue("@AdminID", AdminID);
            InsertData.ExecuteNonQuery();
            return true;
        }

        // Select All Data of Admin.
        public List<AdminLoginPageObjects> SelectAdminLoginData()
        {
            List<AdminLoginPageObjects> ls = new List<AdminLoginPageObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectAdminLoginForDisplay", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            while(reader.Read())
            {
                AdminLoginPageObjects ob = new AdminLoginPageObjects();
                ob.AdminID = Convert.ToInt16(reader["AdminID"]);
                ob.Username = reader["Username"].ToString();
                ob.PasswordOne = reader["PasswordOne"].ToString();
                ob.PasswordTwo = reader["PasswordTwo"].ToString();
                ob.SecurityQuestion = reader["SecurityQuestion"].ToString();
                ob.Answer = reader["Answer"].ToString();
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }

        // Select Admin Username for Forgot Password.
        public bool SelectAdminUsernameForForgot(string username)
        {
            connection();
            SqlCommand SelectData = new SqlCommand("SelectAdminUsernameForForgotPassword", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@Username", username);
            SqlDataReader reader = SelectData.ExecuteReader();
            if (reader.Read())
            {
                con.Close();
                reader.Close();
                return true;
            }
            else
                return false;
        }

        // Select Admin Password One for Forgot Password.
        public bool SelectAdminPasswordOneForForgot(string Password)
        {
            connection();
            SqlCommand SelectData = new SqlCommand("SelectAdminPasswordOneForForgotPassword", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@PasswordOne", Password);
            SqlDataReader reader = SelectData.ExecuteReader();
            if (reader.Read())
            {
                con.Close();
                reader.Close();
                return true;
            }
            else
                return false;
        }

        // Select Admin Username And Password One for Forgot Password.
        public bool SelectAdminUsernamePasswordOneForForgot(string username, string Password)
        {
            connection();
            SqlCommand SelectData = new SqlCommand("SelectAdminUsernamePasswordOneForForgotPassword", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@Username", username);
            SelectData.Parameters.AddWithValue("@PasswordOne", Password);
            SqlDataReader reader = SelectData.ExecuteReader();
            if (reader.Read())
            {
                con.Close();
                reader.Close();
                return true;
            }
            else
                return false;
        }

        // Select Admin Username And Password Two for Forgot Password.
        public bool SelectAdminUsernamePasswordTwoForForgot(string username, string Password)
        {
            connection();
            SqlCommand SelectData = new SqlCommand("SelectAdminUsernamePasswordTwoForForgotPassword", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@Username", username);
            SelectData.Parameters.AddWithValue("@PasswordTwo", Password);
            SqlDataReader reader = SelectData.ExecuteReader();
            if (reader.Read())
            {
                con.Close();
                reader.Close();
                return true;
            }
            else
                return false;
        }

        // Select Admin Username And Security Question And its Answer for Forgot Password.
        public bool SelectAdminUsernameSecurityQuestionForForgot(string username, string securityQ, string answer)
        {
            connection();
            SqlCommand SelectData = new SqlCommand("SelectAdminUsernameSecurityQuestionForForgotPassword", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@Username", username);
            SelectData.Parameters.AddWithValue("@SecurityQ", securityQ);
            SelectData.Parameters.AddWithValue("@Answer", answer);
            SqlDataReader reader = SelectData.ExecuteReader();
            if (reader.Read())
            {
                con.Close();
                reader.Close();
                return true;
            }
            else
                return false;
        }

        // Update Password One and Password Two From Forgot Password.
        public bool UpdatePasswordFromForgotPassword(string username, string passwordOne, string passwordTwo)
        {
            connection();
            SqlCommand SelectData = new SqlCommand("UpdatePasswordsFromForgotPassword", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@Username", username);
            SelectData.Parameters.AddWithValue("@PasswordOne", passwordOne);
            SelectData.Parameters.AddWithValue("@PasswordTwo", passwordTwo);
            SelectData.ExecuteNonQuery();
            return true;
        }

        // Select All data of Admin Login to display in table.
        public List<AdminLoginPageObjects> SelectAllDataOfAdminLoginForDisplay()
        {
            List<AdminLoginPageObjects> ls = new List<AdminLoginPageObjects>();
            connection();
            SqlCommand Selectdata = new SqlCommand("SelectAdminLoginForDisplay", con);
            Selectdata.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = Selectdata.ExecuteReader();
            while(reader.Read())
            {
                AdminLoginPageObjects ob = new AdminLoginPageObjects();
                ob.AdminID = Convert.ToInt32(reader["AdminID"]);
                ob.Username = reader["Username"].ToString();
                ob.PasswordOne = reader["PasswordOne"].ToString();
                ob.PasswordTwo = reader["PasswordTwo"].ToString();
                ob.SecurityQuestion = reader["SecurityQuestion"].ToString();
                ob.Answer = reader["Answer"].ToString();
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }

        // Delete Admin User Profile.
        public bool DeleteAdminUserProfile(int AdminId)
        {
            connection();
            SqlCommand DeleteData = new SqlCommand("DeleteAdminUserProfile", con);
            DeleteData.CommandType = CommandType.StoredProcedure;
            DeleteData.Parameters.AddWithValue("@AdminId", AdminId);
            DeleteData.ExecuteNonQuery();
            return true;
        }

        // Delete Admin User.
        public bool DeleteAdminUser(int AdminId)
        {
            connection();
            SqlCommand DeleteData = new SqlCommand("DeleteAdminUser", con);
            DeleteData.CommandType = CommandType.StoredProcedure;
            DeleteData.Parameters.AddWithValue("@AdminId", AdminId);
            DeleteData.ExecuteNonQuery();
            return true;
        }

        
    }
}
