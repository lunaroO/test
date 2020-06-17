using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index(string name="hhh",int num=1)
        {
            ViewBag.m = "hello" + name;
            ViewBag.num = num;
            return View();
        }
    }
}