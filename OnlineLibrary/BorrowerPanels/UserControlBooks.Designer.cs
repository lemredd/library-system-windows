namespace OnlineLibrary.BorrowerPanels
{
    partial class UserControlBooks
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblBooks = new System.Windows.Forms.Label();
            this.panelBooksTab = new System.Windows.Forms.Panel();
            this.btnBrowseBooks = new System.Windows.Forms.Button();
            this.btnMyBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooks.ForeColor = System.Drawing.Color.White;
            this.lblBooks.Location = new System.Drawing.Point(3, 0);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(133, 46);
            this.lblBooks.TabIndex = 3;
            this.lblBooks.Text = "Books";
            // 
            // panelBooksTab
            // 
            this.panelBooksTab.BackColor = System.Drawing.Color.White;
            this.panelBooksTab.Location = new System.Drawing.Point(0, 49);
            this.panelBooksTab.Name = "panelBooksTab";
            this.panelBooksTab.Size = new System.Drawing.Size(655, 386);
            this.panelBooksTab.TabIndex = 4;
            // 
            // btnBrowseBooks
            // 
            this.btnBrowseBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBrowseBooks.FlatAppearance.BorderSize = 0;
            this.btnBrowseBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseBooks.ForeColor = System.Drawing.Color.White;
            this.btnBrowseBooks.Location = new System.Drawing.Point(551, 0);
            this.btnBrowseBooks.Name = "btnBrowseBooks";
            this.btnBrowseBooks.Size = new System.Drawing.Size(104, 46);
            this.btnBrowseBooks.TabIndex = 5;
            this.btnBrowseBooks.Text = "Browse Books";
            this.btnBrowseBooks.UseVisualStyleBackColor = false;
            // 
            // btnMyBooks
            // 
            this.btnMyBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMyBooks.FlatAppearance.BorderSize = 0;
            this.btnMyBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyBooks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMyBooks.Location = new System.Drawing.Point(441, 0);
            this.btnMyBooks.Name = "btnMyBooks";
            this.btnMyBooks.Size = new System.Drawing.Size(104, 46);
            this.btnMyBooks.TabIndex = 5;
            this.btnMyBooks.Text = "My Books";
            this.btnMyBooks.UseVisualStyleBackColor = false;
            // 
            // UserControlBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnMyBooks);
            this.Controls.Add(this.btnBrowseBooks);
            this.Controls.Add(this.panelBooksTab);
            this.Controls.Add(this.lblBooks);
            this.Name = "UserControlBooks";
            this.Size = new System.Drawing.Size(655, 435);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Panel panelBooksTab;
        private System.Windows.Forms.Button btnBrowseBooks;
        private System.Windows.Forms.Button btnMyBooks;
    }
}
