using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.GUI.detail
{
    public partial class SuaPhongBan : Form
    {
        private phongbandto SelectedDepartment { get; set; }
        static phongbanbus departmentBUS = new phongbanbus();

        public SuaPhongBan(phongbandto selectedDepartment)
        {
            InitializeComponent();
            selectedDepartment = selectedDepartment;

            txtMaPhongBan.Text = selectedDepartment.MaPhongBan.Trim();
            txtTenPhongBan.Text = selectedDepartment.TenPhongBan.Trim();
            txtMoTa.Text = selectedDepartment.MoTa?.Trim() ?? "";
            txtTruongPhong.Text = selectedDepartment.TruongPhong.Trim();
        }

        private void SuaPhongBan_Load(object sender, EventArgs e)
        {
            // Any additional load operations for the form can be added here
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Xác nhận hủy", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenPhongBan.Text))
            {
                MessageBox.Show("Tên phòng ban không được để trống!");
                txtTenPhongBan.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtTruongPhong.Text))
            {
                MessageBox.Show("Trưởng phòng không được để trống!");
                txtTruongPhong.Focus();
            }
            else
            {
                phongbandto departmentDTO = new phongbandto
                {
                    MaPhongBan = txtMaPhongBan.Text.Trim(),
                    TenPhongBan = txtTenPhongBan.Text.Trim(),
                    MoTa = string.IsNullOrWhiteSpace(txtMoTa.Text) ? null : txtMoTa.Text.Trim(),
                    TruongPhong = txtTruongPhong.Text.Trim(),
                };

                try
                {
                    departmentBUS.UpdatePhongBan(departmentDTO);
                    MessageBox.Show("Chỉnh sửa phòng ban thành công!");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình chỉnh sửa: " + ex.Message);
                }
            }
        }
    }
}
