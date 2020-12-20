using BookingMovies.Core.Domain.Entities;
using BookingMovies.Core.Domain.Repositories;
using BookingMovies.Domain.UseCases.SearchForMovies;
using FizzWare.NBuilder;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BookingMovies.Domain.Tests.UseCases
{
    public class SearchForMoviesUseCaseTests
    {
        private readonly Mock<IMovieRepository> mockMovieRepository
           = new Mock<IMovieRepository>();

        [Fact]
        [Trait("Category", "UnitTests")]
        public async Task ShouldReturnMoviesThatMatchInputQuery()
        {
            // Arrange
            mockMovieRepository
                .Setup(repository => repository.Search(It.IsAny<string>()))
                .ReturnsAsync(new List<Movie>() { new Movie() });

            var sut = new SearchForMoviesUseCase(mockMovieRepository.Object);

            var query = "super movie";

            // act

            var results = await sut.Handle(new SearchForMoviesMessage(query), new CancellationToken());

            // Assert
            Assert.Single(results);
        }
    }
}
