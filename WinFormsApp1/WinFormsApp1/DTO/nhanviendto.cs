using System;

namespace WinFormsApp1.DTO
{
    public class nhanviendto
    {
        private string maNhanVien;
        private string hoTen;
        private DateTime ngaySinh; // Ngày sinh chuyển sang kiểu DateTime để phù hợp với SQL
        private string gioiTinh;
        private string diaChi;
        private string email;
        private string sdt; // Đặt tên biến phù hợp quy chuẩn .NET
        private string nguoiQuanLy; // Nullable (có thể null)
        private string phongBan; // Nullable (có thể null)
        private string chucVu;
        private string hoSoGioiThieu; // Nullable (có thể null)
        private int trangThai;

        // Constructor mặc định
        public nhanviendto() { }

        // Constructor đầy đủ
        public nhanviendto(string maNhanVien, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi,
                           string email, string sdt, string nguoiQuanLy, string phongBan, string chucVu,
                           string hoSoGioiThieu, int trangThai)
        {
            this.maNhanVien = maNhanVien;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.email = email;
            this.sdt = sdt;
            this.nguoiQuanLy = nguoiQuanLy;
            this.phongBan = phongBan;
            this.chucVu = chucVu;
            this.hoSoGioiThieu = hoSoGioiThieu;
            this.trangThai = trangThai;
        }

        // Properties
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public string NguoiQuanLy { get => nguoiQuanLy; set => nguoiQuanLy = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string HoSoGioiThieu { get => hoSoGioiThieu; set => hoSoGioiThieu = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
