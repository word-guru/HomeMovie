using HomeMovie.Models;
using HomeMovie.Repozitories.Interfaces;

namespace HomeMovie.Repozitories
{
    public class MovieRepozitory : IMovieRepozitori
    {
        public List<Movie> GetAll()
        {
            return new List<Movie>
            {
                new Movie
                {
                    Id = 0,
                    Name = "Восстание телепузиков",
                    Producer = "Силиванов",
                    Genre = "Фантастика",
                    Description = "Телепузики возвращаются",
                    Session = new List<DateTime>
                    {
                        new DateTime(2022,11,7,13,25,00),
                        new DateTime(2022,11,5,16,25,00),
                        new DateTime(2022,11,6,12,25,00)
                    }
                },
                new Movie
                {
                    Id = 1,
                    Name = "Битва за Простоквашино",
                    Producer = "Карибикян",
                    Genre = "Боевик",
                    Description = "Возвращение Матроскина",
                    Session = new List<DateTime>
                    {
                        new DateTime(2022,11,7,11,00,00),
                        new DateTime(2022,11,5,18,30,00),
                        new DateTime(2022,11,6,22,00,00)
                    }
                },
                new Movie
                {
                    Id = 2,
                    Name = "Шарик",
                    Producer = "Зизигуги",
                    Genre = "Комедия",
                    Description = "Жизнь пса в будке",
                    Session = new List<DateTime>
                    {
                        new DateTime(2022,11,7,13,25,00),
                        new DateTime(2022,11,5,16,25,00),
                        new DateTime(2022,11,6,12,25,00)
                    }
                }
            };
        }

        public Movie GetById(int id)
        {
            var allMovies = GetAll();
            return allMovies.First(x => x.Id == id);
        }
    }
}
