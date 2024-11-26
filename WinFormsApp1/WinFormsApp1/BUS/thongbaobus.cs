using System;
using System.Collections.Generic;
using WinFormsApp1.DAO;
using WinFormsApp1.DTO;

namespace WinFormsApp1.BUS
{
    internal class thongbaobus
    {
        private thongbaodao thongBaoDao = new thongbaodao();

        // Lấy tất cả các thông báo
        public List<thongbaodto> GetThongBao()
        {
            return thongBaoDao.GetThongBao();
        }

        // Thêm mới thông báo
        public void AddThongBao(thongbaodto notification)
        {
            thongBaoDao.AddThongBao(notification);
        }

        // Cập nhật thông báo
        public void UpdateThongBao(thongbaodto notification)
        {
            thongBaoDao.UpdateThongBao(notification);
        }

        // Tìm kiếm thông báo theo nội dung
        public List<thongbaodto> SearchThongBaoByContent(string keyword)
        {
            return thongBaoDao.SearchThongBaoByContent(keyword);
        }

        // Xóa thông báo theo mã thông báo
        public void DeleteThongBao(string maThongBao)
        {
            thongBaoDao.DeleteThongBao(maThongBao);
        }

    }
}
