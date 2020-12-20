using BookingMovies.Core.Domain.Entities;
using BookingMovies.Core.Domain.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BookingMovies.Domain.UseCases.GetMovieById
{
    public class GetMovieByIdUseCase : IRequestHandler<GetMovieByIdMessage, Movie>
    {
        private readonly IMovieRepository movieRepository;

        public GetMovieByIdUseCase(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public async Task<Movie> Handle(GetMovieByIdMessage request, CancellationToken cancellationToken)
        {
            return await movieRepository.GetById(request.Id);
        }
    }
}
