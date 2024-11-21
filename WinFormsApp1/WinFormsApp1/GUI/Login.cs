using System.Windows.Forms;

namespace WinFormsApp1.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu textbox đang chứa giá trị mặc định "your email"
            if (textBox1.Text == "Your Email")
            {
                // Xóa giá trị mặc định và đặt con trỏ vào đầu textbox
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        private ForgetPassword fg;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mở form quên mật khẩu
            if (fg == null || fg.IsDisposed)
            {
                fg = new ForgetPassword();
                fg.Show();
              //  this.Close();

            }
            else
            {
                FormSignup.BringToFront();
            }
        }
        private Signup FormSignup;
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mở form đăng ký
            if (FormSignup == null || FormSignup.IsDisposed)
            {
                FormSignup = new Signup();
                FormSignup.Show();
               // this.Close();

            }
            else
            {
                FormSignup.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                // Hiển thị thông báo đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Thực hiện các hành động khác sau khi đăng nhập thành công (nếu có)
                // Ví dụ: chuyển sang form khác, mở một cửa sổ mới, ...
            }
            else
            {
                // Hiển thị thông báo đăng nhập thất bại
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            // Kiểm tra nếu textbox đang chứa giá trị mặc định "your email"
            if (textBox2.Text == "Your Password")
            {
                // Xóa giá trị mặc định và đặt con trỏ vào đầu textbox
                textBox2.Text = "";
                textBox2.Focus();
            }
        }
    }
}
