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

namespace WinFormsApp1.GUI
{
    public partial class Regist : Form
    {
        public Regist()
        {
            InitializeComponent();



        }
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        //OleDbCommand cmd = new OleDbCommand();
        //OleDbDataAdapter da = new OleDbDataAdapter();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConfirmPassword.Text)
            {
                //con.Open();
                //string register = "INSERT INTO tbl_users VALUES ('" + txtUsername.Text + "','" + txtPassword.Text + "')";
                //cmd = new OleDbCommand(register, con);
                //cmd.ExecuteNonQuery();
                //con.Close();

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";

                MessageBox.Show("Your account has been successfully created", "Registration Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Passwords does not match, please re-enter the password", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void chckbxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";

            txtUsername.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //new frmLogin().Show();
            this.Hide();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            if (this.Owner is LandR landR)
            {
                landR.hienthiLogin();
            }
            else
            {
                MessageBox.Show("Không thể tìm thấy form cha.");
            }
        }
    }
}
