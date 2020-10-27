using DataInterfaces;
using DAL.Dto;
using DAL.Context;

namespace DataFactory
{
    public static class Factory
    {
        public static IFilmContext GetFilmContext()
        {
            return new FilmContext();
        }

        public static IFilmDto GetFilm()
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

        public static IActorDto GetActor()
        {
            return new ActorDto();
        }

        public static IActorContext GetActorContext()
        {
            return new ActorContext();
        }
    }
}
