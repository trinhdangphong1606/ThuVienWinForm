using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using DTO;
using System.IO;

namespace DAL
{
    public class NguoiMuonSachAccess:DatabaseAccess
    {
        public List<NguoiMuonSach> LayToanBoNguoiMuonSach()
            
        {
            List<NguoiMuonSach> dsNguoiMuonSach = new List<NguoiMuonSach>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from NguoiMuonSach";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string hoten = reader.GetString(1);
                string sodienthoai = reader.GetString(2);
                string diachi = reader.GetString(3);
                string email = reader.GetString(4);
                int namsinh = reader.GetInt32(5);
                NguoiMuonSach nms = new NguoiMuonSach();
                nms.Id = id;
                nms.HoTen = hoten;
                nms.SoDienThoai = sodienthoai;
                nms.DiaChi = diachi;
                nms.Email = email;
                nms.NamSinh = namsinh;
                dsNguoiMuonSach.Add(nms);
            }
            reader.Close();
            CloseConnection();
            return dsNguoiMuonSach;
        }
        public List<NguoiMuonSach> TimTenNguoiMuon(NguoiMuonSach nms)
        {
            List<NguoiMuonSach> dsNguoiMuonSach = new List<NguoiMuonSach>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "exec TimTenNguoiMuon @ten ='" + nms.HoTen + "'";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string hoten = reader.GetString(1);
                string sodienthoai = reader.GetString(2);
                string diachi = reader.GetString(3);
                string email = reader.GetString(4);
                int namsinh = reader.GetInt32(5);
                NguoiMuonSach tennms = new NguoiMuonSach();
                tennms.Id = id;
                tennms.HoTen = hoten;
                nms.SoDienThoai = sodienthoai;
                nms.DiaChi = diachi;
                nms.Email = email;
                nms.NamSinh = namsinh;
                dsNguoiMuonSach.Add(tennms);
            }
            reader.Close();
            CloseConnection();
            return dsNguoiMuonSach;
        }
        public bool CapNhatDocGia(NguoiMuonSach nms)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Update NguoiMuonSach set HoTen=N'"+nms.HoTen+"', SoDienThoai ='" + nms.SoDienThoai+"', DiaChi =N'" + nms.DiaChi+"', Email='" + nms.Email+"' where ID='"+nms.Id+"'";
            command.Connection = conn;
            int ketqua = command.ExecuteNonQuery();
            return true;
        }
        public bool ThemDocGia(NguoiMuonSach nms)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into NguoiMuonSach(HoTen,SoDienThoai,DiaChi,Email,NamSinh)values(N'"+nms.HoTen+"','"+nms.SoDienThoai+"', N'"+nms.DiaChi+"', '"+nms.Email+"', '"+nms.NamSinh+"')";
            command.Connection = conn;
            int ketqua = command.ExecuteNonQuery();
            return true;
        }
    }

}

