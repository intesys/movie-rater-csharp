using MovieRaterWebApp.Models;

namespace MovieRaterWebApp.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly ILogger<MoviesService> _logger;

        public MoviesService(ILogger<MoviesService> logger)
        {
            _logger = logger;
        }

        public async Task<Tuple<Movie, Movie>> Get2RandomMovies()
        {
            return new Tuple<Movie, Movie>(
                new Movie { Id = 8, Title = "Pulp Fiction", Year = 1994, Genre = "Crime, Drama", Director = "Quentin Tarantino", Actors = "Tim Roth, Amanda Plummer, Laura Lovelace, John Travolta", Country = "USA" },
                new Movie { Id = 11, Title = "Forrest Gump", Year = 1994, Genre = "Comedy, Drama, Romance", Director = "Robert Zemeckis", Actors = "Tom Hanks, Rebecca Williams, Sally Field, Michael Conner Humphreys", Country = "USA" }
            );
        }

        public async Task<int> GetMovieCount()
        {
            return 0;
        }

        public async Task Vote(int movieId)
        {
            _logger.LogInformation("Add vote for movie {movieId}", movieId);
        }
    }
}
