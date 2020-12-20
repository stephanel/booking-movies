using BookingMovies.Core.Domain.Entities;
using BookingMovies.Core.Domain.Repositories;
using BookingMovies.Infrastructure.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingMovies.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly List<Movie> movies;

        public MovieRepository()
        {
            var task = Task.Run(()=> new FakeMovieDatabase().GetAllMovies());
            task.Wait();
            movies = task.Result;
        }

        public async Task<List<Movie>> GetAll()
        {
            return await Task.FromResult(movies);
        }

        public async Task<Movie> GetById(int id)
        {
            var movie = movies.Single(movie => movie.Id == id);
            return await Task.FromResult(movie);
        }

        public async Task<List<Movie>> Search(string searchedText)
        {
            var results = movies
                .Where(movie =>
                    searchedText.IsIn(movie.Language)
                    || searchedText.IsIn(movie.Location)
                    || searchedText.IsIn(movie.Plot)
                    || searchedText.IsIn(movie.Title)
                )
                .ToList();

            return await Task.FromResult(results);
        }

    }
}
