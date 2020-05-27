using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

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
            while(reader.Read())
            {
                int id = reader.GetInt32(0);
                string tendangnhap = reader.GetString(1);
                string email = reader.GetString(2);
                int namsinh = reader.GetInt32(3);
                string matkhau= reader.GetString(4);
                string hoten =  reader.GetString(5);
                string keyrestore= reader.GetString(6);
                string sodienthoai= reader.GetString(7);
                string diachi= reader.GetString(8);

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

                dsQuanTriVien.Add(qtv);
            }
            reader.Close();
            return dsQuanTriVien;
        }
    }
}
