using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class UserProfileBussiness
    {
        UserProfileDB ob = new UserProfileDB();

        // Calling Get User Id Method.
        public void GetUserID(string Username)
        {
            ob.GetUserID(Username);
        }

        // Calling Mising People Method.
        public List<MissingPeoplePageObjects> GetPeopleDataFromDatabase()
        {
            return ob.GetPeopleDataFromDatabase();
        }

        // Calling Mising Thing Method.
        public List<MissingThingPageObject> GetThingDataFromDatabase()
        {
            return ob.GetThingDataFromDatabase();
        }

        // Calling Unidentified People Method.
        public List<UnidentifiedPeoplePageObject> GetUnidentifiedPeopleDataFromDatabase()
        {
            return ob.GetUnidentifiedPeopleDataFromDatabase();
        }

        // Delete Missing People Data.
        public bool DeleteMissingPeoplePost(string PeopleID)
        {
            return ob.DeleteMissingPeoplePost(PeopleID);
        }

        // Delete Favourite missing People Post from Submit Missing People Post.
        public void DeleteFavouriteMissingPeoplePost(string PeopleID)
        {
            ob.DeleteFavouriteMissingPeoplePost(PeopleID);
        }

        // Delete Missing Thing Data.
        public bool DeleteMissingThingPost(string ThingID)
        {
            return ob.DeleteMissingThingPost(ThingID);
        }

        // Delete Favourite missing Thing Post from Submit Missing Thing Post.
        public void DeleteFavouriteMissingThingPost(string ThingID)
        {
            ob.DeleteFavouriteMissingThingPost(ThingID);
        }

        // Delete Unidentified People Data.
        public bool DeleteUnidentifiedPeoplePost(string UnidentifiedID)
        {
            return ob.DeleteUnidentifiedPeoplePost(UnidentifiedID);
        }

        // Delete Favourite Unidentified People Post from Submit Unidentified People Post.
        public void DeleteFavouriteUnidentifiedPeoplePost(string UnidentifiedID)
        {
            ob.DeleteFavouriteUnidentifiedPeoplePost(UnidentifiedID);
        }

        public List<MissingThingPageObject> SelectThingNameForEditPost(int ThingID)
        {
            return ob.SelectThingNameForEditPost(ThingID);
        }

        // Edit Missing People Post.
        public bool UpdateMissingPeoplePost(int PeopleID, string name, string nickName, string CNIC, string FatherName, string FatherCNIC, string Contact1, string Contact2, string Permanent, string Current, string Age, string MissingPlace, string Clothes, string Description, string Image)
        {
            return ob.UpdateMissingPeoplePost(PeopleID, name, nickName, CNIC, FatherName, FatherCNIC, Contact1, Contact2, Permanent, Current, Age, MissingPlace, Clothes, Description, Image);
        }

        // Edit Mobile Post.
        public bool UpdateMobilePost(int ThingID, string OwnerName, string OwnerCNIC, string Contact, string Contact2, string FatherName, string FatherCNIC, string Permanent, string Current, string Place, string Description, string Image, string Brand, string Color, string Model, string IMEI)
        {
            return ob.UpdateMobilePost(ThingID, OwnerName, OwnerCNIC, Contact, Contact2, FatherName, FatherCNIC, Permanent, Current, Place, Description, Image, Brand, Color, Model, IMEI);
        }

        // Edit Auto Mobile Post.
        public bool UpdateAutoMobilePost(int ThingID, string OwnerName, string OwnerCNIC, string Contact, string Contact2, string FatherName, string FatherCNIC, string Permanent, string Current, string Place, string Description, string Image, string Company, string Brand, string Engine, string Chasses, string Color, string Model)
        {
            return ob.UpdateAutoMobilePost(ThingID, OwnerName, OwnerCNIC, Contact, Contact2, FatherName, FatherCNIC, Permanent, Current, Place, Description, Image, Company, Brand, Engine, Chasses, Color, Model);
        }

        // Edit CNIC Post.
        public bool UpdateCNICPost(int ThingID, string OwnerName, string OwnerCNIC, string Contact, string Contact2, string FatherName, string FatherCNIC, string Permanent, string Current, string Place, string Description, string Image, string CNICNumb, string FamilyNumb)
        {
            return ob.UpdateCNICPost(ThingID, OwnerName, OwnerCNIC, Contact, Contact2, FatherName, FatherCNIC, Permanent, Current, Place, Description, Image, CNICNumb, FamilyNumb);
        }

        // Edit Unidentified People Post.
        public bool UpdateUnidentifiedPeoplePost(int Unidentified, string Name, string FatherName, string Contact, string Age, string FoundPlace, string Description, string Image, string Language, string Unique)
        {
            return ob.UpdateUnidentifiedPeoplePost(Unidentified, Name, FatherName, Contact, Age, FoundPlace, Description, Image, Language, Unique);
        }
    }
}
