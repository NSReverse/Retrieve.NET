using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Retrieve_net_II.Sources.Data.Networking
{
    class ImageDownloader
    {
        public static async Task<Image> GetImage(String url)
        {
            HttpClient client = new HttpClient();

            Stream streamTask = await client.GetStreamAsync(url);
            Image image = Image.FromStream(streamTask);

            return image;
        }
    }
}
