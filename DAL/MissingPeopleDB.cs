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
    public class MissingPeopleDB
    {
        int R_ID;
        int Comment_ID;
        string strCon;
        SqlConnection con;

        // Connection to Database.
        public void connection()
        {
            strCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            con = new SqlConnection(strCon);
            con.Open();
        }

        // To Fetch a Logged in User ID.
        public void GetUserID(string Username)
        {
            connection();
            SqlCommand cmd = new SqlCommand("SelectRegistrationIDforMissinsgPeople", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", Username);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                R_ID = Convert.ToInt16(reader["RegistrationID"]);
                reader.Close();
                con.Close();
            }
        }

        // Insert Missing People Method.
        public bool MissingPeopleMethod(int Registration_Id, string Reference, string Name, string NickName, string CNIC, string GuardianName, string GuardianCNIC, string Contact, string AnotherContact, string Permanent, string Current, string Religion, string Age, string MissingPlace, string MissingDate, string Tribe, string Language, string ClothColor, string Height, string Weight, string EyeColor, string HairColor, string Description, string Gander, string Image)
        {
            connection();
            SqlCommand UpdateID = new SqlCommand("UpdatePeopleIdInRegistrationTable", con);
            UpdateID.CommandType = CommandType.StoredProcedure;
            SqlCommand InsertData = new SqlCommand("InsertDataForMissingPeople", con);
            InsertData.CommandType = CommandType.StoredProcedure;
            InsertData.Parameters.AddWithValue("@RegistrationID", R_ID);
            InsertData.Parameters.AddWithValue("@ReferenceNuumber", Reference);
            InsertData.Parameters.AddWithValue("@FullName", Name);
            InsertData.Parameters.AddWithValue("@NickName", NickName);
            InsertData.Parameters.AddWithValue("@CNIC", CNIC);
            InsertData.Parameters.AddWithValue("@GuardianName", GuardianName);
            InsertData.Parameters.AddWithValue("@GuardianCNIC", GuardianCNIC);
            InsertData.Parameters.AddWithValue("@ContactNumber", Contact);
            InsertData.Parameters.AddWithValue("@AnotherContact", AnotherContact);
            InsertData.Parameters.AddWithValue("@PermanentAddress", Permanent);
            InsertData.Parameters.AddWithValue("@CurrentAddress", Current);
            InsertData.Parameters.AddWithValue("@Religion", Religion);
            InsertData.Parameters.AddWithValue("@Age", Age);
            InsertData.Parameters.AddWithValue("@MissingPlace", MissingPlace);
            InsertData.Parameters.AddWithValue("@MissingDate", MissingDate);
            InsertData.Parameters.AddWithValue("@Tribe", Tribe);
            InsertData.Parameters.AddWithValue("@Language", Language);
            InsertData.Parameters.AddWithValue("@ClothColor", ClothColor);
            InsertData.Parameters.AddWithValue("@Height", Height);
            InsertData.Parameters.AddWithValue("@Weight", Weight);
            InsertData.Parameters.AddWithValue("@EyesColor",EyeColor);
            InsertData.Parameters.AddWithValue("@HairColor", HairColor);
            InsertData.Parameters.AddWithValue("@Description", Description);
            InsertData.Parameters.AddWithValue("@Gander", Gander);
            InsertData.Parameters.AddWithValue("@Image", Image);
            InsertData.ExecuteNonQuery();
            con.Close();
            return true;
        }
    
        // Update Missing People Status from Admin Panel.
        public bool UpdateMissingPeopleStatus(int PeopleId)
        {
            connection();
            SqlCommand UpdateStatus = new SqlCommand("UpdateMissingPeopleToApproved", con);
            UpdateStatus.CommandType = CommandType.StoredProcedure;
            UpdateStatus.Parameters.AddWithValue("@PeopleID", PeopleId);
            UpdateStatus.ExecuteNonQuery();
            return true;
        }

        // Delete Missing People Post from Admin Panel.
        public bool DeleteMissingPeoplePost(int PeopleId)
        {
            connection();
            SqlCommand UpdateStatus = new SqlCommand("DeleteMissingPeoplePost", con);
            UpdateStatus.CommandType = CommandType.StoredProcedure;
            UpdateStatus.Parameters.AddWithValue("@PeopleID", PeopleId);
            UpdateStatus.ExecuteNonQuery();
            return true;
        }

        // Comments on Missong People Posts.
        public bool PostComments(int People_id, int Reg_id, string Fullname, string Message, string Image)
        {
            connection();
            SqlCommand InsertComment = new SqlCommand("InsertPostsCommentInMissingPeople", con);
            InsertComment.CommandType = CommandType.StoredProcedure;
            InsertComment.Parameters.AddWithValue("@PeopleID", People_id);
            InsertComment.Parameters.AddWithValue("@registration_ID", Reg_id);
            InsertComment.Parameters.AddWithValue("@FullName", Fullname);
            InsertComment.Parameters.AddWithValue("@Message", Message);
            InsertComment.Parameters.AddWithValue("@Image", Image);
            InsertComment.ExecuteNonQuery();
            return true;
        }

        // Select Missing People Comment
        public List<CommentObjects> SelectCommentOfMisingPeople(int PeopleID)
        {
            List<CommentObjects> ls = new List<CommentObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectCommentsForPosts", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@PeopleID", PeopleID);
            SqlDataReader reader = SelectData.ExecuteReader();
            while(reader.Read())
            {
                CommentObjects ob = new CommentObjects();
                ob.CommentID = Convert.ToInt32(reader["CommentID"]);
                ob.PeopleID = Convert.ToInt32(reader["PeopleID"]);
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

        // Delete Missing People Posts Comments.
        public bool DeleteMissingPeopleComments(int R_ID, int Comment_ID)
        {
            connection();
            SqlCommand DeleteData = new SqlCommand("DeleteMissingPeoplePostComments", con);
            DeleteData.CommandType = CommandType.StoredProcedure;
            DeleteData.Parameters.AddWithValue("@RegistrationID", R_ID);
            DeleteData.Parameters.AddWithValue("@CommentID", Comment_ID);
            DeleteData.ExecuteNonQuery();
            return true;
        }

        // Select Total Number of Posts From Missing People For Admin Panel.
        public List<MissingPeoplePageObjects> TotalMissingPeoplePosts()
        {
            List<MissingPeoplePageObjects> ls = new List<MissingPeoplePageObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectMissingPeopleCountPosts", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            if (reader.Read())
            {
                MissingPeoplePageObjects ob = new MissingPeoplePageObjects();
                ob.PeopleID = Convert.ToInt32(reader["PeopleID"]);
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }
    }
}
