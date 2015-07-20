using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExerciseLog.UI.Models;

namespace ExerciseLog.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var database = new FakeExerciseLogDatabase();
            var exercises = database.GetAll();

            return View(exercises);
        }
    }
}