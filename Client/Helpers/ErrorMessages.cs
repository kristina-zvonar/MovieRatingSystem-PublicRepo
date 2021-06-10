using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingSystem.Client.Helpers
{
    public static class ErrorMessages
    {
        public static readonly string  RATING_NOT_UPDATED = "An error occurred updating the rating.";
        public static readonly string  WRONG_PARAMETER = "Wrong value for update";
        public static readonly string  RATING_ZERO = "Rating cannot be zero";
    }
}
