using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TTTH;
using System.Data;
using System.Data.SqlClient;

namespace DAL_TTTH
{
    public class DAL_NHPMo
    {
        public static List<DTO_NHPMo> getListNHPM()
        {
            List<DTO_NHPMo> L_NHPM = new List<DTO_NHPMo>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhomHocPhanMo NHPM,NhomHocPhan NHP where NHP.MaNHP = NHPM.MaNHP", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
                string id = row["MaNHP"].ToString();
                string id_Course = row["MaKhoa"].ToString();
                string name = row["TenNHP"].ToString();
                string isFull = row["isFull"].ToString();
                DTO_NHPMo NHPM = new DTO_NHPMo(id, name, id_Course, isFull);    
                L_NHPM.Add(NHPM);
            }
            return L_NHPM;
        }

        public static void addNHPM(DTO_NhomHocPhan NHP, DTO_Khoa course)
        {
            SqlDataAdapter da = new SqlDataAdapter("INSERT INTO NhomHocPhanMo VALUES('" + NHP.ID + "', '" + course.ID +"', '1')", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        public static void updateIsFull(DTO_NHPMo NHPM)
        {
            string sql = "";
            if (NHPM.IsFull == "0")
            {
                sql = "UPDATE NhomHocPhanMo SET isFull = 1 WHERE MaNHP = '" + NHPM.ID + "' and MaKhoa = '" + NHPM.ID_Course + "'";
            }
            else
            {
                sql = "UPDATE NhomHocPhanMo SET isFull = 0 WHERE MaNHP = '" + NHPM.ID + "' and MaKhoa = '" + NHPM.ID_Course + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }
    }
}
