using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WinFormsApp1.DTO;
using WinFormsApp1.connect;
using System.Data;

namespace WinFormsApp1.DAO
{
    public class khenThuongDAO
    {
        private ketnoi ketnoi = new ketnoi();

        public khenThuongDAO()
        {
        }

        public List<khenThuongDTO> getListReward()
        {
            List<khenThuongDTO> listKhenThuong = new List<khenThuongDTO>();
            using (SqlConnection connection = ketnoi.connection())
            {
                // Mở kết nối nếu chưa mở
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Thực thi câu lệnh SQL để lấy dữ liệu từ bảng KhenThuong
                SqlCommand command = new SqlCommand("SELECT * FROM KhenThuong WHERE TrangThai = 1", connection);
                SqlDataReader reader = command.ExecuteReader();

                // Đọc dữ liệu từ SqlDataReader
                while (reader.Read())
                {
                    // Kiểm tra các trường có phải là DBNull không trước khi gán
                    string maKhenThuong = reader["MaKhenThuong"] != DBNull.Value ? reader["MaKhenThuong"].ToString() : string.Empty;
                    string maNhanVien = reader["MaNhanVien"] != DBNull.Value ? reader["MaNhanVien"].ToString() : string.Empty;
                    string loaiKhenThuong = reader["LoaiKhenThuong"] != DBNull.Value ? reader["LoaiKhenThuong"].ToString() : string.Empty;
                    string chiTietKhenThuong = reader["ChiTietKhenThuong"] != DBNull.Value ? reader["ChiTietKhenThuong"].ToString() : string.Empty;
                    int giaTriKhenThuong = reader["GiaTriKhenThuong"] != DBNull.Value ? Convert.ToInt32(reader["GiaTriKhenThuong"]) : 0;
                    DateTime ngayKhenThuong = reader["NgayKhenThuong"] != DBNull.Value ? Convert.ToDateTime(reader["NgayKhenThuong"]) : DateTime.MinValue;
                    int trangThai = reader["TrangThai"] != DBNull.Value ? Convert.ToInt32(reader["TrangThai"]) : 0;

                    // Tạo đối tượng khenThuongDTO với dữ liệu đã được kiểm tra
                    khenThuongDTO kt = new khenThuongDTO(
                        maKhenThuong, // MaKhenThuong kiểu string
                        maNhanVien,   // MaNhanVien kiểu string
                        loaiKhenThuong,
                        chiTietKhenThuong,
                        giaTriKhenThuong,
                        ngayKhenThuong,
                        trangThai
                    );

                    // Thêm vào danh sách
                    listKhenThuong.Add(kt);
                }

                // Đóng SqlDataReader và kết nối
                reader.Close();
                connection.Close();
            }

            return listKhenThuong;
        }

        public string GenerateNewRewardCode()
        {
            string newRewardCode = "KT0001";  // Mặc định giá trị mã khen thưởng

            SqlConnection connection = ketnoi.connection(); // Kết nối đến cơ sở dữ liệu
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open(); // Mở kết nối nếu chưa mở
                }

                // Truy vấn lấy mã khen thưởng mới nhất
                string query = "SELECT TOP 1 MaKhenThuong FROM KhenThuong ORDER BY MaKhenThuong DESC";
                SqlCommand command = new SqlCommand(query, connection);

                // Thực thi câu lệnh và lấy kết quả
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    string latestRewardCode = result.ToString();
                    if (latestRewardCode.StartsWith("KT"))
                    {
                        // Lấy phần số cuối của mã khen thưởng và tăng lên 1
                        string numberPart = latestRewardCode.Substring(2); // Lấy phần sau "KT"
                        int latestNumber = int.Parse(numberPart);
                        int newNumber = latestNumber + 1;

                        // Tạo mã khen thưởng mới với 4 chữ số
                        newRewardCode = "KT" + newNumber.ToString("D4");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy mã khen thưởng mới: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close(); // Đảm bảo kết nối được đóng
                }
            }

            return newRewardCode;
        }



        public bool addReward(khenThuongDTO reward)
        {
            SqlConnection connection = ketnoi.connection();
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Sử dụng query chuẩn
                string query = "INSERT INTO KhenThuong (MaKhenThuong, MaNhanVien, LoaiKhenThuong, ChiTietKhenThuong, GiaTriKhenThuong, NgayKhenThuong, TrangThai) " +
                               "VALUES (@MaKhenThuong, @MaNhanVien, @LoaiKhenThuong, @ChiTietKhenThuong, @GiaTriKhenThuong, @NgayKhenThuong, @TrangThai)";

                SqlCommand command = new SqlCommand(query, connection);

                // Thêm tham số vào câu lệnh SQL với SqlParameter để bảo đảm loại dữ liệu chính xác
                command.Parameters.Add(new SqlParameter("@MaKhenThuong", SqlDbType.NVarChar) { Value = reward.MaKhenThuong ?? (object)DBNull.Value });
                command.Parameters.Add(new SqlParameter("@MaNhanVien", SqlDbType.NVarChar) { Value = reward.MaNhanVien ?? (object)DBNull.Value });
                command.Parameters.Add(new SqlParameter("@LoaiKhenThuong", SqlDbType.NVarChar) { Value = reward.LoaiKhenThuong ?? (object)DBNull.Value });
                command.Parameters.Add(new SqlParameter("@ChiTietKhenThuong", SqlDbType.NVarChar) { Value = reward.ChiTietKhenThuong ?? (object)DBNull.Value });
                command.Parameters.Add(new SqlParameter("@GiaTriKhenThuong", SqlDbType.Int) { Value = reward.GiaTriKhenThuong > 0 ? reward.GiaTriKhenThuong : (object)DBNull.Value });
                command.Parameters.Add(new SqlParameter("@NgayKhenThuong", SqlDbType.DateTime) { Value = reward.NgayKhenThuong != DateTime.MinValue ? reward.NgayKhenThuong : (object)DBNull.Value });
                command.Parameters.Add(new SqlParameter("@TrangThai", SqlDbType.Int) { Value = reward.TrangThai });

                // Thực thi câu lệnh
                int result = command.ExecuteNonQuery();

                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm khen thưởng: " + ex.ToString());
                return false;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close(); // Đảm bảo kết nối được đóng
                }
            }
        }



        public List<KeyValuePair<string, string>> getEmployeeIdAndName()
        {
            List<KeyValuePair<string, string>> employeeList = new List<KeyValuePair<string, string>>();

            using (SqlConnection connection = ketnoi.connection())
            {
                try
                {
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    string query = "SELECT MaNhanVien, HoTen FROM NhanVien WHERE TrangThai = 1"; // Chỉ lấy nhân viên có trạng thái hoạt động (TrangThai = 1)

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string maNhanVien = reader["MaNhanVien"] != DBNull.Value ? reader["MaNhanVien"].ToString() : string.Empty;
                        string hoTen = reader["HoTen"] != DBNull.Value ? reader["HoTen"].ToString() : string.Empty;

                        employeeList.Add(new KeyValuePair<string, string>(maNhanVien, hoTen));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi lấy dữ liệu nhân viên: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return employeeList;
        }

        public List<string> getRewardTypes()
        {
            List<string> rewardTypes = new List<string>();

            using (SqlConnection connection = ketnoi.connection())
            {
                try
                {
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    string query = "SELECT DISTINCT LoaiKhenThuong FROM KhenThuong";  // DISTINCT để chỉ lấy các giá trị duy nhất

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string loaiKhenThuong = reader["LoaiKhenThuong"] != DBNull.Value ? reader["LoaiKhenThuong"].ToString() : string.Empty;

                        // Thêm giá trị LoaiKhenThuong vào danh sách
                        rewardTypes.Add(loaiKhenThuong);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi lấy dữ liệu loại khen thưởng: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return rewardTypes;
        }


        public bool deleteRewards(List<string> maKhenThuongList)
        {
            SqlConnection connection = ketnoi.connection();
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Khởi tạo biến cho số lượng khen thưởng đã xóa
                int deletedCount = 0;

                // Duyệt qua danh sách mã khen thưởng để xóa từng mã
                foreach (var maKhenThuong in maKhenThuongList)
                {
                    string query = "DELETE FROM KhenThuong WHERE MaKhenThuong = @MaKhenThuong";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Thêm tham số
                    command.Parameters.Add(new SqlParameter("@MaKhenThuong", SqlDbType.NVarChar) { Value = maKhenThuong });

                    // Thực thi câu lệnh
                    deletedCount += command.ExecuteNonQuery();
                }

                return deletedCount > 0;  // Trả về true nếu có ít nhất 1 khen thưởng bị xóa
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa khen thưởng: " + ex.Message);
                return false;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();  // Đảm bảo kết nối được đóng
                }
            }
        }

        public bool updateReward(khenThuongDTO reward)
        {
            SqlConnection connection = ketnoi.connection();
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();  // Mở kết nối nếu chưa mở
                }

                // Câu lệnh SQL để cập nhật khen thưởng
                string query = "UPDATE KhenThuong SET " +
                               "LoaiKhenThuong = @LoaiKhenThuong, " +
                               "ChiTietKhenThuong = @ChiTietKhenThuong, " +
                               "GiaTriKhenThuong = @GiaTriKhenThuong, " +
                               "NgayKhenThuong = @NgayKhenThuong, " +
                               "TrangThai = @TrangThai " +
                               "WHERE MaKhenThuong = @MaKhenThuong";

                // Tạo câu lệnh SQL với các tham số
                SqlCommand command = new SqlCommand(query, connection);

                // Thêm tham số vào câu lệnh SQL
                command.Parameters.Add(new SqlParameter("@LoaiKhenThuong", SqlDbType.NVarChar) { Value = reward.LoaiKhenThuong ?? (object)DBNull.Value });
                command.Parameters.Add(new SqlParameter("@ChiTietKhenThuong", SqlDbType.NVarChar) { Value = reward.ChiTietKhenThuong ?? (object)DBNull.Value });
                command.Parameters.Add(new SqlParameter("@GiaTriKhenThuong", SqlDbType.Int) { Value = reward.GiaTriKhenThuong });
                command.Parameters.Add(new SqlParameter("@NgayKhenThuong", SqlDbType.DateTime) { Value = reward.NgayKhenThuong });
                command.Parameters.Add(new SqlParameter("@TrangThai", SqlDbType.Int) { Value = reward.TrangThai });
                command.Parameters.Add(new SqlParameter("@MaKhenThuong", SqlDbType.NVarChar) { Value = reward.MaKhenThuong });

                // Thực thi câu lệnh và kiểm tra kết quả
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;  // Trả về true nếu có ít nhất một bản ghi được cập nhật
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật khen thưởng: " + ex.Message);
                return false;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();  // Đảm bảo kết nối được đóng
                }
            }
        }
        public List<khenThuongDTO> searchReward(string maNhanVien, string loaiKhenThuong)
        {
            List<khenThuongDTO> result = new List<khenThuongDTO>();

            using (SqlConnection connection = ketnoi.connection())
            {
                try
                {
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();  // Mở kết nối nếu chưa mở
                    }

                    // Câu lệnh SQL để tìm kiếm khen thưởng
                    string query = "SELECT MaKhenThuong, MaNhanVien, LoaiKhenThuong, ChiTietKhenThuong, GiaTriKhenThuong, NgayKhenThuong, TrangThai FROM KhenThuong WHERE 1=1";

                    // Kiểm tra điều kiện mã nhân viên
                    if (!string.IsNullOrEmpty(maNhanVien))
                    {
                        query += " AND MaNhanVien = @MaNhanVien";
                    }

                    // Kiểm tra điều kiện loại khen thưởng
                    if (!string.IsNullOrEmpty(loaiKhenThuong) && loaiKhenThuong != "Chọn loại khen thưởng")
                    {
                        query += " AND LoaiKhenThuong = @LoaiKhenThuong";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        if (!string.IsNullOrEmpty(maNhanVien))
                        {
                            command.Parameters.Add(new SqlParameter("@MaNhanVien", SqlDbType.NVarChar) { Value = maNhanVien });
                        }
                        if (!string.IsNullOrEmpty(loaiKhenThuong) && loaiKhenThuong != "Chọn loại khen thưởng")
                        {
                            command.Parameters.Add(new SqlParameter("@LoaiKhenThuong", SqlDbType.NVarChar) { Value = loaiKhenThuong });
                        }

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Đọc dữ liệu từ SqlDataReader và tạo danh sách các đối tượng DTO
                            while (reader.Read())
                            {
                                khenThuongDTO reward = new khenThuongDTO(
                                    reader["MaKhenThuong"] as string ?? string.Empty,
                                    reader["MaNhanVien"] as string ?? string.Empty,
                                    reader["LoaiKhenThuong"] as string ?? string.Empty,
                                    reader["ChiTietKhenThuong"] as string ?? string.Empty,
                                    reader["GiaTriKhenThuong"] as int? ?? 0,
                                    reader["NgayKhenThuong"] as DateTime? ?? DateTime.MinValue,
                                    reader["TrangThai"] as int? ?? 0
                                );

                                result.Add(reward);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn dữ liệu: " + ex.Message);
                }
                finally
                {
                    connection.Close();  // Đảm bảo kết nối được đóng
                }
            }

            return result;  // Trả về danh sách các đối tượng RewardDTO
        }

    }
}
