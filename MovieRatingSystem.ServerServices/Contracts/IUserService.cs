using MovieRatingSystem.Shared.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingSystem.ServerServices.Contracts
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
    }
}
