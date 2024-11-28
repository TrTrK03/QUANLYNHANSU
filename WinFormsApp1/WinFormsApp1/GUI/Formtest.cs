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
    public partial class Formtest : Form
    {
        public string MaPhongBan { get; set; }
        public string TruongPhong { get; set; }
        public string TenPhongBan { get; set; }
        public string MoTa { get; set; }
        public Formtest()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            txtMaPB.Text = MaPhongBan;
            txtTruongPhong.Text = TruongPhong;
            txtTenPB.Text = TenPhongBan;
            txtMoTa.Text = MoTa;
        }


    }
}
