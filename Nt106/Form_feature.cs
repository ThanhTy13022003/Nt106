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
    public partial class Form_feature : Form
    {
        public Form_feature()
        {
            InitializeComponent();
            this.ShowInTaskbar = false; // Ẩn Form khỏi Taskbar
            this.MouseEnter += (s, e) => this.Activate();
        }
    }
}
