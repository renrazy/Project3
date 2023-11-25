using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_Ex02.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.name = "Show your home page";
            return View();
        }
        //Defferent name
        public ActionResult showInfo()
        {
            return View("show");  
        }
        //In share Folder
        public ActionResult Detail()
        {
            return View("Detail");
        }
        //Deferrent Controller
        public ActionResult ShowmoreDetail()
        {
            return View("~/Views/Contact/Myprofile.cshtml");
        }
    }
}