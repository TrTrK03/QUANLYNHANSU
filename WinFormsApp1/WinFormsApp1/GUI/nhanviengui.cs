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
using OfficeOpenXml;
using ExcelDataReader;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;
using WinFormsApp1.Imports;
using WinFormsApp1.Exports;
using WinFormsApp1.GUI.detail;
using static System.Windows.Forms.AxHost;
using System.IO;
using WinFormsApp1.GUI.Info;

namespace WinFormsApp1.GUI
{
    public partial class nhanviengui : UserControl
    {
        static nhanvienbus nhanvienbus = new nhanvienbus();
        nhanviendto nhanviendto = new nhanviendto();
        List<nhanviendto> nhanviens = nhanvienbus.GetNhanVien();

        private Panel panel1;
        private Panel panel2;
        private Panel panel6;
        private Button delete;
        private Button Import;
        private Button export;
        private Button Tao;
        public TextBox txtSearch;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Button edit;

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            panel6 = new Panel();
            edit = new Button();
            delete = new Button();
            Tao = new Button();
            Import = new Button();
            export = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(252, 250, 255);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 713);
            panel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 59);
            panel5.Name = "panel5";
            panel5.Size = new Size(1016, 654);
            panel5.TabIndex = 6;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(1016, 654);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.FromArgb(49, 17, 117);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1016, 59);
            panel2.TabIndex = 0;
            panel2.MouseClick += panel2_MouseClick;
            // 
            // panel6
            // 
            panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel6.BackColor = Color.White;
            panel6.Controls.Add(edit);
            panel6.Controls.Add(delete);
            panel6.Controls.Add(Tao);
            panel6.Controls.Add(Import);
            panel6.Controls.Add(export);
            panel6.Controls.Add(txtSearch);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(139, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(877, 59);
            panel6.TabIndex = 6;
            panel6.MouseClick += panel6_MouseClick;
            // 
            // edit
            // 
            edit.BackColor = Color.Lavender;
            edit.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            edit.FlatStyle = FlatStyle.Flat;
            edit.Location = new Point(377, 17);
            edit.Name = "edit";
            edit.Size = new Size(80, 30);
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
            delete.Location = new Point(463, 17);
            delete.Name = "delete";
            delete.Size = new Size(80, 30);
            delete.TabIndex = 9;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // Tao
            // 
            Tao.BackColor = Color.LimeGreen;
            Tao.FlatAppearance.BorderSize = 0;
            Tao.FlatStyle = FlatStyle.Flat;
            Tao.Image = Properties.Resources.add2;
            Tao.Location = new Point(721, 11);
            Tao.Name = "Tao";
            Tao.Size = new Size(90, 40);
            Tao.TabIndex = 2;
            Tao.UseVisualStyleBackColor = false;
            Tao.Click += Tao_Click;
            // 
            // Import
            // 
            Import.BackColor = Color.Lavender;
            Import.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            Import.FlatStyle = FlatStyle.Flat;
            Import.Location = new Point(549, 16);
            Import.Name = "Import";
            Import.Size = new Size(80, 30);
            Import.TabIndex = 9;
            Import.Text = "Import";
            Import.UseVisualStyleBackColor = false;
            Import.Click += Import_Click;
            // 
            // export
            // 
            export.BackColor = Color.Lavender;
            export.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            export.FlatStyle = FlatStyle.Flat;
            export.Location = new Point(635, 17);
            export.Name = "export";
            export.Size = new Size(80, 30);
            export.TabIndex = 8;
            export.Text = "Export";
            export.UseVisualStyleBackColor = false;
            export.Click += export_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(17, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(344, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.FromArgb(49, 17, 117);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 59);
            label1.TabIndex = 1;
            label1.Text = "Nhân Viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // nhanviengui
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(49, 17, 117);
            Margin = new Padding(0);
            Name = "nhanviengui";
            Size = new Size(1016, 713);
            Load += nhanviengui_Load;
            MouseClick += nhanviengui_MouseClick;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        private void LoadDataToGUI()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Check", typeof(bool));
            dt.Columns.Add("Ma Nhan Vien", typeof(string));
            dt.Columns.Add("Ho Ten", typeof(string));
            dt.Columns.Add("Ngay sinh", typeof(string));
            dt.Columns.Add("Gioi tinh", typeof(string));
            dt.Columns.Add("Dia chi", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("SDT", typeof(string));
            dt.Columns.Add("Nguoi quan ly", typeof(string));
            dt.Columns.Add("Phong Ban", typeof(string));
            dt.Columns.Add("Chuc vu", typeof(string));
            dt.Columns.Add("Trang Thai", typeof(int));

            foreach (nhanviendto nhanvien in nhanviens)
            {
                dt.Rows.Add(false, nhanvien.MaNhanVien, nhanvien.HoTen, nhanvien.NgaySinh.ToString(), nhanvien.GioiTinh, nhanvien.DiaChi, nhanvien.Email, nhanvien.SDT, nhanvien.NguoiQuanLy, nhanvien.PhongBan, nhanvien.ChucVu, nhanvien.TrangThai.ToString());
            }
            dataGridView1.DataSource = dt;

            // Kiểm tra trạng thái và ẩn dòng nếu trạng thái = 0
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Kiểm tra trạng thái của dòng
                if (row.Cells["Trang Thai"].Value != null && (int)row.Cells["Trang Thai"].Value == 0)
                {
                    // Ẩn toàn bộ dòng nếu trạng thái = 0
                    row.Visible = false;
                }
            }

            dataGridView1.Columns["Ngay sinh"].Visible = false;
            dataGridView1.Columns["Gioi tinh"].Visible = false;
            dataGridView1.Columns["Dia chi"].Visible = false;
            dataGridView1.Columns["Email"].Visible = false;
            dataGridView1.Columns["SDT"].Visible = false;
            dataGridView1.Columns["Nguoi quan ly"].Visible = false;
            dataGridView1.Columns["Trang Thai"].Visible = false;

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridView1.ColumnHeadersDefaultCellStyle.BackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        public nhanviengui()
        {
            InitializeComponent();
        }

        private void nhanviengui_Load(object sender, EventArgs e)
        {
            LoadDataToGUI();
            txtSearch.PlaceholderText = "Tìm kiếm ...";
            dataGridView1.Dock = DockStyle.Fill;
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

            string maNVSelected = dataGridView1.Rows[e.RowIndex].Cells["Ma Nhan Vien"].Value.ToString();
            nhanviendto selectedNhanVien = nhanviens.FirstOrDefault(NhanVien => NhanVien.MaNhanVien == maNVSelected);

            if (selectedNhanVien == null)
            {
                MessageBox.Show($"Không tìm thấy Nhân Viên có mã: {maNVSelected}");
                return;
            }

            NhanVienInfo NhanVienInfo = new NhanVienInfo
            {
                MaNhanVien = selectedNhanVien.MaNhanVien.Trim(),
                TenNhanVien = selectedNhanVien.HoTen.Trim(),
                NgaySinh = selectedNhanVien.NgaySinh,
                GioiTinh = selectedNhanVien.GioiTinh.Trim(),
                QuanLyNhanVien = selectedNhanVien.NguoiQuanLy.Trim(),
                PhongBanPhuTrach = selectedNhanVien.PhongBan.Trim(),
                DiaChi = selectedNhanVien.DiaChi.Trim(),
                SoDienThoai = selectedNhanVien.SDT.Trim(),
                Email = selectedNhanVien.Email.Trim(),
                ChucVu = selectedNhanVien.ChucVu.Trim()
            };

            try
            {
                NhanVienInfo.LoadData();
                NhanVienInfo.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị form: {ex.Message}");
            }
        }

        public void SetSearchMaPB(string maPhongBan)
        {
            txtSearch.Text = maPhongBan;
        }

        private void nhanviengui_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.ClearSelection();
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.ClearSelection();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.ClearSelection();
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.ClearSelection();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các MaNhanVien từ các dòng có checkbox được chọn
            var selectednhanviens = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells["Check"].Value) == true)
                .Select(row => row.Cells["Ma Nhan Vien"].Value.ToString())
                .ToList();

            // Nếu không có dòng nào được chọn
            if (!selectednhanviens.Any())
            {
                MessageBox.Show("Chọn ít nhất một Nhân Viên để xóa!");
                return;
            }

            // Duyệt qua danh sách các MaNhanVien đã chọn
            foreach (string MaNhanVien in selectednhanviens)
            {
                var selectedNhanVien = nhanviens.FirstOrDefault(NhanVien => NhanVien.MaNhanVien == MaNhanVien);
                if (selectedNhanVien != null)
                {
                    try
                    {
                        nhanvienbus.DeleteNhanVien(selectedNhanVien);
                        MessageBox.Show($"Xóa Nhân Viên '{MaNhanVien}' thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có lỗi xảy ra khi xóa Nhân Viên '{MaNhanVien}': {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy Nhân Viên với mã '{MaNhanVien}'!");
                }
            }

            // Làm mới lại danh sách nhanviens (cập nhật từ cơ sở dữ liệu hoặc phương thức lấy dữ liệu)
            nhanviens = nhanvienbus.GetNhanVien(); // Lấy lại dữ liệu sau khi xóa
            // Tải lại dữ liệu sau khi xóa
            LoadDataToGUI();
        }


        private void edit_Click(object sender, EventArgs e)
        {// Lấy danh sách các MaPhongBan từ các dòng có checkbox được chọn
            var selectedNhanViens = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells["Check"].Value) == true)
                .Select(row => row.Cells["Ma Nhan Vien"].Value.ToString())
                .ToList();

            // Nếu không có dòng nào được chọn
            if (!selectedNhanViens.Any())
            {
                MessageBox.Show("Chọn ít nhất một Nhân Viên để chỉnh sửa!");
                return;
            }

            // Duyệt qua danh sách các MaPhongBan đã chọn
            foreach (string MaNhanVien in selectedNhanViens)
            {
                var selectedNhanVien = nhanviens.FirstOrDefault(NhanVien => NhanVien.MaNhanVien == MaNhanVien);

                if (selectedNhanVien != null)
                {
                    // Tạo và hiển thị form chỉnh sửa
                    SuaNhanVien suaNhanVienForm = new SuaNhanVien(selectedNhanVien);
                    suaNhanVienForm.StartPosition = FormStartPosition.CenterParent;
                    suaNhanVienForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy Phòng Ban với mã '{MaNhanVien}'!");
                }
            }
            // Làm mới lại danh sách phongbans (cập nhật từ cơ sở dữ liệu hoặc phương thức lấy dữ liệu)
            nhanviens = nhanvienbus.GetNhanVien(); // Lấy lại dữ liệu sau khi xóa
            // Tải lại dữ liệu sau khi xóa
            LoadDataToGUI();
        }

        private void Tao_Click(object sender, EventArgs e)
        {
            TaoNhanVien interf = new TaoNhanVien();
            interf.ShowDialog();
            nhanviens = nhanvienbus.GetNhanVien(); // Lấy lại dữ liệu sau khi xóa
            LoadDataToGUI();
        }

        private void Import_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Chọn tệp Excel",
                    Filter = "Excel Files (*.xlsx;*.xls)|*.xlsx;*.xls|All Files (*.*)|*.*",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Import im = new Import();
                    im.importEmpByExcel(filePath);
                    MessageBox.Show("Import dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataToGUI();
                }
                else
                {
                    MessageBox.Show("Bạn đã hủy chọn file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Chọn vị trí lưu file",
                Filter = "Excel Files (*.xlsx)|*.xlsx|Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                DefaultExt = "xlsx",
                AddExtension = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                MessageBox.Show($"File sẽ được lưu tại: {filePath}", "Thông báo");

                export ex = new export();
                ex.SaveEmployeeToExcel(filePath);
            }
            else
            {
                MessageBox.Show("Bạn đã hủy lưu file.", "Thông báo");
            }
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
            txtSearch.PlaceholderText = "Tìm kiếm ...";
        }

    }
}