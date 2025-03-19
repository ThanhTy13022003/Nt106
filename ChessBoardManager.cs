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
        private List<Player> player;
        private int currentPlayer;
        private TextBox playerName;
        private PictureBox playerMark;
        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }
        public List<Player> Player { get => player; set => player = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public TextBox PlayerName { get => playerName; set => playerName = value; }
        public PictureBox PlayerMark { get => playerMark; set => playerMark = value; }


        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard,TextBox playerName, PictureBox mark)
        {
            this.ChessBoard = chessBoard;
            this.PlayerName = playerName;
            this.PlayerMark = mark;
            this.Player = new List<Player>()
            {
                new Player("1",Image.FromFile(Application.StartupPath + "\\hinhanh\\icons8-circle-96.png")),
                new Player("2",Image.FromFile(Application.StartupPath + "\\hinhanh\\icons8-x-100.png"))
            };
            CurrentPlayer = 0;

            ChangePlayer();
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
                    btn.BackgroundImageLayout = ImageLayout.Stretch;//làm hình vừa btn
                    ChessBoard.Controls.Add(btn); // thêm button
                    oldButton = btn;// cập nhật lại vị trí
                    btn.Click += btn_Click;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + cons.CHESS_HEIGHT);// xuống dòng 
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;// đây là button mình click
            if (btn.BackgroundImage != null)
                return; // nếu mà đánh rồi ( != null) thì ko cần làm gì hết
            Mark(btn);

            ChangePlayer();

           

        }
        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;// curntplayer = 1 ? nếu ko thì đổi lại thành 1
        }
        private void ChangePlayer()
        {
            PlayerName.Text = Player[CurrentPlayer].Name; // đổi tên khi tới lượt

            PlayerMark.Image = Player[CurrentPlayer].Mark; // đổi hình khi tới lượt
        }
        #endregion

    }
}
