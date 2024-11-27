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
    public partial class LandR : Form
    {
        public LandR()
        {
            InitializeComponent();
            //hienthiLogin();


        }
        Login lg = new Login();
        
        Regist rg = new Regist();

        public void hienthiLogin()
        {
            lg.Owner = this;
            lg.TopLevel = false;
            this.Controls.Add(lg);
            panel1.Hide();
            pictureBox2.Show();
            lg.Show();
            lg.Location = new Point(0, 0);
            rg.Hide();


        }

        public void hienthiRegist()
        {
            panel1.Show();
            pictureBox2.Hide();
            rg.Owner = this;
            rg.TopLevel = false;
            panel2.Controls.Add(rg);
            
            rg.Show();
            rg.Location = new Point(0, 0);
            
            lg.Hide();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
