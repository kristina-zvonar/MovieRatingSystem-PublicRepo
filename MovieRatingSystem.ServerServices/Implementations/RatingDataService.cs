using Microsoft.EntityFrameworkCore;
using MovieRatingSystem.Repository.Contracts;
using MovieRatingSystem.ServerServices.Contracts;
using MovieRatingSystem.Shared.DB;
using MovieRatingSystem.Shared.Enum;
using MovieRatingSystem.Shared.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MovieRatingSystem.ServerServices.Implementations
{
    public class RatingDataService : IRatingDataService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public RatingDataService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<IList<RatingViewModel>> GetRatings(int type, string user = "")
        {
            IList<Content> movies = await _repositoryWrapper.Movies.FindBy(el => el.Type == type)
                .Include(el => el.ContentActors)
                .ThenInclude(el => el.Actor)
                .Include(el => el.Ratings)
                .ToListAsync();

            IList<RatingViewModel> result = movies.Select(el => new RatingViewModel
            {
                ID = el.ID,
                Title = el.Title,                
                AverageRating = el.Ratings.Count > 0 ? Math.Round(el.Ratings.Sum(x => x.Star) / (decimal)el.Ratings.Count, 2) : 0,
                MyRating = el.Ratings.FirstOrDefault(x => x.User == user)?.Star ?? 0
            }).OrderByDescending(el => el.AverageRating).ToList();
            return result;
        }

        public async Task<bool> InsertUpdateRating(int contentID, int star, string user)
        {
            var rating = await _repositoryWrapper.Ratings.FindBy(el => el.ContentID == contentID && el.User == user).FirstOrDefaultAsync();
            if(rating == null)
            {
                rating = new ContentRating
                {
                    ContentID = contentID,
                    Star = star,
                    User = user
                };
                await _repositoryWrapper.Ratings.InsertAsync(rating);
            }
            else
            {
                rating.Star = star;
                await _repositoryWrapper.Ratings.UpdateAsync(rating);
            }
                        
            return true;
        }
                
    }
}
