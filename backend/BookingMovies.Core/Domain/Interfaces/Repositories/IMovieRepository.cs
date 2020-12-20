﻿using BookingMovies.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingMovies.Core.Domain.Interfaces.Repositories
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAll();
    }
}