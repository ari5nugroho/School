namespace login.View
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFeeSB = new Guna.UI2.WinForms.Guna2Button();
            this.btnEvntSB = new Guna.UI2.WinForms.Guna2Button();
            this.btnAttSB = new Guna.UI2.WinForms.Guna2Button();
            this.btnTcrSB = new Guna.UI2.WinForms.Guna2Button();
            this.btnStdSB = new Guna.UI2.WinForms.Guna2Button();
            this.imgSlide = new System.Windows.Forms.PictureBox();
            this.btnDashSB = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dashboard1 = new login.Controller.Dashboard();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFeeSB);
            this.panel1.Controls.Add(this.btnEvntSB);
            this.panel1.Controls.Add(this.btnAttSB);
            this.panel1.Controls.Add(this.btnTcrSB);
            this.panel1.Controls.Add(this.btnStdSB);
            this.panel1.Controls.Add(this.imgSlide);
            this.panel1.Controls.Add(this.btnDashSB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 795);
            this.panel1.TabIndex = 0;
            // 
            // btnFeeSB
            // 
            this.btnFeeSB.BackColor = System.Drawing.Color.Transparent;
            this.btnFeeSB.BorderRadius = 22;
            this.btnFeeSB.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFeeSB.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnFeeSB.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnFeeSB.CheckedState.Image = global::login.Properties.Resources.digital_wallet_icon_vector;
            this.btnFeeSB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFeeSB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFeeSB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFeeSB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFeeSB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnFeeSB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeeSB.ForeColor = System.Drawing.Color.White;
            this.btnFeeSB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFeeSB.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnFeeSB.Location = new System.Drawing.Point(33, 484);
            this.btnFeeSB.Name = "btnFeeSB";
            this.btnFeeSB.Size = new System.Drawing.Size(163, 43);
            this.btnFeeSB.TabIndex = 7;
            this.btnFeeSB.Text = "Fees";
            this.btnFeeSB.UseTransparentBackground = true;
            this.btnFeeSB.CheckedChanged += new System.EventHandler(this.guna2Button6_CheckedChanged);
            this.btnFeeSB.Click += new System.EventHandler(this.btnFeeSB_Click);
            // 
            // btnEvntSB
            // 
            this.btnEvntSB.BackColor = System.Drawing.Color.Transparent;
            this.btnEvntSB.BorderRadius = 22;
            this.btnEvntSB.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEvntSB.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEvntSB.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnEvntSB.CheckedState.Image = global::login.Properties.Resources.jadwal;
            this.btnEvntSB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEvntSB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEvntSB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEvntSB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEvntSB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnEvntSB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvntSB.ForeColor = System.Drawing.Color.White;
            this.btnEvntSB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEvntSB.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnEvntSB.Location = new System.Drawing.Point(33, 411);
            this.btnEvntSB.Name = "btnEvntSB";
            this.btnEvntSB.Size = new System.Drawing.Size(163, 43);
            this.btnEvntSB.TabIndex = 6;
            this.btnEvntSB.Text = "Events";
            this.btnEvntSB.UseTransparentBackground = true;
            this.btnEvntSB.CheckedChanged += new System.EventHandler(this.guna2Button6_CheckedChanged);
            this.btnEvntSB.Click += new System.EventHandler(this.btnEvntSB_Click);
            // 
            // btnAttSB
            // 
            this.btnAttSB.BackColor = System.Drawing.Color.Transparent;
            this.btnAttSB.BorderRadius = 22;
            this.btnAttSB.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAttSB.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAttSB.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnAttSB.CheckedState.Image = global::login.Properties.Resources.education_book_logo_template_vector_illustration;
            this.btnAttSB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAttSB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAttSB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAttSB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAttSB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnAttSB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttSB.ForeColor = System.Drawing.Color.White;
            this.btnAttSB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAttSB.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnAttSB.Location = new System.Drawing.Point(33, 341);
            this.btnAttSB.Name = "btnAttSB";
            this.btnAttSB.Size = new System.Drawing.Size(163, 43);
            this.btnAttSB.TabIndex = 5;
            this.btnAttSB.Text = "Attedances";
            this.btnAttSB.UseTransparentBackground = true;
            this.btnAttSB.CheckedChanged += new System.EventHandler(this.guna2Button6_CheckedChanged);
            this.btnAttSB.Click += new System.EventHandler(this.btnAttSB_Click);
            // 
            // btnTcrSB
            // 
            this.btnTcrSB.BackColor = System.Drawing.Color.Transparent;
            this.btnTcrSB.BorderRadius = 22;
            this.btnTcrSB.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTcrSB.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnTcrSB.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnTcrSB.CheckedState.Image = global::login.Properties.Resources.teacher_icon_template_free_vector;
            this.btnTcrSB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTcrSB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTcrSB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTcrSB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTcrSB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnTcrSB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTcrSB.ForeColor = System.Drawing.Color.White;
            this.btnTcrSB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTcrSB.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnTcrSB.Location = new System.Drawing.Point(33, 270);
            this.btnTcrSB.Name = "btnTcrSB";
            this.btnTcrSB.Size = new System.Drawing.Size(163, 43);
            this.btnTcrSB.TabIndex = 4;
            this.btnTcrSB.Text = "Teachers";
            this.btnTcrSB.UseTransparentBackground = true;
            this.btnTcrSB.CheckedChanged += new System.EventHandler(this.guna2Button6_CheckedChanged);
            this.btnTcrSB.Click += new System.EventHandler(this.btnTcrSB_Click);
            // 
            // btnStdSB
            // 
            this.btnStdSB.BackColor = System.Drawing.Color.Transparent;
            this.btnStdSB.BorderRadius = 22;
            this.btnStdSB.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStdSB.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStdSB.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnStdSB.CheckedState.Image = global::login.Properties.Resources._11;
            this.btnStdSB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStdSB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStdSB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStdSB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStdSB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnStdSB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdSB.ForeColor = System.Drawing.Color.White;
            this.btnStdSB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStdSB.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnStdSB.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStdSB.Location = new System.Drawing.Point(33, 200);
            this.btnStdSB.Name = "btnStdSB";
            this.btnStdSB.Size = new System.Drawing.Size(163, 43);
            this.btnStdSB.TabIndex = 3;
            this.btnStdSB.Text = "Students";
            this.btnStdSB.UseTransparentBackground = true;
            this.btnStdSB.CheckedChanged += new System.EventHandler(this.guna2Button6_CheckedChanged);
            this.btnStdSB.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // imgSlide
            // 
            this.imgSlide.Image = global::login.Properties.Resources._2;
            this.imgSlide.Location = new System.Drawing.Point(160, 103);
            this.imgSlide.Name = "imgSlide";
            this.imgSlide.Size = new System.Drawing.Size(39, 95);
            this.imgSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSlide.TabIndex = 1;
            this.imgSlide.TabStop = false;
            // 
            // btnDashSB
            // 
            this.btnDashSB.BackColor = System.Drawing.Color.Transparent;
            this.btnDashSB.BorderRadius = 22;
            this.btnDashSB.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashSB.Checked = true;
            this.btnDashSB.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashSB.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnDashSB.CheckedState.Image = global::login.Properties.Resources.dashboard_icon_for_your_website_design_logo_app_ui_free_vector_removebg_preview;
            this.btnDashSB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashSB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashSB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashSB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashSB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnDashSB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashSB.ForeColor = System.Drawing.Color.White;
            this.btnDashSB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashSB.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnDashSB.Location = new System.Drawing.Point(33, 129);
            this.btnDashSB.Name = "btnDashSB";
            this.btnDashSB.Size = new System.Drawing.Size(163, 43);
            this.btnDashSB.TabIndex = 2;
            this.btnDashSB.Text = "Dashboard";
            this.btnDashSB.UseTransparentBackground = true;
            this.btnDashSB.CheckedChanged += new System.EventHandler(this.guna2Button6_CheckedChanged);
            this.btnDashSB.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(66, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sigma Highschool";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::login.Properties.Resources.Logo_Project_AM;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dashboard1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(199, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(0, 6, 6, 6);
            this.mainPanel.Size = new System.Drawing.Size(873, 795);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.White;
            this.dashboard1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(873, 795);
            this.dashboard1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1072, 795);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnDashSB;
        private System.Windows.Forms.PictureBox imgSlide;
        private Guna.UI2.WinForms.Guna2Button btnStdSB;
        private Guna.UI2.WinForms.Guna2Button btnFeeSB;
        private Guna.UI2.WinForms.Guna2Button btnEvntSB;
        private Guna.UI2.WinForms.Guna2Button btnAttSB;
        private Guna.UI2.WinForms.Guna2Button btnTcrSB;
        private System.Windows.Forms.Panel mainPanel;
        private Controller.Dashboard dashboard1;
    }
}