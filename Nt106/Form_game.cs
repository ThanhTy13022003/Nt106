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
    public partial class Form_game : Form
    {
        #region Properties
        _ChessBoardManager ChessBoard;
        Form_chatbox chatForm = null; // Biến lưu trữ Form Chat
        Form_login loginForm = null;
        Form_signup signUpForm = null;
        Form_panel panelForm = null;
        Form_feature featureForm = null; // Biến lưu trữ Form_feature
        #endregion

        public Form_game()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(85, 80); // Đặt tọa độ (X=100, Y=100)
            this.MouseEnter += (s, e) => this.Activate();

            ChessBoard = new _ChessBoardManager(pnlChessBoard, txtPlayerName, pcbMark);
            ChessBoard.DrawChessBoard();

            this.Load += box_chat_Load; // Gán sự kiện Load
            this.Load += Form_game_Load; // Khi Form_game load, mở Form_panel
        }

        private async void Form_game_Load(object sender, EventArgs e)
        {
            await Task.Delay(250); // Chờ 250ms để tránh lỗi hiển thị

            // Mở Form_panel
            if (panelForm == null || panelForm.IsDisposed)
            {
                panelForm = new Form_panel();
                panelForm.StartPosition = FormStartPosition.Manual;
                panelForm.Location = new System.Drawing.Point(this.Location.X, this.Location.Y + this.Height + 10);
                panelForm.Show();
            }

            // Mở Form_feature
            if (featureForm == null || featureForm.IsDisposed)
            {
                featureForm = new Form_feature();
                featureForm.StartPosition = FormStartPosition.Manual;
                featureForm.Location = new System.Drawing.Point(this.Location.X + this.Width + 4, this.Location.Y + this.Height - 127); // Đặt bên phải Form_game
                featureForm.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlChessBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        // Hàm vẽ bàn cờ
        private async void box_chat_Load(object sender, EventArgs e)
        {
            await Task.Delay(250); // Chờ 250ms trước khi mở form chat

            if (chatForm == null || chatForm.IsDisposed) // Đảm bảo không bị đóng ngay lập tức
            {
                chatForm = new Form_chatbox();
                chatForm.Show();

                await Task.Delay(250); // Chờ thêm 0.5 giây trước khi focus
                this.Activate(); // Đưa form chat lên trước
            }
        }

        private void chat_button_Click(object sender, EventArgs e)
        {
            if (chatForm == null || chatForm.IsDisposed) // Kiểm tra nếu form chat chưa mở hoặc đã đóng
            {
                chatForm = new Form_chatbox();
                chatForm.Show();
            }
            else
            {
                // chatForm.Focus(); // Nếu form chat đã mở, đưa nó lên trước
                chatForm.Close(); // Nếu form đang mở, đóng nó
                chatForm = null;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginForm != null && loginForm.Visible) // Nếu form đang mở, đóng nó
            {
                loginForm.Close();
                this.Activate(); // Kích hoạt lại cửa sổ chính trước khi đóng form login
                loginForm = null;
            }
            else // Nếu form chưa mở hoặc đã bị đóng, mở lại
            {
                loginForm = new Form_login();
                loginForm.FormClosed += (s, args) => loginForm = null; // Gán null khi form đóng
                loginForm.Show();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (signUpForm != null && signUpForm.Visible) // Nếu form đang mở, đóng nó
            {
                signUpForm.Close();
                this.Activate(); // Kích hoạt lại cửa sổ chính trước khi đóng form signUp
                signUpForm = null;
            }
            else // Nếu form chưa mở hoặc đã bị đóng, mở lại
            {
                signUpForm = new Form_signup();
                signUpForm.FormClosed += (s, args) => signUpForm = null; // Gán null khi form đóng
                signUpForm.Show();
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            // Hiện tại không có hành động nào khi nhấn nút Sign Out
        }


    }
}
