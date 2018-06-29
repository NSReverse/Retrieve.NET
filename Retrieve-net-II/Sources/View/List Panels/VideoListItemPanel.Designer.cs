namespace Retrieve_net_II.Sources.View.List_Panels
{
    partial class VideoListItemPanel
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
            this.idLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addPlaylistPictureBox = new System.Windows.Forms.PictureBox();
            this.deletePictureBox = new System.Windows.Forms.PictureBox();
            this.thumbnailPictureBox = new System.Windows.Forms.PictureBox();
            this.videoResultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPlaylistPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // videoResultPanel
            // 
            this.videoResultPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoResultPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.videoResultPanel.Controls.Add(this.addPlaylistPictureBox);
            this.videoResultPanel.Controls.Add(this.deletePictureBox);
            this.videoResultPanel.Controls.Add(this.idLabel);
            this.videoResultPanel.Controls.Add(this.authorLabel);
            this.videoResultPanel.Controls.Add(this.titleLabel);
            this.videoResultPanel.Controls.Add(this.thumbnailPictureBox);
            this.videoResultPanel.Location = new System.Drawing.Point(8, 8);
            this.videoResultPanel.Name = "videoResultPanel";
            this.videoResultPanel.Size = new System.Drawing.Size(533, 94);
            this.videoResultPanel.TabIndex = 0;
            this.videoResultPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.videoResultPanel_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.White;
            this.idLabel.Location = new System.Drawing.Point(172, 67);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(45, 17);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "label2";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.ForeColor = System.Drawing.Color.White;
            this.authorLabel.Location = new System.Drawing.Point(172, 32);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(45, 17);
            this.authorLabel.TabIndex = 6;
            this.authorLabel.Text = "label1";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoEllipsis = true;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(171, 11);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(58, 19);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "label1";
            // 
            // addPlaylistPictureBox
            // 
            this.addPlaylistPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addPlaylistPictureBox.Image = global::Retrieve_net_II.Properties.Resources.if_icon_81_document_add_314445;
            this.addPlaylistPictureBox.Location = new System.Drawing.Point(475, 64);
            this.addPlaylistPictureBox.Name = "addPlaylistPictureBox";
            this.addPlaylistPictureBox.Size = new System.Drawing.Size(20, 20);
            this.addPlaylistPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addPlaylistPictureBox.TabIndex = 9;
            this.addPlaylistPictureBox.TabStop = false;
            this.addPlaylistPictureBox.Click += new System.EventHandler(this.addPlaylistPictureBox_Click);
            // 
            // deletePictureBox
            // 
            this.deletePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletePictureBox.Image = global::Retrieve_net_II.Properties.Resources.if_trash_bin_1370026;
            this.deletePictureBox.Location = new System.Drawing.Point(501, 64);
            this.deletePictureBox.Name = "deletePictureBox";
            this.deletePictureBox.Size = new System.Drawing.Size(20, 20);
            this.deletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deletePictureBox.TabIndex = 8;
            this.deletePictureBox.TabStop = false;
            this.deletePictureBox.Click += new System.EventHandler(this.deletePictureBox_Click);
            // 
            // thumbnailPictureBox
            // 
            this.thumbnailPictureBox.Location = new System.Drawing.Point(8, 7);
            this.thumbnailPictureBox.Name = "thumbnailPictureBox";
            this.thumbnailPictureBox.Size = new System.Drawing.Size(140, 81);
            this.thumbnailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thumbnailPictureBox.TabIndex = 4;
            this.thumbnailPictureBox.TabStop = false;
            // 
            // VideoListItemPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.videoResultPanel);
            this.Name = "VideoListItemPanel";
            this.Size = new System.Drawing.Size(550, 109);
            this.videoResultPanel.ResumeLayout(false);
            this.videoResultPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPlaylistPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel videoResultPanel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox thumbnailPictureBox;
        protected System.Windows.Forms.PictureBox addPlaylistPictureBox;
        protected System.Windows.Forms.PictureBox deletePictureBox;
    }
}
