using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO;
using WinFormsApp1.DTO;

namespace WinFormsApp1.BUS
{
    internal class nhanvienbus {
        private nhanviendao employeeDAO = new nhanviendao();
        public List<nhanviendto> GetNhanVien()
        {
            return employeeDAO.GetNhanVien();
        }

        public void AddNhanVien(nhanviendto employee)
        {
            employeeDAO.AddNhanVien(employee);
        }

        public void UpdateNhanVien(nhanviendto employee)
        {
            employeeDAO.UpdateNhanVien(employee);
        }
        public void DeleteNhanVien(nhanviendto employee)
        {
            employeeDAO.DeleteNhanVien(employee);
        }

        public string GetMaDuAnFromDatabase(nhanviendto employee)
        {
            return employeeDAO.GetMaDuAnFromDatabase(employee); // Gọi phương thức và trả về string
        }

        //public List<string> LoadMaTK()
        //{
        //    return employeeDAO.LoadMaTK();
        //}

        //public void ChangeStateHidden(nhanviendto employee)
        //{
        //    employeeDAO.ChangeStateHidden(employee);
        //}

        //public void ChangeStateCurrent(nhanviendto employee)
        //{
        //    employeeDAO.ChangeStateCurrent(employee);
        //}
    }
}
