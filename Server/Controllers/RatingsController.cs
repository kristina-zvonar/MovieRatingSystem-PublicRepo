using MovieRatingSystem.Shared;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MovieRatingSystem.Shared.DB;
using MovieRatingSystem.Repository.Contracts;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MovieRatingSystem.Shared.View;
using MovieRatingSystem.Shared.Enum;
using System.Linq.Expressions;
using System;
using MovieRatingSystem.ServerServices.Contracts;
using Microsoft.AspNetCore.Http;
using System.Net;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using MovieRatingSystem.Server.Helpers.Util;

namespace MovieRatingSystem.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private ILogger<RatingsController> _logger;
        private IRatingDataService _ratingService;

        public RatingsController(IRatingDataService ratingService, ILogger<RatingsController> logger)
        {
            _ratingService = ratingService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IList<RatingViewModel>> Get(int type, string user)
        {
            if(!Enum.IsDefined(typeof(ContentTypeEnum), type) || string.IsNullOrWhiteSpace(user))
            {
                return new List<RatingViewModel>();
            }

            try
            {
                var result = await _ratingService.GetRatings(type, user);
                return result;
            }
            catch(Exception exception)
            {
                _logger.LogError(exception.Message);
                throw new Exception(ErrorMessage.ERROR_LOADING_RATINGS);
            }
        }

        [HttpPut]
        public async Task<HttpResponseMessage> Put([FromBody]RatingViewModel requestModel)
        {
            if(requestModel == null || requestModel.ID == 0 || requestModel.MyRating < 1 || requestModel.MyRating > 5)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }

            try
            {
                bool success = await _ratingService.InsertUpdateRating(requestModel.ID, requestModel.MyRating, requestModel.Username);
                if (success)
                {
                    return new HttpResponseMessage(HttpStatusCode.OK);
                }

                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            catch(Exception exception)
            {
                _logger.LogError(exception.Message);
                throw new Exception(ErrorMessage.ERROR_SAVING_RATINGS);
            }
        } 
    }
}