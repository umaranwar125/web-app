using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.ClientServices;
using BLL;
using BOL;

namespace UI.Admin
{
    public partial class AllReports : System.Web.UI.Page
    {
        public List<MissingPeoplePageObjects> DisplayMissingPeopleDatainTable;
        public List<MissingThingPageObject> DisplayMissingThingDatainTable;
        public List<UnidentifiedPeoplePageObject> DisplayUnidentifiedPeopleDatainTable;
        public List<MissingPeoplePageObjects> SearchPeopleDataInRegularSearchBar;
        public List<MissingThingPageObject> SearchThingDataInRegularSearchBar;
        public List<UnidentifiedPeoplePageObject> SearchUnidentifiedDataInRegularSearchBar;
        AdminAllReportsDataBussiness ob = new AdminAllReportsDataBussiness();
        MissingPeopleBussiness ob1 = new MissingPeopleBussiness();
        MissingThingBussiness ob2 = new MissingThingBussiness();
        UnidentifiedPeopleBussiness ob3 = new UnidentifiedPeopleBussiness();
        SeekingInformationBussiness ob4 = new SeekingInformationBussiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session_2();
            if (!IsPostBack)
                Sessions_1();
            DisplayMissingPeopleDatainTable = ob.SelectMissingPeopleMethod();
            DisplayMissingThingDatainTable = ob.SelectMissingThingMethod();
            DisplayUnidentifiedPeopleDatainTable = ob.SelectUnidentifiedPeopleMethod();
            DeleteAndApproveQueryStringForMissingPeople();
            DeleteAndApproveQueryStringForMissingThing();
            DeleteAndApproveQueryStringForUnidentifiedPeople();
        }

        // Sessions 1 Method
        private void Sessions_1()
        {
            Session.Remove("ApprovedPost");
            Session.Remove("DeletePost");
            if (Session["PeopleSelectedIndex"] != null)
            {
                SelectTable.SelectedIndex = Convert.ToInt32(Session["PeopleSelectedIndex"]);
                TableVisibility(true, false, false);
            }
            else if (Session["ThingSelectedIndex"] != null)
            {
                SelectTable.SelectedIndex = Convert.ToInt32(Session["ThingSelectedIndex"]);
                TableVisibility(false, true, false);
            }
            else if (Session["UnidentifiedSelectedIndex"] != null)
            {
                SelectTable.SelectedIndex = Convert.ToInt32(Session["UnidentifiedSelectedIndex"]);
                TableVisibility(false, false, true);
            }
        }

        //Session 2 Method 
        private void Session_2()
        {
            if (Session["AdminUsername"] == null)
                Response.Redirect("Login.aspx");
            if (Session["ApprovedPost"] != null)
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>displayApproveMessage();</script>");
            else if (Session["DeletePost"] != null)
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>displayDeleteMessage();</script>");
        }

        // Display Posts.
        protected void TableSelectButton_Click(object sender, EventArgs e)
        {
            if (SelectTable.SelectedIndex == 0)
            {
                Session["PeopleSelectedIndex"] = SelectTable.SelectedIndex;
                TableVisibility(true, false, false);
            }
            else if (SelectTable.SelectedIndex == 1)
            {
                Session["ThingSelectedIndex"] = SelectTable.SelectedIndex;
                TableVisibility(false, true, false);
            }
            else if (SelectTable.SelectedIndex == 2)
            {
                Session["UnidentifiedSelectedIndex"] = SelectTable.SelectedIndex;
                TableVisibility(false, false, true);
            }
        }

        // Table Visibility
        private void TableVisibility(bool MissingPeopleVisible, bool MissingThingVisible, bool UnidentifiedPeopleVisible)
        {
            MissingPeoples.Visible = MissingPeopleVisible;
            MissingThings.Visible = MissingThingVisible;
            UnidentifiedPeoples.Visible = UnidentifiedPeopleVisible;
        }

        // Approve And Delete Missing People Posts.
        private void DeleteAndApproveQueryStringForMissingPeople()
        {
            if (Request.QueryString["Missing_People_Id"] != null)
            {
                if (ob1.UpdateMissingPeopleStatus(Convert.ToInt32(Request.QueryString["Missing_People_Id"])))
                {
                    Session["ApprovedPost"] = "Approved Successfully";
                    MissingPeopleData();
                }
            }
            else if (Request.QueryString["Missing_People_Delete_Id"] != null)
            {
                if (ob1.DeleteMissingPeoplePost(Convert.ToInt32(Request.QueryString["Missing_People_Delete_Id"])))
                {
                    Session["DeletePost"] = "Deleted Successfully";
                    MissingPeopleData();
                }
            }
        }

        // Approve And Delete Missing Thing Posts.
        private void DeleteAndApproveQueryStringForMissingThing()
        {
            if (Request.QueryString["Missing_Thing_Id"] != null)
            {
                if (ob2.UpdateMissingThingStatus(Convert.ToInt32(Request.QueryString["Missing_Thing_Id"])))
                {
                    Session["ApprovedPost"] = "Approved Successfully";
                    MissingThingData();
                }
            }
            else if (Request.QueryString["Missing_Thing_Delete_Id"] != null)
            {
                if (ob2.DeleteMissingThingPost(Convert.ToInt32(Request.QueryString["Missing_Thing_Delete_Id"])))
                {
                    Session["DeletePost"] = "Deleted Successfully";
                    MissingThingData();
                }
            }
        }

        // Approve And Delete Unidentified People Posts.
        private void DeleteAndApproveQueryStringForUnidentifiedPeople()
        {
            if (Request.QueryString["Unidentified_People_Id"] != null)
            {
                if (ob3.UpdateUnidentifiedPeopleStatus(Convert.ToInt32(Request.QueryString["Unidentified_People_Id"])))
                {
                    Session["ApprovedPost"] = "Approved Successfully";
                    UnidentifiedPeopleData();
                }
            }
            else if (Request.QueryString["Unidentified_People_Delete_Id"] != null)
            {
                if (ob3.DeleteUnidentifiedPeoplePost(Convert.ToInt32(Request.QueryString["Unidentified_People_Delete_Id"])))
                {
                    Session["DeletePost"] = "Deleted Successfully";
                    UnidentifiedPeopleData();
                }
            }
        }

        // Missing People.
        private void MissingPeopleData()
        {
            Session.Remove("UnidentifiedSelectedIndex");
            Session.Remove("ThingSelectedIndex");
            Response.Redirect("AllReports.aspx");
        }

        // Missing Thing.
        private void MissingThingData()
        {
            Session.Remove("PeopleSelectedIndex");
            Session.Remove("UnidentifiedSelectedIndex");
            Response.Redirect("AllReports.aspx");
        }

        // Unidentified People.
        private void UnidentifiedPeopleData()
        {
            Session.Remove("ThingSelectedIndex");
            Session.Remove("PeopleSelectedIndex");
            Response.Redirect("AllReports.aspx");
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            MissingPeoples.Visible = false;
            MissingThings.Visible = false;
            UnidentifiedPeoples.Visible = false;
            SearchPeopleDataInRegularSearchBar = ob4.SearchMissingPeopleDataInAdminPanel(SearchReport.Value.ToString());
            SearchThingDataInRegularSearchBar = ob4.SearchMissingThingDataInAdminPanel(SearchReport.Value.ToString());
            SearchUnidentifiedDataInRegularSearchBar = ob4.SearchUnidentifiedPeopleDataInAdminPanel(SearchReport.Value.ToString());
        }
    }
}