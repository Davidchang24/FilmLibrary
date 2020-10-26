using System;
using System.Collections.Generic;
using System.Text;

namespace LogicInterfaces
{
    public interface IFilm
    {
        int filmId { get; }
        string filmName { get; }
        string filmInformation { get; }
        string filmReleaseDate { get; }
    }
}
