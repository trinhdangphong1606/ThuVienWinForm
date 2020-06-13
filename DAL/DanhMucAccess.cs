using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
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
                dm.IdDanhMuc = id;
                dm.TenDanhMuc = tendanhmuc;
                dm.NoiDungDanhMuc = noidungdanhmuc;

                dsDanhMuc.Add(dm);
            }
            reader.Close();
            CloseConnection();
            return dsDanhMuc;

        }

        public bool InsertDanhMuc(string TenDanhMuc, string NoiDungDanhMuc)
        {
            OpenConnection();
            string query = string.Format("INSERT INTO dbo.DanhMuc (TenDanhMuc,NoiDungDanhMuc) VALUES (N'{0}',N'{1}')", TenDanhMuc, NoiDungDanhMuc);
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            int result = command.ExecuteNonQuery();

            if (result > 0)
            {
                return true;
            }

            return false;
        }
        public bool CapNhatDanhMuc (DanhMuc dm)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Update DanhMuc set TenDanhMuc =N'" + dm.TenDanhMuc + "', NoiDungDanhMuc  =N'" + dm.NoiDungDanhMuc + "' where IdDanhMuc ='" + dm.IdDanhMuc + "'";
            command.Connection = conn;
            int ketqua = command.ExecuteNonQuery();
            return true;
        }
    }
}
