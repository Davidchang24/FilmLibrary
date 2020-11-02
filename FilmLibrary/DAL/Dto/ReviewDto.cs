using System;
using DataInterfaces;
namespace DAL.Dto
{
    public class ReviewDto : IReviewDto
    {
        public int ReviewId { get; set; }
        public string ReviewComment { get; set; }
        public int ReviewStars { get; set; }
    }
}
