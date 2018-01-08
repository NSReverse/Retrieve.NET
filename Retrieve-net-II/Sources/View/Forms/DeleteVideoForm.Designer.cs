namespace Retrieve_net_II.Sources.View.Forms
{
    partial class DeleteVideoForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.closePictureBox_Delete = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.closePictureBoxResizeTimer = new System.Windows.Forms.Timer(this.components);
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.titlePanel.Controls.Add(this.closePictureBox_Delete);
            this.titlePanel.Controls.Add(this.pictureBox3);
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Controls.Add(this.closePictureBox);
            this.titlePanel.Controls.Add(this.pictureBox2);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(358, 35);
            this.titlePanel.TabIndex = 2;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            // 
            // closePictureBox_Delete
            // 
            this.closePictureBox_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePictureBox_Delete.Image = global::Retrieve_net_II.Properties.Resources.close;
            this.closePictureBox_Delete.Location = new System.Drawing.Point(329, 9);
            this.closePictureBox_Delete.Name = "closePictureBox_Delete";
            this.closePictureBox_Delete.Size = new System.Drawing.Size(17, 17);
            this.closePictureBox_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePictureBox_Delete.TabIndex = 5;
            this.closePictureBox_Delete.TabStop = false;
            this.closePictureBox_Delete.Click += new System.EventHandler(this.closePictureBox_Search_Click);
            this.closePictureBox_Delete.MouseEnter += new System.EventHandler(this.closePictureBox_MouseEnter);
            this.closePictureBox_Delete.MouseLeave += new System.EventHandler(this.closePictureBox_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Retrieve_net_II.Properties.Resources.if_document_video_down_103520;
            this.pictureBox3.Location = new System.Drawing.Point(-257, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 26);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(45, 8);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(106, 20);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Delete Video";
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            // 
            // closePictureBox
            // 
            this.closePictureBox.Image = global::Retrieve_net_II.Properties.Resources.close;
            this.closePictureBox.Location = new System.Drawing.Point(922, 10);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(17, 17);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePictureBox.TabIndex = 2;
            this.closePictureBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Retrieve_net_II.Properties.Resources.if_document_video_down_103520;
            this.pictureBox2.Location = new System.Drawing.Point(12, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 26);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Location = new System.Drawing.Point(1, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 133);
            this.panel1.TabIndex = 3;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(183, 80);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(69, 32);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(258, 80);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(69, 32);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(26, 18);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(284, 16);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "Are you sure you wish to delete this video?";
            // 
            // closePictureBoxResizeTimer
            // 
            this.closePictureBoxResizeTimer.Tick += new System.EventHandler(this.closePictureBoxResizeTimer_Tick);
            // 
            // DeleteVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(358, 173);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteVideoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DeleteVideoForm";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox closePictureBox_Delete;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Timer closePictureBoxResizeTimer;
    }
}