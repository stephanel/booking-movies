using BookingMovies.Core.Domain.Entities;
using MediatR;

namespace BookingMovies.Domain.UseCases.GetMovieById
{
    public class GetMovieByIdMessage : IRequest<Movie>
    {
        public int Id { get; private set; }

        public GetMovieByIdMessage(int id)
        {
            Id = id;
        }
    }
}
