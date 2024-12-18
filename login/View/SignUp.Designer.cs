namespace login.View
{
    partial class SignUp
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCreateAcc = new Guna.UI2.WinForms.Guna2Button();
            this.NewPasstb = new Guna.UI2.WinForms.Guna2TextBox();
            this.NewUNametb = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSignin = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.btnSignin);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.btnCreateAcc);
            this.guna2Panel2.Controls.Add(this.NewPasstb);
            this.guna2Panel2.Controls.Add(this.NewUNametb);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(496, 788);
            this.guna2Panel2.TabIndex = 6;
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Animated = true;
            this.btnCreateAcc.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateAcc.BorderRadius = 10;
            this.btnCreateAcc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btnCreateAcc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreateAcc.ForeColor = System.Drawing.Color.White;
            this.btnCreateAcc.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCreateAcc.Location = new System.Drawing.Point(55, 488);
            this.btnCreateAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(372, 60);
            this.btnCreateAcc.TabIndex = 6;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.UseTransparentBackground = true;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // NewPasstb
            // 
            this.NewPasstb.Animated = true;
            this.NewPasstb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.NewPasstb.BorderRadius = 6;
            this.NewPasstb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewPasstb.DefaultText = "";
            this.NewPasstb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewPasstb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewPasstb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPasstb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPasstb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.NewPasstb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPasstb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewPasstb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPasstb.Location = new System.Drawing.Point(51, 400);
            this.NewPasstb.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.NewPasstb.Name = "NewPasstb";
            this.NewPasstb.PasswordChar = '●';
            this.NewPasstb.PlaceholderText = "Password";
            this.NewPasstb.SelectedText = "";
            this.NewPasstb.Size = new System.Drawing.Size(376, 55);
            this.NewPasstb.TabIndex = 2;
            this.NewPasstb.UseSystemPasswordChar = true;
            // 
            // NewUNametb
            // 
            this.NewUNametb.Animated = true;
            this.NewUNametb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.NewUNametb.BorderRadius = 6;
            this.NewUNametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewUNametb.DefaultText = "";
            this.NewUNametb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewUNametb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewUNametb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewUNametb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewUNametb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.NewUNametb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewUNametb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewUNametb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewUNametb.Location = new System.Drawing.Point(51, 310);
            this.NewUNametb.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.NewUNametb.Name = "NewUNametb";
            this.NewUNametb.PasswordChar = '\0';
            this.NewUNametb.PlaceholderText = "User Name";
            this.NewUNametb.SelectedText = "";
            this.NewUNametb.Size = new System.Drawing.Size(376, 55);
            this.NewUNametb.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::login.Properties.Resources.Logo_Project_AM;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(30, 14);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(52, 57);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::login.Properties.Resources.Mesa_de_trabajo_1_copia_4x;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(78, -313);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(1592, 1497);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 7;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ragile", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(47, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 86);
            this.label1.TabIndex = 7;
            this.label1.Text = "School Management \r\n          System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(48, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Welcome!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(51, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Please create an account to get started.";
            // 
            // btnSignin
            // 
            this.btnSignin.Animated = true;
            this.btnSignin.BackColor = System.Drawing.Color.Transparent;
            this.btnSignin.BorderRadius = 10;
            this.btnSignin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btnSignin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignin.ForeColor = System.Drawing.Color.White;
            this.btnSignin.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSignin.Location = new System.Drawing.Point(55, 618);
            this.btnSignin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(372, 60);
            this.btnSignin.TabIndex = 10;
            this.btnSignin.Text = "Login / Sign in";
            this.btnSignin.UseTransparentBackground = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(51, 572);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Already Have an Account?";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 788);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2PictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnCreateAcc;
        private Guna.UI2.WinForms.Guna2TextBox NewPasstb;
        private Guna.UI2.WinForms.Guna2TextBox NewUNametb;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnSignin;
        private System.Windows.Forms.Label label3;
    }
}