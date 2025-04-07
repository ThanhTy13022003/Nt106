namespace Caro
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
            System.Windows.Forms.PictureBox picAva;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLAN = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.pcbMark = new System.Windows.Forms.PictureBox();
            this.prcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
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
            picAva.Location = new System.Drawing.Point(5, 3);
            picAva.Name = "picAva";
            picAva.Size = new System.Drawing.Size(292, 294);
            picAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picAva.TabIndex = 0;
            picAva.TabStop = false;
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChessBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlChessBoard.Location = new System.Drawing.Point(12, 12);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(670, 584);
            this.pnlChessBoard.TabIndex = 0;
            this.pnlChessBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChessBoard_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(picAva);
            this.panel2.Location = new System.Drawing.Point(725, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 300);
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
            this.panel3.Location = new System.Drawing.Point(725, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 197);
            this.panel3.TabIndex = 2;
            // 
            // btnLAN

            // 
            this.btnLAN.Location = new System.Drawing.Point(0, 149);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(131, 23);
            this.btnLAN.TabIndex = 4;
            this.btnLAN.Text = "Play";
            this.btnLAN.UseVisualStyleBackColor = true;

            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChessBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlChessBoard.Location = new System.Drawing.Point(12, 12);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(670, 584);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(picAva);
            this.panel2.Location = new System.Drawing.Point(694, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 300);
            this.panel2.TabIndex = 1;

            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(1, 100);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(130, 22);
            this.txtIP.TabIndex = 3;
            this.txtIP.Text = "127.0.0.1";

            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnLAN);
            this.panel3.Controls.Add(this.txtIP);
            this.panel3.Controls.Add(this.pcbMark);
            this.panel3.Controls.Add(this.prcbCoolDown);
            this.panel3.Controls.Add(this.txtPlayerName);
            this.panel3.Location = new System.Drawing.Point(694, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 197);
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
            // prcbCoolDown
            // 
            this.prcbCoolDown.Location = new System.Drawing.Point(0, 53);
            this.prcbCoolDown.Name = "prcbCoolDown";
            this.prcbCoolDown.Size = new System.Drawing.Size(131, 23);
            this.prcbCoolDown.TabIndex = 1;
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

            // txtPlayerName
            // 

            this.txtPlayerName.Location = new System.Drawing.Point(1, 3);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.ReadOnly = true;
            this.txtPlayerName.Size = new System.Drawing.Size(130, 22);
            this.txtPlayerName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 674);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlChessBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

