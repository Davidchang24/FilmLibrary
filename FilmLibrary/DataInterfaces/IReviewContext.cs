using System;
using System.Collections.Generic;
using DataInterfaces;

namespace DataInterfaces
{
    public interface IReviewContext
    {
        List<ReviewDto> GetReviews();
        void AddReview(ReviewDto review);
        void RemoveReview(int reviewId);
    }
}
