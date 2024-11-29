using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.GUI.Info
{
    public partial class NhanVienInfo : Form
    {
        // Các thuộc tính của nhân viên
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string MoTa { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QuanLyNhanVien { get; set; }
        public string PhongBanPhuTrach { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string GioiTinh { get; set; }
        public string ChucVu {  get; set; }

        public NhanVienInfo()
        {
            InitializeComponent();
        }

        // Phương thức LoadData để gán dữ liệu vào các điều khiển trên giao diện
        public void LoadData()
        {
            // Gán dữ liệu từ các thuộc tính vào các TextBox và các điều khiển trên form
            txtMaNV.Text = MaNhanVien;
            txtHoTen.Text = TenNhanVien;
            txtDuAn.Text = MoTa;
            dtpNgaySinh.Value = NgaySinh; // Cập nhật ngày sinh (Ngày bắt đầu)
            txtPhongBan.Text = PhongBanPhuTrach;
            txtNQL.Text = QuanLyNhanVien;
            txtDiaChi.Text = DiaChi;
            txtSdt.Text = SoDienThoai;
            txtEmail.Text = Email;
            txtChucVu.Text = ChucVu;


            // Xử lý giới tính dựa vào thuộc tính GioiTinh
            if (GioiTinh == "Nam")
                cbNam.Checked = true;
            else if (GioiTinh == "Nữ")
                cbNu.Checked = true;
        }

    }
}
