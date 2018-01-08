using Retrieve_net_II.R;
using Retrieve_net_II.Sources.Data.Networking;
using Retrieve_net_II.Sources.Data.Utils;
using Retrieve_net_II.Sources.Model;
using Retrieve_net_II.Sources.View.List_Panels;
using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Retrieve_net_II.Sources.View
{
    public partial class SearchResultForm : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        string resultJSON = null;
        ArrayList resultList = null;
        private Size closePictureBox_OriginalSize;
        private Point closePictureBox_OriginalLocation;
        private bool closePictureBoxResizeUp = false;
        private String query;
        private FileDownloader.VideoCompletedDelegate context;

        const int itemsPerPage = 4;
        int currentPage = 0;

        public SearchResultForm()
        {
            InitializeComponent();

            closePictureBox_OriginalSize = closePictureBox_SearchResults.Size;
            closePictureBox_OriginalLocation = closePictureBox_SearchResults.Location;

            closePictureBoxTimer_Search.Interval = 10;  // Close Buttom Timer Interval for zoom animation

            resultTableLayoutPanel.ColumnCount = 1;
            resultTableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowOnly;
            resultTableLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;

            resultTableLayoutPanel.Padding = new Padding(0, 0, vertScrollWidth, 0);

            titleLabel.Text = String.Format(Strings.searchResultsTitle, Strings.loadingData);
        }

        public void SetQuery(string query)
        {
            this.query = query; // Save query to display in title after data loads.
        }

        public async void SetResultJSON(string json)
        {
            resultJSON = json;

            resultList = await JsonUtils.ParseSearchResultJSON(resultJSON);

            LoadPageFromDataSource(0);
        }

        public void SetDownloadCompletionContext(FileDownloader.VideoCompletedDelegate context)
        {
            this.context = context;
        }

        private void LoadPageFromDataSource(int page)
        {
            resultTableLayoutPanel.Controls.Clear();

            currentPage = page;

            previousButton.Visible = (currentPage == 0) ? false : true;
            previousButton.Enabled = (currentPage == 0) ? false : true;

            if (resultList != null)
            {
                int totalItemCount = resultList.Count;
                int startIndex = (currentPage * itemsPerPage);
                int endIndex = startIndex + 3;

                if (endIndex >= resultList.Count - 1)
                {
                    endIndex = (resultList.Count - 1);
                    nextButton.Visible = false;
                    nextButton.Enabled = false;
                }
                else
                {
                    nextButton.Visible = true;
                    nextButton.Enabled = true;
                }

                for (int i = startIndex; i <= endIndex; i++)
                {
                    VideoInfo currentObject = (VideoInfo)resultList[i];

                    VideoListItemPanel currentPanel = new VideoListItemPanel();
                    currentPanel.SetSearchResult(currentObject);
                    currentPanel.SetDownloadCompletionContext(context);

                    resultTableLayoutPanel.Controls.Add(currentPanel);

                    currentPanel.Dock = DockStyle.Fill;
                }

                titleLabel.Text = String.Format(Strings.searchResultsTitle + " (Page {1})", query, (page + 1));
            }
            else
            {
                titleLabel.Text = String.Format(Strings.searchResultsTitle, Strings.noData);
            }
        }

        private void closePictureBox_Search_Click(object sender, EventArgs e)
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
                if (closePictureBox_SearchResults.Width < closePictureBox_OriginalSize.Width + 10)
                {
                    closePictureBox_SearchResults.Size = new Size(closePictureBox_SearchResults.Width + 2, closePictureBox_SearchResults.Height + 2);
                    closePictureBox_SearchResults.Location = new Point(closePictureBox_SearchResults.Left - 1, closePictureBox_SearchResults.Top - 1);
                }
                else
                {
                    closePictureBoxTimer_Search.Stop();
                }
            }
            else
            {
                if (closePictureBox_SearchResults.Width > closePictureBox_OriginalSize.Width)
                {
                    closePictureBox_SearchResults.Size = new Size(closePictureBox_SearchResults.Width - 2, closePictureBox_SearchResults.Height - 2);
                    closePictureBox_SearchResults.Location = new Point(closePictureBox_SearchResults.Left + 1, closePictureBox_SearchResults.Top + 1);
                }
                else
                {
                    closePictureBoxTimer_Search.Stop();
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            LoadPageFromDataSource(currentPage + 1);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                LoadPageFromDataSource(currentPage - 1);
            }
        }
    }
}
