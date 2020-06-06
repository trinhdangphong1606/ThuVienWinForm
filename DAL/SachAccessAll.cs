/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace DAL
{
    public class SachAccessAll : DatabaseAccess
    {
        public List<Sach> LayAllToanBoSach()
        {
            List<Sach> dsSachAll = new List<Sach>();
            OpenConnection();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Sach";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int masach = reader.GetInt32(0);
                string tensach = reader.GetString(1);
                int namxuatban = reader.GetInt32(2);
                int danhmuc = reader.GetInt32(3);
                string tacgia = reader.GetString(4);
                string ngonngu = reader.GetString(5);
                string noidung = reader.GetString(6);
                int soluong = reader.GetInt32(7);
                //string trangthai = reader.GetString(8);

                Sach scc = new Sach();
                scc.ID = masach;
                scc.TenSach = tensach;
                scc.NamXuatBan = namxuatban;
                scc.DanhMucID = danhmuc;
                scc.TacGia = tacgia;
                scc.NgonNgu = ngonngu;
                scc.NoiDungSach = noidung;
                scc.SoLuong = soluong;
                //scc.TrangThai = trangthai;
                dsSachAll.Add(scc);

            }
            reader.Close();
            return dsSachAll;
        }
        
    }
}
*/