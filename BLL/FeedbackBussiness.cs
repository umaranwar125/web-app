using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class FeedbackBussiness
    {
        FeedbackDB ob = new FeedbackDB();
        // Calling User Registration Id Method.
        public void GetUserID(string Username)
        {
            ob.GetUserID(Username);
        }

        // Calling User Feedback Method.
        public bool InsertFeedbackData(int R_ID, string Visit, string Need, string Find, string Opinion, string Likelihood, string Suggestions)
        {
            return ob.InsertFeedbackData(R_ID, Visit, Need, Find, Opinion, Likelihood, Suggestions);
        }

        // Select Feedback Data For Admin Panel.
        public List<FeedbackPageObjects> SelectFeedbackDataForAdminPanel()
        {
            return ob.SelectFeedbackDataForAdminPanel();
        }

        // Select Total Number of Posts From Missing People For Admin Panel.
        public List<FeedbackPageObjects> TotalFeedbacks()
        {
            return ob.TotalFeedbacks();
        }
    }
}
