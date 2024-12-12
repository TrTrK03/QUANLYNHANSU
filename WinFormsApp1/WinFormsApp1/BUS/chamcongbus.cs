using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO;
using WinFormsApp1.DTO;

namespace WinFormsApp1.BUS
{
    internal class chamcongbus
    {
        private chamcongdao chamcongDAO = new chamcongdao();
        public List<chamcongdto> GetChamCong()
        {
            return chamcongDAO.GetChamCong();
        }

        public List<chamcongdto> GetChamCong(int thang, int nam)
        {
            return chamcongDAO.GetChamCong(thang, nam);
        }

        public List<chamcongdto> GetDSDungGio(bool True=true)
        {
            return chamcongDAO.GetDSDungGio();
        }

        public List<chamcongdto> GetDSDungGioCuaMaNV(string manv , bool True )
        {
            return chamcongDAO.GetDSDungGioCuaMaNV(manv, True);
        }

        public List<Image> BieuDoChamCongTheoTuan(int tuan, int thang , int nam )
        {
            return chamcongDAO.BieuDoChamCongTheoTuan(tuan, thang, nam);
        }

        public List<chamcongdto> GetDSTheoNgay(DateTime ngay, bool True)
        {
            return chamcongDAO.GetDSTheoNgay(ngay, True);
        }

        public int SoChamCongDungGio(DateTime ngay, bool True)
        {
            return chamcongDAO.SoChamCongDungGio(ngay, True);
        }

        public void AddChamCong(chamcongdto chamcong)
        {
            chamcongDAO.AddChamCong(chamcong);
        }

        public List<string> GetMaCC()
        {
            return chamcongDAO.GetMaCC();
        }

        public void UpdateChamCong(chamcongdto chamcong)
        {
            chamcongDAO.UpdateChamCong(chamcong);
        }

        public void DeleteChamCong(chamcongdto chamcong)
        {
            chamcongDAO.DeleteChamCong(chamcong);
        }

    }

}
