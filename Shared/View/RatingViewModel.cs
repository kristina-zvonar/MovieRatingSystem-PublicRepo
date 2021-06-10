using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingSystem.Shared.View
{
    public class RatingViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }        
        public decimal AverageRating { get; set; }
        public int MyRating { get; set; }
        public string Username { get; set; }
    }
}
