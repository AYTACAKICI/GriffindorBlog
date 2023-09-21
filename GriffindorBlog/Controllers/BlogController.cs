using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GriffindorBlog.Controllers
{
    public class BlogController : Controller
    {
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
        //public IActionResult Login()
        //{
        //    return View();
        //}
        public IActionResult Register()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Register()
        //{
        //    return View();
        //}
    }
}
