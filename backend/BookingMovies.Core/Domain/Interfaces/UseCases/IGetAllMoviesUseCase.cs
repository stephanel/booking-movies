using BookingMovies.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingMovies.Core.Domain.Interfaces.UseCases
{
    public interface IGetAllMoviesUseCase
    {
        Task<List<Movie>> Execute();
    }
}
