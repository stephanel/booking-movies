using BookingMovies.Core.Domain.Entities;
using BookingMovies.Core.Domain.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BookingMovies.Domain.UseCases.GetAllMovies
{
    public class GetAllMoviesUseCase : IRequestHandler<GetAllMoviesMessage, List<Movie>>
    {
        private readonly IMovieRepository movieRepository;

        public GetAllMoviesUseCase(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public async Task<List<Movie>> Handle(GetAllMoviesMessage request, CancellationToken cancellationToken)
        {
            return await movieRepository.GetAll();
        }
    }
}
