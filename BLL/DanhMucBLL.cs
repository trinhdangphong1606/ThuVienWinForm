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
    public class DanhMucBLL
    {
        DanhMucAccess access = new DanhMucAccess();
        public List<DanhMuc> LayToanBoDanhMuc()
        {
            return access.LayToanBoDanhMuc();
        }

        public bool InsertDanhMuc(string TenDanhMuc, string NoiDungDanhMuc)
        {
            return access.InsertDanhMuc(TenDanhMuc, NoiDungDanhMuc);
        }
        public bool CapNhatDanhMuc(DanhMuc CapNhatDM)
        {
            return access.CapNhatDanhMuc(CapNhatDM);
        }
    }
}
