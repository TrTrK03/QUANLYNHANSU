using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WinFormsApp1.GUI.detail
{
    public partial class TaoNhanVien : Form
    {
        nhanviendto employeeDTO = new nhanviendto();
        nhanvienbus employeeBUS = new nhanvienbus();
        private DTO.nhanviendto SelectedEmployee { get; set; }
        

        string lastmanv = "";
        int i = 0;

        public TaoNhanVien()
        {
            InitializeComponent();
            rdbHien.Checked = true;
            List<nhanviendto> employees = employeeBUS.GetNhanVien();
            lastmanv = employees[^1].MaNhanVien;
            i = Convert.ToInt32(lastmanv.Substring(lastmanv.Length - 5)) + 1;
            if (i < 10)
            {
                txtMaNV.Text = "NV0000" + i.ToString();
            }
            else
            {
                if (i < 100)
                {
                    txtMaNV.Text = "NV000" + i.ToString();
                }
                else
                {
                    if (i < 1000)
                    {
                        txtMaNV.Text = "NV00" + i.ToString();
                    }
                    else
                    {
                        if (i < 10000)
                        {
                            txtMaNV.Text = "NV0" + i.ToString();

                        }
                    }
                }
            }


        }

        public TaoNhanVien(DTO.nhanviendto selectedEmployee)
        {
            InitializeComponent();
            rdbHien.Checked = true;
            List<nhanviendto> employees = employeeBUS.GetNhanVien();
            lastmanv = employees[^1].MaNhanVien;
            i = Convert.ToInt32(lastmanv.Substring(lastmanv.Length - 5)) + 1;
            if (i < 10)
            {
                txtMaNV.Text = "NV0000" + i.ToString();
            }
            else
            {
                if (i < 100)
                {
                    txtMaNV.Text = "NV000" + i.ToString();
                }
                else
                {
                    if (i < 1000)
                    {
                        txtMaNV.Text = "NV00" + i.ToString();
                    }
                    else
                    {
                        if (i < 10000)
                        {
                            txtMaNV.Text = "NV0" + i.ToString();

                        }
                    }
                }
            }

            SelectedEmployee = selectedEmployee;
            
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
            if (SelectedEmployee.TrangThai == 1)
            {
                rdbHien.Checked = true;
            }
            else if (SelectedEmployee.TrangThai == 0)
            {
                rdbAn.Checked = true;
            }



        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Xác nhận hủy", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
            }
        }



        private void cbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNam.Checked)
            {
                cbNu.Checked = false;
            }
        }

        private void cbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNu.Checked)
            {
                cbNam.Checked = false;
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
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
            else if (rdbHien.Checked == false && rdbAn.Checked == false)
            {
                MessageBox.Show("Hãy chọn trạng thái của nhân viên!!!");
            }
            else if (!cbNam.Checked && !cbNu.Checked)
            {
                MessageBox.Show("Hãy chọn giới tính của nhân viên!!!");
            }
            else
            {
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
                employeeDTO.NgaySinh = selectedDate.ToString("yyyy-MM-dd"); //5
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

                if (rdbHien.Checked) //8
                {
                    employeeDTO.TrangThai = 1;
                }
                else if (rdbAn.Checked)
                {
                    employeeDTO.TrangThai = 0;
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
                    employeeBUS.AddEmployee(employeeDTO);
                    MessageBox.Show("Thêm nhân viên thành công!!!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình thêm: " + ex.Message);
                }
            }
        }

        private void TaoNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
