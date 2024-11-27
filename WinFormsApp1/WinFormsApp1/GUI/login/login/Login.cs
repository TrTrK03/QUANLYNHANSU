using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using WinFormsApp1.BUS;
using WinFormsApp1.DAO;
using WinFormsApp1.DTO;
using Doanqlchdt.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp1.GUI
{
    public partial class Login : Form
    {
        taikhoanbus taikhoanbus;

        public Login()
        {
            InitializeComponent();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";


            txtUsername.Focus();
        }



        public void label5_Click_1(object sender, EventArgs e)
        {


            if (this.Owner is LandR landR)
            {
                landR.hienthiRegist();
            }
            else
            {
                MessageBox.Show("Không thể tìm thấy form cha.");
            }




        }

        private void butlogin_Click(object sender, EventArgs e)
        {
            taikhoanbus = new taikhoanbus();
            if (txtPassword.Text == "")
            {
                txtPassword.Focus();
                return;
            }
            if (txtUsername.Text == "")
            {
                txtUsername.Focus();
                return;
            }
            String tk = txtUsername.Text;
            String mk = txtPassword.Text;
            if (taikhoanbus.checkt(tk, mk))
            {
                if (this.Owner is LandR landR)
                {
                    landR.Hide();
                }
                index id = new index();
                id.StartPosition = FormStartPosition.CenterScreen;
                id.ShowDialog();
                if (this.Owner is LandR landR1)
                {
                    landR1.Close();
                }


            }
            else
            {
                MessageBox.Show("Username hoặc Password của bạn bị sai!!");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void chckbxPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chckbxPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

       
    }
}
