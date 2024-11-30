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

    }
}
