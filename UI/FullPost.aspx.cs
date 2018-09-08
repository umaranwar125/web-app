using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BLL;
using BOL;

namespace UI
{
    public partial class FullPost : System.Web.UI.Page
    {
        static int reg_id;
        static int People_ID;
        static int AutoMobile_ID;
        static int CNIC_ID;
        static int Mobile_ID;
        static int Unidentified_ID;
        static string fullname;
        public static string image;
        public static SqlDataReader reader;
        public List<MissingPeoplePageObjects> MissingPeopleObject;
        public List<MissingThingPageObject> MissingThingObject;
        public List<UnidentifiedPeoplePageObject> UnidentifiedPeopleObject;
        public List<RegistrationObjects> UserImageAndName;
        public List<MissingPeoplePageObjects> DisplayPopularPostOfMissingPeople;
        public List<MissingThingPageObject> DisplayPopularPostOfMissingThing;
        public List<UnidentifiedPeoplePageObject> DisplayPopularPostOfUnidentifiedPeople;
        public static List<CommentObjects> DisplayAllComments;
        public static List<CommentObjects> DisplayAutoMobileComments;
        public static List<CommentObjects> DisplayMobileComments;
        public static List<CommentObjects> DisplayCNICComments;
        public static List<CommentObjects> DisplayUnidentifiedPeopleComments;

        FullPostPageBussiness ob = new FullPostPageBussiness();

        // Page Load Event.
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayMissingPeopleDataInPopularPost();
            DisplayMissingThingDataInPopularPost();
            DisplayUnidentifiedPeopleDataInPopularPost();
            InsertFavouritePostID();
            if (Session["username"] == null)
            {
                Session["FullPost"] = "Full Post Session";
                Response.Redirect("login");
            }
            else
            {
                QueryString();
                UpdateCountColoumn();
                UserImageAndName = ob.GetImageAndName(Session["username"].ToString());
            }

            // Delete Comments.
            if (Request.QueryString["Missing_People_Delete_ID"] != null)
            {
                DeleteMissingPeopleComents();
            }
            else if (Request.QueryString["CNIC_Delete_ID"] != null)
            {
                DeleteCNICComents();
            }
            else if (Request.QueryString["AutoMobile_Delete_ID"] != null)
            {
                DeleteAutoMobileComents();
            }
            else if (Request.QueryString["Mobile_Delete_ID"] != null)
            {
                DeleteMobileComents();
            }
            else if (Request.QueryString["UnidentifiedPeople_Delete_ID"] != null)
            {
                DeleteUnidentifiedPeopleComents();
            }
        }

        // Query String.
        private void QueryString()
        {
            if (Request.QueryString["Missing_People_Id"] != null)
            {
                People_ID = Convert.ToInt32(Request.QueryString["Missing_People_Id"]);
                MissingPeopleBussiness ob1 = new MissingPeopleBussiness();
                DisplayAllComments = ob1.SelectCommentOfMisingPeople(People_ID);
                MissingPeopleObject = ob.GetPeopleDataUsingQueryString(Convert.ToInt16(Request.QueryString["Missing_People_Id"]));
            }
            else if (Request.QueryString["Missing_Thing_Id"] != null)
            {
                AutoMobile_ID = Convert.ToInt32(Request.QueryString["Missing_Thing_Id"]);
                Mobile_ID = Convert.ToInt32(Request.QueryString["Missing_Thing_Id"]);
                CNIC_ID = Convert.ToInt32(Request.QueryString["Missing_Thing_Id"]);
                MissingThingBussiness ob1 = new MissingThingBussiness();
                DisplayAutoMobileComments = ob1.SelectCommentOfAutoMobile(AutoMobile_ID);
                DisplayMobileComments = ob1.SelectCommentOfMobile(Mobile_ID);
                DisplayCNICComments = ob1.SelectCommentOfCNIC(CNIC_ID);
                MissingThingObject = ob.GetThingsDataUsingQueryString(Convert.ToInt16(Request.QueryString["Missing_Thing_Id"]));
            }
            else if (Request.QueryString["Unidentified_People_Id"] != null)
            {
                Unidentified_ID = Convert.ToInt32(Request.QueryString["Unidentified_People_Id"]);
                UnidentifiedPeopleBussiness ob1 = new UnidentifiedPeopleBussiness();
                DisplayUnidentifiedPeopleComments = ob1.SelectCommentOfUnidentifiedPeople(Unidentified_ID);
                UnidentifiedPeopleObject = ob.GetUnidentifiedPeopleDataUsingQueryString(Convert.ToInt16(Request.QueryString["Unidentified_People_Id"]));
            }
        }

        // Updating Count Column.
        private void UpdateCountColoumn()
        {
            ob.UpdateCountOfMissingPeople(Convert.ToInt16(Request.QueryString["Missing_People_Id"]));
            ob.UpdateCountOfMissingThing(Convert.ToInt16(Request.QueryString["Missing_Thing_Id"]));
            ob.UpdateCountOfUnidentifiedPeople(Convert.ToInt16(Request.QueryString["Unidentified_People_Id"]));
        }

        // Sessions Remove Method.
        private void SessionsRemove()
        {
            Session.Remove("RegisteredSuccessfully");
            Session.Remove("contact");
            Session.Remove("MissingPeople");
            Session.Remove("MissingThing");
            Session.Remove("UnidentifiedPeople");
            Session.Remove("ReportSighting");
            Session.Remove("FullPost");
            Session.Remove("ResetPassword");
            Session.Remove("Feedback");
            Session.Remove("Favourite");
        }

        // Display Missing People Data in Popular Post Section.
        private void DisplayMissingPeopleDataInPopularPost()
        {
            PopularAndRecentPostBussiness ob = new PopularAndRecentPostBussiness();
            DisplayPopularPostOfMissingPeople = ob.GetDataForPopularPeoplePost();
        }

        // Display Missing Thing Data in Popular Post Section.
        private void DisplayMissingThingDataInPopularPost()
        {
            PopularAndRecentPostBussiness ob = new PopularAndRecentPostBussiness();
            DisplayPopularPostOfMissingThing = ob.GetDataForPopularThingPost();
        }

        // Display Unidentified People Data in Popular Post Section.
        private void DisplayUnidentifiedPeopleDataInPopularPost()
        {
            PopularAndRecentPostBussiness ob = new PopularAndRecentPostBussiness();
            DisplayPopularPostOfUnidentifiedPeople = ob.GetDataForPopularUnidentifiedPost();
        }

        // Display Comments
        [WebMethod]
        public static void DisplayComments()
        {
            MissingPeopleBussiness ob1 = new MissingPeopleBussiness();
            DisplayAllComments = ob1.SelectCommentOfMisingPeople(People_ID);
        }

        // Delete Comments of Missing People Posts.
        private void DeleteMissingPeopleComents()
        {
            SelectRegistrationData(Session["username"].ToString());
            MissingPeopleBussiness ob = new MissingPeopleBussiness();
            ob.DeleteMissingPeopleComments(reg_id, Convert.ToInt32(HttpContext.Current.Request.QueryString["Missing_People_Delete_ID"]));
            Response.Redirect("missing-post?Missing_People_Id=" + Request.QueryString["Missing_People_Id"]);
        }

        // Delete Comments of CNIC Posts.
        private void DeleteCNICComents()
        {
            SelectRegistrationData(Session["username"].ToString());
            MissingThingBussiness ob = new MissingThingBussiness();
            ob.DeleteCNICComments(reg_id, Convert.ToInt32(HttpContext.Current.Request.QueryString["CNIC_Delete_ID"]));
            Response.Redirect("missing-post?Missing_Thing_Id=" + Request.QueryString["Missing_Thing_Id"]);
        }

        // Delete Comments of Auto Mobile Posts.
        private void DeleteAutoMobileComents()
        {
            SelectRegistrationData(Session["username"].ToString());
            MissingThingBussiness ob = new MissingThingBussiness();
            ob.DeleteAutoMobileComments(reg_id, Convert.ToInt32(HttpContext.Current.Request.QueryString["AutoMobile_Delete_ID"]));
            Response.Redirect("missing-post?Missing_Thing_Id=" + Request.QueryString["Missing_Thing_Id"]);
        }

        // Delete Comments of Mobile Posts.
        private void DeleteMobileComents()
        {
            SelectRegistrationData(Session["username"].ToString());
            MissingThingBussiness ob = new MissingThingBussiness();
            ob.DeleteMobileComments(reg_id, Convert.ToInt32(HttpContext.Current.Request.QueryString["Mobile_Delete_ID"]));
            Response.Redirect("missing-post?Missing_Thing_Id=" + Request.QueryString["Missing_Thing_Id"]);
        }

        // Delete comments of Unidentified People Posts.
        private void DeleteUnidentifiedPeopleComents()
        {
            SelectRegistrationData(Session["username"].ToString());
            MissingThingBussiness ob = new MissingThingBussiness();
            ob.DeleteMobileComments(reg_id, Convert.ToInt32(HttpContext.Current.Request.QueryString["UnidentifiedPeople_Delete_ID"]));
            Response.Redirect("missing-post?Unidentified_People_Id=" + Request.QueryString["Unidentified_People_Id"]);
        }

        // For Getting User Registration info.
        public static void SelectRegistrationData(string username)
        {
            string str = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("SelectRegistrationData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reg_id = Convert.ToInt32(reader["RegistrationID"]);
                fullname = reader["FullName"].ToString();
                image = reader["Image"].ToString();
            }
            reader.Close();
            con.Close();
        }

        // Favourite Post Query String.
        private void InsertFavouritePostID()
        {
            DefaultBussiness ob = new DefaultBussiness();
            if (Request.QueryString["Favourite_Missing_People_ID"] != null)
            {
                if (Session["username"] == null)
                {
                    Session["Favourite"] = "Favourite";
                    Response.Redirect("login");
                }
                else
                {
                    Session["FavouriteSuccess"] = "FavouriteSuccess";
                    ob.GetUserID(Session["username"].ToString());
                    ob.InsertPeopleFavouriteID(Convert.ToInt16(Request.QueryString["Favourite_Missing_People_ID"]));
                }
            }
            else if (Request.QueryString["Favourite_Missing_Thing_ID"] != null)
            {
                if (Session["username"] == null)
                {
                    Session["Favourite"] = "Favourite";
                    Response.Redirect("login");
                }
                else
                {
                    Session["FavouriteSuccess"] = "FavouriteSuccess";
                    ob.GetUserID(Session["username"].ToString());
                    ob.InsertThingFavouriteID(Convert.ToInt16(Request.QueryString["Favourite_Missing_Thing_ID"]));
                }
            }
            else if (Request.QueryString["Favourite_Unidentified_People_ID"] != null)
            {
                if (Session["username"] == null)
                {
                    Session["Favourite"] = "Favourite";
                    Response.Redirect("login");
                }
                else
                {
                    Session["FavouriteSuccess"] = "FavouriteSuccess";
                    ob.GetUserID(Session["username"].ToString());
                    ob.InsertUnidentifiedFavouriteID(Convert.ToInt16(Request.QueryString["Favourite_Unidentified_People_ID"]));
                }
            }
        }

        // Comment on Missing People
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                SelectRegistrationData(HttpContext.Current.Session["username"].ToString());
                MissingPeopleBussiness ob = new MissingPeopleBussiness();
                if (PeopleComment.Value != "")
                {
                    if (ob.PostComments(People_ID, reg_id, fullname, PeopleComment.Value, image))
                        Response.Redirect("missing-post?Missing_People_Id=" + Request.QueryString["Missing_People_Id"]);
                }
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>displayErrorMessage();</script>");
            }
            else
                Response.Redirect("login");
        }

        // Comment on CNIC Posts.
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                SelectRegistrationData(HttpContext.Current.Session["username"].ToString());
                MissingThingBussiness ob = new MissingThingBussiness();
                if (CnicComment.Value != "")
                {
                    if (ob.PostCommentsonCNIC(CNIC_ID, reg_id, fullname, CnicComment.Value, image))
                        Response.Redirect("missing-post?Missing_Thing_Id=" + Request.QueryString["Missing_Thing_Id"]);
                }
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>displayErrorMessage();</script>");
            }
            else
                Response.Redirect("login");
        }

        // Comment on Auto Mobile Posts.
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                SelectRegistrationData(HttpContext.Current.Session["username"].ToString());
                MissingThingBussiness ob = new MissingThingBussiness();
                if (AutoMobileComment.Value != "")
                    if (ob.PostCommentsonAutoMobile(AutoMobile_ID, reg_id, fullname, AutoMobileComment.Value, image))
                        Response.Redirect("missing-post?Missing_Thing_Id=" + Request.QueryString["Missing_Thing_Id"]);
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>displayErrorMessage();</script>");
            }
            else
                Response.Redirect("login");
        }

        // Comment on Mobile Posts.
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["username"] != null)
            {
                SelectRegistrationData(HttpContext.Current.Session["username"].ToString());
                MissingThingBussiness ob = new MissingThingBussiness();
                if (MobileComment.Value != "")
                {
                    if (ob.PostCommentsonMobile(Mobile_ID, reg_id, fullname, MobileComment.Value, image))
                        Response.Redirect("missing-post?Missing_Thing_Id=" + Request.QueryString["Missing_Thing_Id"]);
                }
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>displayErrorMessage();</script>");
            }
            else
                HttpContext.Current.Response.Redirect("login");
        }

        // Comment on Unidentified Posts.
        protected void Button5_Click(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                SelectRegistrationData(HttpContext.Current.Session["username"].ToString());
                UnidentifiedPeopleBussiness ob = new UnidentifiedPeopleBussiness();
                if (UnidentifiedPeopleComments.Value != "")
                {
                    if (ob.PostCommentsonUnidentifiedPeople(Unidentified_ID, reg_id, fullname, UnidentifiedPeopleComments.Value, image))
                        Response.Redirect("missing-post?Unidentified_People_Id=" + Request.QueryString["Unidentified_People_Id"]);
                }
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>displayErrorMessage();</script>");
            }
            else
                Response.Redirect("login");
        }
    }
}