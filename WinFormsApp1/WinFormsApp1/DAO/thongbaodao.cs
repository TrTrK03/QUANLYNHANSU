using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WinFormsApp1.DTO;
using WinFormsApp1.connect;

namespace WinFormsApp1.DAO
{
    internal class thongbaodao
    {
        private ketnoi connectObj = new ketnoi();

        public thongbaodao() { }

        public List<thongbaodto> GetThongBao()
        {
            List<thongbaodto> notifications = new List<thongbaodto>();

            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("SELECT * FROM ThongBao", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    thongbaodto notification = new thongbaodto
                    {
                        MaThongBao = reader["MaThongBao"].ToString(),
                        NoiDung = reader["NoiDung"].ToString(),
                        NguoiBanHanh = reader["NguoiBanHanh"].ToString(),
                        NgayBanHanh = Convert.ToDateTime(reader["NgayBanHanh"]),
                        TrangThai = Convert.ToInt32(reader["TrangThai"])
                    };
                    notifications.Add(notification);
                }
                reader.Close();
                connection.Close();
            }

            return notifications;
        }

        public void AddThongBao(thongbaodto notification)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("INSERT INTO ThongBao VALUES(@MaThongBao, @NoiDung, @NguoiBanHanh, @NgayBanHanh, @TrangThai)", connection);
                command.Parameters.AddWithValue("@MaThongBao", notification.MaThongBao);
                command.Parameters.AddWithValue("@NoiDung", notification.NoiDung);
                command.Parameters.AddWithValue("@NguoiBanHanh", notification.NguoiBanHanh);
                command.Parameters.AddWithValue("@NgayBanHanh", notification.NgayBanHanh);
                command.Parameters.AddWithValue("@TrangThai", notification.TrangThai);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateThongBao(thongbaodto notification)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("UPDATE ThongBao SET NoiDung = @NoiDung, NguoiBanHanh = @NguoiBanHanh, NgayBanHanh = @NgayBanHanh, TrangThai = @TrangThai WHERE MaThongBao = @MaThongBao", connection);
                command.Parameters.AddWithValue("@MaThongBao", notification.MaThongBao);
                command.Parameters.AddWithValue("@NoiDung", notification.NoiDung);
                command.Parameters.AddWithValue("@NguoiBanHanh", notification.NguoiBanHanh);
                command.Parameters.AddWithValue("@NgayBanHanh", notification.NgayBanHanh);
                command.Parameters.AddWithValue("@TrangThai", notification.TrangThai);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<thongbaodto> SearchThongBaoByContent(string keyword)
        {
            List<thongbaodto> notifications = new List<thongbaodto>();

            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("SELECT * FROM ThongBao WHERE NoiDung LIKE @Keyword", connection);
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    thongbaodto notification = new thongbaodto
                    {
                        MaThongBao = reader["MaThongBao"].ToString(),
                        NoiDung = reader["NoiDung"].ToString(),
                        NguoiBanHanh = reader["NguoiBanHanh"].ToString(),
                        NgayBanHanh = Convert.ToDateTime(reader["NgayBanHanh"]),
                        TrangThai = Convert.ToInt32(reader["TrangThai"])
                    };
                    notifications.Add(notification);
                }
                reader.Close();
            }

            return notifications;
        }

        public void DeleteThongBao(string maThongBao)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("DELETE FROM ThongBao WHERE MaThongBao = @MaThongBao", connection);
                command.Parameters.AddWithValue("@MaThongBao", maThongBao);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
