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
    public class SeekingInformationDB
    {
        string conStr;
        SqlConnection con;

        // Database Connection.
        private void connection()
        {
            conStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            con = new SqlConnection(conStr);
            con.Open();
        }

        // Searching data for MIssing People in Filter.
        public List<MissingPeoplePageObjects> SearchDataForMissingPeople(string Name, string FatherGuardianName, string Contact)
        {
            connection();
            List<MissingPeoplePageObjects> ls = new List<MissingPeoplePageObjects>();
            SqlCommand GetData = new SqlCommand("SelectMissingPeopleDataForSeekingInformation", con);
            GetData.CommandType = CommandType.StoredProcedure;
            GetData.Parameters.AddWithValue("@Name", Name);
            GetData.Parameters.AddWithValue("@FatherGuardianName", FatherGuardianName);
            GetData.Parameters.AddWithValue("@Contact", Contact);
            SqlDataReader reader = GetData.ExecuteReader();
            while(reader.Read())
            {
                MissingPeoplePageObjects ob = new MissingPeoplePageObjects();
                ob.FullName = reader["FullName"].ToString();
                ob.PeopleID = Convert.ToInt32(reader["PeopleID"]);
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.FatherGuardianName = reader["FatherGuardianName"].ToString();
                ob.MissingPlace = reader["MissingPlace"].ToString();
                ob.MissingDate = reader["MissingDate"].ToString();
                ob.Gander = reader["Gander"].ToString();
                ob.Religion = reader["Religion"].ToString();
                ob.Age = reader["Age"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
           
        }

        // Searching data for MIssing Thing in Filter.
        public List<MissingThingPageObject> SearchDataForMissingThing(string Name, string FatherGuardianName, string Contact)
        {
            connection();
            List<MissingThingPageObject> ls = new List<MissingThingPageObject>();
            SqlCommand GetData = new SqlCommand("SelectMissingThingDataForSeekingInformation", con);
            GetData.CommandType = CommandType.StoredProcedure;
            GetData.Parameters.AddWithValue("@Name", Name);
            GetData.Parameters.AddWithValue("@FatherGuardianName", FatherGuardianName);
            GetData.Parameters.AddWithValue("@Contact", Contact);
            SqlDataReader reader = GetData.ExecuteReader();
            while (reader.Read())
            {
                MissingThingPageObject ob = new MissingThingPageObject();
                ob.OwnerName = reader["OwnerName"].ToString();
                ob.ThingID = Convert.ToInt32(reader["ThingID"]);
                ob.ThingName = reader["ThingName"].ToString();
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.FatherGuardianName = reader["FatherGuardianName"].ToString();
                ob.MissingPlace = reader["MissingPlace"].ToString();
                ob.MissingDate = reader["MissingDate"].ToString();
                ob.CurrentAddress = reader["CurrentAddress"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            return ls;
            reader.Close();
            con.Close();
        }

        // Searching data for Unidentified People in Filter.
        public List<UnidentifiedPeoplePageObject> SearchDataForUnidentifiedPeople(string Name, string FatherGuardianName, string Contact)
        {
            connection();
            List<UnidentifiedPeoplePageObject> ls = new List<UnidentifiedPeoplePageObject>();
            SqlCommand GetData = new SqlCommand("SelectUnidentifiedPeopleDataForSeekingInformation", con);
            GetData.CommandType = CommandType.StoredProcedure;
            GetData.Parameters.AddWithValue("@Name", Name);
            GetData.Parameters.AddWithValue("@FatherGuardianName", FatherGuardianName);
            GetData.Parameters.AddWithValue("@Contact", Contact);
            SqlDataReader reader = GetData.ExecuteReader();
            while (reader.Read())
            {
                UnidentifiedPeoplePageObject ob = new UnidentifiedPeoplePageObject();
                ob.FullName = reader["FullName"].ToString();
                ob.UnindentifiedID = Convert.ToInt32(reader["UnindentifiedID"]);
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.FatherGuardianName = reader["FatherGuardianName"].ToString();
                ob.FoundPlace = reader["FoundPlace"].ToString();
                ob.Language = reader["Language"].ToString();
                ob.ClothColor = reader["ClothColor"].ToString();
                ob.Age = reader["Age"].ToString();
                ob.Gander = reader["Gander"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            return ls;
            reader.Close();
            con.Close();
        }

        // Searching data for Missing People in Regular Search.
        public List<MissingPeoplePageObjects> SearchMissingPeopleDataInRegularSearch(string Name)
        {
            connection();
            List<MissingPeoplePageObjects> ls = new List<MissingPeoplePageObjects>();
            SqlCommand GetData = new SqlCommand("SelectMissingPeopleDataForSearchSeekingInformation", con);
            GetData.CommandType = CommandType.StoredProcedure;
            GetData.Parameters.AddWithValue("@Name", Name);
            SqlDataReader reader = GetData.ExecuteReader();
            while (reader.Read())
            {
                MissingPeoplePageObjects ob = new MissingPeoplePageObjects();
                ob.FullName = reader["FullName"].ToString();
                ob.PeopleID = Convert.ToInt32(reader["PeopleID"]);
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.FatherGuardianName = reader["FatherGuardianName"].ToString();
                ob.MissingPlace = reader["MissingPlace"].ToString();
                ob.MissingDate = reader["MissingDate"].ToString();
                ob.Gander = reader["Gander"].ToString();
                ob.Religion = reader["Religion"].ToString();
                ob.Age = reader["Age"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            return ls;
            reader.Close();
            con.Close();
        }

        // Searching data for Missing Thing in Regular Search.
        public List<MissingThingPageObject> SearchMissingThingDataInRegularSearch(string Name)
        {
            connection();
            List<MissingThingPageObject> ls = new List<MissingThingPageObject>();
            SqlCommand GetData = new SqlCommand("SelectMissingThingDataForSearchSeekingInformation", con);
            GetData.CommandType = CommandType.StoredProcedure;
            GetData.Parameters.AddWithValue("@Name", Name);
            SqlDataReader reader = GetData.ExecuteReader();
            while (reader.Read())
            {
                MissingThingPageObject ob = new MissingThingPageObject();
                ob.OwnerName = reader["OwnerName"].ToString();
                ob.ThingID = Convert.ToInt32(reader["ThingID"]);
                ob.ThingName = reader["ThingName"].ToString();
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.FatherGuardianName = reader["FatherGuardianName"].ToString();
                ob.MissingPlace = reader["MissingPlace"].ToString();
                ob.MissingDate = reader["MissingDate"].ToString();
                ob.CurrentAddress = reader["CurrentAddress"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            return ls;
            reader.Close();
            con.Close();
        }

        // Searching data for Unidentified People in Regular Search.
        public List<UnidentifiedPeoplePageObject> SearchUnidentifiedPeopleDataInRegularSearch(string Name)
        {
            connection();
            List<UnidentifiedPeoplePageObject> ls = new List<UnidentifiedPeoplePageObject>();
            SqlCommand GetData = new SqlCommand("SelectUnidentifiedPeopleDataForSearchSeekingInformation", con);
            GetData.CommandType = CommandType.StoredProcedure;
            GetData.Parameters.AddWithValue("@Name", Name);
            SqlDataReader reader = GetData.ExecuteReader();
            while (reader.Read())
            {
                UnidentifiedPeoplePageObject ob = new UnidentifiedPeoplePageObject();
                ob.FullName = reader["FullName"].ToString();
                ob.UnindentifiedID = Convert.ToInt32(reader["UnindentifiedID"]);
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.FatherGuardianName = reader["FatherGuardianName"].ToString();
                ob.FoundPlace = reader["FoundPlace"].ToString();
                ob.Language = reader["Language"].ToString();
                ob.ClothColor = reader["ClothColor"].ToString();
                ob.Age = reader["Age"].ToString();
                ob.Gander = reader["Gander"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            return ls;
            reader.Close();
            con.Close();
        }

        // Searching data for Missing People in Admin Panel.
        public List<MissingPeoplePageObjects> SearchMissingPeopleDataInAdminPanel(string Name)
        {
            connection();
            List<MissingPeoplePageObjects> ls = new List<MissingPeoplePageObjects>();
            SqlCommand GetData = new SqlCommand("SelectMissingPeopleDataForSearch", con);
            GetData.CommandType = CommandType.StoredProcedure;
            GetData.Parameters.AddWithValue("@Name", Name);
            SqlDataReader reader = GetData.ExecuteReader();
            while (reader.Read())
            {
                MissingPeoplePageObjects ob = new MissingPeoplePageObjects();
                ob.PeopleID = Convert.ToInt32(reader["PeopleID"]);
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
            return ls;
            reader.Close();
            con.Close();
        }

        // Searching data for Missing Thing in Admin Panel.
        public List<MissingThingPageObject> SearchMissingThingDataInAdminPanel(string Name)
        {
            connection();
            List<MissingThingPageObject> ls = new List<MissingThingPageObject>();
            SqlCommand GetData = new SqlCommand("SelectMissingThingDataForSearch", con);
            GetData.CommandType = CommandType.StoredProcedure;
            GetData.Parameters.AddWithValue("@Name", Name);
            SqlDataReader reader = GetData.ExecuteReader();
            while (reader.Read())
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
            return ls;
            reader.Close();
            con.Close();
        }

        // Searching data for Unidentified People in Admin Panel.
        public List<UnidentifiedPeoplePageObject> SearchUnidentifiedPeopleDataInAdminPanel(string Name)
        {
            connection();
            List<UnidentifiedPeoplePageObject> ls = new List<UnidentifiedPeoplePageObject>();
            SqlCommand GetData = new SqlCommand("SelectUnidentifiedPeopleDataForSearch", con);
            GetData.CommandType = CommandType.StoredProcedure;
            GetData.Parameters.AddWithValue("@Name", Name);
            SqlDataReader reader = GetData.ExecuteReader();
            while (reader.Read())
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
            return ls;
            reader.Close();
            con.Close();
        }
    }
}
