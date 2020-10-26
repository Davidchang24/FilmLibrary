using System;
using DataInterfaces;

namespace DataInterfaces
{
    public interface IFilmDto
    {
        int filmId { get; set; }
        string filmName { get; set; }
        string filmInformation { get; set; }
        string filmReleaseDate { get; set; }
    }
}
