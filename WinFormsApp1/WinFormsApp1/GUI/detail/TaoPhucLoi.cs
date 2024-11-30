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
    public partial class TaoPhucLoi : Form
    {
        private phucloidto phucloiDTO = new phucloidto(); 
        private phucloibus phucloiBUS = new phucloibus(); 
        private DTO.phucloidto SelectedPhucLoi { get; set; } 

        private string lastMaPhucLoi = ""; 
        private int i = 0; 
        public TaoPhucLoi()
        {
            InitializeComponent();
            try
            {
                
                List<phucloidto> phucloi = phucloiBUS.GetPhucLoi();
                lastMaPhucLoi = phucloi[^1].MaPhucLoi;

                
                string numericPart = lastMaPhucLoi.Substring(2); 
                if (int.TryParse(numericPart, out int lastIndex))
                {
                    i = lastIndex + 1; // Tăng chỉ số
                }
                else
                {
                    MessageBox.Show("Mã phúc lợi không hợp lệ. Đặt mã mặc định là PL00001.");
                    i = 1;
                }


                txtMaPhucLoi.Text = GenerateMaPhucLoi(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu phúc lợi: " + ex.Message);
            }
        }

        
        public TaoPhucLoi(DTO.phucloidto SelectedPhucLoi)
        {
            InitializeComponent();
            SelectedPhucLoi = SelectedPhucLoi;


            txtMaPhucLoi.Text = SelectedPhucLoi.MaPhucLoi;
            txtTenPhucLoi.Text = SelectedPhucLoi.TenPhucLoi;
            txtMoTa.Text = SelectedPhucLoi.MoTa;
            txtGiaTriPhucLoi.Text = SelectedPhucLoi.GiaTriPhucLoi.ToString();
            txtTrangThai.Text = SelectedPhucLoi.TrangThai.ToString();
        }

        private string GenerateMaPhucLoi(int index)
        {
            return index switch
            {
                < 10 => "PL000" + index,
                < 100 => "PL00" + index,
                < 1000 => "PL0" + index,
                < 10000 => "PL" + index,
                _ => "PL" + index
            };
        }

        // Sự kiện khi form tải
        private void TaoPhucLoi_Load(object sender, EventArgs e)
        {
            // Bất kỳ xử lý khởi tạo nào khác có thể đặt tại đây
        }

        private void btnTao_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenPhucLoi.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phúc lợi !");
                txtTenPhucLoi.Focus();
                return;
            }

            // Gán giá trị từ các ô nhập liệu vào DTO
            phucloiDTO.MaPhucLoi = txtMaPhucLoi.Text.Trim();
            phucloiDTO.TenPhucLoi = txtTenPhucLoi.Text.Trim();
            phucloiDTO.MoTa = string.IsNullOrWhiteSpace(txtMoTa.Text) ? null : txtMoTa.Text.Trim();
            phucloiDTO.GiaTriPhucLoi = int.TryParse(txtGiaTriPhucLoi.Text.Trim(), out int giaTri) ? giaTri : 0;
            phucloiDTO.TrangThai = int.TryParse(txtTrangThai.Text.Trim(), out int trangThai) ? trangThai : 0;


            try
            {
                
                phucloiBUS.AddPhucLoi(phucloiDTO);
                MessageBox.Show("Thêm phúc lợi thành công!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình thêm: " + ex.Message);
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Xác nhận hủy", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}
