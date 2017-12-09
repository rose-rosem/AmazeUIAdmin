using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewStaffWeb.Models;

namespace NewStaffWeb.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private Customer db = new Customer();
        public ActionResult Index()
        {
            return View(db.zq_CustomerTable.ToList());
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