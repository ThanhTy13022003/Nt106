using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro
{
    public class _ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;
        private TextBox playerName;
        private PictureBox mark;
        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }
        #endregion

        #region Initialize
        public _ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox mark)
        {
            this.ChessBoard = chessBoard;
            this.playerName = playerName;
            this.mark = mark;
        }
        #endregion


        #region Methods
        public void DrawChessBoard()
        {
            Button oldButton = new Button(); // button tạm
            oldButton.Width = 0;// ở vị trí 0 ( sát mép)
            oldButton.Location = new Point(0, 0);
            for (int i = 0; i < _Cons.CHESS_BOARD_WIDTH; i++)
            {

                for (int j = 0; j < _Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button();
                    btn.Width = _Cons.CHESS_WIDTH;
                    btn.Height = _Cons.CHESS_HEIGHT;
                    btn.Location = new Point(oldButton.Location.X + _Cons.CHESS_WIDTH, oldButton.Location.Y);// nhích qua phải 1 button 
                    ChessBoard.Controls.Add(btn); // thêm button
                    oldButton = btn;// cập nhật lại vị trí
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + _Cons.CHESS_HEIGHT);// xuống dòng 
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }
        #endregion

    }
}
