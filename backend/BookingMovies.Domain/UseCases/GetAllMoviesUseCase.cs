using BookingMovies.Core.Domain.Entities;
using BookingMovies.Core.Domain.Interfaces.Repositories;
using BookingMovies.Core.Domain.Interfaces.UseCases;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingMovies.Domain.UseCases
{
    public class GetAllMoviesUseCase : IGetAllMoviesUseCase
    {
        private readonly IMovieRepository movieRepository;

        public GetAllMoviesUseCase(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public async Task<List<Movie>> Execute()
        {
            return await movieRepository.GetAll();
        }
    }
}
