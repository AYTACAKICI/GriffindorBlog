
using GriffindorBlog.DAL.Interfaces;
using GriffindorBlog.Database.Context;
using GriffindorBlog.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace GriffindorBlog.DAL.Concrete
{
   public class BlokDAL : IBlokDAL
    {
        BlogContext _context;
        public BlokDAL(BlogContext context)
        {
            _context = context;
        }

        public bool AddArticles(Article article)
        {
            _context.Article.Add(article);
          int returned =  _context.SaveChanges();
            if (returned>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Article> GetArticles()
        {
           var articles = _context.Article.ToList();

            return articles;
        }

        public User Login(string username,string password)
        {
            var user = _context.User.FirstOrDefault(x => x.UserName == username);
            if (user==null)
            {
                return null;
            }
            if (user.Password != password)
            {
                return null;
            }
            else
            {
                return user;
            }
        }

        public User Register(User user)
        {
          User AddedUser =  _context.User.Add(user).Entity;
          var deger =  _context.SaveChanges();
            if (deger>0)
            {
                return AddedUser;
            }
            else
            {
                return null;
            }
        }
        public List<SelectListItem> Roles()
        {
            //List<SelectListItem> roleList = (from role in _context.Role
            //                                 select new SelectListItem { Text = role.RoleName, Value = role.RoleID.ToString() }).ToList();
            List<SelectListItem> roleList = _context.Role.Select(x => new SelectListItem() { Text = x.RoleName, Value = x.RoleID.ToString() }).ToList();                    
            return roleList;
        }

        public bool UserExists(string username)
        {
          return ! _context.User.Any(x => x.UserName == username);
        }
    }
}
