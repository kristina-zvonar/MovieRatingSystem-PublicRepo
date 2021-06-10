using MovieRatingSystem.Repository.Contracts;
using MovieRatingSystem.Repository.DB;
using MovieRatingSystem.Shared.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingSystem.Repository.MySQL
{
    public class UserRepository: RepositoryBase<User, ApplicationDBContext>, IUserRepository
    {
        public UserRepository(ApplicationDBContext context) : base(context)
        {

        }
    }
}
