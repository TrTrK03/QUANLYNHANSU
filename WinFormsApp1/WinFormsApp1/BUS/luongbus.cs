using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO;
using WinFormsApp1.DTO;

namespace WinFormsApp1.BUS
{
    internal class luongbus
    {
        private luongdao luongDao = new luongdao();

        public List<luongdto> GetLuong()
        {
            return luongDao.GetLuong();
        }

        public void AddLuong(luongdto salary)
        {
            luongDao.AddLuong(salary);
        }

        public void UpdateLuong(luongdto salary)
        {
            luongDao.UpdateLuong(salary);
        }

        public List<luongdto> SearchLuongByMaNhanVien(string keyword)
        {
            return luongDao.SearchLuongByMaNhanVien(keyword);
        }
    }
}
