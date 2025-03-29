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
        private List<List<Button>> matrix;
        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }
        public List<Player> Player { get => player; set => player = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public TextBox PlayerName { get => playerName; set => playerName = value; }
        public PictureBox PlayerMark { get => playerMark; set => playerMark = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

        

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
            Matrix = new List<List<Button>>();// khởi tạo 1 list dùng để lưu vị trí các quân đã đánh
            Button oldButton = new Button(); // button tạm
            oldButton.Width = 0;// ở vị trí 0 ( sát mép)
            oldButton.Location = new Point(0, 0);
            for (int i = 0; i < cons.CHESS_BOARD_WIDTH; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button();
                    btn.Width = cons.CHESS_WIDTH;
                    btn.Height = cons.CHESS_HEIGHT;
                    btn.Location = new Point(oldButton.Location.X + cons.CHESS_WIDTH, oldButton.Location.Y);// nhích qua phải 1 button 
                    btn.BackgroundImageLayout = ImageLayout.Stretch;//làm hình vừa btn
                    btn.Tag = i.ToString(); //dùng để biết đây là hàng thứ mấy
                    ChessBoard.Controls.Add(btn); // thêm button
                    oldButton = btn;// cập nhật lại vị trí
                    Matrix[i].Add(btn);//đã lưu vị trí btn 
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
            if (isEndGame(btn))
            {
                EndGame();
            }    
           

        }
        private void EndGame()
        {
            MessageBox.Show("Kết thúc rồi !!!");
        }
        private bool isEndGame(Button btn)
        {

            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn); 
        }
        
        private Point GetChessPoint(Button btn)// hàm lấy tọa độ 
        {
            
            int vertical = Convert.ToInt32(btn.Tag);// lấy hàng dọc
            int horizontal = Matrix[vertical].IndexOf(btn); //lấy hàng ngang
            Point point = new Point(horizontal, vertical);// ra được tọa độ
            return point;
        }
        private bool isEndHorizontal(Button btn) // kết thúc hàng ngang
        {
            Point point = GetChessPoint(btn);// lấy tọa độ
            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                {
                    break;
                }
            }
            int countRight = 0;
            for (int i = point.X + 1; i < cons.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                {
                    break;
                }
            }
            return countLeft + countRight == 5;//đủ 5 con
        }
        private bool isEndVertical(Button btn)// kết thúc hàng dọc
        {
            Point point = GetChessPoint(btn);// lấy tọa độ
            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                {
                    break;
                }
            }
            int countBottom = 0;
            for (int i = point.Y + 1; i < cons.CHESS_BOARD_HEIGHT; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                {
                    break;
                }
            }
            return countTop + countBottom == 5;//đủ 5 con
        }
        private bool isEndPrimary(Button btn) // kết thúc chéo chính ( từ trái qua)
        {
            Point point = GetChessPoint(btn);// lấy tọa độ
            int countTop = 0;
            for (int i = 0; i <= point.X ; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                {
                    break;
                }    
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                {
                    break;
                }
            }
            int countBottom = 0;
            for (int i = 1; i <=cons.CHESS_BOARD_WIDTH- point.X; i++)
            {
                if (point.X + i >= cons.CHESS_BOARD_HEIGHT || point.Y + i >= cons.CHESS_BOARD_WIDTH)
                    break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                {
                    break;
                }
            }
            return countTop + countBottom == 5;//đủ 5 con
        }
        private bool isEndSub(Button btn)// KẾT THÚC CHÉO PHỤ 
        {
            Point point = GetChessPoint(btn);// lấy tọa độ
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > cons.CHESS_BOARD_WIDTH || point.Y - i < 0)
                {
                    break;
                }
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                {
                    break;
                }
            }
            int countBottom = 0;
            for (int i = 1; i <= cons.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.Y + i >= cons.CHESS_BOARD_HEIGHT || point.X + i < 0)
                    break;
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                {
                    break;
                }
            }
            return countTop + countBottom == 5;//đủ 5 con
            return false;
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
