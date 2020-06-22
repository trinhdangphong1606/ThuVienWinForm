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
using DAL.DAO;

namespace DAL
{
    public class PhieuMuonSachAccess : DatabaseAccess
    {
        public List<PhieuMuonSachDAO> LayToanBoPhieuMuon()
        {
            List<PhieuMuonSachDAO> dsPhieuMuon = new List<PhieuMuonSachDAO>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT pms.PhieuId,nms.HoTen,s.TenSach,pms.NgayMuon,pms.NgayDuKienTra,pms.NgayTraSach" +
                " FROM PhieuMuonSach pms, NguoiMuonSach nms, Sach s WHERE pms.NguoiMuonSachId = nms.Id and pms.SachID = s.ID" +
                " ORDER BY pms.PhieuId DESC";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                int idphieu = reader.GetInt32(0);
                string tennguoimuon = reader.GetString(1);
                string tensach = reader.GetString(2);
                DateTime ngaymuon = reader.GetDateTime(3);
                DateTime ngaydukientra = reader.GetDateTime(4);
                DateTime? ngaytra;
                if(reader.IsDBNull(5))
                {
                    ngaytra= (DateTime?)null;
                }
                else
                {
                    ngaytra = reader.GetDateTime(5);
                }
                PhieuMuonSachDAO pms = new PhieuMuonSachDAO();
                pms.MaPhieuMuon = idphieu;
                pms.TenNguoiMuonSach = tennguoimuon;
                pms.TenSach = tensach;
                pms.NgayMuon = ngaymuon;
                pms.NgayDuKienTra = ngaydukientra;
                pms.NgayTraSach = ngaytra;
                dsPhieuMuon.Add(pms);
            }
            reader.Close();
            CloseConnection();
            return dsPhieuMuon;
        }
        public bool ThemPhieuMuon(PhieuMuonSach pms)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into PhieuMuonSach(NguoiMuonSachId,SachId,NgayMuon,NgayDuKienTra,TrangThai) " +
                "values('"+pms.NguoiMuonSachId+"','"+pms.SachId+"','"+pms.NgayMuon+"','"+pms.NgayDuKienTra+ "',N'Chưa Trả Sách')" +
                " update Sach set TrangThai=N'Đang cho mượn' where Id='" + pms.SachId + "'";
            command.Connection = conn;
            int ketqua = command.ExecuteNonQuery();
            return ketqua > 0;
        }
        public bool DocGiaTaoPhieu(PhieuMuonSach pms)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into PhieuMuonSach(NguoiMuonSachId,SachId,NgayMuon,NgayDuKienTra,TrangThai) " +
                "values('" + pms.NguoiMuonSachId + "','" + pms.SachId + "','" + pms.NgayMuon + "','" + pms.NgayDuKienTra + "',N'Chờ duyệt')" +
                " update Sach set TrangThai=N'Đang cho mượn' where Id='" + pms.SachId + "'";
            command.Connection = conn;
            int ketqua = command.ExecuteNonQuery();
            return ketqua > 0;
        }
        public bool DongPhieuMuon(PhieuMuonSach pms)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Update PhieuMuonSach set NgayTraSach='"+pms.NgayTraSach+"' ,TrangThai=N'Đã Trả Sách' where PhieuId='"+pms.MaPhieuMuon  + "'";
            command.Connection = conn;
            int ketqua = command.ExecuteNonQuery();
            return ketqua > 0;
        }


        public List<PhieuMuonSachDAO> TimPhieuTheoMa(PhieuMuonSachDAO pms)
        {
            List<PhieuMuonSachDAO> dsPhieuMuon = new List<PhieuMuonSachDAO>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "EXEC TimMaPhieu @maphieu ='" + pms.MaPhieuMuon+"'";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int idphieu = reader.GetInt32(0);
                string tennguoimuon = reader.GetString(1);
                string tensach = reader.GetString(2);
                DateTime ngaymuon = reader.GetDateTime(3);
                DateTime ngaydukientra = reader.GetDateTime(4);
                DateTime? ngaytra;
                if (reader.IsDBNull(5))
                {
                    ngaytra = (DateTime?)null;
                }
                else
                {
                    ngaytra = reader.GetDateTime(5);
                }
                PhieuMuonSachDAO pmsdao = new PhieuMuonSachDAO();
                pmsdao.MaPhieuMuon = idphieu;
                pmsdao.TenNguoiMuonSach = tennguoimuon;
                pmsdao.TenSach = tensach;
                pmsdao.NgayMuon = ngaymuon;
                pmsdao.NgayDuKienTra = ngaydukientra;
                pmsdao.NgayTraSach = ngaytra;
                dsPhieuMuon.Add(pmsdao);
            }
            reader.Close();
            CloseConnection();
            return dsPhieuMuon;
        }
        public List<PhieuMuonSachDAO> TimPhieuTheoten(PhieuMuonSachDAO pms)
        {
            List<PhieuMuonSachDAO> dsPhieuMuon = new List<PhieuMuonSachDAO>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "EXEC TimPhieuTheoTen @ten =N'" + pms.TenNguoiMuonSach + "'";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int idphieu = reader.GetInt32(0);
                string tennguoimuon = reader.GetString(1);
                string tensach = reader.GetString(2);
                DateTime ngaymuon = reader.GetDateTime(3);
                DateTime ngaydukientra = reader.GetDateTime(4);
                DateTime? ngaytra;
                if (reader.IsDBNull(5))
                {
                    ngaytra = (DateTime?)null;
                }
                else
                {
                    ngaytra = reader.GetDateTime(5);
                }
                PhieuMuonSachDAO pmsdao = new PhieuMuonSachDAO();
                pmsdao.MaPhieuMuon = idphieu;
                pmsdao.TenNguoiMuonSach = tennguoimuon;
                pmsdao.TenSach = tensach;
                pmsdao.NgayMuon = ngaymuon;
                pmsdao.NgayDuKienTra = ngaydukientra;
                pmsdao.NgayTraSach = ngaytra;
                dsPhieuMuon.Add(pmsdao);
            }
            reader.Close();
            CloseConnection();
            return dsPhieuMuon;
        }
        public List<PhieuMuonSachDAO> LayPhieuDangMo()
        {
            List<PhieuMuonSachDAO> dsPhieuMuon = new List<PhieuMuonSachDAO>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT pms.PhieuId,nms.HoTen,s.TenSach,pms.NgayMuon,pms.NgayDuKienTra,pms.NgayTraSach " +
                "FROM PhieuMuonSach pms, NguoiMuonSach nms, Sach s WHERE pms.NguoiMuonSachId = nms.Id and pms.SachID = s.ID " +
                "and pms.NgayTraSach is null  ORDER BY pms.PhieuId DESC";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int idphieu = reader.GetInt32(0);
                string tennguoimuon = reader.GetString(1);
                string tensach = reader.GetString(2);
                DateTime ngaymuon = reader.GetDateTime(3);
                DateTime ngaydukientra = reader.GetDateTime(4);
                DateTime? ngaytra;
                if (reader.IsDBNull(5))
                {
                    ngaytra = (DateTime?)null;
                }
                else
                {
                    ngaytra = reader.GetDateTime(5);
                }
                PhieuMuonSachDAO pms = new PhieuMuonSachDAO();
                pms.MaPhieuMuon = idphieu;
                pms.TenNguoiMuonSach = tennguoimuon;
                pms.TenSach = tensach;
                pms.NgayMuon = ngaymuon;
                pms.NgayDuKienTra = ngaydukientra;
                pms.NgayTraSach = ngaytra;
                dsPhieuMuon.Add(pms);
            }
            reader.Close();
            CloseConnection();
            return dsPhieuMuon;
        }
        public List<PhieuMuonSachDAO> LayPhieuDaDong()
        {
            List<PhieuMuonSachDAO> dsPhieuMuon = new List<PhieuMuonSachDAO>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT pms.PhieuId,nms.HoTen,s.TenSach,pms.NgayMuon,pms.NgayDuKienTra,pms.NgayTraSach " +
                "FROM PhieuMuonSach pms, NguoiMuonSach nms, Sach s WHERE pms.NguoiMuonSachId = nms.Id and pms.SachID = s.ID " +
                "and pms.NgayTraSach is not null  ORDER BY pms.PhieuId DESC";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int idphieu = reader.GetInt32(0);
                string tennguoimuon = reader.GetString(1);
                string tensach = reader.GetString(2);
                DateTime ngaymuon = reader.GetDateTime(3);
                DateTime ngaydukientra = reader.GetDateTime(4);
                DateTime? ngaytra;
                if (reader.IsDBNull(5))
                {
                    ngaytra = (DateTime?)null;
                }
                else
                {
                    ngaytra = reader.GetDateTime(5);
                }
                PhieuMuonSachDAO pms = new PhieuMuonSachDAO();
                pms.MaPhieuMuon = idphieu;
                pms.TenNguoiMuonSach = tennguoimuon;
                pms.TenSach = tensach;
                pms.NgayMuon = ngaymuon;
                pms.NgayDuKienTra = ngaydukientra;
                pms.NgayTraSach = ngaytra;
                dsPhieuMuon.Add(pms);
            }
            reader.Close();
            CloseConnection();
            return dsPhieuMuon;
        }
        public List<PhieuMuonSachDAO> TimPhieuTheoNgay(PhieuMuonSachDAO pms)
        {
            List<PhieuMuonSachDAO> dsPhieuMuon = new List<PhieuMuonSachDAO>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "exec TimPhieuTheoNgay @ngay='"+pms.ngay+ "'," +
                " @thang='" + pms.thang + "', " +
                "@nam='" + pms.nam + "'";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int idphieu = reader.GetInt32(0);
                string tennguoimuon = reader.GetString(1);
                string tensach = reader.GetString(2);
                DateTime ngaymuon = reader.GetDateTime(3);
                DateTime ngaydukientra = reader.GetDateTime(4);
                DateTime? ngaytra;
                if (reader.IsDBNull(5))
                {
                    ngaytra = (DateTime?)null;
                }
                else
                {
                    ngaytra = reader.GetDateTime(5);
                }
                PhieuMuonSachDAO timpms = new PhieuMuonSachDAO();
                timpms.MaPhieuMuon = idphieu;
                timpms.TenNguoiMuonSach = tennguoimuon;
                timpms.TenSach = tensach;
                timpms.NgayMuon = ngaymuon;
                timpms.NgayDuKienTra = ngaydukientra;
                timpms.NgayTraSach = ngaytra;
                dsPhieuMuon.Add(timpms);
            }
            reader.Close();
            CloseConnection();
            return dsPhieuMuon;
        }
        public List<PhieuMuonSachDAO> TimPhieuChuaDongTheoTen(PhieuMuonSachDAO pmss)
        {
            List<PhieuMuonSachDAO> dsPhieuMuon = new List<PhieuMuonSachDAO>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "  select pms.PhieuId,pms.NgayMuon,pms.NgayDuKienTra,pms.NgayTraSach " +
                "from PhieuMuonSach pms,Sach s,NguoiMuonSach nms " +
                "where pms.SachId=s.Id and pms.NguoiMuonSachId=nms.Id and nms.HoTen=N'" + pmss.TenNguoiMuonSach+"' " +
                "and pms.NgayTraSach is null";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int idphieu = reader.GetInt32(0);
                DateTime ngaymuon = reader.GetDateTime(1);
                DateTime ngaydukientra = reader.GetDateTime(2);
                DateTime? ngaytra;
                if (reader.IsDBNull(3))
                {
                    ngaytra = (DateTime?)null;
                }
                else
                {
                    ngaytra = reader.GetDateTime(3);
                }
                PhieuMuonSachDAO pms = new PhieuMuonSachDAO();
                pms.MaPhieuMuon = idphieu;
                pms.NgayMuon = ngaymuon;
                pms.NgayDuKienTra = ngaydukientra;
                pms.NgayTraSach = ngaytra;
                dsPhieuMuon.Add(pms);
            }
            reader.Close();
            CloseConnection();
            return dsPhieuMuon;
        }


        public List<PhieuMuonSachDAO> LayPhieuMuonChoDuyet()
        {
            List<PhieuMuonSachDAO> dsPhieuMuon = new List<PhieuMuonSachDAO>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select pms.PhieuId, nms.HoTen,s.TenSach,pms.NgayMuon,pms.NgayDuKienTra,pms.NgayTraSach,pms.TrangThai " +
                "from PhieuMuonSach pms, NguoiMuonSach nms,Sach s " +
                "where nms.Id = pms.NguoiMuonSachId and s.Id = pms.SachId and pms.TrangThai = N'Chờ duyệt'";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int idphieu = reader.GetInt32(0);
                string tennguoimuon = reader.GetString(1);
                string tensach = reader.GetString(2);
                DateTime ngaymuon = reader.GetDateTime(3);
                DateTime ngaydukientra = reader.GetDateTime(4);
                DateTime? ngaytra;
                if (reader.IsDBNull(5))
                {
                    ngaytra = (DateTime?)null;
                }
                else
                {
                    ngaytra = reader.GetDateTime(5);
                }
                string trangthai = reader.GetString(6);
                PhieuMuonSachDAO pms = new PhieuMuonSachDAO();
                pms.MaPhieuMuon = idphieu;
                pms.TenNguoiMuonSach = tennguoimuon;
                pms.TenSach = tensach;
                pms.NgayMuon = ngaymuon;
                pms.NgayDuKienTra = ngaydukientra;
                pms.NgayTraSach = ngaytra;
                pms.TrangThai = trangthai;
                dsPhieuMuon.Add(pms);
            }
            reader.Close();
            CloseConnection();
            return dsPhieuMuon;
        }
    }
}
