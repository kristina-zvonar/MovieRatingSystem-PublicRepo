﻿using MovieRatingSystem.Repository.Contracts;
using MovieRatingSystem.Repository.DB;
using MovieRatingSystem.Shared.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingSystem.Repository.MySQL
{
    public class MovieRepository: RepositoryBase<Content, ApplicationDBContext>, IMovieRepository
    {
        public MovieRepository(ApplicationDBContext context) : base(context)
        {

        }
    }
}
