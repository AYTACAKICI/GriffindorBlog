using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffindorBlog.Database.Entities
{
  public  class Article
    {
        [Key]
        public int ArticleID { get; set; }
        public string ArticleTitleName { get; set; }
        public string Content { get; set; }
        public bool IsPublish { get; set; }
        public int UserID { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime UpdateTime { get; set; }


        public User User { get; set; }
        public List<Comment> Comment { get; set; }

    }
}
