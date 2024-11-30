using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Drawing2D;
using System;
using System.Drawing;
using System.Windows.Forms;
using OfficeOpenXml;
using ExcelDataReader;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;
using WinFormsApp1.Imports;
using WinFormsApp1.Exports;
using WinFormsApp1.GUI.detail;
using WinFormsApp1.GUI.Info;
using static System.Windows.Forms.AxHost;
using System;
using System.Collections.Generic;
using System.IO;
using OfficeOpenXml;

//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.GUI
{
    public partial class tuyendunggui : UserControl
    {
        static tuyendungbus tuyendungbus = new tuyendungbus();
        static hosotuyendungbus hosotuyendungbus = new hosotuyendungbus();
        tuyendungdto tuyendungdto = new tuyendungdto();
        hosotuyendungdto hosotuyendungdto = new hosotuyendungdto();
        List<tuyendungdto> tuyendungs = tuyendungbus.GetTuyenDung();
        List<hosotuyendungdto> hosos = hosotuyendungbus.GetHoSoTuyenDung();
        private Panel panel2;
        private Panel panel6;
        private Button edit;
        private Button delete;
        private TextBox txtSearch;
        private Panel panel3;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private OpenFileDialog openFileDialog1;

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            openFileDialog1 = new OpenFileDialog();
            panel2 = new Panel();
            panel6 = new Panel();
            button1 = new Button();
            label1 = new Label();
            edit = new Button();
            delete = new Button();
            txtSearch = new TextBox();
            panel3 = new Panel();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel3);
            panel2.ForeColor = Color.FromArgb(49, 17, 117);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 51);
            panel2.TabIndex = 0;
            panel2.MouseClick += panel2_MouseClick;
            // 
            // panel6
            // 
            panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel6.BackColor = Color.White;
            panel6.Controls.Add(button1);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(edit);
            panel6.Controls.Add(delete);
            panel6.Controls.Add(txtSearch);
            panel6.Location = new Point(3, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(997, 49);
            panel6.TabIndex = 6;
            panel6.MouseClick += panel6_MouseClick;
            // 
            // button1
            // 
            button1.Location = new Point(605, 8);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 12;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(49, 17, 117);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 49);
            label1.TabIndex = 11;
            label1.Text = "Phòng Ban";
            // 
            // edit
            // 
            edit.Anchor = AnchorStyles.None;
            edit.BackColor = Color.Lavender;
            edit.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            edit.FlatStyle = FlatStyle.Flat;
            edit.Location = new Point(705, 9);
            edit.Name = "edit";
            edit.Size = new Size(81, 34);
            edit.TabIndex = 10;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = false;
            edit.Click += edit_Click;
            // 
            // delete
            // 
            delete.Anchor = AnchorStyles.None;
            delete.BackColor = Color.Lavender;
            delete.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            delete.FlatStyle = FlatStyle.Flat;
            delete.Location = new Point(792, 8);
            delete.Name = "delete";
            delete.Size = new Size(81, 36);
            delete.TabIndex = 9;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.None;
            txtSearch.Location = new Point(241, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(344, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Leave += txtSearch_Leave;
            txtSearch.PlaceholderText = "Tìm kiếm ...";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(252, 250, 255);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(1000, 2);
            panel3.TabIndex = 0;
            panel3.Visible = false;
            // 
            // panel5
            // 
            panel5.AutoScroll = true;
            panel5.BackColor = Color.FromArgb(192, 0, 0);
            panel5.Controls.Add(dataGridView1);
            panel5.Location = new Point(3, 52);
            panel5.Name = "panel5";
            panel5.Size = new Size(1000, 551);
            panel5.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 70;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.Info;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(1000, 551);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(252, 250, 255);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 606);
            panel1.TabIndex = 2;
            // 
            // tuyendunggui
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(49, 17, 117);
            Margin = new Padding(0);
            Name = "tuyendunggui";
            Size = new Size(1009, 609);
            Load += tuyendunggui_Load;
            MouseClick += tuyendunggui_MouseClick;
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            ((ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        public void LoadDataToGUI()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Check", typeof(bool));
            dt.Columns.Add("Ma Ky tuyen Dung", typeof(string));
            dt.Columns.Add("Noi Dung", typeof(string));
            dt.Columns.Add("Ngay Bat Dau", typeof(DateTime));
            dt.Columns.Add("Ngay Ket Thuc", typeof(DateTime));
            dt.Columns.Add("Ma Quan Ly", typeof(string));
            dt.Columns.Add("Trang Thai", typeof(int));

            foreach (tuyendungdto kyTuyenDung in tuyendungs)
            {
                dt.Rows.Add(
                    false,
                    kyTuyenDung.MaKyTuyenDung,
                    kyTuyenDung.NoiDung,
                    kyTuyenDung.NgayBatDau,
                    kyTuyenDung.NgayKetThuc,
                    kyTuyenDung.MaQuanLy,
                    kyTuyenDung.TrangThai
                );
            }

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Ngay Bat Dau"].Visible = false;
            dataGridView1.Columns["Trang Thai"].Visible = false;
            dataGridView1.Columns["Ngay Ket Thuc"].Visible = false;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridView1.ColumnHeadersDefaultCellStyle.BackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor;
        }
        public tuyendunggui()
        {
            InitializeComponent();

        }

        private void tuyendunggui_Load(object? sender, EventArgs e)
        {
            LoadDataToGUI();
            dataGridView1.Dock = DockStyle.Fill;
            //dataGridView1.ClearSelection();
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Kiểm tra nếu nhấn vào tiêu đề hoặc bên ngoài vùng hợp lệ
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Kiểm tra nếu nhấn vào cột "Check"
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Check")
            {
                // Đảo trạng thái checkbox
                bool isChecked = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["Check"].Value);
                dataGridView1.Rows[e.RowIndex].Cells["Check"].Value = !isChecked;
                return; // Không tiếp tục thực hiện logic khác
            }

            // Lấy dữ liệu từ dòng được chọn
            string maTDSelected = dataGridView1.Rows[e.RowIndex].Cells["Ma Ky Tuyen Dung"].Value.ToString();
            tuyendungdto selectedtuyendung = tuyendungs.FirstOrDefault(tuyendung => tuyendung.MaKyTuyenDung == maTDSelected);
            hosotuyendungdto selectedhoso = hosos.FirstOrDefault(hoso => hoso.KyTuyenDung == maTDSelected);
            if (selectedtuyendung != null || selectedhoso != null)
            {
                // Khởi tạo Formtest
                DanhSachTuyenDung test = new DanhSachTuyenDung
                {
                    NoiDung = selectedtuyendung.NoiDung,
                    NgayBatDau = selectedtuyendung.NgayBatDau,
                    NgayKetThuc = selectedtuyendung.NgayKetThuc,
                    QuanLy = selectedtuyendung.MaQuanLy,

                    hosotuyendungs = hosos
                        .Where(h => h.KyTuyenDung == selectedtuyendung.MaKyTuyenDung)
                        .ToList() // Lọc danh sách hồ sơ theo kỳ tuyển dụng
                };

                // Hiển thị Formtest
                test.LoadData();
                test.ShowDialog();
            }

            // Hiển thị bảng chi tiết
            dataGridView1.Size = new Size(1575, 450);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(49, 17, 117);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Lavender;
        }


        private void tuyendunggui_MouseClick(object sender, MouseEventArgs e)
        {
            //LoadDataToGUI();
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.ClearSelection();

        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            //LoadDataToGUI();
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.ClearSelection();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            //LoadDataToGUI();
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.ClearSelection();
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            //LoadDataToGUI();
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.ClearSelection();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các MaPhongBan từ các dòng có checkbox được chọn
            var selectedtuyendungs = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells["Check"].Value) == true)
                .Select(row => row.Cells["Ma Ky Tuyen Dung"].Value.ToString())
                .ToList();

            // Nếu không có dòng nào được chọn
            if (!selectedtuyendungs.Any())
            {
                MessageBox.Show("Chọn ít nhất một Phòng Ban để xóa!");
                return;
            }

            // Duyệt qua danh sách các MaPhongBan đã chọn
            foreach (string maTuyenDung in selectedtuyendungs)
            {
                var selectedtuyendung = tuyendungs.FirstOrDefault(tuyendung => tuyendung.MaKyTuyenDung == maTuyenDung);
                if (selectedtuyendung != null)
                {
                    try
                    {
                        tuyendungbus.DeleteThongBao(selectedtuyendung);
                        MessageBox.Show($"Xóa Phòng Ban '{maTuyenDung}' thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có lỗi xảy ra khi xóa Phòng Ban '{maTuyenDung}': {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy Phòng Ban với mã '{maTuyenDung}'!");
                }
            }

            // Làm mới lại danh sách tuyendungs (cập nhật từ cơ sở dữ liệu hoặc phương thức lấy dữ liệu)
            tuyendungs = tuyendungbus.GetTuyenDung(); // Lấy lại dữ liệu sau khi xóa
            // Tải lại dữ liệu sau khi xóa
            LoadDataToGUI();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các MaPhongBan từ các dòng có checkbox được chọn
            var selectedtuyendungs = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells["Check"].Value) == true)
                .Select(row => row.Cells["Ma Ky Tuyen Dung"].Value.ToString())
                .ToList();

            // Nếu không có dòng nào được chọn
            if (!selectedtuyendungs.Any())
            {
                MessageBox.Show("Chọn ít nhất một Phòng Ban để chỉnh sửa!");
                return;
            }

            // Duyệt qua danh sách các MaPhongBan đã chọn
            foreach (string maTuyenDung in selectedtuyendungs)
            {
                var selectedtuyendung = tuyendungs.FirstOrDefault(tuyendung => tuyendung.MaKyTuyenDung == maTuyenDung);

                if (selectedtuyendung != null)
                {
                    // Tạo và hiển thị form chỉnh sửa
                    SuaTuyenDung SuaTuyenDungForm = new SuaTuyenDung(selectedtuyendung);
                    SuaTuyenDungForm.StartPosition = FormStartPosition.CenterParent;
                    SuaTuyenDungForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy Phòng Ban với mã '{maTuyenDung}'!");
                }
            }
            // Làm mới lại danh sách tuyendungs (cập nhật từ cơ sở dữ liệu hoặc phương thức lấy dữ liệu)
            tuyendungs = tuyendungbus.GetTuyenDung(); // Lấy lại dữ liệu sau khi xóa
                                                      // Tải lại dữ liệu sau khi xóa
            LoadDataToGUI();
        }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        string searchValue = txtSearch.Text.ToLower();

        if (string.IsNullOrWhiteSpace(searchValue))
        {
            txtSearch.PlaceholderText = "Tìm kiếm ...";
        }

        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
            row.Visible = string.IsNullOrEmpty(searchValue) || RowContainsValue(row, searchValue);
        }
    }

    // Hàm kiểm tra hàng có chứa chuỗi tìm kiếm không
    private bool RowContainsValue(DataGridViewRow row, string searchValue)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchValue))
                {
                    return true;
                }
            }
            return false;
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.PlaceholderText = "Tìm kiếm ...";
                txtSearch.ForeColor = Color.Gray; // Chuyển sang màu chữ mờ
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaoTuyenDung TaoTuyenDungForm = new TaoTuyenDung();
            TaoTuyenDungForm.ShowDialog();
            // Làm mới lại danh sách tuyendungs (cập nhật từ cơ sở dữ liệu hoặc phương thức lấy dữ liệu)
            tuyendungs = tuyendungbus.GetTuyenDung(); // Lấy lại dữ liệu sau khi xóa
            // Tải lại dữ liệu sau khi xóa
            LoadDataToGUI();
        }

    }

}