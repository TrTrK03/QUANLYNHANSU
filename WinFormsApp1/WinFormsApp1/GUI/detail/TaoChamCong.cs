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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WinFormsApp1.GUI.detail
{
    public partial class TaoChamCong : Form
    {
        static nhanvienbus nvbus = new nhanvienbus();
        static chamcongbus chamcongbus = new chamcongbus();
        List<string> dsMaNV = nvbus.GetMaNV();
        int buoi = 1;
        string manv = "0001";

        string ngay = "141224";
        string macc = "000011141224";




        public void Loaddata()
        {
            foreach (var ma in dsMaNV)
            {
                cbNV.Items.Add(ma);
            }

            // Thiết lập mục đầu tiên hiển thị (nếu có)
            if (cbNV.Items.Count > 0)
            {
                cbNV.SelectedIndex = 0;
            }
            cbNV.SelectedIndex = 0;
            manv = cbNV.Text.Substring(cbNV.Text.Length - 4);

            cbBuoi.SelectedIndex = 0;
            buoi = int.Parse(cbBuoi.Text);
            DateTime today = DateTime.Now;
            dpNgay.Value = today;
            ngay = today.ToString("ddMMyy");

            macc = manv + buoi.ToString() + ngay.ToString();
            txtMCC.Text = macc;

            string currentTime = today.ToString("HH:mm:ss");
            txtGiovaoca.Text = currentTime;


        }


        public TaoChamCong()
        {
            InitializeComponent();

        }

        private void cbBuoi_SelectedItemChanged(object sender, EventArgs e)
        {
            DomainUpDown cbBuoi = sender as DomainUpDown;
            buoi = cbBuoi.SelectedIndex + 1;
            macc = manv + buoi.ToString() + ngay.ToString();
            txtMCC.Text = macc;
        }

        private void cbNV_SelectedItemChanged(object sender, EventArgs e)
        {
            DomainUpDown cbNV = sender as DomainUpDown;
            //manv = cbNV.Text;
            manv = cbNV.Text.Substring(cbNV.Text.Length - 4);
            macc = manv + buoi.ToString() + ngay.ToString();
            txtMCC.Text = macc;
        }



        private void TaoChamCong_Load_1(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            chamcongdto chamcong = new chamcongdto();
            chamcong.MaNhanVien = "NV" + manv;
            chamcong.Buoi = buoi;
            DateTime dateTime = dpNgay.Value;
            chamcong.Ngay = dateTime;
            chamcong.MaBangChamCong = macc;
            chamcong.GioVaoCa = txtGiovaoca.Text;

            List<string> list = chamcongbus.GetMaCC();
            if (list.Contains(macc))
            {
                MessageBox.Show("Nhân viên đã chấm công trước đó!");
            }
            else
            {

                try
                {
                    chamcongbus.AddChamCong(chamcong);
                    MessageBox.Show("Chấm công thành công!");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình thêm: " + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Xác nhận hủy", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void dpNgay_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker date = sender as DateTimePicker;

            ngay = date.Value.ToString("ddMMyy");
            macc = manv + buoi.ToString() + ngay.ToString();
            txtMCC.Text = macc;
        }
    }
}
