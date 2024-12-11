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
    public partial class SuaPhucLoi : Form
    {
        private phucloidto selectedPhucLoi { get; set; }
        static phucloibus phucloiBUS = new phucloibus();
        public SuaPhucLoi(phucloidto selectedPhucLoi)
        {
            InitializeComponent();
            selectedPhucLoi = selectedPhucLoi;

            txtMaPhucLoi.Text = selectedPhucLoi.MaPhucLoi.Trim();
            txtTenPhucLoi.Text = selectedPhucLoi.TenPhucLoi.Trim();
            txtMoTa.Text = selectedPhucLoi.MoTa?.Trim() ?? "";
            txtGiaTriPhucLoi.Text = selectedPhucLoi.GiaTriPhucLoi.ToString();
            txtTrangThai.Text = selectedPhucLoi.TrangThai.ToString();

        }

        private void SuaPhucLoi_Load(object sender, EventArgs e)
        {

        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenPhucLoi.Text))
            {
                MessageBox.Show("Tên phúc lợi không được để trống!");
                txtTenPhucLoi.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtMoTa.Text))
            {
                MessageBox.Show("Mô tả không được để trống!");
                txtMoTa.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtGiaTriPhucLoi.Text))
            {
                MessageBox.Show("Hãy nhập giá trị phúc lợi" + "!");
                txtGiaTriPhucLoi.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtTrangThai.Text))
            {
                MessageBox.Show("Hãy nhập trạng thái!");
                txtTrangThai.Focus();
            }
            else
            {
                phucloidto phucloiDTO = new phucloidto
                {
                    MaPhucLoi = txtMaPhucLoi.Text.Trim(),
                    TenPhucLoi = txtTenPhucLoi.Text.Trim(),
                    MoTa = string.IsNullOrWhiteSpace(txtMoTa.Text) ? null : txtMoTa.Text.Trim(),
                    GiaTriPhucLoi = int.TryParse(txtGiaTriPhucLoi.Text.Trim(), out int giaTri) ? giaTri : 0,
                    TrangThai = int.TryParse(txtTrangThai.Text.Trim(), out int trangThai) ? trangThai : 0
                };

                try
                {
                    phucloiBUS.UpdatePhucLoi(phucloiDTO);
                    MessageBox.Show("Chỉnh sửa phúc lợi thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình chỉnh sửa: " + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Xác nhận hủy", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
