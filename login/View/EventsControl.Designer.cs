﻿namespace login.View
{
    partial class EventsControl
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
            this.label5 = new System.Windows.Forms.Label();
            this.dtEvent = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNameEvnt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHourEvnt = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDelEvnt = new System.Windows.Forms.Button();
            this.btnEdtEvnt = new System.Windows.Forms.Button();
            this.btnAddEvnt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.GDVEvnt = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDVEvnt)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(873, 58);
            this.panel1.TabIndex = 2;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(752, 12);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(807, 12);
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
            this.label1.Location = new System.Drawing.Point(100, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Events School";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label5.Location = new System.Drawing.Point(101, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 26);
            this.label5.TabIndex = 58;
            this.label5.Text = "Date";
            // 
            // dtEvent
            // 
            this.dtEvent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEvent.Location = new System.Drawing.Point(106, 254);
            this.dtEvent.Name = "dtEvent";
            this.dtEvent.Size = new System.Drawing.Size(123, 26);
            this.dtEvent.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label6.Location = new System.Drawing.Point(419, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 26);
            this.label6.TabIndex = 56;
            this.label6.Text = "Duration in Hours";
            // 
            // txtNameEvnt
            // 
            this.txtNameEvnt.Location = new System.Drawing.Point(106, 170);
            this.txtNameEvnt.Multiline = true;
            this.txtNameEvnt.Name = "txtNameEvnt";
            this.txtNameEvnt.Size = new System.Drawing.Size(271, 27);
            this.txtNameEvnt.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(101, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 26);
            this.label3.TabIndex = 53;
            this.label3.Text = "Name Events";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 14.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label9.Location = new System.Drawing.Point(100, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 40);
            this.label9.TabIndex = 52;
            this.label9.Text = "Add Events";
            // 
            // txtHourEvnt
            // 
            this.txtHourEvnt.Location = new System.Drawing.Point(423, 170);
            this.txtHourEvnt.Multiline = true;
            this.txtHourEvnt.Name = "txtHourEvnt";
            this.txtHourEvnt.Size = new System.Drawing.Size(205, 27);
            this.txtHourEvnt.TabIndex = 59;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(579, 385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 47);
            this.button4.TabIndex = 63;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDelEvnt
            // 
            this.btnDelEvnt.AutoSize = true;
            this.btnDelEvnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnDelEvnt.ForeColor = System.Drawing.Color.White;
            this.btnDelEvnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelEvnt.Location = new System.Drawing.Point(442, 385);
            this.btnDelEvnt.Name = "btnDelEvnt";
            this.btnDelEvnt.Size = new System.Drawing.Size(132, 47);
            this.btnDelEvnt.TabIndex = 62;
            this.btnDelEvnt.Text = "Delete";
            this.btnDelEvnt.UseVisualStyleBackColor = false;
            this.btnDelEvnt.Click += new System.EventHandler(this.btnDelEvnt_Click);
            // 
            // btnEdtEvnt
            // 
            this.btnEdtEvnt.AutoSize = true;
            this.btnEdtEvnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnEdtEvnt.ForeColor = System.Drawing.Color.White;
            this.btnEdtEvnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdtEvnt.Location = new System.Drawing.Point(305, 385);
            this.btnEdtEvnt.Name = "btnEdtEvnt";
            this.btnEdtEvnt.Size = new System.Drawing.Size(132, 47);
            this.btnEdtEvnt.TabIndex = 61;
            this.btnEdtEvnt.Text = "Edit";
            this.btnEdtEvnt.UseVisualStyleBackColor = false;
            this.btnEdtEvnt.Click += new System.EventHandler(this.btnEdtEvnt_Click);
            // 
            // btnAddEvnt
            // 
            this.btnAddEvnt.AutoSize = true;
            this.btnAddEvnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnAddEvnt.ForeColor = System.Drawing.Color.White;
            this.btnAddEvnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddEvnt.Location = new System.Drawing.Point(168, 385);
            this.btnAddEvnt.Name = "btnAddEvnt";
            this.btnAddEvnt.Size = new System.Drawing.Size(132, 47);
            this.btnAddEvnt.TabIndex = 60;
            this.btnAddEvnt.Text = "Add";
            this.btnAddEvnt.UseVisualStyleBackColor = false;
            this.btnAddEvnt.Click += new System.EventHandler(this.btnAddEvnt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label7.Location = new System.Drawing.Point(374, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 36);
            this.label7.TabIndex = 64;
            this.label7.Text = "Events List";
            // 
            // GDVEvnt
            // 
            this.GDVEvnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GDVEvnt.BackgroundColor = System.Drawing.Color.White;
            this.GDVEvnt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GDVEvnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDVEvnt.GridColor = System.Drawing.Color.Purple;
            this.GDVEvnt.Location = new System.Drawing.Point(32, 492);
            this.GDVEvnt.Name = "GDVEvnt";
            this.GDVEvnt.ReadOnly = true;
            this.GDVEvnt.RowHeadersWidth = 51;
            this.GDVEvnt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GDVEvnt.Size = new System.Drawing.Size(803, 251);
            this.GDVEvnt.TabIndex = 65;
            this.GDVEvnt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GDVEvent_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::login.Properties.Resources.pngwing_com__5_;
            this.pictureBox1.Location = new System.Drawing.Point(32, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // EventsControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GDVEvnt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDelEvnt);
            this.Controls.Add(this.btnEdtEvnt);
            this.Controls.Add(this.btnAddEvnt);
            this.Controls.Add(this.txtHourEvnt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtEvent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNameEvnt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EventsControl";
            this.Size = new System.Drawing.Size(873, 795);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDVEvnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtEvent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNameEvnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHourEvnt;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDelEvnt;
        private System.Windows.Forms.Button btnEdtEvnt;
        private System.Windows.Forms.Button btnAddEvnt;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.DataGridView GDVEvnt;
    }
}
