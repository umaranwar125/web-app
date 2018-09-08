using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class RegistrationBussiness
    {
        // Object Created for Data Access Layer Class.
        RegistrationDB ClassObject = new RegistrationDB();

        // Insert Registration Method Call.
        public bool InsertRegisterationData(string FullName, string Username, string Email, string Password, string Contact, string Age, string Gander, string Image)
        {
            return ClassObject.InsertRegisterationData(FullName, Username, Email, Password, Contact, Age, Gander, Image);
        }

        // Username And Email Existance Method Call.
        public bool CheckingUserNameDuringRegistration(string Username, string Email)
        {
            return ClassObject.CheckingUserNameDuringRegistration(Username, Email);
        }

        // Select Registration Data Method Call.
        public List<RegistrationObjects> SelectRegistrationData(string username)
        {
            return ClassObject.SelectRegistrationData(username);
        }

        // Select Registration Data Method Call for ADmin Panel.
        public List<RegistrationObjects> SelectRegistrationDataForAdminPanel()
        {
            return ClassObject.SelectRegistrationDataForAdminPanel();
        }

        // Checking Email Existance for User Prfile.
        public bool CheckingEmail(string username, string Email)
        {
            return ClassObject.CheckingEmail(username, Email);
        }

        // Checking Old password Existance for User Prfile.
        public bool CheckingPassword(string username, string password)
        {
            return ClassObject.CheckingPassword(username, password);
        }

        // Update User Profile.
        public bool UpdateUserProfile(string username, string name, string about, string email_addr, string contact_num, string pass, string img)
        {
            return ClassObject.UpdateUserProfile(username, name, about, email_addr, contact_num, pass, img);
        }

        // Select Total Number of Posts From Missing People For Admin Panel.
        public List<RegistrationObjects> TotalRegisterationPosts()
        {
            return ClassObject.TotalRegisterationPosts();
        }

        // Search Registeration Data.
        public List<RegistrationObjects> SearchRegisterationData(string Name)
        {
            return ClassObject.SearchRegisterationData(Name);
        }
    }
}
