using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing.Printing;
using BOL;
using BLL;

namespace UI
{
    public partial class Default : System.Web.UI.Page
    {
        int Registration_ID;
        public List<MissingPeoplePageObjects> Post_display;
        public List<MissingThingPageObject> Things_Post_display;
        public List<UnidentifiedPeoplePageObject> Unidentified_Post_display;
        public List<MissingPeoplePageObjects> DisplayRecentPostOfMissingPeople;
        public List<MissingThingPageObject> DisplayRecentPostOfMissingThing;
        public List<UnidentifiedPeoplePageObject> DisplayRecentPostOfUnidentifiedPeople;
        public List<MissingPeoplePageObjects> DisplayPopularPostOfMissingPeople;
        public List<MissingThingPageObject> DisplayPopularPostOfMissingThing;
        public List<UnidentifiedPeoplePageObject> DisplayPopularPostOfUnidentifiedPeople;
        public List<FavouritePostPageObjects> CheckTrue;
        // Page Load Event.
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionsRemove();
            DisplayMissingPeoplePost();
            DisplayMissingThingPost();
            DisplayUnidentifiedPeoplePost();
            DisplayMissingPeopledatainRecentPost();
            DisplayMissingThingDataInRecentPost();
            DisplayUnidentifiedDataInRecentPost();
            DisplayMissingPeopleDataInPopularPost();
            DisplayMissingThingDataInPopularPost();
            DisplayUnidentifiedPeopleDataInPopularPost();
            InsertFavouritePostID();
            DefaultBussiness ob = new DefaultBussiness();

            if (Session["FavouriteSuccess"] != null)
            {
                ClientScript.RegisterStartupScript(GetType(), "", "<script>FavouritePost();</script>");
                Session.Remove("FavouriteSuccess");
            }
            if(Session["FavouriteFailure"] != null)
            {
                ClientScript.RegisterStartupScript(GetType(), "", "<script>FavouritePostFailure();</script>");
                Session.Remove("FavouriteFailure");
            }
        }

        // Display missing people Data.
        private void DisplayMissingPeoplePost()
        {
            DefaultBussiness ob = new DefaultBussiness();
            Post_display = ob.GetPeopleDataFromDatabase();
        }

        // Display Missing Thing Data.
        private void DisplayMissingThingPost()
        {
            DefaultBussiness ob = new DefaultBussiness();
            Things_Post_display = ob.GetThingDataFromDatabase();
        }

        // Display Unidentified People Data.
        private void DisplayUnidentifiedPeoplePost()
        {
            DefaultBussiness ob = new DefaultBussiness();
            Unidentified_Post_display = ob.GetUnidentifiedPeopleDataFromDatabase();
        }

        // Display Missing People Post in Recent data Section.
        private void DisplayMissingPeopledatainRecentPost()
        {
            PopularAndRecentPostBussiness ob1 = new PopularAndRecentPostBussiness();
            DisplayRecentPostOfMissingPeople = ob1.GetDataForMissingPeoplePost();
        }

        // Display Missing Thing Data in recent Post Section.
        private void DisplayMissingThingDataInRecentPost()
        {
            PopularAndRecentPostBussiness ob1 = new PopularAndRecentPostBussiness();
            DisplayRecentPostOfMissingThing = ob1.GetDataForRecentThingPost();
        }
        
        // Display Unidentified People Data in Recent Post Section.
        private void DisplayUnidentifiedDataInRecentPost()
        {
            PopularAndRecentPostBussiness ob1 = new PopularAndRecentPostBussiness();
            DisplayRecentPostOfUnidentifiedPeople = ob1.GetDataForRecentUnidentifiedPost();
        }

        // Display Missing People Data in Popular Post Section.
        private void DisplayMissingPeopleDataInPopularPost()
        {
            PopularAndRecentPostBussiness ob = new PopularAndRecentPostBussiness();
            DisplayPopularPostOfMissingPeople =  ob.GetDataForPopularPeoplePost();
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
                    ob.GetUserID(Session["username"].ToString());
                    if (ob.CheckMissingPeopleFavouritePost(Registration_ID, Convert.ToInt16(Request.QueryString["Favourite_Missing_People_ID"])))
                    {
                        Session["FavouriteSuccess"] = "FavouriteSuccess";
                        ob.GetUserID(Session["username"].ToString());
                        ob.InsertPeopleFavouriteID(Convert.ToInt16(Request.QueryString["Favourite_Missing_People_ID"]));
                    }
                    else
                        Session["FavouriteFailure"] = "FavouriteSuccess";
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
                    ob.GetUserID(Session["username"].ToString());
                    if (ob.CheckMissingThingFavouritePost(Registration_ID, Convert.ToInt16(Request.QueryString["Favourite_Missing_Thing_ID"])))
                    {
                        Session["FavouriteSuccess"] = "FavouriteSuccess";
                        ob.GetUserID(Session["username"].ToString());
                        ob.InsertThingFavouriteID(Convert.ToInt16(Request.QueryString["Favourite_Missing_Thing_ID"]));
                    }
                    else
                        Session["FavouriteFailure"] = "FavouriteSuccess";
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
                    ob.GetUserID(Session["username"].ToString());
                    if (ob.CheckUnidentifiedPeopleFavouritePost(Registration_ID, Convert.ToInt16(Request.QueryString["Favourite_Unidentified_People_ID"])))
                    {
                        Session["FavouriteSuccess"] = "FavouriteSuccess";
                        ob.GetUserID(Session["username"].ToString());
                        ob.InsertUnidentifiedFavouriteID(Convert.ToInt16(Request.QueryString["Favourite_Unidentified_People_ID"]));
                    }
                    else
                        Session["FavouriteFailure"] = "FavouriteSuccess";
                }
            }
        }
    }
}