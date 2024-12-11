//using Doanqlchdt.BUS;
//using Doanqlchdt.DTO;
//using Doanqlchdt.connect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinFormsApp1.GUI;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;


//using Doanqlchdt.GUI.Messageboxshow;

namespace WinFormsApp1.GUI.detail;

public partial class SuaNhanVien : Form
{
    private DTO.nhanviendto SelectedEmployee { get; set; }
    static nhanvienbus employeeBUS = new nhanvienbus();
    public SuaNhanVien(DTO.nhanviendto selectedEmployee)
    {
        InitializeComponent();
        SelectedEmployee = selectedEmployee;
        txtMaNV.Text = selectedEmployee.MaNhanVien.Trim();
        txtDiaChi.Text = selectedEmployee.DiaChi.Trim();
        txtEmail.Text = selectedEmployee.Email.Trim();
        txtHoTen.Text = selectedEmployee.HoTen.Trim();
        txtNQL.Text = selectedEmployee.NguoiQuanLy.Trim();
        txtPhongBan.Text = selectedEmployee.PhongBan.Trim();
        txtSDT.Text = selectedEmployee.SDT.Trim();
        txtChucVu.Text = selectedEmployee.ChucVu.Trim();
        if (selectedEmployee.GioiTinh.Trim().ToLower() == "nam")
        {
            cbNam.Checked = true;
        }
        else if (selectedEmployee.GioiTinh.Trim().ToLower() == "nữ")
        {
            cbNu.Checked = true;
        }

    }

    // Sự kiện khi cbNam được thay đổi
    private void cbNam_CheckedChanged(object sender, EventArgs e)
    {
        if (cbNam.Checked)
        {
            cbNu.Checked = false;
        }
    }

    // Sự kiện khi cbNu được thay đổi
    private void cbNu_CheckedChanged(object sender, EventArgs e)
    {
        if (cbNu.Checked)
        {
            cbNam.Checked = false;
        }
    }

    private void SuaNhanVien_Load(object sender, EventArgs e)
    {

    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Xác nhận hủy", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@gmail\.com$"))
        {
            MessageBox.Show("Địa chỉ email không hợp lệ!!!");
            txtEmail.Focus();
        }
        else if (!Regex.IsMatch(txtSDT.Text, @"^[0-9]+$"))
        {
            MessageBox.Show("Số điện thoại không hợp lệ!!!");
            txtSDT.Focus();
        }
        else if (Regex.IsMatch(txtHoTen.Text, @"\d"))
        {
            MessageBox.Show("Họ tên không hợp lệ!!!");
            txtHoTen.Focus();
        }
        else if (txtPhongBan.Text == "")
        {
            MessageBox.Show("Điền phòng ban!");
            txtPhongBan.Focus();
        }

        else if (dtpNgaySinh.Value == default(DateTime))
        {
            MessageBox.Show("Bạn chưa chọn ngày sinh của nhân viên!!!");
        }
        else if (!cbNam.Checked && !cbNu.Checked)
        {
            MessageBox.Show("Hãy chọn giới tính của nhân viên!!!");
        }
        else
        {
            nhanviendto employeeDTO = new nhanviendto();
            // Thực hiện truy vấn tại đây
            employeeDTO.MaNhanVien = txtMaNV.Text.ToString(); //1
            employeeDTO.HoTen = txtHoTen.Text; //2
            employeeDTO.SDT = txtSDT.Text;//3
            employeeDTO.Email = txtEmail.Text;//4
            employeeDTO.DiaChi = txtDiaChi.Text; //10
            employeeDTO.ChucVu = txtChucVu.Text;//11
            employeeDTO.HoSoGioiThieu = null;

            //employeeDTO.MaTK = Convert.ToInt32(cbbMaTK.SelectedItem);
            DateTime selectedDate = dtpNgaySinh.Value;
            employeeDTO.NgaySinh = selectedDate;
            if (txtNQL.Text == "") //6
            {
                employeeDTO.NguoiQuanLy = null;
            }
            else
            {
                employeeDTO.NguoiQuanLy = txtNQL.Text;
            }

            if (txtPhongBan.Text == "") //7
            {
                employeeDTO.PhongBan = null;
            }
            else
            {
                employeeDTO.PhongBan = txtPhongBan.Text;
            }

            if (cbNam.Checked) //9
            {
                employeeDTO.GioiTinh = "Nam";
            }
            else if (cbNu.Checked)
            {
                employeeDTO.GioiTinh = "Nữ";
            }


            try
            {
                employeeBUS.UpdateNhanVien(employeeDTO);
                MessageBox.Show("Chỉnh sửa nhân viên thành công!!!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình chỉnh sửa: " + ex.Message);
            }
        }
    }
}
