using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class FullPostPageBussiness
    {
        FullPostPageDB ob = new FullPostPageDB();

        // Calling User Image and Name Method. 
        public List<RegistrationObjects> GetImageAndName(string username)
        {
            return ob.GetImageAndName(username);
        }

        // calling update coujnt method for Unidentified People.
        public void UpdateCountOfUnidentifiedPeople(int UnidentifiedID)
        {
            ob.UpdateCountOfUnidentifiedPeople(UnidentifiedID);
        }

        // calling update coujnt method for Unidentified People.
        public void UpdateCountOfMissingThing(int ThingID)
        {
            ob.UpdateCountOfMissingThing(ThingID);
        }

        // calling update coujnt method for Unidentified People.
        public void UpdateCountOfMissingPeople(int PeopleID)
        {
            ob.UpdateCountOfMissingPeople(PeopleID);
        }

        // Calling People Data For diplay.
        public List<MissingPeoplePageObjects> GetPeopleDataUsingQueryString(int PeopleID)
        {
            return ob.GetPeopleDataUsingQueryString(PeopleID);
        }

        // Calling People Data For diplay.
        public List<MissingThingPageObject> GetThingsDataUsingQueryString(int ThingID)
        {
            return ob.GetThingsDataUsingQueryString(ThingID);
        }

        // Calling Unidentified People Data For diplay.
        public List<UnidentifiedPeoplePageObject> GetUnidentifiedPeopleDataUsingQueryString(int UnindentifiedID)
        {
            return ob.GetUnidentifiedPeopleDataUsingQueryString(UnindentifiedID);
        }
    }
}
