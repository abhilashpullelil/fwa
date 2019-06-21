using System;

namespace FWS.Movie.DTO
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime YearOfRelease { get; set; }
        public long RunningTimeMinutes { get; set; }
        public string Genres { get; set; }
        public double AverageRating { get; set; }
    }
}
