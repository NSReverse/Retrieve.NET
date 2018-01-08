namespace Retrieve_net_II.Sources.View.Main_Panels
{
    partial class VideosPanel
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
            this.addVideosButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.videosTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.addVideosButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 44);
            this.panel1.TabIndex = 1;
            // 
            // addVideosButton
            // 
            this.addVideosButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addVideosButton.FlatAppearance.BorderSize = 0;
            this.addVideosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVideosButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVideosButton.ForeColor = System.Drawing.Color.White;
            this.addVideosButton.Location = new System.Drawing.Point(339, 6);
            this.addVideosButton.Name = "addVideosButton";
            this.addVideosButton.Size = new System.Drawing.Size(102, 32);
            this.addVideosButton.TabIndex = 4;
            this.addVideosButton.Text = "Add Videos";
            this.addVideosButton.UseVisualStyleBackColor = true;
            this.addVideosButton.Click += new System.EventHandler(this.addVideosButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.videosTableLayoutPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 264);
            this.panel2.TabIndex = 2;
            // 
            // videosTableLayoutPanel
            // 
            this.videosTableLayoutPanel.ColumnCount = 1;
            this.videosTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 805F));
            this.videosTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videosTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.videosTableLayoutPanel.Name = "videosTableLayoutPanel";
            this.videosTableLayoutPanel.RowCount = 11;
            this.videosTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.videosTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.videosTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.videosTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.videosTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.videosTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.videosTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.videosTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.videosTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.videosTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.videosTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.videosTableLayoutPanel.Size = new System.Drawing.Size(444, 264);
            this.videosTableLayoutPanel.TabIndex = 1;
            // 
            // VideosPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VideosPanel";
            this.Size = new System.Drawing.Size(444, 308);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addVideosButton;
        private System.Windows.Forms.TableLayoutPanel videosTableLayoutPanel;
    }
}
