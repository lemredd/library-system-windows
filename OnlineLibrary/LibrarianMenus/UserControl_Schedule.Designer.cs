namespace OnlineLibrary.Panel_LibrarianUI
{
    partial class UserControl_Schedule
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvSchedules = new System.Windows.Forms.DataGridView();
            this.txtScheduleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Schedules";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(123)))), ((int)(((byte)(0)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(488, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 53);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit Schedule";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.dgvSchedules.Location = new System.Drawing.Point(0, 59);
            this.dgvSchedules.Name = "dgvSchedules";
            this.dgvSchedules.ReadOnly = true;
            this.dgvSchedules.Size = new System.Drawing.Size(681, 376);
            this.dgvSchedules.TabIndex = 4;
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
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(582, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 53);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Schedule";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UserControl_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSchedules);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_Schedule";
            this.Size = new System.Drawing.Size(681, 435);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvSchedules;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtScheduleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIsbn;
        private System.Windows.Forms.Button btnDelete;
    }
}
