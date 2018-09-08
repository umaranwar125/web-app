using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BOL;
using BLL;

namespace UI
{
    public partial class MissingPeopleReport : System.Web.UI.Page
    {
        int Registration_ID;
        public List<MissingPeoplePageObjects> DisplayPopularPostOfMissingPeople;
        public List<MissingThingPageObject> DisplayPopularPostOfMissingThing;
        public List<UnidentifiedPeoplePageObject> DisplayPopularPostOfUnidentifiedPeople;
           
        // Page Load Event.
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionsRemove();
            DisplayMissingPeopleDataInPopularPost();
            DisplayMissingThingDataInPopularPost();
            DisplayUnidentifiedPeopleDataInPopularPost();
        }

        // Form Submit Button Click Event.
        protected void FormSubmit_Click(object sender, EventArgs e)
        {
            // Missing Date.
            string calender = Date.Value.ToString();
            calender += "/" + MissingPeopleMonth.Value.ToString();
            calender += "/" + MissingPeopleYear.Value.ToString();

            // Reference Number.
            Random ReferenceNo = new Random();
            string value = ReferenceNo.Next(10000, 99999).ToString() + "-" + ReferenceNo.Next(100, 999).ToString();

            if (Session["username"] == null)
            {
                Session["MissingPeople"] = "Missing People Session";
                Response.Redirect("login");
            }
            else
            {
                // Missing People Object.
                MissingPeopleBussiness ob = new MissingPeopleBussiness();
                // Get user ID Method Calling.
                ob.GetUserID(Session["username"].ToString());

                if (MissingPeopleImage.HasFile)
                {
                    // Image.
                    string path = MissingPeopleImage.FileName.ToString();
                    MissingPeopleImage.PostedFile.SaveAs(Server.MapPath(".") + "//Image//" + path);
                    string str = "Image/" + path.ToString();
                    if (Date.SelectedIndex == 0 || MissingPeopleMonth.SelectedIndex == 0 || MissingPeopleYear.SelectedIndex == 0)
                    {
                        ErrorSelect.Visible = true;
                        Note.Visible = false;
                        Error_Image.Visible = false;
                    }
                    else
                    {
                        ErrorSelect.Visible = false;
                        if (MissingPeopleMale.Checked)
                        {
                            if (ob.MissingPeopleMethod(Registration_ID, value.ToString(), MissingPeopleName.Value.ToString(), MissingPeopleNickName.Value.ToString(), MissingPeopleCNIC.Value.ToString(), MissingPeopleGuardianName.Value.ToString(), MissingPeopleGuardianCNIC.Value.ToString(), MissingPeopleNameContact.Value.ToString(), MissingPeopleAnotherContact.Value.ToString(), MissingPeoplePermanent.Value.ToString(), MissingPeopleCurrent.Value.ToString(), MissingPeopleReligion.Value.ToString(), MissingPeopleAge.Value.ToString(), MissingPeoplePlace.Value.ToString(), calender, MissingPeopleTribe.Value.ToString(), MissingPeopleLanguage.Value.ToString(), MissingPeopleClothes.Value.ToString(), MissingPeopleHeight.Value.ToString(), MissingPeopleWeight.Value.ToString(), MissingPeopleEyes.Value.ToString(), MissingPeopleHair.Value.ToString(), MissingPeopleDescription.Value.ToString(), MissingPeopleMale.Value.ToString(), str))
                                Visibility();
                        }
                        else if (MissingPeopleFemale.Checked)
                        {
                            if (ob.MissingPeopleMethod(Registration_ID, value.ToString(), MissingPeopleName.Value.ToString(), MissingPeopleNickName.Value.ToString(), MissingPeopleCNIC.Value.ToString(), MissingPeopleGuardianName.Value.ToString(), MissingPeopleGuardianCNIC.Value.ToString(), MissingPeopleNameContact.Value.ToString(), MissingPeopleAnotherContact.Value.ToString(), MissingPeoplePermanent.Value.ToString(), MissingPeopleCurrent.Value.ToString(), MissingPeopleReligion.Value.ToString(), MissingPeopleAge.Value.ToString(), MissingPeoplePlace.Value.ToString(), calender, MissingPeopleTribe.Value.ToString(), MissingPeopleLanguage.Value.ToString(), MissingPeopleClothes.Value.ToString(), MissingPeopleHeight.Value.ToString(), MissingPeopleWeight.Value.ToString(), MissingPeopleEyes.Value.ToString(), MissingPeopleHair.Value.ToString(), MissingPeopleDescription.Value.ToString(), MissingPeopleFemale.Value.ToString(), str))
                                Visibility();
                        }
                    }
                }
                else if (!MissingPeopleImage.HasFile)
                {
                    Error_Image.Visible = true;
                    Note.Visible = false;
                    ErrorSelect.Visible = false;
                }
            }
        }

        // Method When Condition Become True;
        private void Visibility()
        {
            ReportSuccessfull.Visible = true;
            Error_Image.Visible = false;
            ErrorSelect.Visible = false;
            Note.Visible = false;
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
    }
}