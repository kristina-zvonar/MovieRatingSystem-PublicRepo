using MovieRatingSystem.Repository.Contracts;
using MovieRatingSystem.ServerServices.Contracts;
using MovieRatingSystem.ServerServices.Helpers.Extensions;
using MovieRatingSystem.Shared.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingSystem.ServerServices.Implementations
{
    public class UserService: IUserService
    {
        private readonly IRepositoryWrapper _repository;

        public UserService(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        public async Task<User> Authenticate(string username, string password)
        {
            var user = _repository.Users.FindBy(el => el.Username == username).FirstOrDefault();

            if (user == null)
            {
                return null;
            }

            bool verified = password.VerifyPassword(user.Password, user);
            if (!verified)
            {
                return null;
            }

            // Remove password
            user.Password = null;
            return user;
        }
    }
}
