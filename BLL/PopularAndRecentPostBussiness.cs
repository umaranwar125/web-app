using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class PopularAndRecentPostBussiness
    {
        PopularAndRecentPostDB ob = new PopularAndRecentPostDB();

        // Callig Services for Popular Missing People Data.
        public List<MissingPeoplePageObjects> GetDataForPopularPeoplePost()
        {
            return ob.GetDataForPopularPeoplePost();
        }

        // Callig Services for Popular Missing People Data.
        public List<MissingThingPageObject> GetDataForPopularThingPost()
        {
            return ob.GetDataForPopularThingPost();
        }

        // Callig Services for Popular Unidentified People Data.
        public List<UnidentifiedPeoplePageObject> GetDataForPopularUnidentifiedPost()
        {
            return ob.GetDataForPopularUnidentifiedPost();
        }
        
        // Callig Services for Recent Missing People Data.
        public List<MissingPeoplePageObjects> GetDataForMissingPeoplePost()
        {
            return ob.GetDataForRecentPeoplePost();
        }

        // Callig Services for Recent Missing Thing Data.
        public List<MissingThingPageObject> GetDataForRecentThingPost()
        {
            return ob.GetDataForRecentThingPost();
        }

        // Callig Services for Recent Unidentified Peole Data.
        public List<UnidentifiedPeoplePageObject> GetDataForRecentUnidentifiedPost()
        {
            return ob.GetDataForRecentUnidentifiedPost();
        }
    }
}
