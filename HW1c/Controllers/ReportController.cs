using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW1c.Models;
using HW1c.Backend;

namespace HW1c.Controllers
{
    public class ReportController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            var myData = new LogBackend().Index();
            return View(myData);
        }
    }
}