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
using WinFormsApp1.GUI.detail;

namespace WinFormsApp1.GUI.Info
{
    public partial class ChiTietPhucLoiNhanVien : Form
    {
        phucloigui phucloigui = new phucloigui();
        static chitietphucloinhanvienbus chitietphucloinhanvienbus = new chitietphucloinhanvienbus();
        chitietphucloidto chitietphucloidto = new chitietphucloidto();
        List<chitietphucloidto> chitietpls = chitietphucloinhanvienbus.GetChiTietPhucLoi();
        public string MaPhucLoi { get; set; }
        public string MaNhanVien { get; set; }
        public string MoTa { get; set; }
        public string GiaTriPhucLoi { get; set; }
        public List<chitietphucloidto> chitietphuclois { get; set; }
        public ChiTietPhucLoiNhanVien()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            if (txtMoTa == null || txtGiaTriPhucLoi == null)
            {
                MessageBox.Show("Một hoặc nhiều control chưa được khởi tạo.");
                return;
            }
            txtMoTa.Text = MoTa;
            txtGiaTriPhucLoi.Text = GiaTriPhucLoi.ToString();
            DataTable dt = new DataTable();
            dt.Columns.Add("Check", typeof(bool));
            dt.Columns.Add("Mã Phúc Lợi", typeof(string));
            dt.Columns.Add("Mã Nhân Viên", typeof(string));

            foreach (chitietphucloidto chitietphucloi in chitietphuclois)
            {
                dt.Rows.Add(
                    false,
                    chitietphucloi.MaPhucLoi,
                    chitietphucloi.MaNhanVien
                );
            }

            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnTao_Click_1(object sender, EventArgs e)
        {
            try
            {
                TaoChiTietPhucLoi TaoPLForm = new TaoChiTietPhucLoi();
                TaoPLForm.ShowDialog();
                chitietphuclois = chitietphucloinhanvienbus.GetChiTietPhucLoi();
                TaoPLForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            var selectedPLNVs = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells["Check"].Value) == true)
                .Select(row => row.Cells["Mã Nhân Viên"].Value.ToString())
                .ToList();

            if (!selectedPLNVs.Any())
            {
                MessageBox.Show("Chọn ít nhất một để xóa!");
                return;
            }

            foreach (string MaNhanVien in selectedPLNVs)
            {
                var selectedChiTiet = chitietpls.FirstOrDefault(hitietpls => hitietpls.MaNhanVien == MaNhanVien);
                if (selectedChiTiet != null)
                {
                    try
                    {
                        chitietphucloinhanvienbus.DeleteChiTietPhucLoi(selectedChiTiet);
                        MessageBox.Show($"Hủy tham gia '{MaNhanVien}' thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có lỗi xảy ra khi hủy '{MaNhanVien}': {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy Nhân viêm với mã '{MaNhanVien}'!");
                }
            }
            MessageBox.Show("Xóa thành công!");
            chitietphuclois = chitietphucloinhanvienbus.GetChiTietPhucLoi();
            LoadData();
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
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.PlaceholderText = "Tìm kiếm ...";
                txtSearch.ForeColor = Color.Gray; // Chuyển sang màu chữ mờ
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
                // Skip the new row (uncommitted row)
                if (row.IsNewRow)
                    continue;

                row.Visible = RowContainsValue(row, searchValue);
            }
        }
        
    }
}
