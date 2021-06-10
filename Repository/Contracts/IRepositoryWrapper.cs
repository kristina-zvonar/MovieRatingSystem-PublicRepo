using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingSystem.Repository.Contracts
{
    public interface IRepositoryWrapper
    {
        IActorRepository Actors { get; }
        IMovieRepository Movies { get; }        
        IRatingRepository Ratings { get; }
        IUserRepository Users { get; }

        void Save();
        Task SaveAsync();
    }
}
