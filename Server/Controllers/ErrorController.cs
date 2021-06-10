using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingSystem.Server.Controllers
{

    [Route("/Error")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : ControllerBase
    {
        private ILogger _logger;

        public ErrorController(ILogger logger)
        {
            _logger = logger;
        }

        public void Index(int? code)
        {
            _logger.LogError($"Error occured, code {code}");
        }
    }
}
