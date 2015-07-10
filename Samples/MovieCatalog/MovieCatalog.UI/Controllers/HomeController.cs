using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieCatalog.BLL;

namespace MovieCatalog.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var ops = new MovieOperations();
            var results = ops.GetAllMovies();

            return View(results);
        }
    }
}