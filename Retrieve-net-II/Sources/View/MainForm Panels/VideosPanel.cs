using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Retrieve_net_II.R;
using Retrieve_net_II.Sources.Data.Utils;
using Retrieve_net_II.Sources.Data.Networking;
using System.Web;
using System.Collections;
using System.IO;
using Retrieve_net_II.Sources.Model;
using Retrieve_net_II.Sources.View.List_Panels;
using Retrieve_net_II.Sources.View.Forms;

namespace Retrieve_net_II.Sources.View.Main_Panels
{
    public partial class VideosPanel : UserControl,
        SearchVideoInputForm.Delegate, 
        FileDownloader.VideoCompletedDelegate,
        DeleteVideoForm.Delegate
    {
        public VideosPanel()
        {
            InitializeComponent();

            videosTableLayoutPanel.ColumnCount = 1;
            videosTableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowOnly;
            videosTableLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            videosTableLayoutPanel.AutoScroll = true;

            ReloadDataSource();
        }

        private void ReloadDataSource()
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(() =>
                {
                    ReloadDataSource();
                }));
            }
            else
            {
                videosTableLayoutPanel.Controls.Clear();

                ArrayList dataList = new ArrayList();

                string directory = String.Format(Strings.libraryFormatMetadata, PreferenceManager.GetLibraryLocation());

                Directory.CreateDirectory(directory);       // Create directory if not exists

                string[] dataDirectory = Directory.GetFiles(directory);

                foreach (string filename in dataDirectory)
                {
                    VideoInfo currentInfo = XmlSerializer.Deserialize(filename);

                    DownloadedVideoListItemPanel currentPanel = new DownloadedVideoListItemPanel();
                    currentPanel.SetSearchResult(currentInfo);
                    currentPanel.SetDeleteContext(this);

                    videosTableLayoutPanel.Controls.Add(currentPanel);

                    currentPanel.Dock = DockStyle.Fill;
                }
            }
        }

        public void SearchCancelled()
        {
            throw new NotImplementedException();
        }

        public async Task SendSearchQueryAsync(string query)
        {
            int resultLimit = PreferenceManager.GetSearchResultLimit();

            string address = String.Format(Strings.formatSearchURL, query, resultLimit, Strings.youtubeDeveloperKey);
            string result = await StringDownloader.GetString(address);

            if (ApplicationConfig.loggingEnabled)
            {
                Log.D(Strings.Tags.MAIN_FORM, "Query  : " + query);
            }

            SearchResultForm resultForm = new SearchResultForm();
            resultForm.SetQuery(HttpUtility.UrlDecode(query));
            resultForm.SetResultJSON(result);
            resultForm.SetDownloadCompletionContext(this);
            resultForm.ShowDialog();
        }

        private void addVideosButton_Click(object sender, EventArgs e)
        {
            SearchVideoInputForm searchForm = new SearchVideoInputForm();
            searchForm.SetDelegate(this);
            searchForm.ShowDialog();
        }

        public void VideoDownloaded(VideoInfo videoInfo)
        {
            ReloadDataSource();
        }

        public void VideoDeleted(string videoId)
        {
            ReloadDataSource();
        }
    }
}
