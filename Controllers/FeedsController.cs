using Advanced_Api.Interfaces;
using Advanced_Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advanced_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeedsController : ControllerBase
    {
        private readonly ILogger<FeedsController> _logger;
        private readonly IDataSource _dataSource;

        public FeedsController(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }       

        [HttpGet]
        public IEnumerable<Feed> Get()
        {
            return _dataSource.GetFeeds();
        }
    }
}
