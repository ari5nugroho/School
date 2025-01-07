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
            this.label7 = new System.Windows.Forms.Label();
            this.GDVSch = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSchTcr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSchDay = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSchTime = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDelSch = new System.Windows.Forms.Button();
            this.btnEdtSch = new System.Windows.Forms.Button();
            this.btnAddSch = new System.Windows.Forms.Button();
            this.cmbSchCls = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSchSub = new System.Windows.Forms.TextBox();
            this.txtSchName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GDVSch)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.label7.Location = new System.Drawing.Point(361, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 31);
            this.label7.TabIndex = 33;
            this.label7.Text = "Schedule List";
            // 
            // GDVSch
            // 
            this.GDVSch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GDVSch.BackgroundColor = System.Drawing.Color.White;
            this.GDVSch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GDVSch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDVSch.GridColor = System.Drawing.Color.Purple;
            this.GDVSch.Location = new System.Drawing.Point(53, 478);
            this.GDVSch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GDVSch.Name = "GDVSch";
            this.GDVSch.ReadOnly = true;
            this.GDVSch.RowHeadersWidth = 51;
            this.GDVSch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GDVSch.Size = new System.Drawing.Size(773, 289);
            this.GDVSch.TabIndex = 46;
            this.GDVSch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GDVSch_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label6.Location = new System.Drawing.Point(90, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 50;
            this.label6.Text = "Teacher ID";
            // 
            // cmbSchTcr
            // 
            this.cmbSchTcr.FormattingEnabled = true;
            this.cmbSchTcr.Location = new System.Drawing.Point(93, 170);
            this.cmbSchTcr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSchTcr.Name = "cmbSchTcr";
            this.cmbSchTcr.Size = new System.Drawing.Size(224, 24);
            this.cmbSchTcr.TabIndex = 49;
            this.cmbSchTcr.SelectedIndexChanged += new System.EventHandler(this.cmbSchTcr_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(612, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(412, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 54;
            this.label3.Text = "Day";
            // 
            // cmbSchDay
            // 
            this.cmbSchDay.FormattingEnabled = true;
            this.cmbSchDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.cmbSchDay.Location = new System.Drawing.Point(415, 171);
            this.cmbSchDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSchDay.Name = "cmbSchDay";
            this.cmbSchDay.Size = new System.Drawing.Size(132, 24);
            this.cmbSchDay.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label4.Location = new System.Drawing.Point(612, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
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
            this.cmbSchTime.Location = new System.Drawing.Point(615, 172);
            this.cmbSchTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSchTime.Name = "cmbSchTime";
            this.cmbSchTime.Size = new System.Drawing.Size(132, 24);
            this.cmbSchTime.TabIndex = 55;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(566, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 47);
            this.button4.TabIndex = 68;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDelSch
            // 
            this.btnDelSch.AutoSize = true;
            this.btnDelSch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnDelSch.ForeColor = System.Drawing.Color.White;
            this.btnDelSch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelSch.Location = new System.Drawing.Point(428, 363);
            this.btnDelSch.Name = "btnDelSch";
            this.btnDelSch.Size = new System.Drawing.Size(132, 47);
            this.btnDelSch.TabIndex = 67;
            this.btnDelSch.Text = "Delete";
            this.btnDelSch.UseVisualStyleBackColor = false;
            this.btnDelSch.Click += new System.EventHandler(this.btnDelSch_Click);
            // 
            // btnEdtSch
            // 
            this.btnEdtSch.AutoSize = true;
            this.btnEdtSch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnEdtSch.ForeColor = System.Drawing.Color.White;
            this.btnEdtSch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdtSch.Location = new System.Drawing.Point(290, 363);
            this.btnEdtSch.Name = "btnEdtSch";
            this.btnEdtSch.Size = new System.Drawing.Size(132, 47);
            this.btnEdtSch.TabIndex = 66;
            this.btnEdtSch.Text = "Edit";
            this.btnEdtSch.UseVisualStyleBackColor = false;
            this.btnEdtSch.Click += new System.EventHandler(this.btnEdtSch_Click);
            // 
            // btnAddSch
            // 
            this.btnAddSch.AutoSize = true;
            this.btnAddSch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnAddSch.ForeColor = System.Drawing.Color.White;
            this.btnAddSch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSch.Location = new System.Drawing.Point(152, 363);
            this.btnAddSch.Name = "btnAddSch";
            this.btnAddSch.Size = new System.Drawing.Size(132, 47);
            this.btnAddSch.TabIndex = 65;
            this.btnAddSch.Text = "Add";
            this.btnAddSch.UseVisualStyleBackColor = false;
            this.btnAddSch.Click += new System.EventHandler(this.btnAddSch_Click);
            // 
            // cmbSchCls
            // 
            this.cmbSchCls.FormattingEnabled = true;
            this.cmbSchCls.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.cmbSchCls.Location = new System.Drawing.Point(616, 238);
            this.cmbSchCls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSchCls.Name = "cmbSchCls";
            this.cmbSchCls.Size = new System.Drawing.Size(131, 24);
            this.cmbSchCls.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label5.Location = new System.Drawing.Point(89, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 69;
            this.label5.Text = "Subject";
            // 
            // txtSchSub
            // 
            this.txtSchSub.Enabled = false;
            this.txtSchSub.Location = new System.Drawing.Point(93, 307);
            this.txtSchSub.Multiline = true;
            this.txtSchSub.Name = "txtSchSub";
            this.txtSchSub.Size = new System.Drawing.Size(224, 27);
            this.txtSchSub.TabIndex = 70;
            // 
            // txtSchName
            // 
            this.txtSchName.Enabled = false;
            this.txtSchName.Location = new System.Drawing.Point(94, 235);
            this.txtSchName.Multiline = true;
            this.txtSchName.Name = "txtSchName";
            this.txtSchName.Size = new System.Drawing.Size(223, 27);
            this.txtSchName.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label8.Location = new System.Drawing.Point(90, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 23);
            this.label8.TabIndex = 71;
            this.label8.Text = "Teacher Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 14.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label9.Location = new System.Drawing.Point(88, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 32);
            this.label9.TabIndex = 73;
            this.label9.Text = "Add Schedule";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lesson Schedule";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(808, 11);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(47, 34);
            this.guna2ControlBox1.TabIndex = 73;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(753, 11);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(47, 34);
            this.guna2ControlBox2.TabIndex = 74;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 58);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::login.Properties.Resources.pngwing_com__2_;
            this.pictureBox1.Location = new System.Drawing.Point(33, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::login.Properties.Resources.icons8_download_40;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(703, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 47);
            this.button1.TabIndex = 74;
            this.button1.Text = "        Ekspor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // schedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSchName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSchSub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDelSch);
            this.Controls.Add(this.btnEdtSch);
            this.Controls.Add(this.btnAddSch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSchTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSchDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSchCls);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSchTcr);
            this.Controls.Add(this.GDVSch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "schedule";
            this.Size = new System.Drawing.Size(873, 795);
            this.Load += new System.EventHandler(this.schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GDVSch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView GDVSch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSchTcr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSchDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSchTime;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDelSch;
        private System.Windows.Forms.Button btnEdtSch;
        private System.Windows.Forms.Button btnAddSch;
        private System.Windows.Forms.ComboBox cmbSchCls;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSchSub;
        private System.Windows.Forms.TextBox txtSchName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}
