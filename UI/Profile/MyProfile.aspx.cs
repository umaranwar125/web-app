using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOL;
using BLL;

namespace UI.Profile
{
    public partial class MyProfile : System.Web.UI.Page
    {
        public List<RegistrationObjects> DisplayUserProfile;
        public List<MissingPeoplePageObjects> DisplayMissingPeopleData;
        public List<MissingThingPageObject> DisplayMissingThingData;
        public List<UnidentifiedPeoplePageObject> DisplayUnidentifiedPeopleData;
        UserProfileBussiness ProfileOB = new UserProfileBussiness();
        RegistrationBussiness ob = new RegistrationBussiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["username"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            AllMethodAndObjects();
        }

        // List Objects.
        private void AllMethodAndObjects()
        {
            DisplayUserProfile = ob.SelectRegistrationData(Session["username"].ToString());
            ProfileOB.GetUserID(Session["username"].ToString());
            DisplayMissingPeopleData = ProfileOB.GetPeopleDataFromDatabase();
            DisplayMissingThingData = ProfileOB.GetThingDataFromDatabase();
            DisplayUnidentifiedPeopleData = ProfileOB.GetUnidentifiedPeopleDataFromDatabase();
            DisplayUser();
            QueryString();
        }

        // Querystrings.
        private void QueryString()
        {
            if (Request.QueryString["Missing-People-Delete-ID"] != null)
            {
                ProfileOB.DeleteFavouriteMissingPeoplePost(Request.QueryString["Missing-People-Delete-ID"].ToString());
                if (ProfileOB.DeleteMissingPeoplePost(Request.QueryString["Missing-People-Delete-ID"]))
                    Response.Redirect("MyProfile.aspx");
            }
            else if(Request.QueryString["Missing-Thing-Delete-ID"] != null)
            {
                ProfileOB.DeleteFavouriteMissingThingPost(Request.QueryString["Missing-Thing-Delete-ID"].ToString());
                if(ProfileOB.DeleteMissingThingPost(Request.QueryString["Missing-Thing-Delete-ID"]))
                    Response.Redirect("MyProfile.aspx");
            }
            else if (Request.QueryString["Unidentified-People-Delete-ID"] != null)
            {
                ProfileOB.DeleteFavouriteUnidentifiedPeoplePost(Request.QueryString["Unidentified-People-Delete-ID"].ToString());
                if (ProfileOB.DeleteUnidentifiedPeoplePost(Request.QueryString["Unidentified-People-Delete-ID"]))
                    Response.Redirect("MyProfile.aspx");
            }
        }

        // Display User Method.
        private void DisplayUser()
        {
            DisplayUserProfile = ob.SelectRegistrationData(Session["username"].ToString());
        }
    }
}