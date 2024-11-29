using System;
using System.Windows.Forms;

namespace WinFormsApp1.GUI.Info
{
    public partial class ThongBaoInfo : Form
    {
        public string MaThongBao { get; set; }
        public string NguoiBanHanh { get; set; }
        public string NoiDung { get; set; }
        public DateTime NgayBanHanh { get; set; }

        public ThongBaoInfo()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            if (txtMaThongBao == null || txtNguoiBanHanh == null || dtpNgayBanHanh == null)
            {
                MessageBox.Show("Một hoặc nhiều control chưa được khởi tạo.");
                return;
            }

            txtMaThongBao.Text = MaThongBao;
            txtNguoiBanHanh.Text = NguoiBanHanh;
            txtNoiDung.Text = NoiDung;
            dtpNgayBanHanh.Value = NgayBanHanh;
        }
    }
}
