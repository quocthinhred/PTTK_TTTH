using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_TTTH;

namespace DAL_TTTH
{
    public class DAL_NhomHocPhan
    {
        public static List<DTO_NhomHocPhan> getAllNHP()
        {
            List<DTO_NhomHocPhan> AllNHP = new List<DTO_NhomHocPhan>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhomHocPhan", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                string name_NHP = row["TenNHP"].ToString();
                string id_NHP = row["MaNHP"].ToString();
                string fee = row["HocPhi"].ToString();
                DTO_NhomHocPhan NHP = new DTO_NhomHocPhan(id_NHP, name_NHP, fee);
                AllNHP.Add(NHP);
            }
            return AllNHP;
        }
    }
}
