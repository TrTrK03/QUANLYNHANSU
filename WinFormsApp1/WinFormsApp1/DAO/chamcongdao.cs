using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.connect;
using WinFormsApp1.DTO;

namespace WinFormsApp1.DAO
{
    internal class chamcongdao
    {
        private ketnoi connectObj = new ketnoi();
        public chamcongdao() { }

        public List<chamcongdto> GetChamCong()
        {
            List<chamcongdto> chamcongdtos = new List<chamcongdto>();
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM BangChamCong";
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    chamcongdto chamcong = new chamcongdto
                    {
                        MaBangChamCong = reader["MaBangChamCong"].ToString(),
                        GioVaoCa = reader["GioVaoCa"].ToString(),
                        ThangNam = DateTime.Parse(reader["ThangNam"].ToString()),


                    };
                    chamcongdtos.Add(chamcong);
                }
                reader.Close();
                connection.Close();
                return chamcongdtos;
            }
        }
    }
}
