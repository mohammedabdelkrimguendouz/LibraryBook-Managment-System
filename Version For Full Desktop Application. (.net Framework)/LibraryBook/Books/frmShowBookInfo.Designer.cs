namespace LibraryBook.Books
{
    partial class frmShowBookInfo
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
            this.tpAuthorsAndCopies = new System.Windows.Forms.TabPage();
            this.btnAddBookCopy = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ctrlListCopiesForBook1 = new LibraryBook.Book_Copies.ctrlListCopiesForBook();
            this.ctrlListAuthorsForBook1 = new LibraryBook.Authors.Controls.ctrlListAuthorsForBook();
            this.tpBookInfo = new System.Windows.Forms.TabPage();
            this.pbCoverImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlBookCardInfo1 = new LibraryBook.Books.controls.ctrlBookCardInfo();
            this.tcBookInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddAuthorForBook = new Guna.UI2.WinForms.Guna2Button();
            this.tpAuthorsAndCopies.SuspendLayout();
            this.tpBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverImage)).BeginInit();
            this.tcBookInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpAuthorsAndCopies
            // 
            this.tpAuthorsAndCopies.Controls.Add(this.btnAddAuthorForBook);
            this.tpAuthorsAndCopies.Controls.Add(this.btnAddBookCopy);
            this.tpAuthorsAndCopies.Controls.Add(this.btnBack);
            this.tpAuthorsAndCopies.Controls.Add(this.guna2HtmlLabel7);
            this.tpAuthorsAndCopies.Controls.Add(this.guna2HtmlLabel6);
            this.tpAuthorsAndCopies.Controls.Add(this.ctrlListCopiesForBook1);
            this.tpAuthorsAndCopies.Controls.Add(this.ctrlListAuthorsForBook1);
            this.tpAuthorsAndCopies.Location = new System.Drawing.Point(4, 44);
            this.tpAuthorsAndCopies.Name = "tpAuthorsAndCopies";
            this.tpAuthorsAndCopies.Padding = new System.Windows.Forms.Padding(3);
            this.tpAuthorsAndCopies.Size = new System.Drawing.Size(942, 488);
            this.tpAuthorsAndCopies.TabIndex = 1;
            this.tpAuthorsAndCopies.Text = "Authors & Copies";
            this.tpAuthorsAndCopies.UseVisualStyleBackColor = true;
            // 
            // btnAddBookCopy
            // 
            this.btnAddBookCopy.Animated = true;
            this.btnAddBookCopy.BorderRadius = 10;
            this.btnAddBookCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBookCopy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBookCopy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBookCopy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddBookCopy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddBookCopy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddBookCopy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddBookCopy.ForeColor = System.Drawing.Color.Black;
            this.btnAddBookCopy.Image = global::LibraryBook.Properties.Resources.add_32;
            this.btnAddBookCopy.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddBookCopy.Location = new System.Drawing.Point(410, 6);
            this.btnAddBookCopy.Name = "btnAddBookCopy";
            this.btnAddBookCopy.Size = new System.Drawing.Size(49, 34);
            this.btnAddBookCopy.TabIndex = 100;
            this.btnAddBookCopy.Click += new System.EventHandler(this.btnAddBookCopy_Click);
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
            this.btnBack.Location = new System.Drawing.Point(789, 441);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 41);
            this.btnBack.TabIndex = 99;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(482, 13);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(180, 27);
            this.guna2HtmlLabel7.TabIndex = 98;
            this.guna2HtmlLabel7.Text = "List Book Authors : ";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(6, 13);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(167, 27);
            this.guna2HtmlLabel6.TabIndex = 97;
            this.guna2HtmlLabel6.Text = "List Book Copies : ";
            // 
            // ctrlListCopiesForBook1
            // 
            this.ctrlListCopiesForBook1.BackColor = System.Drawing.Color.White;
            this.ctrlListCopiesForBook1.Location = new System.Drawing.Point(9, 46);
            this.ctrlListCopiesForBook1.Name = "ctrlListCopiesForBook1";
            this.ctrlListCopiesForBook1.Size = new System.Drawing.Size(450, 372);
            this.ctrlListCopiesForBook1.TabIndex = 1;
            // 
            // ctrlListAuthorsForBook1
            // 
            this.ctrlListAuthorsForBook1.BackColor = System.Drawing.Color.White;
            this.ctrlListAuthorsForBook1.Location = new System.Drawing.Point(482, 46);
            this.ctrlListAuthorsForBook1.Name = "ctrlListAuthorsForBook1";
            this.ctrlListAuthorsForBook1.Size = new System.Drawing.Size(450, 372);
            this.ctrlListAuthorsForBook1.TabIndex = 0;
            // 
            // tpBookInfo
            // 
            this.tpBookInfo.Controls.Add(this.pbCoverImage);
            this.tpBookInfo.Controls.Add(this.btnNext);
            this.tpBookInfo.Controls.Add(this.ctrlBookCardInfo1);
            this.tpBookInfo.Location = new System.Drawing.Point(4, 44);
            this.tpBookInfo.Name = "tpBookInfo";
            this.tpBookInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookInfo.Size = new System.Drawing.Size(942, 488);
            this.tpBookInfo.TabIndex = 0;
            this.tpBookInfo.Text = "Book Info";
            this.tpBookInfo.UseVisualStyleBackColor = true;
            // 
            // pbCoverImage
            // 
            this.pbCoverImage.BackColor = System.Drawing.Color.Transparent;
            this.pbCoverImage.Image = global::LibraryBook.Properties.Resources.book_100;
            this.pbCoverImage.ImageRotate = 0F;
            this.pbCoverImage.Location = new System.Drawing.Point(3, 6);
            this.pbCoverImage.Name = "pbCoverImage";
            this.pbCoverImage.Size = new System.Drawing.Size(263, 421);
            this.pbCoverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCoverImage.TabIndex = 101;
            this.pbCoverImage.TabStop = false;
            this.pbCoverImage.UseTransparentBackground = true;
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
            this.btnNext.Image = global::LibraryBook.Properties.Resources.Prev_32;
            this.btnNext.Location = new System.Drawing.Point(789, 441);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(143, 41);
            this.btnNext.TabIndex = 100;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlBookCardInfo1
            // 
            this.ctrlBookCardInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlBookCardInfo1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlBookCardInfo1.Location = new System.Drawing.Point(272, 6);
            this.ctrlBookCardInfo1.Name = "ctrlBookCardInfo1";
            this.ctrlBookCardInfo1.Size = new System.Drawing.Size(661, 421);
            this.ctrlBookCardInfo1.TabIndex = 0;
            // 
            // tcBookInfo
            // 
            this.tcBookInfo.Controls.Add(this.tpBookInfo);
            this.tcBookInfo.Controls.Add(this.tpAuthorsAndCopies);
            this.tcBookInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcBookInfo.ItemSize = new System.Drawing.Size(180, 40);
            this.tcBookInfo.Location = new System.Drawing.Point(0, 0);
            this.tcBookInfo.Name = "tcBookInfo";
            this.tcBookInfo.SelectedIndex = 0;
            this.tcBookInfo.Size = new System.Drawing.Size(950, 536);
            this.tcBookInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcBookInfo.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcBookInfo.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcBookInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcBookInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcBookInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcBookInfo.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcBookInfo.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcBookInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcBookInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcBookInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcBookInfo.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcBookInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcBookInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcBookInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcBookInfo.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcBookInfo.TabIndex = 11;
            this.tcBookInfo.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcBookInfo.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
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
            this.btnClose.Location = new System.Drawing.Point(793, 542);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 41);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddAuthorForBook
            // 
            this.btnAddAuthorForBook.Animated = true;
            this.btnAddAuthorForBook.BorderRadius = 10;
            this.btnAddAuthorForBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAuthorForBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAuthorForBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAuthorForBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddAuthorForBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddAuthorForBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddAuthorForBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddAuthorForBook.ForeColor = System.Drawing.Color.Black;
            this.btnAddAuthorForBook.Image = global::LibraryBook.Properties.Resources.add_32;
            this.btnAddAuthorForBook.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddAuthorForBook.Location = new System.Drawing.Point(883, 6);
            this.btnAddAuthorForBook.Name = "btnAddAuthorForBook";
            this.btnAddAuthorForBook.Size = new System.Drawing.Size(49, 34);
            this.btnAddAuthorForBook.TabIndex = 101;
            this.btnAddAuthorForBook.Click += new System.EventHandler(this.btnAddAuthorForBook_Click);
            // 
            // frmShowBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 586);
            this.Controls.Add(this.tcBookInfo);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowBookInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Book Info";
            this.Load += new System.EventHandler(this.frmShowBookInfo_Load);
            this.tpAuthorsAndCopies.ResumeLayout(false);
            this.tpAuthorsAndCopies.PerformLayout();
            this.tpBookInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverImage)).EndInit();
            this.tcBookInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.TabPage tpAuthorsAndCopies;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Book_Copies.ctrlListCopiesForBook ctrlListCopiesForBook1;
        private Authors.Controls.ctrlListAuthorsForBook ctrlListAuthorsForBook1;
        private System.Windows.Forms.TabPage tpBookInfo;
        private Guna.UI2.WinForms.Guna2TabControl tcBookInfo;
        private controls.ctrlBookCardInfo ctrlBookCardInfo1;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2PictureBox pbCoverImage;
        private Guna.UI2.WinForms.Guna2Button btnAddBookCopy;
        private Guna.UI2.WinForms.Guna2Button btnAddAuthorForBook;
    }
}