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
    public partial class phucloigui : UserControl
    {
        static phucloibus phucloibus = new phucloibus();
        static chitietphucloinhanvienbus chitietphucloinhanvienbus = new chitietphucloinhanvienbus();
        phucloidto phucloidto = new phucloidto();
        chitietphucloidto chitietphucloidto = new chitietphucloidto();
        List<phucloidto> phuclois = phucloibus.GetPhucLoi();
        List<chitietphucloidto> chitietpls = chitietphucloinhanvienbus.GetChiTietPhucLoi();
        private Panel panel6;
        private Button button1;
        private Label label1;
        private Button edit;
        private Button delete;
        private TextBox txtSearch;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Panel panel1;
        private OpenFileDialog openFileDialog1;

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            openFileDialog1 = new OpenFileDialog();
            panel1 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            button1 = new Button();
            edit = new Button();
            delete = new Button();
            txtSearch = new TextBox();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 53);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.FromArgb(49, 17, 117);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 53);
            label1.TabIndex = 11;
            label1.Text = "Phúc Lợi";
            // 
            // panel6
            // 
            panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel6.BackColor = Color.White;
            panel6.Controls.Add(button1);
            panel6.Controls.Add(edit);
            panel6.Controls.Add(delete);
            panel6.Controls.Add(txtSearch);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(152, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(864, 53);
            panel6.TabIndex = 6;
            panel6.MouseClick += panel6_MouseClick;
            // 
            // button1
            // 
            button1.Location = new Point(428, 10);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 12;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // edit
            // 
            edit.BackColor = Color.Lavender;
            edit.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            edit.FlatStyle = FlatStyle.Flat;
            edit.Location = new Point(528, 12);
            edit.Name = "edit";
            edit.Size = new Size(81, 34);
            edit.TabIndex = 10;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = false;
            edit.Click += edit_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Lavender;
            delete.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            delete.FlatStyle = FlatStyle.Flat;
            delete.Location = new Point(615, 12);
            delete.Name = "delete";
            delete.Size = new Size(81, 36);
            delete.TabIndex = 9;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(143, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm ...";
            txtSearch.Size = new Size(279, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // panel5
            // 
            panel5.AutoScroll = true;
            panel5.BackColor = Color.FromArgb(192, 0, 0);
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1016, 766);
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.Info;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(1016, 766);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // phucloigui
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(panel5);
            ForeColor = Color.FromArgb(49, 17, 117);
            Margin = new Padding(0);
            Name = "phucloigui";
            Size = new Size(1016, 766);
            Load += phucloigui_Load;
            MouseClick += phucloigui_MouseClick;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        public void LoadDataToGUI()
        {
            DataTable pl = new DataTable();
            pl.Columns.Add("Check", typeof(bool));
            pl.Columns.Add("Ma Phuc Loi", typeof(string));
            pl.Columns.Add("Ten Phuc Loi", typeof(string));
            pl.Columns.Add("Mo Ta", typeof(string));
            pl.Columns.Add("Gia Tri Phuc Loi", typeof(int));
            pl.Columns.Add("Trang Thai", typeof(int));

            foreach (phucloidto phucLoi in phuclois)
            {
                pl.Rows.Add(
                    false,
                    phucLoi.MaPhucLoi,
                    phucLoi.TenPhucLoi,
                    phucLoi.MoTa,
                    phucLoi.GiaTriPhucLoi,
                    phucLoi.TrangThai
                );
            }

            dataGridView1.DataSource = pl;
            
           // dataGridView1.Columns["Trang Thai"].Visible = false;
            
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridView1.ColumnHeadersDefaultCellStyle.BackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor;
        }
        public phucloigui()
        {
            InitializeComponent();

        }

        private void phucloigui_Load(object? sender, EventArgs e)
        {
            LoadDataToGUI();
            dataGridView1.Dock = DockStyle.Fill;
            //dataGridView1.ClearSelection();
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Check")
            {
                bool isChecked = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["Check"].Value);
                dataGridView1.Rows[e.RowIndex].Cells["Check"].Value = !isChecked;
                return; 
            }

            
            string maPLSelected = dataGridView1.Rows[e.RowIndex].Cells["Ma Phuc Loi"].Value.ToString();
            phucloidto selectedphucloi = phuclois.FirstOrDefault(phucloi => phucloi.MaPhucLoi == maPLSelected);
            chitietphucloidto selectedchitietpl = chitietpls.FirstOrDefault(chitietpl => chitietpl.MaPhucLoi == maPLSelected);
            if (selectedphucloi != null || selectedchitietpl != null)
            {
               // Khởi tạo Formtest
                ChiTietPhucLoiNhanVien test = new ChiTietPhucLoiNhanVien
                {
                    
                    MoTa = selectedphucloi.MoTa,
                    GiaTriPhucLoi = selectedphucloi.GiaTriPhucLoi.ToString(),
                    

                    chitietphuclois = chitietpls
                        .Where(h => h.MaPhucLoi == selectedphucloi.MaPhucLoi)
                        .ToList() // Lọc danh sách hồ sơ theo kỳ tuyển dụng
                };

                // Hiển thị Formtest
                test.LoadData();
                test.ShowDialog();
        }

       
        dataGridView1.Size = new Size(1575, 450);
        dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(49, 17, 117);
        dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Lavender;
    }


    private void phucloigui_MouseClick(object sender, MouseEventArgs e)
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
            var selectedphuclois = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells["Check"].Value) == true)
                .Select(row => row.Cells["Ma Phuc Loi"].Value.ToString())
                .ToList();

            // Nếu không có dòng nào được chọn
            if (!selectedphuclois.Any())
            {
                MessageBox.Show("Chọn ít nhất một Phúc Lợi để xóa!");
                return;
            }

            // Duyệt qua danh sách các MaPhongBan đã chọn
            foreach (string maPhucLoi in selectedphuclois)
            {
                var selectedphucloi = phuclois.FirstOrDefault(phucloi => phucloi.MaPhucLoi == maPhucLoi);
                if (selectedphucloi != null)
                {
                    try
                    {
                        phucloibus.DeletePhucLoi(selectedphucloi);
                        MessageBox.Show($"Xóa Phuc Loi '{maPhucLoi}' thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có lỗi xảy ra khi xóa Phuc Loi '{maPhucLoi}': {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy Phuc Loi với mã '{maPhucLoi}'!");
                }
            }

            // Làm mới lại danh sách tuyendungs (cập nhật từ cơ sở dữ liệu hoặc phương thức lấy dữ liệu)
            phuclois = phucloibus.GetPhucLoi(); // Lấy lại dữ liệu sau khi xóa
            // Tải lại dữ liệu sau khi xóa
            LoadDataToGUI();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các MaPhongBan từ các dòng có checkbox được chọn
            var selectedphuclois = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells["Check"].Value) == true)
                .Select(row => row.Cells["Ma Phuc Loi"].Value.ToString())
                .ToList();

            // Nếu không có dòng nào được chọn
            if (!selectedphuclois.Any())
            {
                MessageBox.Show("Chọn ít nhất một Phòng Ban để chỉnh sửa!");
                return;
            }

            // Duyệt qua danh sách các MaPhongBan đã chọn
            foreach (string maPhucLoi in selectedphuclois)
            {
                var selectedphucloi = phuclois.FirstOrDefault(phucloi => phucloi.MaPhucLoi == maPhucLoi);

                if (selectedphucloi != null)
                {
                    // Tạo và hiển thị form chỉnh sửa
                    SuaPhucLoi SuaPhucLoiForm = new SuaPhucLoi(selectedphucloi);
                    SuaPhucLoiForm.StartPosition = FormStartPosition.CenterParent;
                    SuaPhucLoiForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy Phòng Ban với mã '{maPhucLoi}'!");
                }
            }
            // Làm mới lại danh sách tuyendungs (cập nhật từ cơ sở dữ liệu hoặc phương thức lấy dữ liệu)
            phuclois = phucloibus.GetPhucLoi(); // Lấy lại dữ liệu sau khi xóa
                                                      // Tải lại dữ liệu sau khi xóa
            LoadDataToGUI();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchValue))
            {
                txtSearch.PlaceholderText = "Tìm kiếm ...";
            }

            // Lọc dữ liệu trong DataGridView dựa trên giá trị tìm kiếm
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

        // Sự kiện khi rời khỏi ô tìm kiếm
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
            TaoPhucLoi TaoPhucLoiForm = new TaoPhucLoi();
            TaoPhucLoiForm.ShowDialog();
            // Làm mới lại danh sách tuyendungs (cập nhật từ cơ sở dữ liệu hoặc phương thức lấy dữ liệu)
            phuclois = phucloibus.GetPhucLoi(); // Lấy lại dữ liệu sau khi xóa
            // Tải lại dữ liệu sau khi xóa
            LoadDataToGUI();
        }

    }

}