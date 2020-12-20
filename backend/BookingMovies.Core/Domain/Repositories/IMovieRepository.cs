using BookingMovies.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingMovies.Core.Domain.Repositories
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAll();
        Task<Movie> GetById(int id);
        Task<List<Movie>> Search(string searchedText);
    }
}
