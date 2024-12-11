using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;

namespace WinFormsApp1.GUI.detail
{
    public partial class TaoNhanVien : Form
    {
        private nhanviendto employeeDTO = new nhanviendto(); // DTO for employee
        private nhanvienbus employeeBUS = new nhanvienbus(); // BUS for employee
        private DTO.nhanviendto SelectedEmployee { get; set; } // Selected employee for editing

        private string lastMaNV = ""; // Store last employee ID
        private int i = 0; // Counter for generating new employee ID

        // Constructor for creating a new employee
        public TaoNhanVien()
        {
            InitializeComponent();

            try
            {
                // Get the list of employees and the last employee ID
                List<nhanviendto> employees = employeeBUS.GetNhanVienLast();
                lastMaNV = employees[^1].MaNhanVien;

                // Process last employee ID to generate the next one
                string numericPart = lastMaNV.Substring(2); // Get numeric part
                if (int.TryParse(numericPart, out int lastIndex))
                {
                    i = lastIndex + 1; // Increment the index
                }
                else
                {
                    MessageBox.Show("Mã nhân viên không hợp lệ. Đặt mã mặc định là NV00001.");
                    i = 1;
                }

                // Generate new employee ID
                txtMaNV.Text = GenerateMaNV(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu nhân viên: " + ex.Message);
            }
        }

        // Constructor for editing an existing employee
        public TaoNhanVien(DTO.nhanviendto selectedEmployee)
        {
            InitializeComponent();
            SelectedEmployee = selectedEmployee;

            // Assign values from selected employee to fields
            txtMaNV.Text = selectedEmployee.MaNhanVien;
            txtHoTen.Text = selectedEmployee.HoTen;
            txtSDT.Text = selectedEmployee.SDT;
            txtEmail.Text = selectedEmployee.Email;
            txtDiaChi.Text = selectedEmployee.DiaChi;
            txtChucVu.Text = selectedEmployee.ChucVu;
            txtNQL.Text = selectedEmployee.NguoiQuanLy;
            txtPhongBan.Text = selectedEmployee.PhongBan;

            // Set gender based on selected employee
            if (selectedEmployee.GioiTinh.Trim().ToLower() == "nam")
                cbNam.Checked = true;
            else if (selectedEmployee.GioiTinh.Trim().ToLower() == "nữ")
                cbNu.Checked = true;

            // Set status based on selected employee
        }

        // Method to generate a new employee ID
        private string GenerateMaNV(int index)
        {
            return index switch
            {
                < 10 => "NV000" + index,
                < 100 => "NV00" + index,
                < 1000 => "NV0" + index,
                < 10000 => "NV" + index,
                _ => "NV" + index
            };
        }

        // Event handler for creating a new employee
        private void btnTao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Hãy ghi đầy đủ họ tên");
                txtHoTen.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPhongBan.Text))
            {
                MessageBox.Show("Hãy nhập phong ban");
                txtPhongBan.Focus();
                return;
            }

            // Assign values to employeeDTO
            employeeDTO.MaNhanVien = txtMaNV.Text;
            employeeDTO.HoTen = txtHoTen.Text;
            employeeDTO.SDT = txtSDT.Text;
            employeeDTO.Email = txtEmail.Text;
            employeeDTO.DiaChi = txtDiaChi.Text;
            employeeDTO.ChucVu = txtChucVu.Text;
            employeeDTO.NguoiQuanLy = txtNQL.Text;
            employeeDTO.PhongBan = txtPhongBan.Text;
            employeeDTO.GioiTinh = cbNam.Checked ? "Nam" : "Nữ";
            employeeDTO.NgaySinh = dtpNgaySinh.Value;

            try
            {
                // Add the new employee using BUS
                employeeBUS.AddNhanVien(employeeDTO);
                MessageBox.Show("Thêm nhân viên thành công!");
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
