
using GriffindorBlog.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffindorBlog.DAL.Interfaces
{
    interface IBlokDAL
    {
        User Register(User user);
        User Login(string username,string Password);
        bool UserExists(string username);
    }
}
