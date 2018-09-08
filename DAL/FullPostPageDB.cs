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
    public class FullPostPageDB
    {
        string conStr;
        SqlConnection con;
        
        // COnnection to database.
        private void connection()
        {
            conStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            con = new SqlConnection(conStr);
            con.Open();
        }

        // Get Username and Image of Login User.
        public List<RegistrationObjects> GetImageAndName(string username)
        {
            connection();
            List<RegistrationObjects> ls = new List<RegistrationObjects>();
            SqlCommand GetUserData = new SqlCommand("SelectRegistrationIDforMissinsgPeople", con);
            GetUserData.CommandType = CommandType.StoredProcedure;
            GetUserData.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = GetUserData.ExecuteReader();
            if(reader.Read())
            {
                RegistrationObjects ob = new RegistrationObjects();
                ob.FullName = reader["FullName"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }

        // Updating Count Column in Unidentified People.
        public void UpdateCountOfUnidentifiedPeople(int UnidentifiedID)
        {
            connection();
            SqlCommand UpdateCount = new SqlCommand("UpdateCountColumnOfUnidentifiedPeople", con);
            UpdateCount.CommandType = CommandType.StoredProcedure;
            UpdateCount.Parameters.AddWithValue("@UnidentifiedID", UnidentifiedID);
            UpdateCount.ExecuteNonQuery();
            con.Close();
        }

        // Updating Count Column in fMissing Thing.
        public void UpdateCountOfMissingThing(int ThingID)
        {
            connection();
            SqlCommand UpdateCount = new SqlCommand("UpdateCountColumnOfMissingThing", con);
            UpdateCount.CommandType = CommandType.StoredProcedure;
            UpdateCount.Parameters.AddWithValue("@ThingID", ThingID);
            UpdateCount.ExecuteNonQuery();
            con.Close();
        }

        // Updating Count Column in Missing People.
        public void UpdateCountOfMissingPeople(int PeopleID)
        {
            connection();
            SqlCommand UpdateCount = new SqlCommand("UpdateCountColumnOfMissingPeople", con);
            UpdateCount.CommandType = CommandType.StoredProcedure;
            UpdateCount.Parameters.AddWithValue("@PeopleID", PeopleID);
            UpdateCount.ExecuteNonQuery();
            con.Close();
        }

        // Get people Data Through Query String.
        public List<MissingPeoplePageObjects> GetPeopleDataUsingQueryString(int PeopleID)
        {
            connection();
            List<MissingPeoplePageObjects> ls = new List<MissingPeoplePageObjects>();
            SqlCommand GetData = new SqlCommand("SelectMissinfPeopleDataForQueryString", con);
            GetData.CommandType = CommandType.StoredProcedure;
            GetData.Parameters.AddWithValue("@PeopleID", PeopleID);
            SqlDataReader reader = GetData.ExecuteReader();
            if(reader.Read())
            {
                MissingPeoplePageObjects ob = new MissingPeoplePageObjects();
                ob.PeopleID = Convert.ToInt16(reader["PeopleID"]);
                ob.Count = Convert.ToInt16(reader["Count"]);
                ob.RegistrationID = Convert.ToInt16(reader["RegistrationID"]);
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
                ob.FullName = reader["FullName"].ToString();
                ob.FatherGuardianName = reader["FatherGuardianName"].ToString();
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
                ob.EyeColor = reader["EyesColor"].ToString();
                ob.HairColor = reader["HairColor"].ToString();
                ob.Description = reader["Description"].ToString();
                ob.Gander = reader["Gander"].ToString();
                ob.Status = reader["Status"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }

        // Get Things Data Through Query String.
        public List<MissingThingPageObject> GetThingsDataUsingQueryString(int ThingID)
        {
            connection();
            List<MissingThingPageObject> ls = new List<MissingThingPageObject>();
            SqlCommand GetData = new SqlCommand("SelectMissinfThingDataForQueryString", con);
            GetData.CommandType = CommandType.StoredProcedure;
            GetData.Parameters.AddWithValue("@ThingID", ThingID);
            SqlDataReader reader = GetData.ExecuteReader();
            if (reader.Read())
            {
                MissingThingPageObject ob = new MissingThingPageObject();
                ob.ThingID = Convert.ToInt16(reader["ThingID"]);
                ob.Count = Convert.ToInt16(reader["Count"]);
                ob.RegistrationID = Convert.ToInt16(reader["RegistrationID"]);
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
                ob.OwnerName = reader["OwnerName"].ToString();
                ob.FatherGuardianName = reader["FatherGuardianName"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.AnotherContactNumber = reader["AnotherContactNumber"].ToString();
                ob.PermanentAddress = reader["PermanentAddress"].ToString();
                ob.CurrentAddress = reader["CurrentAddress"].ToString();
                ob.ThingName = reader["ThingName"].ToString();
                ob.CompanyName = reader["CompanyName"].ToString();
                ob.MissingPlace = reader["MissingPlace"].ToString();
                ob.MissingDate = reader["MissingDate"].ToString();
                ob.BrandName = reader["BrandName"].ToString();
                ob.EngineNumber = reader["EngineNumber"].ToString();
                ob.ChassesNumber = reader["ChassesNumber"].ToString();
                ob.Color = reader["Color"].ToString();
                ob.Model = reader["Model"].ToString();
                ob.IMEI = reader["IMEI"].ToString();
                ob.CNICNumber = reader["CNICNumber"].ToString();
                ob.UniqueIdentification = reader["UniqueIdentification"].ToString();
                ob.DateOfBirth = reader["DateOfBirth"].ToString();
                ob.FamilyNumber = reader["FamilyNumber"].ToString();
                ob.Description = reader["Description"].ToString();
                ob.Gander = reader["Gander"].ToString();
                ob.Status = reader["Status"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }

        // Get Unidentified People Data Through Query String.
        public List<UnidentifiedPeoplePageObject> GetUnidentifiedPeopleDataUsingQueryString(int UnindentifiedID)
        {
            connection();
            List<UnidentifiedPeoplePageObject> ls = new List<UnidentifiedPeoplePageObject>();
            SqlCommand GetData = new SqlCommand("SelectUnidentifiedPeopleDataForQueryString", con);
            GetData.CommandType = CommandType.StoredProcedure;
            GetData.Parameters.AddWithValue("@UnindentifiedID", UnindentifiedID);
            SqlDataReader reader = GetData.ExecuteReader();
            if (reader.Read())
            {
                UnidentifiedPeoplePageObject ob = new UnidentifiedPeoplePageObject();
                ob.UnindentifiedID = Convert.ToInt16(reader["UnindentifiedID"]);
                ob.Count = Convert.ToInt16(reader["Count"]);
                ob.RegistrationID = Convert.ToInt16(reader["RegistrationID"]);
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
                ob.FullName = reader["FullName"].ToString();
                ob.FatherGuardianName = reader["FatherGuardianName"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.Religion = reader["Religion"].ToString();
                ob.Age = reader["Age"].ToString();
                ob.UniqueIdentification = reader["UniqueIdentification"].ToString();
                ob.FoundPlace = reader["FoundPlace"].ToString();
                ob.Language = reader["Language"].ToString();
                ob.ClothColor = reader["ClothColor"].ToString();
                ob.EyesColor = reader["EyesColor"].ToString();
                ob.Description = reader["Description"].ToString();
                ob.Gander = reader["Gander"].ToString();
                ob.Status = reader["Status"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }
    }
}
