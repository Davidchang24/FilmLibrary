using System;
using System.Collections.Generic;
using System.Text;
using DataInterfaces;

namespace DAL.Dto
{
    public class FilmDto : IFilmDto
    {
        public string filmName { get; set; }
        public string filmInformation { get; set; }
        public DateTime filmReleaseDate { get; set; }
    }
}
