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
    public class DAL_DangKyLopChuyenDe
    {
        public static int intFee;
        public static List<DTO_DangKyLopChuyenDe> getRegisterTheme()
        {
            List<DTO_DangKyLopChuyenDe> Registers = new List<DTO_DangKyLopChuyenDe>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DangKyLopChuyenDe", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
                string id_Student = row["MaHV"].ToString();
                string id_Class = row["MaLCD"].ToString();
                string id_Course = row["MaKhoa"].ToString();
                string fee = row["HocPhi"].ToString();
                DTO_DangKyLopChuyenDe register = new DTO_DangKyLopChuyenDe(id_Student, id_Class, id_Course, fee);
                Registers.Add(register);
            }
            return Registers;
        }



        public static void addStudent(string id_student, DTO_LopCDMo LCDM)
        {
            SqlDataAdapter da = new SqlDataAdapter("INSERT INTO DangKyLopChuyenDe VALUES('" + id_student + "','" + LCDM.ID + "','" + LCDM.ID_Course + "', NULL)", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }


        public static void getFee(string id_class)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LopChuyenDe WHERE MaLCD = '" + id_class + "'", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                string fee = row["HocPhi"].ToString();
                intFee = Int32.Parse(fee);
            }
        }

        public static void payFee(string id_student, string id_class, string id_course)
        {
            getFee(id_class);
            SqlDataAdapter da = new SqlDataAdapter("UPDATE DangKyLopChuyenDe SET HocPhi = " + intFee + " WHERE MaHV = '" + id_student + "' and MaLCD = '" + id_class + "' and MaKhoa = '" + id_course + "'", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }
    }
}
