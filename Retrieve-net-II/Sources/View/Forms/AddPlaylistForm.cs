using Retrieve_net_II.Sources.Data.Utils;
using Retrieve_net_II.Sources.Model;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Retrieve_net_II.Sources.View.Forms
{
    public partial class AddPlaylistForm : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private Size closePictureBox_OriginalSize;
        private Point closePictureBox_OriginalLocation;
        private bool closePictureBoxResizeUp = false;

        private Delegate currentDelegate;

        public interface Delegate
        {
            void PlaylistAdded();
        }

        public void SetDelegate(Delegate delegateCandidate)
        {
            if (delegateCandidate is Delegate)
            {
                currentDelegate = delegateCandidate;
            }
        }
        
        public AddPlaylistForm()
        {
            InitializeComponent();

            closePictureBox_OriginalSize = closePictureBox_Folder.Size;
            closePictureBox_OriginalLocation = closePictureBox_Folder.Location;

            closePictureBoxTimer_Folder.Interval = 10;  // Close Buttom Timer Interval for zoom animation
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            PlaylistInfo newInfo = new PlaylistInfo();
            newInfo.name = folderNameTextBox.Text;

            PlaylistManager.AddPlaylist(newInfo, null);

            if (currentDelegate != null)
            {
                currentDelegate.PlaylistAdded();
            }

            this.Close();
        }

        private void closePictureBox_Folder_Click(object sender, EventArgs e)
        {
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

        private void closePictureBox_Folder_MouseEnter(object sender, EventArgs e)
        {
            closePictureBoxResizeUp = true;
            closePictureBoxTimer_Folder.Start();
        }

        private void closePictureBox_Folder_MouseLeave(object sender, EventArgs e)
        {
            closePictureBoxResizeUp = false;
            closePictureBoxTimer_Folder.Start();
        }

        private void closePictureBoxTimer_Folder_Tick(object sender, EventArgs e)
        {
            if (closePictureBoxResizeUp)
            {
                if (closePictureBox_Folder.Width < closePictureBox_OriginalSize.Width + 10)
                {
                    closePictureBox_Folder.Size = new Size(closePictureBox_Folder.Width + 2, closePictureBox_Folder.Height + 2);
                    closePictureBox_Folder.Location = new Point(closePictureBox_Folder.Left - 1, closePictureBox_Folder.Top - 1);
                }
                else
                {
                    closePictureBoxTimer_Folder.Stop();
                }
            }
            else
            {
                if (closePictureBox_Folder.Width > closePictureBox_OriginalSize.Width)
                {
                    closePictureBox_Folder.Size = new Size(closePictureBox_Folder.Width - 2, closePictureBox_Folder.Height - 2);
                    closePictureBox_Folder.Location = new Point(closePictureBox_Folder.Left + 1, closePictureBox_Folder.Top + 1);
                }
                else
                {
                    closePictureBoxTimer_Folder.Stop();
                }
            }
        }
    }
}
