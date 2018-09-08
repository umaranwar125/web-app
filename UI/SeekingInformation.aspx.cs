using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOL;
using BLL;

namespace UI
{
    public partial class SeekingInformation : System.Web.UI.Page
    {
        public List<MissingPeoplePageObjects> DisplayPopularPostOfMissingPeople;
        public List<MissingThingPageObject> DisplayPopularPostOfMissingThing;
        public List<UnidentifiedPeoplePageObject> DisplayPopularPostOfUnidentifiedPeople;
        public List<MissingPeoplePageObjects> SearchDataForMissingPeople;
        public List<MissingThingPageObject> SearchDataForMissingThing;
        public List<UnidentifiedPeoplePageObject> SearchDataForUnidentifiedPeople;
        public List<MissingPeoplePageObjects> SearchPeopleDataInRegularSearchBar;
        public List<MissingThingPageObject> SearchThingDataInRegularSearchBar;
        public List<UnidentifiedPeoplePageObject> SearchUnidentifiedDataInRegularSearchBar;
        SeekingInformationBussiness ob = new SeekingInformationBussiness();
        // Page Load Event.
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionsRemove();
            DisplayMissingPeopleDataInPopularPost();
            DisplayMissingThingDataInPopularPost();
            DisplayUnidentifiedPeopleDataInPopularPost();
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
            Session.Remove("Favourite");
            Session.Remove("Feedback");
        }

        // Search Filter.
        protected void SearchButton_Click(object sender, EventArgs e)
        {
            SeekingInformationBussiness ob = new SeekingInformationBussiness();
            if (CategoryName.SelectedIndex == 0)
            {
                ErrorCategory.Visible = true;
            }
            else if (CategoryName.SelectedIndex == 1)
            {
                ErrorCategory.Visible = false;
                SearchDataForMissingPeople = ob.SearchDataForMissingPeople(Name.Value.ToString(), GuardianName.Value.ToString(), Contact.Value.ToString());
            }
            else if (CategoryName.SelectedIndex == 2)
            {
                ErrorCategory.Visible = false;
                SearchDataForMissingThing = ob.SearchDataForMissingThing(Name.Value.ToString(), GuardianName.Value.ToString(), Contact.Value.ToString());
            }
            else if (CategoryName.SelectedIndex == 3)
            {
                ErrorCategory.Visible = false;
                SearchDataForUnidentifiedPeople = ob.SearchDataForUnidentifiedPeople(Name.Value.ToString(), GuardianName.Value.ToString(), Contact.Value.ToString());
            }
        }

        protected void RegularSearch_Click(object sender, EventArgs e)
        {
            SearchPeopleDataInRegularSearchBar = ob.SearchMissingPeopleDataInRegularSearch(top_search.Value.ToString());
            SearchThingDataInRegularSearchBar = ob.SearchMissingThingDataInRegularSearch(top_search.Value.ToString());
            SearchUnidentifiedDataInRegularSearchBar = ob.SearchUnidentifiedPeopleDataInRegularSearch(top_search.Value.ToString());
        }
    }
}