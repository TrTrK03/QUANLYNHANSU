using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DTO
{
    public class phucloidto
    {
        private string maPhucLoi;
        private string tenPhucLoi;
        private string moTa;
        private int giaTriPhucLoi = 0;
        private int trangThai;

        public phucloidto() { }

        public phucloidto(string maPhucLoi, string tenPhucLoi, string moTa, int giaTriPhucLoi, int trangThai)
        {
            this.maPhucLoi = maPhucLoi;
            this.tenPhucLoi = tenPhucLoi;
            this.moTa = moTa;
            this.giaTriPhucLoi = giaTriPhucLoi;
            this.trangThai = trangThai;
        }

        public string MaPhucLoi { get => maPhucLoi; set => maPhucLoi = value; }
        public string TenPhucLoi { get => tenPhucLoi; set => tenPhucLoi = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public int GiaTriPhucLoi { get => giaTriPhucLoi; set => giaTriPhucLoi = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
