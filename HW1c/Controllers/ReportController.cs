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
            var myViewModel = new ReportViewModel();

            myViewModel.LogViewModel = new LogBackend().Index();
            myViewModel.NumberOfUsers = 3;

            return View(myViewModel);
        }
    }
}