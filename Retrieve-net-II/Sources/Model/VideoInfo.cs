using System;
using System.Drawing;
using System.Xml.Serialization;

namespace Retrieve_net_II.Sources.Model
{
    public class VideoInfo
    {
        public string title;
        public string author;
        public string thumbnailURL;
        public string youtubeURL;
        public string youtubeID;
        [XmlIgnore] public Image thumbnailImage;

        public VideoInfo()
        {
            title = "";
            author = "";
            thumbnailURL = "";
            youtubeURL = "";
            youtubeID = "";
            thumbnailImage = null;
        }
    }
}
