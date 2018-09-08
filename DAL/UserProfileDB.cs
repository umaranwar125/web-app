using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BOL;

namespace DAL
{
    public class UserProfileDB
    {
        string strCon;
        SqlConnection con;
        int R_ID;
        int PeopleID;
        int ThingID;
        int UnidentifiedID;

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

        // Get Data for User Profile From Missing People Table.
        public List<MissingPeoplePageObjects> GetPeopleDataFromDatabase()
        {
            List<MissingPeoplePageObjects> ls = new List<MissingPeoplePageObjects>();
            connection();
            SqlCommand DisplayData = new SqlCommand("SelectMissingPeopleDataForUserProfile", con);
            DisplayData.CommandType = CommandType.StoredProcedure;
            DisplayData.Parameters.AddWithValue("@RegistrationID", R_ID);
            SqlDataReader reader = DisplayData.ExecuteReader();
            while (reader.Read())
            {
                MissingPeoplePageObjects ob = new MissingPeoplePageObjects();
                ob.PeopleID = Convert.ToInt32(reader["PeopleID"]);
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
                ob.FullName = reader["FullName"].ToString();
                ob.CNIC = reader["CNIC"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.MissingDate = reader["MissingDate"].ToString();
                ob.Image = reader["Image"].ToString();
                ob.Status = reader["Status"].ToString();
                ob.Count = Convert.ToInt32(reader["Count"]);
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }

        // Get Data for User Profile From Missing Thing Table.
        public List<MissingThingPageObject> GetThingDataFromDatabase()
        {
            List<MissingThingPageObject> ls = new List<MissingThingPageObject>();
            connection();
            SqlCommand DisplayData = new SqlCommand("SelectMissingThingDataForUserProfile", con);
            DisplayData.CommandType = CommandType.StoredProcedure;
            DisplayData.Parameters.AddWithValue("@RegistrationID", R_ID);
            SqlDataReader reader = DisplayData.ExecuteReader();
            while(reader.Read())
            {
                MissingThingPageObject ob = new MissingThingPageObject();
                ob.ThingID = Convert.ToInt32(reader["ThingID"]);
                ob.OwnerName = reader["OwnerName"].ToString();
                ob.OwnerCNIC = reader["OwnerCNIC"].ToString();
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.MissingDate = reader["MissingDate"].ToString();
                ob.ThingName = reader["ThingName"].ToString();
                ob.Image = reader["Image"].ToString();
                ob.Status = reader["Status"].ToString();
                ob.Count = Convert.ToInt32(reader["Count"]);
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }

        // Get Data for User Profile From Unidentified People Table.
        public List<UnidentifiedPeoplePageObject> GetUnidentifiedPeopleDataFromDatabase()
        {
            List<UnidentifiedPeoplePageObject> ls = new List<UnidentifiedPeoplePageObject>();
            connection();
            SqlCommand DisplayData = new SqlCommand("SelectUnidentifiedPeopleDataForUserProfile", con);
            DisplayData.CommandType = CommandType.StoredProcedure;
            DisplayData.Parameters.AddWithValue("@RegistrationID", R_ID);
            SqlDataReader reader = DisplayData.ExecuteReader();
            while (reader.Read())
            {
                UnidentifiedPeoplePageObject ob = new UnidentifiedPeoplePageObject();
                ob.UnindentifiedID = Convert.ToInt32(reader["UnindentifiedID"]);
                ob.FullName = reader["FullName"].ToString();
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.FoundPlace = reader["FoundPlace"].ToString();
                ob.Religion = reader["Religion"].ToString();
                ob.Image = reader["Image"].ToString();
                ob.Status = reader["Status"].ToString();
                ob.Count = Convert.ToInt32(reader["Count"]);
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }

        // Delete Missing People Data.
        public bool DeleteMissingPeoplePost(string PeopleID)
        {
            connection();
            SqlCommand DeletePost = new SqlCommand("DeleteMissingPeoplePost", con);
            DeletePost.CommandType = CommandType.StoredProcedure;
            DeletePost.Parameters.AddWithValue("@PeopleID", PeopleID);
            DeletePost.ExecuteNonQuery();
            con.Close();
            return true;
        }

        // Delete Favourite missing People Post from Submit Missing People Post.
        public void DeleteFavouriteMissingPeoplePost(string PeopleID)
        {
            connection();
            SqlCommand DeletePost = new SqlCommand("DeleteFavouritePostFromSubmitPost", con);
            DeletePost.CommandType = CommandType.StoredProcedure;
            DeletePost.Parameters.AddWithValue("@PeopleID", PeopleID);
            DeletePost.ExecuteNonQuery();
            con.Close();
        }

        // Delete Missing Thing Data.
        public bool DeleteMissingThingPost(string ThingID)
        {
            connection();
            SqlCommand DeletePost = new SqlCommand("DeleteMissingThingPost", con);
            DeletePost.CommandType = CommandType.StoredProcedure;
            DeletePost.Parameters.AddWithValue("@ThingID", ThingID);
            DeletePost.ExecuteNonQuery();
            con.Close();
            return true;
        }

        // Delete Favourite missing Thing Post from Submit Missing Thing Post.
        public void DeleteFavouriteMissingThingPost(string ThingID)
        {
            connection();
            SqlCommand DeletePost = new SqlCommand("DeleteFavouriteThingPostFromSubmitPost", con);
            DeletePost.CommandType = CommandType.StoredProcedure;
            DeletePost.Parameters.AddWithValue("@ThingID", ThingID);
            DeletePost.ExecuteNonQuery();
            con.Close();
        }

        // Delete Unidentified People Data.
        public bool DeleteUnidentifiedPeoplePost(string UnidentifiedID)
        {
            connection();
            SqlCommand DeletePost = new SqlCommand("DeleteUnidentifiedPeoplePost", con);
            DeletePost.CommandType = CommandType.StoredProcedure;
            DeletePost.Parameters.AddWithValue("@UnidentifiedID", UnidentifiedID);
            DeletePost.ExecuteNonQuery();
            con.Close();
            return true;
        }

        // Delete Favourite Unidentified People Post from Submit Unidentified People Post.
        public void DeleteFavouriteUnidentifiedPeoplePost(string UnidentifiedID)
        {
            connection();
            SqlCommand DeletePost = new SqlCommand("DeleteFavouriteUnidentifiedPostFromSubmitPost", con);
            DeletePost.CommandType = CommandType.StoredProcedure;
            DeletePost.Parameters.AddWithValue("@UnidentifiedID", UnidentifiedID);
            DeletePost.ExecuteNonQuery();
            con.Close();
        }

        public List<MissingThingPageObject> SelectThingNameForEditPost(int ThingID)
        {
            connection();
            List<MissingThingPageObject> ls = new List<MissingThingPageObject>();
            SqlCommand cmd = new SqlCommand("SelectMissingThingDataOnID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ThingID", ThingID);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                MissingThingPageObject ob = new MissingThingPageObject();
                ob.ThingName = reader["ThingName"].ToString();
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }

        // Edit Missing People Post.
        public bool UpdateMissingPeoplePost(int PeopleID, string name, string nickName, string CNIC, string FatherName, string FatherCNIC, string Contact1, string Contact2, string Permanent, string Current, string Age, string MissingPlace, string Clothes, string Description, string Image)
        {
            connection();
            SqlCommand UpdateData = new SqlCommand("UpdateMissingPeoplePostInUserProfile", con);
            UpdateData.CommandType = CommandType.StoredProcedure;
            UpdateData.Parameters.AddWithValue("@PeopleID", PeopleID);
            UpdateData.Parameters.AddWithValue("@FullName", name);
            UpdateData.Parameters.AddWithValue("@NickName", nickName);
            UpdateData.Parameters.AddWithValue("@CNIC", CNIC);
            UpdateData.Parameters.AddWithValue("@FatherName", FatherName);
            UpdateData.Parameters.AddWithValue("@FatherCNIC", FatherCNIC);
            UpdateData.Parameters.AddWithValue("@Contact", Contact1);
            UpdateData.Parameters.AddWithValue("@Contact2", Contact2);
            UpdateData.Parameters.AddWithValue("@Permanent", Permanent);
            UpdateData.Parameters.AddWithValue("@Current", Current);
            UpdateData.Parameters.AddWithValue("@Age", Age);
            UpdateData.Parameters.AddWithValue("@MissingPlace", MissingPlace);
            UpdateData.Parameters.AddWithValue("@ClothesColor", Clothes);
            UpdateData.Parameters.AddWithValue("@Description", Description);
            UpdateData.Parameters.AddWithValue("@Image", Image);
            UpdateData.ExecuteNonQuery();
            con.Close();
            return true;
        }

        // Edit Mobile Post.
        public bool UpdateMobilePost(int ThingID, string OwnerName, string OwnerCNIC, string Contact, string Contact2, string FatherName, string FatherCNIC, string Permanent, string Current, string Place, string Description, string Image, string Brand, string Color, string Model, string IMEI)
        {
            connection();
            SqlCommand UpdateData = new SqlCommand("UpdateMobilePostInUserProfile", con);
            UpdateData.CommandType = CommandType.StoredProcedure;
            UpdateData.Parameters.AddWithValue("@ThingID", ThingID);
            UpdateData.Parameters.AddWithValue("@OwnerName", OwnerName);
            UpdateData.Parameters.AddWithValue("@OwnerCNIC", OwnerCNIC);
            UpdateData.Parameters.AddWithValue("@Contact", Contact);
            UpdateData.Parameters.AddWithValue("@Contact2", Contact2);
            UpdateData.Parameters.AddWithValue("@FatherName", FatherName);
            UpdateData.Parameters.AddWithValue("@FatherCNIC", FatherCNIC);
            UpdateData.Parameters.AddWithValue("@Permanent", Permanent);
            UpdateData.Parameters.AddWithValue("@Current", Current);
            UpdateData.Parameters.AddWithValue("@Place", Place);
            UpdateData.Parameters.AddWithValue("@Decription", Description);
            UpdateData.Parameters.AddWithValue("@Brand", Brand);
            UpdateData.Parameters.AddWithValue("@Color", Color);
            UpdateData.Parameters.AddWithValue("@Model", Model);
            UpdateData.Parameters.AddWithValue("@IMEI", IMEI);
            UpdateData.Parameters.AddWithValue("@Image", Image);
            UpdateData.ExecuteNonQuery();
            con.Close();
            return true;
        }

        // Edit Auto Mobile Post.
        public bool UpdateAutoMobilePost(int ThingID, string OwnerName, string OwnerCNIC, string Contact, string Contact2, string FatherName, string FatherCNIC, string Permanent, string Current, string Place, string Description, string Image, string Company, string Brand, string Engine, string Chasses, string Color, string Model)
        {
            connection();
            SqlCommand UpdateData = new SqlCommand("UpdateAutoMobilePostInUserProfile", con);
            UpdateData.CommandType = CommandType.StoredProcedure;
            UpdateData.Parameters.AddWithValue("@ThingID", ThingID);
            UpdateData.Parameters.AddWithValue("@OwnerName", OwnerName);
            UpdateData.Parameters.AddWithValue("@OwnerCNIC", OwnerCNIC);
            UpdateData.Parameters.AddWithValue("@Contact", Contact);
            UpdateData.Parameters.AddWithValue("@Contact2", Contact2);
            UpdateData.Parameters.AddWithValue("@FatherName", FatherName);
            UpdateData.Parameters.AddWithValue("@FatherCNIC", FatherCNIC);
            UpdateData.Parameters.AddWithValue("@Permanent", Permanent);
            UpdateData.Parameters.AddWithValue("@Current", Current);
            UpdateData.Parameters.AddWithValue("@Place", Place);
            UpdateData.Parameters.AddWithValue("@Decription", Description);
            UpdateData.Parameters.AddWithValue("@Company", Company);
            UpdateData.Parameters.AddWithValue("@Brand", Brand);
            UpdateData.Parameters.AddWithValue("@Engine", Engine);
            UpdateData.Parameters.AddWithValue("@Chasses", Chasses);
            UpdateData.Parameters.AddWithValue("@Color", Color);
            UpdateData.Parameters.AddWithValue("@Model", Model);
            UpdateData.Parameters.AddWithValue("@Image", Image);
            UpdateData.ExecuteNonQuery();
            con.Close();
            return true;
        }

        // Edit CNIC Post.
        public bool UpdateCNICPost(int ThingID, string OwnerName, string OwnerCNIC, string Contact, string Contact2, string FatherName, string FatherCNIC, string Permanent, string Current, string Place, string Description, string Image, string CNICNumb, string FamilyNumb)
        {
            connection();
            SqlCommand UpdateData = new SqlCommand("UpdateCNICPostInUserProfile", con);
            UpdateData.CommandType = CommandType.StoredProcedure;
            UpdateData.Parameters.AddWithValue("@ThingID", ThingID);
            UpdateData.Parameters.AddWithValue("@OwnerName", OwnerName);
            UpdateData.Parameters.AddWithValue("@OwnerCNIC", OwnerCNIC);
            UpdateData.Parameters.AddWithValue("@Contact", Contact);
            UpdateData.Parameters.AddWithValue("@Contact2", Contact2);
            UpdateData.Parameters.AddWithValue("@FatherName", FatherName);
            UpdateData.Parameters.AddWithValue("@FatherCNIC", FatherCNIC);
            UpdateData.Parameters.AddWithValue("@Permanent", Permanent);
            UpdateData.Parameters.AddWithValue("@Current", Current);
            UpdateData.Parameters.AddWithValue("@Place", Place);
            UpdateData.Parameters.AddWithValue("@Decription", Description);
            UpdateData.Parameters.AddWithValue("@CNICNumb", CNICNumb);
            UpdateData.Parameters.AddWithValue("@familyNumb", FamilyNumb);
            UpdateData.Parameters.AddWithValue("@Image", Image);
            UpdateData.ExecuteNonQuery();
            con.Close();
            return true;
        }

        // Edit Unidentified People Post.
        public bool UpdateUnidentifiedPeoplePost(int Unidentified, string Name, string FatherName, string Contact, string Age, string FoundPlace, string Description, string Image, string Language, string Unique)
        {
            connection();
            SqlCommand UpdateData = new SqlCommand("UpdateUnidentifiedPeoplePostInUserProfile", con);
            UpdateData.CommandType = CommandType.StoredProcedure;
            UpdateData.Parameters.AddWithValue("@UnidentifiedID", Unidentified);
            UpdateData.Parameters.AddWithValue("@FullName", Name);
            UpdateData.Parameters.AddWithValue("@FatherName", FatherName);
            UpdateData.Parameters.AddWithValue("@Contact", Contact);
            UpdateData.Parameters.AddWithValue("@Age", Age);
            UpdateData.Parameters.AddWithValue("@Unique", Unique);
            UpdateData.Parameters.AddWithValue("@Found", FoundPlace);
            UpdateData.Parameters.AddWithValue("@Language", Language);
            UpdateData.Parameters.AddWithValue("@Description", Description);
            UpdateData.Parameters.AddWithValue("@Image", Image);
            UpdateData.ExecuteNonQuery();
            con.Close();
            return true;
        }
    }
}
