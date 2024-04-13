namespace Final_Year_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.addClientBtn = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.saveBtn = new System.Windows.Forms.RibbonButton();
            this.loadBtn = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.createDB_Btn = new System.Windows.Forms.RibbonButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.detailDisplayPanel = new System.Windows.Forms.Panel();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010_Extended;
            this.ribbon1.OrbVisible = false;
            // 
            // 
            // 
            this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButton1);
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1009, 122);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.TabSpacing = 3;
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Panels.Add(this.ribbonPanel3);
            this.ribbonTab1.Text = "ribbonTab1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.addClientBtn);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "Clients";
            // 
            // addClientBtn
            // 
            this.addClientBtn.Image = ((System.Drawing.Image)(resources.GetObject("addClientBtn.Image")));
            this.addClientBtn.LargeImage = ((System.Drawing.Image)(resources.GetObject("addClientBtn.LargeImage")));
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("addClientBtn.SmallImage")));
            this.addClientBtn.Text = "Add Client";
            this.addClientBtn.Click += new System.EventHandler(this.addClientBtn_DoubleClick);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.saveBtn);
            this.ribbonPanel2.Items.Add(this.loadBtn);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "Save/Load";
            // 
            // saveBtn
            // 
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.LargeImage = ((System.Drawing.Image)(resources.GetObject("saveBtn.LargeImage")));
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("saveBtn.SmallImage")));
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Image = ((System.Drawing.Image)(resources.GetObject("loadBtn.Image")));
            this.loadBtn.LargeImage = ((System.Drawing.Image)(resources.GetObject("loadBtn.LargeImage")));
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("loadBtn.SmallImage")));
            this.loadBtn.Text = "Load";
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "ribbonPanel3";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Panels.Add(this.ribbonPanel4);
            this.ribbonTab2.Text = "ribbonTab2";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.createDB_Btn);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Text = "DataBase";
            // 
            // createDB_Btn
            // 
            this.createDB_Btn.Image = ((System.Drawing.Image)(resources.GetObject("createDB_Btn.Image")));
            this.createDB_Btn.LargeImage = ((System.Drawing.Image)(resources.GetObject("createDB_Btn.LargeImage")));
            this.createDB_Btn.Name = "createDB_Btn";
            this.createDB_Btn.SmallImage = ((System.Drawing.Image)(resources.GetObject("createDB_Btn.SmallImage")));
            this.createDB_Btn.Text = "Create";
            this.createDB_Btn.Click += new System.EventHandler(this.createDB_Btn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 129);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 433);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // detailDisplayPanel
            // 
            this.detailDisplayPanel.AutoScroll = true;
            this.detailDisplayPanel.Location = new System.Drawing.Point(208, 128);
            this.detailDisplayPanel.Name = "detailDisplayPanel";
            this.detailDisplayPanel.Size = new System.Drawing.Size(543, 433);
            this.detailDisplayPanel.TabIndex = 2;
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 575);
            this.Controls.Add(this.detailDisplayPanel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ribbon1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Main Window";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel detailDisplayPanel;
        private System.Windows.Forms.RibbonButton addClientBtn;
        private System.Windows.Forms.RibbonButton saveBtn;
        private System.Windows.Forms.RibbonButton loadBtn;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton createDB_Btn;
        private System.Windows.Forms.RibbonButton ribbonButton1;
    }
}

