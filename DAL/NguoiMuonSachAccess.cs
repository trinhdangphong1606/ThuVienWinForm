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
                string bieuhien = reader.GetString(4);

                NguoiMuonSach nms = new NguoiMuonSach();

                nms.Id = id;
                nms.HoTen = hoten;
                nms.SoDienThoai = sodienthoai;
                nms.DiaChi = diachi;
                nms.BieuHien = bieuhien;

                dsNguoiMuonSach.Add(nms);
            }
            reader.Close();

            return dsNguoiMuonSach;
        }
    }
}

