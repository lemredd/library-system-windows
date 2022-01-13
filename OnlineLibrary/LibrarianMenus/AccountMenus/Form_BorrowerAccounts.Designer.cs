namespace OnlineLibrary.LibrarianMenus
{
    partial class Form_BorrowerAccounts
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
            this.dgvBorrowerAccounts = new System.Windows.Forms.DataGridView();
            this.txtAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.btnDeleteAcc = new System.Windows.Forms.Button();
            this.btnEditAcc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowerAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBorrowerAccounts
            // 
            this.dgvBorrowerAccounts.AllowUserToAddRows = false;
            this.dgvBorrowerAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvBorrowerAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBorrowerAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBorrowerAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowerAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtAccountID,
            this.txtUsername,
            this.txtPassword});
            this.dgvBorrowerAccounts.Location = new System.Drawing.Point(12, 12);
            this.dgvBorrowerAccounts.Name = "dgvBorrowerAccounts";
            this.dgvBorrowerAccounts.ReadOnly = true;
            this.dgvBorrowerAccounts.Size = new System.Drawing.Size(776, 382);
            this.dgvBorrowerAccounts.TabIndex = 1;
            // 
            // txtAccountID
            // 
            this.txtAccountID.DataPropertyName = "account_id";
            this.txtAccountID.HeaderText = "Account ID";
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.ReadOnly = true;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtUsername.DataPropertyName = "username";
            this.txtUsername.HeaderText = "Username";
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtPassword.DataPropertyName = "password";
            this.txtPassword.HeaderText = "Password";
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddAcc.FlatAppearance.BorderSize = 0;
            this.btnAddAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAcc.ForeColor = System.Drawing.Color.White;
            this.btnAddAcc.Location = new System.Drawing.Point(12, 400);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(85, 38);
            this.btnAddAcc.TabIndex = 3;
            this.btnAddAcc.Text = "Add Account";
            this.btnAddAcc.UseVisualStyleBackColor = false;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // btnDeleteAcc
            // 
            this.btnDeleteAcc.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteAcc.FlatAppearance.BorderSize = 0;
            this.btnDeleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAcc.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAcc.Location = new System.Drawing.Point(194, 400);
            this.btnDeleteAcc.Name = "btnDeleteAcc";
            this.btnDeleteAcc.Size = new System.Drawing.Size(92, 38);
            this.btnDeleteAcc.TabIndex = 3;
            this.btnDeleteAcc.Text = "Delete Account";
            this.btnDeleteAcc.UseVisualStyleBackColor = false;
            this.btnDeleteAcc.Click += new System.EventHandler(this.btnDeleteAcc_Click);
            // 
            // btnEditAcc
            // 
            this.btnEditAcc.BackColor = System.Drawing.Color.Navy;
            this.btnEditAcc.FlatAppearance.BorderSize = 0;
            this.btnEditAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAcc.ForeColor = System.Drawing.Color.White;
            this.btnEditAcc.Location = new System.Drawing.Point(103, 400);
            this.btnEditAcc.Name = "btnEditAcc";
            this.btnEditAcc.Size = new System.Drawing.Size(85, 38);
            this.btnEditAcc.TabIndex = 3;
            this.btnEditAcc.Text = "Edit Account";
            this.btnEditAcc.UseVisualStyleBackColor = false;
            this.btnEditAcc.Click += new System.EventHandler(this.btnEditAcc_Click);
            // 
            // Form_BorrowerAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteAcc);
            this.Controls.Add(this.btnEditAcc);
            this.Controls.Add(this.btnAddAcc);
            this.Controls.Add(this.dgvBorrowerAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_BorrowerAccounts";
            this.Text = "Form_BorrowerAccounts";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowerAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBorrowerAccounts;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.Button btnDeleteAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPassword;
        private System.Windows.Forms.Button btnEditAcc;
    }
}