using BookingMovies.Core.Domain.Entities;
using BookingMovies.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BookingMovies.Domain.UseCases.SearchForMovies
{
    public class SearchForMoviesUseCase : IRequestHandler<SearchForMoviesMessage, List<Movie>>
    {
        private readonly IMovieRepository movieRepository;

        public SearchForMoviesUseCase(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public async Task<List<Movie>> Handle(SearchForMoviesMessage request, CancellationToken cancellationToken)
        {
            return await movieRepository.Search(request.Query);
        }
    }
}
