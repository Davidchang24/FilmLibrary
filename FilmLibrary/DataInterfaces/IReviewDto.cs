using System;
namespace DataInterfaces
{
    public interface IReviewDto
    {
        int ReviewId { get; set; }
        string ReviewComment { get; set; }
        int ReviewStars { get; set; }
    }
}
