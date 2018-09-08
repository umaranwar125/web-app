using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOL;
using BLL;

namespace UI.Admin
{
    public partial class ReportSighting : System.Web.UI.Page
    {
        public List<ReportSightingPageObjects> DisplayReportSightingData;
        public List<ReportSightingPageObjects> DisplayDataOnSearch;
        ReportSightingBussiness ob = new ReportSightingBussiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminUsername"] == null)
                Response.Redirect("Login.aspx");
            DisplayReportSightingData = ob.SelectReportSightingMethodForAdminPanel();
            DeleteReport();
            Sessions();
            if(!IsPostBack)
                Session.Remove("ReportSighting");

        }

        private void Sessions()
        {
            if (Session["ReportSighting"] != null)
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>displayDeleteSuccessMessage();</script>");
        }

        protected void SelectThing_Click(object sender, EventArgs e)
        {
            if(SelectTable.SelectedIndex == 0)
            {
                TableVisibility(true, false, false, false, false);
            }
            else if (SelectTable.SelectedIndex == 1)
            {
                TableVisibility(false, true, false, false, false);
            }
            else if (SelectTable.SelectedIndex == 2)
            {
                TableVisibility(false, false, true, false, false);
            }
            else if (SelectTable.SelectedIndex == 3)
            {
                TableVisibility(false, false, false, true, false);
            }
            else if (SelectTable.SelectedIndex == 4)
            {
                TableVisibility(false, false, false, false, true);
            }
        }

        // Table Visisbility.
        public void TableVisibility(bool All, bool People, bool Auto, bool Mobile, bool CNIC)
        {
            AllReports.Visible = All;
            MissingPeople.Visible = People;
            MissingAuto.Visible = Auto;
            MissingMobile.Visible = Mobile;
            MissingCNIC.Visible = CNIC;
        }

        // Delete Sighting Report.
        private void DeleteReport()
        {
            if (Request.QueryString["Report_Sighting_Delete_Id"] != null)
            {
                if (ob.DeleteSightingReport(Convert.ToInt32(Request.QueryString["Report_Sighting_Delete_Id"])))
                {
                    Session["ReportSighting"] = "Report Sighting";
                    Response.Redirect("ReportSighting.aspx");
                }
            }
        }

        // Search Reports.
        protected void Search_Click(object sender, EventArgs e)
        {
            AllReports.Visible = false;
            MissingCNIC.Visible = false;
            MissingMobile.Visible = false;
            MissingAuto.Visible = false;
            MissingPeople.Visible = false;
            Combo.Disabled = true;
            DisplayDataOnSearch = ob.SearchReportSightingData(ReportSearch.Value.ToString());
        }
    }
}