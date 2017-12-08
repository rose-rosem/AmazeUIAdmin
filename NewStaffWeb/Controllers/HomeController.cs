using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewStaffWeb.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Download()
        {
            return View();
        }

        public ActionResult Lottery()
        {
            return View();
        }

        public ActionResult Data()
        {
            return View();
        }

        public ActionResult Date()
        {
            return View();
        }
    }
}