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
    public class DAL_DangKyNHP
    {
        public static int intFee;
        public static List<DTO_DangKyNHP> getList()
        {
            List<DTO_DangKyNHP> Lists = new List<DTO_DangKyNHP>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DangKyNhomHocPhan", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
                string id_student = row["MaHV"].ToString();
                string id_course = row["MaKhoa"].ToString();
                string id_NHP = row["MaNHP"].ToString();
                string point = row["DTB"].ToString();
                string examCount = row["SoLanThiLai"].ToString();
                string fee = row["HocPhi"].ToString();
                string result = row["KetQua"].ToString();
                DTO_DangKyNHP DKNHP = new DTO_DangKyNHP(id_student, id_NHP, id_course, point, fee, examCount, result);
                Lists.Add(DKNHP);
            }
            return Lists;
        }

        public static void addDKNHP(string id_student, DTO_NHPMo NHPM)
        {
            SqlDataAdapter da = new SqlDataAdapter("INSERT INTO DangKyNhomHocPhan VALUES('" + id_student + "','" + NHPM.ID + "','" + NHPM.ID_Course + "',NULL,0,0,NULL)", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        public static void getFee(string id_NHP)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhomHocPhan WHERE MaNHP = '"+id_NHP+"'", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            foreach (DataRow row in dt.Rows)
            {
                string fee = row["HocPhi"].ToString();
                intFee = Int32.Parse(fee);
            }
        }

        public static void payFee(string id_student, string id_NHP, string id_course)
        {
            getFee(id_NHP);
            SqlDataAdapter da = new SqlDataAdapter("UPDATE DangKyNhomHocPhan SET HocPhi = "+ intFee +" WHERE MaHV = '" + id_student + "' and MaNHP = '" + id_NHP + "' and MaKhoa = '" + id_course + "'", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }
    }
}
