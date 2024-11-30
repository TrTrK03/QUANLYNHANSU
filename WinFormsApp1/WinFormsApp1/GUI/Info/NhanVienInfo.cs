using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;

namespace WinFormsApp1.GUI.Info
{
    public partial class NhanVienInfo : Form
    {
        nhanvienbus nhanvienbus = new nhanvienbus();
        // Các thuộc tính của nhân viên
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string DuAn { get; set; }
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
            // Tạo một đối tượng nhanviendto từ thông tin hiện có (ví dụ, MaNhanVien)
            nhanviendto employee = new nhanviendto
            {
                MaNhanVien = MaNhanVien, // Gán giá trị MaNhanVien từ thuộc tính
                                         // Thêm các thuộc tính khác nếu cần
            };
            string MaDuAn;
            // Lấy MaDuAn từ cơ sở dữ liệu bằng đối tượng nhanviendto
            MaDuAn = nhanvienbus.GetMaDuAnFromDatabase(employee);

            // Gán dữ liệu từ các thuộc tính vào các TextBox và các điều khiển trên form
            txtMaNV.Text = MaNhanVien;
            txtHoTen.Text = TenNhanVien;
            txtDuAn.Text = MaDuAn;
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
