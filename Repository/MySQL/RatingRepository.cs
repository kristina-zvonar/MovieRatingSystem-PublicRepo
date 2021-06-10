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
    public class RatingRepository: RepositoryBase<ContentRating, ApplicationDBContext>, IRatingRepository
    {
        public RatingRepository(ApplicationDBContext context) : base(context)
        {

        }
    }
}
