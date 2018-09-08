using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using BOL;  

namespace UI
{
    public partial class ReportAsighting : System.Web.UI.Page
    {
        string ReferenceNumber;
        int RegistrationID;
        public List<MissingPeoplePageObjects> DisplayPopularPostOfMissingPeople;
        public List<MissingThingPageObject> DisplayPopularPostOfMissingThing;
        public List<UnidentifiedPeoplePageObject> DisplayPopularPostOfUnidentifiedPeople;
        // Page Load Event.
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionsRemove();
            MissingThingSelectIndexShow();
            AdvertisementSelectIndex();
            DisplayMissingPeopleDataInPopularPost();
            DisplayMissingThingDataInPopularPost();
            DisplayUnidentifiedPeopleDataInPopularPost();
        }

        // Report Sighting Button Click Event.
        protected void ReportSightingButton_Click(object sender, EventArgs e)
        {
            if(Session["username"] == null)
            {
                Session["ReportSighting"] = "Report Sighting Session";
                Response.Redirect("login");
            }
            else
            {
                if(ReportDate.SelectedIndex == 0 || ReportMonth.SelectedIndex == 0 || ReportYear.SelectedIndex == 0)
                {
                    DropDownListValidation(false, false, true, false);
                }
                else if(ReportCCTV.SelectedIndex == 0)
                {
                    DropDownListValidation(true, false, false, false);
                }
                else if (ReportPublicity.SelectedIndex == 0)
                {
                    DropDownListValidation(false, true, false, false);
                }
                else
                {
                     // Missing Date.
                    string calender = ReportDate.Value.ToString();
                    calender += "/" + ReportMonth.Value.ToString();
                    calender += "/" + ReportYear.Value.ToString();
                    ReportSightingBussiness ob = new ReportSightingBussiness();
                    ob.GetUderID(Session["username"].ToString());
                    if (ReportPublicity.SelectedIndex == 4)
                    {
                        if (ReportImage.HasFile)
                        {
                            // Image.
                            string path = ReportImage.FileName.ToString();
                            ReportImage.PostedFile.SaveAs(Server.MapPath(".") + "//Image//" + path);
                            string str = "Image/" + path.ToString();
                            if (ReportMale.Checked)
                            {
                                if(ReportYes.Checked)
                                {
                                    if (ob.GetPostReferenceForPeople(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if(ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), str, ReportMale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "Yes"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else if(ob.GetPostReferenceForThing(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), str, ReportMale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "Yes"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else
                                        IfConditionTrue(false, false, false, true, false);
                                }
                                else
                                {
                                    if (ob.GetPostReferenceForPeople(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), str, ReportMale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "No"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else if (ob.GetPostReferenceForThing(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), str, ReportMale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "No"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else
                                        IfConditionTrue(false, false, false, true, false);
                                }
                            }
                            else if (ReportFemale.Checked)
                            {
                                if (ReportYes.Checked)
                                {
                                    if (ob.GetPostReferenceForPeople(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), str, ReportFemale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "Yes"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else if (ob.GetPostReferenceForThing(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), str, ReportMale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "Yes"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else
                                        IfConditionTrue(false, false, false, true, false);
                                }
                                else
                                {
                                    if (ob.GetPostReferenceForPeople(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), str, ReportFemale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "No"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else if (ob.GetPostReferenceForThing(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), str, ReportMale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "No"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else
                                        IfConditionTrue(false, false, false, true, false);
                                }
                            }
                            else if (ReportMale.Checked == false || ReportFemale.Checked == false)
                            {
                                if (ReportYes.Checked)
                                {
                                    if (ob.GetPostReferenceForPeople(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), str, "NULL", ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "Yes"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else if (ob.GetPostReferenceForThing(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), str, "NULL", ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "Yes"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else
                                        IfConditionTrue(false, false, false, true, false);
                                }
                                else
                                {
                                    if (ob.GetPostReferenceForPeople(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), str, "NULL", ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "No"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else if (ob.GetPostReferenceForThing(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), str, "NULL", ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "No"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else
                                        IfConditionTrue(false, false, false, true, false);
                                }
                            }
                        }
                        else if (!ReportImage.HasFile)
                        {
                            if (ReportMale.Checked)
                            {
                                if (ReportYes.Checked)
                                {
                                    if (ob.GetPostReferenceForPeople(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), "Image/facebook-avatar.jpg", ReportMale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "Yes"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else if (ob.GetPostReferenceForThing(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), "Image/facebook-avatar.jpg", ReportMale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "Yes"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else
                                        IfConditionTrue(false, false, false, true, false);
                                }
                                else
                                {
                                    if (ob.GetPostReferenceForPeople(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), "Image/facebook-avatar.jpg", ReportMale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "No"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else if (ob.GetPostReferenceForThing(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), "Image/facebook-avatar.jpg", ReportMale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "No"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else
                                        IfConditionTrue(false, false, false, true, false);
                                }
                            }
                            else if (ReportFemale.Checked)
                            {
                                if (ReportYes.Checked)
                                {
                                    if (ob.GetPostReferenceForPeople(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), "Image/facebook-avatar.jpg", ReportFemale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "Yes"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else if (ob.GetPostReferenceForThing(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), "Image/facebook-avatar.jpg", ReportMale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "Yes"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else
                                        IfConditionTrue(false, false, false, true, false);
                                }
                                else
                                {
                                    if (ob.GetPostReferenceForPeople(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), "Image/facebook-avatar.jpg", ReportFemale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "No"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else if (ob.GetPostReferenceForThing(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), "Image/facebook-avatar.jpg", ReportMale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "No"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else
                                        IfConditionTrue(false, false, false, true, false);
                                }
                            }
                            else if (ReportMale.Checked == false || ReportFemale.Checked == false)
                            {
                                if (ReportYes.Checked)
                                {
                                    if (ob.GetPostReferenceForPeople(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), "Image/facebook-avatar.jpg", "NULL", ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "Yes"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else if (ob.GetPostReferenceForThing(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), "Image/facebook-avatar.jpg", "NULL", ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "Yes"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else
                                        IfConditionTrue(false, false, false, true, false);
                                }
                                else
                                {
                                    if (ob.GetPostReferenceForPeople(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), "Image/facebook-avatar.jpg", "NULL", ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "No"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else if (ob.GetPostReferenceForThing(ReportReferenceNumber.Value.ToString()))
                                    {
                                        if (ob.InsertReportSightingDataWithReferenec(RegistrationID, ReferenceNumber, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), "Image/facebook-avatar.jpg", "NULL", ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "No"))
                                            IfConditionTrue(false, false, false, false, true);
                                    }
                                    else
                                        IfConditionTrue(false, false, false, true, false);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (ReportImage.HasFile)
                        {
                            // Image.
                            string path = ReportImage.FileName.ToString();
                            ReportImage.PostedFile.SaveAs(Server.MapPath(".") + "//Image//" + path);
                            string str = "Image/" + path.ToString();
                            if (ReportMale.Checked)
                            {
                                if (ReportYes.Checked)
                                {
                                    if(ob.InsertReportSightingData(RegistrationID, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), str, ReportMale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "Yes"))
                                        IfConditionTrue(false, false, false, false, true);
                                }
                                else
                                {
                                    if (ob.InsertReportSightingData(RegistrationID, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), str, ReportMale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "No"))
                                        IfConditionTrue(false, false, false, false, true);
                                }
                            }
                            else if (ReportFemale.Checked)
                            {
                                if (ReportYes.Checked)
                                {
                                    if (ob.InsertReportSightingData(RegistrationID, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), str, ReportFemale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "Yes"))
                                        IfConditionTrue(false, false, false, false, true);
                                }
                                else
                                {
                                    if (ob.InsertReportSightingData(RegistrationID, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), str, ReportFemale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "No"))
                                        IfConditionTrue(false, false, false, false, true);
                                }
                            }
                            else if (ReportMale.Checked == false || ReportFemale.Checked == false)
                            {
                                if (ReportYes.Checked)
                                {
                                    if (ob.InsertReportSightingData(RegistrationID, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), str, "Null", ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "Yes"))
                                        IfConditionTrue(false, false, false, false, true);
                                }
                                else
                                {
                                    if (ob.InsertReportSightingData(RegistrationID, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), str, "Null", ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "No"))
                                        IfConditionTrue(false, false, false, false, true);
                                }
                            }
                        }
                        else if (!ReportImage.HasFile)
                        {
                            if (ReportMale.Checked)
                            {
                                if (ReportYes.Checked)
                                {
                                    if (ob.InsertReportSightingData(RegistrationID, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), "Image/facebook-avatar.jpg", ReportMale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "Yes"))
                                        IfConditionTrue(false, false, false, false, true);
                                }
                                else
                                {
                                    if (ob.InsertReportSightingData(RegistrationID, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), "Image/facebook-avatar.jpg", ReportMale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "No"))
                                        IfConditionTrue(false, false, false, false, true);
                                }
                            }
                            else if (ReportFemale.Checked)
                            {
                                if (ReportYes.Checked)
                                {
                                    if (ob.InsertReportSightingData(RegistrationID, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), "Image/facebook-avatar.jpg", ReportFemale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "Yes"))
                                        IfConditionTrue(false, false, false, false, true);
                                }
                                else
                                {
                                    if (ob.InsertReportSightingData(RegistrationID, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), "Image/facebook-avatar.jpg", ReportFemale.Value.ToString(), ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "No"))
                                        IfConditionTrue(false, false, false, false, true);
                                }
                            }
                            else if (ReportMale.Checked == false || ReportFemale.Checked == false)
                            {
                                if (ReportYes.Checked)
                                {
                                    if (ob.InsertReportSightingData(RegistrationID, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), "Image/facebook-avatar.jpg", "NULL", ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "Yes"))
                                        IfConditionTrue(false, false, false, false, true);
                                }
                                else
                                {
                                    if (ob.InsertReportSightingData(RegistrationID, ReportFoundThing.SelectedItem.ToString(), ReportCompanyName.Value.ToString(), ReportBrandName.Value.ToString(), ReportColor.Value.ToString(), ReportCNICNumber.Value.ToString(), ReportCNICFamily.Value.ToString(), ReportMissingPerson.Value.ToString(), calender, ReportFound.Value.ToString(), ReportCCTV.Value.ToString(), ReportCloth.Value.ToString(), ReportPublicity.SelectedItem.ToString(), "Image/facebook-avatar.jpg", "Null", ReportYourName.Value.ToString(), ReportYourEmail.Value.ToString(), ReportYourMobile.Value.ToString(), ReportYourAddress.Value.ToString(), "No"))
                                        IfConditionTrue(false, false, false, false, true);
                                }
                            }
                        }
                    }
                }
            }
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
            Session.Remove("ReportSighting");
            Session.Remove("FullPost");
            Session.Remove("ResetPassword");
            Session.Remove("Favourite");
            Session.Remove("Feedback");
        }

        // Show Input Fields.
        private void MissingThingSelectedIndex(bool MissingPerson, bool Cloth, bool Gander, bool Company, bool Brand, bool Color, bool Family, bool Number)
        {
            ReportMissingPersonHide.Visible = MissingPerson;
            ReportClothHide.Visible = Cloth;
            ReportGanderHide.Visible = Gander;
            ReportCompanyNameHide.Visible = Company;
            ReportBrandNameHide.Visible = Brand;
            ReportColorHide.Visible = Color;
            ReportCNICFamilyHide.Visible = Family;
            ReportCNICNumberHide.Visible = Number;
        }

        // Show Input Fields Method in Page Load Event.
        private void MissingThingSelectIndexShow()
        {
            if (ReportFoundThing.SelectedIndex == 1)
                MissingThingSelectedIndex(true, true, true, false, false, false, false, false);
            else if (ReportFoundThing.SelectedIndex == 2)
                MissingThingSelectedIndex(false, false, false, true, true, true, false, false);
            else if (ReportFoundThing.SelectedIndex == 3)
                MissingThingSelectedIndex(false, false, false, false, true, true, false, false);
            else if (ReportFoundThing.SelectedIndex == 4)
                MissingThingSelectedIndex(false, false, false, false, false, false, true, true);
        }

        // Validation for not Select Select Tags.
        private void DropDownListValidation(bool CCTV, bool Publicity, bool Date, bool note)
        {
            ErrorCCTV.Visible = CCTV;
            ErrorPublicity.Visible = Publicity;
            ErrorDate.Visible = Date;
            Note.Visible = note;
        }

        // display Advertisemet Method in Page Load Event.
        private void AdvertisementSelectIndex()
        {
            if (ReportPublicity.SelectedIndex == 4)
            {
                DropDownListValidation(false, false, false, false);
                ReportReferenceHide.Visible = true;
            }
            else if (ReportPublicity.SelectedIndex != 4)
            {
                DropDownListValidation(false, false, false, false);
                ReportReferenceHide.Visible = false;
            }
        }

        // When Condition Become True.
        private void IfConditionTrue(bool CCTV, bool Publicity, bool Date, bool Reference, bool Success)
        {
            ErrorCCTV.Visible = CCTV;
            ErrorPublicity.Visible = Publicity;
            ErrorDate.Visible = Date;
            ErrorReference.Visible = Reference;
            ReportSuccessfull.Visible = Success;
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