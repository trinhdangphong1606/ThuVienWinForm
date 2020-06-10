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
        public bool DangKy(QuanTriVien qtv)
        {
            return qtvien.DangKy(qtv);
        }
    }
}
