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
    public class ContactDB
    {
        int Registration_ID;
        string strCon;
        SqlConnection con;

        // Connection to Database.
        public void connection()
        {
            strCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            con = new SqlConnection(strCon);
            con.Open();
        }

        public void GetUserID(string Username)
        {
            connection();
            SqlCommand cmd = new SqlCommand("SelectRegistrationIDforMissinsgPeople", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", Username);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Registration_ID = Convert.ToInt16(reader["RegistrationID"]);
                reader.Close();
                con.Close();
            }
        }

        // To Insert Data in Contact Us Table.
        public bool InsertContactDataToDatabase(string subject, string email, long contact, string message, string date, string time)
        {
            connection();
            SqlCommand InsertData = new SqlCommand("InsertDataForContactUsPage", con);
            InsertData.CommandType = CommandType.StoredProcedure;
            InsertData.Parameters.AddWithValue("@RegistrationID", Registration_ID);
            InsertData.Parameters.AddWithValue("@email", email);
            InsertData.Parameters.AddWithValue("@contact", contact);
            InsertData.Parameters.AddWithValue("@subject", subject);
            InsertData.Parameters.AddWithValue("@message", message);
            InsertData.Parameters.AddWithValue("@date", date);
            InsertData.Parameters.AddWithValue("@time", time);
            InsertData.ExecuteNonQuery();
            con.Close();
            return true;
        }

        // Select Contact Page Data For Admin Panel.
        public List<ContactUsPageObjects> SelectContactPageDataForAdminPanel()
        {
            List<ContactUsPageObjects> ls = new List<ContactUsPageObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectAllDataOfContactUs", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            while(reader.Read())
            {
                ContactUsPageObjects ob = new ContactUsPageObjects();
                ob.ContactID = Convert.ToInt32(reader["ContactID"]);
                ob.RegistrationID = Convert.ToInt32(reader["RegistrationID"]);
                ob.Email = reader["Email"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.Subject = reader["Subject"].ToString();
                ob.Message = reader["Message"].ToString();
                ob.Date = reader["Date"].ToString();
                ob.Time = reader["Time"].ToString();
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }

        // Delete Contact data From Admin Panel.
        public bool DeleteUserContacts(int ContactID)
        {
            connection();
            SqlCommand DeleteData = new SqlCommand("DeleteUsersContact", con);
            DeleteData.CommandType = CommandType.StoredProcedure;
            DeleteData.Parameters.AddWithValue("@ContactID", ContactID);
            DeleteData.ExecuteNonQuery();
            return true;
        }

        // Select Total Number of Posts From Missing People For Admin Panel.
        public List<ContactUsPageObjects> TotalContactPosts()
        {
            List<ContactUsPageObjects> ls = new List<ContactUsPageObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectContactsCountPosts", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            if (reader.Read())
            {
                ContactUsPageObjects ob = new ContactUsPageObjects();
                ob.ContactID = Convert.ToInt32(reader["ContactID"]);
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }
    }
}
