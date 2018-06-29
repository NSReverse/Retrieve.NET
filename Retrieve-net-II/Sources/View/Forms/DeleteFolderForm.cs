using Retrieve_net_II.Sources.Data.Utils;
using Retrieve_net_II.Sources.Model;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Retrieve_net_II.Sources.View.Forms
{
    public partial class DeleteFolderForm : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private Delegate currentDelegate;
        public string videoId;

        private Size closePictureBox_OriginalSize;
        private Point closePictureBox_OriginalLocation;
        private bool closePictureBoxResizeUp = false;
        private PlaylistInfo currentInfo;

        public interface Delegate
        {
            void FolderDeleted();
        }

        public void SetDelegate(Delegate delegateCandidate)
        {
            currentDelegate = delegateCandidate;
        }

        public void SetPlaylistInfo(PlaylistInfo info)
        {
            currentInfo = info;
        }

        public DeleteFolderForm()
        {
            InitializeComponent();

            closePictureBox_OriginalSize = closePictureBox_Delete.Size;
            closePictureBox_OriginalLocation = closePictureBox_Delete.Location;

            closePictureBoxResizeTimer.Interval = 10;  // Close Buttom Timer Interval for zoom animation
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            PlaylistManager.RemovePlaylist(currentInfo);

            if (currentDelegate != null)
            {
                currentDelegate.FolderDeleted();
            }

            this.Close();
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

        private void closePictureBox_Delete_MouseEnter(object sender, EventArgs e)
        {
            closePictureBoxResizeUp = true;
            closePictureBoxResizeTimer.Start();
        }

        private void closePictureBox_Delete_MouseLeave(object sender, EventArgs e)
        {
            closePictureBoxResizeUp = false;
            closePictureBoxResizeTimer.Start();
        }

        private void closePictureBoxResizeTimer_Tick(object sender, EventArgs e)
        {
            if (closePictureBoxResizeUp)
            {
                if (closePictureBox_Delete.Width < closePictureBox_OriginalSize.Width + 10)
                {
                    closePictureBox_Delete.Size = new Size(closePictureBox_Delete.Width + 2, closePictureBox_Delete.Height + 2);
                    closePictureBox_Delete.Location = new Point(closePictureBox_Delete.Left - 1, closePictureBox_Delete.Top - 1);
                }
                else
                {
                    closePictureBoxResizeTimer.Stop();
                }
            }
            else
            {
                if (closePictureBox_Delete.Width > closePictureBox_OriginalSize.Width)
                {
                    closePictureBox_Delete.Size = new Size(closePictureBox_Delete.Width - 2, closePictureBox_Delete.Height - 2);
                    closePictureBox_Delete.Location = new Point(closePictureBox_Delete.Left + 1, closePictureBox_Delete.Top + 1);
                }
                else
                {
                    closePictureBoxResizeTimer.Stop();
                }
            }
        }

        private void closePictureBox_Delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
