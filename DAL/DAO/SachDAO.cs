﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class SachDAO
    {
        public int ID { get; set; }
        public string TenSach { get; set; }
        public int NamXuatBan { get; set; }
        public string TheLoai { get; set; }
        public string TacGia { get; set; }
        public string NgonNgu { get; set; }
        public string NoiDungSach { get; set; }
        public int SoLuong { get; set; }
        public string TrangThai { get; set; }
    }
}
