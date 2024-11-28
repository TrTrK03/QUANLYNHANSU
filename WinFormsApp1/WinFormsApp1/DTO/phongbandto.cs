using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DTO
{
    public class phongbandto
    {
        private string maPhongBan;
        private string tenPhongBan;
        private string moTa;
        private string truongPhong;
        private int trangThai;

        public phongbandto() { }

        public phongbandto(string maPhongBan, string tenPhongBan, string moTa, string truongPhong, int trangThai)
        {
            this.maPhongBan = maPhongBan;
            this.tenPhongBan = tenPhongBan;
            this.moTa = moTa;
            this.truongPhong = truongPhong;
            this.trangThai = trangThai;
        }

        public string MaPhongBan { get => maPhongBan; set => maPhongBan = value; }
        public string TenPhongBan { get => tenPhongBan; set => tenPhongBan = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string TruongPhong { get => truongPhong; set => truongPhong = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
