using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class DefaultBussiness
    {
        DefaultDB ob = new DefaultDB();

        // Calling Missing People Display Method.
        public List<MissingPeoplePageObjects> GetPeopleDataFromDatabase()
        {
            return ob.GetPeopleDataFromDatabase();
        }

        // Calling Missing Thing Display Method.
        public List<MissingThingPageObject> GetThingDataFromDatabase()
        {
            return ob.GetThingDataFromDatabase();
        }

        // Calling Unidentified People Display Method.
        public List<UnidentifiedPeoplePageObject> GetUnidentifiedPeopleDataFromDatabase()
        {
            return ob.GetUnidentifiedPeopleDataFromDatabase();
        }

        // To Get User ID
        public void GetUserID(string Username)
        {
            ob.GetUserID(Username);
        }

        // Checking Missing People Favourite Post Existance
        public bool CheckMissingPeopleFavouritePost(int Registration_Id, int PeopleID)
        {
            return ob.CheckMissingPeopleFavouritePost(Registration_Id, PeopleID);
        }

        // Checking Missing Thing Favourite Post Existance
        public bool CheckMissingThingFavouritePost(int Registration_Id, int ThingID)
        {
            return ob.CheckMissingThingFavouritePost(Registration_Id, ThingID);
        }

        // Checking Unidentified People Favourite Post Existance
        public bool CheckUnidentifiedPeopleFavouritePost(int Registration_Id, int UnidentifiedID)
        {
            return ob.CheckUnidentifiedPeopleFavouritePost(Registration_Id, UnidentifiedID);
        }

        // Calling Favourite People Post Method.
        public void InsertPeopleFavouriteID(int PeopleID)
        {
            ob.InsertPeopleFavouriteID(PeopleID);
        }

        // Calling Favourite Thing Post Method.
        public void InsertThingFavouriteID(int ThingID)
        {
            ob.InsertThingFavouriteID(ThingID);
        }

        // Calling Favourite Unidentified Post Method.
        public void InsertUnidentifiedFavouriteID(int UnidentifiedID)
        {
            ob.InsertUnidentifiedFavouriteID(UnidentifiedID);
        }

        // Select Missing People Poat For Print.
        public List<MissingPeoplePageObjects> SelectMissingPeoplePostForPrint(int PeopleID)
        {
            return ob.SelectMissingPeoplePostForPrint(PeopleID);
        }
    }
}
