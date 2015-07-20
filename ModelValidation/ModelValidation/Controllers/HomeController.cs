using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelValidation.Models;

namespace ModelValidation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult MakeBooking()
        {
            return View(new Appointment());
        }

        [HttpPost]
        public ActionResult MakeBooking(Appointment appt)
        {
            //if (string.IsNullOrEmpty(appt.ClientName))
            //{
            //    ModelState.AddModelError("ClientName", "Please enter your name");

            //}
            //if (ModelState.IsValidField("Date") && DateTime.Now > appt.Date)
            //{
            //    ModelState.AddModelError("Date", "Please enter a date in the future");
            //}
            //if (!appt.TermsAccepted)
            //{
            //    ModelState.AddModelError("TermsAccepted", "You must accept the terms");
            //}
            //if (ModelState.IsValidField("ClientName") && ModelState.IsValidField("Date"))
            //{
            //    if(appt.ClientName == "Garfield" && appt.Date.DayOfWeek==DayOfWeek.Monday)
            //    {
            //        ModelState.AddModelError("", "Garfield cannot book appointments on Mondays");
            //    }
            //}

            if (ModelState.IsValid)
            {
                return View("Completed", appt);
            }
            return View();
        }
    }
}
