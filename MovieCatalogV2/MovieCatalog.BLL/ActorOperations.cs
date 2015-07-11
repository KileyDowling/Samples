using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieCatalog.Data;
using MovieCatalog.Models;

namespace MovieCatalog.BLL
{
    public class ActorOperations
    {
        public List<Actor> GetActorsNotInMovie(int movieID)
        {
            var repo = new ActorRepository();
            return repo.GetActorsNotInMovie(movieID);
        }

        public List<Actor> GetActorsInMovie(int movieID)
        {
            var repo = new ActorRepository();
            return repo.GetActorsInMovie(movieID);
        }
    }

}
