using HomeMovie.Models;
using HomeMovie.Services;
using HomeMovie.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeMovie.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IRepozitory _movieRepozitory;
        public Movie MovieId { get; private set; }

        public DetailsModel(IRepozitory movieRepozitory)
        {
            _movieRepozitory = movieRepozitory;
        }
        public void OnGet(int id)
        {
            MovieId = _movieRepozitory.GetById(id);
        }
    }
}
