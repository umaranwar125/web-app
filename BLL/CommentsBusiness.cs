using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class CommentsBusiness
    {
        CommentsDB ob = new CommentsDB();
        // Select ALL Comments
        public List<CommentObjects> SelectAllComments()
        {
            return ob.SelectAllComments();
        }

        // Delete Comments
        public bool DeletComment(int CommentID)
        {
            return ob.DeletComment(CommentID);
        }

        // Select Total Number of Comments From Comments Table For Admin Panel.
        public List<CommentObjects> TotalComments()
        {
            return ob.TotalComments();
        }
    }
}
