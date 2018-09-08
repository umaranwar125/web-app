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
    public class ViewAllPostsDB
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

        // Select Missing People data for View All Post Page.
        public List<MissingPeoplePageObjects> SelectDataForViewAllPosts()
        {
            connection();
            List<MissingPeoplePageObjects> ls = new List<MissingPeoplePageObjects>();
            SqlCommand DisplayData = new SqlCommand("SelectMissingPeopleDataForViewAllPost", con);
            DisplayData.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = DisplayData.ExecuteReader();
            while(reader.Read())
            {
                MissingPeoplePageObjects ob = new MissingPeoplePageObjects();
                ob.FullName = reader["FullName"].ToString();
                ob.ContactNumber = reader["ContactNumber"].ToString();
                ob.MissingDate = reader["MissingDate"].ToString();
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
