using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BLL;
using BOL;

namespace UI.Admin
{
    public partial class Dashboard : System.Web.UI.Page
    {
        string strCon;
        SqlConnection con;
        public List<MissingPeoplePageObjects> DisplayTotalMissingPeople;
        public List<MissingPeoplePageObjects> SelectID;
        public List<MissingThingPageObject> DisplayTotalMissingThing;
        public List<UnidentifiedPeoplePageObject> DisplayTotalUnidentifiedPeople;
        public List<CommentObjects> DisplayTotalComments;
        public List<ReportSightingPageObjects> DisplayTotalReportSighting;
        public List<FeedbackPageObjects> DisplayTotalFeedbacks;
        public List<ContactUsPageObjects> DisplayTotalContacts;
        public List<RegistrationObjects> DisplayTotalRegisteration;
        public List<RegistrationObjects> SelectReg;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminUsername"] == null)
                Response.Redirect("Login.aspx");
            DisplayTotalMissingPeopleMethod();
            DisplayTotalMissingThingMethod();
            DisplayTotalUnidentifiedPeopleMethod();
            DisplayTotalCommentsMehod();
            DisplayTotalReportSightingMehod();
            DisplayTotalFeedbacksMehod();
            DisplayTotalContactsMehod();
            DisplayTotalRegistrationMehod();
        }
        
        private void DisplayTotalMissingPeopleMethod()
        {
            MissingPeopleBussiness ob = new MissingPeopleBussiness();
            DisplayTotalMissingPeople = ob.TotalMissingPeoplePosts();
        }

        private void DisplayTotalMissingThingMethod()
        {
            MissingThingBussiness ob = new MissingThingBussiness();
            DisplayTotalMissingThing = ob.TotalMissingThingPosts();
        }

        private void DisplayTotalUnidentifiedPeopleMethod()
        {
            UnidentifiedPeopleBussiness ob = new UnidentifiedPeopleBussiness();
            DisplayTotalUnidentifiedPeople = ob.TotalUnidentifiedPeoplePosts();
        }

        private void DisplayTotalCommentsMehod()
        {
            CommentsBusiness ob = new CommentsBusiness();
            DisplayTotalComments = ob.TotalComments();
        }

        private void DisplayTotalReportSightingMehod()
        {
            ReportSightingBussiness ob = new ReportSightingBussiness();
            DisplayTotalReportSighting = ob.TotalReportSightingPosts();
        }

        private void DisplayTotalFeedbacksMehod()
        {
            FeedbackBussiness ob = new FeedbackBussiness();
            DisplayTotalFeedbacks = ob.TotalFeedbacks();
        }

        private void DisplayTotalContactsMehod()
        {
            ContactBussiness ob = new ContactBussiness();
            DisplayTotalContacts = ob.TotalContactPosts();
        }

        private void DisplayTotalRegistrationMehod()
        {
            RegistrationBussiness ob = new RegistrationBussiness();
            DisplayTotalRegisteration = ob.TotalRegisterationPosts();
        }
    }
}