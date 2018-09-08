using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class AdminLoginPageObjects
    {
        public int AdminID { get; set; }
        public string Username { get; set; }
        public string PasswordOne { get; set; }
        public string PasswordTwo { get; set; }
        public string SecurityQuestion { get; set; }
        public string Answer { get; set; }
    }
}
