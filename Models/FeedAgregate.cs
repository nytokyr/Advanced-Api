using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advanced_Api.Models
{
    public partial class FeedAgregate
    {
        public Feed[] Feeds { get; set; }
        public int TotalFeed { get; set; }

    }
}
