namespace Final_Year_Project
{
    partial class CreateDatabaseFile
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fileLoactionGroupBox = new System.Windows.Forms.GroupBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.fileLocation = new System.Windows.Forms.TextBox();
            this.fieldListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addFieldBtn = new System.Windows.Forms.Button();
            this.createDBfileBtn = new System.Windows.Forms.Button();
            this.fileLoactionGroupBox.SuspendLayout();
            this.fieldListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "sqlite";
            this.saveFileDialog1.FileName = "localDB";
            // 
            // fileLoactionGroupBox
            // 
            this.fileLoactionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileLoactionGroupBox.Controls.Add(this.browseBtn);
            this.fileLoactionGroupBox.Controls.Add(this.fileLocation);
            this.fileLoactionGroupBox.Location = new System.Drawing.Point(13, 13);
            this.fileLoactionGroupBox.Name = "fileLoactionGroupBox";
            this.fileLoactionGroupBox.Size = new System.Drawing.Size(509, 53);
            this.fileLoactionGroupBox.TabIndex = 0;
            this.fileLoactionGroupBox.TabStop = false;
            this.fileLoactionGroupBox.Text = "File Location";
            // 
            // browseBtn
            // 
            this.browseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseBtn.Location = new System.Drawing.Point(303, 19);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(71, 21);
            this.browseBtn.TabIndex = 1;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // fileLocation
            // 
            this.fileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileLocation.Location = new System.Drawing.Point(7, 20);
            this.fileLocation.Name = "fileLocation";
            this.fileLocation.Size = new System.Drawing.Size(290, 20);
            this.fileLocation.TabIndex = 0;
            // 
            // fieldListPanel
            // 
            this.fieldListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldListPanel.AutoScroll = true;
            this.fieldListPanel.Controls.Add(this.addFieldBtn);
            this.fieldListPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fieldListPanel.Location = new System.Drawing.Point(13, 68);
            this.fieldListPanel.Name = "fieldListPanel";
            this.fieldListPanel.Size = new System.Drawing.Size(509, 307);
            this.fieldListPanel.TabIndex = 1;
            this.fieldListPanel.WrapContents = false;
            // 
            // addFieldBtn
            // 
            this.addFieldBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addFieldBtn.Location = new System.Drawing.Point(3, 3);
            this.addFieldBtn.Name = "addFieldBtn";
            this.addFieldBtn.Size = new System.Drawing.Size(506, 38);
            this.addFieldBtn.TabIndex = 1;
            this.addFieldBtn.Text = "Add Field";
            this.addFieldBtn.UseVisualStyleBackColor = true;
            this.addFieldBtn.Click += new System.EventHandler(this.addFieldBtn_Click);
            // 
            // createDBfileBtn
            // 
            this.createDBfileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createDBfileBtn.Location = new System.Drawing.Point(13, 381);
            this.createDBfileBtn.Name = "createDBfileBtn";
            this.createDBfileBtn.Size = new System.Drawing.Size(509, 28);
            this.createDBfileBtn.TabIndex = 2;
            this.createDBfileBtn.Text = "Create Database File";
            this.createDBfileBtn.UseVisualStyleBackColor = true;
            this.createDBfileBtn.Click += new System.EventHandler(this.createDBfileBtn_Click);
            // 
            // CreateDatabaseFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 421);
            this.Controls.Add(this.createDBfileBtn);
            this.Controls.Add(this.fieldListPanel);
            this.Controls.Add(this.fileLoactionGroupBox);
            this.Name = "CreateDatabaseFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Database File";
            this.fileLoactionGroupBox.ResumeLayout(false);
            this.fileLoactionGroupBox.PerformLayout();
            this.fieldListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox fileLoactionGroupBox;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox fileLocation;
        private System.Windows.Forms.FlowLayoutPanel fieldListPanel;
        private System.Windows.Forms.Button addFieldBtn;
        private System.Windows.Forms.Button createDBfileBtn;
    }
}