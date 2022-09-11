using HomeMovie.Models;
using HomeMovie.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeMovie.Pages
{
    public class MoviesModel : PageModel
    {
        private readonly IRepozitory _movieRepozitory;
        public List<Movie> _movies { get; set; }

        public MoviesModel(IRepozitory movieRepozitory)
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
