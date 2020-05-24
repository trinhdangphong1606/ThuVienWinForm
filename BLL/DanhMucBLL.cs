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
        DanhMucAccess damuc = new DanhMucAccess();
        public List<DanhMuc> LayToanBoDanhMuc()
        {

            return damuc.LayToanBoDanhMuc();
        }
    }
}
