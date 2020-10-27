using DataInterfaces;
using DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Dto;

namespace DAL.Context
{
    public class ActorContext : IActorContext
    {
        public List<IActorDto> GetActors()
        {
            string command = "SELECT * FROM actors";
            List<IActorDto> actors = new List<IActorDto>();
            using (MySqlConnection connect = Connection.GetConnection())
            {

                connect.Open();
                MySqlCommand cmd = new MySqlCommand(command, connect);

                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    actors.Add(new ActorDto()
                    {
                        ActorId = Convert.ToInt32(reader["actorId"]),
                        ActorName = reader["actorName"].ToString(),
                        ActorInfo = reader["ActorInfo"].ToString()
                    }) ;
                }
            }
            return actors;
        }
        public void AddActor(IActorDto actorDto)
        {
            string command = "INSERT INTO `actor` (`actorId`, `actorName`, `actorInfo`) VALUES ({0}, '{1]', '{2}');";   
            using (MySqlConnection connect = Connection.GetConnection())
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format(command, actorDto.ActorId, actorDto.ActorName, actorDto.ActorInfo), connect);
                
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteActor(int ActorId)
        {
            string command = "DELETE FROM actor WHERE actorId = {0};"; 

            using(MySqlConnection connect = Connection.GetConnection())
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format(command, ActorId), connect);

                cmd.ExecuteNonQuery();
            }
        }
        public void EditActor(string actorName, string actorInfo, int actorId)
        {
            string command = "UPDATE actor SET actorName='{0}', actorInfo='{1}' actorId = {2};";

            using (MySqlConnection connect = Connection.GetConnection())
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format(command, actorName, actorInfo, actorId), connect);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
