using WinFormsApp1.connect;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Collections;
using WinFormsApp1.DTO;

namespace WinFormsApp1.DAO
{
    internal class phucloidao
    {
        private ketnoi connectObj = new ketnoi();

        public phucloidao() { }

        public List<phucloidto> GetPhucLoi()
        {
            List<phucloidto> projects = new List<phucloidto>();

            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("SELECT * FROM PhucLoi WHERE TrangThai = 1", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    phucloidto project = new phucloidto
                    {
                        MaPhucLoi = reader["MaPhucLoi"].ToString(),
                        TenPhucLoi = reader["TenPhucLoi"].ToString(),
                        MoTa = reader["MoTa"].ToString(),
                        GiaTriPhucLoi = reader["GiaTriPhucLoi"] != DBNull.Value
                        ? Convert.ToInt32(reader["GiaTriPhucLoi"]): 0,
                        TrangThai = Convert.ToInt32(reader["TrangThai"])
                    };
                    projects.Add(project);
                }
                reader.Close();
                connection.Close();
                return projects;
            }
        }

        public void AddPhucLoi(phucloidto project)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                SqlCommand command = new SqlCommand("INSERT INTO PhucLoi VALUES(@MaPhucLoi, @TenPhucLoi, @MoTa, @GiaTriPhucLoi, @TrangThai)", connection);
                command.Parameters.AddWithValue("@MaPhucLoi", project.MaPhucLoi);
                command.Parameters.AddWithValue("@TenPhucLoi", project.TenPhucLoi);
                command.Parameters.AddWithValue("@MoTa", project.MoTa);
                command.Parameters.AddWithValue("@GiaTriPhucLoi", project.GiaTriPhucLoi);
                command.Parameters.AddWithValue("@TrangThai", project.TrangThai);
                command.ExecuteNonQuery();
            }
        }

        public void UpdatePhucLoi(phucloidto project)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                SqlCommand command = new SqlCommand("UPDATE PhucLoi SET TenPhucLoi = @TenPhucLoi, MoTa = @MoTa, GiaTriPhucLoi = @GiaTriPhucLoi, TrangThai = @TrangThai WHERE MaPhucLoi = @MaPhucLoi", connection);
                command.Parameters.AddWithValue("@MaPhucLoi", project.MaPhucLoi);
                command.Parameters.AddWithValue("@TenPhucLoi", project.TenPhucLoi);
                command.Parameters.AddWithValue("@MoTa", project.MoTa);;
                command.Parameters.AddWithValue("@GiaTriPhucLoi", project.GiaTriPhucLoi);
                command.Parameters.AddWithValue("@TrangThai", project.TrangThai);
                command.ExecuteNonQuery();
            }
        }

        public void DeletePhucLoi(string maPhucLoi)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                
                SqlCommand command = new SqlCommand("DELETE FROM PhucLoi WHERE MaPhucLoi = @MaPhucLoi", connection);
                command.Parameters.AddWithValue("@MaPhucLoi", maPhucLoi);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
