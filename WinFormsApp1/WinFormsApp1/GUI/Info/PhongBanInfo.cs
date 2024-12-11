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
using WinFormsApp1.DTO;

namespace WinFormsApp1.GUI.Info
{
    public partial class PhongBanInfo : Form
    {
        static nhanvienbus nhanvienbus = new nhanvienbus();
        public string MaPhongBan { get; set; }
        public string TruongPhong { get; set; }
        public string TenPhongBan { get; set; }
        public string MoTa { get; set; }
        public List<nhanviendto> nhanviens { get; set; }
        public PhongBanInfo()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            txtMaPB.Text = MaPhongBan;
            txtTruongPhong.Text = TruongPhong;
            txtTenPB.Text = TenPhongBan;
            txtMoTa.Text = MoTa;

            // Prepare DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Nhân Viên", typeof(string));
            dt.Columns.Add("Họ Tên", typeof(string));

            // Add employee data to DataTable
            if (nhanviens != null)
            {
                foreach (nhanviendto nhanvien in nhanviens)
                {
                    dt.Rows.Add(
                        nhanvien.MaNhanVien,
                        nhanvien.HoTen
                    );
                }
            }
            // Assign DataTable to DataGridView
            dataGridView1.DataSource = dt;
        }


    }
}