using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterfaces
{
    public interface IFilmContext
    {
        List<IFilmDto> GetFilms();
    }
}
