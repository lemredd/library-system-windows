namespace OnlineLibrary.Panel_LibrarianUI
{
    partial class UserControl_Books
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
            this.btnallbooks = new System.Windows.Forms.Button();
            this.btnaddbooks = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbsearchbook = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Books";
            // 
            // btnallbooks
            // 
            this.btnallbooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(123)))), ((int)(((byte)(0)))));
            this.btnallbooks.FlatAppearance.BorderSize = 0;
            this.btnallbooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnallbooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnallbooks.Location = new System.Drawing.Point(519, 0);
            this.btnallbooks.Name = "btnallbooks";
            this.btnallbooks.Size = new System.Drawing.Size(78, 53);
            this.btnallbooks.TabIndex = 1;
            this.btnallbooks.Text = "All Books";
            this.btnallbooks.UseVisualStyleBackColor = false;
            // 
            // btnaddbooks
            // 
            this.btnaddbooks.BackColor = System.Drawing.Color.Navy;
            this.btnaddbooks.FlatAppearance.BorderSize = 0;
            this.btnaddbooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddbooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnaddbooks.Location = new System.Drawing.Point(603, 0);
            this.btnaddbooks.Name = "btnaddbooks";
            this.btnaddbooks.Size = new System.Drawing.Size(78, 53);
            this.btnaddbooks.TabIndex = 2;
            this.btnaddbooks.Text = "+ Add Books";
            this.btnaddbooks.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(59, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sort by:";
            // 
            // tbsearchbook
            // 
            this.tbsearchbook.Location = new System.Drawing.Point(425, 4);
            this.tbsearchbook.Name = "tbsearchbook";
            this.tbsearchbook.Size = new System.Drawing.Size(255, 20);
            this.tbsearchbook.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbsearchbook);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 376);
            this.panel1.TabIndex = 8;
            // 
            // UserControl_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnaddbooks);
            this.Controls.Add(this.btnallbooks);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_Books";
            this.Size = new System.Drawing.Size(681, 435);
            this.Load += new System.EventHandler(this.UserControl_Books_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnallbooks;
        private System.Windows.Forms.Button btnaddbooks;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbsearchbook;
        private System.Windows.Forms.Panel panel1;
    }
}
