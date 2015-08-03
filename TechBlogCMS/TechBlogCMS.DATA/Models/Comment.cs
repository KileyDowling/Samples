using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBlogCMS.DATA.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int PostID { get; set; }
        public string CommentContent { get; set; }
        public int StatusID { get; set; }
        public int UserID { get; set; }
        public string Nickname { get; set; }
    }
}
