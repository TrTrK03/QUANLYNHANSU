using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1.DTO
{
    public class nhanviendto
    {
        //private string MaNhanVien;
        //private string HoTen;
        //private string NgaySinh;
        //private string GioiTinh;
        //private string DiaChi;
        //private string Email;
        //private string SDT;
        //private string NguoiQuanLy;
        //private string PhongBan;
        //private string ChucVu;
        //private string HoSoGioiThieu;
        //private int TrangThai;


        private string maNhanVien;
        private string hoTen;
        private string ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string email;
        private string sDT;
        private string nguoiQuanLy;
        private string phongBan;
        private string chucVu;
        private string hoSoGioiThieu;
        private int trangThai;




        private int maTK;
        
        public nhanviendto()
        {

        }
        public nhanviendto(string maNhanVien, string hoTen, string ngaySinh, string gioiTinh, string diaChi, string email, string sDT, string nguoiQuanLy, string phongBan, string chucVu, string hoSoGioiThieu, int trangThai)
        {
            this.maNhanVien = maNhanVien;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.email = email;
            this.sDT = sDT;
            this.nguoiQuanLy = nguoiQuanLy;
            this.phongBan = phongBan; 
            this.chucVu = chucVu;
            this.hoSoGioiThieu = hoSoGioiThieu;
            this.trangThai = trangThai;
            
            
        }

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string NguoiQuanLy { get => nguoiQuanLy; set => nguoiQuanLy = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string HoSoGioiThieu { get => hoSoGioiThieu; set => hoSoGioiThieu = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        
        
    }
}
