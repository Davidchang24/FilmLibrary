using System;
namespace LogicInterfaces
{
    public interface IReview
    {
        int ReviewId { get; set; }
        string ReviewComment { get; set; }
        int ReviewStars { get; set; }
    }
}
