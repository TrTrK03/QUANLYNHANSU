﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.DTO;
using WinFormsApp1.BUS;

namespace WinFormsApp1.GUI.detail
{
    public partial class TaoChiTietPhucLoi : Form
    {
        private chitietphucloidto chitietphucloidto = new chitietphucloidto();
        private chitietphucloinhanvienbus chitietphucloinhanvienbus = new chitietphucloinhanvienbus();
        private string MaPhucLoi { get; set; }
        public TaoChiTietPhucLoi()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            if (string.IsNullOrEmpty(MaPhucLoi))
            {
                MessageBox.Show("Mã phúc lợi không hợp lệ.");
                return;
            }
            txtMaPhucLoi.Text = MaPhucLoi;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TaoChiTietPhucLoi_Load(object sender, EventArgs e)
        {

        }

        private void txtMaPhucLoi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTao_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhucLoi.Text))
            {
                MessageBox.Show("Hãy ghi đúng mã phúc lợi.");
                txtMaPhucLoi.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                MessageBox.Show("Hãy ghi đúng mã nhân viên.");
                txtMaNhanVien.Focus();
                return;
            }

            chitietphucloidto.MaPhucLoi = txtMaPhucLoi.Text;
            chitietphucloidto.MaNhanVien = txtMaNhanVien.Text; // Thêm mã nhân viên vào đối tượng

            try
            {
                chitietphucloinhanvienbus.AddChiTietPhucLoi(chitietphucloidto);
                MessageBox.Show("Tham gia phúc lợi thành công!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình thêm: " + ex.Message);
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy? Tất cả dữ liệu chưa lưu sẽ bị mất.", "Xác nhận hủy", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

    }
}
