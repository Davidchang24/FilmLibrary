using System;
using System.Collections.Generic;
using DataInterfaces;

namespace DataInterfaces
{
    public interface IReviewContext
    {
        List<IReviewDto> GetReviews();
        void AddReview(IReviewDto review);
        void RemoveReview(int reviewId);
    }
}
