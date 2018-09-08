using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using BOL;

namespace UI.Admin
{
    public partial class Comments : System.Web.UI.Page
    {
        public List<CommentObjects> DisplayComment;
        CommentsBusiness ob = new CommentsBusiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminUsername"] == null)
                Response.Redirect("Login.aspx");
            DisplayComment = ob.SelectAllComments();
            DeleteComment();
            Sessions();
            if (!IsPostBack)
                Session.Remove("CommentDelete");
        }

        private void Sessions()
        {
            if (Session["CommentDelete"] != null)
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>displayDeleteSuccessMessage();</script>");
        }

        private void DeleteComment()
        {
            if(Request.QueryString["Comment_Delete_Id"] != null)
            {
                if (ob.DeletComment(Convert.ToInt32(Request.QueryString["Comment_Delete_Id"])))
                {
                    Session["CommentDelete"] = "Comment Delete";
                    Response.Redirect("Comments.aspx");
                }
            }
        }
    }
}