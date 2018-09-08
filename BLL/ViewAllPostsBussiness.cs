using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class ViewAllPostsBussiness
    {
        public List<MissingPeoplePageObjects> SelectDataForViewAllPosts()
        {
            ViewAllPostsDB ob = new ViewAllPostsDB();
            return ob.SelectDataForViewAllPosts();
        }
    }
}
