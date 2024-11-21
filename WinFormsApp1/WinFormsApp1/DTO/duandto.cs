using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DTO
{
    public class duandto
    {
        private string maDuAn;
        private string tenDuAn;
        private string moTa;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private string quanLyDuAn;
        private string phongBanPhuTrach;
        private int trangThai;

        public duandto() { }

        public duandto(string maDuAn, string tenDuAn, string moTa, DateTime ngayBatDau, DateTime ngayKetThuc, string quanLyDuAn, string phongBanPhuTrach, int trangThai)
        {
            this.maDuAn = maDuAn;
            this.tenDuAn = tenDuAn;
            this.moTa = moTa;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.quanLyDuAn = quanLyDuAn;
            this.phongBanPhuTrach = phongBanPhuTrach;
            this.trangThai = trangThai;
        }

        public string MaDuAn { get => maDuAn; set => maDuAn = value; }
        public string TenDuAn { get => tenDuAn; set => tenDuAn = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public string QuanLyDuAn { get => quanLyDuAn; set => quanLyDuAn = value; }
        public string PhongBanPhuTrach { get => phongBanPhuTrach; set => phongBanPhuTrach = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
