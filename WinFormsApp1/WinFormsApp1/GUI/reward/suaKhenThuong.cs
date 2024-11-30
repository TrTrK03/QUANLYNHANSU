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

namespace WinFormsApp1.GUI.reward
{
    public partial class suaKhenThuong : Form
    {
        private khenThuongDTO khenThuongDTO;
        private khenThuongBUS khenThuongBUS;
        public suaKhenThuong(khenThuongDTO dto)
        {
            InitializeComponent();
            khenThuongDTO = dto;
            khenThuongBUS = new khenThuongBUS();
            SuaKhenThuongForm_Load();
           
        }
        private void SuaKhenThuongForm_Load()
        {
            // Hiển thị dữ liệu của khen thưởng lên các trường
            textBoxMaKhenThuong.Text = khenThuongDTO.MaKhenThuong.ToString();

            // Load danh sách nhân viên vào ComboBox
            loadEmployeeData();

            // Sau khi load dữ liệu vào ComboBox, chọn giá trị tương ứng với mã nhân viên từ khenThuongDTO
            var selectedEmployee = comboBoxMaNV.Items
                .Cast<dynamic>()
                .FirstOrDefault(item => item.MaNhanVien == khenThuongDTO.MaNhanVien);

            if (selectedEmployee != null)
            {
                // Chọn nhân viên từ khenThuongDTO trong ComboBox
                comboBoxMaNV.SelectedItem = selectedEmployee;  // Đặt SelectedItem, không phải Text
            }

            // Load danh sách loại khen thưởng vào ComboBox
            loadRewardTypes();

            // Sau khi load loại khen thưởng vào ComboBox, chọn giá trị tương ứng với loại khen thưởng từ khenThuongDTO
            comboBoxLoaiKT.SelectedItem = khenThuongDTO.LoaiKhenThuong;

            // Các trường dữ liệu khác
            textBoxGiaTriKT.Text = khenThuongDTO.GiaTriKhenThuong.ToString();
            richTextBoxChiTietKT.Text = khenThuongDTO.ChiTietKhenThuong.ToString();
            dateTimePicker.Value = khenThuongDTO.NgayKhenThuong;
        }



        private void buttonSave_Click(object sender, EventArgs e)
        {
           
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các trường nhập liệu
                // Lấy mã nhân viên và loại khen thưởng từ ComboBox
                var selectedEmployee = comboBoxMaNV.SelectedItem as dynamic;
                if (selectedEmployee == null)
                {
                    MessageBox.Show("Chọn nhân viên trước khi lưu.");
                    return;
                }

                khenThuongDTO.MaNhanVien = selectedEmployee.MaNhanVien;

                // Lấy loại khen thưởng từ ComboBox
                string loaiKhenThuong = comboBoxLoaiKT.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(loaiKhenThuong))
                {
                    MessageBox.Show("Chọn loại khen thưởng trước khi lưu.");
                    return;
                }

                khenThuongDTO.LoaiKhenThuong = loaiKhenThuong;

                // Cập nhật giá trị khen thưởng từ textBox
                if (int.TryParse(textBoxGiaTriKT.Text, out int giaTri))
                {
                    khenThuongDTO.GiaTriKhenThuong = giaTri;
                }
                else
                {
                    MessageBox.Show("Giá trị khen thưởng không hợp lệ.");
                    return;
                }

                // Cập nhật chi tiết khen thưởng từ richTextBox
                khenThuongDTO.ChiTietKhenThuong = richTextBoxChiTietKT.Text;

                // Cập nhật ngày khen thưởng từ dateTimePicker
                khenThuongDTO.NgayKhenThuong = dateTimePicker.Value;

                // Gọi phương thức cập nhật từ BUS để lưu lại vào cơ sở dữ liệu
                bool isUpdated = khenThuongBUS.updateReward(khenThuongDTO);

                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật khen thưởng thành công!");
                    this.DialogResult = DialogResult.OK;  // Trả về DialogResult.OK khi cập nhật thành công
                    this.Close();  // Đóng form sửa khen thưởng
                }
                else
                {
                    MessageBox.Show("Cập nhật khen thưởng thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật khen thưởng: " + ex.Message);
            }
        }

        private void loadEmployeeData()
        {
            try
            {
                var employeeList = khenThuongBUS.getEmployeeIdAndName();

                comboBoxMaNV.Items.Clear();



                foreach (var employee in employeeList)
                {
                    comboBoxMaNV.Items.Add(new { MaNhanVien = employee.Key, TenNhanVien = employee.Value });
                }


                comboBoxMaNV.DisplayMember = "TenNhanVien";
                comboBoxMaNV.ValueMember = "MaNhanVien";

                comboBoxMaNV.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu nhân viên: " + ex.Message);
            }
        }


        private void loadRewardTypes()
        {
            try
            {
                // Lấy danh sách các loại khen thưởng từ BUS
                var rewardTypes = khenThuongBUS.getRewardTypes();

                // Xóa các mục cũ trong ComboBox (nếu có)
                comboBoxLoaiKT.Items.Clear();

                // Thêm một mục mặc định cho ComboBox

                // Thêm các loại khen thưởng từ danh sách vào ComboBox
                foreach (var rewardType in rewardTypes)
                {
                    comboBoxLoaiKT.Items.Add(rewardType);
                }

                // Chọn mục mặc định là "Chọn loại khen thưởng"
                comboBoxLoaiKT.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu loại khen thưởng: " + ex.Message);
            }
        }

    }
}
