using System;
using DataInterfaces;
namespace DataInterfaces
{
    public class ReviewDto 
    {
        public int ReviewId { get; set; }
        public string ReviewComment { get; set; }
        public int ReviewStars { get; set; }
    }
}
