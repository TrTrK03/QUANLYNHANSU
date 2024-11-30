using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DTO
{
    public class tuyendungdto
    {
        private string maKyTuyenDung;
        private string noiDung;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private string maQuanLy;
        private int trangThai;

        public tuyendungdto() { }

        public tuyendungdto(string maKyTuyenDung, string noiDung, DateTime ngayBatDau, DateTime ngayKetThuc, string maQuanLy, int trangThai)
        {
            this.maKyTuyenDung = maKyTuyenDung;
            this.noiDung = noiDung;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.maQuanLy = maQuanLy;
            this.trangThai = trangThai;
        }

        public string MaKyTuyenDung { get => maKyTuyenDung; set => maKyTuyenDung = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public string MaQuanLy { get => maQuanLy; set => maQuanLy = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
