using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class UnidentifiedPeopleBussiness
    {
        UnidentifiedPeopleDB ob = new UnidentifiedPeopleDB();

        // Calling Services for User Registration ID Method.
        public void UserRegistrationID(string username)
        {
            ob.UserRegistrationID(username);
        }

        // Calling Services For Unidentified People Registration Method.
        public bool UnidetifiedPeopleDataInsertion(int R_ID, string Reference, string FullName, string GuardianName, string Contact, string Religion, string Age, string Unique, string FoundPlace, string Language, string ClothColor, string EyesColor, string Description, string Gander, string Image)
        {
            return ob.UnidetifiedPeopleDataInsertion(R_ID, Reference, FullName, GuardianName, Contact, Religion, Age, Unique, FoundPlace, Language, ClothColor, EyesColor, Description, Gander, Image);
        }

        // Approve Missing Thing post from Admin Panel.
        public bool UpdateUnidentifiedPeopleStatus(int UnidentifiedId)
        {
            return ob.UpdateUnidentifiedPeopleStatus(UnidentifiedId);
        }

        // Delete Unidentified post from Admin Panel.
        public bool DeleteUnidentifiedPeoplePost(int UnidentifiedId)
        {
            return ob.DeleteUnidentifiedPeoplePost(UnidentifiedId);
        }

        // Comments on Unidentified People Posts.
        public bool PostCommentsonUnidentifiedPeople(int unidentified, int Reg_id, string Fullname, string Message, string Image)
        {
            return ob.PostCommentsonUnidentifiedPeople(unidentified, Reg_id, Fullname, Message, Image);
        }

        // Select Unidentified People Comment
        public List<CommentObjects> SelectCommentOfUnidentifiedPeople(int Unidentified)
        {
            return ob.SelectCommentOfUnidentifiedPeople(Unidentified);
        }

        // Delete Unidentified People Posts Comments.
        public bool DeleteUnidentifiedPeopleComments(int R_ID, int Comment_ID)
        {
            return ob.DeleteUnidentifiedPeopleComments(R_ID, Comment_ID);
        }

        // Select Total Number of Posts From Unidentified People For Admin Panel.
        public List<UnidentifiedPeoplePageObject> TotalUnidentifiedPeoplePosts()
        {
            return ob.TotalUnidentifiedPeoplePosts();
        }
    }
}
