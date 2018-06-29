using System;
using System.Windows.Forms;
using Retrieve_net_II.Sources.Model;
using Retrieve_net_II.Sources.View.Forms;

namespace Retrieve_net_II.Sources.View.List_Panels
{
    public partial class PlaylistItemPanel : UserControl
    {
        private PlaylistInfo currentInfo;
        private DeleteFolderForm.Delegate deleteContext;

        public PlaylistItemPanel()
        {
            InitializeComponent();
        }

        public void SetPlaylistInfo(PlaylistInfo currentInfo)
        {
            titleLabel.Text = currentInfo.name;

            this.currentInfo = currentInfo;
        }

        public void SetDeleteContext(DeleteFolderForm.Delegate delegateCandidate)
        {
            if (delegateCandidate is DeleteFolderForm.Delegate)
            {
                deleteContext = delegateCandidate;
            }
        }

        private void videoResultPanel_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Open Folder
            }
            else if (e.Button == MouseButtons.Right)
            {
                // Open Folder Delete Dialog 
                DeleteFolderForm deleteForm = new DeleteFolderForm();
                deleteForm.SetDelegate(deleteContext);
                deleteForm.SetPlaylistInfo(currentInfo);
                deleteForm.ShowDialog();
            }
        }
    }
}
