using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retrieve_net_II.Sources.Data.Utils
{
    class PanelManager
    {
        private Size panelOriginalSize;
        private Size panelHiddenSize = new Size(0, 0);

        public void SetPanelOriginalSize(UserControl panel)
        {
            panelOriginalSize = panel.Size;
        }

        public void ShowMainPanel(UserControl panel, bool show)
        {
            panel.Dock = (show)? DockStyle.Fill : DockStyle.None;           // Set Dock properties so panel can be resized.
            panel.Size = (show)? panelOriginalSize : panelHiddenSize;       // Set appropriate sizing.
        }
    }
}
