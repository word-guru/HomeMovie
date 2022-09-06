using HomeMovie.Models;
using HomeMovie.Repozitories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeMovie.Pages
{
    public class MoviesModel : PageModel
    {
        private readonly IMovieRepozitori _movieRepozitory;
        public List<Movie> _movies { get; set; }

        public MoviesModel(IMovieRepozitori movieRepozitory)
        {
            _movieRepozitory = movieRepozitory;
            _movies = new List<Movie>();
        }

        public void OnGet()
        {
            _movies = _movieRepozitory.GetAll();
        }
    }
}
