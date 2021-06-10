using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingSystem.Shared.DB
{
    public class ContentRating
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int ContentID { get; set; }

        [Required]
        public int Star { get; set; }

        public string User { get; set; }

        public Content Content { get; set; }
    }
}
