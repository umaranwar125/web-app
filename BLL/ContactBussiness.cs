using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class ContactBussiness
    {
        ContactDB ob = new ContactDB();

        // To get User ID Method calling.
        public void GetUserID(string Username)
        {
            ob.GetUserID(Username.ToString());
        }

        // Insert Contact Data to Database.
        public bool InsertContactDataToDatabase(string subject, string email, long contact, string message, string date, string time)
        {
            return ob.InsertContactDataToDatabase(subject, email, contact, message, date, time);
        }

        // Calling Contact Page Data Method For Admin Panel.
        public List<ContactUsPageObjects> SelectContactPageDataForAdminPanel()
        {
            return ob.SelectContactPageDataForAdminPanel();
        }

        // Delete Contact data From Admin Panel.
        public bool DeleteUserContacts(int ContactID)
        {
            return ob.DeleteUserContacts(ContactID);
        }

        // Select Total Number of Posts From Missing People For Admin Panel.
        public List<ContactUsPageObjects> TotalContactPosts()
        {
            return ob.TotalContactPosts();
        }
    }
}
