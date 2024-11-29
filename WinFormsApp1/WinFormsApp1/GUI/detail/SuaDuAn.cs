using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;

namespace WinFormsApp1.GUI.detail;

public partial class SuaDuAn : Form
{
    private duandto SelectedProject { get; set; }
    static duanbus projectBUS = new duanbus();

    public SuaDuAn(duandto selectedProject)
    {
        InitializeComponent();
        SelectedProject = selectedProject;

        txtMaDuAn.Text = selectedProject.MaDuAn.Trim();
        txtTenDuAn.Text = selectedProject.TenDuAn.Trim();
        txtMoTa.Text = selectedProject.MoTa?.Trim() ?? "";
        txtQuanLyDuAn.Text = selectedProject.QuanLyDuAn.Trim();
        txtPhongBan.Text = selectedProject.PhongBanPhuTrach.Trim();
        dtpNgayBatDau.Value = selectedProject.NgayBatDau;
        dtpNgayKetThuc.Value = selectedProject.NgayKetThuc;
    }

    private void SuaDuAn_Load(object sender, EventArgs e)
    {

    }


    private void btnSua_Click_1(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTenDuAn.Text))
        {
            MessageBox.Show("Tên dự án không được để trống!");
            txtTenDuAn.Focus();
        }
        else if (dtpNgayBatDau.Value > dtpNgayKetThuc.Value)
        {
            MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!");
        }
        else if (string.IsNullOrWhiteSpace(txtPhongBan.Text))
        {
            MessageBox.Show("Phòng ban phụ trách không được để trống!");
            txtPhongBan.Focus();
        }
        else if (string.IsNullOrWhiteSpace(txtQuanLyDuAn.Text))
        {
            MessageBox.Show("Hãy nhập mã quản lý dự án!");
            txtQuanLyDuAn.Focus();
        }
        else
        {
            duandto projectDTO = new duandto
            {
                MaDuAn = txtMaDuAn.Text.Trim(),
                TenDuAn = txtTenDuAn.Text.Trim(),
                MoTa = string.IsNullOrWhiteSpace(txtMoTa.Text) ? null : txtMoTa.Text.Trim(),
                NgayBatDau = dtpNgayBatDau.Value,
                NgayKetThuc = dtpNgayKetThuc.Value,
                QuanLyDuAn = txtQuanLyDuAn.Text.Trim(),
                PhongBanPhuTrach = txtPhongBan.Text.Trim()
            };

            try
            {
                projectBUS.UpdateDuAn(projectDTO);
                MessageBox.Show("Chỉnh sửa dự án thành công!");
                this.Close();
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
