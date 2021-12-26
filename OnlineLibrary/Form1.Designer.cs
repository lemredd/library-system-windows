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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBackground = new System.Windows.Forms.PictureBox();
            this.labelFormEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.panelFormCtrlEmail = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelFormCtrlPass = new System.Windows.Forms.Panel();
            this.labelFormPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonAdminSignIn = new System.Windows.Forms.Button();
            this.buttonSignInStudent = new System.Windows.Forms.Button();
            this.panelFormPasswordSettings = new System.Windows.Forms.Panel();
            this.checkBoxRememberPass = new System.Windows.Forms.CheckBox();
            this.linkLabelForgotPass = new System.Windows.Forms.LinkLabel();
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).BeginInit();
            this.panelFormCtrlEmail.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelFormCtrlPass.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelFormPasswordSettings.SuspendLayout();
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
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Controls.Add(this.picboxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
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
            // 
            // labelFormEmail
            // 
            this.labelFormEmail.AutoSize = true;
            this.labelFormEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFormEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormEmail.Location = new System.Drawing.Point(50, 0);
            this.labelFormEmail.Name = "labelFormEmail";
            this.labelFormEmail.Size = new System.Drawing.Size(48, 20);
            this.labelFormEmail.TabIndex = 0;
            this.labelFormEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(169)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxEmail.Location = new System.Drawing.Point(50, 25);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(316, 20);
            this.textBoxEmail.TabIndex = 1;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panelFormCtrlEmail
            // 
            this.panelFormCtrlEmail.Controls.Add(this.labelFormEmail);
            this.panelFormCtrlEmail.Controls.Add(this.textBoxEmail);
            this.panelFormCtrlEmail.Location = new System.Drawing.Point(3, 124);
            this.panelFormCtrlEmail.Name = "panelFormCtrlEmail";
            this.panelFormCtrlEmail.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panelFormCtrlEmail.Size = new System.Drawing.Size(416, 45);
            this.panelFormCtrlEmail.TabIndex = 2;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.panelFormPasswordSettings);
            this.panelForm.Controls.Add(this.panelButtons);
            this.panelForm.Controls.Add(this.panelFormCtrlPass);
            this.panelForm.Controls.Add(this.panelFormCtrlEmail);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 115);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(422, 566);
            this.panelForm.TabIndex = 3;
            // 
            // panelFormCtrlPass
            // 
            this.panelFormCtrlPass.Controls.Add(this.labelFormPassword);
            this.panelFormCtrlPass.Controls.Add(this.textBoxPassword);
            this.panelFormCtrlPass.Location = new System.Drawing.Point(3, 175);
            this.panelFormCtrlPass.Name = "panelFormCtrlPass";
            this.panelFormCtrlPass.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panelFormCtrlPass.Size = new System.Drawing.Size(416, 45);
            this.panelFormCtrlPass.TabIndex = 3;
            // 
            // labelFormPassword
            // 
            this.labelFormPassword.AutoSize = true;
            this.labelFormPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFormPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormPassword.Location = new System.Drawing.Point(50, 0);
            this.labelFormPassword.Name = "labelFormPassword";
            this.labelFormPassword.Size = new System.Drawing.Size(78, 20);
            this.labelFormPassword.TabIndex = 0;
            this.labelFormPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(169)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxPassword.Location = new System.Drawing.Point(50, 25);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(316, 20);
            this.textBoxPassword.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonSignInStudent);
            this.panelButtons.Controls.Add(this.buttonAdminSignIn);
            this.panelButtons.Location = new System.Drawing.Point(3, 288);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panelButtons.Size = new System.Drawing.Size(416, 45);
            this.panelButtons.TabIndex = 4;
            // 
            // buttonAdminSignIn
            // 
            this.buttonAdminSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(123)))), ((int)(((byte)(0)))));
            this.buttonAdminSignIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAdminSignIn.FlatAppearance.BorderSize = 0;
            this.buttonAdminSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminSignIn.ForeColor = System.Drawing.Color.White;
            this.buttonAdminSignIn.Location = new System.Drawing.Point(50, 0);
            this.buttonAdminSignIn.Name = "buttonAdminSignIn";
            this.buttonAdminSignIn.Size = new System.Drawing.Size(120, 45);
            this.buttonAdminSignIn.TabIndex = 0;
            this.buttonAdminSignIn.Text = "Sign in as librarian";
            this.buttonAdminSignIn.UseVisualStyleBackColor = false;
            // 
            // buttonSignInStudent
            // 
            this.buttonSignInStudent.BackColor = System.Drawing.Color.Navy;
            this.buttonSignInStudent.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSignInStudent.FlatAppearance.BorderSize = 0;
            this.buttonSignInStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignInStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignInStudent.ForeColor = System.Drawing.Color.White;
            this.buttonSignInStudent.Location = new System.Drawing.Point(244, 0);
            this.buttonSignInStudent.Name = "buttonSignInStudent";
            this.buttonSignInStudent.Size = new System.Drawing.Size(122, 45);
            this.buttonSignInStudent.TabIndex = 1;
            this.buttonSignInStudent.Text = "Sign in as student";
            this.buttonSignInStudent.UseVisualStyleBackColor = false;
            // 
            // panelFormPasswordSettings
            // 
            this.panelFormPasswordSettings.Controls.Add(this.linkLabelForgotPass);
            this.panelFormPasswordSettings.Controls.Add(this.checkBoxRememberPass);
            this.panelFormPasswordSettings.Location = new System.Drawing.Point(3, 226);
            this.panelFormPasswordSettings.Name = "panelFormPasswordSettings";
            this.panelFormPasswordSettings.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panelFormPasswordSettings.Size = new System.Drawing.Size(416, 45);
            this.panelFormPasswordSettings.TabIndex = 4;
            // 
            // checkBoxRememberPass
            // 
            this.checkBoxRememberPass.AutoSize = true;
            this.checkBoxRememberPass.Location = new System.Drawing.Point(54, 17);
            this.checkBoxRememberPass.Name = "checkBoxRememberPass";
            this.checkBoxRememberPass.Size = new System.Drawing.Size(126, 17);
            this.checkBoxRememberPass.TabIndex = 0;
            this.checkBoxRememberPass.Text = "Remember Password";
            this.checkBoxRememberPass.UseVisualStyleBackColor = true;
            // 
            // linkLabelForgotPass
            // 
            this.linkLabelForgotPass.AutoSize = true;
            this.linkLabelForgotPass.Location = new System.Drawing.Point(274, 17);
            this.linkLabelForgotPass.Name = "linkLabelForgotPass";
            this.linkLabelForgotPass.Size = new System.Drawing.Size(92, 13);
            this.linkLabelForgotPass.TabIndex = 1;
            this.linkLabelForgotPass.TabStop = true;
            this.linkLabelForgotPass.Text = "Forgot Password?";
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
            this.panelSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).EndInit();
            this.panelFormCtrlEmail.ResumeLayout(false);
            this.panelFormCtrlEmail.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelFormCtrlPass.ResumeLayout(false);
            this.panelFormCtrlPass.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelFormPasswordSettings.ResumeLayout(false);
            this.panelFormPasswordSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBackground;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelFormEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Panel panelFormCtrlEmail;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelFormCtrlPass;
        private System.Windows.Forms.Label labelFormPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonAdminSignIn;
        private System.Windows.Forms.Panel panelFormPasswordSettings;
        private System.Windows.Forms.LinkLabel linkLabelForgotPass;
        private System.Windows.Forms.CheckBox checkBoxRememberPass;
        private System.Windows.Forms.Button buttonSignInStudent;
    }
}

