using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Testing.Controllers
{
    public class AnimalController : Controller
    {
        // GET: Animal
        
        public ActionResult AnimalList()
        {
            return View();
        }
        public ActionResult AnimalEntry()
        {
            return View();
        }
    }
}