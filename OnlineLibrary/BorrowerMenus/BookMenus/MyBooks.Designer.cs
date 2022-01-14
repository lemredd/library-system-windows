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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtScheduleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtScheduleID,
            this.txtAccountID,
            this.txtBookID,
            this.txtDateStart,
            this.txtDateEnd,
            this.txtStatus});
            this.dataGridView1.Location = new System.Drawing.Point(15, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(622, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtScheduleID
            // 
            this.txtScheduleID.DataPropertyName = "schedule_id";
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
            // 
            // txtBookID
            // 
            this.txtBookID.DataPropertyName = "book_id";
            this.txtBookID.HeaderText = "Book ID";
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
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
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(15, 343);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 30);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit Schedule";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(109, 343);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Schedule";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // MyBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MyBooks";
            this.Size = new System.Drawing.Size(655, 386);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtScheduleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtStatus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}
