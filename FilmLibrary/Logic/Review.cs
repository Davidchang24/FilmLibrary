using System;
using LogicInterfaces;
namespace Logic
{
    public class Review : IReview
    {
        public int ReviewId { get; set; }
        public string ReviewComment { get; set; }
        public int ReviewStars { get; set; }
    }
}
