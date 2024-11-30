using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO;
using WinFormsApp1.DTO;

namespace WinFormsApp1.BUS
{
    internal class bangLuongBUS
    {
        private bangLuongDAO luongDao = new bangLuongDAO();

        public List<bangLuongDTO> GetLuong()
        {
            return luongDao.GetLuong();
        }

        public bool AddLuong(bangLuongDTO salary)
        {
            try
            {
                // Gọi phương thức AddLuong từ lớp DAO và trả kết quả cho lớp BUS
                return luongDao.AddLuong(salary);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có và ném lại thông báo lỗi
                throw new Exception("Lỗi khi thêm bảng lương: " + ex.Message);
            }
        }

        public bool DeleteLuong(string maNhanVien, DateTime thangNam)
        {
            try
            {
                // Gọi phương thức xóa từ DAO
                return luongDao.DeleteLuong(maNhanVien, thangNam);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa bảng lương: " + ex.Message);
            }
        }

        public List<bangLuongDTO> SearchLuong(string searchQuery)
        {
            try
            {
                return luongDao.SearchLuong(searchQuery);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm bảng lương: " + ex.Message);
            }
        }

        public List<bangLuongDTO> SearchLuongByMaNhanVien(string keyword)
        {
            return luongDao.SearchLuongByMaNhanVien(keyword);
        }
       public List<nhanviendto> getListEmployeeNotSalary()
        {
            return luongDao.getListEmployeeNotSalary();
        }
        public int GetLuongCoBanByMaNhanVien(string maNhanVien)
        {
            try
            {
                return luongDao.GetLuongCoBanByMaNhanVien(maNhanVien);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy lương cơ bản: " + ex.Message);
            }
        }

        public bool UpdateLuong(bangLuongDTO updatedSalary)
        {
            return luongDao.UpdateLuong(updatedSalary);
        }
    }
}
