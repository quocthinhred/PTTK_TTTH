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
                examDate = examDate.Substring(0, examDate.IndexOf(" "));
                DTO_BangDiem table = new DTO_BangDiem(id_Student, id_Subject, id_Course, examCount, point, examDate);
                Tables.Add(table);
            }
            return Tables;
        }

        public static void updatePoint(DTO_BangDiemHV table)
        {
            SqlDataAdapter da = new SqlDataAdapter("update BANGDIEM set DiemThi = " + table.Point + " where MaHV = '" + table.ID_Student + "' and MaMon = '" + table.ID_Class + "' and MaKhoa = '" + table.ID_Course + "' and LanThi = " + table.ExamCount, DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }
    }
}
