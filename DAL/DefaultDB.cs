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
    public class DefaultDB
    {
        string strCon;
        SqlConnection con;
        int R_ID;

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
            }
            reader.Close();
            con.Close();
        }

        // Checking Missing People Favourite Post Existance
        public bool CheckMissingPeopleFavouritePost(int Registration_Id, int PeopleID)
        {
            connection();
            SqlCommand SelectData = new SqlCommand("CheckingFavouriteMissingPeopleIDExistance", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@RegisterationID", R_ID);
            SelectData.Parameters.AddWithValue("@PeopleID", PeopleID);
            SqlDataReader reader = SelectData.ExecuteReader();
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

        // Checking Missing Thing Favourite Post Existance
        public bool CheckMissingThingFavouritePost(int Registration_Id, int ThingID)
        {
            connection();
            SqlCommand SelectData = new SqlCommand("CheckingFavouriteMissingThingIDExistance", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@RegisterationID", R_ID);
            SelectData.Parameters.AddWithValue("@ThingID", ThingID);
            SqlDataReader reader = SelectData.ExecuteReader();
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

        // Checking Unidentified People Favourite Post Existance
        public bool CheckUnidentifiedPeopleFavouritePost(int Registration_Id, int UnidentifiedID)
        {
            connection();
            SqlCommand SelectData = new SqlCommand("CheckingFavouriteUnidentifiedPeopleIDExistance", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@RegisterationID", R_ID);
            SelectData.Parameters.AddWithValue("@UnidentifiedID", UnidentifiedID);
            SqlDataReader reader = SelectData.ExecuteReader();
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


        // Get Default Page Data From Missing People Table.
        public List<MissingPeoplePageObjects> GetPeopleDataFromDatabase()
        {
            List<MissingPeoplePageObjects> ls = new List<MissingPeoplePageObjects>();
            connection();
            SqlCommand DisplayData = new SqlCommand("SelectDataForDisplayMissingPeopleReports", con);
            DisplayData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = DisplayData.ExecuteReader();
            while(reader.Read())
            {
                MissingPeoplePageObjects ob = new MissingPeoplePageObjects();
                ob.PeopleID = Convert.ToInt16(reader["PeopleID"]);
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
                ob.FullName = reader["FullName"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.MissingDate = reader["MissingDate"].ToString();
                ob.Description = reader["Description"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }

        // Get Default Page Data From Missing Thing Table.
        public List<MissingThingPageObject> GetThingDataFromDatabase()
        {
            List<MissingThingPageObject> ls = new List<MissingThingPageObject>();
            connection();
            SqlCommand DisplayData = new SqlCommand("SelectDataForDisplayMissingThingReports", con);
            DisplayData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = DisplayData.ExecuteReader();
            while(reader.Read())
            {
                MissingThingPageObject ob = new MissingThingPageObject();
                ob.ThingID = Convert.ToInt16(reader["ThingID"]);
                ob.OwnerName = reader["OwnerName"].ToString();
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.MissingDate = reader["MissingDate"].ToString();
                ob.Description = reader["Description"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }

        // Get Default Page Data From Unidentified People Table.
        public List<UnidentifiedPeoplePageObject> GetUnidentifiedPeopleDataFromDatabase()
        {
            List<UnidentifiedPeoplePageObject> ls = new List<UnidentifiedPeoplePageObject>();
            connection();
            SqlCommand DisplayData = new SqlCommand("SelectDataForDisplayUnidentifiedPeople", con);
            DisplayData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = DisplayData.ExecuteReader();
            while (reader.Read())
            {
                UnidentifiedPeoplePageObject ob = new UnidentifiedPeoplePageObject();
                ob.UnindentifiedID = Convert.ToInt16(reader["UnindentifiedID"]);
                ob.FullName = reader["FullName"].ToString();
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob .FoundPlace= reader["FoundPlace"].ToString();
                ob.Description = reader["Description"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }

        // Insert Favourite People Post Id in Table.
        public void InsertPeopleFavouriteID(int PeopleID)
        {
            connection();
            SqlCommand InsertID = new SqlCommand("InsertFovouritePostPeopleID", con);
            InsertID.CommandType = CommandType.StoredProcedure;
            InsertID.Parameters.AddWithValue("@RegistrationID", R_ID);
            InsertID.Parameters.AddWithValue("@PeopleID", PeopleID);
            InsertID.ExecuteNonQuery();
            con.Close();
        }

        // Insert Favourite Thing Post Id in Table.
        public void InsertThingFavouriteID(int ThingID)
        {
            connection();
            SqlCommand InsertID = new SqlCommand("InsertFovouritePostThingID", con);
            InsertID.CommandType = CommandType.StoredProcedure;
            InsertID.Parameters.AddWithValue("@RegistrationID", R_ID);
            InsertID.Parameters.AddWithValue("@ThingID", ThingID);
            InsertID.ExecuteNonQuery();
            con.Close();
        }

        // Insert Unidentified People Post Id in Table.
        public void InsertUnidentifiedFavouriteID(int UnidentifiedID)
        {
            connection();
            SqlCommand InsertID = new SqlCommand("InsertFovouritePostUnidentifiedID", con);
            InsertID.CommandType = CommandType.StoredProcedure;
            InsertID.Parameters.AddWithValue("@RegistrationID", R_ID);
            InsertID.Parameters.AddWithValue("@UnidentifiedID", UnidentifiedID);
            InsertID.ExecuteNonQuery();
            con.Close();
        }

        // Select Missing People Poat For Print.
        public List<MissingPeoplePageObjects> SelectMissingPeoplePostForPrint(int PeopleID)
        {
            List<MissingPeoplePageObjects> ls = new List<MissingPeoplePageObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectMissingPeoplePostForPrint", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@PeopleID", PeopleID);
            SqlDataReader reader = SelectData.ExecuteReader();
            if (reader.Read())
            {
                MissingPeoplePageObjects ob = new MissingPeoplePageObjects();
                ob.PeopleID = Convert.ToInt16(reader["PeopleID"]);
                ob.Count = Convert.ToInt16(reader["Count"]);
                ob.RegistrationID = Convert.ToInt16(reader["RegistrationID"]);
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
                ob.FullName = reader["FullName"].ToString();
                ob.NickName = reader["NickName"].ToString();
                ob.CNIC = reader["CNIC"].ToString();
                ob.FatherGuardianName = reader["FatherGuardianName"].ToString();
                ob.FatherGuardianCNIC = reader["FatherGuardianCNIC"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.AnotherContactNumber = reader["AnotherContactNumber"].ToString();
                ob.PermanentAddress = reader["PermanentAddress"].ToString();
                ob.CurrentAddress = reader["CurrentAddress"].ToString();
                ob.Religion = reader["Religion"].ToString();
                ob.Age = reader["Age"].ToString();
                ob.MissingPlace = reader["MissingPlace"].ToString();
                ob.MissingDate = reader["MissingDate"].ToString();
                ob.Tribe = reader["Tribe"].ToString();
                ob.LAnguage = reader["Language"].ToString();
                ob.ClothesColor = reader["ClothesColor"].ToString();
                ob.Height = reader["Height"].ToString();
                ob.Weight = reader["Weight"].ToString();
                ob.EyeColor = reader["EyesColor"].ToString();
                ob.HairColor = reader["HairColor"].ToString();
                ob.Description = reader["Description"].ToString();
                ob.Gander = reader["Gander"].ToString();
                ob.Image = reader["Image"].ToString();
                ob.Status = reader["Status"].ToString();
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }
    }
}
