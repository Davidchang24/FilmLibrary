using System;

namespace DataInterfaces
{
    public interface IFilmDto
    {
        string filmName { get; }
        string filmInformation { get; }
        DateTime filmReleaseDate { get; }
    }
}
