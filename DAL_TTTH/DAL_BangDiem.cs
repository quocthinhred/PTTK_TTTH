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
    public class DAL_BangDiem
    {
        public static List<DTO_BangDiem> getPointTable()
        {
            List<DTO_BangDiem> Tables = new List<DTO_BangDiem>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BANGDIEM", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
                string id_Student = row["MaHV"].ToString();
                string id_Subject = row["MaMon"].ToString();
                string id_Course = row["MaKhoa"].ToString();
                string examCount = row["LanThi"].ToString();
                string point = row["DiemThi"].ToString();
                string examDate = row["NgayThi"].ToString();
                DTO_BangDiem table = new DTO_BangDiem(id_Student, id_Subject, id_Course, examCount, point, examDate);
                Tables.Add(table);
            }
            return Tables;
        }
    }
}
