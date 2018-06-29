using Retrieve_net_II.R;
using Retrieve_net_II.R.Configurations;
using Retrieve_net_II.Sources.Data.Networking;
using Retrieve_net_II.Sources.Data.Utils;
using Retrieve_net_II.Sources.Model;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Retrieve_net_II.Sources.View.Forms
{
    public partial class SearchResultVideoOptionsForm : Form, FileDownloader.ProgressDelegate, SocketManager.Delegate
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private VideoInfo currentResult;
        private Size closePictureBox_OriginalSize;
        private Point closePictureBox_OriginalLocation;
        private bool closePictureBoxResizeUp = false;

        private FileDownloader.VideoCompletedDelegate context;

        public SearchResultVideoOptionsForm()
        {
            InitializeComponent();

            closePictureBox_OriginalSize = closePictureBox_Search.Size;
            closePictureBox_OriginalLocation = closePictureBox_Search.Location;

            closePictureBoxTimer_Search.Interval = 10;  // Close Buttom Timer Interval for zoom animation

            progressBar.Visible = false;
            progressLabel.Visible = false;
        }

        public void SetSearchResult(VideoInfo newResult)
        {
            currentResult = newResult;

            if (currentResult != null)
            {
                thumbnailPictureBox.Image = currentResult.thumbnailImage;
                videoTitleLabel.Text = currentResult.title;
                authorLabel.Text = currentResult.author;
                idLabel.Text = currentResult.youtubeID;

                titleLabel.Text = currentResult.title;
            }
        }

        public void SetDownloadCompletionContext(FileDownloader.VideoCompletedDelegate context)
        {
            this.context = context;
        }

        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HT_CAPTION = 0x2;

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closePictureBoxTimer_Search_Tick(object sender, EventArgs e)
        {
            if (closePictureBoxResizeUp)
            {
                if (closePictureBox_Search.Width < closePictureBox_OriginalSize.Width + 10)
                {
                    closePictureBox_Search.Size = new Size(closePictureBox_Search.Width + 2, closePictureBox_Search.Height + 2);
                    closePictureBox_Search.Location = new Point(closePictureBox_Search.Left - 1, closePictureBox_Search.Top - 1);
                }
                else
                {
                    closePictureBoxTimer_Search.Stop();
                }
            }
            else
            {
                if (closePictureBox_Search.Width > closePictureBox_OriginalSize.Width)
                {
                    closePictureBox_Search.Size = new Size(closePictureBox_Search.Width - 2, closePictureBox_Search.Height - 2);
                    closePictureBox_Search.Location = new Point(closePictureBox_Search.Left + 1, closePictureBox_Search.Top + 1);
                }
                else
                {
                    closePictureBoxTimer_Search.Stop();
                }
            }
        }

        private void closePictureBox_Search_MouseEnter(object sender, EventArgs e)
        {
            closePictureBoxResizeUp = true;
            closePictureBoxTimer_Search.Start();
        }

        private void closePictureBox_Search_MouseLeave(object sender, EventArgs e)
        {
            closePictureBoxResizeUp = false;
            closePictureBoxTimer_Search.Start();
        }

        private void closePictureBox_Search_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            if (ApplicationUtils.CheckLibrary())
            {
                SocketManager manager = SocketManager.GetInstance();
                manager.SetDelegate(this);
                manager.SubmitYouTubeURL(currentResult.youtubeURL);

                downloadButton.Enabled = false;

                progressBar.Visible = true;
                progressLabel.Visible = true;

                progressLabel.Text = Strings.resolvingUrl;
            }
            else
            {
                QuickAlert.ShowError("Error", "Library path is invalid. Please create a folder or point to an existing library in settings.");
            }
        }

        private void streamButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(currentResult.youtubeURL);
        }

        public void VideoDownloadProgressChanged(double receivedBytes, double bytesExpected, int progress)
        {
            // Dispatching UI updates to main thread.
            this.BeginInvoke(new MethodInvoker(() =>
            {
                progressLabel.Text = String.Format(Strings.downloadFormatProgress, (receivedBytes / Math.Pow(1024, 2)), (bytesExpected / Math.Pow(1024, 2)), progress);
                progressBar.Value = progress;
            }));
        }

        public void DownloadURLReceived(string videoURL)
        {
            string libraryLocation = Retrieve.Default.LibraryLocation;

            Log.D(Strings.Tags.SEARCH_RESULT_VIDEO_OPTIONS_FORM, "libraryLocation: " + libraryLocation);
            Log.D(Strings.Tags.SEARCH_RESULT_VIDEO_OPTIONS_FORM, "videoURL: " + videoURL);

            if (libraryLocation != null && !libraryLocation.Equals(""))
            {
                FileDownloader.WithCompletionDelegate(context)
                    .WithProgressDelegate(this)
                    .WithVideoMetadata(currentResult)
                    .GetFile(videoURL);
            }
            else
            {
                QuickAlert.ShowError(Strings.errorUnableToDownload, Strings.noDefaultLibrary);
            }
        }
    }
}
