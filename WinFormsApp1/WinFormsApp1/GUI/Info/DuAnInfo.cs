using System;
using System.Windows.Forms;

namespace WinFormsApp1.GUI.Info
{
    public partial class DuAnInfo : Form
    {
        public string MaDuAn { get; set; }
        public string TenDuAn { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string QuanLyDuAn { get; set; }
        public string PhongBanPhuTrach { get; set; }
        public int TrangThai { get; set; }

        public DuAnInfo()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            if (txtMaDuAn == null || txtTenDuAn == null || dtpNgayBatDau == null || dtpNgayKetThuc == null ||
                txtQuanLyDuAn == null || txtPhongBanPhuTrach == null)
            {
                MessageBox.Show("Một hoặc nhiều control chưa được khởi tạo.");
                return;
            }

            txtMaDuAn.Text = MaDuAn;
            txtTenDuAn.Text = TenDuAn;
            txtMoTa.Text = MoTa;
            dtpNgayBatDau.Value = NgayBatDau;
            dtpNgayKetThuc.Value = NgayKetThuc;
            txtQuanLyDuAn.Text = QuanLyDuAn;
            txtPhongBanPhuTrach.Text = PhongBanPhuTrach;
        }
    }
}
