using Microsoft.AspNetCore.Identity;
using MovieRatingSystem.Shared.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingSystem.ServerServices.Helpers.Extensions
{
    public static class StringExtensions
    {
        private readonly static PasswordHasher<User> passwordHasher = new PasswordHasher<User>();

        public static bool VerifyPassword(this string password, string passwordHash, User user)
        {
            var result = passwordHasher.VerifyHashedPassword(user, passwordHash, password);

            bool verified = result == PasswordVerificationResult.Success || result == PasswordVerificationResult.SuccessRehashNeeded;
            return verified;
        }
    }
}
