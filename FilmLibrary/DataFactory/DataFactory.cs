using DataInterfaces;
using DAL.Context;

namespace DataFactory
{
    public static class DataFactory
    {
        public static IFilmContext GetFilmContext()
        {
            return new FilmContext();
        }

        public static FilmDto GetFilmDto()
        {
            return new FilmDto();
        }

        public static AccountDto GetAccountDto()
        {
            return new AccountDto();
        }

        public static IAccountContext GetAccountContext()
        {
            return new AccountContext();
        }

        public static ActorDto GetActorDto()
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

        public static GenreDto GetGenreDto()
        {
            return new GenreDto();
        }

        public static IReviewContext GetReviewContext()
        {
            return new ReviewContext();
        }

        public static ReviewDto GetReviewDto()
        {
            return new ReviewDto();
        } 
    }
}
