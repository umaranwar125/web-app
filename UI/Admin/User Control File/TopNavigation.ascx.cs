using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Services;
using BOL;
using BLL;

namespace UI.Admin.User_Control_File
{
    public partial class TopNavigation : System.Web.UI.UserControl
    {
        int AdminID;
        string strCon;
        SqlConnection con;
        public List<AdminProfilePageObjects> DisplayAdminProfile;
        public List<MissingPeoplePageObjects> SelectIDFromPeople;
        public List<MissingThingPageObject> SelectIDFromThing;
        public List<ReportSightingPageObjects> SelectIDFromSighting;
        public List<UnidentifiedPeoplePageObject> SelectIDFromUnidentified;
        public List<RegistrationObjects> SelectRegisteredData;
        public static List<ContactUsPageObjects> DisplayContactsInMessages;
        AdminProfileBussiness ob = new AdminProfileBussiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminUsername"] == null)
                Response.Redirect("Login.aspx");
            ob.GetAdminID(Session["AdminUsername"].ToString());
            DisplayAdminProfile = ob.SelectAdminProfileData(AdminID);
            GetActiveAdminID(Session["AdminUsername"].ToString());
            DisplayMessages();
            ftn();
        }

        // Display Messages Data.
        public static void DisplayMessages()
        {
            ContactBussiness ob1 = new ContactBussiness();
            DisplayContactsInMessages = ob1.SelectContactPageDataForAdminPanel();
        }

        // Getting Active Admin ID.
        public void GetActiveAdminID(string Username)
        {
            string constr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand GetID = new SqlCommand("SelectAdminIDAndUsername", con);
            GetID.CommandType = System.Data.CommandType.StoredProcedure;
            GetID.Parameters.AddWithValue("@Username", Username);
            SqlDataReader reader = GetID.ExecuteReader();
            if (reader.Read())
            {
                AdminID = Convert.ToInt16(reader["AdminID"]);
                Session["AdminID"] = AdminID;
                con.Close();
                reader.Close();
            }
        }

        // Connection to Database.
        public void connection()
        {
            strCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            con = new SqlConnection(strCon);
            con.Open();
        }

        // Selecting Missing People Data For Notification.
        private List<MissingPeoplePageObjects> SelectRegisterationIDFromMissingPeople()
        {
            connection();
            List<MissingPeoplePageObjects> ls = new List<MissingPeoplePageObjects>();
            SqlCommand SelectData = new SqlCommand("SelectMissingPeopleForNotification", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            while (reader.Read())
            {
                MissingPeoplePageObjects ob = new MissingPeoplePageObjects();
                ob.RegistrationID = Convert.ToInt32(reader["RegistrationID"]);
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }

        // Selecting Missing Thing Data For Notification.
        private List<MissingThingPageObject> SelectRegisterationIDFromMissingThing()
        {
            connection();
            List<MissingThingPageObject> ls = new List<MissingThingPageObject>();
            SqlCommand SelectData = new SqlCommand("SelectMissingThingForNotification", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            while (reader.Read())
            {
                MissingThingPageObject ob = new MissingThingPageObject();
                ob.RegistrationID = Convert.ToInt32(reader["RegistrationID"]);
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }

        // Selecting Unidentified People Data For Notification.
        private List<UnidentifiedPeoplePageObject> SelectRegisterationIDFromUnidentifiedPeople()
        {
            connection();
            List<UnidentifiedPeoplePageObject> ls = new List<UnidentifiedPeoplePageObject>();
            SqlCommand SelectData = new SqlCommand("SelectUnidentifiedPeopleForNotification", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            while (reader.Read())
            {
                UnidentifiedPeoplePageObject ob = new UnidentifiedPeoplePageObject();
                ob.RegistrationID = Convert.ToInt32(reader["RegistrationID"]);
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }

        // Selecting ReportSighting Data For Notification.
        private List<ReportSightingPageObjects> SelectRegisterationIDFromReportSighting()
        {
            connection();
            List<ReportSightingPageObjects> ls = new List<ReportSightingPageObjects>();
            SqlCommand SelectData = new SqlCommand("SelectReportSightingForNotification", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = SelectData.ExecuteReader();
            while (reader.Read())
            {
                ReportSightingPageObjects ob = new ReportSightingPageObjects();
                ob.RegistrationID = Convert.ToInt32(reader["RegistrationID"]);
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }

        // Selecting Registration Data For Notification.
        public List<RegistrationObjects> SelectRegisterationData(int Reg_ID)
        {
            connection();
            List<RegistrationObjects> ls = new List<RegistrationObjects>();
            SqlCommand SelectData = new SqlCommand("SelectRegisterationDataForNotification", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@RegistrationID", Reg_ID);
            SqlDataReader reader = SelectData.ExecuteReader();
            if (reader.Read())
            {
                RegistrationObjects ob = new RegistrationObjects();
                ob.RegistrationID = Convert.ToInt16(reader["RegistrationID"]);
                ob.FullName = reader["FullName"].ToString();
                ob.Image = reader["Image"].ToString();
                ls.Add(ob);
            }
            con.Close();
            reader.Close();
            return ls;
        }

        public void ftn()
        {
            SelectIDFromPeople = SelectRegisterationIDFromMissingPeople();
            SelectIDFromThing = SelectRegisterationIDFromMissingThing();
            SelectIDFromUnidentified = SelectRegisterationIDFromUnidentifiedPeople();
            SelectIDFromSighting = SelectRegisterationIDFromReportSighting();
        }
    }
}