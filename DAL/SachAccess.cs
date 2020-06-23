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
        public List<Sach> LayAllToanBoSach()
        {
            List<Sach> dsSachAll = new List<Sach>();
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
                string trangthai = reader.GetString(8);

                Sach scc = new Sach();
                scc.ID = masach;
                scc.TenSach = tensach;
                scc.NamXuatBan = namxuatban;
                scc.DanhMucID = danhmuc;
                scc.TacGia = tacgia;
                scc.NgonNgu = ngonngu;
                scc.NoiDungSach = noidung;
                scc.SoLuong = soluong;
                scc.TrangThai = trangthai;
                dsSachAll.Add(scc);

            }
            reader.Close();
            return dsSachAll;
        }
        public List<Sach> LayAllToanBoSachTrong()
        {
            List<Sach> dsSachAll = new List<Sach>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Sach where TrangThai=N'Trống'";
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
                string trangthai = reader.GetString(8);

                Sach scc = new Sach();
                scc.ID = masach;
                scc.TenSach = tensach;
                scc.NamXuatBan = namxuatban;
                scc.DanhMucID = danhmuc;
                scc.TacGia = tacgia;
                scc.NgonNgu = ngonngu;
                scc.NoiDungSach = noidung;
                scc.SoLuong = soluong;
                scc.TrangThai = trangthai;
                dsSachAll.Add(scc);

            }
            reader.Close();
            return dsSachAll;
        }
        public List<SachDAO> LayToanBoSach()
        {
            List<SachDAO> dsSach = new List<SachDAO>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT s.Id, s.TenSach, s.NamXuatBan, dm.TenDanhMuc, s.TacGia, s.NgonNgu, s.NoiDungSach,s.TrangThai,s.SoLuong FROM Sach s INNER JOIN DanhMuc dm ON s.DanhMucID = dm.IdDanhMuc";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();// truy vấn trả về nhiều dòng dữ liệu, ExecuteReader trả về đầu đọc quản lý bảng dữ liệu đó 
            while (reader.Read())//Đọc cho đến khi hết dữ liệu trả về từ db, khi hết dữ liệu sẽ trả về False -> dừng vòng lặp
            {
                int masach = reader.GetInt32(0); //gán vị trí đầu tiên trong đầu đọc là masach
                string tensach = reader.GetString(1);
                int namxuatban = reader.GetInt32(2);
                string theloai = reader.GetString(3);
                string tacgia = reader.GetString(4);
                string ngonngu = reader.GetString(5);
                string noidung = reader.GetString(6);
                string trangthai = reader.GetString(7);
                int soluong = reader.GetInt32(8);

                SachDAO sc = new SachDAO(); //Nạp vào đối tượng SachDAO
                sc.ID = masach;
                sc.TenSach = tensach;
                sc.NamXuatBan = namxuatban;
                sc.TheLoai = theloai;
                sc.TacGia = tacgia;
                sc.NgonNgu = ngonngu;
                sc.NoiDungSach = noidung;
                sc.TrangThai = trangthai;
                //sc.SoLuong = soluong;

                dsSach.Add(sc); //đưa sach vào dssach
            }
            reader.Close();
            return dsSach;
        }
        public List<SachDAO> LayToanBoSachTrong()
        {
            List<SachDAO> dsSach = new List<SachDAO>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT s.Id, s.TenSach, s.NamXuatBan, dm.TenDanhMuc, s.TacGia, s.NgonNgu, s.NoiDungSach,s.TrangThai,s.SoLuong from Sach s,DanhMuc dm where TrangThai=N'Trống' and s.DanhMucID = dm.IdDanhMuc";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();// truy vấn trả về nhiều dòng dữ liệu, ExecuteReader trả về đầu đọc quản lý bảng dữ liệu đó 
            while (reader.Read())//Đọc cho đến khi hết dữ liệu trả về từ db, khi hết dữ liệu sẽ trả về False -> dừng vòng lặp
            {
                int masach = reader.GetInt32(0); //gán vị trí đầu tiên trong đầu đọc là masach
                string tensach = reader.GetString(1);
                int namxuatban = reader.GetInt32(2);
                string theloai = reader.GetString(3);
                string tacgia = reader.GetString(4);
                string ngonngu = reader.GetString(5);
                string noidung = reader.GetString(6);
                string trangthai = reader.GetString(7);
                int soluong = reader.GetInt32(8);

                SachDAO sc = new SachDAO(); //Nạp vào đối tượng SachDAO
                sc.ID = masach;
                sc.TenSach = tensach;
                sc.NamXuatBan = namxuatban;
                sc.TheLoai = theloai;
                sc.TacGia = tacgia;
                sc.NgonNgu = ngonngu;
                sc.NoiDungSach = noidung;
                sc.TrangThai = trangthai;
                //sc.SoLuong = soluong;

                dsSach.Add(sc); //đưa sach vào dssach
            }
            reader.Close();
            return dsSach;
        }
        public List<SachDAO> TimTenSach(SachDAO timsach)
        {
            List<SachDAO> dsSach = new List<SachDAO>();
            OpenConnection();
            string cmd = "exec TimSachTheoTen @ten=N'" + timsach.TenSach + "'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = cmd;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            //Console.WriteLine("Inside " + cmd);
            while (reader.Read())
            {
                //Console.WriteLine("In loop");

                int masach = reader.GetInt32(0);
                string tensach = reader.GetString(1);
                int namxuatban = reader.GetInt32(2);
                string theloai = reader.GetString(3);
                string tacgia = reader.GetString(4);
                string ngonngu = reader.GetString(5);
                string noidung = reader.GetString(6);
                int soluong = reader.GetInt32(7);
                string trangthai = reader.GetString(8);

                SachDAO sc = new SachDAO();

                sc.ID = masach;
                sc.TenSach = tensach;
                sc.NamXuatBan = namxuatban;
                sc.TheLoai = theloai;
                sc.TacGia = tacgia;
                sc.NgonNgu = ngonngu;
                sc.NoiDungSach = noidung;
                sc.SoLuong = soluong;
                sc.TrangThai = trangthai;

                dsSach.Add(sc);
            }
            reader.Close();
            return dsSach;

        }
        public List<SachDAO> TimSachTrongTheoTen(SachDAO timsach)
        {
            List<SachDAO> dsSach = new List<SachDAO>();
            OpenConnection();
            string cmd = "exec TimSachTrongTheoTen @ten=N'" + timsach.TenSach + "'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = cmd;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            //Console.WriteLine("Inside " + cmd);
            while (reader.Read())
            {
                //Console.WriteLine("In loop");

                int masach = reader.GetInt32(0);
                string tensach = reader.GetString(1);
                int namxuatban = reader.GetInt32(2);
                string theloai = reader.GetString(3);
                string tacgia = reader.GetString(4);
                string ngonngu = reader.GetString(5);
                string noidung = reader.GetString(6);
                int soluong = reader.GetInt32(7);
                string trangthai = reader.GetString(8);

                SachDAO sc = new SachDAO();

                sc.ID = masach;
                sc.TenSach = tensach;
                sc.NamXuatBan = namxuatban;
                sc.TheLoai = theloai;
                sc.TacGia = tacgia;
                sc.NgonNgu = ngonngu;
                sc.NoiDungSach = noidung;
                sc.SoLuong = soluong;
                sc.TrangThai = trangthai;

                dsSach.Add(sc);
            }
            reader.Close();
            return dsSach;

        }
        public bool CapNhatPhieuMuon(Sach sac)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update Sach set TrangThai=N'Trống' where Id='" + sac.ID + "'";
            command.Connection = conn;
            int ketqua = command.ExecuteNonQuery();
            return ketqua > 0;
        }
        public List<Sach> TimMaSach(Sach timsach)
        {
            OpenConnection();
            List<Sach> dsSach = new List<Sach>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select Id,TenSach from Sach where TenSach=N'" + timsach.TenSach + "'";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int masach = reader.GetInt32(0);
                string tensach = reader.GetString(1);
                Sach sc = new Sach();
                sc.ID = masach;
                sc.TenSach = tensach;
                dsSach.Add(sc);
            }
            reader.Close();
            CloseConnection();
            return dsSach;
        }
        public bool ThemSach(Sach sac)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into Sach(TenSach,TacGia,NamXuatBan,NgonNgu,NoiDungSach,DanhMucID,SoLuong,TrangThai)values" +
                "(N'" + sac.TenSach + "', N'" + sac.TacGia + "', '" + sac.NamXuatBan + "', N'" + sac.NgonNgu + "', " +
                "N'" + sac.NoiDungSach + "', '" + sac.DanhMucID + "','1',N'Trống')";
            command.Connection = conn;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
        public bool SuaSach(Sach sac)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Update Sach set TenSach =N'" + sac.TenSach + "', NamXuatBan ='" + sac.NamXuatBan + "'" +
                ",DanhMucID =N'" + sac.DanhMucID + "', TacGia =N'" + sac.TacGia + "', NgonNgu =N'" + sac.NgonNgu + "'" +
                ",NoiDungSach =N'" + sac.NoiDungSach + "' where ID='" + sac.ID + "'";
            command.Connection = conn;
            int ketqua = command.ExecuteNonQuery();
            return ketqua > 0;
        }
        public bool CapNhatTrangThaiLoi(Sach sac)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update Sach set TrangThai=N'Sách bị lỗi' where TenSach=N'"+sac.TenSach+"'";
            command.Connection = conn;
            int ketqua = command.ExecuteNonQuery();
            return ketqua > 0;
        }
        public bool CapNhatDocGiaKhongDen(Sach sac)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update Sach set TrangThai=N'Trống' where TenSach=N'" + sac.TenSach + "'";
            command.Connection = conn;
            int ketqua = command.ExecuteNonQuery();
            return ketqua > 0;
        }
        public bool CapNhatDaSuaLoiSach(Sach sac)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update Sach set TrangThai=N'Trống' where TenSach=N'" + sac.ID + "'";
            command.Connection = conn;
            int ketqua = command.ExecuteNonQuery();
            return ketqua > 0;
        }
        public List<SachDAO> TimSachTheoDanhMuc(SachDAO timsachdm)
        {
            List<SachDAO> dsSachh = new List<SachDAO>();
            OpenConnection();
            string cmd = "SELECT s.Id, s.TenSach, s.NamXuatBan, dm.TenDanhMuc, s.TacGia, s.NgonNgu, s.NoiDungSach,s.TrangThai,s.SoLuong FROM Sach s " +
                "INNER JOIN DanhMuc dm ON s.DanhMucID = dm.IdDanhMuc Where dm.TenDanhMuc =N'" + timsachdm.TheLoai + "'";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = cmd;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            //Console.WriteLine("Inside " + cmd);
            while (reader.Read())
            {
                //Console.WriteLine("In loop");

                int masach = reader.GetInt32(0);
                string tensach = reader.GetString(1);
                int namxuatban = reader.GetInt32(2);
                string theloai = reader.GetString(3);
                string tacgia = reader.GetString(4);
                string ngonngu = reader.GetString(5);
                string noidung = reader.GetString(6);
                string trangthai = reader.GetString(7);
                int soluong = reader.GetInt32(8);


                SachDAO sc = new SachDAO();

                sc.ID = masach;
                sc.TenSach = tensach;
                sc.NamXuatBan = namxuatban;
                sc.TheLoai = theloai;
                sc.TacGia = tacgia;
                sc.NgonNgu = ngonngu;
                sc.NoiDungSach = noidung;
                sc.SoLuong = soluong;
                sc.TrangThai = trangthai;

                dsSachh.Add(sc);
            }
            reader.Close();
            return dsSachh;

        }
    }
}
