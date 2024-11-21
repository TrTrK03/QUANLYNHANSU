using WinFormsApp1.connect;
using WinFormsApp1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace WinFormsApp1.DAO
{
    internal class nhanviendao
    {
        private ketnoi connectObj = new ketnoi();
        public nhanviendao() { }
       
        public List<nhanviendto> GetNhanVien()
        {
            List<nhanviendto> employees = new List<nhanviendto>();

            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM NhanVien";
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        nhanviendto employee = new nhanviendto
                        {
                            MaNhanVien = reader["MaNhanVien"].ToString(),
                            HoTen = reader["HoTen"].ToString(),
                            NgaySinh = Convert.ToString(reader["ngaysinh"]),
                            GioiTinh = reader["GioiTinh"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            Email = reader["Email"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            NguoiQuanLy = reader["NguoiQuanLy"].ToString(),
                            PhongBan = reader["PhongBan"].ToString(),
                            ChucVu= reader["ChucVu"].ToString(),
                            HoSoGioiThieu = reader["HoSoGioiThieu"].ToString(),
                            TrangThai = Convert.ToInt32(reader["TrangThai"])
                            
                            
                        };
                        employees.Add(employee);
                    }
                reader.Close();
                connection.Close();
                return employees;
            }
        }

        public void AddEmployee(nhanviendto employee)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                SqlCommand command = new SqlCommand("INSERT INTO NhanVien VALUES(@MaNhanVien, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @Email, @SDT, @NguoiQuanLy, @PhongBan, @ChucVu, @HoSoGioiThieu, @TrangThai)", connection);

                // Sử dụng SqlParameter với kiểu dữ liệu rõ ràng
                command.Parameters.Add(new SqlParameter("@MaNhanVien", SqlDbType.NVarChar)).Value = employee.MaNhanVien;
                command.Parameters.Add(new SqlParameter("@HoTen", SqlDbType.NVarChar)).Value = employee.HoTen;
                command.Parameters.Add(new SqlParameter("@NgaySinh", SqlDbType.Date)).Value = employee.NgaySinh;
                command.Parameters.Add(new SqlParameter("@GioiTinh", SqlDbType.NVarChar)).Value = employee.GioiTinh;
                command.Parameters.Add(new SqlParameter("@DiaChi", SqlDbType.NVarChar)).Value = employee.DiaChi;
                command.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar)).Value = employee.Email;
                command.Parameters.Add(new SqlParameter("@SDT", SqlDbType.NVarChar)).Value = employee.SDT;
                command.Parameters.Add(new SqlParameter("@NguoiQuanLy", SqlDbType.NVarChar)).Value = (object)employee.NguoiQuanLy ?? DBNull.Value; // Xử lý NULL
                command.Parameters.Add(new SqlParameter("@PhongBan", SqlDbType.NVarChar)).Value = (object)employee.PhongBan ?? DBNull.Value; // Xử lý NULL
                command.Parameters.Add(new SqlParameter("@ChucVu", SqlDbType.NVarChar)).Value = employee.ChucVu;
                command.Parameters.Add(new SqlParameter("@HoSoGioiThieu", SqlDbType.NVarChar)).Value = (object)employee.HoSoGioiThieu ?? DBNull.Value; // Xử lý NULL
                command.Parameters.Add(new SqlParameter("@TrangThai", SqlDbType.Int)).Value = employee.TrangThai;

                // Thực thi lệnh
                command.ExecuteNonQuery();
            }
        }

        public void UpdateEmployee(nhanviendto employee)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE NhanVien SET HoTen = @HoTen, ngaysinh = @NgaySinh,  GioiTinh = @GioiTinh, DiaChi=@DiaChi, SDT = @SDT, Email = @Email, NguoiQuanLy=@NguoiQuanLy, TrangThai = @TrangThai, PhongBan=@PhongBan, ChucVu=@ChucVu, HoSoGioiThieu=@HoSoGioiThieu WHERE MaNhanVien = @MaNhanVien";
                command.Parameters.Add(new SqlParameter("@MaNhanVien", SqlDbType.NVarChar)).Value = employee.MaNhanVien;
                command.Parameters.Add(new SqlParameter("@HoTen", SqlDbType.NVarChar)).Value = employee.HoTen;
                command.Parameters.Add(new SqlParameter("@NgaySinh", SqlDbType.Date)).Value = employee.NgaySinh;
                command.Parameters.Add(new SqlParameter("@GioiTinh", SqlDbType.NVarChar)).Value = employee.GioiTinh;
                command.Parameters.Add(new SqlParameter("@DiaChi", SqlDbType.NVarChar)).Value = employee.DiaChi;
                command.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar)).Value = employee.Email;
                command.Parameters.Add(new SqlParameter("@SDT", SqlDbType.NVarChar)).Value = employee.SDT;
                command.Parameters.Add(new SqlParameter("@NguoiQuanLy", SqlDbType.NVarChar)).Value = (object)employee.NguoiQuanLy ?? DBNull.Value; // Xử lý NULL
                command.Parameters.Add(new SqlParameter("@PhongBan", SqlDbType.NVarChar)).Value = (object)employee.PhongBan ?? DBNull.Value; // Xử lý NULL
                command.Parameters.Add(new SqlParameter("@ChucVu", SqlDbType.NVarChar)).Value = employee.ChucVu;
                command.Parameters.Add(new SqlParameter("@HoSoGioiThieu", SqlDbType.NVarChar)).Value = (object)employee.HoSoGioiThieu ?? DBNull.Value; // Xử lý NULL
                command.Parameters.Add(new SqlParameter("@TrangThai", SqlDbType.Int)).Value = employee.TrangThai;

                command.Connection = connection;
                command.ExecuteNonQuery();

            }
        }
        public ArrayList SearchEmployeeByID(string keyword)
        {
            ArrayList employees = new ArrayList();
            using (SqlConnection connection = connectObj.connection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM nhanvien WHERE MaNhanVien LIKE @Keyword", connection);
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    nhanviendto employee = new nhanviendto
                    {
                        MaNhanVien = reader["MaNhanVien"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                        NgaySinh = Convert.ToString(reader["ngaysinh"]),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        Email = reader["Email"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        NguoiQuanLy = reader["NguoiQuanLy"].ToString(),
                        PhongBan = reader["PhongBan"].ToString(),
                        ChucVu = reader["ChucVu"].ToString(),
                        HoSoGioiThieu = reader["HoSoGioiThieu"].ToString(),
                        TrangThai = Convert.ToInt32(reader["TrangThai"])
                    };
                    employees.Add(employee);
                }
                reader.Close();
            }
            return employees;
        }
        public ArrayList SearchEmployeeByName(string keyword)
        {
            ArrayList employees = new ArrayList();
            using (SqlConnection connection = connectObj.connection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM NhanVien WHERE HoTen LIKE @Keyword", connection);
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    nhanviendto employee = new nhanviendto
                    {
                        MaNhanVien = reader["MaNhanVien"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                        NgaySinh = Convert.ToString(reader["ngaysinh"]),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        Email = reader["Email"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        NguoiQuanLy = reader["NguoiQuanLy"].ToString(),
                        PhongBan = reader["PhongBan"].ToString(),
                        ChucVu = reader["ChucVu"].ToString(),
                        HoSoGioiThieu = reader["HoSoGioiThieu"].ToString(),
                        TrangThai = Convert.ToInt32(reader["TrangThai"])

                    };
                    employees.Add(employee);
                }
                reader.Close();
            }
            return employees;
        }
        public ArrayList SearchEmployeeByPhoneNumber(string keyword)
        {
            ArrayList employees = new ArrayList();
            using (SqlConnection connection = connectObj.connection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM NhanVien WHERE SDT LIKE @Keyword OR Email LIKE @Keyword", connection);
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                SqlDataReader reader = command.ExecuteReader();
               
                while (reader.Read())
                {
                    nhanviendto employee = new nhanviendto
                    {
                        MaNhanVien = reader["MaNhanVien"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                        NgaySinh = Convert.ToString(reader["ngaysinh"]),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        Email = reader["Email"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        NguoiQuanLy = reader["NguoiQuanLy"].ToString(),
                        PhongBan = reader["PhongBan"].ToString(),
                        ChucVu = reader["ChucVu"].ToString(),
                        HoSoGioiThieu = reader["HoSoGioiThieu"].ToString(),
                        TrangThai = Convert.ToInt32(reader["TrangThai"])

                    };
                    employees.Add(employee);
                }
                reader.Close();
            }
            return employees;
        }


        public void HideEmployee(nhanviendto employee)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE NhanVien SET TrangThai = 0 WHERE MaNhanVien = @MaNhanVien";
                command.Parameters.Add(new SqlParameter("@MaNhanVien", SqlDbType.NVarChar)).Value = employee.MaNhanVien;
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }

       

        //public List<string> LoadMaTK()
        //{
        //    List<string> userIDs = new List<string>();
        //    using (SqlConnection connection = connectObj.connection())
        //    {
        //        SqlCommand command = new SqlCommand("SELECT UserID FROM TaiKhoan WHERE TrangThai = 0", connection);
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            userIDs.Add(reader["UserID"].ToString());
        //        }
        //        reader.Close();
        //    }
        //    return userIDs;
        //}

        //public void ChangeStateHidden(nhanviendto employee)
        //{
        //    using (SqlConnection connection = connectObj.connection())
        //    {
        //        SqlCommand command = new SqlCommand("UPDATE TaiKhoan SET TrangThai = 0 FROM NhanVien JOIN TaiKhoan ON NhanVien.maTK = TaiKhoan.UserID WHERE NhanVien.maNV = @MaNV", connection);
        //        command.Parameters.AddWithValue("@MaNhanVien", employee.MaNhanVien);
        //        command.ExecuteNonQuery();
        //    }
        //}

        //public void ChangeStateCurrent(nhanviendto employee)
        //{
        //    using (SqlConnection connection = connectObj.connection())
        //    {
        //        SqlCommand command = new SqlCommand("UPDATE TaiKhoan SET TrangThai = 1 FROM NhanVien JOIN TaiKhoan ON NhanVien.maTK = TaiKhoan.UserID WHERE NhanVien.maNV = @MaNV", connection);
        //        command.Parameters.AddWithValue("@MaNhanVien", employee.MaNhanVien);
        //        command.ExecuteNonQuery();
        //    }
        //}

    }
}
