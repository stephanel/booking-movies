using BookingMovies.Core.Domain.Entities;
using BookingMovies.Core.Domain.Interfaces.UseCases;
using BookingMovies.WebAPI.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace BookingMovies.WebAPI.Tests
{
    public class MoviesControllerTests
    {
        private readonly Mock<IGetAllMoviesUseCase> mockUseCase
            = new Mock<IGetAllMoviesUseCase>();

        private readonly Mock<ILogger<MoviesController>> mockLogger
            = new Mock<ILogger<MoviesController>>();

        [Fact]
        [Trait("Category", "UnitTests")]
        public async Task ShouldReturnAllMovies()
        {
            // Arrange
            mockUseCase.Setup(useCase => useCase.Execute())
                .ReturnsAsync(new List<Movie>() { new Movie() { Id = 1 } });

            var sut = new MoviesController(mockUseCase.Object, mockLogger.Object);

            // Act
            var results = await sut.Get();

            // Assert
            Assert.Single(results);
            Assert.Equal(1, results[0].Id);
        }
    }
}
