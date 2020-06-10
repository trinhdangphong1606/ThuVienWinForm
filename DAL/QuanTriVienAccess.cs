using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;
using System.Security.Cryptography.X509Certificates;

namespace DAL
{
    public class QuanTriVienAccess : DatabaseAccess
    {
        public List<QuanTriVien> LayToanBoQuanTriVien()
        {
            List<QuanTriVien> dsQuanTriVien = new List<QuanTriVien>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from QuanTriVien";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string tendangnhap = reader.GetString(1);
                string email = reader.GetString(2);
                int namsinh = reader.GetInt32(3);
                string matkhau = reader.GetString(4);
                string hoten = reader.GetString(5);
                string keyrestore = reader.GetString(6);
                string sodienthoai = reader.GetString(7);
                string diachi = reader.GetString(8);
                string quyen = reader.GetString(9);

                QuanTriVien qtv = new QuanTriVien();

                qtv.ID = id;
                qtv.TenDangNhap = tendangnhap;
                qtv.Email = email;
                qtv.NamSinh = namsinh;
                qtv.MatKhau = matkhau;
                qtv.HoTen = hoten;
                qtv.KeyRestore = keyrestore;
                qtv.SoDienThoai = sodienthoai;
                qtv.DiaChi = diachi;
                qtv.Quyen = quyen;

                dsQuanTriVien.Add(qtv);
            }
            reader.Close();
            CloseConnection();
            return dsQuanTriVien;
        }
        public bool ThemQuanTriVien(QuanTriVien qtvien)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into QuanTriVien(TenDangNhap,Email,NamSinh,MatKhau,HoTen,KeyRestore,SoDienThoai,DiaChi,Quyen) " +
                "values('" + qtvien.TenDangNhap + "','" + qtvien.Email + "','" + qtvien.NamSinh + "','" + qtvien.MatKhau + "'," +
                "N'" + qtvien.HoTen + "','" + qtvien.KeyRestore + "','" + qtvien.SoDienThoai + "',N'" + qtvien.DiaChi + "','"+qtvien.Quyen+"')";
            command.Connection = conn;
            int ketqua = command.ExecuteNonQuery();
            return ketqua > 0;

        }
        public bool ChinhSuaQuanTriVien(QuanTriVien qtvien)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update QuanTriVien set TenDangNhap='" + qtvien.TenDangNhap + "',Email='" + qtvien.Email + "'," +
                "NamSinh='" + qtvien.NamSinh + "', HoTen=N'" + qtvien.HoTen + "', SoDienThoai = '" + qtvien.SoDienThoai + "', " +
                "DiaChi=N'" + qtvien.DiaChi + "', Quyen='"+qtvien.Quyen+"'  where Id='" + qtvien.ID + "'";
            command.Connection = conn;
            int ketqua = command.ExecuteNonQuery();
            return ketqua > 0;
        }
        public List<QuanTriVien> DangNhap(QuanTriVien qtvien)
        {
            List<QuanTriVien> dsQuanTriVien = new List<QuanTriVien>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select TenDangNhap,MatKhau,Quyen from QuanTriVien " +
                "where TenDangNhap='" + qtvien.TenDangNhap + "' and MatKhau='" + qtvien.MatKhau + "' ";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string tendangnhap = reader.GetString(0);
                string matkhau = reader.GetString(1);
                string quyen = reader.GetString(2);

                QuanTriVien qtv = new QuanTriVien();

                qtv.TenDangNhap = tendangnhap;
                qtv.MatKhau = matkhau;
                qtv.Quyen = quyen;

                dsQuanTriVien.Add(qtv);
            }
            return dsQuanTriVien;
            
        } 
        public bool DangKy (QuanTriVien qtvien)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into QuanTriVien(TenDangNhap,Email,NamSinh,MatKhau,HoTen,KeyRestore,SoDienThoai,DiaChi,Quyen) " +
                "values('" + qtvien.TenDangNhap + "','" + qtvien.Email + "','" + qtvien.NamSinh + "','" + qtvien.MatKhau + "'," +
                "N'" + qtvien.HoTen + "','" + qtvien.KeyRestore + "','" + qtvien.SoDienThoai + "',N'" + qtvien.DiaChi + "','User')";
            command.Connection = conn;
            int ketqua = command.ExecuteNonQuery();
            return ketqua > 0;
        }
        public bool ResetMatKhau (QuanTriVien qtvien)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update QuanTriVien set MatKhau ='"+qtvien.MatKhau+"' where Id='"+qtvien.ID+"' and KeyRestore='"+qtvien.KeyRestore+"'" +
                "";
            command.Connection = conn;
            int ketqua = command.ExecuteNonQuery();
            return ketqua > 0;
        }
    }
}
