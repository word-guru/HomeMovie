using HomeMovie.Models;

namespace HomeMovie.Repozitories.Interfaces
{
    public interface IMovieRepozitori
    {
        List<Movie> GetAll();
        Movie GetById(int id);
    }
}
