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
    internal class phucloibus
    {
        private phucloidao phucloidao = new phucloidao();

        public List<phucloidto> GetPhucLoi()
        {
            return phucloidao.GetPhucLoi();
        }

        public void AddPhucLoi(phucloidto PhucLoi)
        {
            phucloidao.AddPhucLoi(PhucLoi);
        }

        public void UpdatePhucLoi(phucloidto PhucLoi)
        {
            phucloidao.UpdatePhucLoi(PhucLoi);
        }
        public void DeletePhucLoi(phucloidto selectedPhucLoi)
        {
            phucloidao.DeletePhucLoi(selectedPhucLoi.MaPhucLoi);
        }

    }
}
