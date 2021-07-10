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
    }
}
