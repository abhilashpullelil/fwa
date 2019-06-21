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

        public MovieDTO Movie { get; set; } // Foreign key to Movie -> It is not in DTO but in Entity
    }
}
