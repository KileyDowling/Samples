using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieCatalog.BLL;
using MovieCatalog.UI.Models;

namespace MovieCatalog.UI.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Edit()
        {
            var model = new MovieEditVM();
            var movieOps = new MovieOperations();
            var genreOps = new GenreOperations();
            var actorOps = new ActorOperations();

            model.MovieToEdit = movieOps.Get();
            return View();
        }
    }
}