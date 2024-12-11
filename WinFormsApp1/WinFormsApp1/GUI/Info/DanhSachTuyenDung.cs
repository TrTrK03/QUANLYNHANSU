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
    public partial class DanhSachTuyenDung : Form
    {
        static hosotuyendungbus hosotuyendungbus = new hosotuyendungbus();
        hosotuyendungdto hosotuyendungdto = new hosotuyendungdto();
        List<hosotuyendungdto> hosos = hosotuyendungbus.GetHoSoTuyenDung();
        public string MaHoSoTuyenDung { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string TrinhDo { get; set; }
        public string MoTaBangCap { get; set; }
        public string KyTuyenDung { get; set; }
        public int TrangThai { get; set; }
        public string NoiDung { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string QuanLy { get; set; }
        public List<hosotuyendungdto> hosotuyendungs { get; set; }

        public DanhSachTuyenDung()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            if (txtNoiDung == null || dtpNgayBatDau == null || dtpNgayKetThuc == null || txtQuanLy == null)
            {
                MessageBox.Show("Một hoặc nhiều control chưa được khởi tạo.");
                return;
            }
            txtNoiDung.Text = NoiDung;
            dtpNgayBatDau.Value = NgayBatDau;
            dtpNgayKetThuc.Value = NgayKetThuc;
            txtQuanLy.Text = QuanLy;
            // Tạo bảng dữ liệu với các cột phù hợp với hosotuyendungdto
            DataTable dt = new DataTable();
            dt.Columns.Add("Check", typeof(bool));
            dt.Columns.Add("Mã Hồ Sơ", typeof(string));
            dt.Columns.Add("Họ Tên", typeof(string));
            dt.Columns.Add("Ngày Sinh", typeof(DateTime));
            dt.Columns.Add("Giới Tính", typeof(string));
            dt.Columns.Add("Địa Chỉ", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("SĐT", typeof(string));
            dt.Columns.Add("Trình Độ", typeof(string));
            dt.Columns.Add("Mô Tả Bằng Cấp", typeof(string));
            dt.Columns.Add("Kỳ Tuyển Dụng", typeof(string));
            dt.Columns.Add("Trạng Thái", typeof(int));

            // Duyệt qua danh sách hồ sơ tuyển dụng và thêm dữ liệu vào DataTable
            foreach (hosotuyendungdto hosotuyendung in hosotuyendungs)
            {
                dt.Rows.Add(
                    false,
                    hosotuyendung.MaHoSoTuyenDung,
                    hosotuyendung.HoTen,
                    hosotuyendung.NgaySinh,
                    hosotuyendung.GioiTinh,
                    hosotuyendung.DiaChi,
                    hosotuyendung.Email,
                    hosotuyendung.SDT,
                    hosotuyendung.TrinhDo,
                    hosotuyendung.MoTaBangCap,
                    hosotuyendung.KyTuyenDung,
                    hosotuyendung.TrangThai
                );
            }

            // Gán DataTable cho DataGridView
            dataGridView1.DataSource = dt;

            // Ẩn một số cột không cần thiết
            dataGridView1.Columns["Trạng Thái"].Visible = false;
            dataGridView1.Columns["Kỳ Tuyển Dụng"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các MaHoSoTuyenDung từ các dòng có checkbox được chọn
            var selectedHoSos = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells["Check"].Value) == true)
                .Select(row => row.Cells["Mã Hồ Sơ"].Value.ToString())
                .ToList();

            // Nếu không có dòng nào được chọn
            if (!selectedHoSos.Any())
            {
                MessageBox.Show("Chọn ít nhất một Hồ Sơ để xóa!");
                return;
            }

            // Duyệt qua danh sách các MaHoSoTuyenDung đã chọn
            foreach (string MaHoSoTuyenDung in selectedHoSos)
            {
                var selectedHoSo = hosos.FirstOrDefault(hoso => hoso.MaHoSoTuyenDung == MaHoSoTuyenDung);
                if (selectedHoSo != null)
                {
                    try
                    {
                        hosotuyendungbus.DeleteHoSoTuyenDung(selectedHoSo);
                        MessageBox.Show($"Xóa Hồ Sơ '{MaHoSoTuyenDung}' thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có lỗi xảy ra khi xóa Hồ Sơ '{MaHoSoTuyenDung}': {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy Hồ Sơ với mã '{MaHoSoTuyenDung}'!");
                }
            }
            MessageBox.Show("Xóa thành công!");
            // Làm mới lại danh sách phongbans (cập nhật từ cơ sở dữ liệu hoặc phương thức lấy dữ liệu)
            hosotuyendungs = hosotuyendungbus.GetHoSoTuyenDung();
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TaoHoSo TaoHoSoForm = new TaoHoSo();
            TaoHoSoForm.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các MaHoSoTuyenDung từ các dòng có checkbox được chọn
            var selectedHoSos = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells["Check"].Value) == true)
                .Select(row => row.Cells["Mã Hồ Sơ"].Value.ToString())
                .ToList();

            // Nếu không có dòng nào được chọn
            if (!selectedHoSos.Any())
            {
                MessageBox.Show("Chọn ít nhất một Hồ Sơ để ghi vào nhân viên!");
                return;
            }

            // Duyệt qua danh sách các mã hồ sơ đã chọn
            foreach (var maHoSo in selectedHoSos)
            {
                var selectedHoSo = hosotuyendungs.FirstOrDefault(hoso => hoso.MaHoSoTuyenDung == maHoSo);
                if (selectedHoSo != null)
                {
                    try
                    {
                        // Tạo form TaoNhanVien và truyền dữ liệu từ hồ sơ
                        TaoNhanVien taoNhanVienForm = new TaoNhanVien
                        {
                            // Ghi các thông tin từ hồ sơ tuyển dụng sang form TaoNhanVien
                            txtHoTen = { Text = selectedHoSo.HoTen },
                            txtDiaChi = { Text = selectedHoSo.DiaChi },
                            txtSDT = { Text = selectedHoSo.SDT },
                            txtEmail = { Text = selectedHoSo.Email },
                            dtpNgaySinh = { Value = selectedHoSo.NgaySinh },
                            cbNam = { Checked = selectedHoSo.GioiTinh.ToLower() == "nam" },
                            cbNu = { Checked = selectedHoSo.GioiTinh.ToLower() == "nữ" }
                        };

                        // Hiển thị form TaoNhanVien
                        taoNhanVienForm.ShowDialog();
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có lỗi xảy ra khi mở form TaoNhanVien cho hồ sơ '{maHoSo}': {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy hồ sơ với mã '{maHoSo}'!");
                }
            }
        }
    }
}
