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

        public Movie UpdateMovie(Movie updatedMovie)
        {
            var repo = new MovieRepository();
            return repo.UpdateMovie(updatedMovie);
        }
}
}
