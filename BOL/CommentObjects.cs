using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class CommentObjects
    {
        public int CommentID { get; set; }
        public int RegistrationID { get; set; }
        public int PeopleID { get; set; }
        public int AutoMobileID { get; set; }
        public int MobileID { get; set; }
        public int CnicID { get; set; }
        public int UnidentifiedID { get; set; }
        public string FullName{ get; set;}
        public string Message { get; set;}
        public string Image{ get; set;}
    }
}
