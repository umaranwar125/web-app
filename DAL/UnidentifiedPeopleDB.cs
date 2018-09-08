using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using BOL;

namespace DAL
{
    public class UnidentifiedPeopleDB
    {
        int Registration_ID;
        string conStr;
        SqlConnection con;

        // Connection to Database.
        public void connection()
        {
            conStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            con = new SqlConnection(conStr);
            con.Open();
        }

        // Get  User Registration ID.
        public void UserRegistrationID(string username)
        {
            connection();
            SqlCommand GetUserID = new SqlCommand("SelectRegistrationIDforMissinsgPeople", con);
            GetUserID.CommandType = CommandType.StoredProcedure;
            GetUserID.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = GetUserID.ExecuteReader();
            if(reader.Read())
            {
                Registration_ID = Convert.ToInt16(reader["RegistrationID"]);
                reader.Close();
                con.Close();
            }
       }

        // Insert Data of UnidentifiedPeople into Databse.
        public bool UnidetifiedPeopleDataInsertion(int R_ID, string Reference, string FullName, string GuardianName, string Contact, string Religion, string Age, string Unique, string FoundPlace, string Language, string ClothColor, string EyesColor, string Description, string Gander, string Image)
        {
            connection();
            SqlCommand InsertData = new SqlCommand("InsertDataIntoUnidentidiedPeople", con);
            InsertData.CommandType = CommandType.StoredProcedure;
            InsertData.Parameters.AddWithValue("@RegistrationID", Registration_ID);
            InsertData.Parameters.AddWithValue("@Reference", Reference);
            InsertData.Parameters.AddWithValue("@FullNAme", FullName);
            InsertData.Parameters.AddWithValue("@FatherGuardianName", GuardianName);
            InsertData.Parameters.AddWithValue("@ContactNumber", Contact);
            InsertData.Parameters.AddWithValue("@Religion", Religion);
            InsertData.Parameters.AddWithValue("@Age", Age);
            InsertData.Parameters.AddWithValue("@Unique", Unique);
            InsertData.Parameters.AddWithValue("@FoundPlace", FoundPlace);
            InsertData.Parameters.AddWithValue("@Language", Language);
            InsertData.Parameters.AddWithValue("@ClothColor", ClothColor);
            InsertData.Parameters.AddWithValue("@EyeColor", EyesColor);
            InsertData.Parameters.AddWithValue("@Description", Description);
            InsertData.Parameters.AddWithValue("@Gander", Gander);
            InsertData.Parameters.AddWithValue("@Image", Image);
            InsertData.ExecuteNonQuery();
            return true;
        }

        // Approve Unidentified People post from Admin Panel.
        public bool UpdateUnidentifiedPeopleStatus(int UnidentifiedId)
        {
            connection();
            SqlCommand UpdateStatus = new SqlCommand("UpdateUnidentifiedPeopleToApproved", con);
            UpdateStatus.CommandType = CommandType.StoredProcedure;
            UpdateStatus.Parameters.AddWithValue("@UnidentifiedID", UnidentifiedId);
            UpdateStatus.ExecuteNonQuery();
            return true;
        }

        // Delete Unidentified post from Admin Panel.
        public bool DeleteUnidentifiedPeoplePost(int UnidentifiedId)
        {
            connection();
            SqlCommand UpdateStatus = new SqlCommand("DeleteUnidentifiedPeoplePost", con);
            UpdateStatus.CommandType = CommandType.StoredProcedure;
            UpdateStatus.Parameters.AddWithValue("@UnidentifiedID", UnidentifiedId);
            UpdateStatus.ExecuteNonQuery();
            return true;
        }

        // Comments on Unidentified People Posts.
        public bool PostCommentsonUnidentifiedPeople(int unidentified, int Reg_id, string Fullname, string Message, string Image)
        {
            connection();
            SqlCommand InsertComment = new SqlCommand("InsertPostsCommentInUnidentifiedID", con);
            InsertComment.CommandType = CommandType.StoredProcedure;
            InsertComment.Parameters.AddWithValue("@Unidentified", unidentified);
            InsertComment.Parameters.AddWithValue("@registration_ID", Reg_id);
            InsertComment.Parameters.AddWithValue("@FullName", Fullname);
            InsertComment.Parameters.AddWithValue("@Message", Message);
            InsertComment.Parameters.AddWithValue("@Image", Image);
            InsertComment.ExecuteNonQuery();
            return true;
        }

        // Select Unidentified People Comment
        public List<CommentObjects> SelectCommentOfUnidentifiedPeople(int Unidentified)
        {
            List<CommentObjects> ls = new List<CommentObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectCommentsForUnidentifiedPeople", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@Unidentified", Unidentified);
            SqlDataReader reader = SelectData.ExecuteReader();
            while (reader.Read())
            {
                CommentObjects ob = new CommentObjects();
                ob.CommentID = Convert.ToInt32(reader["CommentID"]);
                ob.UnidentifiedID = Convert.ToInt32(reader["UnidentifiedID"]);
                ob.RegistrationID = Convert.ToInt32(reader["RegistrationID"]);
                ob.FullName = reader["FullName"].ToString();
                ob.Message = reader["Message"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }

        // Delete Unidentified People Posts Comments.
        public bool DeleteUnidentifiedPeopleComments(int R_ID, int Comment_ID)
        {
            connection();
            SqlCommand DeleteData = new SqlCommand("DeleteUnidentifiedPeoplePostComments", con);
            DeleteData.CommandType = CommandType.StoredProcedure;
            DeleteData.Parameters.AddWithValue("@RegistrationID", R_ID);
            DeleteData.Parameters.AddWithValue("@CommentID", Comment_ID);
            DeleteData.ExecuteNonQuery();
            return true;
        }

        // Select Total Number of Posts From Unidentified People For Admin Panel.
        public List<UnidentifiedPeoplePageObject> TotalUnidentifiedPeoplePosts()
        {
            List<UnidentifiedPeoplePageObject> ls = new List<UnidentifiedPeoplePageObject>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectUnidentifiedPeopleCountPosts", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            if (reader.Read())
            {
                UnidentifiedPeoplePageObject ob = new UnidentifiedPeoplePageObject();
                ob.UnindentifiedID = Convert.ToInt32(reader["UnindentifiedID"]);
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }
    }
}
