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
        public List<SachDAO> LayToanBoSach()
        {

            return sac.LayToanBoSach();
        }

        public List<SachDAO> TimTenSach(SachDAO TimTenSach)
        {
            return sac.TimTenSach(TimTenSach);
        }
    }
}
