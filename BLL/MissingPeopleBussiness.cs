using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class MissingPeopleBussiness
    {
        MissingPeopleDB ob = new MissingPeopleDB();

        // To get User ID Method calling.
        public void GetUserID(string Username)
        {
            ob.GetUserID(Username.ToString());
        }

        // To Insert Missing People data method calling.
        public bool MissingPeopleMethod(int Registration_ID ,string Reference, string Name, string NickName, string CNIC, string GuardianName, string GuardianCNIC, string Contact, string AnotherContact, string Permanent, string Current, string Religion, string Age, string MissingPlace, string MissingDate, string Tribe, string Language, string ClothColor, string Height, string Weight, string EyeColor, string HairColor, string Description, string Gander, string Image)
        {
            return ob.MissingPeopleMethod(Registration_ID, Reference, Name, NickName, CNIC, GuardianName, GuardianCNIC, Contact, AnotherContact, Permanent, Current, Religion, Age, MissingPlace, MissingDate, Tribe, Language, ClothColor, Height, Weight, EyeColor, HairColor, Description, Gander, Image);
        }
        
        // Update Missing People Status from Admin Panel.
        public bool UpdateMissingPeopleStatus(int PeopleID)
        {
            return ob.UpdateMissingPeopleStatus(PeopleID);
        }

        // Delete Missing People Status from Admin Panel.
        public bool DeleteMissingPeoplePost(int PeopleId)
        {
            return ob.DeleteMissingPeoplePost(PeopleId);
        }

        // Comments on Posts.
        public bool PostComments(int People_Id, int Reg_id, string Fullname, string Message, string Image)
        {
            return ob.PostComments(People_Id, Reg_id, Fullname, Message, Image);
        }

        // Select Comment
        public List<CommentObjects> SelectCommentOfMisingPeople(int PeopleID)
        {
            return ob.SelectCommentOfMisingPeople(PeopleID);
        }

        // Delete Missing People Posts Comments.
        public bool DeleteMissingPeopleComments(int R_ID, int Comment_ID)
        {
            return ob.DeleteMissingPeopleComments(R_ID, Comment_ID);
        }

        // Select Total Number of Posts From Missing People For Admin Panel.
        public List<MissingPeoplePageObjects> TotalMissingPeoplePosts()
        {
            return ob.TotalMissingPeoplePosts();
        }
    }
}
