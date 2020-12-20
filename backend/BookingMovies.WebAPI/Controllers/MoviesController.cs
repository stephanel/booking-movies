using BookingMovies.Core.Domain.Entities;
using BookingMovies.Core.Domain.Interfaces.UseCases;
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
        private readonly IGetAllMoviesUseCase useCase;
        private readonly ILogger<MoviesController> logger;

        public MoviesController(IGetAllMoviesUseCase useCase, ILogger<MoviesController> logger)
        {
            this.useCase = useCase;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<List<Movie>> Get()
        {
            return await this.useCase.Execute();
        }
    }
}
