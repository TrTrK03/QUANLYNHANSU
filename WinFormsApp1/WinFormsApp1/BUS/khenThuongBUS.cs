using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO;
using WinFormsApp1.DTO;

namespace WinFormsApp1.BUS
{
    public class khenThuongBUS
    {
        private khenThuongDAO khenThuongDAO;
        public khenThuongBUS()
        {
            khenThuongDAO = new khenThuongDAO();
        }
        public List<khenThuongDTO> getListReward()
        {
           return khenThuongDAO.getListReward();
        }

        public List<KeyValuePair<string, string>> getEmployeeIdAndName()
        {
            return khenThuongDAO.getEmployeeIdAndName();
        }

        public List<string> getRewardTypes()
        {
            return khenThuongDAO.getRewardTypes();
        }

        //add reward
        public bool addReward(khenThuongDTO reward)
        {
            return khenThuongDAO.addReward(reward);
        }
        public string GenerateNewRewardCode()
        {
            return khenThuongDAO.GenerateNewRewardCode();
        }
        public bool deleteRewards(List<string> maKhenThuongList)
        {
           return khenThuongDAO.deleteRewards(maKhenThuongList);
        }
        public bool updateReward(khenThuongDTO reward)
        {
            return khenThuongDAO.updateReward(reward);
        }
        public List<khenThuongDTO> searchReward(string maNhanVien, string loaiKhenThuong)
        {
            return khenThuongDAO.searchReward(maNhanVien, loaiKhenThuong);
        }
    }
}
