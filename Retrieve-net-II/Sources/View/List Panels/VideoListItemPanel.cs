using System;
using System.Windows.Forms;
using Retrieve_net_II.Sources.Model;
using Retrieve_net_II.Sources.View.Forms;
using Retrieve_net_II.Sources.Data.Networking;

namespace Retrieve_net_II.Sources.View.List_Panels
{
    public partial class VideoListItemPanel : UserControl
    {
        protected VideoInfo currentResult;
        private FileDownloader.VideoCompletedDelegate context;

        public VideoListItemPanel()
        {
            InitializeComponent();
        }

        public void SetSearchResult(VideoInfo newResult)
        {
            currentResult = newResult;

            if (currentResult != null)
            {
                thumbnailPictureBox.Image = currentResult.thumbnailImage;
                titleLabel.Text = currentResult.title;
                authorLabel.Text = currentResult.author;
                idLabel.Text = currentResult.youtubeID;
            }
        }

        public void SetDownloadCompletionContext(FileDownloader.VideoCompletedDelegate context)
        {
            this.context = context;
        }

        public virtual void videoResultPanel_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SearchResultVideoOptionsForm optionsForm = new SearchResultVideoOptionsForm();
                optionsForm.SetSearchResult(currentResult);
                optionsForm.SetDownloadCompletionContext(context);
                optionsForm.ShowDialog();
            }
        }
    }
}
