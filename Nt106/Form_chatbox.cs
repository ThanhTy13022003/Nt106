using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro
{
    public partial class Form_chatbox : Form
    {
        public Form_chatbox()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(990, 80);
            this.ShowInTaskbar = false; // Ẩn cửa sổ khỏi Taskbar
            this.MouseEnter += (s, e) => this.Activate();
        }

        private void send_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null; // Bỏ focus khỏi richTextBox2
        }
    }
}
