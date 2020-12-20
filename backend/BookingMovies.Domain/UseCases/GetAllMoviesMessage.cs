﻿using BookingMovies.Core.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace BookingMovies.Domain.UseCases
{
    public class GetAllMoviesMessage : IRequest<List<Movie>>
    {
    }
}
