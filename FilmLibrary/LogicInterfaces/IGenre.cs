using System;
namespace LogicInterfaces
{
    public interface IGenre
    {
        int GenreId { get; set; }
        string GenreTitle { get; set; }
        string GenreDesc { get; set; }
    }
}
