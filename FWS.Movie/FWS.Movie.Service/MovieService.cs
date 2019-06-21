using FWS.Movie.DTO;
using FWS.Movie.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FWS.Movie.Service
{
    public class MovieService : IMovieService
    {
        private List<MovieDTO> Movies;
        private List<UserMovieRateDTO> UseMovieRate;
        public MovieService()
        {
            this.Movies = this.GetDefaultMovies();
            this.UseMovieRate = this.GetDefaultUserMovieRating();
        }

        private List<UserMovieRateDTO> GetDefaultUserMovieRating()
        {
            var userRating = new List<UserMovieRateDTO>();
            userRating.Add(new UserMovieRateDTO() { MovieId = 1, UserId = 1, Rate = 4, Movie = this.Movies[0] });
            userRating.Add(new UserMovieRateDTO() { MovieId = 1, UserId = 2, Rate = 2, Movie = this.Movies[0] });
            userRating.Add(new UserMovieRateDTO() { MovieId = 2, UserId = 1, Rate = 3, Movie = this.Movies[1] });
            userRating.Add(new UserMovieRateDTO() { MovieId = 2, UserId = 2, Rate = 4, Movie = this.Movies[1] });
            userRating.Add(new UserMovieRateDTO() { MovieId = 3, UserId = 1, Rate = 2.5, Movie = this.Movies[2] });
            userRating.Add(new UserMovieRateDTO() { MovieId = 3, UserId = 2, Rate = 3.5, Movie = this.Movies[2] });
            userRating.Add(new UserMovieRateDTO() { MovieId = 4, UserId = 1, Rate = 4, Movie = this.Movies[3] });
            userRating.Add(new UserMovieRateDTO() { MovieId = 4, UserId = 2, Rate = 2, Movie = this.Movies[3] });
            userRating.Add(new UserMovieRateDTO() { MovieId = 5, UserId = 1, Rate = 3, Movie = this.Movies[4] });
            userRating.Add(new UserMovieRateDTO() { MovieId = 5, UserId = 2, Rate = 4, Movie = this.Movies[4] });

            return userRating;
        }

        private List<MovieDTO> GetDefaultMovies()
        {
            var movies = new List<MovieDTO>();
            movies.Add(new MovieDTO() { Id = 1, Title = "Movie 1", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 3.5 });
            movies.Add(new MovieDTO() { Id = 2, Title = "Movie 2", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 5 });
            movies.Add(new MovieDTO() { Id = 3, Title = "Movie 3", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 4 });
            movies.Add(new MovieDTO() { Id = 4, Title = "Movie 4", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 2.5 });
            movies.Add(new MovieDTO() { Id = 5, Title = "Movie 5", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 4.5 });
            return movies;
        }

        /// <summary>
        /// Get list of movies based on the param
        /// </summary>
        /// <param name="param">Filters</param>
        /// <returns>List of MovieDTO</returns>
        public List<MovieDTO> GetMovies(MovieFilterDTO param)
        {
            IEnumerable<MovieDTO> filterdMovies = this.Movies;
            if (!string.IsNullOrEmpty(param.Title))
            {
                filterdMovies = filterdMovies.Where(x => x.Title == param.Title);
            }
            if (!string.IsNullOrEmpty(param.Genres))
            {
                filterdMovies = filterdMovies.Where(x => x.Genres == param.Genres);
            }
            if(param.YearOfRelease != null)
            {
                filterdMovies = filterdMovies.Where(x => x.YearOfRelease == param.YearOfRelease);
            }

            return filterdMovies.OrderByDescending(x=>x.YearOfRelease).ToList();
        }

        /// <summary>
        /// Get top rated movies
        /// </summary>
        /// <param name="maxCount">Count of movies</param>
        /// <returns>List of movies</returns>
        public List<MovieDTO> GetTopRatedMovies(int maxCount)
        {
            return this.Movies.OrderByDescending(x => x.AverageRating).ThenBy(x => x.Title).Take(maxCount).ToList();
        }

        /// <summary>
        /// Get top rated movies for a given user
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="maxCount">Max count of the result</param>
        /// <returns>List of Movies in order</returns>
        public List<MovieDTO> GetUserTopRatedMovies(int userId, int maxCount)
        {
            return this.UseMovieRate.Where(x => x.UserId == userId).OrderByDescending(x => x.Rate).ThenBy(x => x.Movie.Title)
                .Take(maxCount)
                .Select(x=> x.Movie).ToList();
        }
    }
}
