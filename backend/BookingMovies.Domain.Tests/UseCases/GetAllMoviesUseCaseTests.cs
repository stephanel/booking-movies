using BookingMovies.Core.Domain.Entities;
using BookingMovies.Core.Domain.Repositories;
using BookingMovies.Domain.UseCases.GetAllMovies;
using FizzWare.NBuilder;
using Moq;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BookingMovies.Domain.Tests.UseCases
{
    public class GetAllMoviesUseCaseTests
    {
        private readonly Mock<IMovieRepository> mockMovieRepository 
            = new Mock<IMovieRepository>();

        [Fact]
        [Trait("Category", "UnitTests")]
        public async Task ShouldReturnAllMovies()
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
                .ReturnsAsync(movies);

            var sut = new GetAllMoviesUseCase(mockMovieRepository.Object);

            // act
            var results = await sut.Handle(new GetAllMoviesMessage(), new CancellationToken());

            // Assert
            Assert.Equal(3, results.Count);
        }
    }
}
