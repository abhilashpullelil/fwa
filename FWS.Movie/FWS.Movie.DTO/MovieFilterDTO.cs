using System;
using System.Collections.Generic;
using System.Text;

namespace FWS.Movie.DTO
{
    public class MovieFilterDTO
    {
        public string Title { get; set; }
        public DateTime? YearOfRelease { get; set; }
        public string Genres { get; set; }
    }
}
