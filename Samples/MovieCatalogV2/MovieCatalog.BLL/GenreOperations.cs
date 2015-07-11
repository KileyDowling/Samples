using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieCatalog.Data;
using MovieCatalog.Models;

namespace MovieCatalog.BLL
{
    public class GenreOperations
    {
        public List<Genre> GetGenres()
        {
            var repo = new GenreRepository();
            return repo.GetAll();
        }
    }
}
