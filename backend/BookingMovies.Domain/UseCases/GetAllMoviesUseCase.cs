using BookingMovies.Core.Domain.Entities;
using BookingMovies.Core.Domain.Interfaces;
using System.Collections.Generic;

namespace BookingMovies.Domain.UseCases
{
    public class GetAllMoviesUseCase
    {
        private readonly IMovieRepository movieRepository;

        public GetAllMoviesUseCase(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public List<Movie> Execute()
        {
            return movieRepository.GetAll();
        }
    }
}
