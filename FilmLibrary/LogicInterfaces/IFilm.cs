using System;
using System.Collections.Generic;
using System.Text;

namespace LogicInterfaces
{
    public interface IFilm
    {
        int FilmId { get; set; }
        string FilmName { get; set; }
        string FilmInformation { get; set; }
        DateTime  FilmReleaseDate { get; set; }
    }
}
