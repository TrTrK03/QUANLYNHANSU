using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DTO
{
    internal class luongdto
    {
        private string maNhanVien;
        private DateTime thangNam;
        private int phuCap;
        private int khauTru;
        private int luongThucNhan;

        public luongdto() { }

        public luongdto(string maNhanVien, DateTime thangNam, int phuCap, int khauTru, int luongThucNhan)
        {
            this.maNhanVien = maNhanVien;
            this.thangNam = thangNam;
            this.phuCap = phuCap;
            this.khauTru = khauTru;
            this.luongThucNhan = luongThucNhan;
        }

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public DateTime ThangNam { get => thangNam; set => thangNam = value; }
        public int PhuCap { get => phuCap; set => phuCap = value; }
        public int KhauTru { get => khauTru; set => khauTru = value; }
        public int LuongThucNhan { get => luongThucNhan; set => luongThucNhan = value; }
    }
}
