﻿using System;
using System.Collections.Generic;
using DataInterfaces;
using MySql.Data.MySqlClient;

namespace DAL.Context
{
    public class GenreContext : IGenreContext
    {
        public List<GenreDto> GetGenres()
        {
            string command = "SELECT * FROM genre";
            List<GenreDto> genres = new List<GenreDto>();

            using (MySqlConnection connect = Connection.GetConnection())
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(command, connect);

                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    genres.Add(new GenreDto()
                    {
                        GenreId = Convert.ToInt32(reader["genreId"]),
                        GenreName = reader["genreName"].ToString(),
                        GenreDesc = reader["genreDesc"].ToString()
                    });
                }
            }
            return genres;
        }

        public void AddGenre(GenreDto genre)
        {
            string command = "INSERT INTO `genre` (`genreId`, `genreName`, `GenreDesc`) VALUES ({0}, '{1}' ,{2}');";

            using (MySqlConnection connect = Connection.GetConnection())
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(command, connect);

                cmd.ExecuteNonQuery();
            }

        }

        public void RemoveGenre(int genreId)
        {
            string command = "DELETE FROM genre WHERE genreId = {0};";

            using (MySqlConnection connect = Connection.GetConnection())
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format(command, genreId), connect);

                cmd.ExecuteNonQuery();
            }
        }

        public List<GenreDto> GetGenreByFilmId(int filmId)
        {
            string command = "SELECT genre.genreId, genreName FROM filmGenre JOIN genre ON genre.genreId = filmGenre.genreId WHERE filmId = {0}";
            List<GenreDto> genreDtos = new List<GenreDto>();

            using (MySqlConnection connect = Connection.GetConnection())
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format(command, filmId), connect);

                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    genreDtos.Add(new GenreDto()
                    {
                        GenreId = Convert.ToInt32(reader["genreId"]),
                        GenreName = reader["genreName"].ToString(),
                    });
                }
            }
            return genreDtos;
        }
    }
}
