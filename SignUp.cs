using System;
using System.Windows.Forms;
using Firebase.Auth;


namespace Caro
{
    public partial class SignUp : Form
    {
        private string apiKey = "AIzaSyAtbgnNBlNDVe4tlvlXFf8lRVCeus8Dong"; 

        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void gm_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string Username = username.Text;
            string email = mail.Text;
            string password = pw.Text;

            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));

                // Kiểm tra email đã tồn tại chưa
                var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(email, password);

                // Lưu thông tin user vào Firebase Realtime Database (Không lưu mật khẩu!)
                await FirebaseHelper.AddUser(Username, "********", email);

                MessageBox.Show("Đăng ký thành công!");
                Login form = new Login();
                form.Show();
                this.Close();
            }
            catch (FirebaseAuthException ex)
            {
                if (ex.ResponseData.Contains("EMAIL_EXISTS"))
                {
                    MessageBox.Show("Email đã được đăng ký!");
                }
                else
                {
                    MessageBox.Show("Lỗi đăng ký: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng ký: " + ex.Message);
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            pw.UseSystemPasswordChar = !show.Checked;

        }
    }
}
