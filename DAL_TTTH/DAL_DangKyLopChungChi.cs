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
    public class DAL_DangKyLopChungChi
    {
        public static List<DTO_DangKyLopChungChi> getRegisterCerti()
        {
            List<DTO_DangKyLopChungChi> Registers = new List<DTO_DangKyLopChungChi>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DangKyLopChungChi", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                string id_Student = row["MaHV"].ToString();
                string id_Class = row["MaLCC"].ToString();
                string id_Course = row["MaKhoa"].ToString();
                string fee = row["HocPhi"].ToString();
                string point = row["DiemThi"].ToString();
                string examDate = row["NgayThi"].ToString();
                examDate = examDate.Substring(0, examDate.IndexOf(" "));
                DTO_DangKyLopChungChi register = new DTO_DangKyLopChungChi(id_Student, id_Class, id_Course, fee, point, examDate);
                Registers.Add(register);
            }
            return Registers;
        }

        public static void updatePoint(DTO_BangDiemHV table)
        {
            SqlDataAdapter da = new SqlDataAdapter("update DangKyLopChungChi set DiemThi = " + table.Point + " where MaHV = '" + table.ID_Student + "' and MaLCC = '" + table.ID_Class + "' and MaKhoa = '" + table.ID_Course, DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }


        public static void addStudent(string id_student, DTO_LopCCMo LCCM)
        {
            SqlDataAdapter da = new SqlDataAdapter("INSERT INTO DangKyLopChungChi VALUES('"+id_student+"','"+LCCM.ID+"','"+LCCM.ID_Course+"', NULL, NULL, '')", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }
    }
}
