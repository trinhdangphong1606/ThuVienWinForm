using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuMuonSach
    {
        public int MaPhieuMuon { get; set; }
        public int NguoiMuonSachId { get; set; }
        public int SachId { get; set; }
        
        public DateTime NgayMuon { get; set; }
        public DateTime NgayDuKienTra { get; set; }
        public DateTime NgayTraSach { get; set; }
        
    }
}
