using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using MovieCatalog.Models;

namespace MovieCatalog.Data
{
    public class MovieRepository
    {

        public Movie Get(int movieID)
        {
            Movie result = new Movie();

            using (var cn = new SqlConnection(Settings.GetConnectionString()))
            {
                var cmd = new SqlCommand("MovieGet", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MovieID", movieID);

                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result.MovieID = (int) dr["MovieID"];
                        result.GenreID = (int) dr["GenreID"];
                        result.Title = dr["Title"].ToString();
                        if (dr["ReleaseYear"] != DBNull.Value)
                        {
                            result.ReleaseYear = (int) dr["ReleaseYear"];
                        }
                    }
                }
            }
            return result;
        }

        public List<MovieListItem> GetMovieList()
        {
            List<MovieListItem> results = new List<MovieListItem>();

            using (var cn = new SqlConnection(Settings.GetConnectionString()))
            {
                var cmd = new SqlCommand("MovieGetAll", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var item = new MovieListItem();
                        item.MovieID = (int) dr["MovieID"];
                        item.GenreID = (int) dr["GenreID"];
                        item.Title = dr["Title"].ToString();
                        item.GenreName = dr["GenreName"].ToString();
                        if (dr["ReleaseYear"] != DBNull.Value)
                        {
                            item.ReleaseYear = (int) dr["ReleaseYear"];
                        }
                        results.Add(item);
                    }
                }
            }
            return results;

        }

        public Movie UpdateMovie(Movie newMovieDetails)
        {

            using (var cn = new SqlConnection(Settings.GetConnectionString()))
            {
                var cmd = new SqlCommand("MovieUpdate", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MovieID", newMovieDetails.MovieID);
                cmd.Parameters.AddWithValue("@Title", newMovieDetails.Title);
                cmd.Parameters.AddWithValue("@ReleaseYear", newMovieDetails.ReleaseYear);
                cmd.Parameters.AddWithValue("@GenreId", newMovieDetails.GenreID);

                cn.Open();
                cmd.ExecuteNonQueryAsync();
            }
            return Get(newMovieDetails.MovieID);
        }
    }
}