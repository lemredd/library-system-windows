namespace OnlineLibrary.BorrowerMenus.BookMenus
{
    partial class Form_BookDetails
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
            this.btnBorrow = new System.Windows.Forms.Button();
            this.numCopiesLeft = new System.Windows.Forms.NumericUpDown();
            this.numIsbn = new System.Windows.Forms.NumericUpDown();
            this.tbCategories = new System.Windows.Forms.TextBox();
            this.lblBookCover = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.dtpDateAuth = new System.Windows.Forms.DateTimePicker();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblDateAuth = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbBookCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCopiesLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIsbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBorrow.FlatAppearance.BorderSize = 0;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.ForeColor = System.Drawing.Color.White;
            this.btnBorrow.Location = new System.Drawing.Point(182, 363);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(120, 36);
            this.btnBorrow.TabIndex = 24;
            this.btnBorrow.Text = "Borrow Book";
            this.btnBorrow.UseVisualStyleBackColor = false;
            // 
            // numCopiesLeft
            // 
            this.numCopiesLeft.Enabled = false;
            this.numCopiesLeft.Location = new System.Drawing.Point(163, 273);
            this.numCopiesLeft.Name = "numCopiesLeft";
            this.numCopiesLeft.Size = new System.Drawing.Size(139, 20);
            this.numCopiesLeft.TabIndex = 22;
            // 
            // numIsbn
            // 
            this.numIsbn.Enabled = false;
            this.numIsbn.Location = new System.Drawing.Point(163, 224);
            this.numIsbn.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numIsbn.Name = "numIsbn";
            this.numIsbn.Size = new System.Drawing.Size(139, 20);
            this.numIsbn.TabIndex = 23;
            // 
            // tbCategories
            // 
            this.tbCategories.Enabled = false;
            this.tbCategories.Location = new System.Drawing.Point(14, 108);
            this.tbCategories.Multiline = true;
            this.tbCategories.Name = "tbCategories";
            this.tbCategories.Size = new System.Drawing.Size(288, 87);
            this.tbCategories.TabIndex = 20;
            // 
            // lblBookCover
            // 
            this.lblBookCover.AutoSize = true;
            this.lblBookCover.Location = new System.Drawing.Point(11, 208);
            this.lblBookCover.Name = "lblBookCover";
            this.lblBookCover.Size = new System.Drawing.Size(63, 13);
            this.lblBookCover.TabIndex = 18;
            this.lblBookCover.Text = "Book Cover";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(11, 92);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(57, 13);
            this.lblCategories.TabIndex = 19;
            this.lblCategories.Text = "Categories\r\n";
            // 
            // dtpDateAuth
            // 
            this.dtpDateAuth.Enabled = false;
            this.dtpDateAuth.Location = new System.Drawing.Point(14, 65);
            this.dtpDateAuth.Name = "dtpDateAuth";
            this.dtpDateAuth.Size = new System.Drawing.Size(288, 20);
            this.dtpDateAuth.TabIndex = 16;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Enabled = false;
            this.tbAuthor.Location = new System.Drawing.Point(159, 26);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(143, 20);
            this.tbAuthor.TabIndex = 14;
            // 
            // tbTitle
            // 
            this.tbTitle.Enabled = false;
            this.tbTitle.Location = new System.Drawing.Point(14, 26);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(131, 20);
            this.tbTitle.TabIndex = 15;
            // 
            // lblDateAuth
            // 
            this.lblDateAuth.AutoSize = true;
            this.lblDateAuth.Location = new System.Drawing.Point(11, 49);
            this.lblDateAuth.Name = "lblDateAuth";
            this.lblDateAuth.Size = new System.Drawing.Size(76, 13);
            this.lblDateAuth.TabIndex = 9;
            this.lblDateAuth.Text = "Date Authored";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(160, 10);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 10;
            this.lblAuthor.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Copies Left";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(160, 208);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 12;
            this.lblISBN.Text = "ISBN";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(11, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(55, 13);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Book Title";
            // 
            // pbBookCover
            // 
            this.pbBookCover.Image = global::OnlineLibrary.Properties.Resources.addcover;
            this.pbBookCover.InitialImage = global::OnlineLibrary.Properties.Resources.addcover;
            this.pbBookCover.Location = new System.Drawing.Point(12, 224);
            this.pbBookCover.Name = "pbBookCover";
            this.pbBookCover.Size = new System.Drawing.Size(131, 175);
            this.pbBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookCover.TabIndex = 21;
            this.pbBookCover.TabStop = false;
            // 
            // Form_BookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(312, 411);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.numCopiesLeft);
            this.Controls.Add(this.numIsbn);
            this.Controls.Add(this.pbBookCover);
            this.Controls.Add(this.tbCategories);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_BookDetails";
            this.Text = "Book Details";
            ((System.ComponentModel.ISupportInitialize)(this.numCopiesLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIsbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.NumericUpDown numCopiesLeft;
        private System.Windows.Forms.NumericUpDown numIsbn;
        private System.Windows.Forms.PictureBox pbBookCover;
        private System.Windows.Forms.TextBox tbCategories;
        private System.Windows.Forms.Label lblBookCover;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.DateTimePicker dtpDateAuth;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblDateAuth;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblTitle;
    }
}