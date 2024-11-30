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
using WinFormsApp1.GUI.wave;

namespace WinFormsApp1.GUI.NewFolder
{
    public partial class bangLuongGUI : UserControl
    {
        private bangLuongBUS bangLuongBUS;
        private bangLuongDTO selectedRowData; // Khai báo biến toàn cục để lưu thông tin dòng đã chọn

        public bangLuongGUI()
        {
            InitializeComponent();
            bangLuongBUS = new bangLuongBUS();
            loadDataWave();
        }

        private void loadDataWave()
        {
            DataTable dt = new DataTable();

            // Cột Check sẽ là cột checkbox để người dùng chọn các khen thưởng muốn xóa
            dt.Columns.Add("Check", typeof(bool)); // Cột chọn để đánh dấu các khen thưởng (nếu cần)
            dt.Columns.Add("Ma Nhan Vien", typeof(string)); // Đảm bảo kiểu string
            dt.Columns.Add("Ten Nhan Vien", typeof(string)); // Đảm bảo kiểu string
            dt.Columns.Add("Thang Nam", typeof(DateTime));
            dt.Columns.Add("Phu Cap", typeof(int));
            dt.Columns.Add("Khau Tru", typeof(int));
            dt.Columns.Add("Luong Thuc Nhan", typeof(int)); // Dạng số để hiển thị

            try
            {
                // Lấy dữ liệu từ lớp BUS (Dữ liệu về lương, không phải khen thưởng)
                var allSalaries = bangLuongBUS.GetLuong(); // Lấy dữ liệu từ lớp BUS

                // Duyệt qua danh sách lương (sửa lại kiểu dữ liệu đúng)
                foreach (bangLuongDTO salary in allSalaries)
                {
                    // Thêm các dòng dữ liệu vào DataTable
                    dt.Rows.Add(false, salary.MaNhanVien, salary.HoTen, salary.ThangNam, salary.PhuCap,
                        salary.KhauTru, salary.LuongThucNhan);
                }

                // Gán DataTable làm DataSource cho DataGridView
                dataWage.DataSource = dt;

                // Thêm cột Check vào DataGridView để có thể đánh dấu các khen thưởng
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "Check";
                checkColumn.HeaderText = "Chọn";
                checkColumn.Width = 50; // Bạn có thể điều chỉnh độ rộng của cột nếu cần
                checkColumn.FillWeight = 5; // Điều chỉnh tỷ lệ cột

                // Thêm cột checkbox vào DataGridView nếu chưa có
                if (!dataWage.Columns.Contains("Check"))
                {
                    dataWage.Columns.Insert(0, checkColumn);  // Chèn cột Check vào đầu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn không
                DataGridViewRow selectedRow = null;

                foreach (DataGridViewRow row in dataWage.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["Check"].Value); // Kiểm tra checkbox
                    if (isSelected)
                    {
                        selectedRow = row;
                        break;
                    }
                }

                // Nếu không có dòng nào được chọn
                if (selectedRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một bảng lương để xóa.");
                    return;
                }

                // Lấy mã nhân viên từ dòng đã chọn
                string maNhanVien = selectedRow.Cells["Ma Nhan Vien"].Value.ToString();
                DateTime thangNam = (DateTime)selectedRow.Cells["Thang Nam"].Value;

                // Xác nhận việc xóa
                DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa bảng lương của nhân viên {maNhanVien} vào tháng {thangNam:MM/yyyy}?",
                                                           "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Gọi phương thức xóa trong lớp BUS
                    bool result = bangLuongBUS.DeleteLuong(maNhanVien, thangNam);

                    if (result)
                    {
                        MessageBox.Show("Xóa bảng lương thành công!");
                        loadDataWave(); // Tải lại dữ liệu
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa bảng lương.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa bảng lương: " + ex.Message);
            }
        }


        private void addWave_Click(object sender, EventArgs e)
        {
            try
            {
                themBangLuongGUI them = new themBangLuongGUI();

                // Mở form themBangLuongGUI và chờ kết quả trả về
                if (them.ShowDialog() == DialogResult.OK)
                {
                    // Nếu form themBangLuongGUI đóng với DialogResult.OK, gọi lại loadDataWave để làm mới dữ liệu
                    loadDataWave();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form thêm bảng lương: " + ex.Message);
            }
        }

        // Sự kiện khi thay đổi lựa chọn dòng trong DataGridView
        private void dataWage_SelectionChanged(object sender, EventArgs e)
        {
            if (dataWage.SelectedRows.Count > 0)
            {
                // Lấy thông tin dòng đã chọn
                var selectedRow = dataWage.SelectedRows[0];

                string maNhanVien = selectedRow.Cells["Ma Nhan Vien"].Value.ToString();
                string tenNhanVien = selectedRow.Cells["Ten Nhan Vien"].Value.ToString();
                DateTime thangNam = (DateTime)selectedRow.Cells["Thang Nam"].Value;
                int phuCap = Convert.ToInt32(selectedRow.Cells["Phu Cap"].Value);
                int khauTru = Convert.ToInt32(selectedRow.Cells["Khau Tru"].Value);
                int luongThucNhan = Convert.ToInt32(selectedRow.Cells["Luong Thuc Nhan"].Value);

                // Lưu thông tin vào biến tạm
                selectedRowData = new bangLuongDTO
                {
                    MaNhanVien = maNhanVien,
                    HoTen = tenNhanVien,
                    ThangNam = thangNam,
                    PhuCap = phuCap,
                    KhauTru = khauTru,
                    LuongThucNhan = luongThucNhan
                };
            }
            else
            {
                selectedRowData = null; // Nếu không có dòng nào được chọn
            }
        }

        private void editWave_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn trong DataGridView không
                DataGridViewRow selectedRow = null;

                // Duyệt qua các dòng trong DataGridView để tìm dòng được chọn
                foreach (DataGridViewRow row in dataWage.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["Check"].Value); // Kiểm tra checkbox
                    if (isSelected)
                    {
                        selectedRow = row;
                        break;  // Nếu tìm thấy dòng được chọn thì thoát vòng lặp
                    }
                }

                // Nếu không có dòng nào được chọn
                if (selectedRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để sửa.");
                    return;
                }

                // Lấy thông tin từ dòng được chọn
                string maNhanVien = selectedRow.Cells["Ma Nhan Vien"].Value.ToString();
                string tenNhanVien = selectedRow.Cells["Ten Nhan Vien"].Value.ToString();
                DateTime thangNam = (DateTime)selectedRow.Cells["Thang Nam"].Value;
                int phuCap = Convert.ToInt32(selectedRow.Cells["Phu Cap"].Value);
                int khauTru = Convert.ToInt32(selectedRow.Cells["Khau Tru"].Value);
                int luongThucNhan = Convert.ToInt32(selectedRow.Cells["Luong Thuc Nhan"].Value);

                // Kiểm tra thông tin có hợp lệ hay không
                if (string.IsNullOrEmpty(maNhanVien) || string.IsNullOrEmpty(tenNhanVien))
                {
                    MessageBox.Show("Thông tin nhân viên không đầy đủ.");
                    return;
                }

                // Tạo đối tượng bangLuongDTO từ các thông tin đã lấy
                bangLuongDTO selectedSalary = new bangLuongDTO
                {
                    MaNhanVien = maNhanVien,
                    HoTen = tenNhanVien,
                    ThangNam = thangNam,
                    PhuCap = phuCap,
                    KhauTru = khauTru,
                    LuongThucNhan = luongThucNhan
                };

                // Mở form sửa bảng lương và truyền đối tượng DTO vào
                suaBangLuongGUI suaBangLuongForm = new suaBangLuongGUI(selectedSalary);

                // Hiển thị form sửa bảng lương
                if (suaBangLuongForm.ShowDialog() == DialogResult.OK)
                {
                    // Sau khi đóng form sửa bảng lương, tải lại dữ liệu trong DataGridView
                    loadDataWave();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form sửa bảng lương: " + ex.Message);
            }
        }


        private void dataWage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý sự kiện khi người dùng click vào một ô trong DataGridView
        }

        private void searchWaveByEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                string searchQuery = searchWage.Text.Trim(); // Giả sử bạn có một TextBox cho phép người dùng nhập từ khóa tìm kiếm

                // Gọi phương thức tìm kiếm từ lớp BUS và lấy kết quả
                var searchResults = bangLuongBUS.SearchLuong(searchQuery);

                // Tạo DataTable mới để lưu dữ liệu tìm kiếm
                DataTable dt = new DataTable();
                dt.Columns.Add("Check", typeof(bool));
                dt.Columns.Add("Ma Nhan Vien", typeof(string));
                dt.Columns.Add("Ten Nhan Vien", typeof(string));
                dt.Columns.Add("Thang Nam", typeof(DateTime));
                dt.Columns.Add("Phu Cap", typeof(int));
                dt.Columns.Add("Khau Tru", typeof(int));
                dt.Columns.Add("Luong Thuc Nhan", typeof(int));

                // Thêm các dòng dữ liệu vào DataTable
                foreach (var salary in searchResults)
                {
                    dt.Rows.Add(false, salary.MaNhanVien, salary.HoTen, salary.ThangNam, salary.PhuCap,
                                salary.KhauTru, salary.LuongThucNhan);
                }

                // Gán DataTable làm DataSource cho DataGridView
                dataWage.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadDataWave();
            searchWage.Text = "";
        }
    }
}
