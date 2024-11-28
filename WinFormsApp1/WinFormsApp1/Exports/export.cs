using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;

namespace WinFormsApp1.Exports
{
    internal class export
    {
        // Initialize objects for employee and project data
        nhanviendto employeeDTO = new nhanviendto();
        nhanvienbus employeeBUS = new nhanvienbus();
        duandto projectDTO = new duandto();
        duanbus projectBUS = new duanbus();

        // Export employee data to Excel
        public void SaveEmployeeToExcel(string filePath)
        {
            List<nhanviendto> employees = employeeBUS.GetNhanVien();
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;

                using (ExcelPackage package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Employee");

                    // Header for employee data
                    worksheet.Cells[1, 1].Value = "Mã Nhân Viên";
                    worksheet.Cells[1, 2].Value = "Họ và Tên";
                    worksheet.Cells[1, 3].Value = "Ngày Sinh";
                    worksheet.Cells[1, 4].Value = "Giới Tính";
                    worksheet.Cells[1, 5].Value = "Địa Chỉ";
                    worksheet.Cells[1, 6].Value = "Email";
                    worksheet.Cells[1, 7].Value = "Số Điện Thoại";
                    worksheet.Cells[1, 8].Value = "Người Quản Lý";
                    worksheet.Cells[1, 9].Value = "Phòng Ban";
                    worksheet.Cells[1, 10].Value = "Chức Vụ";
                    worksheet.Cells[1, 11].Value = "Trạng Thái";

                    // Apply header styles
                    using (var range = worksheet.Cells[1, 1, 1, 11])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
                    }

                    // Write employee data
                    int row = 2;
                    foreach (var employee in employees)
                    {
                        worksheet.Cells[row, 1].Value = employee.MaNhanVien;
                        worksheet.Cells[row, 2].Value = employee.HoTen;
                        worksheet.Cells[row, 3].Value = employee.NgaySinh.ToString("dd/MM/yyyy");
                        worksheet.Cells[row, 3].Style.Numberformat.Format = "dd/MM/yyyy";
                        worksheet.Cells[row, 4].Value = employee.GioiTinh;
                        worksheet.Cells[row, 5].Value = employee.DiaChi;
                        worksheet.Cells[row, 6].Value = employee.Email;
                        worksheet.Cells[row, 7].Value = employee.SDT;
                        worksheet.Cells[row, 8].Value = employee.NguoiQuanLy;
                        worksheet.Cells[row, 9].Value = employee.PhongBan;
                        worksheet.Cells[row, 10].Value = employee.ChucVu;
                        worksheet.Cells[row, 11].Value = employee.TrangThai;

                        row++;
                    }

                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                    package.SaveAs(new FileInfo(filePath));
                }

                MessageBox.Show("File Excel đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lưu file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Export project data to Excel
        public void SaveProjectToExcel(string filePath)
        {
            List<duandto> projects = projectBUS.GetDuAn();
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;

                using (ExcelPackage package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Project");

                    // Header for project data
                    worksheet.Cells[1, 1].Value = "Mã Dự Án";
                    worksheet.Cells[1, 2].Value = "Tên Dự Án";
                    worksheet.Cells[1, 3].Value = "Mô Tả";
                    worksheet.Cells[1, 4].Value = "Ngày Bắt Đầu";
                    worksheet.Cells[1, 5].Value = "Ngày Kết Thúc";
                    worksheet.Cells[1, 6].Value = "Quản Lý Dự Án";
                    worksheet.Cells[1, 7].Value = "Phòng Ban Phụ Trách";
                    worksheet.Cells[1, 8].Value = "Trạng Thái";

                    // Apply header styles
                    using (var range = worksheet.Cells[1, 1, 1, 8])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
                    }

                    // Write project data
                    int row = 2;
                    foreach (var project in projects)
                    {
                        worksheet.Cells[row, 1].Value = project.MaDuAn;
                        worksheet.Cells[row, 2].Value = project.TenDuAn;
                        worksheet.Cells[row, 3].Value = project.MoTa;
                        worksheet.Cells[row, 4].Value = project.NgayBatDau.ToString("dd/MM/yyyy");
                        worksheet.Cells[row, 4].Style.Numberformat.Format = "dd/MM/yyyy";
                        worksheet.Cells[row, 5].Value = project.NgayKetThuc.ToString("dd/MM/yyyy");
                        worksheet.Cells[row, 5].Style.Numberformat.Format = "dd/MM/yyyy";
                        worksheet.Cells[row, 6].Value = project.QuanLyDuAn;
                        worksheet.Cells[row, 7].Value = project.PhongBanPhuTrach;
                        worksheet.Cells[row, 8].Value = project.TrangThai == 1 ? "Hiện" : "Ẩn";

                        row++;
                    }

                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                    package.SaveAs(new FileInfo(filePath));
                }

                MessageBox.Show("File Excel đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lưu file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
