using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_Ex02.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Detail()
        {
            return View("Details");
        }
        public ActionResult Mycontent()
        {
            return View("Hello");
        }
        public int add()
    }
}