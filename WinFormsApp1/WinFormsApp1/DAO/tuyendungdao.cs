using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WinFormsApp1.DTO;
using WinFormsApp1.connect;

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

                SqlCommand command = new SqlCommand("SELECT * FROM KyTuyenDung", connection);
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

                SqlCommand command = new SqlCommand("INSERT INTO KyTuyenDung VALUES(@MaKyTuyenDung, @NoiDung, @NgayBatDau, @NgayKetThuc, @MaQuanLy, 1)", connection);
                command.Parameters.AddWithValue("@MaKyTuyenDung", recruitment.MaKyTuyenDung);
                command.Parameters.AddWithValue("@NoiDung", recruitment.NoiDung);
                command.Parameters.AddWithValue("@NgayBatDau", recruitment.NgayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", recruitment.NgayKetThuc);
                command.Parameters.AddWithValue("@MaQuanLy", recruitment.MaQuanLy);

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

                SqlCommand command = new SqlCommand("UPDATE KyTuyenDung SET NoiDung = @NoiDung, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, MaQuanLy = @MaQuanLy, TrangThai = 1 WHERE MaKyTuyenDung = @MaKyTuyenDung", connection);
                command.Parameters.AddWithValue("@MaKyTuyenDung", recruitment.MaKyTuyenDung);
                command.Parameters.AddWithValue("@NoiDung", recruitment.NoiDung);
                command.Parameters.AddWithValue("@NgayBatDau", recruitment.NgayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", recruitment.NgayKetThuc);
                command.Parameters.AddWithValue("@MaQuanLy", recruitment.MaQuanLy);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void DeleteTuyenDung(string MaKyTuyenDung)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("DELETE FROM KyTuyenDung WHERE MaKyTuyenDung = @MaKyTuyenDung", connection);
                command.Parameters.AddWithValue("@MaKyTuyenDung", MaKyTuyenDung);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
