namespace login.View
{
    partial class schedule
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
            this.label7 = new System.Windows.Forms.Label();
            this.GDVStd = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSchTcr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSchCls = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSchDay = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSchTime = new System.Windows.Forms.ComboBox();
            this.btnDelSch = new System.Windows.Forms.Button();
            this.btnEdtSch = new System.Windows.Forms.Button();
            this.btnAddSch = new System.Windows.Forms.Button();
            this.btnRstSch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDVStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 51);
            this.panel1.TabIndex = 3;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(752, 8);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(807, 8);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(47, 34);
            this.guna2ControlBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lesson Schedule";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label7.Location = new System.Drawing.Point(344, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 36);
            this.label7.TabIndex = 33;
            this.label7.Text = "Schedule List";
            // 
            // GDVStd
            // 
            this.GDVStd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GDVStd.BackgroundColor = System.Drawing.Color.White;
            this.GDVStd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GDVStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDVStd.GridColor = System.Drawing.Color.Purple;
            this.GDVStd.Location = new System.Drawing.Point(32, 534);
            this.GDVStd.Name = "GDVStd";
            this.GDVStd.ReadOnly = true;
            this.GDVStd.RowHeadersWidth = 51;
            this.GDVStd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GDVStd.Size = new System.Drawing.Size(803, 231);
            this.GDVStd.TabIndex = 46;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::login.Properties.Resources.pngwing_com__2_;
            this.pictureBox1.Location = new System.Drawing.Point(32, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label6.Location = new System.Drawing.Point(102, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 26);
            this.label6.TabIndex = 50;
            this.label6.Text = "Teacher";
            // 
            // cmbSchTcr
            // 
            this.cmbSchTcr.FormattingEnabled = true;
            this.cmbSchTcr.Location = new System.Drawing.Point(106, 119);
            this.cmbSchTcr.Name = "cmbSchTcr";
            this.cmbSchTcr.Size = new System.Drawing.Size(300, 28);
            this.cmbSchTcr.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(477, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 52;
            this.label2.Text = "Class";
            // 
            // cmbSchCls
            // 
            this.cmbSchCls.FormattingEnabled = true;
            this.cmbSchCls.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.cmbSchCls.Location = new System.Drawing.Point(481, 116);
            this.cmbSchCls.Name = "cmbSchCls";
            this.cmbSchCls.Size = new System.Drawing.Size(201, 28);
            this.cmbSchCls.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(102, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 26);
            this.label3.TabIndex = 54;
            this.label3.Text = "Day";
            // 
            // cmbSchDay
            // 
            this.cmbSchDay.FormattingEnabled = true;
            this.cmbSchDay.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.cmbSchDay.Location = new System.Drawing.Point(106, 204);
            this.cmbSchDay.Name = "cmbSchDay";
            this.cmbSchDay.Size = new System.Drawing.Size(201, 28);
            this.cmbSchDay.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label4.Location = new System.Drawing.Point(101, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 56;
            this.label4.Text = "Time";
            // 
            // cmbSchTime
            // 
            this.cmbSchTime.FormattingEnabled = true;
            this.cmbSchTime.Items.AddRange(new object[] {
            "07.00 - 08.40",
            "08.50 - 10.30",
            "10.40 - 12.20",
            "13.20 - 15.00",
            "15.30 - 17.10"});
            this.cmbSchTime.Location = new System.Drawing.Point(105, 291);
            this.cmbSchTime.Name = "cmbSchTime";
            this.cmbSchTime.Size = new System.Drawing.Size(201, 28);
            this.cmbSchTime.TabIndex = 55;
            // 
            // btnDelSch
            // 
            this.btnDelSch.AutoSize = true;
            this.btnDelSch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnDelSch.ForeColor = System.Drawing.Color.White;
            this.btnDelSch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelSch.Location = new System.Drawing.Point(444, 374);
            this.btnDelSch.Name = "btnDelSch";
            this.btnDelSch.Size = new System.Drawing.Size(132, 47);
            this.btnDelSch.TabIndex = 60;
            this.btnDelSch.Text = "Delete";
            this.btnDelSch.UseVisualStyleBackColor = false;
            // 
            // btnEdtSch
            // 
            this.btnEdtSch.AutoSize = true;
            this.btnEdtSch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnEdtSch.ForeColor = System.Drawing.Color.White;
            this.btnEdtSch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdtSch.Location = new System.Drawing.Point(296, 374);
            this.btnEdtSch.Name = "btnEdtSch";
            this.btnEdtSch.Size = new System.Drawing.Size(132, 47);
            this.btnEdtSch.TabIndex = 59;
            this.btnEdtSch.Text = "Edit";
            this.btnEdtSch.UseVisualStyleBackColor = false;
            // 
            // btnAddSch
            // 
            this.btnAddSch.AutoSize = true;
            this.btnAddSch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnAddSch.ForeColor = System.Drawing.Color.White;
            this.btnAddSch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSch.Location = new System.Drawing.Point(144, 374);
            this.btnAddSch.Name = "btnAddSch";
            this.btnAddSch.Size = new System.Drawing.Size(132, 47);
            this.btnAddSch.TabIndex = 58;
            this.btnAddSch.Text = "Add";
            this.btnAddSch.UseVisualStyleBackColor = false;
            // 
            // btnRstSch
            // 
            this.btnRstSch.AutoSize = true;
            this.btnRstSch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnRstSch.ForeColor = System.Drawing.Color.White;
            this.btnRstSch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRstSch.Location = new System.Drawing.Point(596, 374);
            this.btnRstSch.Name = "btnRstSch";
            this.btnRstSch.Size = new System.Drawing.Size(132, 47);
            this.btnRstSch.TabIndex = 61;
            this.btnRstSch.Text = "Reset";
            this.btnRstSch.UseVisualStyleBackColor = false;
            // 
            // schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelSch);
            this.Controls.Add(this.btnEdtSch);
            this.Controls.Add(this.btnAddSch);
            this.Controls.Add(this.btnRstSch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSchTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSchDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSchCls);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSchTcr);
            this.Controls.Add(this.GDVStd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "schedule";
            this.Size = new System.Drawing.Size(873, 795);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDVStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView GDVStd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSchTcr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSchCls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSchDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSchTime;
        private System.Windows.Forms.Button btnDelSch;
        private System.Windows.Forms.Button btnEdtSch;
        private System.Windows.Forms.Button btnAddSch;
        private System.Windows.Forms.Button btnRstSch;
    }
}
