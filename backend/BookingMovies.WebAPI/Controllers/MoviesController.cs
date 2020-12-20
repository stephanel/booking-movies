using BookingMovies.Core.Domain.Entities;
using BookingMovies.Domain.UseCases.GetAllMovies;
using BookingMovies.Domain.UseCases.GetMovieById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingMovies.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly ILogger<MoviesController> logger;

        public MoviesController(IMediator mediator, ILogger<MoviesController> logger)
        {
            this.mediator = mediator;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<List<Movie>> Get()
        {
            logger.LogTrace("All movies requested!");
            return await this.mediator.Send(new GetAllMoviesMessage());
        }

        [HttpGet("{id}")]
        public async Task<Movie> GetById(int id)
        {
            logger.LogTrace($"Movie requested by ID={id}.");
            return await this.mediator.Send(new GetMovieByIdMessage(id));
        }
    }
}
