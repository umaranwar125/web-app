using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class MissingThingBussiness
    {
        MissingThingDB ob = new MissingThingDB();

        // Calling UserID Method Services.
        public void GetUserId(string username)
        {
            ob.GetUserId(username);
        }

        //Calling CNIC Method Services.
        public bool InsertDataIntoCNIC(int R_ID, string Reference, string OwnerName, string OwnerCNIC, string GuardianName, string GuardianCNIC, string ContactNumber, string AnotherContact, string ThingName, string MissingPlace, string MissingDate, string Description, string CNICNumber, string UniqueIdentification, string CNICDOB, string CNICFamily, string PermanentAddress, string CurrentAddress, string Gander, string Image)
        {
            return ob.InsertDataIntoCNIC(R_ID, Reference, OwnerName, OwnerCNIC, GuardianName, GuardianCNIC, ContactNumber, AnotherContact, ThingName, MissingPlace, MissingDate, Description, CNICNumber, UniqueIdentification, CNICDOB, CNICFamily, PermanentAddress, CurrentAddress, Gander, Image);
        }

        // Calling Mobile Method Services.
        public bool InsertDataIntoMobile(int R_ID, string Reference, string OwnerName, string OwnerCNIC, string GuardianName, string GuardianCNIC, string ContactNumber, string AnotherContact, string ThingName, string BrandName, string Color, string Model, string MissingPlace, string MissingDate, string IMEI, string Description, string PermanentAddress, string CurrentAddress, string Image)
        {
            return ob.InsertDataIntoMobile(R_ID, Reference, OwnerName, OwnerCNIC, GuardianName, GuardianCNIC, ContactNumber, AnotherContact, ThingName, BrandName, Color, Model, MissingPlace, MissingDate, IMEI, Description, PermanentAddress, CurrentAddress, Image);
        }

        // Calling Auto Mobile Method Services. 
        public bool InsertDataIntoAutoMobile(int RegistrationID, string Reference, string OwnerName, string OwnerCNIC, string GuardianName, string GuardianCNIC, string ContactNumber, string AnotherContact, string ThingName, string CompanyName, string BrandName, string EngineNumber, string ChassesNumber, string Color, string Model, string MissingPlace, string MissingDate, string Description, string PermanentAddress, string CurrentAddress, string Image)
        {
            return ob.InsertDataIntoAutoMobile(RegistrationID, Reference, OwnerName, OwnerCNIC, GuardianName, GuardianCNIC, ContactNumber, AnotherContact, ThingName, CompanyName, BrandName, EngineNumber, ChassesNumber, Color, Model, MissingPlace, MissingDate, Description, PermanentAddress, CurrentAddress, Image);
        }

        // Delete Missing Thing post from Admin Panel.
        public bool DeleteMissingThingPost(int ThingId)
        {
            return ob.DeleteMissingThingPost(ThingId);
        }

        // Approve Missing Thing post from Admin Panel.
        public bool UpdateMissingThingStatus(int ThingId)
        {
            return ob.UpdateMissingThingStatus(ThingId);
        }

        // Comments on Auto Mobile Posts.
        public bool PostCommentsonAutoMobile(int AutoMobile, int Reg_id, string Fullname, string Message, string Image)
        {
            return ob.PostCommentsonAutoMobile(AutoMobile, Reg_id, Fullname, Message, Image);
        }

        // Select Auto mobile Comment
        public List<CommentObjects> SelectCommentOfAutoMobile(int AutoMobile)
        {
            return ob.SelectCommentOfAutoMobile(AutoMobile);
        }

        // Comments on Mobile Posts.
        public bool PostCommentsonMobile(int Mobile, int Reg_id, string Fullname, string Message, string Image)
        {
            return ob.PostCommentsonMobile(Mobile, Reg_id, Fullname, Message, Image);
        }

        // Select Mobile Comment
        public List<CommentObjects> SelectCommentOfMobile(int Mobile)
        {
            return ob.SelectCommentOfMobile(Mobile);
        }

        // Comments on CNIC Posts.
        public bool PostCommentsonCNIC(int CNIC, int Reg_id, string Fullname, string Message, string Image)
        {
            return ob.PostCommentsonCNIC(CNIC, Reg_id, Fullname, Message, Image);
        }

        // Select Mobile Comment
        public List<CommentObjects> SelectCommentOfCNIC(int CNIC)
        {
            return ob.SelectCommentOfCNIC(CNIC);
        }

        // Delete CNIC Posts Comments.
        public bool DeleteCNICComments(int R_ID, int Comment_ID)
        {
            return ob.DeleteCNICComments(R_ID, Comment_ID);
        }

        // Delete Auto Mobile Posts Comments.
        public bool DeleteAutoMobileComments(int R_ID, int Comment_ID)
        {
            return ob.DeleteAutoMobileComments(R_ID, Comment_ID);
        }

        // Delete Mobile Posts Comments.
        public bool DeleteMobileComments(int R_ID, int Comment_ID)
        {
            return ob.DeleteMobileComments(R_ID, Comment_ID);
        }

        // Select Total Number of Posts From Missing Thing For Admin Panel.
        public List<MissingThingPageObject> TotalMissingThingPosts()
        {
            return ob.TotalMissingThingPosts();
        }
    }
}
