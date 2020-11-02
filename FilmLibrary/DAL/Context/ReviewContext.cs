using System;
using System.Collections.Generic;
using DataInterfaces;
using DAL.Dto;
using MySql.Data.MySqlClient;

namespace DAL.Context
{
    public class ReviewContext : IReviewContext
    {
        public List<IReviewDto> GetReviews()
        {
            string command = "SELECT * FROM review";
            List<IReviewDto> reviews = new List<IReviewDto>();
            using (MySqlConnection connect = Connection.GetConnection())
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(command, connect);

                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reviews.Add(new ReviewDto()
                    {
                        ReviewId = Convert.ToInt32(reader["reviewId"]),
                        ReviewComment = reader["reviewComment"].ToString(),
                        ReviewStars = Convert.ToInt32(reader["reviewStars"])

                    });
                }
            }
            return reviews;
        }

        public void AddReview(IReviewDto review)
        {
            string command = "INSERT INTO `review` (`reviewId`, `reviewComment`, `reviewStars`) VALUES ({0}, '{1}' ,{2});";

            using (MySqlConnection connect = Connection.GetConnection())
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format(command, review.ReviewId, review.ReviewComment, review.ReviewStars), connect);

                cmd.ExecuteNonQuery();
            }
        }

        public void RemoveReview(int reviewId)
        {
            string command = "DELETE FROM review WHERE reviewId = {0};";

            using (MySqlConnection connect = Connection.GetConnection())
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format(command, reviewId), connect);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
