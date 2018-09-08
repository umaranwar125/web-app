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
    public class PopularAndRecentPostDB
    {
        string strCon;
        SqlConnection con;

        // Connection to Database.
        public void connection()
        {
            strCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            con = new SqlConnection(strCon);
            con.Open();
        }

        // To Display a Most Viwed Missing People Post in Pouplar Section.
        public List<MissingPeoplePageObjects> GetDataForPopularPeoplePost()
        {
            connection();
            List<MissingPeoplePageObjects> ls = new List<MissingPeoplePageObjects>();
            SqlCommand DisplayData = new SqlCommand("SelectPopularPeoplePostData", con);
            DisplayData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = DisplayData.ExecuteReader();
            while (reader.Read())
            {
                MissingPeoplePageObjects ob = new MissingPeoplePageObjects();
                ob.PeopleID = Convert.ToInt16(reader["PeopleID"]);
                ob.FullName = reader["FullName"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.MissingPlace = reader["MissingPlace"].ToString();
                ob.Image = reader["Image"].ToString();
                ob.Description = reader["Description"].ToString();
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }

        // To Display a Most Viwed Missing Thing Post in Pouplar Section.
        public List<MissingThingPageObject> GetDataForPopularThingPost()
        {
            connection();
            List<MissingThingPageObject> ls = new List<MissingThingPageObject>();
            SqlCommand DisplayData = new SqlCommand("SelectPopularThingPostData", con);
            DisplayData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = DisplayData.ExecuteReader();
            if (reader.Read())
            {
                MissingThingPageObject ob = new MissingThingPageObject();
                ob.ThingID = Convert.ToInt16(reader["ThingID"]);
                ob.OwnerName = reader["OwnerName"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.MissingPlace = reader["MissingPlace"].ToString();
                ob.Image = reader["Image"].ToString();
                ob.Description = reader["Description"].ToString();
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }

        // To Display a Most Viwed Unidentified People Post in Pouplar Section.
        public List<UnidentifiedPeoplePageObject> GetDataForPopularUnidentifiedPost()
        {
            connection();
            List<UnidentifiedPeoplePageObject> ls = new List<UnidentifiedPeoplePageObject>();
            SqlCommand DisplayData = new SqlCommand("SelectPopularUnidentifiedPostData", con);
            DisplayData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = DisplayData.ExecuteReader();
            while (reader.Read())
            {
                UnidentifiedPeoplePageObject ob = new UnidentifiedPeoplePageObject();
                ob.UnindentifiedID = Convert.ToInt16(reader["UnindentifiedID"]);
                ob.FullName = reader["FullName"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.FoundPlace = reader["FoundPlace"].ToString();
                ob.Image = reader["Image"].ToString();
                ob.Description = reader["Description"].ToString();
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }

        // To display a Missing People data into Recent Section from Database.
        public List<MissingPeoplePageObjects> GetDataForRecentPeoplePost()
        {
            connection();
            List<MissingPeoplePageObjects> ls = new List<MissingPeoplePageObjects>();
            SqlCommand DisplayData = new SqlCommand("SelectRecentPeoplePostData", con);
            DisplayData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = DisplayData.ExecuteReader();
            while(reader.Read())
            {
                MissingPeoplePageObjects ob = new MissingPeoplePageObjects();
                ob.PeopleID = Convert.ToInt16(reader["PeopleID"]);
                ob.FullName = reader["FullName"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.MissingPlace = reader["MissingPlace"].ToString();
                ob.Image = reader["Image"].ToString();
                ob.Description = reader["Description"].ToString();
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }

        // To display a Missing Thing data into Recent Section from Database.
        public List<MissingThingPageObject> GetDataForRecentThingPost()
        {
            connection();
            List<MissingThingPageObject> ls = new List<MissingThingPageObject>();
            SqlCommand DisplayData = new SqlCommand("SelectRecentThingPostData", con);
            DisplayData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = DisplayData.ExecuteReader();
            while (reader.Read())
            {
                MissingThingPageObject ob = new MissingThingPageObject();
                ob.ThingID = Convert.ToInt16(reader["ThingID"]);
                ob.OwnerName = reader["OwnerName"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.MissingPlace = reader["MissingPlace"].ToString();
                ob.Image = reader["Image"].ToString();
                ob.Description = reader["Description"].ToString();
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }

        // To display a Unidentified People data into Recent Section from Database.
        public List<UnidentifiedPeoplePageObject> GetDataForRecentUnidentifiedPost()
        {
            connection();
            List<UnidentifiedPeoplePageObject> ls = new List<UnidentifiedPeoplePageObject>();
            SqlCommand DisplayData = new SqlCommand("SelectRecentUnidentifiedPostData", con);
            DisplayData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = DisplayData.ExecuteReader();
            while (reader.Read())
            {
                UnidentifiedPeoplePageObject ob = new UnidentifiedPeoplePageObject();
                ob.UnindentifiedID = Convert.ToInt16(reader["UnindentifiedID"]);
                ob.FullName = reader["FullName"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.FoundPlace = reader["FoundPlace"].ToString();
                ob.Image = reader["Image"].ToString();
                ob.Description = reader["Description"].ToString();
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }
    }
}
