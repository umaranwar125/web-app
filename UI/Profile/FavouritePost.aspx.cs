using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BOL;
using BLL;

namespace UI.Profile
{
    public partial class FavouritePost : System.Web.UI.Page
    {
        public int R_ID;
        public List<RegistrationObjects> DisplayUserData;
        public List<FavouritePostPageObjects> DisplayFavouritePosts;
        public List<MissingPeoplePageObjects> DisplayMissingPeopleFavouritePosts;
        public List<MissingThingPageObject> DisplayMissingThingFavouritePosts;
        public List<UnidentifiedPeoplePageObject> DisplayUnidentifiedPeopleFavouritePosts;
        RegistrationBussiness ob = new RegistrationBussiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["username"] == null)
                Response.Redirect("/Login.aspx");
            if (Session["FavourtiePostDelete"] != null)
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>displayCongratsFavouritePostMessage();</script>");
            if (!IsPostBack)
                Session.Remove("FavourtiePostDelete");
            DisplayUser();
            FavouritePosts();
            FavouritePostMethod();
            DeleteFavourtotePosts();
        }

        // Delete Favourite Post.
        private void DeleteFavourtotePosts()
        {
            if (Request.QueryString["Delete-Favourite-Post"] != null)
            {
                FavouritePostBusiness ob = new FavouritePostBusiness();
                if (ob.DeleteFavouritePost(Convert.ToInt32(Request.QueryString["Delete-Favourite-Post"])))
                {
                    Session["FavourtiePostDelete"] = "FavourtiePostDelete";
                    Response.Redirect("FavouritePost.aspx");
                }
            }
        }

        // Display User Method.
        private void DisplayUser()
        {
            DisplayUserData = ob.SelectRegistrationData(Session["username"].ToString());
        }

        // Select Favourite Posts.
        private void FavouritePosts()
        {
            FavouritePostBusiness ob2 = new FavouritePostBusiness();
            ob2.GetUserID(Session["username"].ToString());
            DisplayFavouritePosts = ob2.FavouritePost(R_ID);
        }

        public void FavouritePostMethod()
        {
            FavouritePostBusiness ob2 = new FavouritePostBusiness();
            ob2.GetUserID(Session["username"].ToString());
            List<FavouritePostPageObjects> DisplayFavouritePost = ob2.FavouritePost(R_ID);
        }
    }
}