using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class SeekingInformationBussiness
    {
        SeekingInformationDB ob = new SeekingInformationDB();

        //  Calling Searching Data for Missing People Method.
        public List<MissingPeoplePageObjects> SearchDataForMissingPeople(string Name, string FatherGuardianName, string Contact)
        {
            return ob.SearchDataForMissingPeople(Name, FatherGuardianName, Contact);
        }

        //  Calling Searching Data for Missing Thing Method.
        public List<MissingThingPageObject> SearchDataForMissingThing(string Name, string FatherGuardianName, string Contact)
        {
            return ob.SearchDataForMissingThing(Name, FatherGuardianName, Contact);
        }

        //  Calling Searching Data for Unidentified People Method.
        public List<UnidentifiedPeoplePageObject> SearchDataForUnidentifiedPeople(string Name, string FatherGuardianName, string Contact)
        {
            return ob.SearchDataForUnidentifiedPeople(Name, FatherGuardianName, Contact);
        }

        // Searching data for Missing People in Regular Search.
        public List<MissingPeoplePageObjects> SearchMissingPeopleDataInRegularSearch(string Name)
        {
            return ob.SearchMissingPeopleDataInRegularSearch(Name);
        }

        // Searching data for Missing Thing in Regular Search.
        public List<MissingThingPageObject> SearchMissingThingDataInRegularSearch(string Name)
        {
            return ob.SearchMissingThingDataInRegularSearch(Name);
        }

        // Searching data for Unidentified People in Regular Search.
        public List<UnidentifiedPeoplePageObject> SearchUnidentifiedPeopleDataInRegularSearch(string Name)
        {
            return ob.SearchUnidentifiedPeopleDataInRegularSearch(Name);
        }

        // Searching data for Missing People in Admin Panel.
        public List<MissingPeoplePageObjects> SearchMissingPeopleDataInAdminPanel(string Name)
        {
            return ob.SearchMissingPeopleDataInAdminPanel(Name);
        }

        // Searching data for Missing Thing in Admin Panel.
        public List<MissingThingPageObject> SearchMissingThingDataInAdminPanel(string Name)
        {
            return ob.SearchMissingThingDataInAdminPanel(Name);
        }

        // Searching data for Unidentified People in Admin Panel.
        public List<UnidentifiedPeoplePageObject> SearchUnidentifiedPeopleDataInAdminPanel(string Name)
        {
            return ob.SearchUnidentifiedPeopleDataInAdminPanel(Name);
        }
    }
}
