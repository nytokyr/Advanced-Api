using System;

namespace Advanced_Api.Models
{
   
        public class Multimedia
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public object Description { get; set; }
            public string Url { get; set; }
            public int Mediatype { get; set; }
            public int LikeCount { get; set; }
            public object Place { get; set; }
            public DateTime CreateAt { get; set; }
        }

   
}
