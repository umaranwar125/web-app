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
    public partial class UnidentifiedPeople : System.Web.UI.Page
    {
        int RegistrationID;
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

        // InidentifiedButtonClick Event.
        protected void UnidentidiedButton_Click(object sender, EventArgs e)
        {
            // Reference Number.
            Random ReferenceNo = new Random();
            string value = ReferenceNo.Next(10000, 99999).ToString() + "-" + ReferenceNo.Next(100, 999).ToString();

            if(Session["username"] == null)
            {
                Session["UnidentifiedPeople"] = "Unidetified People Sessions";
                Response.Redirect("login");
            }
            else
            {
                UnidentifiedPeopleBussiness ob = new UnidentifiedPeopleBussiness();
                ob.UserRegistrationID(Session["username"].ToString());
                if(UnidentifiedImage.HasFile)
                {
                    ErrorImage.Visible = false;
                    // Image.
                    string path = UnidentifiedImage.FileName.ToString();
                    UnidentifiedImage.PostedFile.SaveAs(Server.MapPath(".") + "//Image//" + path);
                    string str = "Image/" + path.ToString();
                    if (UnidetifiedMale.Checked)
                    {
                        if (ob.UnidetifiedPeopleDataInsertion(RegistrationID, value, UnidentifiedName.Value.ToString(), UnidentifiedGuardianName.Value.ToString(), UnidentifiedContact.Value.ToString(), UnidentifiedReligion.Value.ToString(), UnidentifiedAge.Value.ToString(), UnidentifiedUnique.Value.ToString(), UnidentifiedFound.Value.ToString(), UnidentifiedLanguage.Value.ToString(), UnidentifiedCloth.Value.ToString(), UnidentifiedEyes.Value.ToString(), UnidentifiedDescription.Value.ToString(), UnidetifiedMale.Value.ToString(), str))
                        {
                            Note.Visible = false;
                            ReportSuccessfull.Visible = true;
                        }
                    }
                    else if(UnidetifiedFemale.Checked)
                    {
                        if (ob.UnidetifiedPeopleDataInsertion(RegistrationID, value, UnidentifiedName.Value.ToString(), UnidentifiedGuardianName.Value.ToString(), UnidentifiedContact.Value.ToString(), UnidentifiedReligion.Value.ToString(), UnidentifiedAge.Value.ToString(), UnidentifiedUnique.Value.ToString(), UnidentifiedFound.Value.ToString(), UnidentifiedLanguage.Value.ToString(), UnidentifiedCloth.Value.ToString(), UnidentifiedEyes.Value.ToString(), UnidentifiedDescription.Value.ToString(), UnidetifiedFemale.Value.ToString(), str))
                        {
                            Note.Visible = false;
                            ReportSuccessfull.Visible = true;
                        }
                    }
                }
                else if(!UnidentifiedImage.HasFile)
                {
                    ErrorImage.Visible = true;
                    Note.Visible = false;
                }
            }
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
    }
}