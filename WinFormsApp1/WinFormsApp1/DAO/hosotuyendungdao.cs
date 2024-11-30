using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WinFormsApp1.connect;
using WinFormsApp1.DTO;

namespace WinFormsApp1.DAO
{
    internal class hosotuyendungdao
    {
        private ketnoi connectObj = new ketnoi();

        public hosotuyendungdao() { }

        public List<hosotuyendungdto> GetHoSoTuyenDung()
        {
            List<hosotuyendungdto> hoSoList = new List<hosotuyendungdto>();

            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("SELECT * FROM HoSoTuyenDung", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    hosotuyendungdto hoSo = new hosotuyendungdto
                    {
                        MaHoSoTuyenDung = reader["MaHoSoTuyenDung"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                        NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        Email = reader["Email"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        TrinhDo = reader["TrinhDo"].ToString(),
                        MoTaBangCap = reader["MoTaBangCap"].ToString(),
                        KyTuyenDung = reader["KyTuyenDung"].ToString(),
                        TrangThai = Convert.ToInt32(reader["TrangThai"])
                    };
                    hoSoList.Add(hoSo);
                }
                reader.Close();
                connection.Close();
            }

            return hoSoList;
        }

        public void AddHoSoTuyenDung(hosotuyendungdto hoSo)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("INSERT INTO HoSoTuyenDung VALUES(@MaHoSoTuyenDung, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @Email, @SDT, @TrinhDo, @MoTaBangCap, @KyTuyenDung, 1)", connection);
                command.Parameters.AddWithValue("@MaHoSoTuyenDung", hoSo.MaHoSoTuyenDung);
                command.Parameters.AddWithValue("@HoTen", hoSo.HoTen);
                command.Parameters.AddWithValue("@NgaySinh", hoSo.NgaySinh);
                command.Parameters.AddWithValue("@GioiTinh", hoSo.GioiTinh);
                command.Parameters.AddWithValue("@DiaChi", hoSo.DiaChi);
                command.Parameters.AddWithValue("@Email", hoSo.Email);
                command.Parameters.AddWithValue("@SDT", hoSo.SDT);
                command.Parameters.AddWithValue("@TrinhDo", hoSo.TrinhDo);
                command.Parameters.AddWithValue("@MoTaBangCap", hoSo.MoTaBangCap);
                command.Parameters.AddWithValue("@KyTuyenDung", hoSo.KyTuyenDung);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateHoSoTuyenDung(hosotuyendungdto hoSo)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE HoSoTuyenDung SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, Email = @Email, SDT = @SDT, TrinhDo = @TrinhDo, MoTaBangCap = @MoTaBangCap, KyTuyenDung = @KyTuyenDung, TrangThai = 1 WHERE MaHoSoTuyenDung = @MaHoSoTuyenDung", connection);
                command.Parameters.AddWithValue("@MaHoSoTuyenDung", hoSo.MaHoSoTuyenDung);
                command.Parameters.AddWithValue("@HoTen", hoSo.HoTen);
                command.Parameters.AddWithValue("@NgaySinh", hoSo.NgaySinh);
                command.Parameters.AddWithValue("@GioiTinh", hoSo.GioiTinh);
                command.Parameters.AddWithValue("@DiaChi", hoSo.DiaChi);
                command.Parameters.AddWithValue("@Email", hoSo.Email);
                command.Parameters.AddWithValue("@SDT", hoSo.SDT);
                command.Parameters.AddWithValue("@TrinhDo", hoSo.TrinhDo);
                command.Parameters.AddWithValue("@MoTaBangCap", hoSo.MoTaBangCap);
                command.Parameters.AddWithValue("@KyTuyenDung", hoSo.KyTuyenDung);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void DeleteHoSoTuyenDung(string MaHoSoTuyenDung)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Xóa phòng ban theo mã phòng ban (MaPhongBan)
                SqlCommand command = new SqlCommand("UPDATE HoSoTuyenDung SET TrangThai = 0 WHERE MaHoSoTuyenDung = @MaHoSoTuyenDung", connection);
                command.Parameters.AddWithValue("@MaHoSoTuyenDung", MaHoSoTuyenDung);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
