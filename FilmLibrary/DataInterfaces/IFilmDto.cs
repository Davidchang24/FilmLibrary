using System;
using DataInterfaces;

namespace DataInterfaces
{
    public interface IFilmDto
    {
        int filmId { get; }
        string filmName { get; }
        string filmInformation { get; }
        string filmReleaseDate { get; }
    }
}
