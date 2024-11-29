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
        private duandao duandao = new duandao();

        public List<duandto> GetDuAn()
        {
            return duandao.GetDuAn();
        }

        public void AddDuAn(duandto DuAn)
        {
            duandao.AddDuAn(DuAn);
        }

        public void UpdateDuAn(duandto DuAn)
        {
            duandao.UpdateDuAn(DuAn);
        }
        public void DeleteDuAn(duandto selectedDuAn)
        {
            duandao.DeleteDuAn(selectedDuAn.MaDuAn);
        }

        // Các hàm khác nếu cần
    }
}
