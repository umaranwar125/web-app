using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class LoginDB
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

        // Login Method.
        public bool LoginMethod(string username, string password)
        {
            connection();
            SqlCommand LoginSelect = new SqlCommand("SelectDataForLogin", con);
            LoginSelect.CommandType = CommandType.StoredProcedure;
            LoginSelect.Parameters.AddWithValue("@username", username);
            LoginSelect.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = LoginSelect.ExecuteReader();
            if(reader.Read())
            {
                reader.Close();
                con.Close();
                return true;
            }
            else
            {
                reader.Close();
                con.Close();
                return false;
            }
        }

        // Checking Username.
        public bool CheckUsername(string username)
        {
            connection();
            SqlCommand SelectData = new SqlCommand("SelectUsernameForModifyPassword", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@Username", username);
            SqlDataReader reader = SelectData.ExecuteReader();
            if(reader.Read())
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

        // Checking Email.
        public bool CheckEmail(string email)
        {
            connection();
            SqlCommand SelectData = new SqlCommand("SelectEmailForModifyPassword", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@Email", email);
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

        // Checking Number.
        public bool CheckNumber(string number, string username, string email)
        {
            connection();
            SqlCommand SelectData = new SqlCommand("SelectNumberForModifyPassword", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@Number", number);
            SelectData.Parameters.AddWithValue("@username", username);
            SelectData.Parameters.AddWithValue("@Email", email);
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

        // Update Password.
        public bool UpdatePassword(string number, string username, string email, string password)
        {
            connection();
            SqlCommand SelectData = new SqlCommand("UpdatePasswordForUser", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@Number", number);
            SelectData.Parameters.AddWithValue("@username", username);
            SelectData.Parameters.AddWithValue("@Email", email);
            SelectData.Parameters.AddWithValue("@Password", password);
            SelectData.ExecuteNonQuery();
            con.Close();
            return true;
        }
    }
}
