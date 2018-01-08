using Retrieve_net_II.R;
using Retrieve_net_II.Sources.Data.Utils;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Retrieve_net_II.Sources.View
{
    public partial class SearchVideoInputForm : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private Delegate currentDelegate;
        private Size closePictureBox_OriginalSize;
        private Point closePictureBox_OriginalLocation;
        private bool closePictureBoxResizeUp = false;

        public interface Delegate
        {
            Task SendSearchQueryAsync(string query);
            void SearchCancelled();
        }

        public SearchVideoInputForm()
        {
            InitializeComponent();

            closePictureBox_OriginalSize = closePictureBox_Search.Size;
            closePictureBox_OriginalLocation = closePictureBox_Search.Location;

            closePictureBoxTimer_Search.Interval = 10;  // Close Buttom Timer Interval for zoom animation
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string query = queryTextBox.Text;

            if (query.Length == 0)
            {
                QuickAlert.ShowError(Strings.searchQueryEmptyAlertTitle, Strings.searchQueryEmptyAlertBody);
            }
            else
            {
                query = HttpUtility.UrlEncode(query);

                if (currentDelegate != null)
                {
                    currentDelegate.SendSearchQueryAsync(query);
                }

                this.Close();
            }
        }

        public void SetDelegate(Object delegateCandidate)
        {
            if (delegateCandidate is Delegate)
            {
                currentDelegate = (Delegate)delegateCandidate;
            }
        }

        private void closePictureBox_Search_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
