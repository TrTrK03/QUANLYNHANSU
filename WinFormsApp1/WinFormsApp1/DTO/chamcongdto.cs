using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DAO
{
    internal class chamcongdto
    {
        private string maBangChamCong;
        private string gioVaoCa;
        private DateTime thangNam;

        public chamcongdto() { }

        public chamcongdto(string maBangChamCong, string gioVaoCa, DateTime thangNam)
        {
            this.maBangChamCong = maBangChamCong;
            this.gioVaoCa = gioVaoCa;
            this.thangNam = thangNam;
        }

        public string MaBangChamCong { get => maBangChamCong; set => maBangChamCong = value; }
        public string GioVaoCa { get => gioVaoCa;  set => gioVaoCa = value; } 
        public DateTime ThangNam { get => thangNam; set { thangNam = value; } }


    }
}
