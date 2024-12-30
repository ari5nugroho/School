namespace login.View
{
    partial class FeesControl
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbStIdFee = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFee = new System.Windows.Forms.DateTimePicker();
            this.txtAmountFee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAddFee = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.GDVFee = new System.Windows.Forms.DataGridView();
            this.txtNameFee = new System.Windows.Forms.TextBox();
            this.btnEkspor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GDVFee)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(873, 58);
            this.panel1.TabIndex = 1;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(753, 10);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(808, 10);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(47, 34);
            this.guna2ControlBox1.TabIndex = 10;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::login.Properties.Resources.digital_wallet_icon_vector_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(32, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fees";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 14.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label9.Location = new System.Drawing.Point(100, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 32);
            this.label9.TabIndex = 45;
            this.label9.Text = "Add Fees";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label6.Location = new System.Drawing.Point(311, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 23);
            this.label6.TabIndex = 49;
            this.label6.Text = "Student Name";
            // 
            // cmbStIdFee
            // 
            this.cmbStIdFee.FormattingEnabled = true;
            this.cmbStIdFee.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbStIdFee.Location = new System.Drawing.Point(110, 162);
            this.cmbStIdFee.Name = "cmbStIdFee";
            this.cmbStIdFee.Size = new System.Drawing.Size(123, 24);
            this.cmbStIdFee.TabIndex = 48;
            this.cmbStIdFee.SelectedIndexChanged += new System.EventHandler(this.cmbStIdFee_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(106, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 46;
            this.label3.Text = "Student ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label5.Location = new System.Drawing.Point(106, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "Period";
            // 
            // dtFee
            // 
            this.dtFee.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFee.Location = new System.Drawing.Point(110, 235);
            this.dtFee.Name = "dtFee";
            this.dtFee.Size = new System.Drawing.Size(123, 22);
            this.dtFee.TabIndex = 50;
            // 
            // txtAmountFee
            // 
            this.txtAmountFee.Enabled = false;
            this.txtAmountFee.Location = new System.Drawing.Point(106, 308);
            this.txtAmountFee.Multiline = true;
            this.txtAmountFee.Name = "txtAmountFee";
            this.txtAmountFee.Size = new System.Drawing.Size(275, 27);
            this.txtAmountFee.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(106, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Amount";
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(481, 383);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 47);
            this.button4.TabIndex = 57;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAddFee
            // 
            this.btnAddFee.AutoSize = true;
            this.btnAddFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnAddFee.ForeColor = System.Drawing.Color.White;
            this.btnAddFee.Location = new System.Drawing.Point(199, 383);
            this.btnAddFee.Name = "btnAddFee";
            this.btnAddFee.Size = new System.Drawing.Size(266, 47);
            this.btnAddFee.TabIndex = 54;
            this.btnAddFee.Text = "Pay Fees";
            this.btnAddFee.UseVisualStyleBackColor = false;
            this.btnAddFee.Click += new System.EventHandler(this.btnAddFee_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label7.Location = new System.Drawing.Point(373, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 31);
            this.label7.TabIndex = 58;
            this.label7.Text = "Fees List";
            // 
            // GDVFee
            // 
            this.GDVFee.BackgroundColor = System.Drawing.Color.White;
            this.GDVFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GDVFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDVFee.Location = new System.Drawing.Point(67, 506);
            this.GDVFee.Name = "GDVFee";
            this.GDVFee.RowHeadersWidth = 51;
            this.GDVFee.Size = new System.Drawing.Size(739, 248);
            this.GDVFee.TabIndex = 59;
            this.GDVFee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GDVFee_CellClick);
            // 
            // txtNameFee
            // 
            this.txtNameFee.Enabled = false;
            this.txtNameFee.Location = new System.Drawing.Point(315, 159);
            this.txtNameFee.Multiline = true;
            this.txtNameFee.Name = "txtNameFee";
            this.txtNameFee.Size = new System.Drawing.Size(271, 27);
            this.txtNameFee.TabIndex = 60;
            // 
            // btnEkspor
            // 
            this.btnEkspor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnEkspor.ForeColor = System.Drawing.Color.White;
            this.btnEkspor.Image = global::login.Properties.Resources.icons8_download_40;
            this.btnEkspor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkspor.Location = new System.Drawing.Point(703, 69);
            this.btnEkspor.Name = "btnEkspor";
            this.btnEkspor.Size = new System.Drawing.Size(132, 47);
            this.btnEkspor.TabIndex = 75;
            this.btnEkspor.Text = "        Ekspor";
            this.btnEkspor.UseVisualStyleBackColor = false;
            this.btnEkspor.Click += new System.EventHandler(this.btnEkspor_Click);
            // 
            // FeesControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnEkspor);
            this.Controls.Add(this.txtNameFee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GDVFee);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAddFee);
            this.Controls.Add(this.txtAmountFee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbStIdFee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FeesControl";
            this.Size = new System.Drawing.Size(873, 795);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GDVFee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbStIdFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFee;
        private System.Windows.Forms.TextBox txtAmountFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAddFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView GDVFee;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.TextBox txtNameFee;
        private System.Windows.Forms.Button btnEkspor;
    }
}
