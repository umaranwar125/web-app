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
    public partial class Contacts : System.Web.UI.Page
    {
        public List<ContactUsPageObjects> DisplayContactData;
        ContactBussiness ob = new ContactBussiness();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["AdminUsername"] == null)
                Response.Redirect("Login.aspx");
            DisplayContactData = ob.SelectContactPageDataForAdminPanel();
            if (Session["DeletePost"] != null)
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>displayDeleteMessage();</script>");
            if(!IsPostBack)
                Session.Remove("DeletePost");
            DelectContacts();
        }
     
        // Delete User Contacts.
        private void DelectContacts()
        {
            if(Request.QueryString["Contacts_Id"] != null)
            {
                if(ob.DeleteUserContacts(Convert.ToInt32(Request.QueryString["Contacts_Id"])))
                {
                    Session["DeletePost"] = "Deleted Successfully";
                    Response.Redirect("Contacts.aspx");
                }
            }
        }
    }
}