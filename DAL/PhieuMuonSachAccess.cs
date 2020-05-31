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
            command.CommandText = "SELECT pms.PhieuId,nms.HoTen,s.TenSach,pms.NgayMuon,pms.NgayDuKienTra,pms.NgayTraSach FROM PhieuMuonSach pms, NguoiMuonSach nms, Sach s WHERE pms.NguoiMuonSachId = nms.Id and pms.SachID = s.ID";
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
                //DateTime? ngaytra = !reader.IsDBNull(5) ? reader.GetDateTime(5) : (DateTime?) null;
                if(!reader.IsDBNull(5))
                {
                    ngaytra = reader.GetDateTime(5);
                }
                else
                {
                    ngaytra= (DateTime?)null;
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
            command.CommandText = "insert into PhieuMuonSach(NguoiMuonSachId,SachId,NgayMuon,NgayDuKienTra) values('"+pms.NguoiMuonSachId+"','"+pms.SachId+"','"+pms.NgayMuon+"','"+pms.NgayDuKienTra+"')";
            command.Connection = conn;
            int ketqua = command.ExecuteNonQuery();
            return true;
        }

    }
}
