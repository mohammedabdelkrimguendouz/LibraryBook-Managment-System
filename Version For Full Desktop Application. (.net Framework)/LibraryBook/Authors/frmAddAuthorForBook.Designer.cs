namespace LibraryBook.Authors.Controls
{
    partial class frmAddAuthorForBook
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tcAddAuthorForBook = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpBookInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.tpAuthorInfo = new System.Windows.Forms.TabPage();
            this.pAuthoreInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.pbPersonImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlBookCardInfoWithFilter1 = new LibraryBook.Books.controls.ctrlBookCardInfoWithFilter();
            this.ctrlAuthorCardInfoWithFilter1 = new LibraryBook.Authors.Controls.ctrlAuthorCardInfoWithFilter();
            this.tcAddAuthorForBook.SuspendLayout();
            this.tpBookInfo.SuspendLayout();
            this.tpAuthorInfo.SuspendLayout();
            this.pAuthoreInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(413, 654);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 32);
            this.btnClose.TabIndex = 21;
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
            this.btnSave.Enabled = false;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::LibraryBook.Properties.Resources.Save_;
            this.btnSave.Location = new System.Drawing.Point(566, 654);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 32);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(152, -4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(385, 49);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Add Author For Book";
            // 
            // tcAddAuthorForBook
            // 
            this.tcAddAuthorForBook.Controls.Add(this.tpBookInfo);
            this.tcAddAuthorForBook.Controls.Add(this.tpAuthorInfo);
            this.tcAddAuthorForBook.ItemSize = new System.Drawing.Size(180, 40);
            this.tcAddAuthorForBook.Location = new System.Drawing.Point(12, 41);
            this.tcAddAuthorForBook.Name = "tcAddAuthorForBook";
            this.tcAddAuthorForBook.SelectedIndex = 0;
            this.tcAddAuthorForBook.Size = new System.Drawing.Size(707, 615);
            this.tcAddAuthorForBook.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcAddAuthorForBook.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcAddAuthorForBook.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcAddAuthorForBook.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcAddAuthorForBook.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcAddAuthorForBook.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcAddAuthorForBook.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcAddAuthorForBook.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcAddAuthorForBook.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcAddAuthorForBook.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcAddAuthorForBook.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcAddAuthorForBook.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcAddAuthorForBook.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcAddAuthorForBook.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcAddAuthorForBook.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcAddAuthorForBook.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcAddAuthorForBook.TabIndex = 23;
            this.tcAddAuthorForBook.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcAddAuthorForBook.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpBookInfo
            // 
            this.tpBookInfo.Controls.Add(this.btnNext);
            this.tpBookInfo.Controls.Add(this.ctrlBookCardInfoWithFilter1);
            this.tpBookInfo.Location = new System.Drawing.Point(4, 44);
            this.tpBookInfo.Name = "tpBookInfo";
            this.tpBookInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookInfo.Size = new System.Drawing.Size(699, 567);
            this.tpBookInfo.TabIndex = 0;
            this.tpBookInfo.Text = "Book Info";
            this.tpBookInfo.UseVisualStyleBackColor = true;
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
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Image = global::LibraryBook.Properties.Resources.Next_32;
            this.btnNext.Location = new System.Drawing.Point(550, 530);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(143, 33);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpAuthorInfo
            // 
            this.tpAuthorInfo.Controls.Add(this.pAuthoreInfo);
            this.tpAuthorInfo.Location = new System.Drawing.Point(4, 44);
            this.tpAuthorInfo.Name = "tpAuthorInfo";
            this.tpAuthorInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpAuthorInfo.Size = new System.Drawing.Size(699, 567);
            this.tpAuthorInfo.TabIndex = 1;
            this.tpAuthorInfo.Text = "Authore Info";
            this.tpAuthorInfo.UseVisualStyleBackColor = true;
            // 
            // pAuthoreInfo
            // 
            this.pAuthoreInfo.Controls.Add(this.pbPersonImage);
            this.pAuthoreInfo.Controls.Add(this.btnBack);
            this.pAuthoreInfo.Controls.Add(this.ctrlAuthorCardInfoWithFilter1);
            this.pAuthoreInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAuthoreInfo.Enabled = false;
            this.pAuthoreInfo.Location = new System.Drawing.Point(3, 3);
            this.pAuthoreInfo.Name = "pAuthoreInfo";
            this.pAuthoreInfo.Size = new System.Drawing.Size(693, 561);
            this.pAuthoreInfo.TabIndex = 0;
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackColor = System.Drawing.Color.Transparent;
            this.pbPersonImage.Image = global::LibraryBook.Properties.Resources.author_100;
            this.pbPersonImage.ImageRotate = 0F;
            this.pbPersonImage.Location = new System.Drawing.Point(3, 27);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(165, 414);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 29;
            this.pbPersonImage.TabStop = false;
            this.pbPersonImage.UseTransparentBackground = true;
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
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Image = global::LibraryBook.Properties.Resources.Prev_32;
            this.btnBack.Location = new System.Drawing.Point(547, 525);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 33);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ctrlBookCardInfoWithFilter1
            // 
            this.ctrlBookCardInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlBookCardInfoWithFilter1.EnableFilter = true;
            this.ctrlBookCardInfoWithFilter1.Location = new System.Drawing.Point(6, 6);
            this.ctrlBookCardInfoWithFilter1.Name = "ctrlBookCardInfoWithFilter1";
            this.ctrlBookCardInfoWithFilter1.ShowAddNewBook = true;
            this.ctrlBookCardInfoWithFilter1.Size = new System.Drawing.Size(692, 526);
            this.ctrlBookCardInfoWithFilter1.TabIndex = 0;
            // 
            // ctrlAuthorCardInfoWithFilter1
            // 
            this.ctrlAuthorCardInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlAuthorCardInfoWithFilter1.EnableFilter = true;
            this.ctrlAuthorCardInfoWithFilter1.Location = new System.Drawing.Point(166, 16);
            this.ctrlAuthorCardInfoWithFilter1.Name = "ctrlAuthorCardInfoWithFilter1";
            this.ctrlAuthorCardInfoWithFilter1.ShowAddNewAuthor = true;
            this.ctrlAuthorCardInfoWithFilter1.Size = new System.Drawing.Size(524, 425);
            this.ctrlAuthorCardInfoWithFilter1.TabIndex = 27;
            this.ctrlAuthorCardInfoWithFilter1.OnAuthorSelected += new System.EventHandler<LibraryBook.Authors.Controls.ctrlAuthorCardInfoWithFilter.AuthorSelectedEventArgs>(this.ctrlAuthorCardInfoWithFilter1_OnAuthorSelected);
            // 
            // frmAddAuthorForBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 692);
            this.Controls.Add(this.tcAddAuthorForBook);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddAuthorForBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Author For Book";
            this.Load += new System.EventHandler(this.frmAddAuthorForBook_Load);
            this.tcAddAuthorForBook.ResumeLayout(false);
            this.tpBookInfo.ResumeLayout(false);
            this.tpAuthorInfo.ResumeLayout(false);
            this.pAuthoreInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl tcAddAuthorForBook;
        private System.Windows.Forms.TabPage tpBookInfo;
        private System.Windows.Forms.TabPage tpAuthorInfo;
        private Books.controls.ctrlBookCardInfoWithFilter ctrlBookCardInfoWithFilter1;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Panel pAuthoreInfo;
        private Guna.UI2.WinForms.Guna2PictureBox pbPersonImage;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private ctrlAuthorCardInfoWithFilter ctrlAuthorCardInfoWithFilter1;
    }
}