using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApi.Model
{
    public class Video
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public Uri ThumbnailUri { get; set; }
        public MyToolkit.Multimedia.YouTube.YouTubeUri VideoUri { get; set; }
        public DateTime? PubDate { get; set; }
    }
}
