using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieCatalog.Data;
using MovieCatalog.Models;

namespace MovieCatalog.BLL
{
    public class MovieOperations
    {
        public Movie Get(int movieID)
        {
            var repo = new MovieRepository();
            return repo.Get(movieID);
        }

        public List<MovieListItem> GetAllMovies()
        {
            var repo = new MovieRepository();
            return repo.GetMovieList();
        }

        public void RemoveActorFromMovie(int actorID, int movieID)
        {
            var repo = new MovieRepository();
            repo.RemoveActorFromMovie(actorID, movieID);
        }

        public void AddActors(List<int> ActorIDs, int MovieID)
        {
            var repo = new MovieRepository();
            repo.AddActors(ActorIDs, MovieID);
        }

        public void UpdateMovie(Movie movie)
        {
         var repo = new MovieRepository();
            repo.Update(movie);
        }
}
}
