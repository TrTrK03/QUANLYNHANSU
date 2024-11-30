using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;

namespace WinFormsApp1.GUI.detail
{
    public partial class TaoPhongBan : Form
    {
        private phongbandto departmentDTO = new phongbandto(); // DTO đối tượng phòng ban
        private phongbanbus departmentBUS = new phongbanbus(); // BUS xử lý phòng ban
        private DTO.phongbandto SelectedDepartment { get; set; } // Phòng ban được chọn

        private string lastMaPhongBan = ""; // Lưu mã phòng ban cuối cùng
        private int i = 0; // Chỉ số để tạo mã phòng ban mới

        // Constructor cho việc tạo mới phòng ban
        public TaoPhongBan()
        {
            InitializeComponent();

            try
            {
                // Lấy danh sách phòng ban và mã cuối cùng
                List<phongbandto> departments = departmentBUS.GetPhongBan();
                lastMaPhongBan = departments[^1].MaPhongBan;

                // Xử lý mã phòng ban cuối cùng
                string numericPart = lastMaPhongBan.Substring(2); // Bỏ "PB", lấy phần số
                if (int.TryParse(numericPart, out int lastIndex))
                {
                    i = lastIndex + 1; // Tăng chỉ số
                }
                else
                {
                    MessageBox.Show("Mã phòng ban không hợp lệ. Đặt mã mặc định là PB00001.");
                    i = 1;
                }

                // Gán mã phòng ban mới
                txtMaPhongBan.Text = GenerateMaPhongBan(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu phòng ban: " + ex.Message);
            }
        }

        // Constructor cho việc chỉnh sửa phòng ban
        public TaoPhongBan(DTO.phongbandto selectedDepartment)
        {
            InitializeComponent();
            SelectedDepartment = selectedDepartment;

            // Gán thông tin phòng ban đã chọn
            txtMaPhongBan.Text = selectedDepartment.MaPhongBan;
            txtTenPhongBan.Text = selectedDepartment.TenPhongBan;
            txtMoTa.Text = selectedDepartment.MoTa;
        }

        // Phương thức sinh mã phòng ban mới dựa trên chỉ số
        private string GenerateMaPhongBan(int index)
        {
            return index switch
            {
                < 10 => "PB000" + index,
                < 100 => "PB00" + index,
                < 1000 => "PB0" + index,
                < 10000 => "PB" + index,
                _ => "PB" + index
            };
        }

        // Sự kiện khi form tải
        private void TaoPhongBan_Load(object sender, EventArgs e)
        {
            // Bất kỳ xử lý khởi tạo nào khác có thể đặt tại đây
        }

        private void btnTao_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenPhongBan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phòng ban!");
                txtTenPhongBan.Focus();
                return;
            }

            // Gán giá trị từ các ô nhập liệu vào DTO
            departmentDTO.MaPhongBan = txtMaPhongBan.Text;
            departmentDTO.TenPhongBan = txtTenPhongBan.Text;
            departmentDTO.MoTa = txtMoTa.Text;
            departmentDTO.TruongPhong = txtTruongPhong.Text;

            try
            {
                // Thêm phòng ban mới thông qua BUS
                departmentBUS.AddPhongBan(departmentDTO);
                MessageBox.Show("Thêm phòng ban thành công!");
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
