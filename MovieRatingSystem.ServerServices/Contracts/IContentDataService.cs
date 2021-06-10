using MovieRatingSystem.Shared.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingSystem.ServerServices.Contracts
{
    public interface IContentDataService
    {
        Task<IList<ContentViewModel>> SearchContent(string searchTerm, int type);        
    }
}
