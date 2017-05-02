namespace Hall_management_System_sdp
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.webCamStudentIdentificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallStudentMealBillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mealTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mealStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mealPriceSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserType = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterEntryToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.webCamStudentIdentificationToolStripMenuItem,
            this.hallStudentMealBillingToolStripMenuItem,
            this.mealTypeToolStripMenuItem,
            this.mealStockToolStripMenuItem,
            this.mealPriceSettingToolStripMenuItem,
            this.logoutToolStripMenuItem1,
            this.aboutToolStripMenuItem,
            this.supplierEntryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // masterEntryToolStripMenuItem
            // 
            this.masterEntryToolStripMenuItem.Name = "masterEntryToolStripMenuItem";
            this.masterEntryToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.masterEntryToolStripMenuItem.Text = "Hall Student Regstration";
            this.masterEntryToolStripMenuItem.Click += new System.EventHandler(this.masterEntryToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrationToolStripMenuItem,
            this.logsToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registrationToolStripMenuItem.Text = "Registration";
            this.registrationToolStripMenuItem.Click += new System.EventHandler(this.registrationToolStripMenuItem_Click);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logsToolStripMenuItem.Text = "Logs";
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.logsToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem1,
            this.restoreToolStripMenuItem1});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // backupToolStripMenuItem1
            // 
            this.backupToolStripMenuItem1.Name = "backupToolStripMenuItem1";
            this.backupToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.backupToolStripMenuItem1.Text = "Backup";
            this.backupToolStripMenuItem1.Click += new System.EventHandler(this.backupToolStripMenuItem1_Click);
            // 
            // restoreToolStripMenuItem1
            // 
            this.restoreToolStripMenuItem1.Name = "restoreToolStripMenuItem1";
            this.restoreToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.restoreToolStripMenuItem1.Text = "Restore";
            this.restoreToolStripMenuItem1.Click += new System.EventHandler(this.restoreToolStripMenuItem1_Click);
            // 
            // webCamStudentIdentificationToolStripMenuItem
            // 
            this.webCamStudentIdentificationToolStripMenuItem.Name = "webCamStudentIdentificationToolStripMenuItem";
            this.webCamStudentIdentificationToolStripMenuItem.Size = new System.Drawing.Size(188, 20);
            this.webCamStudentIdentificationToolStripMenuItem.Text = "Web Cam Student Identification";
            this.webCamStudentIdentificationToolStripMenuItem.Click += new System.EventHandler(this.webCamStudentIdentificationToolStripMenuItem_Click);
            // 
            // hallStudentMealBillingToolStripMenuItem
            // 
            this.hallStudentMealBillingToolStripMenuItem.Name = "hallStudentMealBillingToolStripMenuItem";
            this.hallStudentMealBillingToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.hallStudentMealBillingToolStripMenuItem.Text = "Hall Student Meal Billing";
            this.hallStudentMealBillingToolStripMenuItem.Click += new System.EventHandler(this.hallStudentMealBillingToolStripMenuItem_Click);
            // 
            // mealTypeToolStripMenuItem
            // 
            this.mealTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.subCategoryToolStripMenuItem});
            this.mealTypeToolStripMenuItem.Name = "mealTypeToolStripMenuItem";
            this.mealTypeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.mealTypeToolStripMenuItem.Text = "Meal Type";
            this.mealTypeToolStripMenuItem.Click += new System.EventHandler(this.mealTypeToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click_1);
            // 
            // subCategoryToolStripMenuItem
            // 
            this.subCategoryToolStripMenuItem.Name = "subCategoryToolStripMenuItem";
            this.subCategoryToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.subCategoryToolStripMenuItem.Text = "SubCategory";
            this.subCategoryToolStripMenuItem.Click += new System.EventHandler(this.subCategoryToolStripMenuItem_Click_1);
            // 
            // mealStockToolStripMenuItem
            // 
            this.mealStockToolStripMenuItem.Name = "mealStockToolStripMenuItem";
            this.mealStockToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.mealStockToolStripMenuItem.Text = "Meal Stock";
            this.mealStockToolStripMenuItem.Click += new System.EventHandler(this.mealStockToolStripMenuItem_Click);
            // 
            // mealPriceSettingToolStripMenuItem
            // 
            this.mealPriceSettingToolStripMenuItem.Name = "mealPriceSettingToolStripMenuItem";
            this.mealPriceSettingToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.mealPriceSettingToolStripMenuItem.Text = "Meal Price Setting";
            this.mealPriceSettingToolStripMenuItem.Click += new System.EventHandler(this.mealPriceSettingToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // supplierEntryToolStripMenuItem
            // 
            this.supplierEntryToolStripMenuItem.Name = "supplierEntryToolStripMenuItem";
            this.supplierEntryToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.supplierEntryToolStripMenuItem.Text = "Supplier Entry";
            this.supplierEntryToolStripMenuItem.Click += new System.EventHandler(this.supplierEntryToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.lblUser,
            this.toolStripStatusLabel2,
            this.lblUserType,
            this.toolStripStatusLabel3,
            this.lblTime});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 562);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(1262, 22);
            this.StatusStrip1.TabIndex = 4;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(86, 17);
            this.ToolStripStatusLabel1.Text = "Logged in As :";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Image = ((System.Drawing.Image)(resources.GetObject("lblUser.Image")));
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(145, 17);
            this.lblUser.Text = "ToolStripStatusLabel2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = ":";
            // 
            // lblUserType
            // 
            this.lblUserType.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(124, 17);
            this.lblUserType.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(758, 17);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(124, 17);
            this.lblTime.Text = "toolStripStatusLabel5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(807, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 89;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hall Management System";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel lblUserType;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        internal System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.ToolStripMenuItem masterEntryToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webCamStudentIdentificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallStudentMealBillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mealTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mealStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mealPriceSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierEntryToolStripMenuItem;
    }
}