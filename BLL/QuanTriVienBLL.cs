using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class QuanTriVienBLL
    {
        QuanTriVienAccess qtvien = new QuanTriVienAccess();
        public List<QuanTriVien> LayToanBoQuanTriVien()
        {

            return qtvien.LayToanBoQuanTriVien();
        }
        public bool ThemQuanTriVien(QuanTriVien newqtv)
        {
            return qtvien.ThemQuanTriVien(newqtv);
        }
        public bool ChinhSuaQuanTriVien(QuanTriVien qtv)
        {
            return qtvien.ChinhSuaQuanTriVien(qtv);
        }
        public List<QuanTriVien> DangNhap(QuanTriVien qtv)
        {
            return qtvien.DangNhap(qtv);
        }
        public List<QuanTriVien> TimTenDangNhap(QuanTriVien qtv)
        {
            return qtvien.TimTenDangNhap(qtv);
        }
        
        public bool DangKy(QuanTriVien qtv)
        {
            return qtvien.DangKy(qtv);
        }
        public bool RestoreMatKhau(QuanTriVien qtv)
        {
            return qtvien.RestoreMatKhau(qtv);
        }
        public bool ResetMatKhau(QuanTriVien qtv)
        {
            return qtvien.ResetMatKhau(qtv);
        }
        public List<QuanTriVien> LayThongTinCaNhan(QuanTriVien qtv)
        {
            return qtvien.LayThongTinCaNhan(qtv);
        }
        public List<QuanTriVien> KiemTraKey(QuanTriVien qtv)
        {
            return qtvien.KiemTraKey(qtv);
        }
        public bool DoiKeyRestore(QuanTriVien qtv)
        {
            return qtvien.DoiKeyRestore(qtv);
        }
        public List<QuanTriVien> TimTenQTV(QuanTriVien qtv)
        {
            return qtvien.TimTenQTV(qtv);
        }
        public List<QuanTriVien> TimQTVTheoQuyen(QuanTriVien qtv)
        {
            return qtvien.TimQTVTheoQuyen(qtv);
        }
        
        public List<QuanTriVien> TimTenQTVTheoMa(QuanTriVien qtv)
        {
            return qtvien.TimTenQTVTheoMa(qtv);
        }
        public bool DoiThongTinCaNhan(QuanTriVien qtv)
        {
            return qtvien.DoiThongTinCaNhan(qtv);
        }
        
    }
}
