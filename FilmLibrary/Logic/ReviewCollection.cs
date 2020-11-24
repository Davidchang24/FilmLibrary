using System;
using LogicInterfaces;
using DataFactory;
using DataInterfaces;
using System.Collections.Generic;
namespace Logic
{
    public class ReviewCollection : IReviewCollection
    {
        private List<IReview> reviews;

        public ReviewCollection()
        {
            IReviewContext db = DataFactory.DataFactory.GetReviewContext();
            reviews = new List<IReview>();
            List<ReviewDto> reviewDtos = db.GetReviews();
            foreach (var review in reviewDtos)
            {
                reviews.Add(new Review()
                {
                    ReviewId = review.ReviewId,
                    ReviewComment = review.ReviewComment,
                    ReviewStars = review.ReviewStars
                });
            }
        }

        public void AddReview(IReview review)
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

        public IReadOnlyList<IReview> GetReviews()
        {
            return reviews;
        }
    }
}
