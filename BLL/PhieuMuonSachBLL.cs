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
    }
}
