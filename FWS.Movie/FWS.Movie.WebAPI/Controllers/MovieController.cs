using FWS.Movie.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FWS.Movie.WebAPI.Controllers
{
    [RoutePrefix("api/Movie")]
    public class MovieController : ApiController
    {

        // GET api/Movie/Get
        [HttpPost]
        [Route("Get")]
        public IEnumerable<MovieDTO> GetMovies(MovieFilterDTO param)
        {
            var movies = new List<MovieDTO>();
            movies.Add(new MovieDTO() { Id = 1, Title = "Movie 1", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 3.5 });
            movies.Add(new MovieDTO() { Id = 2, Title = "Movie 2", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 5 });
            movies.Add(new MovieDTO() { Id = 3, Title = "Movie 3", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 4 });
            movies.Add(new MovieDTO() { Id = 4, Title = "Movie 4", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 2.5 });
            movies.Add(new MovieDTO() { Id = 5, Title = "Movie 5", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 4.5 });
            return movies;
        }

        [HttpGet]
        [Route("GetTop")]
        public IEnumerable<MovieDTO> GetTopMovies()
        {
            var movies = new List<MovieDTO>();
            movies.Add(new MovieDTO() { Id = 1, Title = "Movie 1", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 3.5 });
            movies.Add(new MovieDTO() { Id = 2, Title = "Movie 2", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 5 });
            movies.Add(new MovieDTO() { Id = 3, Title = "Movie 3", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 4 });
            movies.Add(new MovieDTO() { Id = 4, Title = "Movie 4", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 2.5 });
            movies.Add(new MovieDTO() { Id = 5, Title = "Movie 5", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 4.5 });
            return movies;
        }

        [HttpGet]
        [Route("GetMyTop")]
        public IEnumerable<MovieDTO> GetMyTopMovies(int user)
        {
            var movies = new List<MovieDTO>();
            movies.Add(new MovieDTO() { Id = 1, Title = "Movie 1", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 3.5 });
            movies.Add(new MovieDTO() { Id = 2, Title = "Movie 2", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 5 });
            movies.Add(new MovieDTO() { Id = 3, Title = "Movie 3", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 4 });
            movies.Add(new MovieDTO() { Id = 4, Title = "Movie 4", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 2.5 });
            movies.Add(new MovieDTO() { Id = 5, Title = "Movie 5", YearOfRelease = DateTime.Now.AddDays(-200), Genres = "Action", RunningTimeMinutes = 120, AverageRating = 4.5 });
            return movies;
        }

        //// GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
