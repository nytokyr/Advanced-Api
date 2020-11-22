using System;

namespace Advanced_Api.Models
{
   
        public class Feed
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Location { get; set; }
            public int Lng { get; set; }
            public int Lat { get; set; }
            public int UserId { get; set; }
            public string Name { get; set; }
            public bool Isdeleted { get; set; }
            public string ProfilePicture { get; set; }
            public object VideoUrl { get; set; }
            public object Images { get; set; }
            public int Mediatype { get; set; }
            public object ImagePaths { get; set; }
            public object FeedsComment { get; set; }
            public int CommentCount { get; set; }
            public Multimedia[] MultiMedia { get; set; }
            public Likedislike LikeDislike { get; set; }
            public DateTime CreatedAt { get; set; }
            public int Code { get; set; }
            public object Msg { get; set; }
        }

   
}
