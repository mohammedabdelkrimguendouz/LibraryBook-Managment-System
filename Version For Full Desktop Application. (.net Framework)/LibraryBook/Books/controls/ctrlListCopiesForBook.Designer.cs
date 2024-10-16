namespace LibraryBook.Book_Copies
{
    partial class ctrlListCopiesForBook
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
            this.dgvListCopiesForBook = new System.Windows.Forms.DataGridView();
            this.lblRecordsCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cmsListCopiesForBook = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCopiesForBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.cmsListCopiesForBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListCopiesForBook
            // 
            this.dgvListCopiesForBook.AllowUserToAddRows = false;
            this.dgvListCopiesForBook.AllowUserToDeleteRows = false;
            this.dgvListCopiesForBook.AllowUserToOrderColumns = true;
            this.dgvListCopiesForBook.AllowUserToResizeColumns = false;
            this.dgvListCopiesForBook.AllowUserToResizeRows = false;
            this.dgvListCopiesForBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListCopiesForBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListCopiesForBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvListCopiesForBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCopiesForBook.ContextMenuStrip = this.cmsListCopiesForBook;
            this.dgvListCopiesForBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvListCopiesForBook.Location = new System.Drawing.Point(0, 0);
            this.dgvListCopiesForBook.MultiSelect = false;
            this.dgvListCopiesForBook.Name = "dgvListCopiesForBook";
            this.dgvListCopiesForBook.ReadOnly = true;
            this.dgvListCopiesForBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListCopiesForBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListCopiesForBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListCopiesForBook.Size = new System.Drawing.Size(450, 340);
            this.dgvListCopiesForBook.TabIndex = 57;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblRecordsCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(138, 346);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(12, 23);
            this.lblRecordsCount.TabIndex = 59;
            this.lblRecordsCount.Text = "0";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 342);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(95, 27);
            this.guna2HtmlLabel1.TabIndex = 58;
            this.guna2HtmlLabel1.Text = " # Records :";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::LibraryBook.Properties.Resources.Count_32;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(102, 342);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(30, 27);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 60;
            this.guna2PictureBox1.TabStop = false;
            // 
            // cmsListCopiesForBook
            // 
            this.cmsListCopiesForBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsListCopiesForBook.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsListCopiesForBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cmsListCopiesForBook.Name = "cmsListUsers";
            this.cmsListCopiesForBook.Size = new System.Drawing.Size(141, 42);
            this.cmsListCopiesForBook.Opening += new System.ComponentModel.CancelEventHandler(this.cmsListCopiesForBook_Opening);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::LibraryBook.Properties.Resources.Delete_32_2;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(140, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ctrlListCopiesForBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.dgvListCopiesForBook);
            this.Name = "ctrlListCopiesForBook";
            this.Size = new System.Drawing.Size(450, 372);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCopiesForBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.cmsListCopiesForBook.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListCopiesForBook;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRecordsCount;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsListCopiesForBook;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
