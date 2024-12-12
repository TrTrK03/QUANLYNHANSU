using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DTO
{
    public class chamcongdto
    {
        private string maBangChamCong;
        private int buoi;
        private string gioVaoCa;
        private DateTime ngay;
        private string maNhanVien;

        public chamcongdto() { }

        public chamcongdto(string maBangChamCong, int buoi, string gioVaoCa, DateTime ngay, string maNhanVien)
        {
            this.maBangChamCong = maBangChamCong;
            this.gioVaoCa = gioVaoCa;
            this.buoi = buoi;
            this.ngay = ngay;
            this.maNhanVien = maNhanVien;
        }

        public string MaBangChamCong { get => maBangChamCong; set => maBangChamCong = value; }
        public int Buoi { get => buoi; set => buoi = value; }
        public string GioVaoCa { get => gioVaoCa; set => gioVaoCa = value; }
        public DateTime Ngay { get => ngay; set { ngay = value; } }

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }


    }
}
