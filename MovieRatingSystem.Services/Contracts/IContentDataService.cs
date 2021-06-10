using MovieRatingSystem.Shared.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingSystem.Services.Contracts
{
    public interface IContentDataService
    {
        Task<IEnumerable<ContentViewModel>> GetContent(string searchTerm, int type);
        Task<IEnumerable<RatingViewModel>> GetRatings(int type, string user);
        Task<bool> UpdateRating(RatingViewModel content);
    }
}
