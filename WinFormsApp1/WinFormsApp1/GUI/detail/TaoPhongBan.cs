using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;

namespace WinFormsApp1.GUI.detail
{
    public partial class TaoPhongBan : Form
    {
        phongbandto departmentDTO = new phongbandto();
        phongbanbus departmentBUS = new phongbanbus();
        private DTO.phongbandto SelectedDepartment { get; set; }

        string lastMaPhongBan = "";
        int i = 0;

        public TaoPhongBan()
        {
            InitializeComponent();
            List<phongbandto> departments = departmentBUS.GetPhongBan();
            lastMaPhongBan = departments[^1].MaPhongBan;
            i = Convert.ToInt32(lastMaPhongBan.Substring(lastMaPhongBan.Length - 5)) + 1;
            txtMaPhongBan.Text = GenerateMaPhongBan(i);
        }

        public TaoPhongBan(DTO.phongbandto selectedDepartment)
        {
            InitializeComponent();
            SelectedDepartment = selectedDepartment;

            txtMaPhongBan.Text = selectedDepartment.MaPhongBan;
            txtTenPhongBan.Text = selectedDepartment.TenPhongBan;
            txtMoTa.Text = selectedDepartment.MoTa;
        }

        private string GenerateMaPhongBan(int index)
        {
            return index switch
            {
                < 10 => "PB0000" + index,
                < 100 => "PB000" + index,
                < 1000 => "PB00" + index,
                < 10000 => "PB0" + index,
                _ => "PB" + index
            };
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Xác nhận hủy", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenPhongBan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phòng ban!");
                txtTenPhongBan.Focus();
            }
            else
            {
                departmentDTO.MaPhongBan = txtMaPhongBan.Text;
                departmentDTO.TenPhongBan = txtTenPhongBan.Text;
                departmentDTO.MoTa = txtMoTa.Text;

                try
                {
                    departmentBUS.AddPhongBan(departmentDTO);
                    MessageBox.Show("Thêm phòng ban thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình thêm: " + ex.Message);
                }
            }
        }

        private void TaoPhongBan_Load(object sender, EventArgs e)
        {
            // Any additional initialization can go here
        }

    }
}
