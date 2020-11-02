using System;
using System.Collections.Generic;
using DataInterfaces;
using DAL.Dto;
using MySql.Data.MySqlClient;

namespace DAL.Context
{   
    public class FilmContext : IFilmContext
    {
        public List<IFilmDto> GetFilms()
        {
            string command = "SELECT * FROM film";
            List<IFilmDto> films = new List<IFilmDto>();
            using (MySqlConnection connect = Connection.GetConnection())
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(command, connect);

                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    films.Add(new FilmDto()
                    {
                        FilmId = Convert.ToInt32(reader["filmId"]),
                        FilmName = reader["filmName"].ToString(),
                        FilmInformation = reader["filmInformation"].ToString()

                    }); 
                }
            }
            return films;
        }

        public void AddFilm(IFilmDto film)
        {
            string command = "INSERT INTO `film` (`filmId`, `filmName`, `filmInformation`, `filmReleaseDate`) VALUES ({0}, '{1}' ,{2}', '{3}');";

            using (MySqlConnection connect = Connection.GetConnection())
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format(command,film.FilmId, film.FilmName,film.FilmInformation,
                                                                  film.FilmReleaseDate), connect);

                cmd.ExecuteNonQuery();
            }
        }

        public void RemoveFilm(int filmId)
        {
            string command = "DELETE FROM film WHERE filmId = {0};";

            using(MySqlConnection connect = Connection.GetConnection())
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format(command, filmId), connect);

                cmd.ExecuteNonQuery();
            }
        }

        public void EditFilm(string filmName, string filmInformation, string filmReleaseDate, int filmId)
        {
            string command = "UPDATE film SET filmName='{0}', filmInformation='{1}', filmReleaseDate='{2}' WHERE filmId='{3}';";
            
            using (MySqlConnection connect = Connection.GetConnection())
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format(command, filmName, filmInformation, filmReleaseDate, filmId), connect);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
