using HomeMovie.Models;
using HomeMovie.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMovie.Services
{
    public class MovieRepozitory : IRepozitory
    {
        public List<Movie> GetAll()
        {
            return new List<Movie>
            {
                new Movie
                {
                    Id = 0,
                    Name = "Терминатор",
                    Producer = "Силиванов",
                    Genre = Genres.Фантастика,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit," +
                    " sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
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
                    Name = "Рэмбо",
                    Producer = "Карибикян",
                    Genre = Genres.Боевик,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit," +
                    " sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
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
                    Name = "Каникулы",
                    Producer = "Зизигуги",
                    Genre = Genres.Комедия,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit," +
                    " sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
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
