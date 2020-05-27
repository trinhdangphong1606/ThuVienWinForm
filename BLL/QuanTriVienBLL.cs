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
    }
}
