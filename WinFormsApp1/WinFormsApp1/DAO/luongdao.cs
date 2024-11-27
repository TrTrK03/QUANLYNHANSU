using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WinFormsApp1.DTO;
using WinFormsApp1.connect;

namespace WinFormsApp1.DAO
{
    internal class luongdao
    {
        private ketnoi connectObj = new ketnoi();

        public luongdao() { }

        public List<luongdto> GetLuong()
        {
            List<luongdto> salaries = new List<luongdto>();

            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("SELECT * FROM Luong", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    luongdto salary = new luongdto
                    {
                        MaNhanVien = reader["MaNhanVien"].ToString(),
                        ThangNam = Convert.ToDateTime(reader["ThangNam"]),
                        PhuCap = Convert.ToInt32(reader["PhuCap"]),
                        KhauTru = Convert.ToInt32(reader["KhauTru"]),
                        LuongThucNhan = Convert.ToInt32(reader["LuongThucNhan"])
                    };
                    salaries.Add(salary);
                }
                reader.Close();
                connection.Close();
            }

            return salaries;
        }

        public void AddLuong(luongdto salary)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("INSERT INTO Luong VALUES(@MaNhanVien, @ThangNam, @PhuCap, @KhauTru, @LuongThucNhan)", connection);
                command.Parameters.AddWithValue("@MaNhanVien", salary.MaNhanVien);
                command.Parameters.AddWithValue("@ThangNam", salary.ThangNam);
                command.Parameters.AddWithValue("@PhuCap", salary.PhuCap);
                command.Parameters.AddWithValue("@KhauTru", salary.KhauTru);
                command.Parameters.AddWithValue("@LuongThucNhan", salary.LuongThucNhan);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateLuong(luongdto salary)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("UPDATE Luong SET ThangNam = @ThangNam, PhuCap = @PhuCap, KhauTru = @KhauTru, LuongThucNhan = @LuongThucNhan WHERE MaNhanVien = @MaNhanVien", connection);
                command.Parameters.AddWithValue("@MaNhanVien", salary.MaNhanVien);
                command.Parameters.AddWithValue("@ThangNam", salary.ThangNam);
                command.Parameters.AddWithValue("@PhuCap", salary.PhuCap);
                command.Parameters.AddWithValue("@KhauTru", salary.KhauTru);
                command.Parameters.AddWithValue("@LuongThucNhan", salary.LuongThucNhan);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<luongdto> SearchLuongByMaNhanVien(string keyword)
        {
            List<luongdto> salaries = new List<luongdto>();

            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("SELECT * FROM Luong WHERE MaNhanVien LIKE @Keyword", connection);
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    luongdto salary = new luongdto
                    {
                        MaNhanVien = reader["MaNhanVien"].ToString(),
                        ThangNam = Convert.ToDateTime(reader["ThangNam"]),
                        PhuCap = Convert.ToInt32(reader["PhuCap"]),
                        KhauTru = Convert.ToInt32(reader["KhauTru"]),
                        LuongThucNhan = Convert.ToInt32(reader["LuongThucNhan"])
                    };
                    salaries.Add(salary);
                }
                reader.Close();
            }

            return salaries;
        }
    }
}
