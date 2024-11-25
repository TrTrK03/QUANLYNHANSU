using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DTO
{
    internal class hosotuyendungdto
    {
        private string maHoSoTuyenDung;
        private string hoTen;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string email;
        private string sdt;
        private string trinhDo;
        private string moTaBangCap;
        private string kyTuyenDung;
        private int trangThai;

        public hosotuyendungdto() { }

        public hosotuyendungdto(string maHoSoTuyenDung, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string email, string sdt, string trinhDo, string moTaBangCap, string kyTuyenDung, int trangThai)
        {
            this.maHoSoTuyenDung = maHoSoTuyenDung;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.email = email;
            this.sdt = sdt;
            this.trinhDo = trinhDo;
            this.moTaBangCap = moTaBangCap;
            this.kyTuyenDung = kyTuyenDung;
            this.trangThai = trangThai;
        }

        public string MaHoSoTuyenDung { get => maHoSoTuyenDung; set => maHoSoTuyenDung = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public string TrinhDo { get => trinhDo; set => trinhDo = value; }
        public string MoTaBangCap { get => moTaBangCap; set => moTaBangCap = value; }
        public string KyTuyenDung { get => kyTuyenDung; set => kyTuyenDung = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
