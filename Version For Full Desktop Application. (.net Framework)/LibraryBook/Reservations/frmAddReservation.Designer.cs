namespace LibraryBook.Reservations
{
    partial class frmAddReservation
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
            this.tcReservation = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpBookInfo = new System.Windows.Forms.TabPage();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbLanguages = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pbCoverImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnNextToPersonInfo = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlBookCardInfoWithFilter1 = new LibraryBook.Books.controls.ctrlBookCardInfoWithFilter();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.pPersonInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnNextToReservationInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnBackToBookInfo = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlPersonCardInfoWithFilter1 = new LibraryBook.People.Controls.ctrlPersonCardInfoWithFilter();
            this.tpReservationInfo = new System.Windows.Forms.TabPage();
            this.pReservationInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblReservationStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblReservationDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCreatedByUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox10 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox9 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblReservationID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnBackToPersonInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnReserve = new Guna.UI2.WinForms.Guna2Button();
            this.tcReservation.SuspendLayout();
            this.tpBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverImage)).BeginInit();
            this.tpPersonInfo.SuspendLayout();
            this.pPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.tpReservationInfo.SuspendLayout();
            this.pReservationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(198, -11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(526, 49);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Add New Reservation";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tcReservation
            // 
            this.tcReservation.Controls.Add(this.tpBookInfo);
            this.tcReservation.Controls.Add(this.tpPersonInfo);
            this.tcReservation.Controls.Add(this.tpReservationInfo);
            this.tcReservation.ItemSize = new System.Drawing.Size(180, 40);
            this.tcReservation.Location = new System.Drawing.Point(12, 35);
            this.tcReservation.Name = "tcReservation";
            this.tcReservation.SelectedIndex = 0;
            this.tcReservation.Size = new System.Drawing.Size(884, 612);
            this.tcReservation.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcReservation.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcReservation.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcReservation.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcReservation.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcReservation.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcReservation.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcReservation.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcReservation.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcReservation.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcReservation.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcReservation.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcReservation.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcReservation.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcReservation.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcReservation.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcReservation.TabIndex = 3;
            this.tcReservation.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcReservation.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpBookInfo
            // 
            this.tpBookInfo.Controls.Add(this.guna2PictureBox3);
            this.tpBookInfo.Controls.Add(this.cbLanguages);
            this.tpBookInfo.Controls.Add(this.pbCoverImage);
            this.tpBookInfo.Controls.Add(this.btnNextToPersonInfo);
            this.tpBookInfo.Controls.Add(this.ctrlBookCardInfoWithFilter1);
            this.tpBookInfo.Location = new System.Drawing.Point(4, 44);
            this.tpBookInfo.Name = "tpBookInfo";
            this.tpBookInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookInfo.Size = new System.Drawing.Size(876, 564);
            this.tpBookInfo.TabIndex = 0;
            this.tpBookInfo.Text = "Book Info";
            this.tpBookInfo.UseVisualStyleBackColor = true;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::LibraryBook.Properties.Resources.languages_32;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(758, 364);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(30, 27);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 68;
            this.guna2PictureBox3.TabStop = false;
            // 
            // cbLanguages
            // 
            this.cbLanguages.BackColor = System.Drawing.Color.Transparent;
            this.cbLanguages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguages.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLanguages.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLanguages.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbLanguages.ForeColor = System.Drawing.Color.Black;
            this.cbLanguages.ItemHeight = 30;
            this.cbLanguages.Location = new System.Drawing.Point(687, 397);
            this.cbLanguages.Name = "cbLanguages";
            this.cbLanguages.Size = new System.Drawing.Size(186, 36);
            this.cbLanguages.TabIndex = 67;
            // 
            // pbCoverImage
            // 
            this.pbCoverImage.BackColor = System.Drawing.Color.Transparent;
            this.pbCoverImage.Image = global::LibraryBook.Properties.Resources.book_100;
            this.pbCoverImage.ImageRotate = 0F;
            this.pbCoverImage.Location = new System.Drawing.Point(702, 35);
            this.pbCoverImage.Name = "pbCoverImage";
            this.pbCoverImage.Size = new System.Drawing.Size(143, 311);
            this.pbCoverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCoverImage.TabIndex = 66;
            this.pbCoverImage.TabStop = false;
            this.pbCoverImage.UseTransparentBackground = true;
            // 
            // btnNextToPersonInfo
            // 
            this.btnNextToPersonInfo.Animated = true;
            this.btnNextToPersonInfo.BorderRadius = 10;
            this.btnNextToPersonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextToPersonInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNextToPersonInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNextToPersonInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNextToPersonInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNextToPersonInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNextToPersonInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNextToPersonInfo.ForeColor = System.Drawing.Color.Black;
            this.btnNextToPersonInfo.Image = global::LibraryBook.Properties.Resources.Next_32;
            this.btnNextToPersonInfo.Location = new System.Drawing.Point(727, 517);
            this.btnNextToPersonInfo.Name = "btnNextToPersonInfo";
            this.btnNextToPersonInfo.Size = new System.Drawing.Size(143, 41);
            this.btnNextToPersonInfo.TabIndex = 16;
            this.btnNextToPersonInfo.Text = "Next";
            this.btnNextToPersonInfo.Click += new System.EventHandler(this.btnNextToPersonInfo_Click);
            // 
            // ctrlBookCardInfoWithFilter1
            // 
            this.ctrlBookCardInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlBookCardInfoWithFilter1.EnableFilter = true;
            this.ctrlBookCardInfoWithFilter1.Location = new System.Drawing.Point(4, 6);
            this.ctrlBookCardInfoWithFilter1.Name = "ctrlBookCardInfoWithFilter1";
            this.ctrlBookCardInfoWithFilter1.ShowAddNewBook = true;
            this.ctrlBookCardInfoWithFilter1.Size = new System.Drawing.Size(692, 526);
            this.ctrlBookCardInfoWithFilter1.TabIndex = 0;
            this.ctrlBookCardInfoWithFilter1.OnBookSelected += new System.EventHandler<LibraryBook.Books.controls.ctrlBookCardInfoWithFilter.BookSelectedEventArgs>(this.ctrlBookCardInfoWithFilter1_OnBookSelected);
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.pPersonInfo);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 44);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(876, 564);
            this.tpPersonInfo.TabIndex = 1;
            this.tpPersonInfo.Text = "Person Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // pPersonInfo
            // 
            this.pPersonInfo.Controls.Add(this.guna2PictureBox4);
            this.pPersonInfo.Controls.Add(this.btnNextToReservationInfo);
            this.pPersonInfo.Controls.Add(this.btnBackToBookInfo);
            this.pPersonInfo.Controls.Add(this.ctrlPersonCardInfoWithFilter1);
            this.pPersonInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPersonInfo.Enabled = false;
            this.pPersonInfo.Location = new System.Drawing.Point(3, 3);
            this.pPersonInfo.Name = "pPersonInfo";
            this.pPersonInfo.Size = new System.Drawing.Size(870, 558);
            this.pPersonInfo.TabIndex = 16;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.Image = global::LibraryBook.Properties.Resources.people_100;
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(703, 98);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(143, 283);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 65;
            this.guna2PictureBox4.TabStop = false;
            this.guna2PictureBox4.UseTransparentBackground = true;
            // 
            // btnNextToReservationInfo
            // 
            this.btnNextToReservationInfo.Animated = true;
            this.btnNextToReservationInfo.BorderRadius = 10;
            this.btnNextToReservationInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextToReservationInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNextToReservationInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNextToReservationInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNextToReservationInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNextToReservationInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNextToReservationInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNextToReservationInfo.ForeColor = System.Drawing.Color.Black;
            this.btnNextToReservationInfo.Image = global::LibraryBook.Properties.Resources.Next_32;
            this.btnNextToReservationInfo.Location = new System.Drawing.Point(724, 514);
            this.btnNextToReservationInfo.Name = "btnNextToReservationInfo";
            this.btnNextToReservationInfo.Size = new System.Drawing.Size(143, 41);
            this.btnNextToReservationInfo.TabIndex = 19;
            this.btnNextToReservationInfo.Text = "Next";
            this.btnNextToReservationInfo.Click += new System.EventHandler(this.btnNextToReservationInfo_Click);
            // 
            // btnBackToBookInfo
            // 
            this.btnBackToBookInfo.Animated = true;
            this.btnBackToBookInfo.BorderRadius = 10;
            this.btnBackToBookInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToBookInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackToBookInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackToBookInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackToBookInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackToBookInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBackToBookInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBackToBookInfo.ForeColor = System.Drawing.Color.Black;
            this.btnBackToBookInfo.Image = global::LibraryBook.Properties.Resources.Prev_32;
            this.btnBackToBookInfo.Location = new System.Drawing.Point(724, 467);
            this.btnBackToBookInfo.Name = "btnBackToBookInfo";
            this.btnBackToBookInfo.Size = new System.Drawing.Size(143, 41);
            this.btnBackToBookInfo.TabIndex = 18;
            this.btnBackToBookInfo.Text = "Back";
            this.btnBackToBookInfo.Click += new System.EventHandler(this.btnBackToBookInfo_Click);
            // 
            // ctrlPersonCardInfoWithFilter1
            // 
            this.ctrlPersonCardInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardInfoWithFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlPersonCardInfoWithFilter1.EnableFilter = true;
            this.ctrlPersonCardInfoWithFilter1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonCardInfoWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlPersonCardInfoWithFilter1.Name = "ctrlPersonCardInfoWithFilter1";
            this.ctrlPersonCardInfoWithFilter1.ShowAddNewPerson = true;
            this.ctrlPersonCardInfoWithFilter1.Size = new System.Drawing.Size(870, 558);
            this.ctrlPersonCardInfoWithFilter1.TabIndex = 17;
            // 
            // tpReservationInfo
            // 
            this.tpReservationInfo.Controls.Add(this.pReservationInfo);
            this.tpReservationInfo.Location = new System.Drawing.Point(4, 44);
            this.tpReservationInfo.Name = "tpReservationInfo";
            this.tpReservationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpReservationInfo.Size = new System.Drawing.Size(876, 564);
            this.tpReservationInfo.TabIndex = 2;
            this.tpReservationInfo.Text = "Reservation Info";
            this.tpReservationInfo.UseVisualStyleBackColor = true;
            // 
            // pReservationInfo
            // 
            this.pReservationInfo.Controls.Add(this.lblReservationStatus);
            this.pReservationInfo.Controls.Add(this.lblReservationDate);
            this.pReservationInfo.Controls.Add(this.guna2PictureBox2);
            this.pReservationInfo.Controls.Add(this.guna2HtmlLabel1);
            this.pReservationInfo.Controls.Add(this.guna2PictureBox1);
            this.pReservationInfo.Controls.Add(this.guna2HtmlLabel2);
            this.pReservationInfo.Controls.Add(this.lblCreatedByUser);
            this.pReservationInfo.Controls.Add(this.guna2PictureBox5);
            this.pReservationInfo.Controls.Add(this.guna2HtmlLabel7);
            this.pReservationInfo.Controls.Add(this.guna2PictureBox10);
            this.pReservationInfo.Controls.Add(this.guna2HtmlLabel6);
            this.pReservationInfo.Controls.Add(this.guna2PictureBox9);
            this.pReservationInfo.Controls.Add(this.lblReservationID);
            this.pReservationInfo.Controls.Add(this.btnBackToPersonInfo);
            this.pReservationInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pReservationInfo.Enabled = false;
            this.pReservationInfo.Location = new System.Drawing.Point(3, 3);
            this.pReservationInfo.Name = "pReservationInfo";
            this.pReservationInfo.Size = new System.Drawing.Size(870, 558);
            this.pReservationInfo.TabIndex = 0;
            // 
            // lblReservationStatus
            // 
            this.lblReservationStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblReservationStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationStatus.Location = new System.Drawing.Point(321, 331);
            this.lblReservationStatus.Name = "lblReservationStatus";
            this.lblReservationStatus.Size = new System.Drawing.Size(49, 27);
            this.lblReservationStatus.TabIndex = 160;
            this.lblReservationStatus.Text = "[????]";
            // 
            // lblReservationDate
            // 
            this.lblReservationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReservationDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationDate.Location = new System.Drawing.Point(321, 288);
            this.lblReservationDate.Name = "lblReservationDate";
            this.lblReservationDate.Size = new System.Drawing.Size(49, 27);
            this.lblReservationDate.TabIndex = 159;
            this.lblReservationDate.Text = "[????]";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::LibraryBook.Properties.Resources.reservation_100;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(47, 18);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(809, 200);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 152;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(118, 331);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(166, 27);
            this.guna2HtmlLabel1.TabIndex = 148;
            this.guna2HtmlLabel1.Text = "Reservation Status :";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::LibraryBook.Properties.Resources.status_32;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(287, 333);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(30, 27);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 150;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(138, 374);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(146, 27);
            this.guna2HtmlLabel2.TabIndex = 145;
            this.guna2HtmlLabel2.Text = "Created By User :";
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.Location = new System.Drawing.Point(321, 377);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(49, 27);
            this.lblCreatedByUser.TabIndex = 146;
            this.lblCreatedByUser.Text = "[????]";
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.Image = global::LibraryBook.Properties.Resources.username_32;
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Location = new System.Drawing.Point(287, 377);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.Size = new System.Drawing.Size(30, 27);
            this.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox5.TabIndex = 147;
            this.guna2PictureBox5.TabStop = false;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(130, 288);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(154, 27);
            this.guna2HtmlLabel7.TabIndex = 142;
            this.guna2HtmlLabel7.Text = "Reservation Date :";
            // 
            // guna2PictureBox10
            // 
            this.guna2PictureBox10.Image = global::LibraryBook.Properties.Resources.calendar_32;
            this.guna2PictureBox10.ImageRotate = 0F;
            this.guna2PictureBox10.Location = new System.Drawing.Point(287, 289);
            this.guna2PictureBox10.Name = "guna2PictureBox10";
            this.guna2PictureBox10.Size = new System.Drawing.Size(30, 27);
            this.guna2PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox10.TabIndex = 144;
            this.guna2PictureBox10.TabStop = false;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(151, 245);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(133, 27);
            this.guna2HtmlLabel6.TabIndex = 139;
            this.guna2HtmlLabel6.Text = "Reservation ID :";
            // 
            // guna2PictureBox9
            // 
            this.guna2PictureBox9.Image = global::LibraryBook.Properties.Resources.id_32;
            this.guna2PictureBox9.ImageRotate = 0F;
            this.guna2PictureBox9.Location = new System.Drawing.Point(287, 245);
            this.guna2PictureBox9.Name = "guna2PictureBox9";
            this.guna2PictureBox9.Size = new System.Drawing.Size(30, 27);
            this.guna2PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox9.TabIndex = 141;
            this.guna2PictureBox9.TabStop = false;
            // 
            // lblReservationID
            // 
            this.lblReservationID.BackColor = System.Drawing.Color.Transparent;
            this.lblReservationID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationID.Location = new System.Drawing.Point(321, 245);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(49, 27);
            this.lblReservationID.TabIndex = 140;
            this.lblReservationID.Text = "[????]";
            // 
            // btnBackToPersonInfo
            // 
            this.btnBackToPersonInfo.Animated = true;
            this.btnBackToPersonInfo.BorderRadius = 10;
            this.btnBackToPersonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToPersonInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackToPersonInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackToPersonInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackToPersonInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackToPersonInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBackToPersonInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBackToPersonInfo.ForeColor = System.Drawing.Color.Black;
            this.btnBackToPersonInfo.Image = global::LibraryBook.Properties.Resources.Prev_32;
            this.btnBackToPersonInfo.Location = new System.Drawing.Point(724, 511);
            this.btnBackToPersonInfo.Name = "btnBackToPersonInfo";
            this.btnBackToPersonInfo.Size = new System.Drawing.Size(143, 41);
            this.btnBackToPersonInfo.TabIndex = 17;
            this.btnBackToPersonInfo.Text = "Back";
            this.btnBackToPersonInfo.Click += new System.EventHandler(this.btnBackToPersonInfo_Click);
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
            this.btnClose.Location = new System.Drawing.Point(594, 649);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 41);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Animated = true;
            this.btnReserve.BorderRadius = 10;
            this.btnReserve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReserve.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReserve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReserve.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReserve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReserve.Enabled = false;
            this.btnReserve.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReserve.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.ForeColor = System.Drawing.Color.Black;
            this.btnReserve.Image = global::LibraryBook.Properties.Resources.reservation_32;
            this.btnReserve.Location = new System.Drawing.Point(743, 649);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(143, 41);
            this.btnReserve.TabIndex = 17;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // frmAddEditReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(898, 692);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcReservation);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Reservation";
            this.Load += new System.EventHandler(this.frmAddEditReservation_Load);
            this.tcReservation.ResumeLayout(false);
            this.tpBookInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverImage)).EndInit();
            this.tpPersonInfo.ResumeLayout(false);
            this.pPersonInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.tpReservationInfo.ResumeLayout(false);
            this.pReservationInfo.ResumeLayout(false);
            this.pReservationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl tcReservation;
        private System.Windows.Forms.TabPage tpBookInfo;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpReservationInfo;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Books.controls.ctrlBookCardInfoWithFilter ctrlBookCardInfoWithFilter1;
        private Guna.UI2.WinForms.Guna2Button btnNextToPersonInfo;
        private Guna.UI2.WinForms.Guna2Panel pReservationInfo;
        private Guna.UI2.WinForms.Guna2Button btnBackToPersonInfo;
        private Guna.UI2.WinForms.Guna2Panel pPersonInfo;
        private Guna.UI2.WinForms.Guna2Button btnBackToBookInfo;
        private People.Controls.ctrlPersonCardInfoWithFilter ctrlPersonCardInfoWithFilter1;
        private Guna.UI2.WinForms.Guna2Button btnNextToReservationInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCreatedByUser;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox9;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblReservationID;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblReservationDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblReservationStatus;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2ComboBox cbLanguages;
        private Guna.UI2.WinForms.Guna2PictureBox pbCoverImage;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2Button btnReserve;
    }
}