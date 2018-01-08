using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Retrieve_net_II.Sources.Data.Networking
{
    class StringDownloader
    {
        public static async Task<string> GetString(String url)
        {
            HttpClient client = new HttpClient();
            Task<string> downloadStringTask = client.GetStringAsync(url);

            return await downloadStringTask;
        }
    }
}
