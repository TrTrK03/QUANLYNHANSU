using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO;
using WinFormsApp1.DTO;

namespace WinFormsApp1.BUS
{
    internal class chitietphucloinhanvienbus
    {
        private chitietphucloinhanviendao chitietphucloinhanviendao = new chitietphucloinhanviendao();

        public List<chitietphucloidto> GetChiTietPhucLoi()
        {
            return chitietphucloinhanviendao.GetChiTietPhucLoi();
        }

        public void AddChiTietPhucLoi(chitietphucloidto chitietphucloi)
        {
            chitietphucloinhanviendao.AddChiTietPhucLoi(chitietphucloi);
        }

        public void UpdateChiTietPhucLoi(chitietphucloidto chitietphucloi)
        {
            chitietphucloinhanviendao.UpdateChiTietPhucLoi(chitietphucloi);
        }
        public void DeleteChiTietPhucLoi(chitietphucloidto selectedchitiet)
        {
            chitietphucloinhanviendao.DeleteChiTietPhucLoi(selectedchitiet.MaNhanVien);
        }
    }
}
