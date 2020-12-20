using BookingMovies.Core.Domain.Entities;
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
            Assert.Equal("Il buono, il brutto, il cattivo", results[4].Title);

        }
    }
}
