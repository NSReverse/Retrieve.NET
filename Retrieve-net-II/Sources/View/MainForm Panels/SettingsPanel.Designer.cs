namespace Retrieve_net_II.Sources.View
{
    partial class SettingsPanel
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
            this.developmentCheckBox = new System.Windows.Forms.CheckBox();
            this.generalSettingsLabel = new System.Windows.Forms.Label();
            this.defaultButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.libraryLocationTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.resultNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // developmentCheckBox
            // 
            this.developmentCheckBox.AutoSize = true;
            this.developmentCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developmentCheckBox.ForeColor = System.Drawing.Color.White;
            this.developmentCheckBox.Location = new System.Drawing.Point(69, 205);
            this.developmentCheckBox.Name = "developmentCheckBox";
            this.developmentCheckBox.Size = new System.Drawing.Size(183, 21);
            this.developmentCheckBox.TabIndex = 0;
            this.developmentCheckBox.TabStop = false;
            this.developmentCheckBox.Text = "Use Development Server";
            this.developmentCheckBox.UseVisualStyleBackColor = true;
            // 
            // generalSettingsLabel
            // 
            this.generalSettingsLabel.AutoSize = true;
            this.generalSettingsLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalSettingsLabel.ForeColor = System.Drawing.Color.White;
            this.generalSettingsLabel.Location = new System.Drawing.Point(40, 26);
            this.generalSettingsLabel.Name = "generalSettingsLabel";
            this.generalSettingsLabel.Size = new System.Drawing.Size(61, 16);
            this.generalSettingsLabel.TabIndex = 1;
            this.generalSettingsLabel.Text = "General";
            // 
            // defaultButton
            // 
            this.defaultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultButton.FlatAppearance.BorderSize = 0;
            this.defaultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultButton.ForeColor = System.Drawing.Color.White;
            this.defaultButton.Location = new System.Drawing.Point(574, 324);
            this.defaultButton.Name = "defaultButton";
            this.defaultButton.Size = new System.Drawing.Size(88, 32);
            this.defaultButton.TabIndex = 2;
            this.defaultButton.TabStop = false;
            this.defaultButton.Text = "Default";
            this.defaultButton.UseVisualStyleBackColor = true;
            this.defaultButton.Click += new System.EventHandler(this.defaultButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.FlatAppearance.BorderSize = 0;
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.ForeColor = System.Drawing.Color.White;
            this.applyButton.Location = new System.Drawing.Point(480, 324);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(88, 32);
            this.applyButton.TabIndex = 3;
            this.applyButton.TabStop = false;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Library Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Development";
            // 
            // browseButton
            // 
            this.browseButton.FlatAppearance.BorderSize = 0;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.Color.White;
            this.browseButton.Location = new System.Drawing.Point(574, 56);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(88, 32);
            this.browseButton.TabIndex = 12;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // libraryLocationTextBox
            // 
            this.libraryLocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.libraryLocationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.libraryLocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.libraryLocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libraryLocationTextBox.ForeColor = System.Drawing.Color.White;
            this.libraryLocationTextBox.Location = new System.Drawing.Point(229, 62);
            this.libraryLocationTextBox.MaximumSize = new System.Drawing.Size(330, 22);
            this.libraryLocationTextBox.Name = "libraryLocationTextBox";
            this.libraryLocationTextBox.Size = new System.Drawing.Size(330, 22);
            this.libraryLocationTextBox.TabIndex = 13;
            this.libraryLocationTextBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Max Search Results";
            // 
            // resultNumericUpDown
            // 
            this.resultNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.resultNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultNumericUpDown.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.resultNumericUpDown.ForeColor = System.Drawing.Color.White;
            this.resultNumericUpDown.Location = new System.Drawing.Point(229, 112);
            this.resultNumericUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.resultNumericUpDown.Name = "resultNumericUpDown";
            this.resultNumericUpDown.Size = new System.Drawing.Size(330, 20);
            this.resultNumericUpDown.TabIndex = 15;
            this.resultNumericUpDown.TabStop = false;
            // 
            // SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.resultNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.libraryLocationTextBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.defaultButton);
            this.Controls.Add(this.generalSettingsLabel);
            this.Controls.Add(this.developmentCheckBox);
            this.Name = "SettingsPanel";
            this.Size = new System.Drawing.Size(691, 382);
            ((System.ComponentModel.ISupportInitialize)(this.resultNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox developmentCheckBox;
        private System.Windows.Forms.Label generalSettingsLabel;
        private System.Windows.Forms.Button defaultButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox libraryLocationTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown resultNumericUpDown;
    }
}
