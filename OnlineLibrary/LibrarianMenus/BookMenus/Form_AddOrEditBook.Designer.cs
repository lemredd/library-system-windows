namespace OnlineLibrary.LibrarianMenus.BookMenus
{
    partial class Form_AddOrEditBook
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.lblDateAuth = new System.Windows.Forms.Label();
            this.dtpDateAuth = new System.Windows.Forms.DateTimePicker();
            this.lblCategories = new System.Windows.Forms.Label();
            this.tbCategories = new System.Windows.Forms.TextBox();
            this.lblCategoriesNote = new System.Windows.Forms.Label();
            this.lblBookCover = new System.Windows.Forms.Label();
            this.numIsbn = new System.Windows.Forms.NumericUpDown();
            this.lblISBN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numCopiesLeft = new System.Windows.Forms.NumericUpDown();
            this.btnAddOrEditBook = new System.Windows.Forms.Button();
            this.pbBookCover = new System.Windows.Forms.PictureBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numIsbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCopiesLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(9, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(55, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Book Title";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(12, 25);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(131, 20);
            this.tbTitle.TabIndex = 1;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(158, 9);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Author";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(157, 25);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(143, 20);
            this.tbAuthor.TabIndex = 1;
            // 
            // lblDateAuth
            // 
            this.lblDateAuth.AutoSize = true;
            this.lblDateAuth.Location = new System.Drawing.Point(9, 48);
            this.lblDateAuth.Name = "lblDateAuth";
            this.lblDateAuth.Size = new System.Drawing.Size(76, 13);
            this.lblDateAuth.TabIndex = 0;
            this.lblDateAuth.Text = "Date Authored";
            // 
            // dtpDateAuth
            // 
            this.dtpDateAuth.Location = new System.Drawing.Point(12, 64);
            this.dtpDateAuth.Name = "dtpDateAuth";
            this.dtpDateAuth.Size = new System.Drawing.Size(288, 20);
            this.dtpDateAuth.TabIndex = 2;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(9, 91);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(57, 13);
            this.lblCategories.TabIndex = 3;
            this.lblCategories.Text = "Categories\r\n";
            // 
            // tbCategories
            // 
            this.tbCategories.Location = new System.Drawing.Point(12, 107);
            this.tbCategories.Multiline = true;
            this.tbCategories.Name = "tbCategories";
            this.tbCategories.Size = new System.Drawing.Size(288, 87);
            this.tbCategories.TabIndex = 4;
            // 
            // lblCategoriesNote
            // 
            this.lblCategoriesNote.AutoSize = true;
            this.lblCategoriesNote.Location = new System.Drawing.Point(9, 197);
            this.lblCategoriesNote.Name = "lblCategoriesNote";
            this.lblCategoriesNote.Size = new System.Drawing.Size(214, 13);
            this.lblCategoriesNote.TabIndex = 3;
            this.lblCategoriesNote.Text = "Separate each category with a semicolon (;)";
            // 
            // lblBookCover
            // 
            this.lblBookCover.AutoSize = true;
            this.lblBookCover.Location = new System.Drawing.Point(9, 277);
            this.lblBookCover.Name = "lblBookCover";
            this.lblBookCover.Size = new System.Drawing.Size(63, 13);
            this.lblBookCover.TabIndex = 3;
            this.lblBookCover.Text = "Book Cover";
            // 
            // numIsbn
            // 
            this.numIsbn.Location = new System.Drawing.Point(12, 244);
            this.numIsbn.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numIsbn.Name = "numIsbn";
            this.numIsbn.Size = new System.Drawing.Size(162, 20);
            this.numIsbn.TabIndex = 7;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(9, 228);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copies Left";
            // 
            // numCopiesLeft
            // 
            this.numCopiesLeft.Location = new System.Drawing.Point(180, 244);
            this.numCopiesLeft.Name = "numCopiesLeft";
            this.numCopiesLeft.Size = new System.Drawing.Size(120, 20);
            this.numCopiesLeft.TabIndex = 7;
            // 
            // btnAddOrEditBook
            // 
            this.btnAddOrEditBook.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddOrEditBook.FlatAppearance.BorderSize = 0;
            this.btnAddOrEditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrEditBook.ForeColor = System.Drawing.Color.White;
            this.btnAddOrEditBook.Location = new System.Drawing.Point(180, 430);
            this.btnAddOrEditBook.Name = "btnAddOrEditBook";
            this.btnAddOrEditBook.Size = new System.Drawing.Size(120, 36);
            this.btnAddOrEditBook.TabIndex = 8;
            this.btnAddOrEditBook.Text = "Add/Edit Book";
            this.btnAddOrEditBook.UseVisualStyleBackColor = false;
            this.btnAddOrEditBook.Click += new System.EventHandler(this.btnAddOrEditBook_Click);
            // 
            // pbBookCover
            // 
            this.pbBookCover.Image = global::OnlineLibrary.Properties.Resources.addcover;
            this.pbBookCover.InitialImage = global::OnlineLibrary.Properties.Resources.addcover;
            this.pbBookCover.Location = new System.Drawing.Point(12, 293);
            this.pbBookCover.Name = "pbBookCover";
            this.pbBookCover.Size = new System.Drawing.Size(131, 173);
            this.pbBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookCover.TabIndex = 5;
            this.pbBookCover.TabStop = false;
            this.pbBookCover.DoubleClick += new System.EventHandler(this.pbBookCover_DoubleClick);
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.Navy;
            this.btnAddImage.FlatAppearance.BorderSize = 0;
            this.btnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImage.ForeColor = System.Drawing.Color.White;
            this.btnAddImage.Location = new System.Drawing.Point(180, 293);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(120, 34);
            this.btnAddImage.TabIndex = 9;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteImage.FlatAppearance.BorderSize = 0;
            this.btnDeleteImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteImage.ForeColor = System.Drawing.Color.White;
            this.btnDeleteImage.Location = new System.Drawing.Point(180, 333);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(120, 34);
            this.btnDeleteImage.TabIndex = 9;
            this.btnDeleteImage.Text = "Delete Image";
            this.btnDeleteImage.UseVisualStyleBackColor = false;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // Form_AddOrEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(312, 478);
            this.Controls.Add(this.btnDeleteImage);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.btnAddOrEditBook);
            this.Controls.Add(this.numCopiesLeft);
            this.Controls.Add(this.numIsbn);
            this.Controls.Add(this.pbBookCover);
            this.Controls.Add(this.tbCategories);
            this.Controls.Add(this.lblCategoriesNote);
            this.Controls.Add(this.lblBookCover);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.dtpDateAuth);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblDateAuth);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_AddOrEditBook";
            this.Text = "Add/Edit Book";
            ((System.ComponentModel.ISupportInitialize)(this.numIsbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCopiesLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label lblDateAuth;
        private System.Windows.Forms.DateTimePicker dtpDateAuth;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.TextBox tbCategories;
        private System.Windows.Forms.Label lblCategoriesNote;
        private System.Windows.Forms.PictureBox pbBookCover;
        private System.Windows.Forms.Label lblBookCover;
        private System.Windows.Forms.NumericUpDown numIsbn;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCopiesLeft;
        private System.Windows.Forms.Button btnAddOrEditBook;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Button btnDeleteImage;
    }
}