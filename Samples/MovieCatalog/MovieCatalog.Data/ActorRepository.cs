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
    public class ActorRepository
    {
        public List<Actor> GetActorsNotInMovie(int movieID)
        {

            List<Actor> results = new List<Actor>();
            using (var cn = new SqlConnection(Settings.GetConnectionString()))
            {
                var cmd = new SqlCommand("ActorGetNotInMovie", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MovieID", movieID);

                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var actor = new Actor();
                        actor.ActorID = (int)dr["ActorID"];
                        actor.FirstName = dr["FirstName"].ToString();
                        actor.LastName = dr["LastName"].ToString();
                        if (dr["DateOfBirth"] != DBNull.Value)
                        {
                            actor.DateOfBirth = (DateTime)dr["DateOfBirth"];
                        }

                        results.Add(actor);
                    }
                }
            }
            return results;


        }


        public List<Actor> GetActorsInMovie(int movieID)
        {
            List<Actor> results = new List<Actor>();
            using (var cn = new SqlConnection(Settings.GetConnectionString()))
            {
                var cmd = new SqlCommand("ActorGetInMovie", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MovieID", movieID);

                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var actor = new Actor();
                        actor.ActorID = (int)dr["ActorID"];
                        actor.FirstName = dr["FirstName"].ToString();
                        actor.LastName = dr["LastName"].ToString();
                        if (dr["DateOfBirth"] != DBNull.Value)
                        {
                            actor.DateOfBirth = (DateTime)dr["DateOfBirth"];
                        }

                        results.Add(actor);
                    }
                }
            }
            return results;


        }

    }
}
