using OfficeOpenXml.FormulaParsing.Ranges;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.connect;
using WinFormsApp1.DTO;

namespace WinFormsApp1.DAO
{
    internal class chamcongdao
    {
        private ketnoi connectObj = new ketnoi();
        public chamcongdao() { }

        public List<chamcongdto> GetChamCong()
        {
            List<chamcongdto> chamcongdtos = new List<chamcongdto>();
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM BangChamCong";
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    chamcongdto chamcong = new chamcongdto
                    {
                        MaBangChamCong = reader["MaBangChamCong"].ToString(),
                        Buoi = Convert.ToInt32(reader["Buoi"]),
                        GioVaoCa = reader["GioVaoCa"].ToString(),
                        Ngay = DateTime.Parse(reader["Ngay"].ToString()),
                        MaNhanVien = reader["MaNhanVien"].ToString(),


                    };
                    chamcongdtos.Add(chamcong);
                }
                reader.Close();
                connection.Close();
                return chamcongdtos;
            }
        }


        public List<chamcongdto> GetChamCong(int thang, int nam)
        {
            List<chamcongdto> chamcongdtos = new List<chamcongdto>();
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;

                // Câu truy vấn có điều kiện lọc theo tháng và năm
                command.CommandText = @"
                SELECT * 
                FROM BangChamCong
                WHERE MONTH(Ngay) = @Thang AND YEAR(Ngay) = @Nam";
                command.Connection = connection;

                // Thêm tham số cho truy vấn để tránh SQL Injection
                command.Parameters.AddWithValue("@Thang", thang);
                command.Parameters.AddWithValue("@Nam", nam);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    chamcongdto chamcong = new chamcongdto
                    {
                        MaBangChamCong = reader["MaBangChamCong"].ToString(),
                        Buoi = Convert.ToInt32(reader["Buoi"]),
                        GioVaoCa = reader["GioVaoCa"].ToString(),
                        Ngay = DateTime.Parse(reader["Ngay"].ToString()),
                        MaNhanVien = reader["MaNhanVien"].ToString(),
                    };
                    chamcongdtos.Add(chamcong);
                }

                reader.Close();
                connection.Close();
            }
            return chamcongdtos;
        }


        public void UpdateChamCong(chamcongdto chamcong)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE BangChamCong SET GioVaoCa = @GioVaoCa WHERE MaBangChamCong = @MaBangChamCong";
                command.Parameters.Add(new SqlParameter("@MaBangChamCong", SqlDbType.NVarChar)).Value = chamcong.MaBangChamCong;
                command.Parameters.Add(new SqlParameter("@GioVaoCa", SqlDbType.NVarChar)).Value = chamcong.GioVaoCa;
            
                command.Connection = connection;
                command.ExecuteNonQuery();

            }
        }

        public void DeleteChamCong(chamcongdto chamcong)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "DELETE FROM BangChamCong WHERE MaBangChamCong = @MaBangChamCong";
                command.Parameters.Add(new SqlParameter("@MaBangChamCong", SqlDbType.NVarChar)).Value = chamcong.MaBangChamCong;
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }


        private bool dunggio(int buoi, string giovaolam)
        {
            DateTime time = DateTime.Parse(giovaolam);
            DateTime sangmax = DateTime.Parse("07:30");
            DateTime sangmin = DateTime.Parse("06:00");
            DateTime chieumax = DateTime.Parse("13:30");
            DateTime chieumin = DateTime.Parse("12:30");
            if (buoi == 1)
            {
                if (time >= sangmin && time <= sangmax)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (buoi == 2)
            {
                if (time >= chieumin && time <= chieumax)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public List<chamcongdto> GetDSDungGio(bool True = true)
        {
            List<chamcongdto> chamcongdtos = new List<chamcongdto>();
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM BangChamCong";
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    chamcongdto chamcong = new chamcongdto
                    {
                        MaBangChamCong = reader["MaBangChamCong"].ToString(),
                        Buoi = Convert.ToInt32(reader["Buoi"]),
                        GioVaoCa = reader["GioVaoCa"].ToString(),
                        Ngay = DateTime.Parse(reader["Ngay"].ToString()),
                        MaNhanVien = reader["MaNhanVien"].ToString(),


                    };
                    if (dunggio(chamcong.Buoi, chamcong.GioVaoCa) == True)
                    {
                        chamcongdtos.Add(chamcong);
                    }
                }
                reader.Close();
                connection.Close();
                return chamcongdtos;
            }
        }

        public List<chamcongdto> GetDSDungGioCuaMaNV(string manv , bool True)
        {
            nhanviendto employee = new nhanviendto();
            List<chamcongdto> chamcongdtos = new List<chamcongdto>();
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM BangChamCong WHERE MaNhanVien = @MaNhanVien";
                command.Parameters.Add(new SqlParameter("@MaNhanVien", SqlDbType.NVarChar)).Value = manv;
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    chamcongdto chamcong = new chamcongdto
                    {
                        MaBangChamCong = reader["MaBangChamCong"].ToString(),
                        Buoi = Convert.ToInt32(reader["Buoi"]),
                        GioVaoCa = reader["GioVaoCa"].ToString(),
                        Ngay = DateTime.Parse(reader["Ngay"].ToString()),
                        MaNhanVien = reader["MaNhanVien"].ToString(),


                    };
                    if (dunggio(chamcong.Buoi, chamcong.GioVaoCa) == True)
                    {
                        chamcongdtos.Add(chamcong);
                    }
                }
                reader.Close();
                connection.Close();
                return chamcongdtos;
            }
        }

        public List<chamcongdto> GetDSTheoNgay(DateTime ngay, bool True)
        {
            
            List<chamcongdto> chamcongtheongay = new List<chamcongdto>();
            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM BangChamCong WHERE Ngay = @Ngay";
                command.Parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date)).Value = ngay;
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    chamcongdto chamcong = new chamcongdto
                    {
                        MaBangChamCong = reader["MaBangChamCong"].ToString(),
                        Buoi = Convert.ToInt32(reader["Buoi"]),
                        GioVaoCa = reader["GioVaoCa"].ToString(),
                        Ngay = DateTime.Parse(reader["Ngay"].ToString()),
                        MaNhanVien = reader["MaNhanVien"].ToString(),


                    };
                    if (dunggio(chamcong.Buoi, chamcong.GioVaoCa) == True)
                    {
                        chamcongtheongay.Add(chamcong);
                    }
                }
                reader.Close();
                connection.Close();
                return chamcongtheongay;


            }
        }

        public int SoChamCongDungGio(DateTime ngay, bool True )
        {
            int count = GetDSTheoNgay(ngay, True ).Count;
            return count;
        }







        public List<Image> BieuDoChamCongTheoTuan(int tuan, int thang , int nam)
        {
            
            List<Image> list = new List<Image>();
            


            for (int i = 2; i < 7; i++)
            {
                int ngay = GetNthWeekdayOfMonth(nam, thang, i-1, tuan);
                if (ngay <=0)
                {
                    Image image = new Bitmap(1, 1);
                    list.Add(image);
                }
                else
                {
                    //DateTime dateTime = new DateTime(nam, thang, ngay);
                    int dung = SoChamCongDungGio(new DateTime(nam, thang, ngay), true);
                    int sai = SoChamCongDungGio(new DateTime(nam, thang, ngay), false);
                    Image image = VeBieuDoChamCongTheoNgay(ngay, dung, sai);
                    list.Add(image);
                }
            }


            return list;
        }




        // Lấy ngày khi có thứ, tuần, tháng năm
        public int GetNthWeekdayOfMonth(int year, int month, int dayOfWeek, int weekNumber)
        {
            // Lấy ngày đầu tiên của tháng
            DateTime firstDayOfMonth = new DateTime(year, month, 1);

            // Tìm ngày đầu tiên của tháng khớp với dayOfWeek
            int offset = (int)dayOfWeek - (int)firstDayOfMonth.DayOfWeek;
            int day = 1 + offset + (weekNumber - 1) * 7;
            if (offset < 0)
            {
                offset += 7;

                // Tính ngày cụ thể
                day = 1 + offset + (weekNumber-2) * 7;
            }

            // Kiểm tra nếu ngày vượt quá số ngày trong tháng
            if (day > DateTime.DaysInMonth(year, month))
            {
                return 0;
            }

            return day;
        }
        


        private Bitmap VeBieuDoChamCongTheoNgay(int ngay, int dung, int sai)
        {
            int width = 200;  // Chiều rộng của đối tượng
            int height = 100; // Chiều cao của đối tượng

            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                // Tính tổng giá trị "Đúng" và "Sai"
                int total = dung + sai;

                // Tính tỷ lệ thu nhỏ (scale) nếu tổng vượt quá giới hạn chiều rộng
                float maxWidth = 180; // Chiều rộng tối đa khả dụng (bỏ khoảng cách và padding)
                float scale = total > maxWidth / 20 ? (float)maxWidth / (total * 20) : 1.0f;

                // Tính toán chiều rộng sau khi áp dụng tỷ lệ
                float dungWidth = dung * 20 * scale;
                float saiWidth = sai * 20 * scale;

                // Vẽ phần "Ngày"
                g.DrawString($"Ngày: {ngay}", new Font("Arial", 12), Brushes.Black, 10, 10);

                // Vẽ phần "Đúng"
                g.FillRectangle(Brushes.Green, 10, 40, dungWidth, 20);
                g.DrawRectangle(Pens.Black, 10, 40, dungWidth, 20);
                g.DrawString($"{dung}", new Font("Arial", 10), Brushes.White, 15, 42);

                // Vẽ phần "Sai"
                g.FillRectangle(Brushes.Red, 10 + dungWidth + 5, 40, saiWidth, 20);
                g.DrawRectangle(Pens.Black, 10 + dungWidth + 5, 40, saiWidth, 20);
                g.DrawString($"{sai}", new Font("Arial", 10), Brushes.White, 15 + dungWidth + 5, 42);
            }

            return bmp;
        }

        public void AddChamCong(chamcongdto chamcong)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                SqlCommand command = new SqlCommand("INSERT INTO BangChamCong VALUES(@MaBangChamCong, @Ngay, @Buoi, @GioVaoCa, @MaNhanVien)", connection);

                // Sử dụng SqlParameter với kiểu dữ liệu rõ ràng
                command.Parameters.Add(new SqlParameter("@MaBangChamCong", SqlDbType.NVarChar)).Value = chamcong.MaBangChamCong;
                
                command.Parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date)).Value = chamcong.Ngay;
                
                command.Parameters.Add(new SqlParameter("@Buoi", SqlDbType.Int)).Value = chamcong.Buoi;
                command.Parameters.Add(new SqlParameter("@GioVaoCa", SqlDbType.NVarChar)).Value = chamcong.GioVaoCa;
                command.Parameters.Add(new SqlParameter("@MaNhanVien", SqlDbType.NVarChar)).Value = chamcong.MaNhanVien;

                // Thực thi lệnh
                command.ExecuteNonQuery();
            }
        }

        public List<string> GetMaCC()
        {
            List<string> chamcong = new List<string>();

            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM BangChamCong";
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string Ma = reader["MaBangChamCong"].ToString();

                    chamcong.Add(Ma);
                }
                reader.Close();
                connection.Close();
                return chamcong;
            }
        }

    }
}
