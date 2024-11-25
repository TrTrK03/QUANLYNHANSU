using System;
using System.Collections.Generic;
using WinFormsApp1.DAO;
using WinFormsApp1.DTO;

namespace WinFormsApp1.BUS
{
    internal class phongbanbus
    {
        private phongbandao phongBanDao = new phongbandao();

        // Lấy tất cả các phòng ban
        public List<phongbandto> GetPhongBan()
        {
            return phongBanDao.GetPhongBan();
        }

        // Thêm mới phòng ban
        public void AddPhongBan(phongbandto phongBan)
        {
            phongBanDao.AddPhongBan(phongBan);
        }

        // Cập nhật thông tin phòng ban
        public void UpdatePhongBan(phongbandto phongBan)
        {
            phongBanDao.UpdatePhongBan(phongBan);
        }

        // Tìm kiếm phòng ban theo tên
        public List<phongbandto> SearchPhongBanByName(string keyword)
        {
            return phongBanDao.SearchPhongBanByTen(keyword);
        }
        
        // Lấy phòng ban theo mã phòng ban
        public phongbandto GetPhongBanById(string maPhongBan)
        {
            return phongBanDao.GetPhongBanById(maPhongBan);
        }

        // Xóa phòng ban theo mã
        public void DeletePhongBan(string maPhongBan)
        {
            phongBanDao.DeletePhongBan(maPhongBan);
        }

        // Lấy danh sách phòng ban có trạng thái nhất định
        public List<phongbandto> GetDepartmentsByStatus(int trangThai)
        {
            return phongBanDao.GetDepartmentsByStatus(trangThai);
        }

        // Lấy danh sách phòng ban theo trưởng phòng
        public List<phongbandto> GetDepartmentsByManager(string truongPhong)
        {
            return phongBanDao.GetDepartmentsByManager(truongPhong);
        }
    }
}
