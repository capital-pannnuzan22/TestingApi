﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Testing.Controllers
{
    public class TestingController : Controller
    {
        // GET: Testing
        public ActionResult Testingindex()
        {
            return View();
        }

        public ActionResult TestingList()
        {
            return View();
        }
    }
}