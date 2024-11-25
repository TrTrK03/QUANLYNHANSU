using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WinFormsApp1.DTO;

namespace WinFormsApp1.DAO
{
    internal class tuyendungdao
    {
        private ketnoi connectObj = new ketnoi();

        public tuyendungdao() { }

        public List<tuyendungdto> GetTuyenDung()
        {
            List<tuyendungdto> recruitmentList = new List<tuyendungdto>();

            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("SELECT * FROM Tuyendung", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tuyendungdto recruitment = new tuyendungdto
                    {
                        MaKyTuyenDung = reader["MaKyTuyenDung"].ToString(),
                        NoiDung = reader["NoiDung"].ToString(),
                        NgayBatDau = Convert.ToDateTime(reader["NgayBatDau"]),
                        NgayKetThuc = Convert.ToDateTime(reader["NgayKetThuc"]),
                        MaQuanLy = reader["MaQuanLy"].ToString(),
                        TrangThai = Convert.ToInt32(reader["TrangThai"])
                    };
                    recruitmentList.Add(recruitment);
                }
                reader.Close();
                connection.Close();
            }

            return recruitmentList;
        }

        public void AddTuyenDung(tuyendungdto recruitment)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("INSERT INTO Tuyendung VALUES(@MaKyTuyenDung, @NoiDung, @NgayBatDau, @NgayKetThuc, @MaQuanLy, @TrangThai)", connection);
                command.Parameters.AddWithValue("@MaKyTuyenDung", recruitment.MaKyTuyenDung);
                command.Parameters.AddWithValue("@NoiDung", recruitment.NoiDung);
                command.Parameters.AddWithValue("@NgayBatDau", recruitment.NgayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", recruitment.NgayKetThuc);
                command.Parameters.AddWithValue("@MaQuanLy", recruitment.MaQuanLy);
                command.Parameters.AddWithValue("@TrangThai", recruitment.TrangThai);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateTuyenDung(tuyendungdto recruitment)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("UPDATE Tuyendung SET NoiDung = @NoiDung, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, MaQuanLy = @MaQuanLy, TrangThai = @TrangThai WHERE MaKyTuyenDung = @MaKyTuyenDung", connection);
                command.Parameters.AddWithValue("@MaKyTuyenDung", recruitment.MaKyTuyenDung);
                command.Parameters.AddWithValue("@NoiDung", recruitment.NoiDung);
                command.Parameters.AddWithValue("@NgayBatDau", recruitment.NgayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", recruitment.NgayKetThuc);
                command.Parameters.AddWithValue("@MaQuanLy", recruitment.MaQuanLy);
                command.Parameters.AddWithValue("@TrangThai", recruitment.TrangThai);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<tuyendungdto> SearchTuyenDungByContent(string keyword)
        {
            List<tuyendungdto> recruitmentList = new List<tuyendungdto>();

            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("SELECT * FROM Tuyendung WHERE NoiDung LIKE @Keyword", connection);
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tuyendungdto recruitment = new tuyendungdto
                    {
                        MaKyTuyenDung = reader["MaKyTuyenDung"].ToString(),
                        NoiDung = reader["NoiDung"].ToString(),
                        NgayBatDau = Convert.ToDateTime(reader["NgayBatDau"]),
                        NgayKetThuc = Convert.ToDateTime(reader["NgayKetThuc"]),
                        MaQuanLy = reader["MaQuanLy"].ToString(),
                        TrangThai = Convert.ToInt32(reader["TrangThai"])
                    };
                    recruitmentList.Add(recruitment);
                }
                reader.Close();
            }

            return recruitmentList;
        }
    }
}
