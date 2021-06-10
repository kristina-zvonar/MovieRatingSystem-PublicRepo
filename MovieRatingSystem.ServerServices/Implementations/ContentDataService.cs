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
    public class ContentDataService : IContentDataService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public ContentDataService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<IList<RatingViewModel>> GetSimpleContent(int type, string user = "")
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

        public async Task<IList<ContentViewModel>> SearchContent(string searchTerm = "", int type = (int)ContentTypeEnum.MOVIE)
        {
            Func<ContentViewModel, bool> searchExpression;
            string starPattern = @"((at least|more than|less than) )?\d{1} (star|stars)";
            Regex starRegex = new Regex(starPattern);

            string yearPattern = @"(after|in|before) \d{4}";
            Regex yearRegex = new Regex(yearPattern);

            string agePattern = @"(((older|younger) than))? \d{1,} year(s)?";
            Regex ageRegex = new Regex(agePattern);

            if(string.IsNullOrWhiteSpace(searchTerm))
            {
                searchExpression = el => true;
            }
            else if (starRegex.IsMatch(searchTerm))
            {
                string numberPattern = @"\d{1}";
                Regex numberRegex = new Regex(numberPattern);
                int.TryParse(numberRegex.Match(searchTerm).Value, out int numberOfStars);
                if(searchTerm.StartsWith(StarRegexEnum.AT_LEAST))
                {
                    searchExpression = el => el.AverageRating >= numberOfStars;
                }
                else if(searchTerm.StartsWith(StarRegexEnum.MORE_THAN))
                {
                    searchExpression = el => el.AverageRating > numberOfStars;
                }
                else if(searchTerm.StartsWith(StarRegexEnum.LESS_THAN))
                {
                    searchExpression = el => el.AverageRating < numberOfStars;
                }
                else
                {
                    searchExpression = el => el.AverageRating == (decimal)numberOfStars;
                }
            }
            else if(yearRegex.IsMatch(searchTerm)) 
            {
                string numberPattern = @"\d{4}";
                Regex numberRegex = new Regex(numberPattern);
                int.TryParse(numberRegex.Match(searchTerm).Value, out int yearOfRelease);
                if (searchTerm.StartsWith(YearRegexEnum.BEFORE))
                {
                    searchExpression = el => el.ReleaseDate.Year < yearOfRelease;
                }
                else if (searchTerm.StartsWith(YearRegexEnum.IN))
                {
                    searchExpression = el => el.ReleaseDate.Year == yearOfRelease;
                }
                else if (searchTerm.StartsWith(YearRegexEnum.AFTER))
                {
                    searchExpression = el => el.ReleaseDate.Year > yearOfRelease;
                }
                else
                {
                    searchExpression = el => true;
                }
            }
            else if(ageRegex.IsMatch(searchTerm))
            {
                string numberPattern = @"\d{1,}";
                Regex numberRegex = new Regex(numberPattern);
                int.TryParse(numberRegex.Match(searchTerm).Value, out int contentAge);
                DateTime yearOfRelease = new DateTime(DateTime.Today.AddYears(-contentAge).Year, 1, 1);
                if (searchTerm.StartsWith(AgeRegexEnum.OLDER_THAN))
                {
                    searchExpression = el => el.ReleaseDate < yearOfRelease;
                }
                else if (searchTerm.StartsWith(AgeRegexEnum.YOUNGER_THAN))
                {
                    searchExpression = el => el.ReleaseDate < yearOfRelease;
                }                
                else
                {
                    searchExpression = el => true;
                }
            }
            else
            {
                searchExpression = el => el.Title.ToLower().Contains(searchTerm) 
                        || el.Description.ToLower().Contains(searchTerm) 
                        || el.Cast.ToLower().Contains(searchTerm);
            }
                        
            IList<Content> movies = await _repositoryWrapper.Movies.FindBy(el => el.Type == type)
                .Include(el => el.ContentActors)
                .ThenInclude(el => el.Actor)
                .Include(el => el.Ratings)
                .ToListAsync();

            IList<ContentViewModel> result = movies.Select(el => new ContentViewModel
            {
                ID = el.ID,
                Title = el.Title,
                Description = el.Description,
                CoverImage = el.CoverImage,
                ReleaseDate = el.ReleaseDate,
                Cast = string.Join(',', el.ContentActors.Select(x => x.Actor.FirstName + " " + x.Actor.LastName)),
                AverageRating = el.Ratings.Count > 0 ? Math.Round(el.Ratings.Sum(x => x.Star) / (decimal)el.Ratings.Count, 2) : 0
            }).Where(searchExpression).OrderByDescending(el => el.AverageRating).ToList();
            return result;
        }
    }
}
