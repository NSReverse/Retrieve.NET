using Retrieve_net_II.R;
using Retrieve_net_II.Sources.Data.Utils;
using Retrieve_net_II.Sources.View.Forms;
using System;
using System.Windows.Forms;

namespace Retrieve_net_II.Sources.View.List_Panels
{
    class DownloadedVideoListItemPanel : VideoListItemPanel
    {
        private DeleteVideoForm.Delegate context;

        public override void videoResultPanel_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                string videoLocation = String.Format(Strings.libraryFormatVideos + currentResult.youtubeID + ".mp4",
                PreferenceManager.GetLibraryLocation());

                VideoPlayerForm playerForm = new VideoPlayerForm();
                playerForm.SetVideoLocation(videoLocation);
                playerForm.ShowDialog();
            }
            else if (e.Button == MouseButtons.Right)
            {
                DeleteVideoForm deleteForm = new DeleteVideoForm();
                deleteForm.SetVideoId(currentResult.youtubeID);
                deleteForm.SetDelegate(context);
                deleteForm.ShowDialog();
            }
        }

        public void SetDeleteContext(DeleteVideoForm.Delegate context)
        {
            this.context = context;
        }
    }
}
