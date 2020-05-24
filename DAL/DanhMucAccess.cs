using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using DAL.DAO;
using DTO;
using System.IO;

namespace DAL
{
    public class DanhMucAccess : DatabaseAccess
    {
        public List<DanhMuc> LayToanBoDanhMuc()
        {
            List<DanhMuc> dsDanhMuc = new List<DanhMuc>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from DanhMuc";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string tendanhmuc = reader.GetString(1);
                string noidungdanhmuc = reader.GetString(2);

                DanhMuc dm = new DanhMuc();

                dm.TenDanhMuc = tendanhmuc;
                dm.NoiDungDanhMuc = noidungdanhmuc;

                dsDanhMuc.Add(dm);
            }
            reader.Close();
            return dsDanhMuc;
        }
    }
}
