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
    public class FeedbackDB
    {
        string conStr;
        SqlConnection con;
        int Registration_ID;

        // Database Connection.
        private void connection()
        {
            conStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            con = new SqlConnection(conStr);
            con.Open();
        }

        // Get UserId.
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

        // Insert Feedback Data.
        public bool InsertFeedbackData(int R_ID, string Visit, string Need, string Find, string Opinion, string Likelihood, string Suggestions)
        {
            connection();
            SqlCommand InsertData = new SqlCommand("InsertDataInFeedback", con);
            InsertData.CommandType = CommandType.StoredProcedure;
            InsertData.Parameters.AddWithValue("@registrationID", Registration_ID);
            InsertData.Parameters.AddWithValue("@visit", Visit);
            InsertData.Parameters.AddWithValue("@Need", Need);
            InsertData.Parameters.AddWithValue("@Find", Find);
            InsertData.Parameters.AddWithValue("@Opinion", Opinion);
            InsertData.Parameters.AddWithValue("@Likelihood", Likelihood);
            InsertData.Parameters.AddWithValue("@Suggestion", Suggestions);
            InsertData.ExecuteNonQuery();
            return true;
        }
    
        // Select Feedback Data For Admin Panel.
        public List<FeedbackPageObjects> SelectFeedbackDataForAdminPanel()
        {
            List<FeedbackPageObjects> ls = new List<FeedbackPageObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectAllDataOfFeedback", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            while(reader.Read())
            {
                FeedbackPageObjects ob = new FeedbackPageObjects();
                ob.FeedbackID = Convert.ToInt32(reader["FeedbackID"]);
                ob.RegistrationID = Convert.ToInt32(reader["RegistrationID"]);
                ob.VisitWebsite = reader["VisitWebsite"].ToString();
                ob.FindYourNeed = reader["FindYourNeed"].ToString();
                ob.EasyToFind = reader["EasyToFind"].ToString();
                ob.YourOpinion = reader["YourOpinion"].ToString();
                ob.Likelihood = reader["Likelihood"].ToString();
                ob.Suggestions = reader["Suggestions"].ToString();
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }

        // Select Total Number of Posts From Missing People For Admin Panel.
        public List<FeedbackPageObjects> TotalFeedbacks()
        {
            List<FeedbackPageObjects> ls = new List<FeedbackPageObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectFeedbackCountPosts", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            if (reader.Read())
            {
                FeedbackPageObjects ob = new FeedbackPageObjects();
                ob.FeedbackID = Convert.ToInt32(reader["FeedbackID"]);
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }
    }
}
