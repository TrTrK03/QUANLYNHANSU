using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO;
using WinFormsApp1.DTO;

namespace WinFormsApp1.BUS
{
    internal class duanbus
    {
        private duandao duaodao = new duandao();

        public List<duandto> GetDuAn()
        {
            return duaodao.GetDuAn();
        }

        public void AddDuAn(duandto DuAn)
        {
            duaodao.AddDuAn(DuAn);
        }

        public void UpdateDuAn(duandto DuAn)
        {
            duaodao.UpdateDuAn(DuAn);
        }

        public ArrayList SearchDuAnByID(string keyword)
        {
            return duaodao.SearchDuAnByID(keyword);
        }

        public ArrayList SearchDuAnByName(string keyword)
        {
            return duaodao.SearchDuAnByName(keyword);
        }

        // Các hàm khác nếu cần
    }
}
