using System;
using System.Collections.Generic;
using System.Text;
using FWS.Movie.DTO;

namespace FWS.Movie.Service.Interfaces
{
    public interface IMovieService
    {
        List<MovieDTO> GetMovies(MovieFilterDTO param);
    }
}
