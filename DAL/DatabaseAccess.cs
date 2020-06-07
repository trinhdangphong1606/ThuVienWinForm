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
        string strConn = "Server=localhost;Database=test;User id=adminphongtd;pwd=Phong123@";
        protected SqlConnection conn = null;

        public static object Instance { get; internal set; }

        public void OpenConnection()
        {
            if (conn == null)
                //Nếu đối tượng connection = null thì ta tạo connection
                conn = new SqlConnection(strConn);
            
            if (conn.State == ConnectionState.Closed)
                //Nếu connection đang trạng thái close thì mở 
                conn.Open();
        }
        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
