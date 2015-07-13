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
        public ActionResult Edit(int id)
        {
            var model = new MovieEditVM();
            var movieOps = new MovieOperations();
            var genreOps = new GenreOperations();
            var actorOps = new ActorOperations();

            model.MovieToEdit = movieOps.Get(id);
            model.CreateGenreList(genreOps.GetGenres());
            model.CreateActorsNotInMovie(actorOps.GetActorsNotInMovie(id));
            model.ActorsInMovie = actorOps.GetActorsInMovie(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(MovieEditVM movieEditVm)
        {
            var ops = new MovieOperations();
            ops.UpdateMovie(movieEditVm.MovieToEdit);

            return RedirectToAction("Edit",  new {id=movieEditVm.MovieToEdit.MovieID});
        }

        [HttpPost]
        public ActionResult RemoveActor(int ActorID, int MovieID)
        {
            var movieOps = new MovieOperations();
            movieOps.RemoveActorFromMovie(ActorID, MovieID);

            return RedirectToAction("Edit", new {id=MovieID});
        }

        [HttpPost]
        public ActionResult AddActors(MovieEditVM model)
        {
            var ops = new MovieOperations();
            ops.AddActors(model.SelectedActors, model.MovieToEdit.MovieID);

            return RedirectToAction("Edit", new { id = model.MovieToEdit.MovieID });
        }
    }
}