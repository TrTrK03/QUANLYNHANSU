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
using WinFormsApp1.DAO;

namespace WinFormsApp1.GUI
{
    public partial class chamconggui : UserControl
    {
        static chamcongbus chamcongbus = new chamcongbus();
        chamcongdto chamcongdto = new chamcongdto();
        List<chamcongdto> chamcongs = chamcongbus.GetChamCong();
        public chamconggui()
        {
            InitializeComponent();
        }


        private void LoadDataToGUI()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Check", typeof(bool));
            dt.Columns.Add("Ma Cham công", typeof(string));
            dt.Columns.Add("Ngày", typeof(string));
            dt.Columns.Add("Thời gian", typeof(string));

            foreach (chamcongdto chamcong in chamcongs)
            {
                dt.Rows.Add(false, chamcong.MaBangChamCong, chamcong.ThangNam.ToString("dd/MM/yyyy"), chamcong.GioVaoCa);
            }
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridView1.ColumnHeadersDefaultCellStyle.BackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void chamconggui_Load(object sender, EventArgs e)
        {
            LoadDataToGUI();
            txtSearch.PlaceholderText = "Tìm kiếm ...";
            dataGridView1.Dock = DockStyle.Fill;
        }
    }
}
