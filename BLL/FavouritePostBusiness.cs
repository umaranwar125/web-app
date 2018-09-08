using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class FavouritePostBusiness
    {
        FavoutitePostDB ob = new FavoutitePostDB();
        // Select Favourite Post.
        public List<FavouritePostPageObjects> FavouritePost(int RegistrationID)
        {
            return ob.FavouritePost(RegistrationID);
        }

        // To Fetch a Logged in User ID.
        public void GetUserID(string Username)
        {
            ob.GetUserID(Username);
        }

        // Select Missing People Poss
        public List<MissingPeoplePageObjects> DisplayFavouriteMissingPeoplePosts(int peopleID)
        {
            return ob.DisplayFavouriteMissingPeoplePosts(peopleID);
        }

        // Select Favourite Missing Thing Posts.
        public List<MissingThingPageObject> DisplayFavouriteMissingThingsPosts(int ThingID)
        {
            return ob.DisplayFavouriteMissingThingsPosts(ThingID);
        }

        // Select Favourite Unidentified People Posts.
        public List<UnidentifiedPeoplePageObject> DisplayFavouriteUnidentifiedPeoplePosts(int UnidentifiedID)
        {
            return ob.DisplayFavouriteUnidentifiedPeoplePosts(UnidentifiedID);
        }

        // Delete Favourite Post.
        public bool DeleteFavouritePost(int FavouriteID)
        {
            return ob.DeleteFavouritePost(FavouriteID);
        }
    }
}
