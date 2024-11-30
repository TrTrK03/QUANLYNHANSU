using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DTO
{
    public class khenThuongDTO
    {
        // Các trường dữ liệu được khai báo là public để có thể truy cập từ bên ngoài
        public string MaKhenThuong { get; set; }
        public string MaNhanVien { get; set; }
        public string LoaiKhenThuong { get; set; }
        public string ChiTietKhenThuong { get; set; }
        public int GiaTriKhenThuong { get; set; }
        public DateTime NgayKhenThuong { get; set; }
        public int TrangThai { get; set; }

        // Constructor
        public khenThuongDTO(string maKhenThuong, string maNhanVien, string loaiKhenThuong, string chiTietKhenThuong, int giaTriKhenThuong, DateTime ngayKhenThuong, int trangThai)
        {
            MaKhenThuong = maKhenThuong;
            MaNhanVien = maNhanVien;
            LoaiKhenThuong = loaiKhenThuong;
            ChiTietKhenThuong = chiTietKhenThuong;
            GiaTriKhenThuong = giaTriKhenThuong;
            NgayKhenThuong = ngayKhenThuong;
            TrangThai = trangThai;
        }
    }
}
