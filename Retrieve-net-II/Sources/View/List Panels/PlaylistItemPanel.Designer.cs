namespace Retrieve_net_II.Sources.View.List_Panels
{
    partial class PlaylistItemPanel
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
            this.videoResultPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.videoResultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoResultPanel
            // 
            this.videoResultPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoResultPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.videoResultPanel.Controls.Add(this.titleLabel);
            this.videoResultPanel.Location = new System.Drawing.Point(9, 7);
            this.videoResultPanel.Name = "videoResultPanel";
            this.videoResultPanel.Size = new System.Drawing.Size(533, 45);
            this.videoResultPanel.TabIndex = 1;
            this.videoResultPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.videoResultPanel_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoEllipsis = true;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(15, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(58, 19);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "label1";
            // 
            // PlaylistItemPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.videoResultPanel);
            this.Name = "PlaylistItemPanel";
            this.Size = new System.Drawing.Size(550, 60);
            this.videoResultPanel.ResumeLayout(false);
            this.videoResultPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel videoResultPanel;
        private System.Windows.Forms.Label titleLabel;
    }
}
