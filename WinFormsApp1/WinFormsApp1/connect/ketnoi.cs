using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.connect
{
    internal class ketnoi
    {
        //private string conn = "Data Source=DESKTOP-EEGRU4J\\NGUYETSER;Initial Catalog=basicdb;User ID=sa;Password=123456;";
        //private string conn = "Data Source=DESKTOP-5OES69K\\SQLEXPRESS;Initial Catalog=QLDienThoai;User ID=sa;Password=phat7733419";
        //private String sql = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLDACHBDT;Integrated Security=True";
        private string conn = "Data Source=KHANG;Initial Catalog=QuanLyNhanSuCSharp;Persist Security Info=True;User ID=sa;Password=sa;";
        public SqlConnection connection()
        {
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return connection;
        }

        public void closeconect(SqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                System.Console.WriteLine("Thành công");
            }
            else
            {
                MessageBox.Show("Chưa tạo kết nối");
            }
        }

       




    }
}
