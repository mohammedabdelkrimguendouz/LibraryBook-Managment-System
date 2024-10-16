namespace LibraryBook
{
    partial class frmMain
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.BooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.manageGenresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.manageAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBorrowingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageFinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageReservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subscriptionPeriodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.accountSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUseRInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.singOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BooksToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.subscriptionPeriodsToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1370, 58);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "Main";
            // 
            // BooksToolStripMenuItem
            // 
            this.BooksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageBooksToolStripMenuItem,
            this.manageBorrowingToolStripMenuItem,
            this.manageFinesToolStripMenuItem,
            this.manageReservationsToolStripMenuItem});
            this.BooksToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.book_50;
            this.BooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem";
            this.BooksToolStripMenuItem.Size = new System.Drawing.Size(129, 54);
            this.BooksToolStripMenuItem.Text = "Books";
            // 
            // manageBooksToolStripMenuItem
            // 
            this.manageBooksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.listBooksToolStripMenuItem,
            this.toolStripMenuItem3,
            this.manageGenresToolStripMenuItem,
            this.toolStripMenuItem4,
            this.manageAuthorsToolStripMenuItem});
            this.manageBooksToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBooksToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.book_40;
            this.manageBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageBooksToolStripMenuItem.Name = "manageBooksToolStripMenuItem";
            this.manageBooksToolStripMenuItem.Size = new System.Drawing.Size(270, 46);
            this.manageBooksToolStripMenuItem.Text = "Manage Books";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.add_book_32;
            this.addBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(222, 38);
            this.addBookToolStripMenuItem.Text = "Add Book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // listBooksToolStripMenuItem
            // 
            this.listBooksToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.book_30;
            this.listBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.listBooksToolStripMenuItem.Name = "listBooksToolStripMenuItem";
            this.listBooksToolStripMenuItem.Size = new System.Drawing.Size(222, 38);
            this.listBooksToolStripMenuItem.Text = "List Books";
            this.listBooksToolStripMenuItem.Click += new System.EventHandler(this.listBooksToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(219, 6);
            // 
            // manageGenresToolStripMenuItem
            // 
            this.manageGenresToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.Category_book_32;
            this.manageGenresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageGenresToolStripMenuItem.Name = "manageGenresToolStripMenuItem";
            this.manageGenresToolStripMenuItem.Size = new System.Drawing.Size(222, 38);
            this.manageGenresToolStripMenuItem.Text = "Manage Genres";
            this.manageGenresToolStripMenuItem.Click += new System.EventHandler(this.manageGenresToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(219, 6);
            // 
            // manageAuthorsToolStripMenuItem
            // 
            this.manageAuthorsToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.author_30;
            this.manageAuthorsToolStripMenuItem.Name = "manageAuthorsToolStripMenuItem";
            this.manageAuthorsToolStripMenuItem.Size = new System.Drawing.Size(222, 38);
            this.manageAuthorsToolStripMenuItem.Text = "Manage Authors";
            this.manageAuthorsToolStripMenuItem.Click += new System.EventHandler(this.manageAuthorsToolStripMenuItem_Click);
            // 
            // manageBorrowingToolStripMenuItem
            // 
            this.manageBorrowingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBorrowingToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.borrowing_book_40;
            this.manageBorrowingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageBorrowingToolStripMenuItem.Name = "manageBorrowingToolStripMenuItem";
            this.manageBorrowingToolStripMenuItem.Size = new System.Drawing.Size(270, 46);
            this.manageBorrowingToolStripMenuItem.Text = "Manage Borrowing";
            this.manageBorrowingToolStripMenuItem.Click += new System.EventHandler(this.manageBorrowingToolStripMenuItem_Click);
            // 
            // manageFinesToolStripMenuItem
            // 
            this.manageFinesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageFinesToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.fine_40;
            this.manageFinesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageFinesToolStripMenuItem.Name = "manageFinesToolStripMenuItem";
            this.manageFinesToolStripMenuItem.Size = new System.Drawing.Size(270, 46);
            this.manageFinesToolStripMenuItem.Text = "Manage Fines";
            this.manageFinesToolStripMenuItem.Click += new System.EventHandler(this.manageFinesToolStripMenuItem_Click);
            // 
            // manageReservationsToolStripMenuItem
            // 
            this.manageReservationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageReservationsToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.reservation_40;
            this.manageReservationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageReservationsToolStripMenuItem.Name = "manageReservationsToolStripMenuItem";
            this.manageReservationsToolStripMenuItem.Size = new System.Drawing.Size(270, 46);
            this.manageReservationsToolStripMenuItem.Text = "Manage Reservations";
            this.manageReservationsToolStripMenuItem.Click += new System.EventHandler(this.manageReservationsToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.people_50;
            this.peopleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(134, 54);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // subscriptionPeriodsToolStripMenuItem
            // 
            this.subscriptionPeriodsToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.subscription_50;
            this.subscriptionPeriodsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.subscriptionPeriodsToolStripMenuItem.Name = "subscriptionPeriodsToolStripMenuItem";
            this.subscriptionPeriodsToolStripMenuItem.Size = new System.Drawing.Size(253, 54);
            this.subscriptionPeriodsToolStripMenuItem.Text = "SubscriptionPeriods";
            this.subscriptionPeriodsToolStripMenuItem.Click += new System.EventHandler(this.subscriptionPeriodsToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.payment_50;
            this.paymentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(160, 54);
            this.paymentsToolStripMenuItem.Text = "Payments";
            this.paymentsToolStripMenuItem.Click += new System.EventHandler(this.paymentsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.Users_50;
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(122, 54);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationSettingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.accountSettingToolStripMenuItem});
            this.settingsToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.settings_50;
            this.settingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(146, 54);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // configurationSettingsToolStripMenuItem
            // 
            this.configurationSettingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configurationSettingsToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.Configuration_settings_40;
            this.configurationSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.configurationSettingsToolStripMenuItem.Name = "configurationSettingsToolStripMenuItem";
            this.configurationSettingsToolStripMenuItem.Size = new System.Drawing.Size(279, 46);
            this.configurationSettingsToolStripMenuItem.Text = "Configuration Settings";
            this.configurationSettingsToolStripMenuItem.Click += new System.EventHandler(this.configurationSettingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(276, 6);
            // 
            // accountSettingToolStripMenuItem
            // 
            this.accountSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUseRInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripMenuItem2,
            this.singOutToolStripMenuItem});
            this.accountSettingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSettingToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.account_settings_40;
            this.accountSettingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountSettingToolStripMenuItem.Name = "accountSettingToolStripMenuItem";
            this.accountSettingToolStripMenuItem.Size = new System.Drawing.Size(279, 46);
            this.accountSettingToolStripMenuItem.Text = "Account Settings";
            this.accountSettingToolStripMenuItem.Click += new System.EventHandler(this.accountSettingToolStripMenuItem_Click);
            // 
            // currentUseRInfoToolStripMenuItem
            // 
            this.currentUseRInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUseRInfoToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.info_30;
            this.currentUseRInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.currentUseRInfoToolStripMenuItem.Name = "currentUseRInfoToolStripMenuItem";
            this.currentUseRInfoToolStripMenuItem.Size = new System.Drawing.Size(200, 36);
            this.currentUseRInfoToolStripMenuItem.Text = "Current User Info";
            this.currentUseRInfoToolStripMenuItem.Click += new System.EventHandler(this.currentUseRInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.Change_password_30;
            this.changePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(200, 36);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(197, 6);
            // 
            // singOutToolStripMenuItem
            // 
            this.singOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singOutToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.log_out_30;
            this.singOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.singOutToolStripMenuItem.Name = "singOutToolStripMenuItem";
            this.singOutToolStripMenuItem.Size = new System.Drawing.Size(200, 36);
            this.singOutToolStripMenuItem.Text = "Sing Out";
            this.singOutToolStripMenuItem.Click += new System.EventHandler(this.singOutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LibraryBook.Properties.Resources.LibraryLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1370, 559);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 617);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.msMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem BooksToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subscriptionPeriodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem accountSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUseRInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem singOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBorrowingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageFinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageReservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem manageGenresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem manageAuthorsToolStripMenuItem;
    }
}

