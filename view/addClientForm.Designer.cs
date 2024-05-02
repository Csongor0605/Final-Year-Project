namespace Final_Year_Project
{
    partial class addClientForm
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
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addClientBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 317);
            this.panel1.TabIndex = 0;
            // 
            // addClientBtn
            // 
            this.addClientBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addClientBtn.Location = new System.Drawing.Point(9, 342);
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.Size = new System.Drawing.Size(348, 37);
            this.addClientBtn.TabIndex = 1;
            this.addClientBtn.Text = "Add Client";
            this.addClientBtn.UseVisualStyleBackColor = true;
            this.addClientBtn.Click += new System.EventHandler(this.addClientBtn_Click);
            // 
            // addClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 391);
            this.Controls.Add(this.addClientBtn);
            this.Controls.Add(this.panel1);
            this.Name = "addClientForm";
            this.Text = "Add Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel1;
        private System.Windows.Forms.Button addClientBtn;
    }
}