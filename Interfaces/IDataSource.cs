using Advanced_Api.Models;
using System.Collections.Generic;

namespace Advanced_Api.Interfaces
{
    public interface IDataSource
    {
        IEnumerable<Feed> GetFeeds();
    }
}
