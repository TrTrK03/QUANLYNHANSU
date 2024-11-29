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


        // Xóa phòng ban theo mã
        public void DeletePhongBan(phongbandto selectedphongban)
        {
            phongBanDao.DeletePhongBan(selectedphongban.MaPhongBan);
        }

    }
}
