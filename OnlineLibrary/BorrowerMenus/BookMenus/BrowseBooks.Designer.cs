namespace OnlineLibrary.BorrowerMenus.BookMenus
{
    partial class BrowseBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.txtBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDateAuthored = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCategories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtCopiesLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtBookID,
            this.txtTitle,
            this.txtAuthor,
            this.txtDateAuthored,
            this.txtCategories,
            this.txtISBN,
            this.imgImage,
            this.txtCopiesLeft});
            this.dgvBooks.Location = new System.Drawing.Point(18, 18);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBooks.Size = new System.Drawing.Size(618, 316);
            this.dgvBooks.TabIndex = 10;
            // 
            // txtBookID
            // 
            this.txtBookID.DataPropertyName = "book_id";
            this.txtBookID.HeaderText = "Book ID";
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            // 
            // txtTitle
            // 
            this.txtTitle.DataPropertyName = "title";
            this.txtTitle.HeaderText = "BookTitle";
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            // 
            // txtAuthor
            // 
            this.txtAuthor.DataPropertyName = "author";
            this.txtAuthor.HeaderText = "Author";
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            // 
            // txtDateAuthored
            // 
            this.txtDateAuthored.DataPropertyName = "date_authored";
            this.txtDateAuthored.HeaderText = "Date Authored";
            this.txtDateAuthored.Name = "txtDateAuthored";
            this.txtDateAuthored.ReadOnly = true;
            // 
            // txtCategories
            // 
            this.txtCategories.DataPropertyName = "categories";
            this.txtCategories.HeaderText = "Categories";
            this.txtCategories.Name = "txtCategories";
            this.txtCategories.ReadOnly = true;
            // 
            // txtISBN
            // 
            this.txtISBN.DataPropertyName = "isbn";
            this.txtISBN.HeaderText = "ISBN";
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            // 
            // imgImage
            // 
            this.imgImage.DataPropertyName = "image";
            this.imgImage.HeaderText = "Image ID";
            this.imgImage.Name = "imgImage";
            this.imgImage.ReadOnly = true;
            this.imgImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imgImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtCopiesLeft
            // 
            this.txtCopiesLeft.DataPropertyName = "copies_left";
            this.txtCopiesLeft.HeaderText = "Copies Left";
            this.txtCopiesLeft.Name = "txtCopiesLeft";
            this.txtCopiesLeft.ReadOnly = true;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.DarkOrange;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(18, 340);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 33);
            this.btnView.TabIndex = 11;
            this.btnView.Text = "View Details";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // BrowseBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dgvBooks);
            this.Name = "BrowseBooks";
            this.Size = new System.Drawing.Size(655, 386);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDateAuthored;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtISBN;
        private System.Windows.Forms.DataGridViewImageColumn imgImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCopiesLeft;
        private System.Windows.Forms.Button btnView;
    }
}
