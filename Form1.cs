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
    public partial class Form1: Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        #endregion
        public Form1()
        {
            InitializeComponent();
            ChessBoard = new ChessBoardManager(pnlChessBoard,txtPlayerName,pcbMark);// truyền pannel của form1 vào để add button
            ChessBoard.DrawChessBoard();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Hàm vẽ bàn cờ
        
    }
}
