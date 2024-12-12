using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.BUS;
using WinFormsApp1.DAO;
using WinFormsApp1.DTO;

namespace WinFormsApp1.GUI.detail
{
    public partial class Thongke : Form
    {
        int thang = DateTime.Now.Month;
        int nam = DateTime.Now.Year;    
        static chamcongbus chamcongbus = new chamcongbus();
        static chamcongdao chamcongdao = new chamcongdao();

        public Thongke()
        {
            InitializeComponent();
            domainUpDown1.SelectedIndex = thang - 1;
            domainUpDown2.SelectedIndex = nam - 2023;
            LoadData(thang, nam);
        }

        public void LoadData(int thang, int nam)
        {
            int soNgayTrongThang = DateTime.DaysInMonth(nam, thang);
            int count = 1;
            int tongdung = 0;
            int tongsai = 0;
            for (int i = 1; i <= soNgayTrongThang; i++)
            {
                DateTime ngay = new DateTime(nam, thang, i);
                int dung = chamcongbus.SoChamCongDungGio(new DateTime(nam, thang, i), true);
                int sai = chamcongbus.SoChamCongDungGio(new DateTime(nam, thang, i), false);
                if (dung > 0 || sai > 0)
                {
                    chart2.Series["Đúng giờ"].Points.AddXY(count, dung);
                    chart2.Series["Trễ giờ"].Points.AddXY(count, sai);
                    chart2.ChartAreas[0].AxisX.CustomLabels.Add(count - 0.5, count + 0.5, i.ToString());
                    count++;
                    tongdung += dung;
                    tongsai += sai;
                }
            }
            chart1.Series["Series1"].Points.AddXY("Đúng: "+tongdung, tongdung);
            chart1.Series["Series1"].Points.AddXY("Sai: " + tongsai, tongsai);

        }
    }
}
