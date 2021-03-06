﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAutofac.Models;

namespace TestAutofac.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = PopulateDate.GetStudents();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}