namespace OnlineLibrary.BorrowerMenus.BookMenus
{
    partial class MyBooks
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
            this.dgvSchedules = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtScheduleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSchedules
            // 
            this.dgvSchedules.AllowUserToAddRows = false;
            this.dgvSchedules.AllowUserToDeleteRows = false;
            this.dgvSchedules.BackgroundColor = System.Drawing.Color.White;
            this.dgvSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtScheduleID,
            this.txtAccountID,
            this.txtDateStart,
            this.txtDateEnd,
            this.txtStatus,
            this.txtBookID,
            this.txtTitle,
            this.txtIsbn});
            this.dgvSchedules.Location = new System.Drawing.Point(15, 17);
            this.dgvSchedules.Name = "dgvSchedules";
            this.dgvSchedules.ReadOnly = true;
            this.dgvSchedules.Size = new System.Drawing.Size(622, 320);
            this.dgvSchedules.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(15, 343);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Schedule";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtScheduleID
            // 
            this.txtScheduleID.DataPropertyName = "sched_id";
            this.txtScheduleID.HeaderText = "Schedule ID";
            this.txtScheduleID.Name = "txtScheduleID";
            this.txtScheduleID.ReadOnly = true;
            // 
            // txtAccountID
            // 
            this.txtAccountID.DataPropertyName = "account_id";
            this.txtAccountID.HeaderText = "Account ID";
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.ReadOnly = true;
            this.txtAccountID.Visible = false;
            // 
            // txtDateStart
            // 
            this.txtDateStart.DataPropertyName = "date_start";
            this.txtDateStart.HeaderText = "Date Start";
            this.txtDateStart.Name = "txtDateStart";
            this.txtDateStart.ReadOnly = true;
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.DataPropertyName = "date_end";
            this.txtDateEnd.HeaderText = "Date End";
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.ReadOnly = true;
            // 
            // txtStatus
            // 
            this.txtStatus.DataPropertyName = "status";
            this.txtStatus.HeaderText = "Status";
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
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
            this.txtTitle.HeaderText = "Title";
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            // 
            // txtIsbn
            // 
            this.txtIsbn.DataPropertyName = "isbn";
            this.txtIsbn.HeaderText = "ISBN";
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.ReadOnly = true;
            // 
            // MyBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvSchedules);
            this.Name = "MyBooks";
            this.Size = new System.Drawing.Size(655, 386);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSchedules;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtScheduleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIsbn;
    }
}
