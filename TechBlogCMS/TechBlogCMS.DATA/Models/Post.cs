using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBlogCMS.DATA.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public int UserID { get; set; }
        public string PostContent { get; set; }
        public int StatusID { get; set; }
        public DateTime PostDate { get; set; }
    }
}
