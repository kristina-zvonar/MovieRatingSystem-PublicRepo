using MovieRatingSystem.Shared.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingSystem.ServerServices.Contracts
{
    public interface IRatingDataService
    {
        Task<IList<RatingViewModel>> GetRatings(int type, string user);
        Task<bool> InsertUpdateRating(int contentID, int star, string user);
    }
}
