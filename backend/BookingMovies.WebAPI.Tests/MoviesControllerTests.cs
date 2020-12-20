using BookingMovies.Core.Domain.Entities;
using BookingMovies.WebAPI.Controllers;
using MediatR;
using Microsoft.Extensions.Logging;
using Moq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BookingMovies.WebAPI.Tests
{
    public class MoviesControllerTests
    {
        private readonly Mock<IMediator> mockMediator
            = new Mock<IMediator>();

        private readonly Mock<ILogger<MoviesController>> mockLogger
            = new Mock<ILogger<MoviesController>>();

        [Fact]
        [Trait("Category", "UnitTests")]
        public async Task ShouldReturnAllMovies()
        {
            // Arrange
            mockMediator.Setup(mediator 
                => mediator.Send(It.IsAny<IRequest<List<Movie>>>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new List<Movie>() { new Movie() { Id = 1 } });

            var sut = new MoviesController(mockMediator.Object, mockLogger.Object);

            // Act
            var results = await sut.Get();

            // Assert
            Assert.Single(results);
            Assert.Equal(1, results[0].Id);
        }
    }
}
