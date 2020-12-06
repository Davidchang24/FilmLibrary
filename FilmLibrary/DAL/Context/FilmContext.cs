using System;
using System.Collections.Generic;
using DataInterfaces;
using MySql.Data.MySqlClient;

namespace DAL.Context
{   
    public class FilmContext : IFilmContext
    {
        public List<FilmDto> GetFilms()
        {
            string command = "SELECT * FROM film";
            List<FilmDto> films = new List<FilmDto>();
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
                        FilmInformation = reader["filmInformation"].ToString(),
                        FilmReleaseDate = Convert.ToDateTime(reader["filmReleaseDate"])
                    }); 
                }
            }
            return films;
        }

        public void AddFilm(FilmDto film)
        {
            string command = "INSERT INTO `film` (`filmId`, `filmName`, `filmInformation`, `filmReleaseDate`) VALUES ({0}, '{1}' ,'{2}', '{3}');";

            using (MySqlConnection connect = Connection.GetConnection())
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format(command, film.FilmId, film.FilmName,film.FilmInformation,
                                                                  film.FilmReleaseDate.ToString("yyyy-MM-dd")), connect);

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

        public void EditFilm(string filmName, string filmInformation, DateTime filmReleaseDate, int filmId)
        {
            string command = "UPDATE film SET filmName='{0}', filmInformation='{1}', filmReleaseDate='{2}' WHERE filmId='{3}';";
            
            using (MySqlConnection connect = Connection.GetConnection())
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format(command, filmName, filmInformation, filmReleaseDate.ToString("yyyy-MM-dd"), filmId), connect);

                cmd.ExecuteNonQuery();
            }
        }

        public List<FilmDto> GetFilmsByDateNewToOld()
        {
            string command = "SELECT * FROM film ORDER BY filmReleaseDate DESC";
            List<FilmDto> films = new List<FilmDto>();
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
                        FilmInformation = reader["filmInformation"].ToString(),
                        FilmReleaseDate = Convert.ToDateTime(reader["filmReleaseDate"])
                    });
                }
            }
            return films;
        }

        public void GetFilmByDate()
        {

        }
    }
}
