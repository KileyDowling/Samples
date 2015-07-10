using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieCatalog.Models;

namespace MovieCatalog.Data
{
    public class GenreRepository
    {
        public List<Genre> GetAll()
        {
            List<Genre> results = new List<Genre>();
            using (var cn = new SqlConnection(Settings.GetConnectionString()))
            {
                var cmd = new SqlCommand("GenreGetAll",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var genre = new Genre();
                        genre.GenreID = (int) dr["GenreID"];
                        genre.GenreName = dr["GenreName"].ToString();

                        results.Add(genre);
                    }
                }

            }

            return results;
        }
    }
}
