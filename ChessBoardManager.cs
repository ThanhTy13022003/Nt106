using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;
        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }
        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard)
        {
            this.ChessBoard = chessBoard;
        }
        #endregion


        #region Methods
        public void DrawChessBoard()
        {
            Button oldButton = new Button(); // button tạm
            oldButton.Width = 0;// ở vị trí 0 ( sát mép)
            oldButton.Location = new Point(0, 0);
            for (int i = 0; i < cons.CHESS_BOARD_WIDTH; i++)
            {

                for (int j = 0; j < cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button();
                    btn.Width = cons.CHESS_WIDTH;
                    btn.Height = cons.CHESS_HEIGHT;
                    btn.Location = new Point(oldButton.Location.X + cons.CHESS_WIDTH, oldButton.Location.Y);// nhích qua phải 1 button 
                    ChessBoard.Controls.Add(btn); // thêm button
                    oldButton = btn;// cập nhật lại vị trí
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + cons.CHESS_HEIGHT);// xuống dòng 
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }
        #endregion

    }
}
