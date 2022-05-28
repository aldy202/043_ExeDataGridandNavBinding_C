using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Exerices
{
    class connect
    {
        public SqlConnection Getconn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source=MEGANE\\ALDYAHMADFAUZI;Initial Catalog=login;Persist Security Info=True;User ID=sa;Password=Kacamatahitam4321";
            return Conn;
        }
    }
}
