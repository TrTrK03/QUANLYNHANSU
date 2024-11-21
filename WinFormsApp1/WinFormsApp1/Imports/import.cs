using System;
using System.Collections.Generic;
using System.IO;
using WinFormsApp1.DTO;
using WinFormsApp1.DAO;
using WinFormsApp1.BUS;
using WinFormsApp1.GUI.detail;
using OfficeOpenXml;

namespace WinFormsApp1.Imports
{
    public class Import
    {
        nhanviendto employeeDTO = new nhanviendto();
        nhanvienbus employeeBUS = new nhanvienbus();

        duandto duanDTO = new duandto();
        duanbus duanBUS = new duanbus();

        public List<nhanviendto> ReadExcelFile(string filePath)
        {
            var employees = new List<nhanviendto>();

            // Check if the file exists
            if (!File.Exists(filePath))
                throw new FileNotFoundException("File không tồn tại!");

            // Read the Excel file
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0]; // Get the first sheet
                int rowCount = worksheet.Dimension.Rows;       // Number of rows
                int colCount = worksheet.Dimension.Columns;    // Number of columns

                // Start from row 2, assuming the first row is the header
                for (int row = 2; row <= rowCount; row++)
                {
                    var employee = new nhanviendto
                    {
                        HoTen = worksheet.Cells[row, 1].Text,
                        NgaySinh = worksheet.Cells[row, 2].Text,
                        GioiTinh = worksheet.Cells[row, 3].Text,
                        DiaChi = worksheet.Cells[row, 4].Text,
                        Email = worksheet.Cells[row, 5].Text,
                        SDT = worksheet.Cells[row, 6].Text,
                        NguoiQuanLy = worksheet.Cells[row, 7].Text,
                        PhongBan = worksheet.Cells[row, 8].Text,
                        ChucVu = worksheet.Cells[row, 9].Text,
                        TrangThai = 1
                    };

                    employees.Add(employee);
                }
            }

            return employees;
        }

        public List<duandto> ReadProjectExcelFile(string filePath)
        {
            var projects = new List<duandto>();

            // Check if the file exists
            if (!File.Exists(filePath))
                throw new FileNotFoundException("File không tồn tại!");

            // Read the Excel file
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0]; // Get the first sheet
                int rowCount = worksheet.Dimension.Rows;       // Number of rows

                // Start from row 2, assuming the first row is the header
                for (int row = 2; row <= rowCount; row++)
                {
                    var project = new duandto
                    {
                        MaDuAn = worksheet.Cells[row, 1].Text,
                        TenDuAn = worksheet.Cells[row, 2].Text,
                        MoTa = worksheet.Cells[row, 3].Text,
                        QuanLyDuAn = worksheet.Cells[row, 4].Text,
                        PhongBanPhuTrach = worksheet.Cells[row, 5].Text,
                        NgayBatDau = DateTime.TryParse(worksheet.Cells[row, 6].Text, out var ngayBatDau) ? ngayBatDau : DateTime.MinValue, // Default to DateTime.MinValue if invalid
                        NgayKetThuc = DateTime.TryParse(worksheet.Cells[row, 7].Text, out var ngayKetThuc) ? ngayKetThuc : DateTime.MinValue, // Default to DateTime.MinValue if invalid
                        TrangThai = worksheet.Cells[row, 8].Text == "Hiện" ? 1 : 0 // Assuming "Hiện" is for active projects
                    };

                    projects.Add(project);
                }
            }

            return projects;
        }

        public void importEmpByExcel(string filePath)
        {
            try
            {
                List<nhanviendto> employees = ReadExcelFile(filePath);
                foreach (var employee in employees)
                {
                    List<nhanviendto> NV = employeeBUS.GetNhanVien();
                    string lastmanv = NV[^1].MaNhanVien;

                    TaoNhanVien interf = new TaoNhanVien(employee);
                    interf.StartPosition = FormStartPosition.CenterParent;
                    interf.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }

        public void ImportProjectByExcel(string filePath)
        {
            try
            {
                List<duandto> projects = ReadProjectExcelFile(filePath);
                foreach (var project in projects)
                {
                    // Assuming you have a method in duanBUS to add a project
                    duanBUS.AddDuAn(project);
                    // Optionally, you can show a dialog or message for each imported project
                    Console.WriteLine($"Dự Án: {project.TenDuAn} đã được nhập.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
    }
}