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
    public class AdminAllReportsDataDB
    {
        string conStr;
        SqlConnection con;

        // Connection to Database.
        private void connection()
        {
            conStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            con = new SqlConnection(conStr);
            con.Open();
        }

        // Select All Data for Missing People Table.
        public List<MissingPeoplePageObjects> SelectMissingPeopleMethod()
        {
            List<MissingPeoplePageObjects> ls = new List<MissingPeoplePageObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectAllDataOFMissingPeople", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            while(reader.Read())
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

        // Select All Data for Missing Thing Table.
        public List<MissingThingPageObject> SelectMissingThingMethod()
        {
            List<MissingThingPageObject> ls = new List<MissingThingPageObject>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectAllDataOFMissingThings", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            while(reader.Read())
            {
                MissingThingPageObject ob = new MissingThingPageObject();
                ob.ThingID = Convert.ToInt16(reader["ThingID"]);
                ob.Count = Convert.ToInt16(reader["Count"]);
                ob.RegistrationID = Convert.ToInt16(reader["RegistrationID"]);
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
                ob.OwnerName = reader["OwnerName"].ToString();
                ob.OwnerCNIC = reader["OwnerCNIC"].ToString();
                ob.FatherGuardianName = reader["FatherGuardianName"].ToString();
                ob.FatherGuardianCNIC = reader["FatherGuardianCNIC"].ToString();
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
                ob.Image = reader["Image"].ToString();
                ob.Status = reader["Status"].ToString();
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }

        // Select All Data for Unidentified People.
        public List<UnidentifiedPeoplePageObject> SelectUnidentifiedPeopleMethod()
        {
            List<UnidentifiedPeoplePageObject> ls = new List<UnidentifiedPeoplePageObject>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectAllDataOFUnidetifiedPeople", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            while(reader.Read())
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
