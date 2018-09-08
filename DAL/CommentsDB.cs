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
    public class CommentsDB
    {
        string conStr;
        string result;
        SqlConnection con;

        // Connection to Databse;
        public void connection()
        {
            conStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            con = new SqlConnection(conStr);
            con.Open();
        }

        // Select ALL Comments
        public List<CommentObjects> SelectAllComments()
        {
            List<CommentObjects> ls = new List<CommentObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectAllCommentsForAdmin", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            while(reader.Read())
            {
                CommentObjects ob = new CommentObjects();
                ob.CommentID = Convert.ToInt32(reader["CommentID"]);
                ob.RegistrationID = Convert.ToInt32(reader["RegistrationID"]);
                if (reader["PeopleID"] == DBNull.Value)
                    result = string.Empty;
                else
                    ob.PeopleID = Convert.ToInt32(reader["PeopleID"]);
                if (reader["AutoMobile"] == DBNull.Value)
                    result = string.Empty;
                else
                    ob.AutoMobileID = Convert.ToInt32(reader["AutoMobile"]);
                if (reader["Mobile"] == DBNull.Value)
                    result = string.Empty;
                else
                    ob.MobileID = Convert.ToInt32(reader["Mobile"]);
                if (reader["CNIC"] == DBNull.Value)
                    result = string.Empty;
                else
                    ob.CnicID = Convert.ToInt32(reader["CNIC"]);
                if (reader["UnidentifiedID"] == DBNull.Value)
                    result = string.Empty;
                else
                    ob.UnidentifiedID = Convert.ToInt32(reader["UnidentifiedID"]);
                ob.FullName = reader["FullName"].ToString();
                ob.Message = reader["Message"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }

        // Delete Comments
        public bool DeletComment(int CommentID)
        {
            connection();
            SqlCommand DeleteData = new SqlCommand("DeleteCommentFromAdmin", con);
            DeleteData.CommandType = CommandType.StoredProcedure;
            DeleteData.Parameters.AddWithValue("@CommentID", CommentID);
            DeleteData.ExecuteNonQuery();
            con.Close();
            return true;
        }

        // Select Total Number of Comments From Comments Table For Admin Panel.
        public List<CommentObjects> TotalComments()
        {
            List<CommentObjects> ls = new List<CommentObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectCommentsCountPosts", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            if (reader.Read())
            {
                CommentObjects ob = new CommentObjects();
                ob.CommentID = Convert.ToInt32(reader["CommentID"]);
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }
    }
}
