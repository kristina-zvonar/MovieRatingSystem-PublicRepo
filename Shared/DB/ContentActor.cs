using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingSystem.Shared.DB
{
    public class ContentActor
    {
        public int ActorID { get; set; }
        public Actor Actor { get; set; }

        public int ContentID { get; set; }
        public Content Content { get; set; }
    }
}
