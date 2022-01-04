namespace OnlineLibrary
{
    partial class FormLibrarySystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLibrarySystem));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelFormPasswordSettings = new System.Windows.Forms.Panel();
            this.linkLabelForgotPass = new System.Windows.Forms.LinkLabel();
            this.checkBoxRememberPass = new System.Windows.Forms.CheckBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonSignInStudent = new System.Windows.Forms.Button();
            this.buttonAdminSignIn = new System.Windows.Forms.Button();
            this.panelFormCtrlPass = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelFormPassword = new System.Windows.Forms.Label();
            this.panelFormCtrlEmail = new System.Windows.Forms.Panel();
            this.panelTextBoxEmailContainer = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelFormEmail = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBackground = new System.Windows.Forms.PictureBox();
            this.panelSidebar.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelFormPasswordSettings.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelFormCtrlPass.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelFormCtrlEmail.SuspendLayout();
            this.panelTextBoxEmailContainer.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.White;
            this.panelSidebar.Controls.Add(this.panelForm);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSidebar.Location = new System.Drawing.Point(842, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(422, 681);
            this.panelSidebar.TabIndex = 1;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.panelFormPasswordSettings);
            this.panelForm.Controls.Add(this.panelButtons);
            this.panelForm.Controls.Add(this.panelFormCtrlPass);
            this.panelForm.Controls.Add(this.panelFormCtrlEmail);
            this.panelForm.Location = new System.Drawing.Point(23, 121);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panelForm.Size = new System.Drawing.Size(373, 557);
            this.panelForm.TabIndex = 3;
            // 
            // panelFormPasswordSettings
            // 
            this.panelFormPasswordSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormPasswordSettings.BackColor = System.Drawing.Color.White;
            this.panelFormPasswordSettings.Controls.Add(this.linkLabelForgotPass);
            this.panelFormPasswordSettings.Controls.Add(this.checkBoxRememberPass);
            this.panelFormPasswordSettings.Location = new System.Drawing.Point(0, 290);
            this.panelFormPasswordSettings.Name = "panelFormPasswordSettings";
            this.panelFormPasswordSettings.Size = new System.Drawing.Size(370, 45);
            this.panelFormPasswordSettings.TabIndex = 4;
            // 
            // linkLabelForgotPass
            // 
            this.linkLabelForgotPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelForgotPass.AutoSize = true;
            this.linkLabelForgotPass.Location = new System.Drawing.Point(275, 18);
            this.linkLabelForgotPass.Name = "linkLabelForgotPass";
            this.linkLabelForgotPass.Size = new System.Drawing.Size(92, 13);
            this.linkLabelForgotPass.TabIndex = 1;
            this.linkLabelForgotPass.TabStop = true;
            this.linkLabelForgotPass.Text = "Forgot Password?";
            // 
            // checkBoxRememberPass
            // 
            this.checkBoxRememberPass.AutoSize = true;
            this.checkBoxRememberPass.Location = new System.Drawing.Point(4, 17);
            this.checkBoxRememberPass.Name = "checkBoxRememberPass";
            this.checkBoxRememberPass.Size = new System.Drawing.Size(126, 17);
            this.checkBoxRememberPass.TabIndex = 0;
            this.checkBoxRememberPass.Text = "Remember Password";
            this.checkBoxRememberPass.UseVisualStyleBackColor = true;
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.Controls.Add(this.buttonSignInStudent);
            this.panelButtons.Controls.Add(this.buttonAdminSignIn);
            this.panelButtons.Location = new System.Drawing.Point(0, 350);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(373, 45);
            this.panelButtons.TabIndex = 4;
            // 
            // buttonSignInStudent
            // 
            this.buttonSignInStudent.BackColor = System.Drawing.Color.Navy;
            this.buttonSignInStudent.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSignInStudent.FlatAppearance.BorderSize = 0;
            this.buttonSignInStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignInStudent.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignInStudent.ForeColor = System.Drawing.Color.White;
            this.buttonSignInStudent.Location = new System.Drawing.Point(230, 0);
            this.buttonSignInStudent.Name = "buttonSignInStudent";
            this.buttonSignInStudent.Size = new System.Drawing.Size(143, 45);
            this.buttonSignInStudent.TabIndex = 1;
            this.buttonSignInStudent.Text = "Sign in as student";
            this.buttonSignInStudent.UseVisualStyleBackColor = false;
            // 
            // buttonAdminSignIn
            // 
            this.buttonAdminSignIn.AccessibleName = "buttonAdminSignIn";
            this.buttonAdminSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(123)))), ((int)(((byte)(0)))));
            this.buttonAdminSignIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAdminSignIn.FlatAppearance.BorderSize = 0;
            this.buttonAdminSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminSignIn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminSignIn.ForeColor = System.Drawing.Color.White;
            this.buttonAdminSignIn.Location = new System.Drawing.Point(0, 0);
            this.buttonAdminSignIn.Name = "buttonAdminSignIn";
            this.buttonAdminSignIn.Size = new System.Drawing.Size(147, 45);
            this.buttonAdminSignIn.TabIndex = 0;
            this.buttonAdminSignIn.Text = "Sign in as librarian";
            this.buttonAdminSignIn.UseVisualStyleBackColor = false;
            this.buttonAdminSignIn.Click += new System.EventHandler(this.buttonAdminSignIn_Click);
            // 
            // panelFormCtrlPass
            // 
            this.panelFormCtrlPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormCtrlPass.Controls.Add(this.panel1);
            this.panelFormCtrlPass.Controls.Add(this.labelFormPassword);
            this.panelFormCtrlPass.Location = new System.Drawing.Point(0, 203);
            this.panelFormCtrlPass.Name = "panelFormCtrlPass";
            this.panelFormCtrlPass.Size = new System.Drawing.Size(373, 70);
            this.panelFormCtrlPass.TabIndex = 3;
            this.panelFormCtrlPass.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormCtrlPass_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 35);
            this.panel1.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(169)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxPassword.Location = new System.Drawing.Point(16, 8);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(341, 19);
            this.textBoxPassword.TabIndex = 1;
            // 
            // labelFormPassword
            // 
            this.labelFormPassword.AutoSize = true;
            this.labelFormPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFormPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormPassword.Location = new System.Drawing.Point(0, 0);
            this.labelFormPassword.Name = "labelFormPassword";
            this.labelFormPassword.Size = new System.Drawing.Size(78, 20);
            this.labelFormPassword.TabIndex = 0;
            this.labelFormPassword.Text = "Password";
            // 
            // panelFormCtrlEmail
            // 
            this.panelFormCtrlEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormCtrlEmail.Controls.Add(this.panelTextBoxEmailContainer);
            this.panelFormCtrlEmail.Controls.Add(this.labelFormEmail);
            this.panelFormCtrlEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFormCtrlEmail.Location = new System.Drawing.Point(0, 109);
            this.panelFormCtrlEmail.Name = "panelFormCtrlEmail";
            this.panelFormCtrlEmail.Size = new System.Drawing.Size(373, 70);
            this.panelFormCtrlEmail.TabIndex = 2;
            this.panelFormCtrlEmail.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormCtrlEmail_Paint);
            // 
            // panelTextBoxEmailContainer
            // 
            this.panelTextBoxEmailContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(169)))));
            this.panelTextBoxEmailContainer.Controls.Add(this.textBoxEmail);
            this.panelTextBoxEmailContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTextBoxEmailContainer.Location = new System.Drawing.Point(0, 35);
            this.panelTextBoxEmailContainer.Name = "panelTextBoxEmailContainer";
            this.panelTextBoxEmailContainer.Size = new System.Drawing.Size(373, 35);
            this.panelTextBoxEmailContainer.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(169)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.ForeColor = System.Drawing.Color.White;
            this.textBoxEmail.Location = new System.Drawing.Point(16, 6);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(341, 19);
            this.textBoxEmail.TabIndex = 0;
            // 
            // labelFormEmail
            // 
            this.labelFormEmail.AutoSize = true;
            this.labelFormEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFormEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormEmail.Location = new System.Drawing.Point(0, 0);
            this.labelFormEmail.Name = "labelFormEmail";
            this.labelFormEmail.Size = new System.Drawing.Size(48, 20);
            this.labelFormEmail.TabIndex = 0;
            this.labelFormEmail.Text = "Email";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Controls.Add(this.picboxLogo);
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(422, 115);
            this.panelLogo.TabIndex = 2;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.Navy;
            this.labelLogo.Location = new System.Drawing.Point(143, 38);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(267, 46);
            this.labelLogo.TabIndex = 1;
            this.labelLogo.Text = "Online Library";
            this.labelLogo.Click += new System.EventHandler(this.label1_Click);
            // 
            // picboxLogo
            // 
            this.picboxLogo.Image = global::OnlineLibrary.Properties.Resources.logo_icon_64;
            this.picboxLogo.Location = new System.Drawing.Point(3, 3);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(134, 109);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxLogo.TabIndex = 0;
            this.picboxLogo.TabStop = false;
            this.picboxLogo.Click += new System.EventHandler(this.picboxLogo_Click);
            // 
            // pictureBackground
            // 
            this.pictureBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBackground.Image = global::OnlineLibrary.Properties.Resources.background_resize;
            this.pictureBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBackground.Name = "pictureBackground";
            this.pictureBackground.Size = new System.Drawing.Size(1264, 681);
            this.pictureBackground.TabIndex = 0;
            this.pictureBackground.TabStop = false;
            this.pictureBackground.Click += new System.EventHandler(this.pictureBackground_Click);
            // 
            // FormLibrarySystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.pictureBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLibrarySystem";
            this.Text = "Library System";
            this.Load += new System.EventHandler(this.FormLibrarySystem_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelFormPasswordSettings.ResumeLayout(false);
            this.panelFormPasswordSettings.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelFormCtrlPass.ResumeLayout(false);
            this.panelFormCtrlPass.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFormCtrlEmail.ResumeLayout(false);
            this.panelFormCtrlEmail.PerformLayout();
            this.panelTextBoxEmailContainer.ResumeLayout(false);
            this.panelTextBoxEmailContainer.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBackground;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelFormEmail;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label labelFormPassword;
        private System.Windows.Forms.Button buttonAdminSignIn;
        private System.Windows.Forms.LinkLabel linkLabelForgotPass;
        private System.Windows.Forms.CheckBox checkBoxRememberPass;
        private System.Windows.Forms.Button buttonSignInStudent;
        private System.Windows.Forms.Panel panelTextBoxEmailContainer;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFormPasswordSettings;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelFormCtrlPass;
        private System.Windows.Forms.Panel panelFormCtrlEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}

