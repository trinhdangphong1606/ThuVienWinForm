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
        SachAccessAll sac = new SachAccessAll();
        public List<Sach> LayAllToanBoSach()
        {
            
            return sac.LayAllToanBoSach();
        }
    }
}
