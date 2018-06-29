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

        public DownloadedVideoListItemPanel() : base()
        {
            addPlaylistPictureBox.Visible = true;
            deletePictureBox.Visible = true;
        }

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
        }

        public void SetDeleteContext(DeleteVideoForm.Delegate context)
        {
            this.context = context;
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.addPlaylistPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).BeginInit();
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "DownloadedVideoListItemPanel";
            ((System.ComponentModel.ISupportInitialize)(this.addPlaylistPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        protected override void addPlaylistPictureBox_Click(object sender, EventArgs e)
        {

        }

        protected override void deletePictureBox_Click(object sender, EventArgs e)
        {
            DeleteVideoForm deleteForm = new DeleteVideoForm();
            deleteForm.SetVideoId(currentResult.youtubeID);
            deleteForm.SetDelegate(context);
            deleteForm.ShowDialog();
        }
    }
}
