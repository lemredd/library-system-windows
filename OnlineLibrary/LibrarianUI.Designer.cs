namespace OnlineLibrary
{
    partial class LibrarianUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianUI));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnSchedules = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumBlue;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.picLogo);
            this.panel2.Controls.Add(this.btnBooks);
            this.panel2.Controls.Add(this.btnAccounts);
            this.panel2.Controls.Add(this.btnSchedules);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(89, 450);
            this.panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnLogout.Image = global::OnlineLibrary.Properties.Resources.logout_icon;
            this.btnLogout.Location = new System.Drawing.Point(3, 365);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(83, 85);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "\r\n";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::OnlineLibrary.Properties.Resources.bookanizer_logo;
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(83, 76);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // btnBooks
            // 
            this.btnBooks.AccessibleName = "btnBook";
            this.btnBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBooks.BackgroundImage")));
            this.btnBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Location = new System.Drawing.Point(18, 94);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(50, 40);
            this.btnBooks.TabIndex = 4;
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.AccessibleName = "btnProfile";
            this.btnAccounts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccounts.BackgroundImage")));
            this.btnAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Location = new System.Drawing.Point(18, 218);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(50, 40);
            this.btnAccounts.TabIndex = 2;
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSchedules
            // 
            this.btnSchedules.AccessibleName = "btnCalendar";
            this.btnSchedules.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSchedules.BackgroundImage")));
            this.btnSchedules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSchedules.FlatAppearance.BorderSize = 0;
            this.btnSchedules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedules.Location = new System.Drawing.Point(12, 156);
            this.btnSchedules.Name = "btnSchedules";
            this.btnSchedules.Size = new System.Drawing.Size(60, 40);
            this.btnSchedules.TabIndex = 1;
            this.btnSchedules.UseVisualStyleBackColor = true;
            this.btnSchedules.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.Location = new System.Drawing.Point(107, 3);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(681, 435);
            this.panelContent.TabIndex = 2;
            // 
            // LibrarianUI
            // 
            this.AccessibleName = "librarianui";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineLibrary.Properties.Resources.background_resize;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LibrarianUI";
            this.Text = "Librarian Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LibrarianUI_FormClosing);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Button btnSchedules;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelContent;
    }
}