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

namespace WinFormsApp1.GUI.detail
{
    public partial class suachamcong : Form
    {
        static nhanvienbus nvbus = new nhanvienbus();
        static chamcongbus chamcongbus = new chamcongbus();
        static chamcongdto Chamcongselected { get; set; }


        List<string> dsMaNV = nvbus.GetMaNV();
        int buoi = 1;
        string manv = "00001";

        string ngay = "141224";
        string macc = "000011141224";

        public void Loaddata()
        {
            foreach (var ma in dsMaNV)
            {
                cbNV.Items.Add(ma);
            }

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
                    MessageBox.Show("Chấm công thành công thành công!");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình thêm: " + ex.Message);
                }
            }
        }

        public suachamcong(chamcongdto chamcongselected)
        {
            InitializeComponent();
            Chamcongselected = chamcongselected;
            txtGiovaoca.Text = Chamcongselected.GioVaoCa;
            cbBuoi.SelectedIndex = Chamcongselected.Buoi - 1;

            foreach (var EMP in dsMaNV)
            {
                cbNV.Items.Add(EMP);
            }
            string ma = Chamcongselected.MaNhanVien;
            if (cbNV.Items.Contains(ma)) // Kiểm tra xem giá trị có trong danh sách hay không
            {
                cbNV.SelectedItem = ma; // Gán giá trị
            }
            else
            {
                MessageBox.Show("Mã nhân viên không tồn tại trong danh sách");
            }

            dpNgay.Value = Chamcongselected.Ngay;

            txtMCC.Text = Chamcongselected.MaBangChamCong;




        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Xác nhận hủy", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void cbBuoi_SelectedItemChanged_1(object sender, EventArgs e)
        {
            DomainUpDown cbBuoi = sender as DomainUpDown;
            buoi = cbBuoi.SelectedIndex + 1;
            macc = manv + buoi.ToString() + ngay.ToString();
            txtMCC.Text = macc;
        }

        private void cbNV_SelectedItemChanged_1(object sender, EventArgs e)
        {
            DomainUpDown cbNV = sender as DomainUpDown;
            //manv = cbNV.Text;
            manv = cbNV.Text.Substring(cbNV.Text.Length - 4);
            macc = manv + buoi.ToString() + ngay.ToString();
            txtMCC.Text = macc;
        }

        private void dpNgay_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker date = sender as DateTimePicker;

            ngay = date.Value.ToString("ddMMyy");
            macc = manv + buoi.ToString() + ngay.ToString();
            txtMCC.Text = macc;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chamcongdto chamcong = new chamcongdto();
            chamcong.MaNhanVien = "NV" + manv;
            chamcong.Buoi = buoi;
            DateTime dateTime = dpNgay.Value;
            chamcong.Ngay = dateTime;
            chamcong.MaBangChamCong = macc;
            chamcong.GioVaoCa = txtGiovaoca.Text;

            try
            {
                chamcongbus.UpdateChamCong(chamcong);
                MessageBox.Show("Chỉnh sửa thành công!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình thêm: " + ex.Message);
            }
        }
    }
}
