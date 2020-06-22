namespace UX_Login_Insta
{
    partial class FormLogin
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelDividrButton = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lolForgot = new System.Windows.Forms.LinkLabel();
            this.lblSingUp = new System.Windows.Forms.LinkLabel();
            this.cbRemember = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.BackgroundImage = global::UX_Login_Insta.Properties.Resources._51866dbeaee33124236fcb9a192619c5;
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop.Controls.Add(this.panelDividrButton);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(468, 46);
            this.panelTop.TabIndex = 5;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // panelDividrButton
            // 
            this.panelDividrButton.BackColor = System.Drawing.Color.Black;
            this.panelDividrButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDividrButton.Location = new System.Drawing.Point(418, 0);
            this.panelDividrButton.Name = "panelDividrButton";
            this.panelDividrButton.Size = new System.Drawing.Size(2, 46);
            this.panelDividrButton.TabIndex = 27;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnExit.Location = new System.Drawing.Point(420, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 46);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 515);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 31);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "github.com/MrCl0wnLab";
            // 
            // lolForgot
            // 
            this.lolForgot.AutoSize = true;
            this.lolForgot.BackColor = System.Drawing.Color.Transparent;
            this.lolForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lolForgot.ForeColor = System.Drawing.Color.White;
            this.lolForgot.LinkColor = System.Drawing.Color.White;
            this.lolForgot.Location = new System.Drawing.Point(111, 425);
            this.lolForgot.Name = "lolForgot";
            this.lolForgot.Size = new System.Drawing.Size(162, 18);
            this.lolForgot.TabIndex = 33;
            this.lolForgot.TabStop = true;
            this.lolForgot.Text = "Forgot your password?";
            // 
            // lblSingUp
            // 
            this.lblSingUp.AutoSize = true;
            this.lblSingUp.BackColor = System.Drawing.Color.Transparent;
            this.lblSingUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSingUp.ForeColor = System.Drawing.Color.White;
            this.lblSingUp.LinkColor = System.Drawing.Color.White;
            this.lblSingUp.Location = new System.Drawing.Point(36, 425);
            this.lblSingUp.Name = "lblSingUp";
            this.lblSingUp.Size = new System.Drawing.Size(57, 18);
            this.lblSingUp.TabIndex = 32;
            this.lblSingUp.TabStop = true;
            this.lblSingUp.Text = "Sign up";
            // 
            // cbRemember
            // 
            this.cbRemember.AutoSize = true;
            this.cbRemember.BackColor = System.Drawing.Color.Transparent;
            this.cbRemember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRemember.ForeColor = System.Drawing.Color.White;
            this.cbRemember.Location = new System.Drawing.Point(42, 284);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(130, 24);
            this.cbRemember.TabIndex = 31;
            this.cbRemember.Text = "Remember me";
            this.cbRemember.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Email";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(14)))), ((int)(((byte)(71)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(39, 326);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(391, 69);
            this.btnLogin.TabIndex = 28;
            this.btnLogin.Tag = "";
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(14)))), ((int)(((byte)(71)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(39, 243);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(391, 28);
            this.txtPassword.TabIndex = 27;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(14)))), ((int)(((byte)(71)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(39, 187);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(391, 28);
            this.txtEmail.TabIndex = 26;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::UX_Login_Insta.Properties.Resources.logo_insta;
            this.picLogo.Location = new System.Drawing.Point(182, 52);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(104, 112);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 34;
            this.picLogo.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(14)))), ((int)(((byte)(71)))));
            this.BackgroundImage = global::UX_Login_Insta.Properties.Resources._51866dbeaee33124236fcb9a192619c5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(468, 546);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lolForgot);
            this.Controls.Add(this.lblSingUp);
            this.Controls.Add(this.cbRemember);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelDividrButton;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lolForgot;
        private System.Windows.Forms.LinkLabel lblSingUp;
        private System.Windows.Forms.CheckBox cbRemember;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox picLogo;
    }
}