using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;

namespace WinFormsApp1.GUI.detail;

public partial class SuaTuyenDung : Form
{
    private tuyendungdto selectedtuyendung { get; set; }
    static tuyendungbus tuyendungbus = new tuyendungbus();

    public SuaTuyenDung(tuyendungdto selectedtuyendung)
    {
        InitializeComponent();
        selectedtuyendung = selectedtuyendung;

        txtMaKyTuyenDung.Text = selectedtuyendung.MaKyTuyenDung.Trim();
        txtNoiDung.Text = selectedtuyendung.NoiDung?.Trim() ?? "";
        txtQuanLy.Text = selectedtuyendung.MaQuanLy.Trim();
        dtpNgayBatDau.Value = selectedtuyendung.NgayBatDau;
        dtpNgayKetThuc.Value = selectedtuyendung.NgayKetThuc;
    }

    private void SuaTuyenDung_Load(object sender, EventArgs e)
    {

    }


    private void btnSua_Click_1(object sender, EventArgs e)
    {
        if (dtpNgayBatDau.Value > dtpNgayKetThuc.Value)
        {
            MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!");
        }
        else if (string.IsNullOrWhiteSpace(txtQuanLy.Text))
        {
            MessageBox.Show("Hãy nhập mã quản lý dự án!");
            txtQuanLy.Focus();
        }
        else
        {
            tuyendungdto tuyendungdto = new tuyendungdto
            {
                MaKyTuyenDung = txtMaKyTuyenDung.Text.Trim(),
                NoiDung = string.IsNullOrWhiteSpace(txtNoiDung.Text) ? null : txtNoiDung.Text.Trim(),
                NgayBatDau = dtpNgayBatDau.Value,
                NgayKetThuc = dtpNgayKetThuc.Value,
                MaQuanLy = txtQuanLy.Text.Trim(),
            };

            try
            {
                tuyendungbus.UpdateTuyenDung(tuyendungdto);
                MessageBox.Show("Chỉnh sửa dự án thành công!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình chỉnh sửa: " + ex.Message);
            }
        }
    }

    private void btnHuy_Click_1(object sender, EventArgs e)
    {
        if (MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Xác nhận hủy", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
