using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieCatalog.BLL;
using MovieCatalog.Models;
using MovieCatalog.UI.Models;

namespace MovieCatalog.UI.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie

        public ActionResult Edit(int movieID)
        {
            var model = new MovieEditVM();

            var movieOps = new MovieOperations();
            var genreOps = new GenreOperations();
            var actorOps = new ActorOperations();

            var listOfGenres = genreOps.GetGenres();
            var listOfActors = actorOps.GetActorsNotInMovie(movieID);

            model.MovieToEdit = movieOps.Get(movieID);
            model.ActorsInMovie = actorOps.GetActorsInMovie(movieID);

            //generates selectlistitem for genres & actorsnotinmovie
            model.CreateGenreList(listOfGenres);
            model.CreateActorsNotInMovie(listOfActors);


            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(MovieEditVM movieEditVm)
        {
            var movieOps = new MovieOperations();
            movieEditVm.MovieToEdit = movieOps.UpdateMovie(movieEditVm.MovieToEdit);


            return RedirectToAction("Index", "Home");
        }
    }
}