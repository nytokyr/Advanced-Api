using Advanced_Api.Interfaces;
using Advanced_Api.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Advanced_Api.Odata.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeedsController : ControllerBase
    {
        private readonly IDataSource _dataSource;

        public FeedsController(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        [HttpGet]
        [EnableQuery()]
        public IQueryable<Feed> Get()
        {
            return _dataSource.GetFeeds().AsQueryable();
        }
    }
}
