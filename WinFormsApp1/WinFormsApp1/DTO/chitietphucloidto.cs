using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DTO
{
    public class chitietphucloidto
    {
        private string maPhucLoi;
        private string maNhanVien;

        public chitietphucloidto() { }

        public chitietphucloidto(string maPhucLoi, string maNhanVien)
        {
            this.maPhucLoi = maPhucLoi;
            this.maNhanVien = maNhanVien;
        }

        public string MaPhucLoi { get => maPhucLoi; set => maPhucLoi = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
    }
}
