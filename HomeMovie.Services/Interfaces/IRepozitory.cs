using HomeMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMovie.Services.Interfaces
{
    public interface IRepozitory
    {
        List<Movie> GetAll();
        Movie GetById(int id);
    }
}
