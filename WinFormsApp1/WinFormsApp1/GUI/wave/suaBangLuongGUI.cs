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
    public partial class suaBangLuongGUI : Form
    {
        private bangLuongDTO selectedSalaryData;
        private bangLuongBUS bangLuongBUS;
        public suaBangLuongGUI(bangLuongDTO bangLuongDTO )
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            selectedSalaryData = bangLuongDTO;

            textBoxMaNV.Text = selectedSalaryData.MaNhanVien + "-" + selectedSalaryData.HoTen;

            dateTimePicker1.Value = selectedSalaryData.ThangNam;
            textBoxPhuCap.Text = selectedSalaryData.PhuCap.ToString();
            textBoxKhauTru.Text = selectedSalaryData.KhauTru.ToString();
            textBoxLuongThucNhan.Text = selectedSalaryData.LuongThucNhan.ToString();
            bangLuongBUS = new bangLuongBUS();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateWage_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các TextBox và DateTimePicker
                string maNhanVien = textBoxMaNV.Text.Split('-')[0].Trim();
                if (string.IsNullOrEmpty(maNhanVien))
                {
                    MessageBox.Show("Mã nhân viên không hợp lệ.");
                    return;
                }

                DateTime thangNam = dateTimePicker1.Value;

                // Kiểm tra giá trị phụ cấp
                if (!int.TryParse(textBoxPhuCap.Text, out int phuCap))
                {
                    MessageBox.Show("Phụ cấp phải là số nguyên hợp lệ.");
                    return;
                }

                // Kiểm tra giá trị khấu trừ
                if (!int.TryParse(textBoxKhauTru.Text, out int khauTru))
                {
                    MessageBox.Show("Khấu trừ phải là số nguyên hợp lệ.");
                    return;
                }

                // Kiểm tra giá trị lương thực nhận
                if (!int.TryParse(textBoxLuongThucNhan.Text, out int luongThucNhan))
                {
                    MessageBox.Show("Lương thực nhận phải là số nguyên hợp lệ.");
                    return;
                }

                // Kiểm tra tính hợp lệ của mã nhân viên
                if (string.IsNullOrEmpty(maNhanVien))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                // Kiểm tra ngày tháng (Ngày không thể lớn hơn ngày hiện tại)
                if (thangNam > DateTime.Now)
                {
                    MessageBox.Show("Ngày tháng không thể lớn hơn ngày hiện tại.");
                    return;
                }

                // Tạo đối tượng bangLuongDTO từ dữ liệu người dùng nhập
                bangLuongDTO updatedSalary = new bangLuongDTO
                {
                    MaNhanVien = maNhanVien,
                    ThangNam = thangNam,
                    PhuCap = phuCap,
                    KhauTru = khauTru,
                    LuongThucNhan = luongThucNhan
                };

                // Gọi phương thức cập nhật dữ liệu trong BUS
                bool isUpdated = bangLuongBUS.UpdateLuong(updatedSalary);

                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật bảng lương thành công.");
                    this.DialogResult = DialogResult.OK; // Đóng form nếu cập nhật thành công
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }


        private void suaBangLuongGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
