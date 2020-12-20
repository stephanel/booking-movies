using BookingMovies.Core.Domain.Entities;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookingMovies.Infrastructure.Repositories
{
    internal class FakeMovieDatabase
    {
        public async Task<List<Movie>> GetAllMovies()
        {
            var currentNamespace = this.GetType().Namespace;

            using (var stream = this.GetType()
                .Assembly
                .GetManifestResourceStream($"{currentNamespace}.movies.json"))
            {
                return await JsonSerializer.DeserializeAsync<List<Movie>>(stream);
            }
        }
    }
}
