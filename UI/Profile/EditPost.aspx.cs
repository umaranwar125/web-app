using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using BOL;

namespace UI.Profile
{
    public partial class EditPost : System.Web.UI.Page
    {
        public List<RegistrationObjects> DisplayUserData;
        RegistrationBussiness ob = new RegistrationBussiness();
        UserProfileBussiness obj = new UserProfileBussiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
                Response.Redirect("/Login.aspx");
            DisplayUser();
        }

        // Display User Method.
        private void DisplayUser()
        {
            DisplayUserData = ob.SelectRegistrationData(Session["username"].ToString());
        }

        // Missing People Edit Post.
        protected void Update_Missing_People_Click(object sender, EventArgs e)
        {
            if (Image.HasFile)
            {
                string path = Image.FileName.ToString();
                Image.PostedFile.SaveAs(Server.MapPath("~") + "//Image//" + path);
                string str = "Image/" + path.ToString();
                if(obj.UpdateMissingPeoplePost(Convert.ToInt32(Request.QueryString["Missing-People-Edit-Post-ID"]),M_P_Full_Name.Value.ToString(), M_P_Nickname.Value.ToString(), M_P_CNIC.Value.ToString(), M_P_Father_name.Value.ToString(), M_P_Father_CNIC.Value.ToString(), M_P_Mobile.Value.ToString(), M_P_Mobile2.Value.ToString(), M_P_Permanent.Value.ToString(), M_P_Current.Value.ToString(), M_P_Age.Value.ToString(), M_P_Place.Value.ToString(), M_P_Cloth.Value.ToString(), M_P_Description.Value.ToString(), str))
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>displaySuccessMsgForEditPeoplePost();</script>");
            }
            else
                ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>displayErrorImageEditPeoplePost();</script>");
        }

        // Auto Mobile Edit Post
        protected void Update_Auto_Mobile_post_Click(object sender, EventArgs e)
        {
            if (Auto_img.HasFile)
            {
                string path = Auto_img.FileName.ToString();
                Auto_img.PostedFile.SaveAs(Server.MapPath("~") + "//Image//" + path);
                string str = "Image/" + path.ToString();
                if (obj.UpdateAutoMobilePost(Convert.ToInt32(Request.QueryString["Missing-Thing-Edit-Post-ID"]), Auto_Owner_name.Value.ToString(), Auto_Owner_CNIC.Value.ToString(), Auto_Mobile_No.Value.ToString(), Auto_Mobile_No2.Value.ToString(), Auto_Father_Name.Value.ToString(), Auto_Father_CNIC.Value.ToString(), Auto_Permanent.Value.ToString(), Auto_Current.Value.ToString(), Auto_Place.Value.ToString(), Auto_description.Value.ToString(), str, Auto_company.Value.ToString(), Auto_Brand.Value.ToString(), Auto_Engine.Value.ToString(), Auto_chasses.Value.ToString(), Auto_Color.Value.ToString(), Auto_Model.Value.ToString()))
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>displayAutoSuccessMsgForEditThingPost();</script>");
            }
            else if (!Auto_img.HasFile)
            {
                if (obj.UpdateAutoMobilePost(Convert.ToInt32(Request.QueryString["Missing-Thing-Edit-Post-ID"]), Auto_Owner_name.Value.ToString(), Auto_Owner_CNIC.Value.ToString(), Auto_Mobile_No.Value.ToString(), Auto_Mobile_No2.Value.ToString(), Auto_Father_Name.Value.ToString(), Auto_Father_CNIC.Value.ToString(), Auto_Permanent.Value.ToString(), Auto_Current.Value.ToString(), Auto_Place.Value.ToString(), Auto_description.Value.ToString(), "Image/Auto_Mobile.png", Auto_company.Value.ToString(), Auto_Brand.Value.ToString(), Auto_Engine.Value.ToString(), Auto_chasses.Value.ToString(), Auto_Color.Value.ToString(), Auto_Model.Value.ToString()))
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>displayAutoSuccessMsgForEditThingPost();</script>");

            }
        }

        // CNIC Edit Post.
        protected void Update_CNIC_Post_Click(object sender, EventArgs e)
        {
            if (CNIC_img.HasFile)
            {
                string path = CNIC_img.FileName.ToString();
                CNIC_img.PostedFile.SaveAs(Server.MapPath("~") + "//Image//" + path);
                string str = "Image/" + path.ToString();
                if (obj.UpdateCNICPost(Convert.ToInt32(Request.QueryString["Missing-Thing-Edit-Post-ID"]), CNIC_Owner_name.Value.ToString(), CNIC_Owner_CNIC.Value.ToString(), CNIC_Mobile_no.Value.ToString(), CNIC_Mobile_no2.Value.ToString(), CNIC_Father_name.Value.ToString(), CNIC_Father_CNIC.Value.ToString(), CNIC_Permanent.Value.ToString(), CNIC_Current.Value.ToString(), CNIC_Place.Value.ToString(), CNIC_Description.Value.ToString(), str, CNIC_Number.Value.ToString(), CNIC_Family.Value.ToString()))
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>displayCNICSuccessMsgForEditThingPost();</script>");
            }
            else if (!CNIC_img.HasFile)
            {
                if (obj.UpdateCNICPost(Convert.ToInt32(Request.QueryString["Missing-Thing-Edit-Post-ID"]), CNIC_Owner_name.Value.ToString(), CNIC_Owner_CNIC.Value.ToString(), CNIC_Mobile_no.Value.ToString(), CNIC_Mobile_no2.Value.ToString(), CNIC_Father_name.Value.ToString(), CNIC_Father_CNIC.Value.ToString(), CNIC_Permanent.Value.ToString(), CNIC_Current.Value.ToString(), CNIC_Place.Value.ToString(), CNIC_Description.Value.ToString(), "Image/CNIC.png", CNIC_Number.Value.ToString(), CNIC_Family.Value.ToString()))
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>displayCNICSuccessMsgForEditThingPost();</script>");
            }
        }

        // Edit Mobile Post.
        protected void Update_Mobile_post_Click(object sender, EventArgs e)
        {
            if(Mobile_img.HasFile)
            {
                string path = Mobile_img.FileName.ToString();
                Mobile_img.PostedFile.SaveAs(Server.MapPath("~") + "//Image//" + path);
                string str = "Image/" + path.ToString();
                if(obj.UpdateMobilePost(Convert.ToInt32(Request.QueryString["Missing-Thing-Edit-Post-ID"]), Mobile_Owner_Name.Value.ToString(), Mobile_Owner_CNIC.Value.ToString(), Mobile_Mobile_NO.Value.ToString(), Mobile_Mobile_NO2.Value.ToString(), Mobile_Father_Name.Value.ToString(), Mobile_Father_CNIC.Value.ToString(), Mobile_Permanent.Value.ToString(), Mobile_Current.Value.ToString(), Mobile_Place.Value.ToString(), Mobile_Description.Value.ToString(), str, Mobile_Brand.Value.ToString(), Mobile_Color.Value.ToString(), Mobile_Model.Value.ToString(), Mobile_IMEI.Value.ToString()))
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>displayMobileSuccessMsgForEditThingPost();</script>");
            }
            else if (!Mobile_img.HasFile)
            {
                if (obj.UpdateMobilePost(Convert.ToInt32(Request.QueryString["Missing-Thing-Edit-Post-ID"]), Mobile_Owner_Name.Value.ToString(), Mobile_Owner_CNIC.Value.ToString(), Mobile_Mobile_NO.Value.ToString(), Mobile_Mobile_NO2.Value.ToString(), Mobile_Father_Name.Value.ToString(), Mobile_Father_CNIC.Value.ToString(), Mobile_Permanent.Value.ToString(), Mobile_Current.Value.ToString(), Mobile_Place.Value.ToString(), Mobile_Description.Value.ToString(), "Image/Mobile.jpg", Mobile_Brand.Value.ToString(), Mobile_Color.Value.ToString(), Mobile_Model.Value.ToString(), Mobile_IMEI.Value.ToString()))
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>displayMobileSuccessMsgForEditThingPost();</script>");
            }
        }

        // Edit Unidentified People Post
        protected void Update_Unidentified_Post_Click(object sender, EventArgs e)
        {
            if(Uni_Image.HasFile)
            {
                string path = Uni_Image.FileName.ToString();
                Uni_Image.PostedFile.SaveAs(Server.MapPath("~") + "//Image//" + path);
                string str = "Image/" + path.ToString();
                if (obj.UpdateUnidentifiedPeoplePost(Convert.ToInt32(Request.QueryString["Unidentified-People-Edit-Post-ID"]), Uni_Name.Value.ToString(), Uni_Father_Name.Value.ToString(), Uni_Mobile.Value.ToString(), Uni_Age.Value.ToString(), Uni_found.Value.ToString(), Uni_description.Value.ToString(), str, Uni_language.Value.ToString(), Uni_Unique.Value.ToString()))
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>displayUnidentifiedSuccessMsgForEditThingPost();</script>");
            }
            else if (!Uni_Image.HasFile)
                ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>displayUnidentifiedErrorImageForEditThingPost();</script>");
        }
    }
}