using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1.connect
{
    internal class connect
    {
        String sql = @"Data Source=DESKTOP-EEGRU4J\NGUYETSER;Initial Catalog=basicdb;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";  

        SqlConnection sqlcon = null;

        public connect()
        {
        }

        public SqlConnection connection()
        {
            try
            {
                if (sqlcon == null)
                {
                    sqlcon = new SqlConnection(sql);
                }
                if (sqlcon.State == System.Data.ConnectionState.Closed)
                {
                    sqlcon.Open();
                   
                }
            }
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return sqlcon;
        }
        public void closeconect()
        {
            if(sqlcon!=null && sqlcon.State==System.Data.ConnectionState.Open)
            {
                sqlcon.Close();
                MessageBox.Show("Kết nối đã đóng");
            }
            else
            {
                MessageBox.Show("Chưa tạo kết nối");
            }
        }
    }
}
