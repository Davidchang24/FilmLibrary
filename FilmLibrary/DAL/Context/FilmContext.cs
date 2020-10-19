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
                        filmId = Convert.ToInt32(reader["filmId"]),
                        filmName = reader["filmName"].ToString(),
                        filmInformation = reader["filmInformation"].ToString()

                    }); ;
                }
            }
            return films;
        }
    }
}
