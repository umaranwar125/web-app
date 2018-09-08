using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class LoginBussiness
    {
        LoginDB ob = new LoginDB();
        // Login Method Call.
        public bool LoginMethod(string username, string password)
        {
            return ob.LoginMethod(username, password);
        }

        // Checking Username.
        public bool CheckUsername(string username)
        {
            return ob.CheckUsername(username);
        }

        // Checking Email.
        public bool CheckEmail(string email)
        {
            return ob.CheckEmail(email);
        }

        // Checking Number.
        public bool CheckNumber(string number, string username, string email)
        {
            return ob.CheckNumber(number, username, email);
        }

        // Update Password.
        public bool UpdatePassword(string number, string username, string email, string password)
        {
            return ob.UpdatePassword(number, username, email, password);
        }
    }
}
