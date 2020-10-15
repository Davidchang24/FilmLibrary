using DataInterfaces;

namespace DAL.Dto
{
    public class FilmDto : IFilmDto
    {
        public int filmId { get; set; }
        public string filmName { get; set; }
        public string filmInformation { get; set; }
        public string filmReleaseDate { get; set; }
    }
}
