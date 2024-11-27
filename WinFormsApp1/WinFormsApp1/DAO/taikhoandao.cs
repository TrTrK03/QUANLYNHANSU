﻿using WinFormsApp1.connect;
using WinFormsApp1.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DAO
{
    internal class taikhoandao
    {
        private ketnoi connectObj = new ketnoi();
        public taikhoandao()
        {

        }
        public List<taikhoandto> getds()
        {
            List<taikhoandto> accounts = new List<taikhoandto>();

            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM TaiKhoan";
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    taikhoandto account = new taikhoandto()
                    {
                        MaTaiKhoan = reader["MaTaiKhoan"].ToString(),
                        TenTaiKhoan = reader["TenTaiKhoan"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        MaQuyen = reader["MaQuyen"].ToString(),
                        MaNhanVien = reader["MaNhanVien"].ToString(),
                        TrangThai = Convert.ToInt32(reader["TrangThai"])


                    };
                    accounts.Add(account);
                }
                reader.Close();
                connection.Close();
                return accounts;
            }
        }

        //public ArrayList getds()
        //{
        //    ArrayList ds = new System.Collections.ArrayList();
        //    ketnoi cn = new ketnoi();
        //    SqlConnection connect = cn.connection();
        //    SqlCommand sqlcommand = new SqlCommand();
        //    sqlcommand.CommandType = System.Data.CommandType.Text;
        //    sqlcommand.CommandText = "select * from TaiKhoan";
        //    sqlcommand.Connection = connect;
        //    SqlDataReader reader = sqlcommand.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        String maTaiKhoan = reader.GetString(0);
        //        String username = reader.GetString(1);
        //        String MatKhau = reader.GetString(2);
        //        String maQuyen = reader.GetString(3);
        //        String maNhanVien = reader.GetString(4);
        //        int trangthai = reader.GetInt32(5);
        //        taikhoandto tk = new taikhoandto(maTaiKhoan, username, MatKhau, maQuyen, maNhanVien,trangthai);
        //        ds.Add(tk);
        //    }
        //    reader.Close();
        //    connect.Close();
        //    return ds;
        //}
        public int insert(taikhoandto tk)
        {
            ketnoi cn = new ketnoi();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.CommandType = System.Data.CommandType.Text;
            sqlcommand.CommandText = "insert into TaiKhoan values(N'"+tk.MaTaiKhoan + "',N'"+ tk.TenTaiKhoan + "',N'" + tk.MatKhau + "',N'" + tk.MaQuyen + "','" + tk.MaNhanVien + "','" + tk.TrangThai + "')";
            SqlConnection connect = cn.connection();
            int kq = sqlcommand.ExecuteNonQuery();
            connect.Close();
            return kq;
        }
        public Boolean checkttk(String matk, String mk)
        {
            Boolean flag = false;
            /*connect.connect cn = new connect.connect();  */
            ketnoi cn = new ketnoi();
            SqlCommand cmd = new SqlCommand();
            SqlConnection connection = cn.connection();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Select * from TaiKhoan where MaTaiKhoan='" + matk + "' and MatKhau='" + mk + "'";
            cmd.Connection = connection;
            SqlDataReader read = cmd.ExecuteReader();
            flag = read.Read();
            read.Close();
            cmd.Connection.Close();
            connection.Close();
            return flag;
        }
        //public int update(taikhoandto tk)
        //{
        //    //connect.connect cn = new connect.connect();
        //    ketnoi cn = new ketnoi();
        //    SqlCommand sqlcommand = new SqlCommand();
        //    sqlcommand.CommandType = System.Data.CommandType.Text;
        //    sqlcommand.CommandText = "Update TaiKhoan set MatKhau=N'" + tk.MatKhau + "',maQuyen='" + tk.MaQuyen + "',TrangThai='" + tk.TrangThai + "' where Username='" + tk.Username + "'";
        //    SqlConnection connect = cn.connection();
        //    int kq = sqlcommand.ExecuteNonQuery();
        //    connect.Close();
        //    return kq;
        //}

        public int GetmaQuyen(string tk, string mk)
        {
            int maQuyen = 0; // Giá trị mặc định hoặc giá trị không hợp lệ

            /*connect.connect cn = new connect.connect();*/
            ketnoi cn = new ketnoi();
            SqlConnection connection = cn.connection();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.CommandType = System.Data.CommandType.Text;
            sqlcommand.CommandText = "select maQuyen from TaiKhoan where MaTaiKhoan = '" + tk + "' and MatKhau =  '" + mk + "'";
            sqlcommand.Connection = connection;
            SqlDataReader reader = sqlcommand.ExecuteReader();
            if (reader.Read())
            {
                maQuyen = Convert.ToInt32(reader["maQuyen"]);
            }

            return maQuyen;
        }

        public ArrayList getdsmaQuyen(int maQuyen)
        {
            ArrayList ds = new System.Collections.ArrayList();
            //connect.connect cn = new connect.connect();
            ketnoi cn = new ketnoi();
            SqlConnection connect = cn.connection();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.CommandType = System.Data.CommandType.Text;
            sqlcommand.CommandText = "select * from TaiKhoan where maQuyen like '" + maQuyen + "%'";
            sqlcommand.Connection = connect;
            SqlDataReader reader = sqlcommand.ExecuteReader();
            while (reader.Read())
            {
                String maTaiKhoan = reader.GetString(0);
                String username = reader.GetString(1);
                String MatKhau = reader.GetString(2);
                String MaQuyen = reader.GetString(3);
                String maNhanVien = reader.GetString(4);
                int trangthai = reader.GetInt32(5);
                taikhoandto tk = new taikhoandto(maTaiKhoan, username, MatKhau, MaQuyen, maNhanVien, trangthai);
                ds.Add(tk);
            }
            reader.Close();
            connect.Close();
            return ds;
        }
        public ArrayList getdstk(String user)
        {
            ArrayList ds = new System.Collections.ArrayList();
            //connect.connect cn = new connect.connect();
            ketnoi cn = new ketnoi();
            SqlConnection connect = cn.connection();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.CommandType = System.Data.CommandType.Text;
            sqlcommand.CommandText = "select * from TaiKhoan where Username like '" + user + "%'";
            sqlcommand.Connection = connect;
            SqlDataReader reader = sqlcommand.ExecuteReader();
            while (reader.Read())
            {
                String maTaiKhoan = reader.GetString(0);
                String username = reader.GetString(1);
                String MatKhau = reader.GetString(2);
                String maQuyen = reader.GetString(3);
                String maNhanVien = reader.GetString(4);
                int trangthai = reader.GetInt32(5);
                taikhoandto tk = new taikhoandto(maTaiKhoan, username, MatKhau, maQuyen, maNhanVien, trangthai);
                ds.Add(tk);
            }
            reader.Close();
            connect.Close();
            return ds;
        }
        public ArrayList getdsmtk(String matk)
        {
            ArrayList ds = new System.Collections.ArrayList();
            //connect.connect cn = new connect.connect();
            ketnoi cn = new ketnoi();
            SqlConnection connect = cn.connection();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.CommandType = System.Data.CommandType.Text;
            sqlcommand.CommandText = "select * from TaiKhoan where MaTK like '" + matk + "%'";
            sqlcommand.Connection = connect;
            SqlDataReader reader = sqlcommand.ExecuteReader();
            while (reader.Read())
            {

                String maTaiKhoan = reader.GetString(0);
                String username = reader.GetString(1);
                String MatKhau = reader.GetString(2);
                String maQuyen = reader.GetString(3);
                String maNhanVien = reader.GetString(4);
                int trangthai = reader.GetInt32(5);
                taikhoandto tk = new taikhoandto(maTaiKhoan, username, MatKhau, maQuyen, maNhanVien, trangthai);
                ds.Add(tk);
            }
            reader.Close();
            connect.Close();
            return ds;
        }
        public ArrayList getdstrangthai(int trangthai)
        {
            ArrayList ds = new System.Collections.ArrayList();
            //connect.connect cn = new connect.connect();
            ketnoi cn = new ketnoi();
            SqlConnection connect = cn.connection();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.CommandType = System.Data.CommandType.Text;
            sqlcommand.CommandText = "select * from TaiKhoan where TrangThai like '" + trangthai + "%'";
            sqlcommand.Connection = connect;
            SqlDataReader reader = sqlcommand.ExecuteReader();
            while (reader.Read())
            {
                String maTaiKhoan = reader.GetString(0);
                String username = reader.GetString(1);
                String MatKhau = reader.GetString(2);
                String maQuyen = reader.GetString(3);
                String maNhanVien = reader.GetString(4);
                int trangThai = reader.GetInt32(5);
                taikhoandto tk = new taikhoandto(maTaiKhoan, username, MatKhau, maQuyen, maNhanVien, trangThai);
                ds.Add(tk);
            }
            reader.Close();
            connect.Close();
            return ds;
        }

        //public khachhangdto getKhachHang(string username)
        //{
        //    khachhangdto kh = new khachhangdto();
        //    using (SqlConnection conn = new ketnoi().connection())
        //    {
        //        string query = "select * from TaiKhoan tk join KhachHang kh on tk.UserID=kh.MaTK where tk.Username=@user";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@user", username);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            String mkh = (string)reader["MaKH"];
        //            String name = (string)reader["HoTen"];
        //            String sdt = (String)reader["SDT"];
        //            String email = (string)reader["Email"];
        //            String gioitinh = (string)reader["GioiTinh"];
        //            DateTime ngaysinh = (DateTime)reader["Ngaysinh"];
        //            int user = (int)reader["MaTK"];
        //            int trangthai = (int)reader["TinhTrang"];
        //            kh = new khachhangdto(mkh, name, gioitinh, sdt, email, ngaysinh, user, trangthai);
        //        }
        //    }
        //    return kh;
        //}

        public Boolean changePW(int id, string pass)
        {
            if (id != null)
            {
                using (SqlConnection conn = new ketnoi().connection())
                {
                    string query = "Update TaiKhoan set MatKhau=@pass where UserID=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            return false;
        }

        public Boolean checkOldPass(int id,String oldPass)
        {
            string a=null;
            using (SqlConnection conn = new ketnoi().connection())
            {
                string query = "select MatKhau from TaiKhoan where UserID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader= cmd.ExecuteReader();
                if (reader.Read())
                {
                    a = reader.GetString(0);
                }
            }
            return String.Equals(a, oldPass);
        }


        //public int selectcount()
        //{
        //    //connect.connect cn = new connect.connect();
        //    ketnoi cn = new ketnoi();
        //    SqlCommand sqlcommand = new SqlCommand();
        //    sqlcommand.CommandType = System.Data.CommandType.Text;

        //    sqlcommand.CommandText = "select count (*) from TaiKhoan TK,maQuyen Q where TK.maQuyen=Q.MamaQuyen ";
        //    SqlConnection connect = cn.connection();
        //    sqlcommand.Connection = connect;
        //    int kq = (int)sqlcommand.ExecuteScalar();

        //    connect.Close();
        //    return kq;
        //}
        //public ArrayList getdsformpage(int ofset, int record)
        //{

        //    ArrayList ds = new System.Collections.ArrayList();
        //    ketnoi cn = new ketnoi(); //connect.connect cn = new connect.connect();
        //    SqlConnection connect = cn.connection();
        //    SqlCommand sqlcommand = new SqlCommand();
        //    sqlcommand.CommandType = System.Data.CommandType.Text;
        //    sqlcommand.CommandText = string.Format("select TK.MaTK,TK.Username,TK.MatKhau,TK.maQuyen,Q.TenmaQuyen,TK.TrangThai from TaiKhoan TK,maQuyen Q where TK.maQuyen=Q.MamaQuyen ORDER BY MaTK ASC OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY", ofset, record);
        //    sqlcommand.Connection = connect;
        //    SqlDataReader reader = sqlcommand.ExecuteReader();
        //    while (reader.Read())
        //    {    
        //        int matk=reader.GetInt32(0);
        //        String username = reader.GetString(1);
        //        String MatKhau = reader.GetString(2);
        //        int maQuyen = reader.GetInt32(3);
        //        String tenmaQuyen=reader.GetString(4);
        //        int trangthai = reader.GetInt32(5);
        //        taikhoandto tk=new taikhoandto(maTaiKhoan, username, MatKhau, maQuyen, maNhanVien, trangthai);
        //        ds.Add(tk);
        //    }
        //    reader.Close();
        //    connect.Close();
        //    return ds;
        //}
        //public int selectcountpagesearch(String ten, String dieukien)

        //{
        //    ketnoi cn = new ketnoi(); //connect.connect cn = new connect.connect();
        //    SqlCommand sqlcommand = new SqlCommand();
        //    sqlcommand.CommandType = System.Data.CommandType.Text;
        //    dieukien = dieukien.Trim();

        //    if(ten=="TenmaQuyen")
        //    {
        //        sqlcommand.CommandText = string.Format("select count (*) from TaiKhoan TK,maQuyen Q where TK.maQuyen=Q.MamaQuyen and Q.{0} LIKE N'%" + dieukien + "%' ", ten);
        //    }
        //    else
        //    {
        //        sqlcommand.CommandText = string.Format("select count (*) from TaiKhoan TK,maQuyen Q where TK.maQuyen=Q.MamaQuyen and TK.{0} LIKE N'%" + dieukien + "%' ", ten);
        //    }

        //    SqlConnection connect = cn.connection();
        //    sqlcommand.Connection = connect;
        //    int kq = (int)sqlcommand.ExecuteScalar();
        //    connect.Close();
        //    return kq;
        //}
        //public ArrayList getdsformpageoder(String ten, String dieukien, String dieukiensx, String loaisx, int ofset, int record)
        //{

        //    ArrayList ds = new System.Collections.ArrayList();
        //    ketnoi cn = new ketnoi(); //connect.connect cn = new connect.connect();
        //    SqlConnection connect = cn.connection();
        //    SqlCommand sqlcommand = new SqlCommand();
        //    sqlcommand.CommandType = System.Data.CommandType.Text;
        //    if(ten=="TenmaQuyen")
        //    {
        //        if(dieukiensx=="TenmaQuyen")
        //        {
        //            sqlcommand.CommandText = string.Format("select TK.MaTK,TK.Username,TK.MatKhau,TK.maQuyen,Q.TenmaQuyen,TK.TrangThai from TaiKhoan TK,maQuyen Q where TK.maQuyen=Q.MamaQuyen and Q.{0} LIKE N'%" + dieukien + "%' ORDER BY Q.{1} {2} OFFSET {3} ROWS FETCH NEXT {4} ROWS ONLY", ten, dieukiensx, loaisx, ofset, record);
        //        }
        //        else
        //        {
        //            sqlcommand.CommandText = string.Format("select TK.MaTK,TK.Username,TK.MatKhau,TK.maQuyen,Q.TenmaQuyen,TK.TrangThai from TaiKhoan TK,maQuyen Q where TK.maQuyen=Q.MamaQuyen and Q.{0} LIKE N'%" + dieukien + "%' ORDER BY TK.{1} {2} OFFSET {3} ROWS FETCH NEXT {4} ROWS ONLY", ten, dieukiensx, loaisx, ofset, record);
        //        }
                
        //    }
        //     else
        //    {
        //        if(dieukiensx=="TenmaQuyen")
        //        {
        //            sqlcommand.CommandText = string.Format("select TK.MaTK,TK.Username,TK.MatKhau,TK.maQuyen,Q.TenmaQuyen,TK.TrangThai from TaiKhoan TK,maQuyen Q where TK.maQuyen=Q.MamaQuyen and TK.{0} LIKE N'%" + dieukien + "%' ORDER BY Q.{1} {2} OFFSET {3} ROWS FETCH NEXT {4} ROWS ONLY", ten, dieukiensx, loaisx, ofset, record);
        //        }
        //        else
        //        {
        //            sqlcommand.CommandText = string.Format("select TK.MaTK,TK.Username,TK.MatKhau,TK.maQuyen,Q.TenmaQuyen,TK.TrangThai from TaiKhoan TK,maQuyen Q where TK.maQuyen=Q.MamaQuyen and TK.{0} LIKE N'%" + dieukien + "%' ORDER BY TK.{1} {2} OFFSET {3} ROWS FETCH NEXT {4} ROWS ONLY", ten, dieukiensx, loaisx, ofset, record);
        //        }
               
        //    }
        //    sqlcommand.Connection = connect;
        //    SqlDataReader reader = sqlcommand.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        int matk = reader.GetInt32(0);
        //        String username = reader.GetString(1);
        //        String MatKhau = reader.GetString(2);
        //        int maQuyen = reader.GetInt32(3);
        //        String tenmaQuyen = reader.GetString(4);
        //        int trangthai = reader.GetInt32(5);
        //        TAIKHOANDTO tk = new taikhoandto(maTaiKhoan, username, MatKhau, maQuyen, maNhanVien, trangthai);
        //        ds.Add(tk);
        //    }
        //    reader.Close();
        //    connect.Close();
        //    return ds;
        //}
        //public ArrayList getdsformpageodersx(String ten, String sx, int ofset, int record)
        //{

        //    ArrayList ds = new System.Collections.ArrayList();
        //    ketnoi cn = new ketnoi(); //connect.connect cn = new connect.connect();
        //    SqlConnection connect = cn.connection();
        //    SqlCommand sqlcommand = new SqlCommand();
        //    sqlcommand.CommandType = System.Data.CommandType.Text;
        //    if(ten=="TenmaQuyen")
        //    {
        //        sqlcommand.CommandText = string.Format("select TK.MaTK,TK.Username,TK.MatKhau,TK.maQuyen,Q.TenmaQuyen,TK.TrangThai from TaiKhoan TK,maQuyen Q where TK.maQuyen=Q.MamaQuyen ORDER BY Q.{0} {1} OFFSET {2} ROWS FETCH NEXT {3} ROWS ONLY", ten, sx, ofset, record);
        //    }
        //    else
        //    {
        //        sqlcommand.CommandText = string.Format("select TK.MaTK,TK.Username,TK.MatKhau,TK.maQuyen,Q.TenmaQuyen,TK.TrangThai from TaiKhoan TK,maQuyen Q where TK.maQuyen=Q.MamaQuyen ORDER BY TK.{0} {1} OFFSET {2} ROWS FETCH NEXT {3} ROWS ONLY", ten, sx, ofset, record);
        //    }
        //    sqlcommand.Connection = connect;
        //    SqlDataReader reader = sqlcommand.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        int matk = reader.GetInt32(0);
        //        String username = reader.GetString(1);
        //        String MatKhau = reader.GetString(2);
        //        int maQuyen = reader.GetInt32(3);
        //        String tenmaQuyen = reader.GetString(4);
        //        int trangthai = reader.GetInt32(5);
        //        taikhoandto tk = new taikhoandto(maTaiKhoan, username, MatKhau, maQuyen, maNhanVien, trangthai);
        //        ds.Add(tk);
        //    }
        //    reader.Close();
        //    connect.Close();
        //    return ds;
        //}

        //public int UpDate(taikhoandto tk)
        //{
        //    ketnoi cn = new ketnoi(); //connect.connect cn = new connect.connect();
        //    SqlCommand sqlcommand = new SqlCommand();
        //    sqlcommand.CommandType = System.Data.CommandType.Text;
        //    sqlcommand.CommandText = "UPDATE TaiKhoan set MatKhau=N'" + tk.MatKhau + "',maQuyen='" + tk.maQuyen + "',TrangThai='" + tk.Trangthai + "' where Username='" + tk.Username + "'";
        //    SqlConnection connect = cn.connection();
        //    sqlcommand.Connection = connect;
        //    int kq = sqlcommand.ExecuteNonQuery();
        //    connect.Close();
        //    return kq;

        //}



        //public Boolean checkUserID(string id)
        //{
        //    using (SqlConnection conn = new ketnoi().connection())
        //    {
        //        string query = "select * from TaiKhoan where Username=@id";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@id", id);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        public int GetSoLuong()
        {
            int soLuong = 0;
            using (SqlConnection connection = new ketnoi().connection())
            {
                SqlCommand sql = new SqlCommand("SELECT * FROM TaiKhoan", connection);
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    soLuong++;
                }
            }
            return soLuong;    
        }


        //public void AddAccount(string userid,string username, string MatKhau)
        //{

        //    using (SqlConnection connection = new ketnoi().connection())
        //    {

        //        // Thực hiện truy vấn để thêm dữ liệu vào bảng TaiKhoan
        //        string query = "INSERT INTO TaiKhoan (UserID, Username, MatKhau, maQuyen, TrangThai) VALUES (@UserID ,@Username, @MatKhau, @maQuyen, @TrangThai)";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@UserID", userid);
        //        command.Parameters.AddWithValue("@Username", username);
        //        command.Parameters.AddWithValue("@MatKhau", MatKhau);
        //        command.Parameters.AddWithValue("@maQuyen", 3); // maQuyen = 3 (tương ứng với KhachHang)
        //        command.Parameters.AddWithValue("@TrangThai", 1); // Trạng thái tài khoản (có thể thay đổi)

        //        command.ExecuteNonQuery();
        //    }
        //}

    }
}
