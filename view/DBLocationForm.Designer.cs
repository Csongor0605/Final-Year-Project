namespace Final_Year_Project
{
    partial class DBLocationForm
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
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(17, 16);
            this.locationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(373, 22);
            this.locationTextBox.TabIndex = 0;
            // 
            // browseBtn
            // 
            this.browseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseBtn.Location = new System.Drawing.Point(401, 16);
            this.browseBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(109, 25);
            this.browseBtn.TabIndex = 1;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmBtn.Location = new System.Drawing.Point(400, 87);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(100, 28);
            this.confirmBtn.TabIndex = 2;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(292, 87);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"SQLite|*.sqlite|All Files|*.*\"";
            this.openFileDialog1.Title = "Select Existing SQLite File";
            // 
            // DBLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 128);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.locationTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DBLocationForm";
            this.Text = "Select Databse Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}