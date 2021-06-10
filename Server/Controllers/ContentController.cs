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
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using MovieRatingSystem.Server.Helpers.Util;

namespace MovieRatingSystem.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ContentController : ControllerBase
    {
        private ILogger<ContentController> _logger;
        private IContentDataService _contentService;

        public ContentController(IContentDataService contentService, ILogger<ContentController> logger)
        {
            _contentService = contentService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IList<ContentViewModel>> Get(string searchTerm = "", int type = (int)ContentTypeEnum.MOVIE)
        {
            try
            {                
                var result = await _contentService.SearchContent(searchTerm, type);
                return result;
            }
            catch(Exception exception)
            {
                _logger.LogError(exception.Message);
                throw new Exception(ErrorMessage.ERROR_LOADING_CONTENT);
            }
        }

    }
}