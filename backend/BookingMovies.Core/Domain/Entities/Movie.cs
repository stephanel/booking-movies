using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingMovies.Core.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Language { get; set; }
        public string Location { get; set; }
        public string Poster { get; set; }
        public string Plot { get; set; }
        public ICollection<Still> SoundEffects { get; set; }
        public ICollection<Still> Stills { get; set; }
    }
}
