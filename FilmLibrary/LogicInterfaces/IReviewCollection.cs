using System;
using LogicInterfaces;
using System.Collections.Generic;

namespace Logic
{
    public interface IReviewCollection
    {
        IReadOnlyList<IReview> GetReviews();
        void AddReview(IReview review);
        void RemoveReview(int reviewId);
        void EditReview();
    }
}
