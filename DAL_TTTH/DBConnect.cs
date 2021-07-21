using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_TTTH
{
    public class DBConnect
    {
        public static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UML28IP\\SQLEXPRESS01;Initial Catalog=TTTH;Integrated Security=True");
    }
}
