﻿
using GriffindorBlog.DAL.Interfaces;
using GriffindorBlog.Database.Context;
using GriffindorBlog.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffindorBlog.DAL.Concrete
{
    class BlokDAL : IBlokDAL
    {
        BlogContext _context;
        public BlokDAL(BlogContext context)
        {
            _context = context;
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

        public bool UserExists(string username)
        {
          return ! _context.User.Any(x => x.UserName == username);
        }
    }
}
