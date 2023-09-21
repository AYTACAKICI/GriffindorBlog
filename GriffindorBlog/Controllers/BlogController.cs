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
            return View();
        }
        public IActionResult Contact()
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
             _blokdal.Login(user.UserName, user.Password);
               
            }
            if (user != null)
            {
                return RedirectToAction("About");
            }
            else
            {
                return RedirectToAction("Login");
            }


        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            
            if(ModelState.IsValid)
            {
                _blokdal.Register(user);
            }
            return RedirectToAction("Index");
        }
    }
}
