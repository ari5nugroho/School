﻿namespace login.View
{
    partial class Teachers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSubjectTcr = new System.Windows.Forms.ComboBox();
            this.txtPhoneTcr = new System.Windows.Forms.TextBox();
            this.btnDelTcr = new System.Windows.Forms.Button();
            this.btnEdtTcr = new System.Windows.Forms.Button();
            this.btnAddTcr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDOBTcr = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdrsTcr = new System.Windows.Forms.TextBox();
            this.txtNameTcr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGenTcr = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GDVTcr = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDVTcr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 58);
            this.panel1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(754, 13);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(47, 34);
            this.guna2ControlBox2.TabIndex = 11;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(809, 13);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(47, 34);
            this.guna2ControlBox1.TabIndex = 10;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teacher";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label8.Location = new System.Drawing.Point(597, 251);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 23);
            this.label8.TabIndex = 62;
            this.label8.Text = "Subjects";
            // 
            // cmbSubjectTcr
            // 
            this.cmbSubjectTcr.FormattingEnabled = true;
            this.cmbSubjectTcr.Items.AddRange(new object[] {
            "Math",
            "English",
            "Bahasa Indonesia",
            "Religius",
            "Geographi",
            "Chemistry",
            "Biology",
            "Physics"});
            this.cmbSubjectTcr.Location = new System.Drawing.Point(601, 273);
            this.cmbSubjectTcr.Name = "cmbSubjectTcr";
            this.cmbSubjectTcr.Size = new System.Drawing.Size(122, 24);
            this.cmbSubjectTcr.TabIndex = 61;
            this.cmbSubjectTcr.SelectedIndexChanged += new System.EventHandler(this.cmbSubjectTcr_SelectedIndexChanged);
            // 
            // txtPhoneTcr
            // 
            this.txtPhoneTcr.Location = new System.Drawing.Point(137, 273);
            this.txtPhoneTcr.Multiline = true;
            this.txtPhoneTcr.Name = "txtPhoneTcr";
            this.txtPhoneTcr.Size = new System.Drawing.Size(291, 27);
            this.txtPhoneTcr.TabIndex = 60;
            // 
            // btnDelTcr
            // 
            this.btnDelTcr.AutoSize = true;
            this.btnDelTcr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnDelTcr.ForeColor = System.Drawing.Color.White;
            this.btnDelTcr.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelTcr.Location = new System.Drawing.Point(460, 423);
            this.btnDelTcr.Name = "btnDelTcr";
            this.btnDelTcr.Size = new System.Drawing.Size(132, 47);
            this.btnDelTcr.TabIndex = 56;
            this.btnDelTcr.Text = "Delete";
            this.btnDelTcr.UseVisualStyleBackColor = false;
            this.btnDelTcr.Click += new System.EventHandler(this.btnDelTcr_Click);
            // 
            // btnEdtTcr
            // 
            this.btnEdtTcr.AutoSize = true;
            this.btnEdtTcr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnEdtTcr.ForeColor = System.Drawing.Color.White;
            this.btnEdtTcr.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdtTcr.Location = new System.Drawing.Point(312, 423);
            this.btnEdtTcr.Name = "btnEdtTcr";
            this.btnEdtTcr.Size = new System.Drawing.Size(132, 47);
            this.btnEdtTcr.TabIndex = 55;
            this.btnEdtTcr.Text = "Edit";
            this.btnEdtTcr.UseVisualStyleBackColor = false;
            this.btnEdtTcr.Click += new System.EventHandler(this.btnEdtTcr_Click);
            // 
            // btnAddTcr
            // 
            this.btnAddTcr.AutoSize = true;
            this.btnAddTcr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnAddTcr.ForeColor = System.Drawing.Color.White;
            this.btnAddTcr.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddTcr.Location = new System.Drawing.Point(160, 423);
            this.btnAddTcr.Name = "btnAddTcr";
            this.btnAddTcr.Size = new System.Drawing.Size(132, 47);
            this.btnAddTcr.TabIndex = 54;
            this.btnAddTcr.Text = "Add";
            this.btnAddTcr.UseVisualStyleBackColor = false;
            this.btnAddTcr.Click += new System.EventHandler(this.btnAddTcr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(133, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 59;
            this.label2.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label7.Location = new System.Drawing.Point(362, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 31);
            this.label7.TabIndex = 51;
            this.label7.Text = "Teachers List";
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(612, 423);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 47);
            this.button4.TabIndex = 57;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label6.Location = new System.Drawing.Point(133, 332);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 53;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label5.Location = new System.Drawing.Point(597, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 52;
            this.label5.Text = "DOB";
            // 
            // dtDOBTcr
            // 
            this.dtDOBTcr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDOBTcr.Location = new System.Drawing.Point(601, 186);
            this.dtDOBTcr.Name = "dtDOBTcr";
            this.dtDOBTcr.Size = new System.Drawing.Size(122, 22);
            this.dtDOBTcr.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label4.Location = new System.Drawing.Point(459, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 49;
            this.label4.Text = "Gender";
            // 
            // txtAdrsTcr
            // 
            this.txtAdrsTcr.Location = new System.Drawing.Point(137, 354);
            this.txtAdrsTcr.Multiline = true;
            this.txtAdrsTcr.Name = "txtAdrsTcr";
            this.txtAdrsTcr.Size = new System.Drawing.Size(435, 27);
            this.txtAdrsTcr.TabIndex = 47;
            // 
            // txtNameTcr
            // 
            this.txtNameTcr.Location = new System.Drawing.Point(137, 186);
            this.txtNameTcr.Multiline = true;
            this.txtNameTcr.Name = "txtNameTcr";
            this.txtNameTcr.Size = new System.Drawing.Size(291, 27);
            this.txtNameTcr.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(133, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Name";
            // 
            // cmbGenTcr
            // 
            this.cmbGenTcr.FormattingEnabled = true;
            this.cmbGenTcr.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGenTcr.Location = new System.Drawing.Point(463, 186);
            this.cmbGenTcr.Name = "cmbGenTcr";
            this.cmbGenTcr.Size = new System.Drawing.Size(109, 24);
            this.cmbGenTcr.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 14.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label9.Location = new System.Drawing.Point(131, 93);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 32);
            this.label9.TabIndex = 63;
            this.label9.Text = "Add Teacher";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // GDVTcr
            // 
            this.GDVTcr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GDVTcr.BackgroundColor = System.Drawing.Color.White;
            this.GDVTcr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GDVTcr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDVTcr.GridColor = System.Drawing.Color.Purple;
            this.GDVTcr.Location = new System.Drawing.Point(38, 524);
            this.GDVTcr.Name = "GDVTcr";
            this.GDVTcr.ReadOnly = true;
            this.GDVTcr.RowHeadersWidth = 51;
            this.GDVTcr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GDVTcr.Size = new System.Drawing.Size(803, 251);
            this.GDVTcr.TabIndex = 64;
            this.GDVTcr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GDVTcr_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::login.Properties.Resources.icons8_teacher_64;
            this.pictureBox1.Location = new System.Drawing.Point(36, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Teachers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GDVTcr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbSubjectTcr);
            this.Controls.Add(this.txtPhoneTcr);
            this.Controls.Add(this.btnDelTcr);
            this.Controls.Add(this.btnEdtTcr);
            this.Controls.Add(this.btnAddTcr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtDOBTcr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdrsTcr);
            this.Controls.Add(this.txtNameTcr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGenTcr);
            this.Controls.Add(this.panel1);
            this.Name = "Teachers";
            this.Size = new System.Drawing.Size(873, 795);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDVTcr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSubjectTcr;
        private System.Windows.Forms.TextBox txtPhoneTcr;
        private System.Windows.Forms.Button btnDelTcr;
        private System.Windows.Forms.Button btnEdtTcr;
        private System.Windows.Forms.Button btnAddTcr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtDOBTcr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdrsTcr;
        private System.Windows.Forms.TextBox txtNameTcr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGenTcr;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.DataGridView GDVTcr;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
