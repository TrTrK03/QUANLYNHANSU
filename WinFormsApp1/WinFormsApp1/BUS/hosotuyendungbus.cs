using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO;
using WinFormsApp1.DTO;

namespace WinFormsApp1.BUS
{
    internal class hosotuyendungbus
    {
        private hosotuyendungdao hosotuyendungDao = new hosotuyendungdao();

        public List<hosotuyendungdto> GetHoSoTuyenDung()
        {
            return hosotuyendungDao.GetHoSoTuyenDung();
        }

        public void AddHoSoTuyenDung(hosotuyendungdto hoSo)
        {
            hosotuyendungDao.AddHoSoTuyenDung(hoSo);
        }

        public void UpdateHoSoTuyenDung(hosotuyendungdto hoSo)
        {
            hosotuyendungDao.UpdateHoSoTuyenDung(hoSo);
        }

        public List<hosotuyendungdto> SearchHoSoTuyenDung(string keyword)
        {
            return hosotuyendungDao.SearchHoSoTuyenDung(keyword);
        }
    }
}
