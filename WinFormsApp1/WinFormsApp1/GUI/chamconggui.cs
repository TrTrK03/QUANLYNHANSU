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
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using System.Collections;
using WinFormsApp1.GUI.detail;

namespace WinFormsApp1.GUI
{
    public partial class chamconggui : UserControl
    {
        int thang;
        int nam = 2025;
        bool tq = true;

        static chamcongbus chamcongbus = new chamcongbus();
        chamcongdto chamcongdto = new chamcongdto();

        //List<chamcongdto> chamcongss = chamcongbus.GetDSTheoNgay(new DateTime(2024, 11, 1), false);
        List<chamcongdto> chamcongss = chamcongbus.GetChamCong();

        //List<chamcongdto> chamcongs = chamcongbus.GetDSDungGioCuaMaNV(new string("NV0003"), false);
        public chamconggui()
        {
            InitializeComponent();
            int month = DateTime.Now.Month;
            domainUpDown1.SelectedIndex = month - 2;
            domainUpDown2.SelectedIndex = 1;
            txtSearch.PlaceholderText = "Tìm kiếm ...";
            thang = domainUpDown1.SelectedIndex + 1;
            nam = domainUpDown2.SelectedIndex + 2023;

        }


        private void LoadDataToGUI(int thang, int nam)
        {
            List<chamcongdto> chamcongs = chamcongbus.GetChamCong(thang, nam);
            DataTable dt = new DataTable();

            dt.Columns.Add("Check", typeof(bool));
            dt.Columns.Add("Mã Chấm công", typeof(string));
            dt.Columns.Add("Buoi", typeof(int));
            dt.Columns.Add("Ngày", typeof(string));
            dt.Columns.Add("Giờ vào ca", typeof(string));
            dt.Columns.Add("Mã Nhân Viên", typeof(string));

            foreach (chamcongdto chamcong in chamcongs)
            {
                dt.Rows.Add(false, chamcong.MaBangChamCong, chamcong.Buoi, chamcong.Ngay.ToString("dd/MM/yyyy"), chamcong.GioVaoCa, chamcong.MaNhanVien);
            }
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridView1.ColumnHeadersDefaultCellStyle.BackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void chamconggui_Load(object sender, EventArgs e)
        {
            LoadDataToGUI2(thang, nam);
            //LoadDataToGUI();
            dataGridView1.Dock = DockStyle.Fill;
        }

        private void LoadDataToGUI2(int thang, int nam)
        {




            DataTable dt = new DataTable();

            dt.Columns.Add($"Tháng {thang}", typeof(String));
            dt.Columns.Add("Thứ 2", typeof(Image));
            dt.Columns.Add("Thứ 3", typeof(Image));
            dt.Columns.Add("Thứ 4", typeof(Image));
            dt.Columns.Add("Thứ 5", typeof(Image));
            dt.Columns.Add("Thứ 6", typeof(Image));
            //dt.Columns.Add("Thứ 7", typeof(Image));
            //dt.Columns.Add("Chủ nhật", typeof(Image));

            for (int i = 1; i < 7; i++)
            {

                List<Image> bieudo = chamcongbus.BieuDoChamCongTheoTuan(i, thang, nam);

                // Thêm một hàng vào DataTable
                DataRow row = dt.NewRow();
                row[0] = $"Tuần {i}";


                int index = 0;
                for (int j = 1; j < 6; j++)
                {

                    if (index < bieudo.Count)
                    {
                        row[j] = bieudo[index]; // Gán hình ảnh vào cột tương ứng
                        index++;
                    }
                    else
                    {
                        Image image = new Bitmap(1, 1);
                        row[j] = image;
                    }
                }

                dt.Rows.Add(row); // Thêm hàng vào DataTable
            }

            dataGridView1.DataSource = dt;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            DomainUpDown domainUpDown1 = sender as DomainUpDown;
            thang = domainUpDown1.SelectedIndex + 1;
            if (tq)
            {
                LoadDataToGUI2(thang, nam);
            }
            else
            {
                LoadDataToGUI(thang, nam);
            }

        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {
            DomainUpDown domainUpDown2 = sender as DomainUpDown;
            nam = domainUpDown2.SelectedIndex + 2023;
            if (tq)
            {
                LoadDataToGUI2(thang, nam);
            }
            else
            {
                LoadDataToGUI(thang, nam);
            }
        }

        private void Tao_Click(object sender, EventArgs e)
        {

            TaoChamCong interf = new TaoChamCong();
            interf.ShowDialog();
        }


        private void tongquan_Click(object sender, EventArgs e)
        {
            tq = true;
            LoadDataToGUI2(thang, nam);
            dataGridView1.Dock = DockStyle.Fill;
        }

        private void chitiet_Click(object sender, EventArgs e)
        {
            tq = false;
            LoadDataToGUI(thang, nam);
            dataGridView1.Dock = DockStyle.Fill;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void delete_Click(object sender, EventArgs e)
        {
            if (tq)
            {
                MessageBox.Show("Hãy chuyển sang bảng chi tiết để xóa!");

                return;
            }

            var selectedchamcongs = dataGridView1.Rows
            .Cast<DataGridViewRow>()
            .Where(row => Convert.ToBoolean(row.Cells["Check"].Value) == true)
            .Select(row => row.Cells["Mã Chấm Công"].Value.ToString())
            .ToList();

            // Nếu không có dòng nào được chọn
            if (!selectedchamcongs.Any())
            {
                MessageBox.Show("Chọn ít nhất một chấm công để xóa!");
                return;
            }


            foreach (string MaBangChamCong in selectedchamcongs)
            {
                var selectedChamCong = chamcongss.FirstOrDefault(ChamCong => ChamCong.MaBangChamCong == MaBangChamCong);
                if (selectedChamCong != null)
                {
                    try
                    {
                        //chamcongbus.DeleteChamCong(selectedChamCong);
                        MessageBox.Show($"Xóa thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có lỗi xảy ra khi xóa chấm công: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy chấm công với mã '{MaBangChamCong}'!");
                }
            }
            chamcongss = chamcongbus.GetChamCong();
            LoadDataToGUI(thang, nam);

        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (tq)
            {
                MessageBox.Show("Hãy chuyển sang bảng chi tiết để xóa!");

                return;
            }
            var selectedchamcongs = dataGridView1.Rows
            .Cast<DataGridViewRow>()
            .Where(row => Convert.ToBoolean(row.Cells["Check"].Value) == true)
            .Select(row => row.Cells["Mã Chấm Công"].Value.ToString())
            .ToList();

            // Nếu không có dòng nào được chọn
            if (!selectedchamcongs.Any())
            {
                MessageBox.Show("Chọn một chấm công để xóa!");
                return;
            }

            if (selectedchamcongs.Count > 1)
            {
                MessageBox.Show("Chỉ chọn một chấm công để xóa!");
                return;
            }
            else
            {

                foreach (string MaBangChamCong in selectedchamcongs)
                {
                    var selectedChamCong = chamcongss.FirstOrDefault(ChamCong => ChamCong.MaBangChamCong == MaBangChamCong);
                    if (selectedChamCong != null)
                    {
                        try
                        {

                            suachamcong suaForm = new suachamcong(selectedChamCong);
                            suaForm.StartPosition = FormStartPosition.CenterParent;
                            suaForm.ShowDialog();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Có lỗi xảy ra khi xóa chấm công: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Không tìm thấy chấm công với mã '{MaBangChamCong}'!");
                    }
                }
            }
            chamcongss = chamcongbus.GetChamCong();
            LoadDataToGUI(thang, nam);

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void export_Click(object sender, EventArgs e)
        {
            Thongke tForm = new Thongke();
            tForm.StartPosition = FormStartPosition.CenterParent;
            tForm.ShowDialog();
        }
    }
}

    