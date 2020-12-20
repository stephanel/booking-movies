using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingMovies.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static bool IsIn(this string searchText, string target)
        {
            if(target == null)
            {
                return false;
            }

            if(string.IsNullOrWhiteSpace(searchText))
            {
                return true;
            }

            return target.ToLower().Contains(searchText?.ToLower());
        }
    }
}
