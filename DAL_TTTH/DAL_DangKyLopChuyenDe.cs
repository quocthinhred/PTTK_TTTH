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
    }
}
