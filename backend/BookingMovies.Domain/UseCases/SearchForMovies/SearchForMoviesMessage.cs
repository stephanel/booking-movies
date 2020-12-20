using BookingMovies.Core.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace BookingMovies.Domain.UseCases.SearchForMovies
{
    public class SearchForMoviesMessage : IRequest<List<Movie>>
    {
        public string Query { get; }

        public SearchForMoviesMessage(string query)
        {
            Query = query;
        }
    }
}
