
using GriffindorBlog.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace GriffindorBlog.DAL.Interfaces
{
  public  interface IBlokDAL
    {
        User Register(User user);
        User Login(string username,string Password);
        bool UserExists(string username);
        bool AddArticles(Article article);
        
        List<Article> GetArticles();
        List<SelectListItem> Roles();

    }
}
