namespace Retrieve_net_II.Sources.View.Main_Panels
{
    partial class FoldersPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.createFolderButton = new System.Windows.Forms.Button();
            this.foldersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.createFolderButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 44);
            this.panel1.TabIndex = 5;
            // 
            // createFolderButton
            // 
            this.createFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createFolderButton.FlatAppearance.BorderSize = 0;
            this.createFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createFolderButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createFolderButton.ForeColor = System.Drawing.Color.White;
            this.createFolderButton.Location = new System.Drawing.Point(353, 6);
            this.createFolderButton.Name = "createFolderButton";
            this.createFolderButton.Size = new System.Drawing.Size(112, 32);
            this.createFolderButton.TabIndex = 4;
            this.createFolderButton.Text = "Create Folder";
            this.createFolderButton.UseVisualStyleBackColor = true;
            this.createFolderButton.Click += new System.EventHandler(this.createFolderButton_Click);
            // 
            // foldersTableLayoutPanel
            // 
            this.foldersTableLayoutPanel.AutoScroll = true;
            this.foldersTableLayoutPanel.ColumnCount = 1;
            this.foldersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.foldersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foldersTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.foldersTableLayoutPanel.Name = "foldersTableLayoutPanel";
            this.foldersTableLayoutPanel.RowCount = 11;
            this.foldersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.foldersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.foldersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.foldersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.foldersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.foldersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.foldersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.foldersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.foldersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.foldersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.foldersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.foldersTableLayoutPanel.Size = new System.Drawing.Size(468, 221);
            this.foldersTableLayoutPanel.TabIndex = 6;
            // 
            // FoldersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.foldersTableLayoutPanel);
            this.Controls.Add(this.panel1);
            this.Name = "FoldersPanel";
            this.Size = new System.Drawing.Size(468, 265);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button createFolderButton;
        private System.Windows.Forms.TableLayoutPanel foldersTableLayoutPanel;
    }
}
