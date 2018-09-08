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
    public class ReportSightningDB
    {
        string ReferenceNumber;
        int RegistrationID;
        string conStr;
        SqlConnection con;

        // Connection To Databse.
        public void connection()
        {
            conStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            con = new SqlConnection(conStr);
            con.Open();
        }

        // Get User ID.
        public void GetUserId(string username)
        {
            connection();
            SqlCommand GetID = new SqlCommand("SelectRegistrationIDforMissinsgPeople", con);
            GetID.CommandType = CommandType.StoredProcedure;
            GetID.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = GetID.ExecuteReader();
            if (reader.Read())
            {
                RegistrationID = Convert.ToInt16(reader["RegistrationID"]);
                reader.Close();
                con.Close();
            }
        }

        // Get Reference Numberof Missinf People.
        public bool GetPostReferenceForPeople(string ReferenceNumb)
        {
            connection();
            SqlCommand GetReference = new SqlCommand("SelectReferenceNumberofPeopleForReportSighting", con);
            GetReference.CommandType = CommandType.StoredProcedure;
            GetReference.Parameters.AddWithValue("@Reference", ReferenceNumb);
            SqlDataReader reader = GetReference.ExecuteReader();
            if(reader.Read())
            {
                ReferenceNumber = reader["ReferenceNumber"].ToString();
                reader.Close();
                con.Close(); 
                return true;
            }
            return false;
        }

        // Get Reference Number of Missinf Thing.
        public bool GetPostReferenceForThing(string ReferenceNumb)
        {
            connection();
            SqlCommand GetReference = new SqlCommand("SelectReferenceNumberofThingForReportSighting", con);
            GetReference.CommandType = CommandType.StoredProcedure;
            GetReference.Parameters.AddWithValue("@Reference", ReferenceNumb);
            SqlDataReader reader = GetReference.ExecuteReader();
            if (reader.Read())
            {
                ReferenceNumber = reader["ReferenceNumber"].ToString();
                reader.Close();
                con.Close();
                return true;
            }
            return false;
        }

        // Insert Data Into Report Sighting along With Reference Number.
        public bool InsertReportSightingDataWithReferenec(int R_ID,string Reference, string MissingThingName, string CompanyName, string BrandName, string Color, string CNICNumber, string CNICFamily, string MissingPersonname, string FoundDate, string FoundPlace, string CCTVCamera, string Cloth, string Advertisement, string Image, string Gander, string YourName, string Email, string Contact, string CurrentAddress, string AskQuestion)
        {
            connection();
            SqlCommand InsertData = new SqlCommand("InsertDataIntoReportSightingWithReferenceNumber", con);
            InsertData.CommandType = CommandType.StoredProcedure;
            InsertData.Parameters.AddWithValue("@RegistrationID", RegistrationID);
            InsertData.Parameters.AddWithValue("@ReferenceNumber", ReferenceNumber);
            InsertData.Parameters.AddWithValue("@MissingThingName", MissingThingName);
            InsertData.Parameters.AddWithValue("@CompanyName", CompanyName);
            InsertData.Parameters.AddWithValue("@BrandName", BrandName);
            InsertData.Parameters.AddWithValue("@Color", Color);
            InsertData.Parameters.AddWithValue("@CNICNumber", CNICNumber);
            InsertData.Parameters.AddWithValue("@CNICFamily", CNICFamily);
            InsertData.Parameters.AddWithValue("@MissingPersonName", MissingPersonname);
            InsertData.Parameters.AddWithValue("@FoundDate", FoundDate);
            InsertData.Parameters.AddWithValue("@FoundPlace", FoundPlace);
            InsertData.Parameters.AddWithValue("@CCTVCamera", CCTVCamera);
            InsertData.Parameters.AddWithValue("@Cloth", Cloth);
            InsertData.Parameters.AddWithValue("@Advertisement", Advertisement);
            InsertData.Parameters.AddWithValue("@Image", Image);
            InsertData.Parameters.AddWithValue("@Gander", Gander);
            InsertData.Parameters.AddWithValue("@YourName", YourName);
            InsertData.Parameters.AddWithValue("@Email", Email);
            InsertData.Parameters.AddWithValue("@Contact", Contact);
            InsertData.Parameters.AddWithValue("@CurrentAddress", CurrentAddress);
            InsertData.Parameters.AddWithValue("@AskQuestion", AskQuestion);
            InsertData.ExecuteNonQuery();
            return true;
        }

        // Insert Data Into Report Sighting Database.
        public bool InsertReportSightingData(int R_ID,string MissingThingName, string CompanyName, string BrandName, string Color, string CNICNumber, string CNICFamily, string MissingPersonname, string FoundDate, string FoundPlace, string CCTVCamera, string Cloth, string Advertisement, string Image, string Gander, string YourName, string Email, string Contact, string CurrentAddress, string AskQuestion)
        {
            connection();
            SqlCommand InsertData = new SqlCommand("InsertDataIntoReportSighting", con);
            InsertData.CommandType = CommandType.StoredProcedure;
            InsertData.Parameters.AddWithValue("@RegistrationID", RegistrationID);
            InsertData.Parameters.AddWithValue("@MissingThingName", MissingThingName);
            InsertData.Parameters.AddWithValue("@CompanyName", CompanyName);
            InsertData.Parameters.AddWithValue("@BrandName", BrandName);
            InsertData.Parameters.AddWithValue("@Color", Color);
            InsertData.Parameters.AddWithValue("@CNICNumber", CNICNumber);
            InsertData.Parameters.AddWithValue("@CNICFamily", CNICFamily);
            InsertData.Parameters.AddWithValue("@MissingPersonName", MissingPersonname);
            InsertData.Parameters.AddWithValue("@FoundDate", FoundDate);
            InsertData.Parameters.AddWithValue("@FoundPlace", FoundPlace);
            InsertData.Parameters.AddWithValue("@CCTVCamera", CCTVCamera);
            InsertData.Parameters.AddWithValue("@Cloth", Cloth);
            InsertData.Parameters.AddWithValue("@Advertisement", Advertisement);
            InsertData.Parameters.AddWithValue("@Image", Image);
            InsertData.Parameters.AddWithValue("@Gander", Gander);
            InsertData.Parameters.AddWithValue("@YourName", YourName);
            InsertData.Parameters.AddWithValue("@Email", Email);
            InsertData.Parameters.AddWithValue("@Contact", Contact);
            InsertData.Parameters.AddWithValue("@CurrentAddress", CurrentAddress);
            InsertData.Parameters.AddWithValue("@AskQuestion", AskQuestion);
            InsertData.ExecuteNonQuery();
            return true;
        }

        // Select Report Sighting Data For Admin Panel.
        public List<ReportSightingPageObjects> SelectReportSightingMethodForAdminPanel()
        {
            List<ReportSightingPageObjects> ls = new List<ReportSightingPageObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectAllDataOfReportSighting", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            while (reader.Read())
            {
                ReportSightingPageObjects ob = new ReportSightingPageObjects();
                ob.SightingID = Convert.ToInt32(reader["SightingID"]);
                ob.RegistrationID = Convert.ToInt32(reader["RegistrationID"]);
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
                ob.MissingThingName = reader["MissingThingName"].ToString();
                ob.MissingPersonName = reader["MissingPersonName"].ToString();
                ob.CompanyName = reader["CompanyName"].ToString();
                ob.BrandName = reader["BrandName"].ToString();
                ob.Color = reader["Color"].ToString();
                ob.CNICNumber = reader["CNICNumber"].ToString();
                ob.CNICFamilyNumber = reader["CNICFamilyNumber"].ToString();
                ob.FoundDate = reader["FoundDate"].ToString();
                ob.FoundPlace = reader["FoundPlace"].ToString();
                ob.CCTVCamera = reader["CCTVCamera"].ToString();
                ob.Clothes = reader["Clothes"].ToString();
                ob.Advertisement = reader["Advertisement"].ToString();
                ob.Image = reader["Image"].ToString();
                ob.Gander = reader["Gander"].ToString();
                ob.YourName = reader["YourName"].ToString();
                ob.EmailAddress = reader["EmailAddress"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.CurrentAddress = reader["CurrentAddress"].ToString();
                ob.AskQuestion = reader["AskQuestions"].ToString();
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }

        // Delete Report Sighting Report.
        public bool DeleteSightingReport(int SightingID)
        {
            connection();
            SqlCommand DeleteData = new SqlCommand("DeleteSightingReportFromAdminPanel", con);
            DeleteData.CommandType = CommandType.StoredProcedure;
            DeleteData.Parameters.AddWithValue("@SightingID", SightingID);
            DeleteData.ExecuteNonQuery();
            con.Close();
            return true;
        }

        // Search Report Sighting Data.
        public List<ReportSightingPageObjects> SearchReportSightingData(string Name)
        {
            List<ReportSightingPageObjects> ls = new List<ReportSightingPageObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectReportSightingDataForAdminPanelSearch", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@Name", Name);
            SqlDataReader reader = SelectData.ExecuteReader();
            while (reader.Read())
            {
                ReportSightingPageObjects ob = new ReportSightingPageObjects();
                ob.SightingID = Convert.ToInt32(reader["SightingID"]);
                ob.RegistrationID = Convert.ToInt32(reader["RegistrationID"]);
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
                ob.MissingThingName = reader["MissingThingName"].ToString();
                ob.MissingPersonName = reader["MissingPersonName"].ToString();
                ob.CompanyName = reader["CompanyName"].ToString();
                ob.BrandName = reader["BrandName"].ToString();
                ob.Color = reader["Color"].ToString();
                ob.CNICNumber = reader["CNICNumber"].ToString();
                ob.CNICFamilyNumber = reader["CNICFamilyNumber"].ToString();
                ob.FoundDate = reader["FoundDate"].ToString();
                ob.FoundPlace = reader["FoundPlace"].ToString();
                ob.CCTVCamera = reader["CCTVCamera"].ToString();
                ob.Clothes = reader["Clothes"].ToString();
                ob.Advertisement = reader["Advertisement"].ToString();
                ob.Image = reader["Image"].ToString();
                ob.Gander = reader["Gander"].ToString();
                ob.YourName = reader["YourName"].ToString();
                ob.EmailAddress = reader["EmailAddress"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.CurrentAddress = reader["CurrentAddress"].ToString();
                ob.AskQuestion = reader["AskQuestions"].ToString();
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }

        // Select Total Number of Posts From Report SIghting For Admin Panel.
        public List<ReportSightingPageObjects> TotalReportSightingPosts()
        {
            List<ReportSightingPageObjects> ls = new List<ReportSightingPageObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectSightingReportsCountPosts", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            if (reader.Read())
            {
                ReportSightingPageObjects ob = new ReportSightingPageObjects();
                ob.SightingID = Convert.ToInt32(reader["SightingID"]);
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }
    }
}
