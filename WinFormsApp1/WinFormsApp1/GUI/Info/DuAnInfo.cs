using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;

namespace WinFormsApp1.GUI.Info
{
    public partial class DuAnInfo : Form
    {
        static nhanvienbus nhanvienbus = new nhanvienbus();
        public string MaDuAn { get; set; }
        public string TenDuAn { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string QuanLyDuAn { get; set; }
        public string PhongBanPhuTrach { get; set; }
        public int TrangThai { get; set; }

        // Thuộc tính chứa danh sách nhân viên
        public List<nhanviendto> nhanviens { get; set; }

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

            // Load project data into controls
            txtMaDuAn.Text = MaDuAn;
            txtTenDuAn.Text = TenDuAn;
            txtMoTa.Text = MoTa;
            dtpNgayBatDau.Value = NgayBatDau;
            dtpNgayKetThuc.Value = NgayKetThuc;
            txtQuanLyDuAn.Text = QuanLyDuAn;
            txtPhongBanPhuTrach.Text = PhongBanPhuTrach;

            // Prepare DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Nhân Viên", typeof(string));
            dt.Columns.Add("Họ Tên", typeof(string));

            // Add employee data to DataTable
            if (nhanviens != null)
            {
                foreach (nhanviendto nhanvien in nhanviens)
                {
                    dt.Rows.Add(
                        nhanvien.MaNhanVien,
                        nhanvien.HoTen
                    );
                }
            }

            // Assign DataTable to DataGridView
            dataGridView1.DataSource = dt;
        }
    }
}
