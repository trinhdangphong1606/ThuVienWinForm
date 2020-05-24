using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using DAL.DAO;

namespace DAL
{
    public class SachAccess : DatabaseAccess
    {
        public List<SachDAO>LayToanBoSach()
        {
            List<SachDAO> dsSach = new List<SachDAO>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT s.Id, s.TenSach, s.NamXuatBan, dm.TenDanhMuc, s.TacGia, s.NgonNgu, s.NoiDungSach, s.SoLuong FROM Sach s INNER JOIN DanhMuc dm ON s.DanhMucID = dm.IdDanhMuc";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                int masach = reader.GetInt32(0);
                string tensach = reader.GetString(1);
                int namxuatban = reader.GetInt32(2);
                string theloai = reader.GetString(3);
                string tacgia = reader.GetString(4);
                string ngonngu = reader.GetString(5);
                string noidung = reader.GetString(6);
                int soluong = reader.GetInt32(7);

                SachDAO sc = new SachDAO();
                sc.ID = masach;
                sc.TenSach = tensach;
                sc.NamXuatBan = namxuatban;
                sc.TheLoai = theloai;
                sc.TacGia = tacgia;
                sc.NgonNgu = ngonngu;
                sc.NoiDungSach = noidung;
                sc.SoLuong = soluong;
                dsSach.Add(sc);
            }
            reader.Close();
            return dsSach;
        }

        
    }
}
