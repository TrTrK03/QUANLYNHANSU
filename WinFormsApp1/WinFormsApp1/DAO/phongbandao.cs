using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WinFormsApp1.DTO;
using WinFormsApp1.connect;

namespace WinFormsApp1.DAO
{
    internal class phongbandao
    {
        private ketnoi connectObj = new ketnoi();

        public phongbandao() { }

        public List<phongbandto> GetPhongBan()
        {
            List<phongbandto> departments = new List<phongbandto>();

            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("SELECT * FROM PhongBan", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    phongbandto department = new phongbandto
                    {
                        MaPhongBan = reader["MaPhongBan"].ToString(),
                        TenPhongBan = reader["TenPhongBan"].ToString(),
                        MoTa = reader["MoTa"].ToString(),
                        TruongPhong = reader["TruongPhong"].ToString(),
                        TrangThai = Convert.ToInt32(reader["TrangThai"])
                    };
                    departments.Add(department);
                }
                reader.Close();
                connection.Close();
            }

            return departments;
        }

        public void AddPhongBan(phongbandto department)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("INSERT INTO PhongBan VALUES(@MaPhongBan, @TenPhongBan, @MoTa, @TruongPhong, @TrangThai)", connection);
                command.Parameters.AddWithValue("@MaPhongBan", department.MaPhongBan);
                command.Parameters.AddWithValue("@TenPhongBan", department.TenPhongBan);
                command.Parameters.AddWithValue("@MoTa", department.MoTa);
                command.Parameters.AddWithValue("@TruongPhong", department.TruongPhong);
                command.Parameters.AddWithValue("@TrangThai", department.TrangThai);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdatePhongBan(phongbandto department)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("UPDATE PhongBan SET TenPhongBan = @TenPhongBan, MoTa = @MoTa, TruongPhong = @TruongPhong, TrangThai = @TrangThai WHERE MaPhongBan = @MaPhongBan", connection);
                command.Parameters.AddWithValue("@MaPhongBan", department.MaPhongBan);
                command.Parameters.AddWithValue("@TenPhongBan", department.TenPhongBan);
                command.Parameters.AddWithValue("@MoTa", department.MoTa);
                command.Parameters.AddWithValue("@TruongPhong", department.TruongPhong);
                command.Parameters.AddWithValue("@TrangThai", department.TrangThai);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<phongbandto> SearchPhongBanByTen(string keyword)
        {
            List<phongbandto> departments = new List<phongbandto>();

            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("SELECT * FROM PhongBan WHERE TenPhongBan LIKE @Keyword", connection);
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    phongbandto department = new phongbandto
                    {
                        MaPhongBan = reader["MaPhongBan"].ToString(),
                        TenPhongBan = reader["TenPhongBan"].ToString(),
                        MoTa = reader["MoTa"].ToString(),
                        TruongPhong = reader["TruongPhong"].ToString(),
                        TrangThai = Convert.ToInt32(reader["TrangThai"])
                    };
                    departments.Add(department);
                }
                reader.Close();
            }

            return departments;
        }

        public void DeletePhongBan(string maPhongBan)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Xóa phòng ban theo mã phòng ban (MaPhongBan)
                SqlCommand command = new SqlCommand("DELETE FROM PhongBan WHERE MaPhongBan = @MaPhongBan", connection);
                command.Parameters.AddWithValue("@MaPhongBan", maPhongBan);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

    }
}
