using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;

namespace UI
{
    public class Global : System.Web.HttpApplication
    {
        public static void register(RouteCollection route)
        {
            route.MapPageRoute("AboutPage", "about", "~/AboutUs.aspx");
            route.MapPageRoute("ContactPage", "contact", "~/ContactUs.aspx");
            route.MapPageRoute("DefaultPage", "index", "~/Default.aspx");
            route.MapPageRoute("RegisterPage", "register", "~/CreateAccount.aspx");
            route.MapPageRoute("FAQPage", "frequently-asked-questions", "~/FAQs.aspx");
            route.MapPageRoute("FeedbackPage", "feedback", "~/Feedback.aspx");
            route.MapPageRoute("FullPostPage", "missing-post", "~/FullPost.aspx");
            route.MapPageRoute("LoginPage", "login", "~/Login.aspx");
            route.MapPageRoute("MissingPeoplePage", "missing-people-report", "~/MissingPeopleReport.aspx");
            route.MapPageRoute("MissingThingPage", "missing-thing-report", "~/MissingThingReport.aspx");
            route.MapPageRoute("PostReportPage", "post-report", "~/PostReport.aspx");
            route.MapPageRoute("PrintPage", "print-form", "~/Print.aspx");
            route.MapPageRoute("ReportSightingPage", "report-sighting", "~/ReportAsighting.aspx");
            route.MapPageRoute("SeekingInformationPage", "seeking-information", "~/SeekingInformation.aspx");
            route.MapPageRoute("UnidentifiedPeoplePage", "unidentified-people-report", "~/UnidentifiedPeople.aspx");
            route.MapPageRoute("ViewAllPostsPage", "all-posts", "~/ViewAllPosts.aspx");
            route.MapPageRoute("MyProfilePage", "Profile/user-profile", "~/Profile/MyProfile.aspx");
            route.MapPageRoute("EditProfilePage", "Profile/edit-profile", "~/Profile/MyEditProfile.aspx");
            route.MapPageRoute("FavouritePage", "Profile/favourite-post", "~/Profile/FavouritePost.aspx");
            route.MapPageRoute("EditPostPage", "Profile/edit-post", "~/Profile/EditPost.aspx");
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            register(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}