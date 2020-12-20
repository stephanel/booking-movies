using BookingMovies.Core.Domain.Entities;
using BookingMovies.Core.Domain.Repositories;
using BookingMovies.Domain.UseCases.GetMovieById;
using FizzWare.NBuilder;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BookingMovies.Domain.Tests.UseCases
{
    public class GetMovieByIdUseCaseTests
    {
        private readonly Mock<IMovieRepository> mockMovieRepository
            = new Mock<IMovieRepository>();

        [Fact]
        [Trait("Category", "UnitTests")]
        public async Task ShouldReturnAllMovies()
        {
            // Arrange
            int movieId = 12;

            var movies = Builder<Movie>
                .CreateNew()
                .With(x => x.Id = movieId)
                .Build();

            mockMovieRepository
                .Setup(repository => repository.GetById(movieId))
                .ReturnsAsync(movies);

            var sut = new GetMovieByIdUseCase(mockMovieRepository.Object);

            // act
            var results = await sut.Handle(new GetMovieByIdMessage(movieId), 
                new CancellationToken());

            // Assert
            Assert.NotNull(results);
            Assert.Equal(movieId, results.Id);
        }
    }
}
