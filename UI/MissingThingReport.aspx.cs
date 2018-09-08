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
    public partial class MissingThingReport : System.Web.UI.Page
    {
        int RegistrationID;
        public List<MissingPeoplePageObjects> DisplayPopularPostOfMissingPeople;
        public List<MissingThingPageObject> DisplayPopularPostOfMissingThing;
        public List<UnidentifiedPeoplePageObject> DisplayPopularPostOfUnidentifiedPeople;
        // Page Load Event.
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionsRemove();
            MissingThingSelectIndex();
            DisplayMissingPeopleDataInPopularPost();
            DisplayMissingThingDataInPopularPost();
            DisplayUnidentifiedPeopleDataInPopularPost();
        }

        // Missing Thing Button Click;
        protected void MissingThingButton_Click(object sender, EventArgs e)
        {
            // Missing Date.
            string Missingdate = Date.SelectedItem.Value.ToString();
            Missingdate += "/" + Month.SelectedItem.Value.ToString();
            Missingdate += "/" + Year.SelectedItem.Value.ToString();
            
            // CNIC Date of Birth.
            string CNICdate = CNICDate.Value.ToString();
            CNICdate += "/" + CNICMonth.Value.ToString();
            CNICdate += "/" + CNICYear.Value.ToString();

            // Checking Session.
            if (Session["username"] == null)
            {
                Session["MissingThing"] = "Missing Thing Session";
                Response.Redirect("login");
            }
            else
            {
                MissingThingBussiness ob = new MissingThingBussiness();
                // Reference Number.
                Random ReferenceNo = new Random();
                string value = ReferenceNo.Next(10000, 99990).ToString() + "-" + ReferenceNo.Next(100, 999).ToString();

                // Call GetUserId
                ob.GetUserId(Session["username"].ToString());
                if (Date.SelectedIndex == 0 || Month.SelectedIndex == 0 || Year.SelectedIndex == 0)
                {
                    ErrorDate.Visible = true;
                    Note.Visible = false;
                }
                else
                {
                    if (ThingSelect.SelectedIndex == 0)
                    {
                        ErrorDate.Visible = false;
                        ErrorSelect.Visible = true;
                        Note.Visible = false;
                    }
                    else if (ThingSelect.SelectedIndex == 1)
                    {
                        if (Image.HasFile)
                        {
                            // Image.
                            string path = Image.FileName.ToString();
                            Image.PostedFile.SaveAs(Server.MapPath(".") + "//Image//" + path);
                            string str = "Image/" + path.ToString();
                            if (ob.InsertDataIntoAutoMobile(RegistrationID, value, ThingOwnerName.Value.ToString(), ThingOwnerCNIC.Value.ToString(), ThingGuardianName.Value.ToString(), ThingGuardianCNIC.Value.ToString(), ThingContact.Value.ToString(), ThingAnotherContact.Value.ToString(), ThingSelect.SelectedItem.Value.ToString(), AutoCompany.Value.ToString(), BrandName.Value.ToString(), AutoEngine.Value.ToString(), AutoChasses.Value.ToString(), Color.Value.ToString(), Model.Value.ToString(), ThingMissingPlace.Value.ToString(), Missingdate, ThingDescription.Value.ToString(), ThingPermanentAddress.Value.ToString(), ThingCurrentAddress.Value.ToString(), str))
                                ConditionVIsibility();
                        }
                        else if (!Image.HasFile)
                        {
                            ErrorSelect.Visible = false;
                            if (ob.InsertDataIntoAutoMobile(RegistrationID, value, ThingOwnerName.Value.ToString(), ThingOwnerCNIC.Value.ToString(), ThingGuardianName.Value.ToString(), ThingGuardianCNIC.Value.ToString(), ThingContact.Value.ToString(), ThingAnotherContact.Value.ToString(), ThingSelect.SelectedItem.Value.ToString(), AutoCompany.Value.ToString(), BrandName.Value.ToString(), AutoEngine.Value.ToString(), AutoChasses.Value.ToString(), Color.Value.ToString(), Model.Value.ToString(), ThingMissingPlace.Value.ToString(), Missingdate, ThingDescription.Value.ToString(), ThingPermanentAddress.Value.ToString(), ThingCurrentAddress.Value.ToString(), "Image/Auto_Mobile.png"))
                                ConditionVIsibility();
                        }
                    }
                    else if (ThingSelect.SelectedIndex == 2)
                    {
                        if (Image.HasFile)
                        {
                            // Image.
                            string path = Image.FileName.ToString();
                            Image.PostedFile.SaveAs(Server.MapPath(".") + "//Image//" + path);
                            string str = "Image/" + path.ToString();
                            if (ob.InsertDataIntoMobile(RegistrationID, value, ThingOwnerName.Value.ToString(), ThingOwnerCNIC.Value.ToString(), ThingGuardianName.Value.ToString(), ThingGuardianCNIC.Value.ToString(), ThingContact.Value.ToString(), ThingAnotherContact.Value.ToString(), ThingSelect.SelectedItem.Value.ToString(), BrandName.Value.ToString(), Color.Value.ToString(), Model.Value.ToString(), ThingMissingPlace.Value.ToString(), Missingdate, MobileIMEI.Value.ToString(), ThingDescription.Value.ToString(), ThingPermanentAddress.Value.ToString(), ThingCurrentAddress.Value.ToString(), str))
                                ConditionVIsibility();
                        }
                        else if (!Image.HasFile)
                        {
                            ErrorSelect.Visible = false;
                            if (ob.InsertDataIntoMobile(RegistrationID, value, ThingOwnerName.Value.ToString(), ThingOwnerCNIC.Value.ToString(), ThingGuardianName.Value.ToString(), ThingGuardianCNIC.Value.ToString(), ThingContact.Value.ToString(), ThingAnotherContact.Value.ToString(), ThingSelect.SelectedItem.Value.ToString(), BrandName.Value.ToString(), Color.Value.ToString(), Model.Value.ToString(), ThingMissingPlace.Value.ToString(), Missingdate, MobileIMEI.Value.ToString(), ThingDescription.Value.ToString(), ThingPermanentAddress.Value.ToString(), ThingCurrentAddress.Value.ToString(), "Image/Mobile.jpg"))
                                ConditionVIsibility();
                        }
                    }
                    else if (ThingSelect.SelectedIndex == 3)
                    {
                        if (CNICDate.SelectedIndex == 0 || CNICMonth.SelectedIndex == 0 || CNICYear.SelectedIndex == 0)
                        {
                            ErrorDate.Visible = true;
                            Note.Visible = false;
                        }
                        else
                        {
                            if (Image.HasFile)
                            {
                                // Image.
                                string path = Image.FileName.ToString();
                                Image.PostedFile.SaveAs(Server.MapPath(".") + "//Image//" + path);
                                string str = "Image/" + path.ToString();
                                if (CNICMale.Checked)
                                {
                                    if (ob.InsertDataIntoCNIC(RegistrationID, value, ThingOwnerName.Value.ToString(), ThingOwnerCNIC.Value.ToString(), ThingGuardianName.Value.ToString(), ThingGuardianCNIC.Value.ToString(), ThingContact.Value.ToString(), ThingAnotherContact.Value.ToString(), ThingSelect.SelectedItem.Value.ToString(), ThingMissingPlace.Value.ToString(), Missingdate, ThingDescription.Value.ToString(), CNICNumber.Value.ToString(), CNICUnique.Value.ToString(), CNICdate, CNICFamily.Value.ToString(), ThingPermanentAddress.Value.ToString(), ThingCurrentAddress.Value.ToString(), CNICMale.Value, str))
                                        ConditionVIsibility();
                                    ErrorDate.Visible = false;
                                    Note.Visible = false;
                                }
                                else if (CNICFemale.Checked)
                                {
                                    ErrorSelect.Visible = false;
                                    if (ob.InsertDataIntoCNIC(RegistrationID, value, ThingOwnerName.Value.ToString(), ThingOwnerCNIC.Value.ToString(), ThingGuardianName.Value.ToString(), ThingGuardianCNIC.Value.ToString(), ThingContact.Value.ToString(), ThingAnotherContact.Value.ToString(), ThingSelect.SelectedItem.Value.ToString(), ThingMissingPlace.Value.ToString(), Missingdate, ThingDescription.Value.ToString(), CNICNumber.Value.ToString(), CNICUnique.Value.ToString(), CNICdate, CNICFamily.Value.ToString(), ThingPermanentAddress.Value.ToString(), ThingCurrentAddress.Value.ToString(), CNICFemale.Value, str))
                                        ConditionVIsibility();
                                    ErrorDate.Visible = false;
                                    Note.Visible = false;
                                }
                            }
                            else if (!Image.HasFile)
                            {
                                if (CNICMale.Checked)
                                {
                                    if (ob.InsertDataIntoCNIC(RegistrationID, value, ThingOwnerName.Value.ToString(), ThingOwnerCNIC.Value.ToString(), ThingGuardianName.Value.ToString(), ThingGuardianCNIC.Value.ToString(), ThingContact.Value.ToString(), ThingAnotherContact.Value.ToString(), ThingSelect.SelectedItem.Value.ToString(), ThingMissingPlace.Value.ToString(), Missingdate, ThingDescription.Value.ToString(), CNICNumber.Value.ToString(), CNICUnique.Value.ToString(), CNICdate, CNICFamily.Value.ToString(), ThingPermanentAddress.Value.ToString(), ThingCurrentAddress.Value.ToString(), CNICMale.Value, "Image/CNIC.png"))
                                        ConditionVIsibility();
                                    ErrorDate.Visible = false;
                                    Note.Visible = false;
                                }
                                else if (CNICFemale.Checked)
                                {
                                    ErrorSelect.Visible = false;
                                    if (ob.InsertDataIntoCNIC(RegistrationID, value, ThingOwnerName.Value.ToString(), ThingOwnerCNIC.Value.ToString(), ThingGuardianName.Value.ToString(), ThingGuardianCNIC.Value.ToString(), ThingContact.Value.ToString(), ThingAnotherContact.Value.ToString(), ThingSelect.SelectedItem.Value.ToString(), ThingMissingPlace.Value.ToString(), Missingdate, ThingDescription.Value.ToString(), CNICNumber.Value.ToString(), CNICUnique.Value.ToString(), CNICdate, CNICFamily.Value.ToString(), ThingPermanentAddress.Value.ToString(), ThingCurrentAddress.Value.ToString(), CNICFemale.Value, "Image/CNIC.png"))
                                        ConditionVIsibility();
                                    ErrorDate.Visible = false;
                                    Note.Visible = false;
                                }
                            }
                        }
                    }
                }
            }
        }

        // Execute when Condition is True.
        private void ConditionVIsibility()
        {
            ReportSuccessfull.Visible = true;
            Note.Visible = false;
            ErrorDate.Visible = false;
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

        // Input Visibility.
        private void Visibility(bool ErrorSelects, bool CompanyName, bool BrandName, bool EngineNumber, bool ChasesNumber, bool Color, bool Model, bool Image, bool CNICNumber, bool CNICIdentificatin, bool DOB, bool FamilyNumber, bool Gander, bool IMEI)
        {
            ErrorSelect.Visible = ErrorSelects;
            AutoCompanyHide.Visible = CompanyName;
            BrandHide.Visible = BrandName;
            AutoEngineHide.Visible = EngineNumber;
            AutoChassesHide.Visible = ChasesNumber;
            ColorHide.Visible = Color;
            ModelHide.Visible = Model;
            ImageHide.Visible = Image;
            CnicNumberHide.Visible = CNICNumber;
            CNICUniqueHide.Visible = CNICIdentificatin;
            CNICDateHide.Visible = DOB;
            CNICFamilyHide.Visible = FamilyNumber;
            CNICGanderHide.Visible = Gander;
            MobileIMEIHide.Visible = IMEI;
        }
       
        // Missing Thing Select Method.
        private void MissingThingSelectIndex()
        {
            if (ThingSelect.SelectedIndex == 1)
                Visibility(false, true, true, true, true, true, true, true, false, false, false, false, false, false);
            if (ThingSelect.SelectedIndex == 2)
                Visibility(false, false, true, false, false, true, true, true, false, false, false, false, false, true);
            if (ThingSelect.SelectedIndex == 3)
                Visibility(false, false, false, false, false, false, false, true, true, true, true, true, true, false);
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