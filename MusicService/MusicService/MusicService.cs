using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MusicService
{
    public class MusicService : IMusicService
    {
        /// <summary>
        /// Implement interface methoer of GetMusic
        /// Data extact from Music database through the spGetMusic store procedure
        /// </summary>
        /// <param name="name">Song name that input from client</param>
        /// <returns></returns>
        public Music GetMusic(string name)
        {
            try
            {
                Music music = new Music();
                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("spGetMusic", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parameterId = new SqlParameter();
                    parameterId.ParameterName = "@name";
                    parameterId.Value = name;
                    cmd.Parameters.Add(parameterId);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        music.Id = Convert.ToInt32(reader["Id"]);
                        music.SongName = reader["SongName"].ToString();
                        music.Artist = reader["Artist"].ToString();
                        music.Album = reader["Album"].ToString();
                        music.ReleaseYear = reader["ReleaseYear"].ToString();
                    }
                }
                return music;
            }
            catch (System.Data.SqlTypes.SqlTypeException exception)
            {
                // Output expected SqlTypeExceptions.
                return null;
            }
            catch (SqlException exception)
            {
                // Output unexpected SqlExceptions.
                return null;
            }
            catch (Exception exception)
            {
                return null;

            }
        }
    }
}
