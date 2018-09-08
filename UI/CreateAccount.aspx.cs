using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel.DataAnnotations;
using BLL;
using System.Web.Security;
using System.IO;

namespace UI
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        // Page Load Event.
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionsRemove();
        }

        // Email Validation.
        private bool isValid(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }

        // Register Button Click.
        protected void RegsiterClickButton_Click(object sender, EventArgs e)
        {
            RegistrationBussiness ClassOB = new RegistrationBussiness();
            if (isValid(RegisterEmail.Value.ToString()))
            {
                if (ClassOB.CheckingUserNameDuringRegistration(RegisterUsername.Value.ToString(), RegisterEmail.Value.ToString()))
                {
                    ExistingMsg.Visible = true;
                    EmailFailure.Visible = false;
                }
                else
                {
                    string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(RegisterPassword.Value.ToString(), "MD5");
                    if (RegisterImage.HasFile)
                    {
                        string path = RegisterImage.FileName.ToString();
                        RegisterImage.PostedFile.SaveAs(Server.MapPath(".") + "//Image//" + path);
                        string str = "Image/" + path.ToString();
                        if (RegisterMale.Checked)
                        {
                            if (ClassOB.InsertRegisterationData(RegisterName.Value.ToString(), RegisterUsername.Value.ToString(), RegisterEmail.Value.ToString(), EncryptedPassword, RegisterContact.Value.ToString(), RegisterAge.Value.ToString(), RegisterMale.Value.ToString(), str))
                                SessionAndRedirect();
                        }
                        else if (RegisterFemale.Checked)
                        {
                            if (ClassOB.InsertRegisterationData(RegisterName.Value.ToString(), RegisterUsername.Value.ToString(), RegisterEmail.Value.ToString(), EncryptedPassword, RegisterContact.Value.ToString(), RegisterAge.Value.ToString(), RegisterFemale.Value.ToString(), str))
                                SessionAndRedirect();
                        }
                    }
                    else if (!RegisterImage.HasFile)
                    {
                        if (RegisterMale.Checked)
                        {
                            if (ClassOB.InsertRegisterationData(RegisterName.Value.ToString(), RegisterUsername.Value.ToString(), RegisterEmail.Value.ToString(), EncryptedPassword, RegisterContact.Value.ToString(), RegisterAge.Value.ToString(), RegisterMale.Value.ToString(), "Image/facebook-avatar.jpg"))
                                SessionAndRedirect();
                        }
                        else if (RegisterFemale.Checked)
                        {
                            if (ClassOB.InsertRegisterationData(RegisterName.Value.ToString(), RegisterUsername.Value.ToString(), RegisterEmail.Value.ToString(), EncryptedPassword, RegisterContact.Value.ToString(), RegisterAge.Value.ToString(), RegisterFemale.Value.ToString(), "Image/facebook-avatar.jpg"))
                                SessionAndRedirect();
                        }
                    }
                }
            }
            else
            {
                EmailFailure.Visible = true;
                ExistingMsg.Visible = false;
            }
        }

        // Method When Condution Become True.
        private void SessionAndRedirect()
        {
            Session["RegisteredSuccessfully"] = "Congratz";
            Response.Redirect("login");
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
            Session.Remove("Feedback");
            Session.Remove("Favourite");
        }
    }
}