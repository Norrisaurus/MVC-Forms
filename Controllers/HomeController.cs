using MvcForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcForms.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormData model)
        {
            // Global Validation Message
            //ModelState.AddModelError("", "This is a global error message");

            // If there arent any "Duration" field validation errors
            // then make sure the duration is greater than "0".
            ValidateEntry(model);

            if (ModelState.IsValid)
            {
                // Process Form Data
                return View(model);
                //return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        private void ValidateEntry(FormData model)
        {
            if (ModelState.IsValidField("Duration") && model.Duration <= 0)
            {
                ModelState.AddModelError("Duration", "The Duration field value must be greater than 0");
            }
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