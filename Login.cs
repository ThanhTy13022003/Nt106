using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Auth;


namespace Caro
{
    public partial class Login : Form
    {
        private string apiKey = "AIzaSyAtbgnNBlNDVe4tlvlXFf8lRVCeus8Dong"; 

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            Txpassword.PasswordChar = '*'; // Đảm bảo mật khẩu bị ẩn khi mở form
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void remember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            if (show.Checked)
            {
                Txpassword.PasswordChar = '\0'; // Hiển thị mật khẩu
            }
            else
            {
                Txpassword.PasswordChar = '*'; // Ẩn mật khẩu
            }
        }

        private async void signin_Click(object sender, EventArgs e)
        {
            string input = username.Text; // Người dùng nhập username hoặc email
            string password = Txpassword.Text; // Đảm bảo textbox đúng tên

            // Kiểm tra nếu nhập username thì lấy email tương ứng từ Firebase
            string email = input;
            if (!input.Contains("@")) // Kiểm tra nếu input không phải email
            {
                email = await FirebaseHelper.GetEmailByUsername(input);
                if (email == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản!");
                    return;
                }
            }

            try
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
                var auth = await authProvider.SignInWithEmailAndPasswordAsync(email, password);

                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message);
            }
        }


        private void BTsignup_Click(object sender, EventArgs e)
        {
            SignUp form2 = new SignUp();
            this.Hide();
            form2.Show();
        }
    }
}
