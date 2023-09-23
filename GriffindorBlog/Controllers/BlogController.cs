using GriffindorBlog.Database.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GriffindorBlog.DAL.Interfaces;

namespace GriffindorBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlokDAL _blokdal;
        public BlogController(IBlokDAL blokdal)
        {
            _blokdal = blokdal;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
           var articles = _blokdal.GetArticles();
            return View(articles);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
         
           
            if (ModelState.IsValid)
            {
               var retuned =   _blokdal.Login(user.UserName, user.Password);
                if (retuned.UserName==null)
                {
                    return RedirectToAction("LoginError");
                }
                else
                {
                    return RedirectToAction("About");
                }

            }
            else
            {
                return RedirectToAction("Login");
            }


        }
        [HttpGet]
        public IActionResult LoginError()
        {
            
            return View();
        }


        [HttpGet]
        public IActionResult Register()
        {
          ViewBag.roles= _blokdal.Roles();
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            
            if(ModelState.IsValid)
            {
                if (user.UserName != null&&user.Lastname!=null && user.Password !=null)
                {
                    _blokdal.Register(user);
                    return RedirectToAction("Login");
                }
              
            }
            return RedirectToAction("Register");

        }
    }
}
