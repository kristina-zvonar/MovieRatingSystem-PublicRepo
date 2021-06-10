using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingSystem.Shared.DB
{
    public class Content
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string CoverImage { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public int Type { get; set; }

        [Required]
        public ICollection<ContentActor> ContentActors { get; set; }      
        public ICollection<ContentRating> Ratings { get; set; }

        public Content()
        {
            ContentActors = new HashSet<ContentActor>();
            Ratings = new HashSet<ContentRating>();
        }
    }
}
