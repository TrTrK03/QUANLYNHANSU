using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.GUI
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private Login login;
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mở form đăng nhập
            if (login == null || login.IsDisposed)
            {
                login = new Login();
                login.Show();
               // this.Close();
            }
            else
            {
                login.BringToFront();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu textbox đang chứa giá trị mặc định "your email"
            if (textBox1.Text == "Your Full Name")
            {
                // Xóa giá trị mặc định và đặt con trỏ vào đầu textbox
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu textbox đang chứa giá trị mặc định "your email"
            if (textBox3.Text == "Your Email")
            {
                // Xóa giá trị mặc định và đặt con trỏ vào đầu textbox
                textBox3.Text = "";
                textBox3.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
