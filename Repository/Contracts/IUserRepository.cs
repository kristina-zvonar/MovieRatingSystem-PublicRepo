using MovieRatingSystem.Shared.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingSystem.Repository.Contracts
{
    public interface IUserRepository: IRepositoryBase<User>
    {
    }
}
