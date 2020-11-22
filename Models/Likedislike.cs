namespace Advanced_Api.Models
{
    public partial class FeedAgregate
    {
        public class Likedislike
        {
            public int Likes { get; set; }
            public int Dislikes { get; set; }
            public int UserAction { get; set; }
        }

    }
}
