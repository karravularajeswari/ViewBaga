using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class ViewBagExampleController : Controller
    {
        // GET: ViewBagExample
        public ActionResult Index()
        {
            ViewBag.Uname = "RP";
            ViewBag.Categories = new List<string>()
            {
                "Electronics",
                "Shoes"
            };
            return View();
        }
    }
}