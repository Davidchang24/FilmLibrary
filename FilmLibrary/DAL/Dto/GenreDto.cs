
using DataInterfaces;

namespace DAL.Dto
{
    public class GenreDto : IGenreDto
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public string GenreDesc { get; set; }
    }
}
