using WinFormsApp1.connect;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Collections;
using WinFormsApp1.DTO;

namespace WinFormsApp1.DAO
{
    internal class duandao
    {
        private ketnoi connectObj = new ketnoi();

        public duandao() { }

        public List<duandto> GetDuAn()
        {
            List<duandto> projects = new List<duandto>();

            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("SELECT * FROM DuAn WHERE TrangThai = 1", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    duandto project = new duandto
                    {
                        MaDuAn = reader["MaDuAn"].ToString(),
                        TenDuAn = reader["TenDuAn"].ToString(),
                        MoTa = reader["MoTa"].ToString(),
                        NgayBatDau = Convert.ToDateTime(reader["NgayBatDau"]),
                        NgayKetThuc = Convert.ToDateTime(reader["NgayKetThuc"]),
                        QuanLyDuAn = reader["QuanLyDuAn"].ToString(),
                        PhongBanPhuTrach = reader["PhongBanPhuTrach"].ToString(),
                        TrangThai = Convert.ToInt32(reader["TrangThai"])
                    };
                    projects.Add(project);
                }
                reader.Close();
                connection.Close();
                return projects;
            }
        }

        public void AddDuAn(duandto project)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                SqlCommand command = new SqlCommand("INSERT INTO DuAn VALUES(@MaDuAn, @TenDuAn, @MoTa, @NgayBatDau, @NgayKetThuc, @QuanLyDuAn, @PhongBanPhuTrach, @TrangThai)", connection);
                command.Parameters.AddWithValue("@MaDuAn", project.MaDuAn);
                command.Parameters.AddWithValue("@TenDuAn", project.TenDuAn);
                command.Parameters.AddWithValue("@MoTa", project.MoTa);
                command.Parameters.AddWithValue("@NgayBatDau", project.NgayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", project.NgayKetThuc);
                command.Parameters.AddWithValue("@QuanLyDuAn", project.QuanLyDuAn);
                command.Parameters.AddWithValue("@PhongBanPhuTrach", project.PhongBanPhuTrach);
                command.Parameters.AddWithValue("@TrangThai", project.TrangThai);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateDuAn(duandto project)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                SqlCommand command = new SqlCommand("UPDATE DuAn SET TenDuAn = @TenDuAn, MoTa = @MoTa, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, QuanLyDuAn = @QuanLyDuAn, PhongBanPhuTrach = @PhongBanPhuTrach, TrangThai = @TrangThai WHERE MaDuAn = @MaDuAn", connection);
                command.Parameters.AddWithValue("@MaDuAn", project.MaDuAn);
                command.Parameters.AddWithValue("@TenDuAn", project.TenDuAn);
                command.Parameters.AddWithValue("@MoTa", project.MoTa);
                command.Parameters.AddWithValue("@NgayBatDau", project.NgayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", project.NgayKetThuc);
                command.Parameters.AddWithValue("@QuanLyDuAn", project.QuanLyDuAn);
                command.Parameters.AddWithValue("@PhongBanPhuTrach", project.PhongBanPhuTrach);
                command.Parameters.AddWithValue("@TrangThai", project.TrangThai);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteDuAn(string maDuAn)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Xóa phòng ban theo mã phòng ban (MaDuAn)
                SqlCommand command = new SqlCommand("UPDATE DuAn SET TrangThai = 0 WHERE MaDuAN = @MaDuAn", connection);
                command.Parameters.AddWithValue("@MaDuAn", maDuAn);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
