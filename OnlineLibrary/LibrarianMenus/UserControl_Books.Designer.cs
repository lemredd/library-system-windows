namespace OnlineLibrary.Panel_LibrarianUI
{
    partial class UserControl_Books
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.txtBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDateAuthored = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCategories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtCopiesLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Books";
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.Navy;
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddBook.Location = new System.Drawing.Point(468, 0);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(71, 53);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "+ Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvBooks);
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 376);
            this.panel1.TabIndex = 8;
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
            this.dgvBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBooks.Size = new System.Drawing.Size(681, 376);
            this.dgvBooks.TabIndex = 8;
            // 
            // txtBookID
            // 
            this.txtBookID.DataPropertyName = "book_id";
            this.txtBookID.HeaderText = "Book ID";
            this.txtBookID.Name = "txtBookID";
            // 
            // txtTitle
            // 
            this.txtTitle.DataPropertyName = "title";
            this.txtTitle.HeaderText = "BookTitle";
            this.txtTitle.Name = "txtTitle";
            // 
            // txtAuthor
            // 
            this.txtAuthor.DataPropertyName = "author";
            this.txtAuthor.HeaderText = "Author";
            this.txtAuthor.Name = "txtAuthor";
            // 
            // txtDateAuthored
            // 
            this.txtDateAuthored.DataPropertyName = "date_authored";
            this.txtDateAuthored.HeaderText = "Date Authored";
            this.txtDateAuthored.Name = "txtDateAuthored";
            // 
            // txtCategories
            // 
            this.txtCategories.DataPropertyName = "categories";
            this.txtCategories.HeaderText = "Categories";
            this.txtCategories.Name = "txtCategories";
            // 
            // txtISBN
            // 
            this.txtISBN.DataPropertyName = "isbn";
            this.txtISBN.HeaderText = "ISBN";
            this.txtISBN.Name = "txtISBN";
            // 
            // imgImage
            // 
            this.imgImage.DataPropertyName = "image";
            this.imgImage.HeaderText = "Image ID";
            this.imgImage.Name = "imgImage";
            this.imgImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imgImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtCopiesLeft
            // 
            this.txtCopiesLeft.DataPropertyName = "copies_left";
            this.txtCopiesLeft.HeaderText = "Copies Left";
            this.txtCopiesLeft.Name = "txtCopiesLeft";
            // 
            // btnEditBook
            // 
            this.btnEditBook.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditBook.FlatAppearance.BorderSize = 0;
            this.btnEditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBook.ForeColor = System.Drawing.Color.White;
            this.btnEditBook.Location = new System.Drawing.Point(545, 0);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(65, 53);
            this.btnEditBook.TabIndex = 9;
            this.btnEditBook.Text = "Edit Book";
            this.btnEditBook.UseVisualStyleBackColor = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteBook.FlatAppearance.BorderSize = 0;
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBook.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBook.Location = new System.Drawing.Point(616, 0);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(65, 53);
            this.btnDeleteBook.TabIndex = 9;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // UserControl_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnEditBook);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_Books";
            this.Size = new System.Drawing.Size(681, 435);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDateAuthored;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtISBN;
        private System.Windows.Forms.DataGridViewImageColumn imgImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCopiesLeft;
        private System.Windows.Forms.Button btnDeleteBook;
    }
}
