using Retrieve_net_II.Sources.Data.Networking;
using Retrieve_net_II.Sources.Data.Utils;
using Retrieve_net_II.Sources.Model;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Retrieve_net_II
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private Size navigationDrawerPanel_OriginalSize;
        private bool navigationPanelCollapse = false;

        private Size closePictureBox_OriginalSize;
        private Point closePictureBox_OriginalLocation;
        private bool closePictureBoxResizeUp = false;

        private Color originalButtonColor;
        private Color selectedButtonColor;

        private PanelManager panelManager = new PanelManager();

        private enum SelectedPanelButton
        {
            VIDEOS,
            FOLDERS,
            SETTINGS
        }

        public Form1()
        {
            InitializeComponent();

            navigationDrawerPanel_OriginalSize = navigationDrawerPanel.Size;

            closePictureBox_OriginalSize = closePictureBox.Size;
            closePictureBox_OriginalLocation = closePictureBox.Location;

            navigationDrawerResizeTimer.Interval = 10; // Navigation Drawer Timer Interval for collapse animation
            closePictureBoxResizeTimer.Interval = 10;  // Close Buttom Timer Interval for zoom animation

            // Colors for Navigation Drawer state
            originalButtonColor = Color.FromArgb(255, 26, 32, 40);
            selectedButtonColor = Color.FromArgb(255, 0, 102, 204);

            // Set initial state
            ActivatePage(SelectedPanelButton.VIDEOS);

            panelManager.SetPanelOriginalSize(mainPanel_Videos);
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void navigationDrawerResizeTimer_Tick(object sender, EventArgs e)
        {
            if (navigationPanelCollapse)
            {
                if (navigationDrawerPanel.Width > 85)
                {
                    navigationDrawerPanel.Size = new Size(navigationDrawerPanel.Width - 5, navigationDrawerPanel.Height);
                }
                else
                {
                    navigationDrawerResizeTimer.Stop();
                }
            }
            else
            {
                if (navigationDrawerPanel.Width < navigationDrawerPanel_OriginalSize.Width)
                {
                    navigationDrawerPanel.Size = new Size(navigationDrawerPanel.Width + 5, navigationDrawerPanel.Height);
                }
                else
                {
                    navigationDrawerResizeTimer.Stop();
                }
            }
        }

        private void ActivatePage(SelectedPanelButton page)
        {
            if (page == SelectedPanelButton.VIDEOS)
            {
                videosPanel.BackColor = selectedButtonColor;
                foldersPanel.BackColor = originalButtonColor;
                settingsPanel.BackColor = originalButtonColor;

                panelManager.ShowMainPanel(mainPanel_Videos, true);
                panelManager.ShowMainPanel(mainPanel_Folders, false);
                panelManager.ShowMainPanel(mainPanel_Settings, false);
            }
            else if (page == SelectedPanelButton.FOLDERS)
            {
                videosPanel.BackColor = originalButtonColor;
                foldersPanel.BackColor = selectedButtonColor;
                settingsPanel.BackColor = originalButtonColor;

                panelManager.ShowMainPanel(mainPanel_Videos, false);
                panelManager.ShowMainPanel(mainPanel_Folders, true);
                panelManager.ShowMainPanel(mainPanel_Settings, false);
            }
            else
            {
                videosPanel.BackColor = originalButtonColor;
                foldersPanel.BackColor = originalButtonColor;
                settingsPanel.BackColor = selectedButtonColor;

                panelManager.ShowMainPanel(mainPanel_Videos, false);
                panelManager.ShowMainPanel(mainPanel_Folders, false);
                panelManager.ShowMainPanel(mainPanel_Settings, true);
            }
        }

        private void videosPanel_Click(object sender, EventArgs e)
        {
            ActivatePage(SelectedPanelButton.VIDEOS);
        }

        private void foldersPanel_Click(object sender, EventArgs e)
        {
            ActivatePage(SelectedPanelButton.FOLDERS);
        }

        private void settingsPanel_Click(object sender, EventArgs e)
        {
            ActivatePage(SelectedPanelButton.SETTINGS);
        }

        private void navigationDrawerActivatePictureBox_Click(object sender, EventArgs e)
        { 
            navigationPanelCollapse = !navigationPanelCollapse;
            navigationDrawerResizeTimer.Start();
        }
    }
}
