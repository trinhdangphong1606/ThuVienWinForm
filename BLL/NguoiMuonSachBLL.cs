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
    public class NguoiMuonSachBLL
    {
        NguoiMuonSachAccess nguoimuons = new NguoiMuonSachAccess();
        public List<NguoiMuonSach> LayToanBoNguoiMuonSach()
        {
            return nguoimuons.LayToanBoNguoiMuonSach();
        }
        public bool CapNhatDocGia(NguoiMuonSach CapNhatDG)
        {
            return nguoimuons.CapNhatDocGia(CapNhatDG);
        }
        public bool ThemDocGia(NguoiMuonSach ThemDG)
        {
            return nguoimuons.ThemDocGia(ThemDG);
        }
        public List<NguoiMuonSach> TimTenNguoiMuon(NguoiMuonSach timten)
        {
            return nguoimuons.TimTenNguoiMuon(timten);
        }
    }
}
