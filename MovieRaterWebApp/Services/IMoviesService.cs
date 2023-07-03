using MovieRaterWebApp.Models;

namespace MovieRaterWebApp.Services
{
    public interface IMoviesService
    {
        Task<Tuple<Movie, Movie>> Get2RandomMovies();

        Task<int> GetMovieCount();

        Task Vote(int movieId);
    }
}
