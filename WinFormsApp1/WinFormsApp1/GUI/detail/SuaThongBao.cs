using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;

namespace WinFormsApp1.GUI.detail
{
    public partial class SuaThongBao : Form
    {
        private thongbaodto selectedThongBao { get; set; }
        static thongbaobus thongbaobus = new thongbaobus();

        public SuaThongBao(thongbaodto selectedThongBao)
        {
            InitializeComponent();
            this.selectedThongBao = selectedThongBao;

            // Set values from selectedThongBao to the form fields
            txtMaThongBao.Text = selectedThongBao.MaThongBao.Trim();
            txtNoiDung.Text = selectedThongBao.NoiDung.Trim();
            txtNguoiBanHanh.Text = selectedThongBao.NguoiBanHanh.Trim();
            dtpNgayBanHanh.Value = selectedThongBao.NgayBanHanh;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Nội dung thông báo không được để trống!");
                txtNoiDung.Focus();
            }
            else if (dtpNgayBanHanh.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày ban hành không được lớn hơn ngày hiện tại!");
            }
            else if (string.IsNullOrWhiteSpace(txtNguoiBanHanh.Text))
            {
                MessageBox.Show("Người ban hành không được để trống!");
                txtNguoiBanHanh.Focus();
            }
            else
            {
                thongbaodto updatedThongBao = new thongbaodto
                {
                    MaThongBao = txtMaThongBao.Text.Trim(),
                    NoiDung = txtNoiDung.Text.Trim(),
                    NguoiBanHanh = txtNguoiBanHanh.Text.Trim(),
                    NgayBanHanh = dtpNgayBanHanh.Value,
                };

                try
                {
                    thongbaobus.UpdateThongBao(updatedThongBao); // Update thongbao in the database
                    MessageBox.Show("Chỉnh sửa thông báo thành công!");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình chỉnh sửa: " + ex.Message);
                }
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Xác nhận hủy", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void SuaThongBao_Load_1(object sender, EventArgs e)
        {
            // Additional logic to load if needed
        }
    }
}
