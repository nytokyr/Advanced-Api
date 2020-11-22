using Advanced_Api.Interfaces;
using Advanced_Api.Models;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.Text.Json;

namespace Advanced_Api.Data
{
    public class JSonDataSource : IDataSource
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public JSonDataSource(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IEnumerable<Feed> GetFeeds()
        {
            var webRoot = _hostingEnvironment.WebRootPath;
            var file = System.IO.Path.Combine(webRoot, "data-100.json");
            var json = System.IO.File.ReadAllText(file);
            var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            var feeds = JsonSerializer.Deserialize<FeedAgregate>(json, options);
            return feeds.Feeds;
        }
    }
}
