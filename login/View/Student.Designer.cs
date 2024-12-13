namespace login.View
{
    partial class Student
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdrsStd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GDVStd = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDelStd = new System.Windows.Forms.Button();
            this.btnEdtStd = new System.Windows.Forms.Button();
            this.btnAddStd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbClsStd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDOBStd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGenStd = new System.Windows.Forms.ComboBox();
            this.txtFeeStd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameStd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GDVStd)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 58);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::login.Properties.Resources._21;
            this.pictureBox1.Location = new System.Drawing.Point(36, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students";
            // 
            // txtAdrsStd
            // 
            this.txtAdrsStd.Location = new System.Drawing.Point(124, 343);
            this.txtAdrsStd.Multiline = true;
            this.txtAdrsStd.Name = "txtAdrsStd";
            this.txtAdrsStd.Size = new System.Drawing.Size(605, 32);
            this.txtAdrsStd.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label8.Location = new System.Drawing.Point(124, 317);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 23);
            this.label8.TabIndex = 42;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label7.Location = new System.Drawing.Point(340, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 31);
            this.label7.TabIndex = 32;
            this.label7.Text = "Students List";
            // 
            // GDVStd
            // 
            this.GDVStd.BackgroundColor = System.Drawing.Color.White;
            this.GDVStd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GDVStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDVStd.Location = new System.Drawing.Point(32, 518);
            this.GDVStd.Name = "GDVStd";
            this.GDVStd.RowHeadersWidth = 51;
            this.GDVStd.Size = new System.Drawing.Size(803, 202);
            this.GDVStd.TabIndex = 41;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(571, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 32);
            this.button4.TabIndex = 40;
            this.button4.Text = "Back";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnDelStd
            // 
            this.btnDelStd.AutoSize = true;
            this.btnDelStd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnDelStd.ForeColor = System.Drawing.Color.White;
            this.btnDelStd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelStd.Location = new System.Drawing.Point(445, 405);
            this.btnDelStd.Name = "btnDelStd";
            this.btnDelStd.Size = new System.Drawing.Size(96, 32);
            this.btnDelStd.TabIndex = 39;
            this.btnDelStd.Text = "Delete";
            this.btnDelStd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelStd.UseVisualStyleBackColor = false;
            // 
            // btnEdtStd
            // 
            this.btnEdtStd.AutoSize = true;
            this.btnEdtStd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnEdtStd.ForeColor = System.Drawing.Color.White;
            this.btnEdtStd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdtStd.Location = new System.Drawing.Point(315, 405);
            this.btnEdtStd.Name = "btnEdtStd";
            this.btnEdtStd.Size = new System.Drawing.Size(96, 32);
            this.btnEdtStd.TabIndex = 38;
            this.btnEdtStd.Text = "Edit";
            this.btnEdtStd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdtStd.UseVisualStyleBackColor = false;
            // 
            // btnAddStd
            // 
            this.btnAddStd.AutoSize = true;
            this.btnAddStd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnAddStd.ForeColor = System.Drawing.Color.White;
            this.btnAddStd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddStd.Location = new System.Drawing.Point(187, 405);
            this.btnAddStd.Name = "btnAddStd";
            this.btnAddStd.Size = new System.Drawing.Size(96, 32);
            this.btnAddStd.TabIndex = 37;
            this.btnAddStd.Text = "Add";
            this.btnAddStd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddStd.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label6.Location = new System.Drawing.Point(442, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Class";
            // 
            // cmbClsStd
            // 
            this.cmbClsStd.FormattingEnabled = true;
            this.cmbClsStd.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbClsStd.Location = new System.Drawing.Point(446, 179);
            this.cmbClsStd.Name = "cmbClsStd";
            this.cmbClsStd.Size = new System.Drawing.Size(123, 24);
            this.cmbClsStd.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label5.Location = new System.Drawing.Point(603, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "DOB";
            // 
            // dtDOBStd
            // 
            this.dtDOBStd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDOBStd.Location = new System.Drawing.Point(607, 269);
            this.dtDOBStd.Name = "dtDOBStd";
            this.dtDOBStd.Size = new System.Drawing.Size(122, 22);
            this.dtDOBStd.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label4.Location = new System.Drawing.Point(603, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Gender";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbGenStd
            // 
            this.cmbGenStd.FormattingEnabled = true;
            this.cmbGenStd.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGenStd.Location = new System.Drawing.Point(607, 179);
            this.cmbGenStd.Name = "cmbGenStd";
            this.cmbGenStd.Size = new System.Drawing.Size(122, 24);
            this.cmbGenStd.TabIndex = 30;
            this.cmbGenStd.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtFeeStd
            // 
            this.txtFeeStd.Location = new System.Drawing.Point(124, 262);
            this.txtFeeStd.Multiline = true;
            this.txtFeeStd.Name = "txtFeeStd";
            this.txtFeeStd.Size = new System.Drawing.Size(275, 27);
            this.txtFeeStd.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(124, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Fees";
            // 
            // txtNameStd
            // 
            this.txtNameStd.Location = new System.Drawing.Point(124, 176);
            this.txtNameStd.Multiline = true;
            this.txtNameStd.Name = "txtNameStd";
            this.txtNameStd.Size = new System.Drawing.Size(271, 27);
            this.txtNameStd.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(124, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 14.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label9.Location = new System.Drawing.Point(122, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 32);
            this.label9.TabIndex = 44;
            this.label9.Text = "Add Student";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2ControlBox2.Location = new System.Drawing.Point(751, 10);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(47, 34);
            this.guna2ControlBox2.TabIndex = 11;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(806, 10);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(47, 34);
            this.guna2ControlBox1.TabIndex = 10;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAdrsStd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GDVStd);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDelStd);
            this.Controls.Add(this.btnEdtStd);
            this.Controls.Add(this.btnAddStd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbClsStd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtDOBStd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbGenStd);
            this.Controls.Add(this.txtFeeStd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameStd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Student";
            this.Size = new System.Drawing.Size(873, 795);
            this.Load += new System.EventHandler(this.Student_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GDVStd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAdrsStd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView GDVStd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDelStd;
        private System.Windows.Forms.Button btnEdtStd;
        private System.Windows.Forms.Button btnAddStd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbClsStd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtDOBStd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGenStd;
        private System.Windows.Forms.TextBox txtFeeStd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameStd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}
