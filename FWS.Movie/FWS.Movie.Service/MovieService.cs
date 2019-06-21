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
        public MovieService()
        {
            this.Movies = new List<MovieDTO>();
            this.Movies.Add(new MovieDTO() { Id = 1, Title = "Movie 1", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 3.5 });
            this.Movies.Add(new MovieDTO() { Id = 2, Title = "Movie 2", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 5 });
            this.Movies.Add(new MovieDTO() { Id = 3, Title = "Movie 3", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 4 });
            this.Movies.Add(new MovieDTO() { Id = 4, Title = "Movie 4", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 2.5 });
            this.Movies.Add(new MovieDTO() { Id = 5, Title = "Movie 5", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 4.5 });
        }

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

            return filterdMovies.ToList();
        }
    }
}
