using BookingMovies.Core.Domain.Entities;
using System.Collections.Generic;

namespace BookingMovies.Core.Domain.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
    }
}
