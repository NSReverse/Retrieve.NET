using Retrieve_net_II.R;
using Retrieve_net_II.Sources.Data.Utils;
using System;
using System.Windows.Forms;

namespace Retrieve_net_II.Sources.View
{
    public partial class SettingsPanel : UserControl
    {
        public SettingsPanel()
        {
            InitializeComponent();

            resultNumericUpDown.Minimum = 1;
            resultNumericUpDown.Maximum = 250;

            ReloadPreferences();
        }

        private void ReloadPreferences()
        {
            libraryLocationTextBox.Text = PreferenceManager.GetLibraryLocation();
            resultNumericUpDown.Value = PreferenceManager.GetSearchResultLimit();
            developmentCheckBox.Checked = PreferenceManager.GetUseDevelopmentServer();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            PreferenceManager.SetDefaults(libraryLocationTextBox.Text,
                (int)resultNumericUpDown.Value,
                developmentCheckBox.Checked);
        }

        private void defaultButton_Click(object sender, EventArgs e)
        {
            PreferenceManager.ResetDefaults();

            ReloadPreferences();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Log.D(Strings.Tags.SETTINGS_PANEL, "Path: " + fbd.SelectedPath);

                    libraryLocationTextBox.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
