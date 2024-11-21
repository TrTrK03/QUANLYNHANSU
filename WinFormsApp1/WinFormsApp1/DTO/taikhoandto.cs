    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doanqlchdt.DTO
{
    public class taikhoandto
    {
        private String maTaiKhoan;
        private String tenTaiKhoan;
        private String matKhau;
        private String maQuyen;
        private String maNhanVien;
        private int trangthai;

        public taikhoandto()
        {
        }

        public taikhoandto( string maTaiKhoan, string tenTaiKhoan, string matKhau, string maQuyen,string maNhanVien, int trangthai)
        {
            this.maTaiKhoan = tenTaiKhoan;
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
            this.maQuyen = maQuyen;
            this.maNhanVien = maNhanVien;
            this.trangthai = trangthai;
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string Password { get => matKhau; set => matKhau = value; }
        public string MaQuyen { get => maQuyen; set => maQuyen = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
    }
    public class TAIKHOANDTO
    {
        private String maTaiKhoan;
        private String tenTaiKhoan;
        private String matKhau;
        private String maQuyen;
        public String maNhanVien;
        private int trangthai;
        public TAIKHOANDTO() { }

        public TAIKHOANDTO(string maTaiKhoan, string tenTaiKhoan, string matKhau, string maQuyen, string maNhanVien,  int trangthai)
        {
            this.MaTaiKhoan = maTaiKhoan;
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
            this.MaQuyen = maQuyen;
            this.MaNhanVien =maNhanVien;
            this.Trangthai = trangthai;
        }

        public string MaTaiKhoan{ get => maTaiKhoan; set => maTaiKhoan = value; }
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string MaQuyen { get => maQuyen; set => maQuyen = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
    }
}
