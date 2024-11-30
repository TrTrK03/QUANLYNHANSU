using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;

namespace WinFormsApp1.GUI.detail
{
    public partial class TaoDuAn : Form
    {
        private duandto projectDTO = new duandto(); // DTO đối tượng dự án
        private duanbus projectBUS = new duanbus(); // BUS xử lý dự án
        private DTO.duandto SelectedProject { get; set; } // Dự án được chọn (chỉnh sửa)

        private string lastMaDuAn = ""; // Lưu mã dự án cuối cùng
        private int i = 0; // Chỉ số để tạo mã dự án mới

        // Constructor cho việc tạo mới dự án
        public TaoDuAn()
        {
            InitializeComponent();

            try
            {
                // Lấy danh sách dự án và mã cuối cùng
                List<duandto> projects = projectBUS.GetDuAn();
                lastMaDuAn = projects[^1].MaDuAn;

                // Xử lý mã dự án cuối cùng
                string numericPart = lastMaDuAn.Substring(2); // Bỏ "DA", lấy phần số
                if (int.TryParse(numericPart, out int lastIndex))
                {
                    i = lastIndex + 1; // Tăng chỉ số
                }
                else
                {
                    MessageBox.Show("Mã dự án không hợp lệ. Đặt mã mặc định là DA00001.");
                    i = 1;
                }

                // Gán mã dự án mới
                txtMaDuAn.Text = GenerateMaDuAn(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu dự án: " + ex.Message);
            }
        }

        // Constructor cho việc chỉnh sửa dự án
        public TaoDuAn(DTO.duandto selectedProject)
        {
            InitializeComponent();
            SelectedProject = selectedProject;

            // Gán thông tin dự án đã chọn
            txtMaDuAn.Text = selectedProject.MaDuAn;
            txtTenDuAn.Text = selectedProject.TenDuAn;
            txtMoTa.Text = selectedProject.MoTa;
            dtpNgayBatDau.Value = selectedProject.NgayBatDau;
            dtpNgayKetThuc.Value = selectedProject.NgayKetThuc;
            txtQuanLyDuAn.Text = selectedProject.QuanLyDuAn;
            txtPhongBanPhuTrach.Text = selectedProject.PhongBanPhuTrach;
        }

        // Phương thức sinh mã dự án mới dựa trên chỉ số
        private string GenerateMaDuAn(int index)
        {
            return index switch
            {
                < 10 => "DA000" + index,
                < 100 => "DA00" + index,
                < 1000 => "DA0" + index,
                < 10000 => "DA" + index,
                _ => "DA" + index
            };
        }


        private void btnTao_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra ràng buộc dữ liệu
            if (string.IsNullOrEmpty(txtTenDuAn.Text))
            {
                MessageBox.Show("Vui lòng nhập tên dự án!");
                txtTenDuAn.Focus();
                return;
            }
            else if (dtpNgayBatDau.Value >= dtpNgayKetThuc.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc!");
                return;
            }

            // Gán giá trị từ các ô nhập liệu vào DTO
            projectDTO.MaDuAn = txtMaDuAn.Text;
            projectDTO.TenDuAn = txtTenDuAn.Text;
            projectDTO.MoTa = txtMoTa.Text;
            projectDTO.NgayBatDau = dtpNgayBatDau.Value;
            projectDTO.NgayKetThuc = dtpNgayKetThuc.Value;
            projectDTO.QuanLyDuAn = string.IsNullOrEmpty(txtQuanLyDuAn.Text) ? null : txtQuanLyDuAn.Text;
            projectDTO.PhongBanPhuTrach = string.IsNullOrEmpty(txtPhongBanPhuTrach.Text) ? null : txtPhongBanPhuTrach.Text;

            try
            {
                // Thêm dự án mới thông qua BUS
                projectBUS.AddDuAn(projectDTO);
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
