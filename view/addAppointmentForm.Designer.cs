namespace Final_Year_Project
{
    partial class addAppointmentForm
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
            this.ClinetNAmeTexBox = new System.Windows.Forms.GroupBox();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.notesGroupBox = new System.Windows.Forms.GroupBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.ClinetNAmeTexBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.notesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClinetNAmeTexBox
            // 
            this.ClinetNAmeTexBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClinetNAmeTexBox.Controls.Add(this.clientTextBox);
            this.ClinetNAmeTexBox.Location = new System.Drawing.Point(13, 13);
            this.ClinetNAmeTexBox.Name = "ClinetNAmeTexBox";
            this.ClinetNAmeTexBox.Size = new System.Drawing.Size(429, 56);
            this.ClinetNAmeTexBox.TabIndex = 0;
            this.ClinetNAmeTexBox.TabStop = false;
            this.ClinetNAmeTexBox.Text = "Client";
            // 
            // clientTextBox
            // 
            this.clientTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientTextBox.Location = new System.Drawing.Point(6, 21);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.ReadOnly = true;
            this.clientTextBox.Size = new System.Drawing.Size(415, 22);
            this.clientTextBox.TabIndex = 0;
            this.clientTextBox.Text = "Client Should be passed from main form";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(13, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(414, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // notesGroupBox
            // 
            this.notesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesGroupBox.Controls.Add(this.notesTextBox);
            this.notesGroupBox.Location = new System.Drawing.Point(13, 139);
            this.notesGroupBox.Name = "notesGroupBox";
            this.notesGroupBox.Size = new System.Drawing.Size(427, 368);
            this.notesGroupBox.TabIndex = 2;
            this.notesGroupBox.TabStop = false;
            this.notesGroupBox.Text = "Additional Notes";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTextBox.Location = new System.Drawing.Point(7, 22);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(414, 340);
            this.notesTextBox.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Location = new System.Drawing.Point(13, 514);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(427, 42);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Create Appointment";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 568);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.notesGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClinetNAmeTexBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "addAppointmentForm";
            this.Text = "New Appointment";
            this.ClinetNAmeTexBox.ResumeLayout(false);
            this.ClinetNAmeTexBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.notesGroupBox.ResumeLayout(false);
            this.notesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ClinetNAmeTexBox;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox notesGroupBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Button addBtn;
    }
}