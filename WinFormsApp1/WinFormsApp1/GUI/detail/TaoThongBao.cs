using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;

namespace WinFormsApp1.GUI.detail
{
    public partial class TaoThongBao : Form
    {
        private thongbaodto thongbaodto = new thongbaodto(); // DTO đối tượng dự án
        private thongbaobus thongbaobus = new thongbaobus(); // BUS xử lý dự án
        private DTO.thongbaodto selectedThongBao { get; set; } // Dự án được chọn (chỉnh sửa)

        private string lastMaThongBao = ""; // Lưu mã dự án cuối cùng
        private int i = 0; // Chỉ số để tạo mã dự án mới

        // Constructor cho việc tạo mới dự án
        public TaoThongBao()
        {
            InitializeComponent();

            try
            {
                // Lấy TNnh sách dự án và mã cuối cùng
                List<thongbaodto> projects = thongbaobus.GetThongBao();
                lastMaThongBao = projects[^1].MaThongBao;

                // Xử lý mã dự án cuối cùng
                string numericPart = lastMaThongBao.Substring(2); // Bỏ "TN", lấy phần số
                if (int.TryParse(numericPart, out int lastIndex))
                {
                    i = lastIndex + 1; // Tăng chỉ số
                }
                else
                {
                    MessageBox.Show("Mã dự án không hợp lệ. Đặt mã mặc định là TN00001.");
                    i = 1;
                }

                // Gán mã dự án mới
                txtMaThongBao.Text = GenerateMaThongBao(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu dự án: " + ex.Message);
            }
        }

        // Constructor cho việc chỉnh sửa dự án
        public TaoThongBao(DTO.thongbaodto selectedThongBao)
        {
            InitializeComponent();
            selectedThongBao = selectedThongBao;

            // Gán thông tin dự án đã chọn
            txtMaThongBao.Text = selectedThongBao.MaThongBao;
            txtNoiDung.Text = selectedThongBao.NoiDung;
            dtpNgayBanHanh.Value = selectedThongBao.NgayBanHanh;
            txtNguoiBanHanh.Text = selectedThongBao.NguoiBanHanh;
        }

        // Phương thức sinh mã dự án mới dựa trên chỉ số
        private string GenerateMaThongBao(int index)
        {
            return index switch
            {
                < 10 => "TB000" + index,
                < 100 => "TB00" + index,
                < 1000 => "TB0" + index,
                < 10000 => "TB" + index,
                _ => "TN" + index
            };
        }


        private void btnTao_Click_1(object sender, EventArgs e)
        {
            // Gán giá trị từ các ô nhập liệu vào DTO
            thongbaodto.MaThongBao = txtMaThongBao.Text;
            thongbaodto.NoiDung = txtNoiDung.Text;
            thongbaodto.NgayBanHanh = dtpNgayBanHanh.Value;
            thongbaodto.NguoiBanHanh = string.IsNullOrEmpty(txtNguoiBanHanh.Text) ? null : txtNguoiBanHanh.Text;

            try
            {
                // Thêm dự án mới thông qua BUS
                thongbaobus.AddThongBao(thongbaodto);
                MessageBox.Show("Thêm dự án thành công!");
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
