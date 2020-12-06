using System;
using DataFactory;
using DataInterfaces;
using System.Collections.Generic;
namespace Logic
{
    public class ReviewCollection 
    {
        private List<Review> _reviews;

        public ReviewCollection()
        {
            IReviewContext db = DataFactory.DataFactory.GetReviewContext();
            _reviews = new List<Review>();
            List<ReviewDto> reviewDtos = db.GetReviews();
            foreach (var review in reviewDtos)
            {
                _reviews.Add(new Review()
                {
                    ReviewId = review.ReviewId,
                    ReviewComment = review.ReviewComment,
                    ReviewStars = review.ReviewStars
                });
            }
        }

        public void AddReview(Review review)
        {
            IReviewContext db = DataFactory.DataFactory.GetReviewContext();
            ReviewDto reviewDto = DataFactory.DataFactory.GetReviewDto();

            reviewDto.ReviewId = review.ReviewId;
            reviewDto.ReviewComment = review.ReviewComment;
            reviewDto.ReviewStars = review.ReviewStars;

            db.AddReview(reviewDto);
        }

        public void RemoveReview(int reviewId)
        {
            IReviewContext db = DataFactory.DataFactory.GetReviewContext();
            db.RemoveReview(reviewId);
        }

        public void EditReview()
        {

        }

        public IReadOnlyList<Review> GetReviews()
        {
            return _reviews;
        }
    }
}
