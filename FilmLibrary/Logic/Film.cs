using LogicInterfaces;
using DataFactory;
using DataInterfaces;

namespace Logic
{
    public class Film : IFilm
    {
        private IFilmContext db;
        public int filmId { get; set; }
        public string filmName { get;  set; }
        public string filmInformation { get;  set; }
        public string filmReleaseDate { get;  set; }

        public Film(IFilmContext filmContext)
        {
            db = filmContext;
        }
    }
}
