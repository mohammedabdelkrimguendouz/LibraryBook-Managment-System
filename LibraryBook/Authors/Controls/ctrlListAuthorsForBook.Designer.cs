namespace LibraryBook.Authors.Controls
{
    partial class ctrlListAuthorsForBook
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvListAuthorsForBook = new System.Windows.Forms.DataGridView();
            this.cmsListAuthorsForBook = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showAuthorInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordsCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAuthorsForBook)).BeginInit();
            this.cmsListAuthorsForBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListAuthorsForBook
            // 
            this.dgvListAuthorsForBook.AllowUserToAddRows = false;
            this.dgvListAuthorsForBook.AllowUserToDeleteRows = false;
            this.dgvListAuthorsForBook.AllowUserToOrderColumns = true;
            this.dgvListAuthorsForBook.AllowUserToResizeColumns = false;
            this.dgvListAuthorsForBook.AllowUserToResizeRows = false;
            this.dgvListAuthorsForBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListAuthorsForBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListAuthorsForBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvListAuthorsForBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListAuthorsForBook.ContextMenuStrip = this.cmsListAuthorsForBook;
            this.dgvListAuthorsForBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvListAuthorsForBook.Location = new System.Drawing.Point(0, 0);
            this.dgvListAuthorsForBook.MultiSelect = false;
            this.dgvListAuthorsForBook.Name = "dgvListAuthorsForBook";
            this.dgvListAuthorsForBook.ReadOnly = true;
            this.dgvListAuthorsForBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListAuthorsForBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListAuthorsForBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListAuthorsForBook.Size = new System.Drawing.Size(450, 340);
            this.dgvListAuthorsForBook.TabIndex = 58;
            // 
            // cmsListAuthorsForBook
            // 
            this.cmsListAuthorsForBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsListAuthorsForBook.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsListAuthorsForBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAuthorInfoToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem});
            this.cmsListAuthorsForBook.Name = "cmsListUsers";
            this.cmsListAuthorsForBook.Size = new System.Drawing.Size(219, 108);
            this.cmsListAuthorsForBook.Opening += new System.ComponentModel.CancelEventHandler(this.cmsListAuthorsForBook_Opening);
            // 
            // showAuthorInfoToolStripMenuItem
            // 
            this.showAuthorInfoToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.info_32;
            this.showAuthorInfoToolStripMenuItem.Name = "showAuthorInfoToolStripMenuItem";
            this.showAuthorInfoToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
            this.showAuthorInfoToolStripMenuItem.Text = "Show Author Info";
            this.showAuthorInfoToolStripMenuItem.Click += new System.EventHandler(this.showAuthorInfoToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.Delete_32_2;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblRecordsCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(135, 346);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(12, 23);
            this.lblRecordsCount.TabIndex = 62;
            this.lblRecordsCount.Text = "0";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(0, 342);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(95, 27);
            this.guna2HtmlLabel1.TabIndex = 61;
            this.guna2HtmlLabel1.Text = " # Records :";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::LibraryBook.Properties.Resources.Count_32;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(99, 342);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(30, 27);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 63;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ctrlListAuthorsForBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.dgvListAuthorsForBook);
            this.Name = "ctrlListAuthorsForBook";
            this.Size = new System.Drawing.Size(450, 372);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAuthorsForBook)).EndInit();
            this.cmsListAuthorsForBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListAuthorsForBook;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRecordsCount;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsListAuthorsForBook;
        private System.Windows.Forms.ToolStripMenuItem showAuthorInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
