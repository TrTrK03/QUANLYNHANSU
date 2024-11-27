using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.GUI.detail
{
    public partial class TaoDuAn : Form
    {
        duandto projectDTO = new duandto();
        duanbus projectBUS = new duanbus();
        private DTO.duandto SelectedProject { get; set; }

        string lastMaDuAn = "";
        int i = 0;

        public TaoDuAn()
        {
            InitializeComponent();
            List<duandto> projects = projectBUS.GetDuAn();
            lastMaDuAn = projects[^1].MaDuAn;
            i = Convert.ToInt32(lastMaDuAn.Substring(lastMaDuAn.Length - 5)) + 1;
            txtMaDuAn.Text = GenerateMaDuAn(i);
        }

        public TaoDuAn(DTO.duandto selectedProject)
        {
            InitializeComponent();
            SelectedProject = selectedProject;

            txtMaDuAn.Text = selectedProject.MaDuAn;
            txtTenDuAn.Text = selectedProject.TenDuAn;
            txtMoTa.Text = selectedProject.MoTa;
            dtpNgayBatDau.Value = selectedProject.NgayBatDau;
            dtpNgayKetThuc.Value = selectedProject.NgayKetThuc;
            txtQuanLyDuAn.Text = selectedProject.QuanLyDuAn;
            txtPhongBanPhuTrach.Text = selectedProject.PhongBanPhuTrach;
        }

        private string GenerateMaDuAn(int index)
        {
            return index switch
            {
                < 10 => "DA0000" + index,
                < 100 => "DA000" + index,
                < 1000 => "DA00" + index,
                < 10000 => "DA0" + index,
                _ => "DA" + index
            };
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Xác nhận hủy", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDuAn.Text))
            {
                MessageBox.Show("Vui lòng nhập tên dự án!");
                txtTenDuAn.Focus();
            }
            else if (dtpNgayBatDau.Value >= dtpNgayKetThuc.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc!");
            }
            else
            {
                projectDTO.MaDuAn = txtMaDuAn.Text;
                projectDTO.TenDuAn = txtTenDuAn.Text;
                projectDTO.MoTa = txtMoTa.Text;
                projectDTO.NgayBatDau = dtpNgayBatDau.Value;
                projectDTO.NgayKetThuc = dtpNgayKetThuc.Value;
                projectDTO.QuanLyDuAn = string.IsNullOrEmpty(txtQuanLyDuAn.Text) ? null : txtQuanLyDuAn.Text;
                projectDTO.PhongBanPhuTrach = string.IsNullOrEmpty(txtPhongBanPhuTrach.Text) ? null : txtPhongBanPhuTrach.Text;

                try
                {
                    projectBUS.AddDuAn(projectDTO);
                    MessageBox.Show("Thêm dự án thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình thêm: " + ex.Message);
                }
            }
        }

        private void TaoDuAn_Load(object sender, EventArgs e)
        {
            // Any additional initialization can go here
        }

    }
}
