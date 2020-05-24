using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuMuonSach
    {
        public int NguoiMuonSachID { get; set; }
        public int SachID { get; set; }
        public int QuanTriVienID { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayDuKienTra { get; set; }
        public DateTime NgayTraSach { get; set; }
        public string DiaChi { get; set; }
    }
}
