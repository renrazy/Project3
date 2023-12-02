using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace Test_Ex02.Controllers
{
    public class MasterController : Controller
    {
        // GET: Master
        public ActionResult Show()
        {
            //return Content("Hello");
            return File(Server.MapPath("~/Content/Master.txt"),"text/plain");
        }
        public ActionResult Download()
        {
            return File(Server.MapPath("~/Content/Master.txt"),"text/plain","MVC5.txt");
        }
        public ActionResult ShowInternal() 
        {
            return Redirect("/Home/Showinfo");
        }
        public ActionResult ShowExternal()
        {
            return Redirect("https://google.com");
        }
    }
}