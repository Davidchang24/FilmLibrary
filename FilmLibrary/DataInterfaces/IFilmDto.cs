using System;
using DataInterfaces;

namespace DataInterfaces
{
    public interface IFilmDto
    {
        int FilmId { get; set; }
        string FilmName { get; set; }
        string FilmInformation { get; set; }
        string FilmReleaseDate { get; set; }
    }
}
