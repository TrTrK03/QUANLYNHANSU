using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;

namespace WinFormsApp1.GUI.detail
{
    public partial class TaoTuyenDung : Form
    {
        private tuyendungdto tuyendungdto = new tuyendungdto(); // DTO đối tượng dự án
        private tuyendungbus tuyendungbus = new tuyendungbus(); // BUS xử lý dự án
        private DTO.tuyendungdto SelectedProject { get; set; } // Dự án được chọn (chỉnh sửa)

        private string lastMaKyTuyenDung = ""; // Lưu mã dự án cuối cùng
        private int i = 0; // Chỉ số để tạo mã dự án mới

        // Constructor cho việc tạo mới dự án
        public TaoTuyenDung()
        {
            InitializeComponent();

            try
            {
                // Lấy danh sách dự án và mã cuối cùng
                List<tuyendungdto> tuyendungs = tuyendungbus.GetTuyenDung();
                lastMaKyTuyenDung = tuyendungs[^1].MaKyTuyenDung;

                // Xử lý mã dự án cuối cùng
                string numericPart = lastMaKyTuyenDung.Substring(2); // Bỏ "DA", lấy phần số
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
                txtMaKyTuyenDung.Text = GenerateMaKyTuyenDung(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu dự án: " + ex.Message);
            }
        }

        // Constructor cho việc chỉnh sửa dự án
        public TaoTuyenDung(DTO.tuyendungdto selectedProject)
        {
            InitializeComponent();
            SelectedProject = selectedProject;

            // Gán thông tin dự án đã chọn
            txtMaKyTuyenDung.Text = selectedProject.MaKyTuyenDung;
            txtNoiDung.Text = selectedProject.NoiDung;
            dtpNgayBatDau.Value = selectedProject.NgayBatDau;
            dtpNgayKetThuc.Value = selectedProject.NgayKetThuc;
            txtQuanLy.Text = selectedProject.MaQuanLy;
        }

        // Phương thức sinh mã dự án mới dựa trên chỉ số
        private string GenerateMaKyTuyenDung(int index)
        {
            return index switch
            {
                < 10 => "TD000" + index,
                < 100 => "TD00" + index,
                < 1000 => "TD0" + index,
                < 10000 => "TD" + index,
                _ => "TD" + index
            };
        }


        private void btnTao_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra ràng buộc dữ liệu
            if (dtpNgayBatDau.Value >= dtpNgayKetThuc.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc!");
                return;
            }

            // Gán giá trị từ các ô nhập liệu vào DTO
            tuyendungdto.MaKyTuyenDung = txtMaKyTuyenDung.Text;
            tuyendungdto.NoiDung = txtNoiDung.Text;
            tuyendungdto.NgayBatDau = dtpNgayBatDau.Value;
            tuyendungdto.NgayKetThuc = dtpNgayKetThuc.Value;
            tuyendungdto.MaQuanLy = string.IsNullOrEmpty(txtQuanLy.Text) ? null : txtQuanLy.Text;

            try
            {
                // Thêm dự án mới thông qua BUS
                tuyendungbus.AddTuyenDung(tuyendungdto);
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
