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
    public partial class RegisteredUsers : System.Web.UI.Page
    {
        public List<RegistrationObjects> DisplayRegistrationData;
        public List<RegistrationObjects> DisplayDataOnSearch;
        RegistrationBussiness ob = new RegistrationBussiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminUsername"] == null)
                Response.Redirect("Login.aspx");
            DisplayRegistrationData = ob.SelectRegistrationDataForAdminPanel();
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            table.Visible = false;
            DisplayDataOnSearch = ob.SearchRegisterationData(ReportSearch.Value.ToString());
        }
    }
}