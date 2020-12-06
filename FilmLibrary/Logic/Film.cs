using DataFactory;
using System.Collections.Generic;
using DataInterfaces;
using System;

namespace Logic
{
    public class Film 
    {
        public int FilmId { get; set; }
        public string FilmName { get;  set; }
        public string FilmInformation { get;  set; }
        public DateTime FilmReleaseDate { get; set; }
        public IReadOnlyCollection<string> itest { get { return test.AsReadOnly(); } }
        public List<string> test { get; private set; } = new List<string>();

        public void EditFilm()
        {

        }
    }

    public class Test
    {
        public void Test1()
        {
            Film film = new Film();
        }
    }
}
