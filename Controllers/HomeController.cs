﻿using System;
using System.Web.Mvc;

namespace DevTrends.MvcDonutCaching.Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Simple");
        }

        //
        // GET: /Home/
        [DonutOutputCache(Duration = 24 * 3600)]
        public ActionResult Simple()
        {
            return View(DateTime.Now);
        }

        [ChildActionOnly, DonutOutputCache(Duration = 60)]
        public ActionResult SimpleDonutOne()
        {
            return PartialView(DateTime.Now);
        }

        [ChildActionOnly]
        public ActionResult SimpleDonutTwo()
        {
            return PartialView(DateTime.Now);
        }
    }
}
