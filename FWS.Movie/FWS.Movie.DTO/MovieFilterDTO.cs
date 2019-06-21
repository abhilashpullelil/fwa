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

        /// <summary>
        /// Check whether the model is valid or not
        /// </summary>
        /// <returns> True if invalid/ empty </returns>
        public bool IsEmpty()
        {
            if( string.IsNullOrEmpty(this.Title) || string.IsNullOrEmpty(this.Genres) || this.YearOfRelease == null)
            {
                return true;
            }
            return false;
        }
    }
}
