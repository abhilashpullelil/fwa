using FWS.Movie.DTO;
using FWS.Movie.Service;
using FWS.Movie.Service.Interfaces;
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
        private IMovieService _movieService;

        public MovieController()
        {
            this._movieService = new MovieService(); // TO DO: change this object initialization to Dependency Injection
        }

        // POSt api/Movie/Get
        [HttpPost]
        [Route("Get")]
        public IHttpActionResult GetMovies(MovieFilterDTO param)
        {
            if (param == null || param.IsEmpty())
                return BadRequest(); // 400

            var movies = this._movieService.GetMovies(param);
            if (movies == null)
                return NotFound(); // 404
            
            return Ok(movies);
        }

        // GET api/Movie/GetTopRated
        [HttpGet]
        [Route("GetTopRated")]
        public IHttpActionResult GetTopMovies()
        {
            var movies = this._movieService.GetTopRatedMovies(5);
            if (movies == null || movies.Count < 1)
                return NotFound(); // 404
            return Ok(movies);
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
