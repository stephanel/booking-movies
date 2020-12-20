using BookingMovies.Core.Domain.Entities;
using BookingMovies.Core.Domain.Interfaces;
using BookingMovies.Domain.UseCases;
using FizzWare.NBuilder;
using Moq;
using System;
using System.Linq;
using Xunit;

namespace BookingMovies.Domain.Tests.UseCases
{
    public class GetAllMoviesUseCaseTests
    {
        private readonly Mock<IMovieRepository> mockMovieRepository = new Mock<IMovieRepository>();

        [Fact]
        public void ShouldReturnAllMovies()
        {
            // Arrange
            int id = 1;
            var movies = Builder<Movie>
                .CreateListOfSize(3)
                .All()
                .With(x => x.Id = id++)
                .Build()
                .ToList();

            mockMovieRepository
                .Setup(repository => repository.GetAll())
                .Returns(movies);

            var sut = new GetAllMoviesUseCase(mockMovieRepository.Object);

            // act
            var results = sut.Execute();

            // Assert
            Assert.Equal(3, results.Count);
        }
    }
}
