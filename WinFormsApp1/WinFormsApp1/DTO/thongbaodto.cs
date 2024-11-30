using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DTO
{
    public class thongbaodto
    {
        private string maThongBao;
        private string noiDung;
        private string nguoiBanHanh;
        private DateTime ngayBanHanh;
        private int trangThai;

        public thongbaodto() { }

        public thongbaodto(string maThongBao, string noiDung, string nguoiBanHanh, DateTime ngayBanHanh, int trangThai)
        {
            this.maThongBao = maThongBao;
            this.noiDung = noiDung;
            this.nguoiBanHanh = nguoiBanHanh;
            this.ngayBanHanh = ngayBanHanh;
            this.trangThai = trangThai;
        }

        public string MaThongBao { get => maThongBao; set => maThongBao = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string NguoiBanHanh { get => nguoiBanHanh; set => nguoiBanHanh = value; }
        public DateTime NgayBanHanh { get => ngayBanHanh; set => ngayBanHanh = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
