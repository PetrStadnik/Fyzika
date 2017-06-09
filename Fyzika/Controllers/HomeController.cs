using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fyzika.Models;

namespace Fyzika.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pyramidky()
        {
            PyramidyManager pyrmidyManager = new PyramidyManager();
            
            ViewBag.Message = "Najděte si ten, který potřebujete";
            ViewBag.PyramidkyList = pyrmidyManager.VratList().ToString();

            return View(pyrmidyManager);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}