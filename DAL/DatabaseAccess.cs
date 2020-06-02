using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatabaseAccess
    {
        string strConn = "Data Source = DESKTOP-2ASN71L\\SQLEXPRESS ; Initial Catalog = QuanLyThuVien ; Integrated Security = True ";
        protected SqlConnection conn = null;

        public static object Instance { get; internal set; }

        public void OpenConnection()
        {
            if (conn == null)
                conn = new SqlConnection(strConn);

            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
