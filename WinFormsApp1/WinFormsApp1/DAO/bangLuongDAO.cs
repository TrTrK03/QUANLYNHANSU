using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WinFormsApp1.DTO;
using WinFormsApp1.connect;

namespace WinFormsApp1.DAO
{
    public class bangLuongDAO
    {
        private ketnoi connectObj = new ketnoi();

        public bangLuongDAO() { }

        public List<bangLuongDTO> GetLuong()
        {
            List<bangLuongDTO> salaries = new List<bangLuongDTO>();

            using (SqlConnection connection = connectObj.connection())
            {
                // Mở kết nối nếu chưa mở
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Câu lệnh SQL với JOIN để lấy thông tin từ cả bảng Luong và bảng NhanVien
                string sqlQuery = @"
            SELECT l.MaNhanVien, l.ThangNam, l.PhuCap, l.KhauTru, l.LuongThucNhan, n.HoTen
            FROM BangLuong l
            INNER JOIN NhanVien n ON l.MaNhanVien = n.MaNhanVien";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Đọc dữ liệu từ SqlDataReader
                while (reader.Read())
                {
                    // Kiểm tra các trường có phải là DBNull không trước khi gán
                    string maNhanVien = reader["MaNhanVien"] != DBNull.Value ? reader["MaNhanVien"].ToString() : string.Empty;
                    DateTime thangNam = reader["ThangNam"] != DBNull.Value ? Convert.ToDateTime(reader["ThangNam"]) : DateTime.MinValue;
                    int phuCap = reader["PhuCap"] != DBNull.Value ? Convert.ToInt32(reader["PhuCap"]) : 0;
                    int khauTru = reader["KhauTru"] != DBNull.Value ? Convert.ToInt32(reader["KhauTru"]) : 0;
                    int luongThucNhan = reader["LuongThucNhan"] != DBNull.Value ? Convert.ToInt32(reader["LuongThucNhan"]) : 0;
                    string hoTen = reader["HoTen"] != DBNull.Value ? reader["HoTen"].ToString() : string.Empty;

                    // Tạo đối tượng bangLuongDTO với dữ liệu đã được kiểm tra
                    bangLuongDTO luong = new bangLuongDTO
                    {
                        MaNhanVien = maNhanVien,
                        ThangNam = thangNam,
                        PhuCap = phuCap,
                        KhauTru = khauTru,
                        LuongThucNhan = luongThucNhan,
                        HoTen = hoTen  // Thêm trường HoTen vào đối tượng DTO
                    };

                    // Thêm vào danh sách
                    salaries.Add(luong);
                }

                // Đóng SqlDataReader và kết nối
                reader.Close();
                connection.Close();
            }

            // Trả về danh sách salaries
            return salaries;
        }

        public List<nhanviendto> getListEmployeeNotSalary()
        {
            List<nhanviendto> employeesWithoutSalary = new List<nhanviendto>();

            using (SqlConnection connection = connectObj.connection())
            {
                // Mở kết nối nếu chưa mở
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Câu lệnh SQL với LEFT JOIN để lấy tất cả nhân viên chưa có trong bảng Lương
                string sqlQuery = @"
                    SELECT n.MaNhanVien, n.HoTen
                    FROM NhanVien n
                    LEFT JOIN BangLuong l ON n.MaNhanVien = l.MaNhanVien
                    WHERE l.MaNhanVien IS NULL";  // Lọc ra các nhân viên chưa có trong bảng Lương

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Đọc dữ liệu từ SqlDataReader
                while (reader.Read())
                {
                    // Kiểm tra các trường có phải là DBNull không trước khi gán
                    string maNhanVien = reader["MaNhanVien"] != DBNull.Value ? reader["MaNhanVien"].ToString() : string.Empty;
                    string hoTen = reader["HoTen"] != DBNull.Value ? reader["HoTen"].ToString() : string.Empty;

                    // Tạo đối tượng nhanviendto với dữ liệu đã được kiểm tra
                    nhanviendto employee = new nhanviendto
                    {
                        MaNhanVien = maNhanVien,
                        HoTen = hoTen
                    };

                    // Thêm vào danh sách
                    employeesWithoutSalary.Add(employee);
                }

                // Đóng SqlDataReader và kết nối
                reader.Close();
                connection.Close();
            }

            // Trả về danh sách nhân viên chưa có trong bảng lương
            return employeesWithoutSalary;
        }


        public int GetLuongCoBanByMaNhanVien(string maNhanVien)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                // Mở kết nối nếu chưa mở
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Câu lệnh SQL để lấy lương cơ bản từ bảng ChucVu
                string sqlQuery = @"
                SELECT c.LuongCoBan
                FROM NhanVien n
                INNER JOIN ChucVu c ON c.MaChucVu = n.ChucVu
                WHERE n.MaNhanVien = @MaNhanVien";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

                // Thực thi câu lệnh và lấy giá trị lương cơ bản
                var result = command.ExecuteScalar();

                // Nếu có giá trị, trả về lương cơ bản
                if (result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    throw new Exception("Không tìm thấy lương cơ bản cho nhân viên này.");
                }
            }
        }


        // Phương thức thêm bảng lương vào cơ sở dữ liệu
        public bool AddLuong(bangLuongDTO salary)
        {
            try
            {
                // Câu lệnh SQL để thêm bảng lương vào cơ sở dữ liệu
                string query = @"
            INSERT INTO BangLuong (MaNhanVien, ThangNam, PhuCap, KhauTru, LuongThucNhan)
            VALUES (@MaNhanVien, @ThangNam, @PhuCap, @KhauTru, @LuongThucNhan)";

                // Sử dụng kết nối từ connectObj
                using (SqlConnection connection = connectObj.connection())
                {
                    // Mở kết nối nếu chưa mở
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    // Tạo lệnh SQL và thêm các tham số
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaNhanVien", salary.MaNhanVien);
                    command.Parameters.AddWithValue("@ThangNam", salary.ThangNam);
                    command.Parameters.AddWithValue("@PhuCap", salary.PhuCap);
                    command.Parameters.AddWithValue("@KhauTru", salary.KhauTru);
                    command.Parameters.AddWithValue("@LuongThucNhan", salary.LuongThucNhan);

                    // Thực thi lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                    int rowsAffected = command.ExecuteNonQuery();

                    // Nếu có ít nhất 1 dòng bị ảnh hưởng, trả về true (thêm thành công)
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo nếu có lỗi trong quá trình thêm
                MessageBox.Show("Lỗi khi thêm bảng lương: " + ex.Message);
                return false; // Trả về false nếu có lỗi
            }
        }


        public List<bangLuongDTO> SearchLuongByMaNhanVien(string keyword)
        {
            List<bangLuongDTO> salaries = new List<bangLuongDTO>();

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
                    bangLuongDTO salary = new bangLuongDTO
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
        public bool UpdateLuong(bangLuongDTO updatedSalary)
        {
            try
            {
                // Câu lệnh SQL cập nhật bảng lương
                string query = @"UPDATE BangLuong
                         SET ThangNam = @ThangNam, PhuCap = @PhuCap, 
                             KhauTru = @KhauTru, LuongThucNhan = @LuongThucNhan
                         WHERE MaNhanVien = @MaNhanVien";

                // Sử dụng đối tượng kết nối đã có từ connectObj
                using (SqlConnection connection = connectObj.connection())
                {
                    // Mở kết nối nếu chưa mở
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    // Tạo lệnh SQL và thêm các tham số
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaNhanVien", updatedSalary.MaNhanVien);
                    command.Parameters.AddWithValue("@ThangNam", updatedSalary.ThangNam);
                    command.Parameters.AddWithValue("@PhuCap", updatedSalary.PhuCap);
                    command.Parameters.AddWithValue("@KhauTru", updatedSalary.KhauTru);
                    command.Parameters.AddWithValue("@LuongThucNhan", updatedSalary.LuongThucNhan);

                    // Thực thi lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                    int rowsAffected = command.ExecuteNonQuery();

                    // Trả về true nếu có ít nhất 1 dòng bị ảnh hưởng
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo
                MessageBox.Show("Lỗi khi cập nhật vào cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }
        public bool DeleteLuong(string maNhanVien, DateTime thangNam)
        {
            try
            {
                // Câu lệnh SQL để xóa bảng lương theo mã nhân viên và tháng năm
                string query = "DELETE FROM BangLuong WHERE MaNhanVien = @MaNhanVien AND ThangNam = @ThangNam";

                // Sử dụng kết nối từ connectObj
                using (SqlConnection connection = connectObj.connection())
                {
                    // Mở kết nối nếu chưa mở
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    // Tạo lệnh SQL và thêm tham số
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    command.Parameters.AddWithValue("@ThangNam", thangNam);

                    // Thực thi câu lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                    int rowsAffected = command.ExecuteNonQuery();

                    // Trả về true nếu có ít nhất 1 dòng bị xóa
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo
                MessageBox.Show("Lỗi khi xóa bảng lương: " + ex.Message);
                return false;
            }
        }

        public List<bangLuongDTO> SearchLuong(string searchQuery)
        {
            List<bangLuongDTO> result = new List<bangLuongDTO>();

            using (SqlConnection connection = connectObj.connection())
            {
                // Mở kết nối nếu chưa mở
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Câu lệnh SQL để tìm kiếm theo mã nhân viên hoặc tên nhân viên
                string sqlQuery = @"
            SELECT l.MaNhanVien, l.ThangNam, l.PhuCap, l.KhauTru, l.LuongThucNhan, n.HoTen
            FROM BangLuong l
            INNER JOIN NhanVien n ON l.MaNhanVien = n.MaNhanVien
            WHERE l.MaNhanVien LIKE @searchQuery OR n.HoTen LIKE @searchQuery";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");

                SqlDataReader reader = command.ExecuteReader();

                // Đọc dữ liệu từ SqlDataReader
                while (reader.Read())
                {
                    // Kiểm tra các trường có phải là DBNull không trước khi gán
                    string maNhanVien = reader["MaNhanVien"] != DBNull.Value ? reader["MaNhanVien"].ToString() : string.Empty;
                    DateTime thangNam = reader["ThangNam"] != DBNull.Value ? Convert.ToDateTime(reader["ThangNam"]) : DateTime.MinValue;
                    int phuCap = reader["PhuCap"] != DBNull.Value ? Convert.ToInt32(reader["PhuCap"]) : 0;
                    int khauTru = reader["KhauTru"] != DBNull.Value ? Convert.ToInt32(reader["KhauTru"]) : 0;
                    int luongThucNhan = reader["LuongThucNhan"] != DBNull.Value ? Convert.ToInt32(reader["LuongThucNhan"]) : 0;
                    string hoTen = reader["HoTen"] != DBNull.Value ? reader["HoTen"].ToString() : string.Empty;

                    // Tạo đối tượng bangLuongDTO với dữ liệu đã được kiểm tra
                    bangLuongDTO salary = new bangLuongDTO
                    {
                        MaNhanVien = maNhanVien,
                        ThangNam = thangNam,
                        PhuCap = phuCap,
                        KhauTru = khauTru,
                        LuongThucNhan = luongThucNhan,
                        HoTen = hoTen  // Thêm trường HoTen vào đối tượng DTO
                    };

                    // Thêm vào danh sách kết quả
                    result.Add(salary);
                }

                // Đóng SqlDataReader và kết nối
                reader.Close();
                connection.Close();
            }

            return result;
        }


    }



}
