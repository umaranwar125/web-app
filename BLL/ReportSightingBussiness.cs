using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class ReportSightingBussiness
    {
        ReportSightningDB ob = new ReportSightningDB();

        // Calling Services of UserID Method.
        public void GetUderID(string username)
        {
            ob.GetUserId(username);
        }

        // Calling Services of Post Reference People Method.
        public bool GetPostReferenceForPeople(string ReferenceNumb)
        {
            return ob.GetPostReferenceForPeople(ReferenceNumb);
        }

        // Calling Services of Post Reference People Method.
        public bool GetPostReferenceForThing(string ReferenceNumb)
        {
            return ob.GetPostReferenceForThing(ReferenceNumb);
        }

        // Calling services of InsertReportSightingDataWithReference Method.
         public bool InsertReportSightingDataWithReferenec(int R_ID,string Reference, string MissingThingName, string CompanyName, string BrandName, string Color, string CNICNumber, string CNICFamily, string MissingPersonname, string FoundDate, string FoundPlace, string CCTVCamera, string Cloth, string Advertisement, string Image, string Gander, string YourName, string Email, string Contact, string CurrentAddress, string AskQuestion)
        {
            return (ob.InsertReportSightingDataWithReferenec(R_ID, Reference, MissingThingName, CompanyName, BrandName, Color, CNICNumber, CNICFamily, MissingPersonname, FoundDate, FoundPlace, CCTVCamera, Cloth, Advertisement, Image, Gander, YourName, Email, Contact, CurrentAddress, AskQuestion));

        }

        // Calling Services of InsertReportSightingData Method.
        public bool InsertReportSightingData(int R_ID, string MissingThingName, string CompanyName, string BrandName, string Color, string CNICNumber, string CNICFamily, string MissingPersonname, string FoundDate, string FoundPlace, string CCTVCamera, string Cloth, string Advertisement, string Image, string Gander, string YourName, string Email, string Contact, string CurrentAddress, string AskQuestion)
        {
            return (ob.InsertReportSightingData(R_ID,MissingThingName, CompanyName, BrandName, Color, CNICNumber, CNICFamily, MissingPersonname, FoundDate, FoundPlace, CCTVCamera, Cloth, Advertisement, Image, Gander, YourName, Email, Contact, CurrentAddress, AskQuestion));
        }

        // Calling Report Sighting Data Method For Admin Panel.
        public List<ReportSightingPageObjects> SelectReportSightingMethodForAdminPanel()
        {
            return ob.SelectReportSightingMethodForAdminPanel();
        }

        // Delete Report Sighting Report.
        public bool DeleteSightingReport(int SightingID)
        {
            return ob.DeleteSightingReport(SightingID);
        }

        // Search Report Sighting Data.
        public List<ReportSightingPageObjects> SearchReportSightingData(string Name)
        {
            return ob.SearchReportSightingData(Name);
        }

        // Select Total Number of Posts From Report SIghting For Admin Panel.
        public List<ReportSightingPageObjects> TotalReportSightingPosts()
        {
            return ob.TotalReportSightingPosts();
        }
    }
}
