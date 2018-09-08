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
    public class MissingThingDB
    {
        int RegistrationID;
        string conStr;
        SqlConnection con;
       
        // Connection to Database.
        public void connection()
        {
            conStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            con = new SqlConnection(conStr);
            con.Open();
        }

        // Get User Registration ID.
        public void GetUserId(string username)
        {
            connection();
            SqlCommand GetID = new SqlCommand("SelectRegistrationIDforMissinsgPeople", con);
            GetID.CommandType = CommandType.StoredProcedure;
            GetID.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = GetID.ExecuteReader();
            if(reader.Read())
            {
                RegistrationID = Convert.ToInt16(reader["RegistrationID"]);
                reader.Close();
                con.Close();
            }
        }

        // Insert Data into Mobile.
        public bool InsertDataIntoMobile(int R_ID, string Reference, string OwnerName, string OwnerCNIC, string GuardianName, string GuardianCNIC, string ContactNumber, string AnotherContact, string ThingName, string BrandName, string Color, string Model, string MissingPlace, string MissingDate, string IMEI, string Description, string PermanentAddress, string CurrentAddress, string Image)
        {
            connection();
            SqlCommand InsertData = new SqlCommand("InsertDataIntoMissingThingMobile", con);
            InsertData.CommandType = CommandType.StoredProcedure;
            InsertData.Parameters.AddWithValue("@RegistrationID", RegistrationID);
            InsertData.Parameters.AddWithValue("@Reference", Reference);
            InsertData.Parameters.AddWithValue("@OwnerName", OwnerName);
            InsertData.Parameters.AddWithValue("@OwnerCNIC", OwnerCNIC);
            InsertData.Parameters.AddWithValue("@GuardianName", GuardianName);
            InsertData.Parameters.AddWithValue("@GuardianCNIC", GuardianCNIC);
            InsertData.Parameters.AddWithValue("@ContactNumber", ContactNumber);
            InsertData.Parameters.AddWithValue("@AnotherContact", AnotherContact);
            InsertData.Parameters.AddWithValue("@ThingName", ThingName);
            InsertData.Parameters.AddWithValue("@BrandName", BrandName);
            InsertData.Parameters.AddWithValue("@Color", Color);
            InsertData.Parameters.AddWithValue("@Model", Model);
            InsertData.Parameters.AddWithValue("@MissingPlace", MissingPlace);
            InsertData.Parameters.AddWithValue("@MissingDate", MissingDate);
            InsertData.Parameters.AddWithValue("@IMEI", IMEI);
            InsertData.Parameters.AddWithValue("@Description", Description);
            InsertData.Parameters.AddWithValue("@PermanentAddress", PermanentAddress);
            InsertData.Parameters.AddWithValue("@CurrentAddress", CurrentAddress);
            InsertData.Parameters.AddWithValue("@Image", Image);
            InsertData.ExecuteNonQuery();
            return true;
        }

        // Insert Data into CNIC.
        public bool InsertDataIntoCNIC(int R_ID, string Reference, string OwnerName, string OwnerCNIC, string GuardianName, string GuardianCNIC, string ContactNumber, string AnotherContact, string ThingName, string MissingPlace, string MissingDate, string Description, string CNICNumber, string UniqueIdentification, string CNICDOB, string CNICFamily, string PermanentAddress, string CurrentAddress, string Gander, string Image)
        {
            connection();
            SqlCommand InsertData = new SqlCommand("InsertDataIntoMissingThingCNIC", con);
            InsertData.CommandType = CommandType.StoredProcedure;
            InsertData.Parameters.AddWithValue("@RegistrationID", RegistrationID);
            InsertData.Parameters.AddWithValue("@Reference", Reference);
            InsertData.Parameters.AddWithValue("@OwnerName", OwnerName);
            InsertData.Parameters.AddWithValue("@OwnerCNIC", OwnerCNIC);
            InsertData.Parameters.AddWithValue("@GuardianName", GuardianName);
            InsertData.Parameters.AddWithValue("@GuardianCNIC", GuardianCNIC);
            InsertData.Parameters.AddWithValue("@ContactNumber", ContactNumber);
            InsertData.Parameters.AddWithValue("@AnotherContact", AnotherContact);
            InsertData.Parameters.AddWithValue("@ThingName", ThingName);
            InsertData.Parameters.AddWithValue("@MissingPlace", MissingPlace);
            InsertData.Parameters.AddWithValue("@MissingDate", MissingDate);
            InsertData.Parameters.AddWithValue("@Description", Description);
            InsertData.Parameters.AddWithValue("@CNICNumber", CNICNumber);
            InsertData.Parameters.AddWithValue("@CNICIdentification", UniqueIdentification);
            InsertData.Parameters.AddWithValue("@CNICDOB", CNICDOB);
            InsertData.Parameters.AddWithValue("@CNICFamily", CNICFamily);
            InsertData.Parameters.AddWithValue("@PermanentAddress", PermanentAddress);
            InsertData.Parameters.AddWithValue("@CurrentAddress", CurrentAddress);
            InsertData.Parameters.AddWithValue("@Gander", Gander);
            InsertData.Parameters.AddWithValue("@Image", Image);
            InsertData.ExecuteNonQuery();
            return true;
        }

        // Insert Data into Auto Mobile.
        public bool InsertDataIntoAutoMobile(int R_ID, string Reference, string OwnerName, string OwnerCNIC, string GuardianName, string GuardianCNIC, string ContactNumber, string AnotherContact, string ThingName, string CompanyName, string BrandName, string EngineNumber, string ChassesNumber, string Color, string Model, string MissingPlace, string MissingDate, string Description, string PermanentAddress, string CurrentAddress, string Image)
        {
            connection();
            SqlCommand InsertData = new SqlCommand("InsertDataIntoMissingThingAutoMobile", con);
            InsertData.CommandType = CommandType.StoredProcedure;
            InsertData.Parameters.AddWithValue("@RegistrationID", RegistrationID);
            InsertData.Parameters.AddWithValue("@Reference", Reference);
            InsertData.Parameters.AddWithValue("@OwnerName", OwnerName);
            InsertData.Parameters.AddWithValue("@OwnerCNIC", OwnerCNIC);
            InsertData.Parameters.AddWithValue("@GuardianName", GuardianName);
            InsertData.Parameters.AddWithValue("@GuardianCNIC", GuardianCNIC);
            InsertData.Parameters.AddWithValue("@ContactNumber", ContactNumber);
            InsertData.Parameters.AddWithValue("@AnotherContact", AnotherContact);
            InsertData.Parameters.AddWithValue("@ThingName", ThingName);
            InsertData.Parameters.AddWithValue("@Companyname", CompanyName);
            InsertData.Parameters.AddWithValue("@BrandName", BrandName);
            InsertData.Parameters.AddWithValue("@EngineNumber", EngineNumber);
            InsertData.Parameters.AddWithValue("@ChassesNumber", ChassesNumber);
            InsertData.Parameters.AddWithValue("@Color", Color);
            InsertData.Parameters.AddWithValue("@Model", Model);
            InsertData.Parameters.AddWithValue("@MissingPlace", MissingPlace);
            InsertData.Parameters.AddWithValue("@MissingDate", MissingDate);
            InsertData.Parameters.AddWithValue("@Description", Description);
            InsertData.Parameters.AddWithValue("@PermanentAddress", PermanentAddress);
            InsertData.Parameters.AddWithValue("@CurrentAddress", CurrentAddress);
            InsertData.Parameters.AddWithValue("@Image", Image);
            InsertData.ExecuteNonQuery();
            return true;
        }

        // Delete Missing Thing post from Admin Panel.
        public bool DeleteMissingThingPost(int ThingId)
        {
            connection();
            SqlCommand UpdateStatus = new SqlCommand("DeleteMissingThingPost", con);
            UpdateStatus.CommandType = CommandType.StoredProcedure;
            UpdateStatus.Parameters.AddWithValue("@ThingID", ThingId);
            UpdateStatus.ExecuteNonQuery();
            return true;
        }

        // Approve Missing Thing post from Admin Panel.
        public bool UpdateMissingThingStatus(int ThingId)
        {
            connection();
            SqlCommand UpdateStatus = new SqlCommand("UpdateMissingThingToApproved", con);
            UpdateStatus.CommandType = CommandType.StoredProcedure;
            UpdateStatus.Parameters.AddWithValue("@ThingID", ThingId);
            UpdateStatus.ExecuteNonQuery();
            return true;
        }

        // Comments on Auto Mobile Posts.
        public bool PostCommentsonAutoMobile(int AutoMobile, int Reg_id, string Fullname, string Message, string Image)
        {
            connection();
            SqlCommand InsertComment = new SqlCommand("InsertPostsCommentInMissingThingsAutoMobile", con);
            InsertComment.CommandType = CommandType.StoredProcedure;
            InsertComment.Parameters.AddWithValue("@AutoMobile", AutoMobile);
            InsertComment.Parameters.AddWithValue("@registration_ID", Reg_id);
            InsertComment.Parameters.AddWithValue("@FullName", Fullname);
            InsertComment.Parameters.AddWithValue("@Message", Message);
            InsertComment.Parameters.AddWithValue("@Image", Image);
            InsertComment.ExecuteNonQuery();
            return true;
        }

        // Select Auto Mobile Comment
        public List<CommentObjects> SelectCommentOfAutoMobile(int AutoMobile)
        {
            List<CommentObjects> ls = new List<CommentObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectCommentsForAutoMobile", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@AutoMobile", AutoMobile);
            SqlDataReader reader = SelectData.ExecuteReader();
            while (reader.Read())
            {
                CommentObjects ob = new CommentObjects();
                ob.CommentID = Convert.ToInt32(reader["CommentID"]);
                ob.AutoMobileID = Convert.ToInt32(reader["AutoMobile"]);
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

        // Comments on Mobile Posts.
        public bool PostCommentsonMobile(int Mobile, int Reg_id, string Fullname, string Message, string Image)
        {
            connection();
            SqlCommand InsertComment = new SqlCommand("InsertPostsCommentInMissingThingsMobile", con);
            InsertComment.CommandType = CommandType.StoredProcedure;
            InsertComment.Parameters.AddWithValue("@Mobile", Mobile);
            InsertComment.Parameters.AddWithValue("@registration_ID", Reg_id);
            InsertComment.Parameters.AddWithValue("@FullName", Fullname);
            InsertComment.Parameters.AddWithValue("@Message", Message);
            InsertComment.Parameters.AddWithValue("@Image", Image);
            InsertComment.ExecuteNonQuery();
            return true;
        }

        // Select Mobile Comment
        public List<CommentObjects> SelectCommentOfMobile(int Mobile)
        {
            List<CommentObjects> ls = new List<CommentObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectCommentsForMobile", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@Mobile", Mobile);
            SqlDataReader reader = SelectData.ExecuteReader();
            while (reader.Read())
            {
                CommentObjects ob = new CommentObjects();
                ob.CommentID = Convert.ToInt32(reader["CommentID"]);
                ob.MobileID = Convert.ToInt32(reader["Mobile"]);
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

        // Comments on CNIC Posts.
        public bool PostCommentsonCNIC(int CNIC, int Reg_id, string Fullname, string Message, string Image)
        {
            connection();
            SqlCommand InsertComment = new SqlCommand("InsertPostsCommentInMissingThingCNIC", con);
            InsertComment.CommandType = CommandType.StoredProcedure;
            InsertComment.Parameters.AddWithValue("@CNIC", CNIC);
            InsertComment.Parameters.AddWithValue("@registration_ID", Reg_id);
            InsertComment.Parameters.AddWithValue("@FullName", Fullname);
            InsertComment.Parameters.AddWithValue("@Message", Message);
            InsertComment.Parameters.AddWithValue("@Image", Image);
            InsertComment.ExecuteNonQuery();
            return true;
        }

        // Select Mobile Comment
        public List<CommentObjects> SelectCommentOfCNIC(int CNIC)
        {
            List<CommentObjects> ls = new List<CommentObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectCommentsForCNIC", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@CNIC", CNIC);
            SqlDataReader reader = SelectData.ExecuteReader();
            while (reader.Read())
            {
                CommentObjects ob = new CommentObjects();
                ob.CommentID = Convert.ToInt32(reader["CommentID"]);
                ob.CnicID = Convert.ToInt32(reader["CNIC"]);
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

        // Delete CNIC Posts Comments.
        public bool DeleteCNICComments(int R_ID, int Comment_ID)
        {
            connection();
            SqlCommand DeleteData = new SqlCommand("DeleteCNICPostComments", con);
            DeleteData.CommandType = CommandType.StoredProcedure;
            DeleteData.Parameters.AddWithValue("@RegistrationID", R_ID);
            DeleteData.Parameters.AddWithValue("@CommentID", Comment_ID);
            DeleteData.ExecuteNonQuery();
            return true;
        }

        // Delete Auto Mobile Posts Comments.
        public bool DeleteAutoMobileComments(int R_ID, int Comment_ID)
        {
            connection();
            SqlCommand DeleteData = new SqlCommand("DeleteAutoMobilePostComments", con);
            DeleteData.CommandType = CommandType.StoredProcedure;
            DeleteData.Parameters.AddWithValue("@RegistrationID", R_ID);
            DeleteData.Parameters.AddWithValue("@CommentID", Comment_ID);
            DeleteData.ExecuteNonQuery();
            return true;
        }

        // Delete Mobile Posts Comments.
        public bool DeleteMobileComments(int R_ID, int Comment_ID)
        {
            connection();
            SqlCommand DeleteData = new SqlCommand("DeleteMobilePostComments", con);
            DeleteData.CommandType = CommandType.StoredProcedure;
            DeleteData.Parameters.AddWithValue("@RegistrationID", R_ID);
            DeleteData.Parameters.AddWithValue("@CommentID", Comment_ID);
            DeleteData.ExecuteNonQuery();
            return true;
        }

        // Select Total Number of Posts From Missing Thing For Admin Panel.
        public List<MissingThingPageObject> TotalMissingThingPosts()
        {
            List<MissingThingPageObject> ls = new List<MissingThingPageObject>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectMissingThingCountPosts", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            if (reader.Read())
            {
                MissingThingPageObject ob = new MissingThingPageObject();
                ob.ThingID = Convert.ToInt32(reader["ThingID"]);
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }
    }
}
