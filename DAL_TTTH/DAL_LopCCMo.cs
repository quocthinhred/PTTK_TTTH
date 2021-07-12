using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TTTH;
using System.Data.SqlClient;

namespace DAL_TTTH
{
    public class DAL_LopCCMo
    {
        public static List<DTO_LopCCMo> getDSLopCCMo()
        {
            List<DTO_LopCCMo> DSLopCCMo = new List<DTO_LopCCMo>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LopChungChi LCC, LopChungChiMo LCCM WHERE LCC.MaLCC = LCCM.MaLCC", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                string id = row["MaLCC"].ToString();
                string name = row["TenLCC"].ToString() ;
                string id_Course = row["MaKhoa"].ToString();
                string id_Teacher = row["MaGV"].ToString();
                string schedule = row["LichHoc"].ToString();
                string isFull = row["isFull"].ToString();
                DTO_LopCCMo lop = new DTO_LopCCMo(id, name, id_Course, id_Teacher, schedule, isFull);
                DSLopCCMo.Add(lop);
            }
            return DSLopCCMo;
        }

        public static void updateIsFull(DTO_LopCCMo LCCM)
        {
            string sql;
            if (LCCM.IsFull == "0")
            {
                sql = "UPDATE LopChungChiMo SET isFull = 1 WHERE MaLCC = '"+LCCM.ID+"' and MaKhoa = '"+LCCM.ID_Course+"'";
            }
            else
            {
                sql = "UPDATE LopChungChiMo SET isFull = 0 WHERE MaLCC = '" + LCCM.ID + "' and MaKhoa = '" + LCCM.ID_Course + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        public static void addLCC(DTO_LopCCMo LCCM)
        {
            SqlDataAdapter da = new SqlDataAdapter("INSERT INTO LopChungChiMo VALUES('" + LCCM.ID + "','" + LCCM.ID_Course + "','" + LCCM.Schedule + "','" + LCCM.ID_Teacher + "',1)", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }
    }
}
