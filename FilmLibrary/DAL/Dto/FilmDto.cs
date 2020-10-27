using DataInterfaces;

namespace DAL.Dto
{
    public class FilmDto : IFilmDto
    {
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public string FilmInformation { get; set; }
        public string FilmReleaseDate { get; set; }
    }
}
