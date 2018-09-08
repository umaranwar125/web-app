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
    public class FavoutitePostDB
    {
        int R_ID;
        string r;
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
                R_ID = Convert.ToInt32(reader["RegistrationID"]);
                reader.Close();
                con.Close();
            }
        }

        // Select Favourite Post IDs.
        public List<FavouritePostPageObjects> FavouritePost(int registrationID)
        {
            List<FavouritePostPageObjects> ls = new List<FavouritePostPageObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectFavouritePostsIDs", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@registrationID", R_ID);
            SqlDataReader reader = SelectData.ExecuteReader();
            while (reader.Read())
            {
                FavouritePostPageObjects ob = new FavouritePostPageObjects();
                ob.FavouriteID = Convert.ToInt32(reader["FavouritePostID"]);
                ob.RegistrationID = Convert.ToInt32(reader["RegistrationID"]);
                if(reader["PeopleID"] == DBNull.Value)
                    r = string.Empty;
                else
                    ob.PeopleID = Convert.ToInt32(reader["PeopleID"]);
                if (reader["ThingID"] == DBNull.Value)
                    r = string.Empty;
                else
                    ob.ThingID = Convert.ToInt32(reader["ThingID"]);
                if (reader["UnidentifiedID"] == DBNull.Value)
                    r = string.Empty;
                else
                    ob.UnidentifiedID = Convert.ToInt32(reader["UnidentifiedID"]);
                ls.Add(ob);
            }
            reader.Close();
            con.Close();
            return ls;
        }

        // Select Favourite Missing People Posts.
        public List<MissingPeoplePageObjects> DisplayFavouriteMissingPeoplePosts(int peopleID)
        {
            // Select Missing People Poss
            List<MissingPeoplePageObjects> ls = new List<MissingPeoplePageObjects>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectFavouriteMissingPeoplePosts", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@PeopleID", peopleID);
            SqlDataReader reader = SelectData.ExecuteReader();
            while (reader.Read())
            {
                MissingPeoplePageObjects obj = new MissingPeoplePageObjects();
                obj.PeopleID = Convert.ToInt32(reader["PeopleID"]);
                obj.ReferenceNumber = reader["ReferenceNumber"].ToString();
                obj.FullName = reader["FullName"].ToString();
                obj.CNIC = reader["CNIC"].ToString();
                obj.ContactNumber = reader["ContactNumber"].ToString();
                obj.MissingDate = reader["MissingDate"].ToString();
                obj.Image = reader["Image"].ToString();
                obj.Status = reader["Status"].ToString();
                obj.Count = Convert.ToInt32(reader["Count"]);
                ls.Add(obj);
            }
            reader.Close();
            con.Close();
            return ls;
        }

        // Select Favourite Missing Thing Posts.
        public List<MissingThingPageObject> DisplayFavouriteMissingThingsPosts(int ThingID)
        {
            // Select Missing People Poss
            List<MissingThingPageObject> ls = new List<MissingThingPageObject>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectFavouriteMissingThingPosts", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@ThingsID", ThingID);
            SqlDataReader reader = SelectData.ExecuteReader();
            while (reader.Read())
            {
                MissingThingPageObject ob = new MissingThingPageObject();
                ob.ThingID = Convert.ToInt32(reader["ThingID"]);
                ob.OwnerName = reader["OwnerName"].ToString();
                ob.OwnerCNIC = reader["OwnerCNIC"].ToString();
                ob.ReferenceNumber = reader["ReferenceNumber"].ToString();
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

        // Select Favourite Unidentified People Posts.
        public List<UnidentifiedPeoplePageObject> DisplayFavouriteUnidentifiedPeoplePosts(int UnidentifiedID)
        {
            // Select Missing People Poss
            List<UnidentifiedPeoplePageObject> ls = new List<UnidentifiedPeoplePageObject>();
            connection();
            SqlCommand SelectData = new SqlCommand("SelectFavouriteUnidentifiedPosts", con);
            SelectData.CommandType = CommandType.StoredProcedure;
            SelectData.Parameters.AddWithValue("@UnidentifiedID", UnidentifiedID);
            SqlDataReader reader = SelectData.ExecuteReader();
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

        // Delete Favourite Post.
        public bool DeleteFavouritePost(int FavouriteID)
        {
            connection();
            SqlCommand DeletePost = new SqlCommand("DeleteFavouritePost", con);
            DeletePost.CommandType = CommandType.StoredProcedure;
            DeletePost.Parameters.AddWithValue("@favouriteID", FavouriteID);
            DeletePost.ExecuteNonQuery();
            con.Close();
            return true;
        }
    }
}
