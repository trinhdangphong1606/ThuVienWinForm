﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class PhieuMuonSachDAO
    {
        public int MaPhieuMuon { get; set; }
        public string TenNguoiMuonSach { get; set; }
        public string TenSach { get; set; }
        
        public DateTime NgayMuon { get; set; }
        public DateTime NgayDuKienTra { get; set; }
        public Nullable<DateTime> NgayTraSach { get; set; }

    }
}