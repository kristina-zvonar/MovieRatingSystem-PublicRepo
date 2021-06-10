using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingSystem.Server.Helpers.Util
{
    public static class ErrorMessage
    {
        public static readonly string MISSING_HEADER = "Missing Authorization Header";
        public static readonly string INVALID_HEADER = "Invalid Authorization Header";
        public static readonly string INVALID_CREDENTIALS = "Invalid Username or Password";
        public static readonly string ERROR_LOADING_CONTENT = "There was an error loading movies/TV shows.";
        public static readonly string ERROR_LOADING_RATINGS = "There was an error loading data";
        public static readonly string ERROR_SAVING_RATINGS = "There was an error saving a rating.";
    }
}
