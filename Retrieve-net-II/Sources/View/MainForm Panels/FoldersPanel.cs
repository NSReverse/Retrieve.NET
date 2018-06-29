using System;
using System.Windows.Forms;
using Retrieve_net_II.Sources.View.Forms;
using Retrieve_net_II.Sources.Data.Utils;
using System.Collections.Generic;
using Retrieve_net_II.Sources.Model;
using Retrieve_net_II.Sources.View.List_Panels;

namespace Retrieve_net_II.Sources.View.Main_Panels
{
    public partial class FoldersPanel : UserControl, AddPlaylistForm.Delegate, DeleteFolderForm.Delegate
    {
        public FoldersPanel()
        {
            InitializeComponent();

            ReloadDataSource();
        }

        private void createFolderButton_Click(object sender, EventArgs e)
        {
            if (ApplicationUtils.CheckLibrary())
            {
                AddPlaylistForm addPlaylistForm = new AddPlaylistForm();
                addPlaylistForm.SetDelegate(this);
                addPlaylistForm.ShowDialog();
            }
            else
            {
                QuickAlert.ShowError("Error", "Library path is invalid. Please create a folder or point to an existing library in settings.");
            }
        }

        private void ReloadDataSource()
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(() =>
                {
                    ReloadDataSource();
                }));
            }
            else
            {
                foldersTableLayoutPanel.Controls.Clear();

                HashSet<PlaylistInfo> playlists = PlaylistManager.GetAllPlaylistFiles();

                foreach (PlaylistInfo currentPlaylist in playlists)
                {
                    PlaylistItemPanel currentPanel = new PlaylistItemPanel();
                    currentPanel.SetPlaylistInfo(currentPlaylist);
                    currentPanel.SetDeleteContext(this);

                    foldersTableLayoutPanel.Controls.Add(currentPanel);

                    currentPanel.Dock = DockStyle.Fill;
                }
            }
        }

        public void PlaylistAdded()
        {
            ReloadDataSource();
        }

        public void FolderDeleted()
        {
            ReloadDataSource();
        }
    }
}
