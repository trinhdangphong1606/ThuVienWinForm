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
        public bool DongPhieuMuon(PhieuMuonSach closephieu)
        {
            return phieums.DongPhieuMuon(closephieu);
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
    }
}
