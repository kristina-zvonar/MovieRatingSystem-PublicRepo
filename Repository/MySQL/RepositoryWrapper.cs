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
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDBContext _context;
        private IActorRepository _actors;
        private IMovieRepository _movies;
        private IRatingRepository _ratings;
        private IUserRepository _users;

        public IActorRepository Actors
        {
            get
            {
                if (_actors == null)
                {
                    _actors = new ActorRepository(_context);
                }
                return _actors;
            }
        }

        public IMovieRepository Movies
        {
            get
            {
                if (_movies == null)
                {
                    _movies = new MovieRepository(_context);
                }
                return _movies;
            }
        }

        public IRatingRepository Ratings
        {
            get
            {
                if(_ratings == null)
                {
                    _ratings = new RatingRepository(_context);
                }
                return _ratings;
            }
        }

        public IUserRepository Users
        {
            get
            {
                if(_users == null)
                {
                    _users = new UserRepository(_context);
                }
                return _users;
            }
        }

        public RepositoryWrapper(ApplicationDBContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
