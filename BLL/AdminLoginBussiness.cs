using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class AdminLoginBussiness
    {
        AdminLoginDB ob = new AdminLoginDB();

        // Getting Admin User ID.
        public void GetAdminID(string Username)
        {
            ob.GetAdminID(Username);
        }
        
        // Calling Admin Login Method
        public bool AdminLoginMethod(string username, string passwordOne, string passwordTwo)
        {
            return ob.AdminLoginMethod(username, passwordOne, passwordTwo);
        }

        // Calling Admin Login along with ID Method.
        public bool AdminLoginMethodWithAdminID(int ID, string username, string passwordOne, string passwordTwo)
        {
            return ob.AdminLoginMethodWithAdminID(ID, username, passwordOne, passwordTwo);
        }

        // Calling Update Admin Login Method.
        public bool UpdateAdminLoginMethod(int ID, string username, string passwordOne, string passwordTwo)
        {
            return ob.UpdateAdminLoginMethod(ID, username, passwordOne, passwordTwo);
        }

        // Calling Insert Another Admin Method.
        public bool InsertAnotherAdmin(string Username, string PasswordOne, string PasswordTwo, string Security, string Answer)
        {
            return ob.InsertAnotherAdmin(Username, PasswordOne, PasswordTwo, Security, Answer);
        }

        // Insert Another Admin Profile.
        public bool InsertAnotherAdminProfile(int ID)
        {
            return ob.InsertAnotherAdminProfile(ID);
        }

        // Select All Data of Admin Method.
        public List<AdminLoginPageObjects> SelectAdminLoginData()
        {
            return ob.SelectAdminLoginData();
        }

        // Select Admin Username for Forgot Password.
        public bool SelectAdminUsernameForForgot(string username)
        {
            return ob.SelectAdminUsernameForForgot(username);
        }

        // Select Admin Password One for Forgot Password.
        public bool SelectAdminPasswordOneForForgot(string Password)
        {
            return ob.SelectAdminPasswordOneForForgot(Password);
        }

        // Select Admin Username And Password One for Forgot Password.
        public bool SelectAdminUsernamePasswordOneForForgot(string username, string Password)
        {
            return ob.SelectAdminUsernamePasswordOneForForgot(username, Password);
        }

        // Select Admin Username And Password Two for Forgot Password.
        public bool SelectAdminUsernamePasswordTwoForForgot(string username, string Password)
        {
            return ob.SelectAdminUsernamePasswordTwoForForgot(username, Password);
        }

        // Select Admin Username And Security Question And its Answer for Forgot Password.
        public bool SelectAdminUsernameSecurityQuestionForForgot(string username, string securityQ, string answer)
        {
            return ob.SelectAdminUsernameSecurityQuestionForForgot(username, securityQ, answer);
        }

        // Update Password One and Password Two From Forgot Password.
        public bool UpdatePasswordFromForgotPassword(string username, string passwordOne, string passwordTwo)
        {
            return ob.UpdatePasswordFromForgotPassword(username, passwordOne, passwordTwo);
        }

        // Select All data of Admin Login to display in table.
        public List<AdminLoginPageObjects> SelectAllDataOfAdminLoginForDisplay()
        {
            return ob.SelectAllDataOfAdminLoginForDisplay();
        }

        // Delete Admin User Profile.
        public bool DeleteAdminUserProfile(int AdminId)
        {
            return ob.DeleteAdminUserProfile(AdminId);
        }

        // Delete Admin User.
        public bool DeleteAdminUser(int AdminId)
        {
            return ob.DeleteAdminUser(AdminId);
        }

        
    }
}
