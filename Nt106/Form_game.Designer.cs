namespace Caro
{
    partial class Form_game
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
            System.Windows.Forms.PictureBox picAva;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_game));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLAN = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.pcbMark = new System.Windows.Forms.PictureBox();
            this.prcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.chat_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.signup_button = new System.Windows.Forms.Button();
            this.signout_button = new System.Windows.Forms.Button();
            picAva = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(picAva)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMark)).BeginInit();
            this.SuspendLayout();
            // 
            // picAva
            // 
            picAva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            picAva.BackColor = System.Drawing.SystemColors.ActiveCaption;
            picAva.BackgroundImage = global::Caro.Properties.Resources.images;
            picAva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            picAva.Location = new System.Drawing.Point(43, 38);
            picAva.Name = "picAva";
            picAva.Size = new System.Drawing.Size(351, 341);
            picAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picAva.TabIndex = 0;
            picAva.TabStop = false;
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChessBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlChessBoard.Location = new System.Drawing.Point(41, 43);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(631, 600);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(picAva);
            this.panel2.Location = new System.Drawing.Point(690, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 382);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnLAN);
            this.panel3.Controls.Add(this.txtIP);
            this.panel3.Controls.Add(this.pcbMark);
            this.panel3.Controls.Add(this.prcbCoolDown);
            this.panel3.Controls.Add(this.txtPlayerName);
            this.panel3.Location = new System.Drawing.Point(811, 425);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 197);
            this.panel3.TabIndex = 2;
            // 
            // btnLAN
            // 
            this.btnLAN.Location = new System.Drawing.Point(0, 149);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(131, 27);
            this.btnLAN.TabIndex = 4;
            this.btnLAN.Text = "Play";
            this.btnLAN.UseVisualStyleBackColor = true;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(1, 100);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(130, 22);
            this.txtIP.TabIndex = 3;
            this.txtIP.Text = "127.0.0.1";
            // 
            // pcbMark
            // 
            this.pcbMark.BackColor = System.Drawing.SystemColors.Control;
            this.pcbMark.Location = new System.Drawing.Point(137, 3);
            this.pcbMark.Name = "pcbMark";
            this.pcbMark.Size = new System.Drawing.Size(160, 169);
            this.pcbMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMark.TabIndex = 2;
            this.pcbMark.TabStop = false;
            // 
            // prcbCoolDown
            // 
            this.prcbCoolDown.Location = new System.Drawing.Point(0, 53);
            this.prcbCoolDown.Name = "prcbCoolDown";
            this.prcbCoolDown.Size = new System.Drawing.Size(131, 23);
            this.prcbCoolDown.TabIndex = 1;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(1, 3);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.ReadOnly = true;
            this.txtPlayerName.Size = new System.Drawing.Size(130, 22);
            this.txtPlayerName.TabIndex = 0;
            // 
            // chat_button
            // 
            this.chat_button.Location = new System.Drawing.Point(1060, 425);
            this.chat_button.Name = "chat_button";
            this.chat_button.Size = new System.Drawing.Size(73, 67);
            this.chat_button.TabIndex = 3;
            this.chat_button.Text = "Chat Box";
            this.chat_button.UseVisualStyleBackColor = true;
            this.chat_button.Click += new System.EventHandler(this.chat_button_Click);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(1060, 509);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // signup_button
            // 
            this.signup_button.Location = new System.Drawing.Point(1060, 554);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(75, 23);
            this.signup_button.TabIndex = 5;
            this.signup_button.Text = "Sign Up";
            this.signup_button.UseVisualStyleBackColor = true;
            this.signup_button.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // signout_button
            // 
            this.signout_button.Location = new System.Drawing.Point(1058, 599);
            this.signout_button.Name = "signout_button";
            this.signout_button.Size = new System.Drawing.Size(75, 23);
            this.signout_button.TabIndex = 6;
            this.signout_button.Text = "Sign Out";
            this.signout_button.UseVisualStyleBackColor = true;
            // 
            // Form_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 655);
            this.Controls.Add(this.signout_button);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.chat_button);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlChessBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_game";
            this.Text = "Caro Chess";
            this.Load += new System.EventHandler(this.box_chat_Load);
            ((System.ComponentModel.ISupportInitialize)(picAva)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.PictureBox pcbMark;
        private System.Windows.Forms.ProgressBar prcbCoolDown;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button chat_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.Button signout_button;
    }
}

