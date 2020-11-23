
using DataInterfaces;

namespace DAL.Dto
{
    public class GenreDto : IGenreDto
    {
        public int GenreId { get; set; }
        public string GenreTitle { get; set; }
        public string GenreDesc { get; set; }
    }
}
