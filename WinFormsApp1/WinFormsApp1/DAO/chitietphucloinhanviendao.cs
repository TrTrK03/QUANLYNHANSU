using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WinFormsApp1.connect;
using WinFormsApp1.DTO;

namespace WinFormsApp1.DAO
{
    internal class chitietphucloinhanviendao
    {
        private ketnoi connectObj = new ketnoi();

        public chitietphucloinhanviendao() { }

        public List<chitietphucloidto> GetChiTietPhucLoi()
        {
            List<chitietphucloidto> chitietphucloiList = new List<chitietphucloidto>();

            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("SELECT * FROM ChiTietPhucLoiNhanVien", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    chitietphucloidto chitietphucloi = new chitietphucloidto
                    {
                        MaPhucLoi = reader["MaPhucLoi"].ToString(),
                        MaNhanVien = reader["MaNhanVien"].ToString(),
                    };
                    chitietphucloiList.Add(chitietphucloi);
                }
                reader.Close();
                connection.Close();
            }

            return chitietphucloiList;
        }

        public void AddChiTietPhucLoi(chitietphucloidto chitietphucloi)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("INSERT INTO ChiTietPhucLoiNhanVien VALUES(@MaPhucLoi, @MaNhanVien)", connection);
                command.Parameters.AddWithValue("@MaPhucLoi", chitietphucloi.MaPhucLoi);
                command.Parameters.AddWithValue("@MaNhanVien", chitietphucloi.MaNhanVien);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateChiTietPhucLoi(chitietphucloidto chitietphucloi)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE ChiTietPhucLoiNhanVien SET MaNhanVien = @MaNhanVien, WHERE MaPhucLoi = @MaPhucLoi", connection);
                command.Parameters.AddWithValue("@MaPhucLoi", chitietphucloi.MaPhucLoi);
                command.Parameters.AddWithValue("@MaNhanVien", chitietphucloi.MaNhanVien);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void DeleteChiTietPhucLoi(string MaNhanVien)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("DELETE FROM ChiTietPhucLoiNhanVien WHERE MaNhanVien = @MaNhanVien", connection);
                command.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}

