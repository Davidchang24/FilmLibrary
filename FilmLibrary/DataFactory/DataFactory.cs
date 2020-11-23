using DataInterfaces;
using DAL.Dto;
using DAL.Context;

namespace DataFactory
{
    public static class DataFactory
    {
        public static IFilmContext GetFilmContext()
        {
            return new FilmContext();
        }

        public static IFilmDto GetFilmDto()
        {
            return new FilmDto();
        }

        public static IAccountDto GetAccountDto()
        {
            return new AccountDto();
        }

        public static IAccountContext GetAccountContext()
        {
            return new AccountContext();
        }

        public static IActorDto GetActorDto()
        {
            return new ActorDto();
        }

        public static IActorContext GetActorContext()
        {
            return new ActorContext();
        }
        public static IGenreContext GetGenreContext()
        {
            return new GenreContext();
        }

        public static IGenreDto GetGenreDto()
        {
            return new GenreDto();
        }

        public static IReviewContext GetReviewContext()
        {
            return new ReviewContext();
        }

        public static IReviewDto GetReviewDto()
        {
            return new ReviewDto();
        } 
    }
}
