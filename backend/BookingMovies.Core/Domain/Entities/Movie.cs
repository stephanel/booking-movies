using System.Collections.Generic;

namespace BookingMovies.Core.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string ListingType { get; set; }
        public string ImdbID { get; set; }
        public decimal ImdbRating { get; set; }
        public string Language { get; set; }
        public string Location { get; set; }
        public string Poster { get; set; }
        public string Plot { get; set; }
        public ICollection<string> SoundEffects { get; set; }
        public ICollection<string> Stills { get; set; }
        public string Title { get; set; }
    }
}
