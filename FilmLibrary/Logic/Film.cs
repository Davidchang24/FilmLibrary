using LogicInterfaces;
using DataFactory;
using System.Collections.Generic;
using DataInterfaces;

namespace Logic
{
    public class Film : IFilm
    {
        public int FilmId { get; set; }
        public string FilmName { get;  set; }
        public string FilmInformation { get;  set; }
        public string FilmReleaseDate { get; set; }
        public IReadOnlyCollection<string> itest { get { return test.AsReadOnly(); } }
        public List<string> test { get; private set; } = new List<string>();
    }

    public class Test
    {
        public void Test1()
        {
            Film film = new Film();
        }
    }
}
