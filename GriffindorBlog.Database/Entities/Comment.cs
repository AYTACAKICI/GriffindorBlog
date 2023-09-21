using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffindorBlog.Database.Entities
{
   public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public int ArticleID { get; set; }
        public string CommentDetails { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;


        public Article Article { get; set; }
    }
}
