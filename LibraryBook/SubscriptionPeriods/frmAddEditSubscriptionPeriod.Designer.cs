namespace LibraryBook.SubscriptionPeriods
{
    partial class frmAddEditSubscriptionPeriod
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
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tcSubscriptionPeriod = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlPersonCardInfoWithFilter1 = new LibraryBook.People.Controls.ctrlPersonCardInfoWithFilter();
            this.tpSubscriptionPeriodInfo = new System.Windows.Forms.TabPage();
            this.pSubscriptionPeriodInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.rbAnnualSubscription = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbMonthlySubscription = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.nudNumberOfMonth = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbGender = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblEndDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblStartDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox8 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPaymentAmount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblPaymentID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCreatedByUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblSubscriptionPeriodID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.tcSubscriptionPeriod.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpSubscriptionPeriodInfo.SuspendLayout();
            this.pSubscriptionPeriodInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(94, -8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(526, 49);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add New Subscription Period";
            // 
            // tcSubscriptionPeriod
            // 
            this.tcSubscriptionPeriod.Controls.Add(this.tpPersonInfo);
            this.tcSubscriptionPeriod.Controls.Add(this.tpSubscriptionPeriodInfo);
            this.tcSubscriptionPeriod.ItemSize = new System.Drawing.Size(180, 40);
            this.tcSubscriptionPeriod.Location = new System.Drawing.Point(10, 37);
            this.tcSubscriptionPeriod.Name = "tcSubscriptionPeriod";
            this.tcSubscriptionPeriod.SelectedIndex = 0;
            this.tcSubscriptionPeriod.Size = new System.Drawing.Size(705, 604);
            this.tcSubscriptionPeriod.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcSubscriptionPeriod.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcSubscriptionPeriod.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcSubscriptionPeriod.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcSubscriptionPeriod.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcSubscriptionPeriod.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcSubscriptionPeriod.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcSubscriptionPeriod.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcSubscriptionPeriod.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcSubscriptionPeriod.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcSubscriptionPeriod.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcSubscriptionPeriod.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcSubscriptionPeriod.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcSubscriptionPeriod.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcSubscriptionPeriod.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcSubscriptionPeriod.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcSubscriptionPeriod.TabIndex = 2;
            this.tcSubscriptionPeriod.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcSubscriptionPeriod.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Controls.Add(this.ctrlPersonCardInfoWithFilter1);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 44);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(697, 556);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Animated = true;
            this.btnNext.BorderRadius = 10;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Image = global::LibraryBook.Properties.Resources.Next_32;
            this.btnNext.Location = new System.Drawing.Point(547, 512);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(143, 41);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonCardInfoWithFilter1
            // 
            this.ctrlPersonCardInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardInfoWithFilter1.EnableFilter = true;
            this.ctrlPersonCardInfoWithFilter1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonCardInfoWithFilter1.Location = new System.Drawing.Point(6, 3);
            this.ctrlPersonCardInfoWithFilter1.Name = "ctrlPersonCardInfoWithFilter1";
            this.ctrlPersonCardInfoWithFilter1.ShowAddNewPerson = true;
            this.ctrlPersonCardInfoWithFilter1.Size = new System.Drawing.Size(684, 508);
            this.ctrlPersonCardInfoWithFilter1.TabIndex = 0;
            // 
            // tpSubscriptionPeriodInfo
            // 
            this.tpSubscriptionPeriodInfo.Controls.Add(this.pSubscriptionPeriodInfo);
            this.tpSubscriptionPeriodInfo.Location = new System.Drawing.Point(4, 44);
            this.tpSubscriptionPeriodInfo.Name = "tpSubscriptionPeriodInfo";
            this.tpSubscriptionPeriodInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpSubscriptionPeriodInfo.Size = new System.Drawing.Size(697, 556);
            this.tpSubscriptionPeriodInfo.TabIndex = 1;
            this.tpSubscriptionPeriodInfo.Text = "Subscription Period Info";
            this.tpSubscriptionPeriodInfo.UseVisualStyleBackColor = true;
            // 
            // pSubscriptionPeriodInfo
            // 
            this.pSubscriptionPeriodInfo.Controls.Add(this.rbAnnualSubscription);
            this.pSubscriptionPeriodInfo.Controls.Add(this.rbMonthlySubscription);
            this.pSubscriptionPeriodInfo.Controls.Add(this.btnBack);
            this.pSubscriptionPeriodInfo.Controls.Add(this.nudNumberOfMonth);
            this.pSubscriptionPeriodInfo.Controls.Add(this.txtNotes);
            this.pSubscriptionPeriodInfo.Controls.Add(this.pbGender);
            this.pSubscriptionPeriodInfo.Controls.Add(this.lblEndDate);
            this.pSubscriptionPeriodInfo.Controls.Add(this.guna2PictureBox4);
            this.pSubscriptionPeriodInfo.Controls.Add(this.guna2HtmlLabel4);
            this.pSubscriptionPeriodInfo.Controls.Add(this.lblStartDate);
            this.pSubscriptionPeriodInfo.Controls.Add(this.guna2PictureBox8);
            this.pSubscriptionPeriodInfo.Controls.Add(this.guna2HtmlLabel11);
            this.pSubscriptionPeriodInfo.Controls.Add(this.lblPaymentAmount);
            this.pSubscriptionPeriodInfo.Controls.Add(this.guna2PictureBox7);
            this.pSubscriptionPeriodInfo.Controls.Add(this.guna2HtmlLabel9);
            this.pSubscriptionPeriodInfo.Controls.Add(this.guna2HtmlLabel3);
            this.pSubscriptionPeriodInfo.Controls.Add(this.guna2PictureBox2);
            this.pSubscriptionPeriodInfo.Controls.Add(this.lblPaymentID);
            this.pSubscriptionPeriodInfo.Controls.Add(this.guna2HtmlLabel2);
            this.pSubscriptionPeriodInfo.Controls.Add(this.lblCreatedByUser);
            this.pSubscriptionPeriodInfo.Controls.Add(this.guna2PictureBox3);
            this.pSubscriptionPeriodInfo.Controls.Add(this.guna2HtmlLabel1);
            this.pSubscriptionPeriodInfo.Controls.Add(this.guna2PictureBox1);
            this.pSubscriptionPeriodInfo.Controls.Add(this.lblSubscriptionPeriodID);
            this.pSubscriptionPeriodInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSubscriptionPeriodInfo.Location = new System.Drawing.Point(3, 3);
            this.pSubscriptionPeriodInfo.Name = "pSubscriptionPeriodInfo";
            this.pSubscriptionPeriodInfo.Size = new System.Drawing.Size(691, 550);
            this.pSubscriptionPeriodInfo.TabIndex = 0;
            // 
            // rbAnnualSubscription
            // 
            this.rbAnnualSubscription.AutoSize = true;
            this.rbAnnualSubscription.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAnnualSubscription.CheckedState.BorderThickness = 0;
            this.rbAnnualSubscription.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAnnualSubscription.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAnnualSubscription.CheckedState.InnerOffset = -4;
            this.rbAnnualSubscription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnnualSubscription.Location = new System.Drawing.Point(316, 152);
            this.rbAnnualSubscription.Name = "rbAnnualSubscription";
            this.rbAnnualSubscription.Size = new System.Drawing.Size(168, 25);
            this.rbAnnualSubscription.TabIndex = 84;
            this.rbAnnualSubscription.Text = "Annual Subscription";
            this.rbAnnualSubscription.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAnnualSubscription.UncheckedState.BorderThickness = 2;
            this.rbAnnualSubscription.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAnnualSubscription.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbAnnualSubscription.CheckedChanged += new System.EventHandler(this.rbAnnualSubscription_CheckedChanged);
            // 
            // rbMonthlySubscription
            // 
            this.rbMonthlySubscription.AutoSize = true;
            this.rbMonthlySubscription.Checked = true;
            this.rbMonthlySubscription.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMonthlySubscription.CheckedState.BorderThickness = 0;
            this.rbMonthlySubscription.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMonthlySubscription.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbMonthlySubscription.CheckedState.InnerOffset = -4;
            this.rbMonthlySubscription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMonthlySubscription.Location = new System.Drawing.Point(316, 121);
            this.rbMonthlySubscription.Name = "rbMonthlySubscription";
            this.rbMonthlySubscription.Size = new System.Drawing.Size(177, 25);
            this.rbMonthlySubscription.TabIndex = 83;
            this.rbMonthlySubscription.TabStop = true;
            this.rbMonthlySubscription.Text = "Monthly Subscription";
            this.rbMonthlySubscription.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbMonthlySubscription.UncheckedState.BorderThickness = 2;
            this.rbMonthlySubscription.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbMonthlySubscription.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.BorderRadius = 10;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Image = global::LibraryBook.Properties.Resources.Prev_32;
            this.btnBack.Location = new System.Drawing.Point(545, 506);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 41);
            this.btnBack.TabIndex = 82;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // nudNumberOfMonth
            // 
            this.nudNumberOfMonth.BackColor = System.Drawing.Color.Transparent;
            this.nudNumberOfMonth.BorderRadius = 8;
            this.nudNumberOfMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudNumberOfMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudNumberOfMonth.Location = new System.Drawing.Point(522, 131);
            this.nudNumberOfMonth.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nudNumberOfMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfMonth.Name = "nudNumberOfMonth";
            this.nudNumberOfMonth.Size = new System.Drawing.Size(92, 36);
            this.nudNumberOfMonth.TabIndex = 80;
            this.nudNumberOfMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfMonth.ValueChanged += new System.EventHandler(this.nudNumberOfMonth_ValueChanged);
            // 
            // txtNotes
            // 
            this.txtNotes.Animated = true;
            this.txtNotes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNotes.BorderRadius = 10;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNotes.ForeColor = System.Drawing.Color.Black;
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Location = new System.Drawing.Point(212, 359);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNotes.PlaceholderText = "Notes";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(369, 95);
            this.txtNotes.TabIndex = 79;
            this.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbGender
            // 
            this.pbGender.Image = global::LibraryBook.Properties.Resources.Notes__2__32;
            this.pbGender.ImageRotate = 0F;
            this.pbGender.Location = new System.Drawing.Point(178, 359);
            this.pbGender.Name = "pbGender";
            this.pbGender.Size = new System.Drawing.Size(30, 27);
            this.pbGender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGender.TabIndex = 78;
            this.pbGender.TabStop = false;
            // 
            // lblEndDate
            // 
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(212, 225);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(49, 27);
            this.lblEndDate.TabIndex = 74;
            this.lblEndDate.Text = "[????]";
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = global::LibraryBook.Properties.Resources.calendar_32;
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(176, 225);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(30, 27);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 75;
            this.guna2PictureBox4.TabStop = false;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(82, 225);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(88, 27);
            this.guna2HtmlLabel4.TabIndex = 73;
            this.guna2HtmlLabel4.Text = "End Date :";
            // 
            // lblStartDate
            // 
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(212, 181);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(49, 27);
            this.lblStartDate.TabIndex = 71;
            this.lblStartDate.Text = "[????]";
            // 
            // guna2PictureBox8
            // 
            this.guna2PictureBox8.Image = global::LibraryBook.Properties.Resources.calendar_32;
            this.guna2PictureBox8.ImageRotate = 0F;
            this.guna2PictureBox8.Location = new System.Drawing.Point(176, 181);
            this.guna2PictureBox8.Name = "guna2PictureBox8";
            this.guna2PictureBox8.Size = new System.Drawing.Size(30, 27);
            this.guna2PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox8.TabIndex = 72;
            this.guna2PictureBox8.TabStop = false;
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(75, 181);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(95, 27);
            this.guna2HtmlLabel11.TabIndex = 70;
            this.guna2HtmlLabel11.Text = "Start Date :";
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentAmount.Location = new System.Drawing.Point(212, 269);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(14, 27);
            this.lblPaymentAmount.TabIndex = 68;
            this.lblPaymentAmount.Text = "0";
            // 
            // guna2PictureBox7
            // 
            this.guna2PictureBox7.Image = global::LibraryBook.Properties.Resources.money_32;
            this.guna2PictureBox7.ImageRotate = 0F;
            this.guna2PictureBox7.Location = new System.Drawing.Point(176, 269);
            this.guna2PictureBox7.Name = "guna2PictureBox7";
            this.guna2PictureBox7.Size = new System.Drawing.Size(30, 27);
            this.guna2PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox7.TabIndex = 69;
            this.guna2PictureBox7.TabStop = false;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(13, 269);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(157, 27);
            this.guna2HtmlLabel9.TabIndex = 67;
            this.guna2HtmlLabel9.Text = "Payment Amount :";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(62, 99);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(108, 27);
            this.guna2HtmlLabel3.TabIndex = 64;
            this.guna2HtmlLabel3.Text = "Payment ID :";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::LibraryBook.Properties.Resources.id_32;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(176, 99);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(30, 27);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 66;
            this.guna2PictureBox2.TabStop = false;
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentID.Location = new System.Drawing.Point(212, 99);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(49, 27);
            this.lblPaymentID.TabIndex = 65;
            this.lblPaymentID.Text = "[????]";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(24, 313);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(146, 27);
            this.guna2HtmlLabel2.TabIndex = 61;
            this.guna2HtmlLabel2.Text = "Created By User :";
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.Location = new System.Drawing.Point(212, 313);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(49, 27);
            this.lblCreatedByUser.TabIndex = 62;
            this.lblCreatedByUser.Text = "[????]";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::LibraryBook.Properties.Resources.username_32;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(176, 313);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(30, 27);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 63;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(66, 55);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(104, 27);
            this.guna2HtmlLabel1.TabIndex = 31;
            this.guna2HtmlLabel1.Text = "S.Period ID :";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::LibraryBook.Properties.Resources.id_32;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(176, 55);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(30, 27);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 33;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lblSubscriptionPeriodID
            // 
            this.lblSubscriptionPeriodID.BackColor = System.Drawing.Color.Transparent;
            this.lblSubscriptionPeriodID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubscriptionPeriodID.Location = new System.Drawing.Point(212, 55);
            this.lblSubscriptionPeriodID.Name = "lblSubscriptionPeriodID";
            this.lblSubscriptionPeriodID.Size = new System.Drawing.Size(49, 27);
            this.lblSubscriptionPeriodID.TabIndex = 32;
            this.lblSubscriptionPeriodID.Text = "[????]";
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
            this.btnClose.Location = new System.Drawing.Point(415, 640);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 41);
            this.btnClose.TabIndex = 14;
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
            this.btnSave.Location = new System.Drawing.Point(564, 640);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 41);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditSubscriptionPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 684);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcSubscriptionPeriod);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditSubscriptionPeriod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Subscription Period";
            this.Load += new System.EventHandler(this.frmAddEditSubscriptionPeriod_Load);
            this.tcSubscriptionPeriod.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpSubscriptionPeriodInfo.ResumeLayout(false);
            this.pSubscriptionPeriodInfo.ResumeLayout(false);
            this.pSubscriptionPeriodInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl tcSubscriptionPeriod;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpSubscriptionPeriodInfo;
        private Guna.UI2.WinForms.Guna2Panel pSubscriptionPeriodInfo;
        private People.Controls.ctrlPersonCardInfoWithFilter ctrlPersonCardInfoWithFilter1;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubscriptionPeriodID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCreatedByUser;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPaymentID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPaymentAmount;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEndDate;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStartDate;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2PictureBox pbGender;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNumberOfMonth;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2RadioButton rbMonthlySubscription;
        private Guna.UI2.WinForms.Guna2RadioButton rbAnnualSubscription;
    }
}