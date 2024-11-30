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
        public void AddThongBao(thongbaodto thongbao)
        {
            thongBaoDao.AddThongBao(thongbao);
        }

        // Cập nhật thông báo
        public void UpdateThongBao(thongbaodto thongbao)
        {
            thongBaoDao.UpdateThongBao(thongbao);
        }


        // Xóa thông báo theo mã thông báo
        public void DeleteThongBao(thongbaodto selectedThongBao)
        {
            thongBaoDao.DeleteThongBao(selectedThongBao.MaThongBao);
        }

    }
}
