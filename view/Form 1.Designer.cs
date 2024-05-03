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
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.addClientBtn = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.saveBtn = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.loadBtn = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.permissionsLevelSelector = new System.Windows.Forms.RibbonComboBox();
            this.readOnlyPermissionsBtn = new System.Windows.Forms.RibbonButton();
            this.nonAdminPermissionsBtn = new System.Windows.Forms.RibbonButton();
            this.adminPermissionsBtn = new System.Windows.Forms.RibbonButton();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.createDB_Btn = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator2 = new System.Windows.Forms.RibbonSeparator();
            this.selectDBLocationBtn = new System.Windows.Forms.RibbonButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.detailDisplayPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.appointmentBox = new System.Windows.Forms.GroupBox();
            this.appointmentListBox = new System.Windows.Forms.ListBox();
            this.clientSearch = new System.Windows.Forms.TextBox();
            this.ribbonDescriptionMenuItem1 = new System.Windows.Forms.RibbonDescriptionMenuItem();
            this.ribbonDescriptionMenuItem2 = new System.Windows.Forms.RibbonDescriptionMenuItem();
            this.ribbonDescriptionMenuItem3 = new System.Windows.Forms.RibbonDescriptionMenuItem();
            this.ribbonDescriptionMenuItem4 = new System.Windows.Forms.RibbonDescriptionMenuItem();
            this.ribbonDescriptionMenuItem5 = new System.Windows.Forms.RibbonDescriptionMenuItem();
            this.appointmentBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbon1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.ribbon1.Size = new System.Drawing.Size(1428, 150);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.TabSpacing = 3;
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            this.ribbonButton1.DoubleClick += new System.EventHandler(this.ribbonButton1_DoubleClick);
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
            this.ribbonPanel2.Items.Add(this.ribbonSeparator1);
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
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
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
            this.ribbonPanel3.Items.Add(this.permissionsLevelSelector);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "ribbonPanel3";
            // 
            // permissionsLevelSelector
            // 
            this.permissionsLevelSelector.AllowTextEdit = false;
            this.permissionsLevelSelector.DropDownItems.Add(this.readOnlyPermissionsBtn);
            this.permissionsLevelSelector.DropDownItems.Add(this.nonAdminPermissionsBtn);
            this.permissionsLevelSelector.DropDownItems.Add(this.adminPermissionsBtn);
            this.permissionsLevelSelector.Name = "permissionsLevelSelector";
            this.permissionsLevelSelector.SelectedIndex = 2;
            this.permissionsLevelSelector.Text = "Permissions Level";
            this.permissionsLevelSelector.TextBoxText = "Admin";
            // 
            // readOnlyPermissionsBtn
            // 
            this.readOnlyPermissionsBtn.Image = ((System.Drawing.Image)(resources.GetObject("readOnlyPermissionsBtn.Image")));
            this.readOnlyPermissionsBtn.LargeImage = ((System.Drawing.Image)(resources.GetObject("readOnlyPermissionsBtn.LargeImage")));
            this.readOnlyPermissionsBtn.Name = "readOnlyPermissionsBtn";
            this.readOnlyPermissionsBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("readOnlyPermissionsBtn.SmallImage")));
            this.readOnlyPermissionsBtn.Text = "Read Only";
            // 
            // nonAdminPermissionsBtn
            // 
            this.nonAdminPermissionsBtn.Image = ((System.Drawing.Image)(resources.GetObject("nonAdminPermissionsBtn.Image")));
            this.nonAdminPermissionsBtn.LargeImage = ((System.Drawing.Image)(resources.GetObject("nonAdminPermissionsBtn.LargeImage")));
            this.nonAdminPermissionsBtn.Name = "nonAdminPermissionsBtn";
            this.nonAdminPermissionsBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("nonAdminPermissionsBtn.SmallImage")));
            this.nonAdminPermissionsBtn.Text = "Non-Admin";
            // 
            // adminPermissionsBtn
            // 
            this.adminPermissionsBtn.Image = ((System.Drawing.Image)(resources.GetObject("adminPermissionsBtn.Image")));
            this.adminPermissionsBtn.LargeImage = ((System.Drawing.Image)(resources.GetObject("adminPermissionsBtn.LargeImage")));
            this.adminPermissionsBtn.Name = "adminPermissionsBtn";
            this.adminPermissionsBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("adminPermissionsBtn.SmallImage")));
            this.adminPermissionsBtn.Text = "Admin";
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
            this.ribbonPanel4.Items.Add(this.ribbonSeparator2);
            this.ribbonPanel4.Items.Add(this.selectDBLocationBtn);
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
            // ribbonSeparator2
            // 
            this.ribbonSeparator2.Name = "ribbonSeparator2";
            // 
            // selectDBLocationBtn
            // 
            this.selectDBLocationBtn.Image = ((System.Drawing.Image)(resources.GetObject("selectDBLocationBtn.Image")));
            this.selectDBLocationBtn.LargeImage = ((System.Drawing.Image)(resources.GetObject("selectDBLocationBtn.LargeImage")));
            this.selectDBLocationBtn.Name = "selectDBLocationBtn";
            this.selectDBLocationBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("selectDBLocationBtn.SmallImage")));
            this.selectDBLocationBtn.Text = "Set Database Location";
            this.selectDBLocationBtn.Click += new System.EventHandler(this.selectDBLocationBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(17, 191);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 500);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // detailDisplayPanel
            // 
            this.detailDisplayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailDisplayPanel.AutoScroll = true;
            this.detailDisplayPanel.Location = new System.Drawing.Point(268, 159);
            this.detailDisplayPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detailDisplayPanel.MinimumSize = new System.Drawing.Size(317, 245);
            this.detailDisplayPanel.Name = "detailDisplayPanel";
            this.detailDisplayPanel.Size = new System.Drawing.Size(772, 537);
            this.detailDisplayPanel.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(12, 27);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // appointmentBox
            // 
            this.appointmentBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentBox.Controls.Add(this.appointmentListBox);
            this.appointmentBox.Controls.Add(this.monthCalendar1);
            this.appointmentBox.Location = new System.Drawing.Point(1047, 158);
            this.appointmentBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentBox.Name = "appointmentBox";
            this.appointmentBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentBox.Size = new System.Drawing.Size(333, 533);
            this.appointmentBox.TabIndex = 3;
            this.appointmentBox.TabStop = false;
            this.appointmentBox.Text = "Appointments";
            // 
            // appointmentListBox
            // 
            this.appointmentListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentListBox.FormattingEnabled = true;
            this.appointmentListBox.ItemHeight = 16;
            this.appointmentListBox.Location = new System.Drawing.Point(12, 247);
            this.appointmentListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentListBox.Name = "appointmentListBox";
            this.appointmentListBox.Size = new System.Drawing.Size(312, 276);
            this.appointmentListBox.TabIndex = 4;
            this.appointmentListBox.SelectedIndexChanged += new System.EventHandler(this.appointmentListBox_SelectedIndexChanged);
            this.appointmentListBox.DoubleClick += new System.EventHandler(this.appointmentListBox_DoubleClick);
            // 
            // clientSearch
            // 
            this.clientSearch.Location = new System.Drawing.Point(17, 159);
            this.clientSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientSearch.MaxLength = 250;
            this.clientSearch.Name = "clientSearch";
            this.clientSearch.Size = new System.Drawing.Size(243, 22);
            this.clientSearch.TabIndex = 4;
            this.clientSearch.TextChanged += new System.EventHandler(this.clientSearch_TextChanged);
            // 
            // ribbonDescriptionMenuItem1
            // 
            this.ribbonDescriptionMenuItem1.DescriptionBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ribbonDescriptionMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonDescriptionMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem1.Image")));
            this.ribbonDescriptionMenuItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem1.LargeImage")));
            this.ribbonDescriptionMenuItem1.Name = "ribbonDescriptionMenuItem1";
            this.ribbonDescriptionMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem1.SmallImage")));
            this.ribbonDescriptionMenuItem1.Text = "ribbonDescriptionMenuItem1";
            // 
            // ribbonDescriptionMenuItem2
            // 
            this.ribbonDescriptionMenuItem2.DescriptionBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ribbonDescriptionMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonDescriptionMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem2.Image")));
            this.ribbonDescriptionMenuItem2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem2.LargeImage")));
            this.ribbonDescriptionMenuItem2.Name = "ribbonDescriptionMenuItem2";
            this.ribbonDescriptionMenuItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem2.SmallImage")));
            this.ribbonDescriptionMenuItem2.Text = "ribbonDescriptionMenuItem2";
            // 
            // ribbonDescriptionMenuItem3
            // 
            this.ribbonDescriptionMenuItem3.DescriptionBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ribbonDescriptionMenuItem3.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonDescriptionMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem3.Image")));
            this.ribbonDescriptionMenuItem3.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem3.LargeImage")));
            this.ribbonDescriptionMenuItem3.Name = "ribbonDescriptionMenuItem3";
            this.ribbonDescriptionMenuItem3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem3.SmallImage")));
            this.ribbonDescriptionMenuItem3.Text = "ribbonDescriptionMenuItem3";
            // 
            // ribbonDescriptionMenuItem4
            // 
            this.ribbonDescriptionMenuItem4.DescriptionBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ribbonDescriptionMenuItem4.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonDescriptionMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem4.Image")));
            this.ribbonDescriptionMenuItem4.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem4.LargeImage")));
            this.ribbonDescriptionMenuItem4.Name = "ribbonDescriptionMenuItem4";
            this.ribbonDescriptionMenuItem4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem4.SmallImage")));
            this.ribbonDescriptionMenuItem4.Text = "ribbonDescriptionMenuItem4";
            // 
            // ribbonDescriptionMenuItem5
            // 
            this.ribbonDescriptionMenuItem5.DescriptionBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ribbonDescriptionMenuItem5.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonDescriptionMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem5.Image")));
            this.ribbonDescriptionMenuItem5.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem5.LargeImage")));
            this.ribbonDescriptionMenuItem5.Name = "ribbonDescriptionMenuItem5";
            this.ribbonDescriptionMenuItem5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem5.SmallImage")));
            this.ribbonDescriptionMenuItem5.Text = "ribbonDescriptionMenuItem5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 708);
            this.Controls.Add(this.clientSearch);
            this.Controls.Add(this.appointmentBox);
            this.Controls.Add(this.detailDisplayPanel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ribbon1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Main Window";
            this.appointmentBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FlowLayoutPanel detailDisplayPanel;
        private System.Windows.Forms.RibbonButton addClientBtn;
        private System.Windows.Forms.RibbonButton saveBtn;
        private System.Windows.Forms.RibbonButton loadBtn;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton createDB_Btn;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton selectDBLocationBtn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox appointmentBox;
        private System.Windows.Forms.ListBox appointmentListBox;
        private System.Windows.Forms.TextBox clientSearch;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator2;
        private System.Windows.Forms.RibbonDescriptionMenuItem ribbonDescriptionMenuItem1;
        private System.Windows.Forms.RibbonDescriptionMenuItem ribbonDescriptionMenuItem2;
        private System.Windows.Forms.RibbonDescriptionMenuItem ribbonDescriptionMenuItem3;
        private System.Windows.Forms.RibbonDescriptionMenuItem ribbonDescriptionMenuItem4;
        private System.Windows.Forms.RibbonDescriptionMenuItem ribbonDescriptionMenuItem5;
        private System.Windows.Forms.RibbonComboBox permissionsLevelSelector;
        private System.Windows.Forms.RibbonButton readOnlyPermissionsBtn;
        private System.Windows.Forms.RibbonButton nonAdminPermissionsBtn;
        private System.Windows.Forms.RibbonButton adminPermissionsBtn;
    }
}

