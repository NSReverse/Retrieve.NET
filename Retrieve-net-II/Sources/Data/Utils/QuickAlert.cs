using System;
using System.Windows.Forms;

namespace Retrieve_net_II.Sources.Data.Utils
{
    class QuickAlert
    {
        public static void ShowInfo(String title, String message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowError(String title, String message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
