﻿using LogicInterfaces;
using Logic;
using System;

namespace LogicFactory
{
    public static class ViewFactory
    {
        public static IFilm GetFilm()
        {
            return new Film(DataFactory.DataFactory.GetFilmContext());
        }

        public static IFilmCollection GetFilmCollection()
        {
            return new FilmCollection(DataFactory.DataFactory.GetFilmContext());
        }
    } 
}