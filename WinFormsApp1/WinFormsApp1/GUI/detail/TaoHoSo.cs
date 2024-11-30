using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;

namespace WinFormsApp1.GUI.detail
{
    public partial class TaoHoSo : Form
    {
        private hosotuyendungdto hosotuyendungdto = new hosotuyendungdto(); // DTO for recruitment profile
        private hosotuyendungbus hosotuyendungbus = new hosotuyendungbus(); // BUS for recruitment profile
        private hosotuyendungdto SelectedProfile { get; set; } // Selected profile for editing

        private string lastMaHS = ""; // Store the last recruitment profile ID
        private int i = 0; // Counter for generating new recruitment profile ID

        // Constructor for creating a new recruitment profile
        public TaoHoSo()
        {
            InitializeComponent();

            try
            {
                // Get the list of profiles and the last profile ID
                List<hosotuyendungdto> profiles = hosotuyendungbus.GetHoSoTuyenDung();
                lastMaHS = profiles[^1].MaHoSoTuyenDung;

                // Process last profile ID to generate the next one
                string numericPart = lastMaHS.Substring(2); // Get numeric part
                if (int.TryParse(numericPart, out int lastIndex))
                {
                    i = lastIndex + 1; // Increment the index
                }
                else
                {
                    MessageBox.Show("Mã hồ sơ không hợp lệ. Đặt mã mặc định là HS0001.");
                    i = 1;
                }

                // Generate new profile ID
                txtMaHS.Text = GenerateMaHS(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu hồ sơ: " + ex.Message);
            }
        }

        // Constructor for editing an existing recruitment profile
        public TaoHoSo(hosotuyendungdto selectedProfile)
        {
            InitializeComponent();
            SelectedProfile = selectedProfile;

            // Assign values from selected profile to fields
            txtMaHS.Text = selectedProfile.MaHoSoTuyenDung;
            txtHoTen.Text = selectedProfile.HoTen;
            dtpNgaySinh.Value = selectedProfile.NgaySinh;
            txtSDT.Text = selectedProfile.SDT;
            txtEmail.Text = selectedProfile.Email;
            txtDiaChi.Text = selectedProfile.DiaChi;
            txtTrinhDo.Text = selectedProfile.TrinhDo;
            txtMoTaBangCap.Text = selectedProfile.MoTaBangCap;
            txtKyTuyenDung.Text = selectedProfile.KyTuyenDung;

            // Set gender based on selected profile
            if (selectedProfile.GioiTinh.Trim().ToLower() == "nam")
                cbNam.Checked = true;
            else if (selectedProfile.GioiTinh.Trim().ToLower() == "nữ")
                cbNu.Checked = true;
        }

        // Method to generate a new profile ID
        private string GenerateMaHS(int index)
        {
            return index switch
            {
                < 10 => "HS000" + index,
                < 100 => "HS00" + index,
                < 1000 => "HS0" + index,
                < 10000 => "HS" + index,
                _ => "HS" + index
            };
        }

        // Event handler for creating a new recruitment profile
        private void btnTao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Hãy ghi đầy đủ họ tên.");
                txtHoTen.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtKyTuyenDung.Text))
            {
                MessageBox.Show("Hãy nhập kỳ tuyển dụng.");
                txtKyTuyenDung.Focus();
                return;
            }

            // Assign values to hosotuyendungdto
            hosotuyendungdto.MaHoSoTuyenDung = txtMaHS.Text;
            hosotuyendungdto.HoTen = txtHoTen.Text;
            hosotuyendungdto.SDT = txtSDT.Text;
            hosotuyendungdto.Email = txtEmail.Text;
            hosotuyendungdto.DiaChi = txtDiaChi.Text;
            hosotuyendungdto.TrinhDo = txtTrinhDo.Text;
            hosotuyendungdto.MoTaBangCap = txtMoTaBangCap.Text;
            hosotuyendungdto.KyTuyenDung = txtKyTuyenDung.Text;
            hosotuyendungdto.GioiTinh = cbNam.Checked ? "Nam" : "Nữ";
            hosotuyendungdto.NgaySinh = dtpNgaySinh.Value;

            try
            {
                // Add the new profile using BUS
                hosotuyendungbus.AddHoSoTuyenDung(hosotuyendungdto);
                MessageBox.Show("Thêm hồ sơ thành công!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình thêm: " + ex.Message);
            }
        }

        // Event handler for cancelling
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Xác nhận hủy", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}
