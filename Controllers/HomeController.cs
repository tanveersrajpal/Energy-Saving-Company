using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Techofab_Website.Controllers
{
    public class HomeController : Controller
    {
        // GET: Techofab
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Aboutus()
        {
            return View();
        }

        public ActionResult Courses()
        {
            return View();
        }
        
    }
}