using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DTO
{
    public class bangLuongDTO
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public DateTime ThangNam {  get; set; }
        public int PhuCap { get; set; }
        public int KhauTru { get; set; }
        public int LuongThucNhan { get; set; }
        public bangLuongDTO() { }
        public bangLuongDTO(string maNhanVien,string hoTen, DateTime thangNam, int phuCap, int khauTru, int luongThucNhan)
        {
            MaNhanVien = maNhanVien;
            HoTen = hoTen;
            ThangNam = thangNam;
            PhuCap = phuCap;
            KhauTru = khauTru;
            LuongThucNhan = luongThucNhan;
        }
        public bangLuongDTO(string maNhanVien, DateTime thangNam, int phuCap, int khauTru, int luongThucNhan)
        {
            MaNhanVien = maNhanVien;
            ThangNam = thangNam;
            PhuCap = phuCap;
            KhauTru = khauTru;
            LuongThucNhan = luongThucNhan;
        }

    }
}
