using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;
using WinFormsApp1.GUI.reward;

namespace WinFormsApp1.GUI
{
    public partial class khenThuongGUI : UserControl
    {
        private khenThuongBUS khenThuongBUS;

        public khenThuongGUI()
        {
            InitializeComponent();
            khenThuongBUS = new khenThuongBUS();
            loadDataReward();
            loadEmployeeData();
            loadRewardTypes();
        }

        private void loadDataReward()
        {
            DataTable dt = new DataTable();

            // Cột Check sẽ là cột checkbox để người dùng chọn các khen thưởng muốn xóa
            dt.Columns.Add("Check", typeof(bool)); // Cột chọn để đánh dấu khen thưởng (nếu cần)
            dt.Columns.Add("Ma Khen Thuong", typeof(string)); // Đảm bảo kiểu string
            dt.Columns.Add("Ma Nhan Vien", typeof(string)); // Đảm bảo kiểu string
            dt.Columns.Add("Loai Khen Thuong", typeof(string));
            dt.Columns.Add("ChiTiet Khen Thuong", typeof(string));
            dt.Columns.Add("Gia Tri Khen Thuong", typeof(int));
            dt.Columns.Add("Ngay Khen Thuong", typeof(string)); // Dạng chuỗi để hiển thị theo định dạng mong muốn
            dt.Columns.Add("Trang Thai", typeof(int));

            try
            {
                var allRewards = khenThuongBUS.getListReward(); // Lấy dữ liệu từ lớp BUS

                foreach (khenThuongDTO reward in allRewards)
                {
                    // Thêm các dòng dữ liệu vào DataTable
                    dt.Rows.Add(false, reward.MaKhenThuong, reward.MaNhanVien, reward.LoaiKhenThuong,
                        reward.ChiTietKhenThuong, reward.GiaTriKhenThuong, reward.NgayKhenThuong.ToString("dd/MM/yyyy"), reward.TrangThai);
                }

                // Gán DataTable làm DataSource cho DataGridView
                dataKhenThuong.DataSource = dt;

                // Thêm cột Check vào DataGridView để có thể đánh dấu các khen thưởng
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "Check";
                checkColumn.HeaderText = "Chọn";
                checkColumn.Width = 50; // Bạn có thể điều chỉnh độ rộng của cột nếu cần
                checkColumn.FillWeight = 5; // Điều chỉnh tỷ lệ cột

                // Thêm cột checkbox vào DataGridView nếu chưa có
                if (!dataKhenThuong.Columns.Contains("Check"))
                {
                    dataKhenThuong.Columns.Insert(0, checkColumn);  // Chèn cột Check vào đầu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void loadEmployeeData()
        {
            try
            {
                var employeeList = khenThuongBUS.getEmployeeIdAndName();

                comboBoxNhanVien.Items.Clear();

                comboBoxNhanVien.Items.Add(new { MaNhanVien = "", TenNhanVien = "Chọn nhân viên" });


                foreach (var employee in employeeList)
                {
                    comboBoxNhanVien.Items.Add(new { MaNhanVien = employee.Key, TenNhanVien = employee.Value });
                }


                comboBoxNhanVien.DisplayMember = "TenNhanVien";
                comboBoxNhanVien.ValueMember = "MaNhanVien";

                comboBoxNhanVien.SelectedIndex = 0;
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
                comboBoxKhenThuong.Items.Clear();

                // Thêm một mục mặc định cho ComboBox
                comboBoxKhenThuong.Items.Add("Chọn loại khen thưởng");

                // Thêm các loại khen thưởng từ danh sách vào ComboBox
                foreach (var rewardType in rewardTypes)
                {
                    comboBoxKhenThuong.Items.Add(rewardType);
                }

                // Chọn mục mặc định là "Chọn loại khen thưởng"
                comboBoxKhenThuong.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu loại khen thưởng: " + ex.Message);
            }
        }
        
        // Các sự kiện khác nếu cần xử lý
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý khi người dùng click vào một cell trong DataGridView nếu cần
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xử lý khi người dùng chọn mục trong ComboBox nếu cần
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện click cho Label1 nếu cần
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện click cho Label2 nếu cần
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi thay đổi giá trị của DateTimePicker nếu cần
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            loadDataReward();
            searchReward.Text = "";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn khen thưởng trong DataGridView hay chưa
                DataGridViewRow selectedRow = null;

                // Duyệt qua các dòng để tìm dòng có checkbox được chọn
                foreach (DataGridViewRow row in dataKhenThuong.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["Check"].Value); // Lấy giá trị của checkbox
                    if (isSelected)
                    {
                        selectedRow = row;
                        break;  // Nếu có bất kỳ khen thưởng nào được chọn thì thoát khỏi vòng lặp
                    }
                }

                // Nếu không có khen thưởng nào được chọn
                if (selectedRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một khen thưởng để chỉnh sửa.");
                    return;
                }

                // Lấy thông tin khen thưởng từ dòng đã chọn
                string maKhenThuong = selectedRow.Cells["Ma Khen Thuong"].Value.ToString();
                string maNhanVien = selectedRow.Cells["Ma Nhan Vien"].Value.ToString();
                string loaiKhenThuong = selectedRow.Cells["Loai Khen Thuong"].Value.ToString();
                string chiTietKhenThuong = selectedRow.Cells["ChiTiet Khen Thuong"].Value.ToString();
                int giaTriKhenThuong = Convert.ToInt32(selectedRow.Cells["Gia Tri Khen Thuong"].Value);

                // Xử lý ngày khen thưởng (chỉ lấy ngày, không có giờ, phút)
                DateTime ngayKhenThuong;
                string ngayKhenThuongStr = selectedRow.Cells["Ngay Khen Thuong"].Value.ToString();

                // Cố gắng chuyển đổi ngày theo định dạng dd/MM/yyyy
                if (DateTime.TryParseExact(ngayKhenThuongStr, "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out ngayKhenThuong))
                {
                    // Ngày hợp lệ, chỉ lấy phần ngày, tháng, năm
                    ngayKhenThuong = ngayKhenThuong.Date;
                }
                else
                {
                    MessageBox.Show("Ngày khen thưởng không hợp lệ.");
                    return;
                }

                int trangThai = Convert.ToInt32(selectedRow.Cells["Trang Thai"].Value);

                // Kiểm tra xem giá trị có hợp lệ trước khi truyền vào DTO
                if (string.IsNullOrEmpty(maKhenThuong) || string.IsNullOrEmpty(maNhanVien))
                {
                    MessageBox.Show("Thông tin khen thưởng không đầy đủ.");
                    return;
                }

                // Tạo đối tượng khen thưởng DTO từ các dữ liệu đã chọn
                khenThuongDTO selectedReward = new khenThuongDTO(
                    maKhenThuong,
                    maNhanVien,
                    loaiKhenThuong,
                    chiTietKhenThuong,
                    giaTriKhenThuong,
                    ngayKhenThuong,
                    trangThai
                );

                // Mở form sửa khen thưởng và truyền đối tượng khen thưởng đã chọn vào
                suaKhenThuong suaKhenThuongForm = new suaKhenThuong(selectedReward);

                // Sử dụng ShowDialog() để form sửa khen thưởng chiếm quyền điều khiển
                if (suaKhenThuongForm.ShowDialog() == DialogResult.OK)
                {
                    // Sau khi đóng form sửa khen thưởng, tải lại dữ liệu trong DataGridView
                    loadDataReward();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form sửa khen thưởng: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string maKhenThuong = khenThuongBUS.GenerateNewRewardCode();
                var selectedEmployee = comboBoxNhanVien.SelectedItem as dynamic;  // Lấy đối tượng đã chọn
                string maNhanVien = selectedEmployee?.MaNhanVien; // Lấy MaNhanVien từ đối tượng đã chọn
                string loaiKhenThuong = comboBoxKhenThuong.SelectedItem?.ToString(); // ComboBox chọn loại khen thưởng

                // Kiểm tra nếu thông tin không hợp lệ
                if (string.IsNullOrEmpty(maKhenThuong) || string.IsNullOrEmpty(maNhanVien) || string.IsNullOrEmpty(loaiKhenThuong))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                int giaTriKhenThuong = 0;
                if (!int.TryParse(textBoxKhenThuong.Text, out giaTriKhenThuong))
                {
                    MessageBox.Show("Giá trị khen thưởng không hợp lệ.");
                    return;
                }

                DateTime ngayKhenThuong = dateTimePicker.Value; // DateTimePicker cho ngày khen thưởng

                // Tạo đối tượng khenThuongDTO với các giá trị đã thu thập
                khenThuongDTO reward = new khenThuongDTO(
                    maKhenThuong,
                    maNhanVien,   // Mã nhân viên
                    loaiKhenThuong, // Loại khen thưởng
                    "xuất sắc", // Chi tiết khen thưởng
                    giaTriKhenThuong, // Giá trị khen thưởng
                    ngayKhenThuong, // Ngày khen thưởng
                    1 // Trạng thái
                );

                // Gọi hàm addReward từ BUS để thêm khen thưởng
                bool isAdded = khenThuongBUS.addReward(reward);
                Console.WriteLine(isAdded);

                if (isAdded)
                {
                    MessageBox.Show("Thêm khen thưởng thành công!");
                    try
                    {
                        loadDataReward();  // Ví dụ: tải lại dữ liệu khen thưởng vào DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải lại dữ liệu khen thưởng: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Thêm khen thưởng thất bại. Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khen thưởng: " + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Danh sách các mã khen thưởng được chọn
                List<string> selectedRewards = new List<string>();

                // Kiểm tra và lấy các mã khen thưởng từ các hàng được chọn trong DataGridView
                foreach (DataGridViewRow row in dataKhenThuong.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["Check"].Value); // Lấy giá trị của checkbox

                    if (isSelected)
                    {
                        string maKhenThuong = row.Cells["Ma Khen Thuong"].Value.ToString();
                        selectedRewards.Add(maKhenThuong);
                    }
                }

                // Nếu không có khen thưởng nào được chọn
                if (selectedRewards.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một khen thưởng để xóa.");
                    return;
                }

                // Nếu chỉ có một khen thưởng được chọn, thông báo cho người dùng
                if (selectedRewards.Count == 1)
                {
                    var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khen thưởng này?",
                                                         "Xác nhận xóa",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.No)
                    {
                        return; // Dừng lại nếu người dùng chọn No
                    }
                }
                else
                {
                    var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa các khen thưởng đã chọn?",
                                                         "Xác nhận xóa",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.No)
                    {
                        return; // Dừng lại nếu người dùng chọn No
                    }
                }

                // Gọi phương thức từ BUS (hoặc trực tiếp từ DAO) để xóa các khen thưởng
                bool isDeleted = khenThuongBUS.deleteRewards(selectedRewards);

                if (isDeleted)
                {
                    MessageBox.Show("Xóa khen thưởng thành công!");
                    loadDataReward();  // Tải lại dữ liệu vào DataGridView
                }
                else
                {
                    MessageBox.Show("Xóa khen thưởng thất bại. Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa khen thưởng: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã nhân viên từ ComboBox (nếu có chọn)
                string maNhanVien = comboBoxNhanVien.SelectedValue?.ToString() ?? string.Empty;

                // Lấy loại khen thưởng từ ComboBox (nếu có chọn)
                string loaiKhenThuong = comboBoxKhenThuong.SelectedItem?.ToString() ?? string.Empty;

                // Gọi phương thức tìm kiếm từ BUS và nhận về danh sách kết quả tìm kiếm
                List<khenThuongDTO> searchResults = khenThuongBUS.searchReward(maNhanVien, loaiKhenThuong);

                // Tạo DataTable mới để lưu dữ liệu tìm kiếm
                DataTable dt = new DataTable();
                dt.Columns.Add("Check", typeof(bool)); // Cột chọn
                dt.Columns.Add("Ma Khen Thuong", typeof(string));
                dt.Columns.Add("Ma Nhan Vien", typeof(string));
                dt.Columns.Add("Loai Khen Thuong", typeof(string));
                dt.Columns.Add("Chi Tiet Khen Thuong", typeof(string));
                dt.Columns.Add("Gia Tri Khen Thuong", typeof(int));
                dt.Columns.Add("Ngay Khen Thuong", typeof(DateTime));
                dt.Columns.Add("Trang Thai", typeof(int));

                // Kiểm tra và duyệt qua các đối tượng khen thưởng trong danh sách
                if (searchResults != null && searchResults.Count > 0)
                {
                    foreach (var reward in searchResults)
                    {
                        // Thêm một dòng mới vào DataTable với dữ liệu từ đối tượng khen thưởng
                        dt.Rows.Add(false, reward.MaKhenThuong, reward.MaNhanVien, reward.LoaiKhenThuong,
                                    reward.ChiTietKhenThuong, reward.GiaTriKhenThuong, reward.NgayKhenThuong, reward.TrangThai);
                    }
                }

                // Gán DataTable làm DataSource cho DataGridView
                dataKhenThuong.DataSource = dt;

                // Thêm lại cột Check nếu không có
                if (!dataKhenThuong.Columns.Contains("Check"))
                {
                    DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                    checkColumn.Name = "Check";
                    checkColumn.HeaderText = "Chọn";
                    checkColumn.Width = 50;
                    dataKhenThuong.Columns.Insert(0, checkColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm khen thưởng: " + ex.Message);
            }
        }

    }
}
