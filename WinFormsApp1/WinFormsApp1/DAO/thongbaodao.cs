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

                SqlCommand command = new SqlCommand("SELECT * FROM BangThongBao WHERE TrangThai = 1", connection);
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

                SqlCommand command = new SqlCommand("INSERT INTO BangThongBao VALUES(@MaThongBao, @NoiDung, @NguoiBanHanh, @NgayBanHanh, 1)", connection);
                command.Parameters.AddWithValue("@MaThongBao", notification.MaThongBao);
                command.Parameters.AddWithValue("@NoiDung", notification.NoiDung);
                command.Parameters.AddWithValue("@NguoiBanHanh", notification.NguoiBanHanh);
                command.Parameters.AddWithValue("@NgayBanHanh", notification.NgayBanHanh);

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

                SqlCommand command = new SqlCommand("UPDATE BangThongBao SET NoiDung = @NoiDung, NguoiBanHanh = @NguoiBanHanh, NgayBanHanh = @NgayBanHanh, TrangThai = 1 WHERE MaThongBao = @MaThongBao", connection);
                command.Parameters.AddWithValue("@MaThongBao", notification.MaThongBao);
                command.Parameters.AddWithValue("@NoiDung", notification.NoiDung);
                command.Parameters.AddWithValue("@NguoiBanHanh", notification.NguoiBanHanh);
                command.Parameters.AddWithValue("@NgayBanHanh", notification.NgayBanHanh);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }


        public void DeleteThongBao(string maThongBao)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("UPDATE BangThongBao SET TrangThai = 0 WHERE MaThongBao = @MaThongBao", connection);
                command.Parameters.AddWithValue("@MaThongBao", maThongBao);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
