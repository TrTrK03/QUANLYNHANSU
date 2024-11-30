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

namespace WinFormsApp1.GUI.wave
{
    public partial class themBangLuongGUI : Form
    {
        private bangLuongBUS bangLuongBUS;

        public themBangLuongGUI()
        {
            InitializeComponent();
            bangLuongBUS = new bangLuongBUS();
            LoadEmployeesWithoutSalary();
        }

        // Hàm này sẽ lấy thông tin mã nhân viên được chọn
        private void label5_Click(object sender, EventArgs e)
        {
            // Bạn có thể để hàm này trống nếu không cần xử lý thêm ở đây
        }

        // Tính toán lại lương thực nhận khi người dùng thay đổi phụ cấp hoặc khấu trừ
        private void CalculateLuongThucNhan()
        {
            try
            {
                // Lấy thông tin mã nhân viên được chọn
                string maNhanVien = (comboBoxNhanVien.SelectedItem as dynamic).MaNhanVien;

                // Lấy các thông tin phụ cấp và khấu trừ từ TextBox
                int phuCap = string.IsNullOrEmpty(textBoxPhuCap.Text) ? 0 : int.Parse(textBoxPhuCap.Text);  // Nếu trống thì lấy 0
                int khauTru = string.IsNullOrEmpty(textBoxKhauTru.Text) ? 0 : int.Parse(textBoxKhauTru.Text);  // Nếu trống thì lấy 0

                // Lấy thông tin lương cơ bản của nhân viên từ bảng chức vụ
                int luongCoBan = bangLuongBUS.GetLuongCoBanByMaNhanVien(maNhanVien);

                // Tính lương thực nhận
                int luongThucNhan = luongCoBan + phuCap - khauTru;

                // Hiển thị lương thực nhận trong TextBox (không cho thay đổi giá trị)
                textBoxLuongThucNhan.Text = luongThucNhan.ToString();  // textBoxLuongThucNhan là TextBox chỉ để hiển thị
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính lương thực nhận: " + ex.Message);
            }
        }

        // Tải danh sách nhân viên chưa có lương
        private void LoadEmployeesWithoutSalary()
        {
            try
            {
                var employeeList = bangLuongBUS.getListEmployeeNotSalary();
                comboBoxNhanVien.Items.Clear();

                foreach (var employee in employeeList)
                {
                    comboBoxNhanVien.Items.Add(new { MaNhanVien = employee.MaNhanVien, HoTen = employee.HoTen });
                }

                comboBoxNhanVien.DisplayMember = "HoTen";  // Hiển thị tên
                comboBoxNhanVien.ValueMember = "MaNhanVien";  // Lưu trữ mã nhân viên

                if (comboBoxNhanVien.Items.Count > 0)
                {
                    comboBoxNhanVien.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu nhân viên: " + ex.Message);
            }
        }

        // Hàm xử lý khi nhấn nút "Thêm mới bảng lương"
        // Form themBangLuongGUI

        private void addWage_Click(object sender, EventArgs e)
        {
            try
            {
                string maNhanVien = (comboBoxNhanVien.SelectedItem as dynamic).MaNhanVien;
                int phuCap = string.IsNullOrEmpty(textBoxPhuCap.Text) ? 0 : int.Parse(textBoxPhuCap.Text);
                int khauTru = string.IsNullOrEmpty(textBoxKhauTru.Text) ? 0 : int.Parse(textBoxKhauTru.Text);
                int luongCoBan = bangLuongBUS.GetLuongCoBanByMaNhanVien(maNhanVien);

                // Tính lương thực nhận
                int luongThucNhan = luongCoBan + phuCap - khauTru;

                // Tạo đối tượng bảng lương và thêm vào cơ sở dữ liệu
                bangLuongDTO newSalary = new bangLuongDTO
                {
                    MaNhanVien = maNhanVien,
                    ThangNam = DateTime.Now,  // Tháng hiện tại
                    PhuCap = phuCap,
                    KhauTru = khauTru,
                    LuongThucNhan = luongThucNhan
                };

                // Thêm bảng lương vào cơ sở dữ liệu
                bool isAdded = bangLuongBUS.AddLuong(newSalary);

                if (isAdded)
                {
                    // Thông báo thành công
                    MessageBox.Show("Thêm bảng lương thành công!");
                    this.DialogResult = DialogResult.OK; // Đặt kết quả là OK khi thành công
                    this.Close(); // Đóng form sau khi thêm thành công
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm bảng lương. Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm bảng lương: " + ex.Message);
            }
        }



        // Sự kiện TextChanged cho textBoxKhauTru

        private void textBoxPhuCap_TextChanged_1(object sender, EventArgs e)
        {
            CalculateLuongThucNhan();
        }

        private void textBoxKhauTru_TextChanged(object sender, EventArgs e)
        {
            CalculateLuongThucNhan();
        }
    }

}
