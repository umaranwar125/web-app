using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class AdminAllReportsDataBussiness
    {
        AdminAllReportsDataDB ob = new AdminAllReportsDataDB();
        public List<MissingPeoplePageObjects> SelectMissingPeopleMethod()
        {
            return ob.SelectMissingPeopleMethod();
        }

        public List<MissingThingPageObject> SelectMissingThingMethod()
        {
            return ob.SelectMissingThingMethod();
        }
    
        public List<UnidentifiedPeoplePageObject> SelectUnidentifiedPeopleMethod()
        {
            return ob.SelectUnidentifiedPeopleMethod();
        }
    }
}
