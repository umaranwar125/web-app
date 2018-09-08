using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class AdminProfileBussiness
    {
        AdminProfileDB ob = new AdminProfileDB();

        // Getting Admin ID.
        public void GetAdminID(string Username)
        {
            ob.GetAdminID(Username);
        }

        // Updating Admin Pofile.
        public bool UpdateAdminProfile(int ID, string FullName, string Title, string Email, string Qualification, string ContactNumber, string BioDescription, string Image)
        {
            return ob.UpdateAdminProfile(ID, FullName, Title,Email, Qualification, ContactNumber, BioDescription, Image);
        }
        
        // Selecting Admin Profile Data Method.
        public List<AdminProfilePageObjects> SelectAdminProfileData(int ID)
        {
            return ob.SelectAdminProfileData(ID);
        }
    }
}
