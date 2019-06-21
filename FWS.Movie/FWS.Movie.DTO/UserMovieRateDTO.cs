using System;
using System.Collections.Generic;
using System.Text;

namespace FWS.Movie.DTO
{
    public class UserMovieRateDTO
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public double Rate { get; set; } // 1 to 5
    }
}
