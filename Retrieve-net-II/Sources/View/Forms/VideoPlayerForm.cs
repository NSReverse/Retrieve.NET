using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WMPLib;

namespace Retrieve_net_II.Sources.View.Forms
{
    public partial class VideoPlayerForm : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private Size closePictureBox_OriginalSize;
        private Point closePictureBox_OriginalLocation;
        private bool closePictureBoxResizeUp = false;

        public VideoPlayerForm()
        {
            InitializeComponent();

            closePictureBox_OriginalSize = closePictureBox.Size;
            closePictureBox_OriginalLocation = closePictureBox.Location;

            closePictureBoxResizeTimer.Interval = 10;  // Close Buttom Timer Interval for zoom animation
        }

        public void SetVideoLocation(string location)
        {
            mediaPlayer.URL = location;
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

        private void closePictureBoxResizeTimer_Tick(object sender, EventArgs e)
        {
            if (closePictureBoxResizeUp)
            {
                if (closePictureBox.Width < closePictureBox_OriginalSize.Width + 10)
                {
                    closePictureBox.Size = new Size(closePictureBox.Width + 2, closePictureBox.Height + 2);
                    closePictureBox.Location = new Point(closePictureBox.Left - 1, closePictureBox.Top - 1);
                }
                else
                {
                    closePictureBoxResizeTimer.Stop();
                }
            }
            else
            {
                if (closePictureBox.Width > closePictureBox_OriginalSize.Width)
                {
                    closePictureBox.Size = new Size(closePictureBox.Width - 2, closePictureBox.Height - 2);
                    closePictureBox.Location = new Point(closePictureBox.Left + 1, closePictureBox.Top + 1);
                }
                else
                {
                    closePictureBoxResizeTimer.Stop();
                }
            }
        }

        private void closePictureBox_MouseEnter(object sender, EventArgs e)
        {
            closePictureBoxResizeUp = true;
            closePictureBoxResizeTimer.Start();
        }

        private void closePictureBox_MouseLeave(object sender, EventArgs e)
        {
            closePictureBoxResizeUp = false;
            closePictureBoxResizeTimer.Start();
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.stop();
            this.Close();
        }
    }
}
