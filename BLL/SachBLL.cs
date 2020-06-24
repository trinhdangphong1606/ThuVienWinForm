using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using DAL.DAO;
namespace BLL
{
    public class SachBLL
    {
        SachAccess sac = new SachAccess();
        public List<Sach> LayAllToanBoSach()
        {
            
            return sac.LayAllToanBoSach();
        }
        public List<Sach> LayAllToanBoSachTrong()
        {

            return sac.LayAllToanBoSachTrong();
        } //trả về dữ liệu không cần đầu vào
        public bool CapNhatPhieuMuon(Sach trangthai)
        {
            return sac.CapNhatPhieuMuon(trangthai);
        }
        
        public List<SachDAO> LayToanBoSach()
        {

            return sac.LayToanBoSach();
        }
        public List<SachDAO> LayToanBoSachTrong()
        {

            return sac.LayToanBoSachTrong();
        }
        public List<SachDAO> LayToanBoSachOderTrong()
        {

            return sac.LayToanBoSachOderTrong();
        }
        

        public List<SachDAO> TimTenSach(SachDAO TenSach)
        {
            return sac.TimTenSach(TenSach);
        } // trả về dữ liệu cần đầu vào
        public List<SachDAO> TimSachTrongTheoTen(SachDAO timsach)
        {
            return sac.TimSachTrongTheoTen(timsach);
        }    
        public List<Sach> TimMaSach(Sach sc)
        {
            return sac.TimMaSach(sc);
        }
        public bool ThemSach(Sach Thems)
        {
            return sac.ThemSach(Thems);
        }
        public bool SuaSach(Sach Suas)
        {
            return sac.SuaSach(Suas);
        }
        public bool CapNhatTrangThaiLoi(Sach SachLoi)
        {
            return sac.CapNhatTrangThaiLoi(SachLoi);
        }
        public bool CapNhatDocGiaKhongDen(Sach travetrong) // update hoặc thêm dòng dữ liệu, cần đầu vào
        {
            return sac.CapNhatDocGiaKhongDen(travetrong);
        }
        public bool CapNhatDaSuaLoiSach(Sach SachOK)
        {
            return sac.CapNhatDaSuaLoiSach(SachOK);
        }
        
        public List<SachDAO> TimSachTheoDanhMuc(SachDAO TenDM)
        {
            return sac.TimSachTheoDanhMuc(TenDM);
        }


    }
}
