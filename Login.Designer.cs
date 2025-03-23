﻿namespace Caro
{
    partial class Login
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.signin = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.forgotpw = new System.Windows.Forms.Label();
            this.remember = new System.Windows.Forms.CheckBox();
            this.show = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Gray;
            this.username.Location = new System.Drawing.Point(57, 127);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(342, 47);
            this.username.TabIndex = 2;
            this.username.Text = "User Name or Email";
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Gray;
            this.password.Location = new System.Drawing.Point(57, 195);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(342, 47);
            this.password.TabIndex = 3;
            this.password.Text = "Pass Word";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // signin
            // 
            this.signin.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.signin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.ForeColor = System.Drawing.Color.White;
            this.signin.Location = new System.Drawing.Point(57, 311);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(151, 50);
            this.signin.TabIndex = 4;
            this.signin.Text = "Sign In";
            this.signin.UseVisualStyleBackColor = false;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.signup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.Color.White;
            this.signup.Location = new System.Drawing.Point(246, 311);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(153, 50);
            this.signup.TabIndex = 5;
            this.signup.Text = "Sign Up";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // forgotpw
            // 
            this.forgotpw.AutoSize = true;
            this.forgotpw.BackColor = System.Drawing.Color.White;
            this.forgotpw.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotpw.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.forgotpw.Location = new System.Drawing.Point(161, 387);
            this.forgotpw.Name = "forgotpw";
            this.forgotpw.Size = new System.Drawing.Size(124, 19);
            this.forgotpw.TabIndex = 6;
            this.forgotpw.Text = "Forgot Password";
            this.forgotpw.Click += new System.EventHandler(this.forgotpw_Click);
            // 
            // remember
            // 
            this.remember.AutoSize = true;
            this.remember.BackColor = System.Drawing.Color.White;
            this.remember.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.remember.Location = new System.Drawing.Point(57, 257);
            this.remember.Name = "remember";
            this.remember.Size = new System.Drawing.Size(119, 20);
            this.remember.TabIndex = 7;
            this.remember.Text = "Remember Me";
            this.remember.UseVisualStyleBackColor = false;
            this.remember.CheckedChanged += new System.EventHandler(this.remember_CheckedChanged);
            // 
            // show
            // 
            this.show.AutoSize = true;
            this.show.BackColor = System.Drawing.Color.White;
            this.show.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.show.Location = new System.Drawing.Point(275, 257);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(124, 20);
            this.show.TabIndex = 8;
            this.show.Text = "Show password";
            this.show.UseVisualStyleBackColor = false;
            this.show.CheckedChanged += new System.EventHandler(this.show_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(139, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 53);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sign In";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::Caro.Properties.Resources.register_form_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show);
            this.Controls.Add(this.remember);
            this.Controls.Add(this.forgotpw);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        internal System.Windows.Forms.Button signin;
        internal System.Windows.Forms.Button signup;
        private System.Windows.Forms.Label forgotpw;
        private System.Windows.Forms.CheckBox remember;
        private System.Windows.Forms.CheckBox show;
        private System.Windows.Forms.Label label1;
    }
}