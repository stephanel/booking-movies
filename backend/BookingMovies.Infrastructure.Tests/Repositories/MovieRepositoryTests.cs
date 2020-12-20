using BookingMovies.Core.Domain.Entities;
using BookingMovies.Infrastructure.Extensions;
using BookingMovies.Infrastructure.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace BookingMovies.Infrastructure.Tests.Repositories
{
    public class MovieRepositoryTests
    {
        [Fact]
        [Trait("Category", "IntegrationTests")]
        public async Task ShouldQueryAllMovies()
        {
            // Arrange
            var sut = new MovieRepository();

            // Act
            var results = await sut.GetAll();

            // Assert
            Assert.Equal(5, results.Count);
            Assert.Equal("The Shawshank Redemption", results[0].Title);
            Assert.Equal("Almost Famous", results[1].Title);
            Assert.Equal("Love Actually", results[2].Title);
            Assert.Equal("Le fabuleux destin d'Amélie Poulain", results[3].Title);
            Assert.Equal("Il buono, il brutto, il cattivo. Super", results[4].Title);
        }

        [Fact]
        [Trait("Category", "IntegrationTests")]
        public async Task ShouldQueryAMoviesByItsId()
        {
            // Arrange
            var id = 1;

            var sut = new MovieRepository();

            // Act
            var results = await sut.GetById(id);

            // Assert
            Assert.NotNull(results);
            Assert.Equal(id, results.Id);
            Assert.Equal("The Shawshank Redemption", results.Title);
        }


        [Fact]
        [Trait("Category", "IntegrationTests")]
        public async Task ShouldSearchForMoviesByQuery()
        {
            // Arrange
            var sut = new MovieRepository();

            var query = "super";

            // Act
            var results = await sut.Search(query);

            // Assert
            Assert.NotNull(results);
            Assert.Equal(4, results.Count);
            // check we got the movie where language contains
            Assert.NotNull(results.Where(movie => query.IsIn(movie.Language)));
            Assert.NotNull(results.Where(movie => query.IsIn(movie.Location)));
            Assert.NotNull(results.Where(movie => query.IsIn(movie.Plot)));
            Assert.NotNull(results.Where(movie => query.IsIn(movie.Title)));
        }
    }
}
