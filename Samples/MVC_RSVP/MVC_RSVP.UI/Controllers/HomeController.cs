using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_RSVP.UI.Models;

namespace MVC_RSVP.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegistrationForm()
        {
            var model = new RsvpResponse();
            return View(model);
        }

        public ActionResult RegistrationForm2()
        {
            var model = new RsvpResponse();
            return View(model);
        }
        [HttpPost]
        public ActionResult RegistrationForm(RsvpResponse model)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", model);
            }
            else
            {
                return View(model);
            }
        }
    }
}