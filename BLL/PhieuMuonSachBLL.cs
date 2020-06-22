using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;
using DTO;

namespace BLL
{
    public class PhieuMuonSachBLL
    {
        PhieuMuonSachAccess phieums = new PhieuMuonSachAccess();
        public List<PhieuMuonSachDAO> LayToanBoPhieuMuon()
        {
            return phieums.LayToanBoPhieuMuon();
        }
        public bool ThemPhieuMuon(PhieuMuonSach newphieu)
        {
            return phieums.ThemPhieuMuon(newphieu);
        }
        public bool DocGiaTaoPhieu(PhieuMuonSach newphieu)
        {
            return phieums.DocGiaTaoPhieu(newphieu);
        }
        public bool DongPhieuMuon(PhieuMuonSach closephieu)
        {
            return phieums.DongPhieuMuon(closephieu);
        }

        public List<PhieuMuonSachDAO> TimPhieuChuaDongTheoTen(PhieuMuonSachDAO timphieumo)
        {
            return phieums.TimPhieuChuaDongTheoTen(timphieumo);
        }
        public List<PhieuMuonSachDAO> TimPhieuTheoMa(PhieuMuonSachDAO timmaphieu)
        {
            return phieums.TimPhieuTheoMa(timmaphieu);
        }
        public List<PhieuMuonSachDAO> TimPhieuTheoten(PhieuMuonSachDAO timtenphieu)
        {
            return phieums.TimPhieuTheoten(timtenphieu);
        }
        public List<PhieuMuonSachDAO> LayPhieuDangMo()
        {
            return phieums.LayPhieuDangMo();
        }
        public List<PhieuMuonSachDAO> LayPhieuDaDong()
        {
            return phieums.LayPhieuDaDong();
        }
        public List<PhieuMuonSachDAO> TimphieuTheoNgay(PhieuMuonSachDAO timngayphieu)
        {
            return phieums.TimPhieuTheoNgay(timngayphieu);
        }
        public List<PhieuMuonSachDAO> LayPhieuMuonChoDuyet()
        {
            return phieums.LayPhieuMuonChoDuyet();
        }
        public bool ChapThuanPhieuDuyet(PhieuMuonSach chapthuan)
        {
            return phieums.ChapThuanPhieuDuyet(chapthuan);
        }
        public bool TuChoiPhieuDuyet(PhieuMuonSach tuchoi)
        {
            return phieums.TuChoiPhieuDuyet(tuchoi);
        }
        public List<PhieuMuonSachDAO> LayPhieuMuonChoDocGia()
        {
            return phieums.LayPhieuMuonChoDocGia();
        }
        public bool ChapThuanPhieuChoMuon(PhieuMuonSach chapthuan)
        {
            return phieums.ChapThuanPhieuChoMuon(chapthuan);
        }
        public bool TuChoiPhieuChoMuon(PhieuMuonSach tuchoi)
        {
            return phieums.TuChoiPhieuChoMuon(tuchoi);
        }
    }
}
