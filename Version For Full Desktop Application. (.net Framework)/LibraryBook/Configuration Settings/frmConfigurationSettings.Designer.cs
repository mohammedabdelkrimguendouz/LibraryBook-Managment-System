namespace LibraryBook.ConfigurationSettings
{
    partial class frmConfigurationSettings
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nudDefualtBorrrowDays = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudDefaultNumberOfBorrowedBooks = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nudDefaultNumberOfDaysWaitingForABookReserved = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDefaultFinePerDay = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDefaultMonthlySubscriptionAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDefaultAnnualSubscriptionAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nudDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefualtBorrrowDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultNumberOfBorrowedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultNumberOfDaysWaitingForABookReserved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 87);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(191, 27);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Defualt Borrrow Days :";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(142, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(397, 52);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Configuration Settings";
            // 
            // nudDefualtBorrrowDays
            // 
            this.nudDefualtBorrrowDays.BackColor = System.Drawing.Color.Transparent;
            this.nudDefualtBorrrowDays.BorderRadius = 6;
            this.nudDefualtBorrrowDays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudDefualtBorrrowDays.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudDefualtBorrrowDays.Location = new System.Drawing.Point(242, 87);
            this.nudDefualtBorrrowDays.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudDefualtBorrrowDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDefualtBorrrowDays.Name = "nudDefualtBorrrowDays";
            this.nudDefualtBorrrowDays.Size = new System.Drawing.Size(100, 36);
            this.nudDefualtBorrrowDays.TabIndex = 19;
            this.nudDefualtBorrrowDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDefaultNumberOfBorrowedBooks
            // 
            this.nudDefaultNumberOfBorrowedBooks.BackColor = System.Drawing.Color.Transparent;
            this.nudDefaultNumberOfBorrowedBooks.BorderRadius = 6;
            this.nudDefaultNumberOfBorrowedBooks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudDefaultNumberOfBorrowedBooks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudDefaultNumberOfBorrowedBooks.Location = new System.Drawing.Point(347, 138);
            this.nudDefaultNumberOfBorrowedBooks.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudDefaultNumberOfBorrowedBooks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDefaultNumberOfBorrowedBooks.Name = "nudDefaultNumberOfBorrowedBooks";
            this.nudDefaultNumberOfBorrowedBooks.Size = new System.Drawing.Size(100, 36);
            this.nudDefaultNumberOfBorrowedBooks.TabIndex = 21;
            this.nudDefaultNumberOfBorrowedBooks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(11, 140);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(314, 27);
            this.guna2HtmlLabel2.TabIndex = 20;
            this.guna2HtmlLabel2.Text = "Default Number Of Borrowed Books :";
            // 
            // nudDefaultNumberOfDaysWaitingForABookReserved
            // 
            this.nudDefaultNumberOfDaysWaitingForABookReserved.BackColor = System.Drawing.Color.Transparent;
            this.nudDefaultNumberOfDaysWaitingForABookReserved.BorderRadius = 6;
            this.nudDefaultNumberOfDaysWaitingForABookReserved.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudDefaultNumberOfDaysWaitingForABookReserved.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudDefaultNumberOfDaysWaitingForABookReserved.Location = new System.Drawing.Point(483, 193);
            this.nudDefaultNumberOfDaysWaitingForABookReserved.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudDefaultNumberOfDaysWaitingForABookReserved.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDefaultNumberOfDaysWaitingForABookReserved.Name = "nudDefaultNumberOfDaysWaitingForABookReserved";
            this.nudDefaultNumberOfDaysWaitingForABookReserved.Size = new System.Drawing.Size(100, 36);
            this.nudDefaultNumberOfDaysWaitingForABookReserved.TabIndex = 23;
            this.nudDefaultNumberOfDaysWaitingForABookReserved.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(12, 193);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(465, 27);
            this.guna2HtmlLabel3.TabIndex = 22;
            this.guna2HtmlLabel3.Text = "Default Number Of Days Waiting For A Book Reserved :";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(12, 299);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(183, 27);
            this.guna2HtmlLabel4.TabIndex = 24;
            this.guna2HtmlLabel4.Text = "Default Fine Per Day :";
            // 
            // txtDefaultFinePerDay
            // 
            this.txtDefaultFinePerDay.Animated = true;
            this.txtDefaultFinePerDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDefaultFinePerDay.BorderRadius = 10;
            this.txtDefaultFinePerDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDefaultFinePerDay.DefaultText = "";
            this.txtDefaultFinePerDay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDefaultFinePerDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDefaultFinePerDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDefaultFinePerDay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDefaultFinePerDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDefaultFinePerDay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDefaultFinePerDay.ForeColor = System.Drawing.Color.Black;
            this.txtDefaultFinePerDay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDefaultFinePerDay.Location = new System.Drawing.Point(205, 291);
            this.txtDefaultFinePerDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDefaultFinePerDay.Name = "txtDefaultFinePerDay";
            this.txtDefaultFinePerDay.PasswordChar = '\0';
            this.txtDefaultFinePerDay.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDefaultFinePerDay.PlaceholderText = "";
            this.txtDefaultFinePerDay.SelectedText = "";
            this.txtDefaultFinePerDay.Size = new System.Drawing.Size(279, 40);
            this.txtDefaultFinePerDay.TabIndex = 26;
            this.txtDefaultFinePerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDefaultFinePerDay.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBoxAndIsNumber);
            // 
            // txtDefaultMonthlySubscriptionAmount
            // 
            this.txtDefaultMonthlySubscriptionAmount.Animated = true;
            this.txtDefaultMonthlySubscriptionAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDefaultMonthlySubscriptionAmount.BorderRadius = 10;
            this.txtDefaultMonthlySubscriptionAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDefaultMonthlySubscriptionAmount.DefaultText = "";
            this.txtDefaultMonthlySubscriptionAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDefaultMonthlySubscriptionAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDefaultMonthlySubscriptionAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDefaultMonthlySubscriptionAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDefaultMonthlySubscriptionAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDefaultMonthlySubscriptionAmount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDefaultMonthlySubscriptionAmount.ForeColor = System.Drawing.Color.Black;
            this.txtDefaultMonthlySubscriptionAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDefaultMonthlySubscriptionAmount.Location = new System.Drawing.Point(347, 339);
            this.txtDefaultMonthlySubscriptionAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDefaultMonthlySubscriptionAmount.Name = "txtDefaultMonthlySubscriptionAmount";
            this.txtDefaultMonthlySubscriptionAmount.PasswordChar = '\0';
            this.txtDefaultMonthlySubscriptionAmount.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDefaultMonthlySubscriptionAmount.PlaceholderText = "";
            this.txtDefaultMonthlySubscriptionAmount.SelectedText = "";
            this.txtDefaultMonthlySubscriptionAmount.Size = new System.Drawing.Size(279, 40);
            this.txtDefaultMonthlySubscriptionAmount.TabIndex = 28;
            this.txtDefaultMonthlySubscriptionAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDefaultMonthlySubscriptionAmount.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBoxAndIsNumber);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(11, 352);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(330, 27);
            this.guna2HtmlLabel5.TabIndex = 27;
            this.guna2HtmlLabel5.Text = "Default Monthly Subscription Amount :";
            // 
            // txtDefaultAnnualSubscriptionAmount
            // 
            this.txtDefaultAnnualSubscriptionAmount.Animated = true;
            this.txtDefaultAnnualSubscriptionAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDefaultAnnualSubscriptionAmount.BorderRadius = 10;
            this.txtDefaultAnnualSubscriptionAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDefaultAnnualSubscriptionAmount.DefaultText = "";
            this.txtDefaultAnnualSubscriptionAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDefaultAnnualSubscriptionAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDefaultAnnualSubscriptionAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDefaultAnnualSubscriptionAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDefaultAnnualSubscriptionAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDefaultAnnualSubscriptionAmount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDefaultAnnualSubscriptionAmount.ForeColor = System.Drawing.Color.Black;
            this.txtDefaultAnnualSubscriptionAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDefaultAnnualSubscriptionAmount.Location = new System.Drawing.Point(347, 398);
            this.txtDefaultAnnualSubscriptionAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDefaultAnnualSubscriptionAmount.Name = "txtDefaultAnnualSubscriptionAmount";
            this.txtDefaultAnnualSubscriptionAmount.PasswordChar = '\0';
            this.txtDefaultAnnualSubscriptionAmount.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDefaultAnnualSubscriptionAmount.PlaceholderText = "";
            this.txtDefaultAnnualSubscriptionAmount.SelectedText = "";
            this.txtDefaultAnnualSubscriptionAmount.Size = new System.Drawing.Size(279, 40);
            this.txtDefaultAnnualSubscriptionAmount.TabIndex = 30;
            this.txtDefaultAnnualSubscriptionAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDefaultAnnualSubscriptionAmount.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBoxAndIsNumber);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(12, 405);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(320, 27);
            this.guna2HtmlLabel6.TabIndex = 29;
            this.guna2HtmlLabel6.Text = "Default Annual Subscription Amount :";
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BorderRadius = 10;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::LibraryBook.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(410, 470);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 41);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 10;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::LibraryBook.Properties.Resources.Save_;
            this.btnSave.Location = new System.Drawing.Point(569, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 41);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // nudDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod
            // 
            this.nudDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod.BackColor = System.Drawing.Color.Transparent;
            this.nudDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod.BorderRadius = 6;
            this.nudDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod.Location = new System.Drawing.Point(612, 246);
            this.nudDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod.Name = "nudDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod";
            this.nudDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod.Size = new System.Drawing.Size(100, 36);
            this.nudDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod.TabIndex = 34;
            this.nudDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(11, 246);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(584, 27);
            this.guna2HtmlLabel7.TabIndex = 33;
            this.guna2HtmlLabel7.Text = "Default Number Of Days Allowed To Cancel The Subscription Period :";
            // 
            // frmConfigurationSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 523);
            this.Controls.Add(this.nudDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDefaultAnnualSubscriptionAmount);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.txtDefaultMonthlySubscriptionAmount);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.txtDefaultFinePerDay);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.nudDefaultNumberOfDaysWaitingForABookReserved);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.nudDefaultNumberOfBorrowedBooks);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.nudDefualtBorrrowDays);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConfigurationSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration Settings";
            this.Load += new System.EventHandler(this.frmConfigurationSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDefualtBorrrowDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultNumberOfBorrowedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultNumberOfDaysWaitingForABookReserved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudDefualtBorrrowDays;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudDefaultNumberOfBorrowedBooks;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudDefaultNumberOfDaysWaitingForABookReserved;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtDefaultFinePerDay;
        private Guna.UI2.WinForms.Guna2TextBox txtDefaultMonthlySubscriptionAmount;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtDefaultAnnualSubscriptionAmount;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudDefaultNumberOfDaysAllowedToCancelTheSubscriptionPeriod;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
    }
}