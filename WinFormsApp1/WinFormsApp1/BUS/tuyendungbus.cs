using System;
using System.Collections.Generic;
using WinFormsApp1.DAO;
using WinFormsApp1.DTO;

namespace WinFormsApp1.BUS
{
    internal class tuyendungbus
    {
        private tuyendungdao tuyenDungDao = new tuyendungdao();

        // Lấy tất cả các kỳ tuyển dụng
        public List<tuyendungdto> GetTuyenDung()
        {
            return tuyenDungDao.GetTuyenDung();
        }

        // Thêm mới kỳ tuyển dụng
        public void AddTuyenDung(tuyendungdto recruitment)
        {
            tuyenDungDao.AddTuyenDung(recruitment);
        }

        // Cập nhật kỳ tuyển dụng
        public void UpdateTuyenDung(tuyendungdto recruitment)
        {
            tuyenDungDao.UpdateTuyenDung(recruitment);
        }

        // Tìm kiếm kỳ tuyển dụng theo nội dung
        public List<tuyendungdto> SearchTuyenDungByContent(string keyword)
        {
            return tuyenDungDao.SearchTuyenDungByContent(keyword);
        }
    }
}
