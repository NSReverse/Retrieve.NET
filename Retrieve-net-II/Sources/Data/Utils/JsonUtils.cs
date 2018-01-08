using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Retrieve_net_II.R;
using Retrieve_net_II.Sources.Data.Networking;
using Retrieve_net_II.Sources.Model;
using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Retrieve_net_II.Sources.Data.Utils
{
    class JsonUtils
    {
        public async static Task<ArrayList> ParseSearchResultJSON(string json)
        {
            ArrayList resultList = new ArrayList();

            dynamic rootObject = JsonConvert.DeserializeObject(json);

            JArray items = rootObject.items;

            for (int i = 0; i < items.Count; i++)
            {
                VideoInfo currentResult = new VideoInfo();

                dynamic item = JsonConvert.DeserializeObject(items[i].ToString());

                string videoId = item.id.videoId;
                string videoTitle = item.snippet.title;
                string author = item.snippet.channelTitle;
                string youtubeURL = String.Format(Strings.youtubeFormatURL, item.id.videoId);
                string thumbURL = item.snippet.thumbnails.medium.url;

                if (ApplicationConfig.loggingEnabled)
                {
                    Log.D(Strings.Tags.JSON_UTILS, "===============================================================");
                    Log.D(Strings.Tags.JSON_UTILS, "Video ID      : " + videoId);
                    Log.D(Strings.Tags.JSON_UTILS, "Title         : " + videoTitle);
                    Log.D(Strings.Tags.JSON_UTILS, "Author        : " + author);
                    Log.D(Strings.Tags.JSON_UTILS, "YouTube URL   : " + youtubeURL);
                    Log.D(Strings.Tags.JSON_UTILS, "Thumbnail URL : " + thumbURL);
                }

                currentResult.youtubeID = videoId;
                currentResult.title = videoTitle;
                currentResult.author = author;
                currentResult.youtubeURL = youtubeURL;
                currentResult.thumbnailURL = thumbURL;

                Image thumbnailImage = await ImageDownloader.GetImage(thumbURL);

                currentResult.thumbnailImage = thumbnailImage;

                resultList.Add(currentResult);
            }

            return resultList;
        }
    }
}
