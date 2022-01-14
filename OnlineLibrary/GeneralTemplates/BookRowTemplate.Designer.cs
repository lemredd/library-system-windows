namespace OnlineLibrary.GeneralTemplates
{
    partial class BookRowTemplate
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
            System.Windows.Forms.Label lblAuthor;
            System.Windows.Forms.Label lblDateAuth;
            System.Windows.Forms.Label lblCategs;
            System.Windows.Forms.Label lblISBN;
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnViewMore = new System.Windows.Forms.Button();
            lblAuthor = new System.Windows.Forms.Label();
            lblDateAuth = new System.Windows.Forms.Label();
            lblCategs = new System.Windows.Forms.Label();
            lblISBN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.Location = new System.Drawing.Point(157, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(160, 39);
            this.lblBookTitle.TabIndex = 0;
            this.lblBookTitle.Text = "BookTitle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 238);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAuthor.Location = new System.Drawing.Point(160, 48);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new System.Drawing.Size(57, 20);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Author";
            // 
            // lblDateAuth
            // 
            lblDateAuth.AutoSize = true;
            lblDateAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDateAuth.Location = new System.Drawing.Point(385, 48);
            lblDateAuth.Name = "lblDateAuth";
            lblDateAuth.Size = new System.Drawing.Size(226, 20);
            lblDateAuth.TabIndex = 2;
            lblDateAuth.Text = "Date Authored: MM-DD-YYYY";
            // 
            // lblCategs
            // 
            lblCategs.AutoSize = true;
            lblCategs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCategs.Location = new System.Drawing.Point(160, 138);
            lblCategs.Name = "lblCategs";
            lblCategs.Size = new System.Drawing.Size(298, 20);
            lblCategs.TabIndex = 2;
            lblCategs.Text = "Categories: Genre, Genre, Genre, Genre";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblISBN.Location = new System.Drawing.Point(160, 118);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new System.Drawing.Size(145, 20);
            lblISBN.TabIndex = 2;
            lblISBN.Text = "ISBN: 1234567890";
            // 
            // btnViewMore
            // 
            this.btnViewMore.BackColor = System.Drawing.Color.DarkOrange;
            this.btnViewMore.FlatAppearance.BorderSize = 0;
            this.btnViewMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMore.ForeColor = System.Drawing.Color.White;
            this.btnViewMore.Location = new System.Drawing.Point(164, 202);
            this.btnViewMore.Name = "btnViewMore";
            this.btnViewMore.Size = new System.Drawing.Size(75, 23);
            this.btnViewMore.TabIndex = 3;
            this.btnViewMore.Text = "More Details";
            this.btnViewMore.UseVisualStyleBackColor = false;
            // 
            // BookRowTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnViewMore);
            this.Controls.Add(lblDateAuth);
            this.Controls.Add(lblISBN);
            this.Controls.Add(lblCategs);
            this.Controls.Add(lblAuthor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBookTitle);
            this.Name = "BookRowTemplate";
            this.Size = new System.Drawing.Size(727, 238);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnViewMore;
    }
}
